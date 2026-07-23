# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
    Updates an existing Microsoft 365 capability entry on the default Cross-Tenant
    Access Policy (XTAP) configuration for the tenant.

.Description
    Provides a flattened, user-friendly interface over
    Update-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability.

    Instead of building the nested payload manually, callers supply discrete parameters
    for the inbound access flag and the users and groups to include or exclude.
    The cmdlet assembles the correct Graph API body, constructs the strongly-typed
    model objects, and delegates to the auto-generated cmdlet.

.Parameter CapabilityId
    The OData type name / key of the M365 capability to update
    (e.g. "crossTenantCalendarAvailabilityBasic").

.Parameter IsAllowed
    Whether inbound access is allowed ($true) or blocked ($false) for the capability.

.Parameter IncludedUsers
    User object IDs or the special value "All" to include in the inbound access scope.

.Parameter ExcludedUsers
    User object IDs or "All" to exclude from the inbound access scope.

.Parameter IncludedGroups
    Group object IDs or the special value "All" to include in the inbound access scope.

.Parameter ExcludedGroups
    Group object IDs or "All" to exclude from the inbound access scope.

.Example
    # Update default calendar availability to allow all users
    Set-DefaultM365XTAPCapability `
        -CapabilityId  "crossTenantCalendarAvailabilityBasic" `
        -IsAllowed     $true `
        -IncludedUsers "All"

.Example
    # Restrict default MailTips to a specific group, exclude individual users
    Set-DefaultM365XTAPCapability `
        -CapabilityId   "crossTenantMailTipsAll" `
        -IsAllowed      $true `
        -IncludedGroups "0be493dc-cb56-4a53-936f-9cf64410b8b0" `
        -ExcludedUsers  "6f546279-4da5-4b53-a095-09ea0cef9971"

.Example
    # Block all inbound open profile card access by default
    Set-DefaultM365XTAPCapability `
        -CapabilityId  "crossTenantOpenProfileCard" `
        -IsAllowed     $false `
        -IncludedUsers "All"

.Outputs
    Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphM365CapabilityBase

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicydefaultconfiguration-update-m365capabilities
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/update-mgbetapolicycrosstenantaccesspolicydefaultm365capability
#>
function Set-DefaultM365XTAPCapability {
    [OutputType([Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphM365CapabilityBase])]
    [CmdletBinding(DefaultParameterSetName = 'UpdateExpanded',
                   PositionalBinding = $false,
                   SupportsShouldProcess,
                   ConfirmImpact = 'Medium')]
    param(

        # ── Capability ID ─────────────────────────────────────────────────
        [Parameter(Mandatory = $true, ParameterSetName = 'UpdateExpanded')]
        [System.String]
        # The OData type name / key of the M365 capability to update.
        ${CapabilityId},

        # ── Inbound access ────────────────────────────────────────────────
        [Parameter(Mandatory = $true, ParameterSetName = 'UpdateExpanded')]
        [System.Boolean]
        # Whether inbound access is allowed ($true) or blocked ($false).
        ${IsAllowed},

        [Parameter(ParameterSetName = 'UpdateExpanded')]
        [ValidateScript({
            foreach ($item in $_) {
                if ($item -ne 'All' -and -not [System.Guid]::TryParse($item, [ref][System.Guid]::Empty)) {
                    throw "'$item' is not valid. Each value must be a GUID or 'All'."
                }
            }
            $true
        })]
        [System.String[]]
        # User object IDs or "All" to include in the inbound access scope.
        ${IncludedUsers},

        [Parameter(ParameterSetName = 'UpdateExpanded')]
        [ValidateScript({
            foreach ($item in $_) {
                if ($item -ne 'All' -and -not [System.Guid]::TryParse($item, [ref][System.Guid]::Empty)) {
                    throw "'$item' is not valid. Each value must be a GUID or 'All'."
                }
            }
            $true
        })]
        [System.String[]]
        # User object IDs or "All" to exclude from the inbound access scope.
        ${ExcludedUsers},

        [Parameter(ParameterSetName = 'UpdateExpanded')]
        [ValidateScript({
            foreach ($item in $_) {
                if ($item -ne 'All' -and -not [System.Guid]::TryParse($item, [ref][System.Guid]::Empty)) {
                    throw "'$item' is not valid. Each value must be a GUID or 'All'."
                }
            }
            $true
        })]
        [System.String[]]
        # Group object IDs or "All" to include in the inbound access scope.
        ${IncludedGroups},

        [Parameter(ParameterSetName = 'UpdateExpanded')]
        [ValidateScript({
            foreach ($item in $_) {
                if ($item -ne 'All' -and -not [System.Guid]::TryParse($item, [ref][System.Guid]::Empty)) {
                    throw "'$item' is not valid. Each value must be a GUID or 'All'."
                }
            }
            $true
        })]
        [System.String[]]
        # Group object IDs or "All" to exclude from the inbound access scope.
        ${ExcludedGroups},

        # ── Pipeline / runtime ────────────────────────────────────────────
        [Parameter(DontShow)]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [Microsoft.Graph.Beta.PowerShell.Runtime.SendAsyncStep[]]
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [Microsoft.Graph.Beta.PowerShell.Runtime.SendAsyncStep[]]
        ${HttpPipelinePrepend},

        [Parameter(DontShow)]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [System.Uri]
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        ${ProxyUseDefaultCredentials}
    )

    begin {
    }

    process {
        # ------------------------------------------------------------------
        # Helper: build MicrosoftGraphM365CapabilityResourceScope objects
        # from a plain array of IDs and the implied resourceType string.
        # ------------------------------------------------------------------
        function Build-ResourceScopes {
            param(
                [string[]] $Ids,
                [string]   $ResourceType
            )
            $results = @()
            foreach ($id in $Ids) {
                if ([string]::IsNullOrWhiteSpace($id)) { continue }
                $scope = New-Object Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphM365CapabilityResourceScope
                $scope.ResourceId   = $id.Trim()
                $scope.ResourceType = $ResourceType
                $results += $scope
            }
            return ,$results
        }

        $includedUserScopes  = if ($null -ne $IncludedUsers  -and $IncludedUsers.Count  -gt 0) { Build-ResourceScopes -Ids $IncludedUsers  -ResourceType 'user'  } else { @() }
        $includedGroupScopes = if ($null -ne $IncludedGroups -and $IncludedGroups.Count -gt 0) { Build-ResourceScopes -Ids $IncludedGroups -ResourceType 'group' } else { @() }
        $excludedUserScopes  = if ($null -ne $ExcludedUsers  -and $ExcludedUsers.Count  -gt 0) { Build-ResourceScopes -Ids $ExcludedUsers  -ResourceType 'user'  } else { @() }
        $excludedGroupScopes = if ($null -ne $ExcludedGroups -and $ExcludedGroups.Count -gt 0) { Build-ResourceScopes -Ids $ExcludedGroups -ResourceType 'group' } else { @() }

        $resourceScopes = New-Object Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphM365CapabilityResourceScopes
        $resourceScopes.Included = @($includedUserScopes + $includedGroupScopes)
        $resourceScopes.Excluded = @($excludedUserScopes + $excludedGroupScopes)

        $inboundAccess = New-Object Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphM365CapabilityInboundAccess
        $inboundAccess.IsAllowed      = $IsAllowed
        $inboundAccess.ResourceScopes = $resourceScopes

        Write-Verbose "Updating default XTAP M365 capability '$CapabilityId'."
        Write-Verbose "IsAllowed: $IsAllowed | IncludedUsers: $($IncludedUsers -join ', ') | IncludedGroups: $($IncludedGroups -join ', ') | ExcludedUsers: $($ExcludedUsers -join ', ') | ExcludedGroups: $($ExcludedGroups -join ', ')"

        foreach ($key in @('CapabilityId','IsAllowed',
                            'IncludedUsers','ExcludedUsers','IncludedGroups','ExcludedGroups')) {
            $null = $PSBoundParameters.Remove($key)
        }

        if ($PSCmdlet.ShouldProcess($CapabilityId, "Set-DefaultM365XTAPCapability")) {
            $result = Update-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability `
                -M365CapabilityBaseName $CapabilityId `
                -InboundAccess          $inboundAccess `
                -Name                   $CapabilityId `
                -AdditionalProperties   @{ '@odata.type' = "microsoft.graph.$CapabilityId" } `
                @PSBoundParameters
            if ($null -ne $result) { ConvertTo-EntraXTAPM365CapabilityFlatOutput -Result $result }
        }
    }

    end {
    }
}
