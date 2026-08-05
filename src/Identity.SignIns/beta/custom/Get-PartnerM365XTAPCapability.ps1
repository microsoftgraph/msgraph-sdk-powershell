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
    Gets one or all Microsoft 365 capability entries on a Cross-Tenant Access Policy
    (XTAP) partner configuration.

.Description
    Provides a flattened, user-friendly interface over
    Get-MgBetaPolicyCrossTenantAccessPolicyPartnerM365Capability.

    When -CapabilityId is omitted, all capability entries for the specified partner
    tenant are returned. When -CapabilityId is supplied, only that specific entry
    is returned.

.Parameter PartnerTenantId
    The partner tenant ID (GUID) that identifies the cross-tenant access policy
    partner entry whose M365 capabilities are to be retrieved.

.Parameter CapabilityId
    The OData type name / key of the specific M365 capability to retrieve
    (e.g. "crossTenantCalendarAvailabilityBasic").
    When omitted, all capabilities for the partner are returned.

.Example
    # List all M365 capabilities for a partner tenant
    Get-PartnerM365XTAPCapability -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a"

.Example
    # Get a specific capability
    Get-PartnerM365XTAPCapability `
        -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a" `
        -CapabilityId    "crossTenantCalendarAvailabilityBasic"

.Outputs
    Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphM365CapabilityBase

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicyconfigurationpartner-list-m365capabilities
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/get-mgbetapolicycrosstenantaccesspolicypartnerm365capability
#>
function Get-PartnerM365XTAPCapability {
    [OutputType([Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphM365CapabilityBase])]
    [CmdletBinding(DefaultParameterSetName = 'List',
                   PositionalBinding = $false)]
    param(

        [Parameter(Mandatory = $true, ParameterSetName = 'List')]
        [Parameter(Mandatory = $true, ParameterSetName = 'Get')]
        [ValidateScript({
            [System.Guid]::TryParse($_, [ref][System.Guid]::Empty) -or
            $(throw "'$_' is not a valid GUID. PartnerTenantId must be a valid GUID.")
        })]
        [System.String]
        # The partner tenant ID (GUID) for the cross-tenant access policy entry.
        ${PartnerTenantId},

        [Parameter(Mandatory = $true, ParameterSetName = 'Get')]
        [System.String]
        # The OData type name / key of the specific M365 capability to retrieve.
        ${CapabilityId},

        # ── Pass-through list/query parameters ────────────────────────────
        [Parameter(ParameterSetName = 'List')]
        [System.String]
        # OData $filter expression.
        ${Filter},

        [Parameter(ParameterSetName = 'List')]
        [System.String[]]
        # Properties to sort by (OData $orderby).
        ${Sort},

        [Parameter(ParameterSetName = 'List')]
        [System.Int32]
        # Maximum number of items to return per page.
        ${Top},

        [Parameter(ParameterSetName = 'List')]
        [System.Int32]
        # Number of items to skip.
        ${Skip},

        [Parameter(ParameterSetName = 'List')]
        [System.Management.Automation.SwitchParameter]
        # Return all pages of results.
        ${All},

        [Parameter(ParameterSetName = 'List')]
        [System.String]
        # Variable to store the total item count.
        ${CountVariable},

        [Parameter(ParameterSetName = 'List')]
        [System.Int32]
        # Page size for automatic pagination.
        ${PageSize},

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
        $null = $PSBoundParameters.Remove('PartnerTenantId')
        $null = $PSBoundParameters.Remove('CapabilityId')

        $splat = @{
            CrossTenantAccessPolicyConfigurationPartnerTenantId = $PartnerTenantId
        }

        if ($PSCmdlet.ParameterSetName -eq 'Get') {
            $splat['M365CapabilityBaseName'] = $CapabilityId
        }

        Write-Verbose "Getting XTAP M365 capability $(if ($CapabilityId) { "'$CapabilityId' " })for partner tenant '$PartnerTenantId'."

        Get-MgBetaPolicyCrossTenantAccessPolicyPartnerM365Capability @splat @PSBoundParameters | ForEach-Object {
            ConvertTo-EntraXTAPM365CapabilityFlatOutput -Result $_ -IsPartner
        }
    }

    end {
    }
}
