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
    Creates a new Microsoft 365 capability entry on a Cross-Tenant Access Policy (XTAP)
    partner configuration.

.Description
    Provides a flattened, user-friendly interface over
    New-MgBetaPolicyCrossTenantAccessPolicyPartnerM365Capability.

    Instead of building the nested payload manually, callers supply discrete parameters
    for the capability ID, inbound access flag, and the users and groups to include or
    exclude. The cmdlet assembles the correct Graph API body, constructs the
    strongly-typed model objects, and delegates to the auto-generated cmdlet.

    The Graph API m365CapabilityBase type supports inbound access only.
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

.Parameter PartnerTenantId
    The partner tenant ID (GUID) that identifies the cross-tenant access policy
    partner entry to which this M365 capability will be added.

.Parameter CapabilityId
    The OData type discriminator and key for the M365 capability to configure.
    This becomes both the '@odata.type' and the 'name' field in the request body.

.Parameter IsAllowed
    Whether inbound access is allowed ($true) or blocked ($false) for the capability.

.Parameter IncludedUsers
    User object IDs or the special value "All" whose inbound access is configured
    by this capability entry.

.Parameter ExcludedUsers
    User object IDs to explicitly exclude from the inbound access scope.

.Parameter IncludedGroups
    Group object IDs or the special value "All" whose inbound access is configured
    by this capability entry.

.Parameter ExcludedGroups
    Group object IDs to explicitly exclude from the inbound access scope.

.Example
    # Allow basic calendar availability inbound for all users from a partner tenant
    New-PartnerM365XTAPCapability `
        -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a" `
        -CapabilityId    "crossTenantCalendarAvailabilityBasic" `
        -IsAllowed       $true `
        -IncludedUsers   "All"

.Example
    # Allow free/busy detail sharing inbound for specific users, exclude a group
    New-PartnerM365XTAPCapability `
        -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a" `
        -CapabilityId    "crossTenantCalendarSharingFreeBusyDetail" `
        -IsAllowed       $true `
        -IncludedUsers   "6f546279-4da5-4b53-a095-09ea0cef9971","11111111-2222-3333-4444-555555555555" `
        -ExcludedGroups  "0be493dc-cb56-4a53-936f-9cf64410b8b0"

.Example
    # Block all inbound MailTips for a partner tenant
    New-PartnerM365XTAPCapability `
        -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a" `
        -CapabilityId    "crossTenantMailTipsAll" `
        -IsAllowed       $false `
        -IncludedUsers   "All"

.Example
    # Allow open profile card inbound for a specific group
    New-PartnerM365XTAPCapability `
        -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a" `
        -CapabilityId    "crossTenantOpenProfileCard" `
        -IsAllowed       $true `
        -IncludedGroups  "0be493dc-cb56-4a53-936f-9cf64410b8b0"

.Outputs
    Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphM365CapabilityBase

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicyconfigurationpartner-post-m365capabilities
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/new-mgbetapolicycrosstenantaccesspolicypartnerm365capability
#>
function New-PartnerM365XTAPCapability {
    [OutputType([Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphM365CapabilityBase])]
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded',
                   PositionalBinding = $false,
                   SupportsShouldProcess,
                   ConfirmImpact = 'Medium')]
    param(

        # ── Identity ──────────────────────────────────────────────────────
        [Parameter(Mandatory = $true, ParameterSetName = 'CreateExpanded')]
        [ValidateScript({
            [System.Guid]::TryParse($_, [ref][System.Guid]::Empty) -or
            $(throw "'$_' is not a valid GUID. PartnerTenantId must be a valid GUID.")
        })]
        [System.String]
        # The partner tenant ID (GUID) for the cross-tenant access policy entry.
        ${PartnerTenantId},

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

        # ── Pipeline / runtime (standard Graph module params) ─────────────
        [Parameter(DontShow)]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach.
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [Microsoft.Graph.Beta.PowerShell.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline.
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [Microsoft.Graph.Beta.PowerShell.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline.
        ${HttpPipelinePrepend},

        [Parameter(DontShow)]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use.
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call.
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy.
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

        # ------------------------------------------------------------------
        # Merge included users + groups into one included scopes array, and
        # excluded users + groups into one excluded scopes array.
        # ------------------------------------------------------------------
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

        Write-Verbose "Creating XTAP M365 capability '$CapabilityId' for partner tenant '$PartnerTenantId'."
        Write-Verbose "IsAllowed: $IsAllowed | IncludedUsers: $($IncludedUsers -join ', ') | IncludedGroups: $($IncludedGroups -join ', ') | ExcludedUsers: $($ExcludedUsers -join ', ') | ExcludedGroups: $($ExcludedGroups -join ', ')"

        # ------------------------------------------------------------------
        # Strip custom parameters; forward only pipeline/runtime params.
        # ------------------------------------------------------------------
        foreach ($key in @('PartnerTenantId','CapabilityId','IsAllowed',
                            'IncludedUsers','ExcludedUsers','IncludedGroups','ExcludedGroups')) {
            $null = $PSBoundParameters.Remove($key)
        }

        if ($PSCmdlet.ShouldProcess($PartnerTenantId, "New-PartnerM365XTAPCapability ($CapabilityId)")) {
            $result = New-MgBetaPolicyCrossTenantAccessPolicyPartnerM365Capability `
                -CrossTenantAccessPolicyConfigurationPartnerTenantId $PartnerTenantId `
                -InboundAccess        $inboundAccess `
                -Name                 $CapabilityId `
                -AdditionalProperties @{ '@odata.type' = "microsoft.graph.$CapabilityId" } `
                @PSBoundParameters
            if ($null -ne $result) { ConvertTo-EntraXTAPM365CapabilityFlatOutput -Result $result -IsPartner }
        }
    }

    end {
    }
}
