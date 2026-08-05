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
    Gets one or all Microsoft 365 capability entries from the default Cross-Tenant
    Access Policy (XTAP) configuration for the tenant.

.Description
    Provides a flattened, user-friendly interface over
    Get-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability.

    When -CapabilityId is omitted, all capability entries in the default policy
    are returned. When -CapabilityId is supplied, only that specific entry is returned.

.Parameter CapabilityId
    The OData type name / key of the specific M365 capability to retrieve
    (e.g. "crossTenantCalendarAvailabilityBasic").
    When omitted, all capabilities in the default policy are returned.

.Example
    # List all default M365 capabilities
    Get-DefaultM365XTAPCapability

.Example
    # Get a specific default capability
    Get-DefaultM365XTAPCapability -CapabilityId "crossTenantCalendarAvailabilityBasic"

.Outputs
    Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphM365CapabilityBase

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicydefaultconfiguration-list-m365capabilities
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/get-mgbetapolicycrosstenantaccesspolicydefaultm365capability
#>
function Get-DefaultM365XTAPCapability {
    [OutputType([Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphM365CapabilityBase])]
    [CmdletBinding(DefaultParameterSetName = 'List',
                   PositionalBinding = $false)]
    param(

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
        $null = $PSBoundParameters.Remove('CapabilityId')

        if ($PSCmdlet.ParameterSetName -eq 'Get') {
            Write-Verbose "Getting default XTAP M365 capability '$CapabilityId'."
            $result = Get-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability `
                -M365CapabilityBaseName $CapabilityId `
                @PSBoundParameters
            if ($null -ne $result) { ConvertTo-EntraXTAPM365CapabilityFlatOutput -Result $result }
        } else {
            Write-Verbose "Listing all default XTAP M365 capabilities."
            Get-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability @PSBoundParameters | ForEach-Object {
                ConvertTo-EntraXTAPM365CapabilityFlatOutput -Result $_
            }
        }
    }

    end {
    }
}
