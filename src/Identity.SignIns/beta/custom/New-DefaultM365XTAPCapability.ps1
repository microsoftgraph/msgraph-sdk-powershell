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
    Creates a new Microsoft 365 capability entry on the default Cross-Tenant Access
    Policy (XTAP) configuration for the tenant.

.Description
    Provides a flattened, user-friendly interface over
    New-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability.

    Instead of building the nested payload manually, callers supply discrete parameters
    for the capability ID, inbound access flag, and the users and groups to include or
    exclude. The cmdlet assembles the correct Graph API body, constructs the
    strongly-typed model objects, and delegates to the auto-generated cmdlet.

    The default policy applies tenant-wide and does not target a specific partner.
    The 'name' field (Key) corresponds to the OData type of the capability.

    Known CapabilityId values (from graph.microsoft.com/beta/$metadata):
      Calendar:
        crossTenantCalendarAvailabilityBasic
        crossTenantCalendarAvailabilityLimitedDetails
        crossTenantCalendarSharingFreeBusyDetail
        crossTenantCalendarSharingFreeBusyReviewer
        crossTenantCalendarSharingFreeBusySimple
      Mail:
        crossTenantMailTipsAll
        crossTenantMailTipsLimited
      Other:
        crossTenantMigration
        crossTenantOpenProfileCard
        crossTenantPlacesDeskBooking
        crossTenantPlacesRoomBooking

.Parameter CapabilityId
    The OData type discriminator and key for the M365 capability to configure.
    This becomes both the '@odata.type' and the 'name' field in the request body.

.Parameter IsAllowed
    Whether inbound access is allowed ($true) or blocked ($false) for the capability.

.Parameter IncludedUsers
    User object IDs or the special value "All" to include in the inbound access scope.

.Parameter ExcludedUsers
    User object IDs to exclude from the inbound access scope.

.Parameter IncludedGroups
    Group object IDs or the special value "All" to include in the inbound access scope.

.Parameter ExcludedGroups
    Group object IDs to exclude from the inbound access scope.

.Example
    # Allow basic calendar availability inbound for all users by default
    New-DefaultM365XTAPCapability `
        -CapabilityId  "crossTenantCalendarAvailabilityBasic" `
        -IsAllowed     $true `
        -IncludedUsers "All"

.Example
    # Allow free/busy detail sharing for specific users, exclude a group
    New-DefaultM365XTAPCapability `
        -CapabilityId   "crossTenantCalendarSharingFreeBusyDetail" `
        -IsAllowed      $true `
        -IncludedUsers  "6f546279-4da5-4b53-a095-09ea0cef9971","11111111-2222-3333-4444-555555555555" `
        -ExcludedGroups "0be493dc-cb56-4a53-936f-9cf64410b8b0"

.Example
    # Block all inbound MailTips by default
    New-DefaultM365XTAPCapability `
        -CapabilityId  "crossTenantMailTipsAll" `
        -IsAllowed     $false `
        -IncludedUsers "All"

.Outputs
    Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphM365CapabilityBase

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicydefaultconfiguration-post-m365capabilities
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/new-mgbetapolicycrosstenantaccesspolicydefaultm365capability
#>
function New-DefaultM365XTAPCapability {
    [OutputType([Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphM365CapabilityBase])]
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded',
                   PositionalBinding = $false,
                   SupportsShouldProcess,
                   ConfirmImpact = 'Medium')]
    param(

        # ── Capability ID ─────────────────────────────────────────────────
        [Parameter(Mandatory = $true, ParameterSetName = 'CreateExpanded')]
        [System.String]
        # OData type discriminator and key for the M365 capability to configure.
        ${CapabilityId},

        # ── Inbound access ────────────────────────────────────────────────
        [Parameter(Mandatory = $true, ParameterSetName = 'CreateExpanded')]
        [System.Boolean]
        # Whether inbound access is allowed ($true) or blocked ($false).
        ${IsAllowed},

        [Parameter(ParameterSetName = 'CreateExpanded')]
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

        [Parameter(ParameterSetName = 'CreateExpanded')]
        [ValidateScript({
            foreach ($item in $_) {
                if ($item -ne 'All' -and -not [System.Guid]::TryParse($item, [ref][System.Guid]::Empty)) {
                    throw "'$item' is not valid. Each value must be a GUID or 'All'."
                }
            }
            $true
        })]
        [System.String[]]
        # User object IDs to exclude from the inbound access scope.
        ${ExcludedUsers},

        [Parameter(ParameterSetName = 'CreateExpanded')]
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

        [Parameter(ParameterSetName = 'CreateExpanded')]
        [ValidateScript({
            foreach ($item in $_) {
                if ($item -ne 'All' -and -not [System.Guid]::TryParse($item, [ref][System.Guid]::Empty)) {
                    throw "'$item' is not valid. Each value must be a GUID or 'All'."
                }
            }
            $true
        })]
        [System.String[]]
        # Group object IDs to exclude from the inbound access scope.
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

        Write-Verbose "Creating default XTAP M365 capability '$CapabilityId'."
        Write-Verbose "IsAllowed: $IsAllowed | IncludedUsers: $($IncludedUsers -join ', ') | IncludedGroups: $($IncludedGroups -join ', ') | ExcludedUsers: $($ExcludedUsers -join ', ') | ExcludedGroups: $($ExcludedGroups -join ', ')"

        foreach ($key in @('CapabilityId','IsAllowed',
                            'IncludedUsers','ExcludedUsers','IncludedGroups','ExcludedGroups')) {
            $null = $PSBoundParameters.Remove($key)
        }

        if ($PSCmdlet.ShouldProcess($CapabilityId, "New-DefaultM365XTAPCapability")) {
            $result = New-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability `
                -InboundAccess        $inboundAccess `
                -Name                 $CapabilityId `
                -AdditionalProperties @{ '@odata.type' = "microsoft.graph.$CapabilityId" } `
                @PSBoundParameters
            if ($null -ne $result) { ConvertTo-EntraXTAPM365CapabilityFlatOutput -Result $result }
        }
    }

    end {
    }
}
