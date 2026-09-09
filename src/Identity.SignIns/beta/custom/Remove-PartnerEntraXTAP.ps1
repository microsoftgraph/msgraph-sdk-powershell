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
    Removes a Cross-Tenant Access Policy (XTAP) partner configuration.

.Description
    Provides a flattened, user-friendly interface over
    Remove-MgBetaPolicyCrossTenantAccessPolicyPartner.

.Parameter PartnerTenantId
    The tenant ID (GUID) of the partner whose XTAP configuration is to be removed.

.Example
    # Remove a specific partner XTAP configuration
    Remove-PartnerEntraXTAP -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a"

.Example
    # Remove with PassThru to confirm deletion
    Remove-PartnerEntraXTAP -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a" -PassThru

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicyconfigurationpartner-delete
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/remove-mgbetapolicycrosstenantaccesspolicypartner
#>
function Remove-PartnerEntraXTAP {
    [CmdletBinding(DefaultParameterSetName = 'Delete',
                   PositionalBinding = $false,
                   SupportsShouldProcess,
                   ConfirmImpact = 'High')]
    param(

        [Parameter(Mandatory = $true, ParameterSetName = 'Delete')]
        [ValidateScript({
            [System.Guid]::TryParse($_, [ref][System.Guid]::Empty) -or
            $(throw "'$_' is not a valid GUID. PartnerTenantId must be a valid GUID.")
        })]
        [System.String]
        # The partner tenant ID (GUID) of the XTAP configuration to remove.
        ${PartnerTenantId},

        [Parameter(ParameterSetName = 'Delete')]
        [System.Management.Automation.SwitchParameter]
        # Returns $true on successful deletion.
        ${PassThru},

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

        Write-Verbose "Removing XTAP partner configuration for tenant '$PartnerTenantId'."

        if ($PSCmdlet.ShouldProcess($PartnerTenantId, "Remove-PartnerEntraXTAP")) {
            Remove-MgBetaPolicyCrossTenantAccessPolicyPartner `
                -CrossTenantAccessPolicyConfigurationPartnerTenantId $PartnerTenantId `
                @PSBoundParameters
        }
    }

    end {
    }
}
