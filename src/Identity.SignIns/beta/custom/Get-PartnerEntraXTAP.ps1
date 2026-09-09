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
    Gets one or all Cross-Tenant Access Policy (XTAP) partner configurations.

.Description
    Provides a flattened, user-friendly interface over
    Get-MgBetaPolicyCrossTenantAccessPolicyPartner.

    When -PartnerTenantId is omitted all partner configurations are returned.
    When -PartnerTenantId is supplied only that specific partner entry is returned.

.Parameter PartnerTenantId
    The tenant ID (GUID) of the partner whose XTAP configuration is to be retrieved.
    When omitted, all partner configurations are returned.

.Example
    # List all partner XTAP configurations
    Get-PartnerEntraXTAP

.Example
    # Get a specific partner XTAP configuration
    Get-PartnerEntraXTAP -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a"

.Outputs
    Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicy-list-partners
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/get-mgbetapolicycrosstenantaccesspolicypartner
#>
function Get-PartnerEntraXTAP {
    [OutputType([Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner])]
    [CmdletBinding(DefaultParameterSetName = 'List',
                   PositionalBinding = $false)]
    param(

        [Parameter(Mandatory = $true, ParameterSetName = 'Get')]
        [ValidateScript({
            [System.Guid]::TryParse($_, [ref][System.Guid]::Empty) -or
            $(throw "'$_' is not a valid GUID. PartnerTenantId must be a valid GUID.")
        })]
        [System.String]
        # The partner tenant ID (GUID) to retrieve.
        ${PartnerTenantId},

        # ── List query parameters ─────────────────────────────────────────
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

        if ($PSCmdlet.ParameterSetName -eq 'Get') {
            Write-Verbose "Getting XTAP partner configuration for tenant '$PartnerTenantId'."
            $result = Get-MgBetaPolicyCrossTenantAccessPolicyPartner `
                -CrossTenantAccessPolicyConfigurationPartnerTenantId $PartnerTenantId `
                @PSBoundParameters
            if ($null -ne $result) { ConvertTo-EntraXTAPFlatOutput -Result $result -IsPartner }
        } else {
            Write-Verbose "Listing all XTAP partner configurations."
            Get-MgBetaPolicyCrossTenantAccessPolicyPartner @PSBoundParameters | ForEach-Object {
                ConvertTo-EntraXTAPFlatOutput -Result $_ -IsPartner
            }
        }
    }

    end {
    }
}
