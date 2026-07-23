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
    Removes a Microsoft 365 capability entry from the default Cross-Tenant Access
    Policy (XTAP) configuration for the tenant.

.Description
    Provides a flattened, user-friendly interface over
    Remove-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability.

.Parameter CapabilityId
    The OData type name / key of the M365 capability to remove from the default policy
    (e.g. "crossTenantCalendarAvailabilityBasic").

.Example
    # Remove a specific default M365 capability
    Remove-DefaultM365XTAPCapability -CapabilityId "crossTenantCalendarAvailabilityBasic"

.Example
    # Remove with PassThru to confirm deletion
    Remove-DefaultM365XTAPCapability -CapabilityId "crossTenantMailTipsAll" -PassThru

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicydefaultconfiguration-delete-m365capabilities
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/remove-mgbetapolicycrosstenantaccesspolicydefaultm365capability
#>
function Remove-DefaultM365XTAPCapability {
    [CmdletBinding(DefaultParameterSetName = 'Delete',
                   PositionalBinding = $false,
                   SupportsShouldProcess,
                   ConfirmImpact = 'High')]
    param(

        [Parameter(Mandatory = $true, ParameterSetName = 'Delete')]
        [System.String]
        # The OData type name / key of the M365 capability to remove.
        ${CapabilityId},

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
        $null = $PSBoundParameters.Remove('CapabilityId')

        Write-Verbose "Removing default XTAP M365 capability '$CapabilityId'."

        if ($PSCmdlet.ShouldProcess($CapabilityId, "Remove-DefaultM365XTAPCapability")) {
            Remove-MgBetaPolicyCrossTenantAccessPolicyDefaultM365Capability `
                -M365CapabilityBaseName $CapabilityId `
                @PSBoundParameters
        }
    }

    end {
    }
}
