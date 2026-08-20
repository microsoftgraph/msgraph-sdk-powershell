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
    Resets the tenant-wide default Cross-Tenant Access Policy (XTAP) configuration
    to system defaults.

.Description
    Provides a flattened, user-friendly interface over
    Reset-MgBetaPolicyCrossTenantAccessPolicyDefaultToSystemDefault.

    The default configuration is a singleton — there is exactly one per tenant.
    This cmdlet invokes the Graph API `resetToSystemDefault` action, which restores
    all default XTAP settings (B2B collaboration, M365 Collaboration, App Service
    Connect, InboundTrust, etc.) to the Microsoft-defined system defaults.

.Example
    # Reset the default XTAP configuration to system defaults
    Reset-DefaultEntraXTAPToSystemDefault

.Example
    # Reset with PassThru to confirm the operation succeeded
    Reset-DefaultEntraXTAPToSystemDefault -PassThru

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicydefaultconfiguration-resettosystemdefault
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/reset-mgbetapolicycrosstenantaccesspolicydefaulttosystemdefault
#>
function Reset-DefaultEntraXTAPToSystemDefault {
    [CmdletBinding(DefaultParameterSetName = 'Reset',
                   PositionalBinding = $false,
                   SupportsShouldProcess,
                   ConfirmImpact = 'High')]
    param(

        [Parameter(ParameterSetName = 'Reset')]
        [System.Management.Automation.SwitchParameter]
        # Returns $true on successful reset.
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
        Write-Verbose "Resetting default XTAP configuration to system defaults."

        if ($PSCmdlet.ShouldProcess("Default XTAP Configuration", "Reset-DefaultEntraXTAPToSystemDefault")) {
            Reset-MgBetaPolicyCrossTenantAccessPolicyDefaultToSystemDefault @PSBoundParameters
        }
    }

    end {
    }
}
