# ----------------------------------------------------------------------------------
# Copyright Microsoft Corporation - Licensed under the Apache License, Version 2.0
# ----------------------------------------------------------------------------------

function Set-DefaultEntraXTAP {
    [OutputType([Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationDefault])]
    [CmdletBinding(DefaultParameterSetName = 'Expanded',
                   PositionalBinding = $false, SupportsShouldProcess, ConfirmImpact = 'Medium')]
    param(

        [Parameter(ParameterSetName = 'Expanded')]
        [ValidateSet('Allowed', 'Blocked')]
        [System.String]
        ${M365CollaborationInbound},

        [Parameter(ParameterSetName = 'Expanded')]
        [System.String[]]
        ${M365CollaborationInboundTargetUsers},

        [Parameter(ParameterSetName = 'Expanded')]
        [ValidateSet('Allowed', 'Blocked')]
        [System.String]
        ${M365CollaborationOutbound},

        [Parameter(ParameterSetName = 'Expanded')]
        [System.String[]]
        ${M365CollaborationOutboundTargetUsers},

        [Parameter(ParameterSetName = 'Expanded')]
        [System.String[]]
        ${M365CollaborationOutboundTargetGroups},

        [Parameter(ParameterSetName = 'Expanded')]
        [ValidateSet('Allowed', 'Blocked')]
        [System.String]
        ${AppServiceConnectInbound},

        [Parameter(ParameterSetName = 'Expanded')]
        [System.String[]]
        ${AppServiceConnectInboundTargetApplications},

        [Parameter(DontShow)] [Microsoft.Graph.Beta.PowerShell.Category('Runtime')] [System.Management.Automation.SwitchParameter] ${Break},
        [Parameter(DontShow)] [ValidateNotNull()] [Microsoft.Graph.Beta.PowerShell.Category('Runtime')] [Microsoft.Graph.Beta.PowerShell.Runtime.SendAsyncStep[]] ${HttpPipelineAppend},
        [Parameter(DontShow)] [ValidateNotNull()] [Microsoft.Graph.Beta.PowerShell.Category('Runtime')] [Microsoft.Graph.Beta.PowerShell.Runtime.SendAsyncStep[]] ${HttpPipelinePrepend},
        [Parameter(DontShow)] [Microsoft.Graph.Beta.PowerShell.Category('Runtime')] [System.Uri] ${Proxy},
        [Parameter(DontShow)] [ValidateNotNull()] [Microsoft.Graph.Beta.PowerShell.Category('Runtime')] [System.Management.Automation.PSCredential] ${ProxyCredential},
        [Parameter(DontShow)] [Microsoft.Graph.Beta.PowerShell.Category('Runtime')] [System.Management.Automation.SwitchParameter] ${ProxyUseDefaultCredentials}
    )

    begin {}

    process {
        function Build-TargetConfiguration {
            param([string]$AccessType, [string[]]$Ids, [string]$TargetType)
            if ([string]::IsNullOrEmpty($AccessType) -or $null -eq $Ids -or $Ids.Count -eq 0) { return $null }
            $targets = @()
            foreach ($id in $Ids) {
                $t = New-Object Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyTarget
                $t.Target = $id.Trim(); $t.TargetType = $TargetType; $targets += $t
            }
            $config = New-Object Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyTargetConfiguration
            $config.AccessType = $AccessType.ToLower(); $config.Targets = $targets
            return $config
        }

        foreach ($key in @('M365CollaborationInbound', 'M365CollaborationInboundTargetUsers', 'M365CollaborationOutbound', 'M365CollaborationOutboundTargetUsers', 'M365CollaborationOutboundTargetGroups', 'AppServiceConnectInbound', 'AppServiceConnectInboundTargetApplications')) { $null = $PSBoundParameters.Remove($key) }

        if (-not $M365CollaborationInbound -and -not $M365CollaborationOutbound -and -not $AppServiceConnectInbound) {
            throw 'At least one of -M365CollaborationInbound, -M365CollaborationOutbound, or -AppServiceConnectInbound must be specified.'
        }
        if ($M365CollaborationInbound -and (-not $M365CollaborationInboundTargetUsers -or $M365CollaborationInboundTargetUsers.Count -eq 0)) {
            throw '-M365CollaborationInboundTargetUsers is required when -M365CollaborationInbound is specified.'
        }
        if ($M365CollaborationOutbound -and
            (-not $M365CollaborationOutboundTargetUsers  -or $M365CollaborationOutboundTargetUsers.Count  -eq 0) -and
            (-not $M365CollaborationOutboundTargetGroups -or $M365CollaborationOutboundTargetGroups.Count -eq 0)) {
            throw 'At least one of -M365CollaborationOutboundTargetUsers or -M365CollaborationOutboundTargetGroups is required when -M365CollaborationOutbound is specified.'
        }
        if ($AppServiceConnectInbound -and (-not $AppServiceConnectInboundTargetApplications -or $AppServiceConnectInboundTargetApplications.Count -eq 0)) {
            throw '-AppServiceConnectInboundTargetApplications is required when -AppServiceConnectInbound is specified.'
        }

        $inboundUserConfig = Build-TargetConfiguration -AccessType $M365CollaborationInbound -Ids $M365CollaborationInboundTargetUsers -TargetType 'user'

        $outboundConfig = $null
        if ($M365CollaborationOutbound) {
            $userConfig  = Build-TargetConfiguration -AccessType $M365CollaborationOutbound -Ids $M365CollaborationOutboundTargetUsers  -TargetType 'user'
            $groupConfig = Build-TargetConfiguration -AccessType $M365CollaborationOutbound -Ids $M365CollaborationOutboundTargetGroups -TargetType 'group'
            $mergedTargets = @()
            if ($null -ne $userConfig)  { $mergedTargets += $userConfig.Targets  }
            if ($null -ne $groupConfig) { $mergedTargets += $groupConfig.Targets }
            $outboundConfig            = New-Object Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyTargetConfiguration
            $outboundConfig.AccessType = $M365CollaborationOutbound.ToLower()
            $outboundConfig.Targets    = [Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyTarget[]]$mergedTargets
        }

        $appServiceConnect = $null
        if ($AppServiceConnectInbound) {
            $appConfig = Build-TargetConfiguration -AccessType $AppServiceConnectInbound -Ids $AppServiceConnectInboundTargetApplications -TargetType 'application'
            $appServiceConnect = New-Object Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyAppServiceConnectSetting
            $appServiceConnect.Applications = $appConfig
        }

        $m365Inbound  = $null; $m365Outbound = $null
        if ($null -ne $inboundUserConfig) { $m365Inbound = New-Object Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyM365CollaborationInboundSetting;  $m365Inbound.Users          = $inboundUserConfig }
        if ($null -ne $outboundConfig)    { $m365Outbound = New-Object Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphCrossTenantAccessPolicyM365CollaborationOutboundSetting; $m365Outbound.UsersAndGroups = $outboundConfig    }

        if ($PSCmdlet.ShouldProcess('Default XTAP Configuration', 'Set-DefaultEntraXTAP')) {
            $splat = @{}
            if ($null -ne $m365Inbound)       { $splat['M365CollaborationInbound']  = $m365Inbound       }
            if ($null -ne $m365Outbound)      { $splat['M365CollaborationOutbound'] = $m365Outbound      }
            if ($null -ne $appServiceConnect) { $splat['AppServiceConnectInbound']  = $appServiceConnect }
            $result = Update-MgBetaPolicyCrossTenantAccessPolicyDefault @splat @PSBoundParameters
            if ($null -ne $result) { ConvertTo-EntraXTAPFlatOutput -Result $result }
        }
    }

    end {}
}