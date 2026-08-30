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
    Gets the M365 Collaboration and App Service Connect settings from the tenant-wide
    default Cross-Tenant Access Policy (XTAP) configuration.

.Description
    Provides a flattened, user-friendly interface over
    Get-MgBetaPolicyCrossTenantAccessPolicyDefault.

    The default configuration is a singleton — there is exactly one per tenant.
    This cmdlet scopes the output to the three properties that are configurable
    via Update-DefaultEntraXTAP:

      - M365CollaborationInbound    (inbound user access)
      - M365CollaborationOutbound   (outbound users and groups access)
      - AppServiceConnectInbound    (inbound application access)

    All other properties (B2B, InboundTrust, TenantRestrictions, etc.) are excluded
    from both the API request ($select) and the output object.

.Example
    # Get the default M365 Collaboration and App Service Connect settings
    Get-DefaultEntraXTAP

.Outputs
    Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationDefault

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicydefaultconfiguration-get
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/get-mgbetapolicycrosstenantaccesspolicydefault
#>
function Get-DefaultEntraXTAP {
    [OutputType([Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationDefault])]
    [CmdletBinding(DefaultParameterSetName = 'Get',
                   PositionalBinding = $false)]
    param(

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
        # Request only the three properties exposed by Update-DefaultEntraXTAP.
        $selectProps = 'id', 'isServiceDefault', 'm365CollaborationInbound', 'm365CollaborationOutbound', 'appServiceConnectInbound'

        Write-Verbose "Getting default XTAP configuration (scoped to M365Collaboration and AppServiceConnect)."

        $result = Get-MgBetaPolicyCrossTenantAccessPolicyDefault `
            -Property $selectProps `
            @PSBoundParameters

        if ($null -eq $result) { return }

        ConvertTo-EntraXTAPFlatOutput -Result $result
    }

    end {
    }
}
