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
    Removes a Microsoft 365 capability entry from a Cross-Tenant Access Policy (XTAP)
    partner configuration.

.Description
    Provides a flattened, user-friendly interface over
    Remove-MgBetaPolicyCrossTenantAccessPolicyPartnerM365Capability.

.Parameter PartnerTenantId
    The partner tenant ID (GUID) that identifies the cross-tenant access policy
    partner entry from which the M365 capability will be removed.

.Parameter CapabilityId
    The OData type name / key of the M365 capability to remove
    (e.g. "crossTenantCalendarAvailabilityBasic").

.Example
    # Remove a specific M365 capability from a partner tenant configuration
    Remove-PartnerM365XTAPCapability `
        -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a" `
        -CapabilityId    "crossTenantCalendarAvailabilityBasic"

.Example
    # Remove with PassThru to confirm deletion
    Remove-PartnerM365XTAPCapability `
        -PartnerTenantId "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a" `
        -CapabilityId    "crossTenantMailTipsAll" `
        -PassThru

.Link
    https://learn.microsoft.com/en-us/graph/api/crosstenantaccesspolicyconfigurationpartner-delete-m365capabilities
    https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.beta.identity.signins/remove-mgbetapolicycrosstenantaccesspolicypartnerm365capability
#>
function Remove-PartnerM365XTAPCapability {
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
        # The partner tenant ID (GUID) for the cross-tenant access policy entry.
        ${PartnerTenantId},

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
        $null = $PSBoundParameters.Remove('PartnerTenantId')
        $null = $PSBoundParameters.Remove('CapabilityId')

        Write-Verbose "Removing XTAP M365 capability '$CapabilityId' from partner tenant '$PartnerTenantId'."

        if ($PSCmdlet.ShouldProcess("$PartnerTenantId/$CapabilityId", "Remove-PartnerM365XTAPCapability")) {
            Remove-MgBetaPolicyCrossTenantAccessPolicyPartnerM365Capability `
                -CrossTenantAccessPolicyConfigurationPartnerTenantId $PartnerTenantId `
                -M365CapabilityBaseName                               $CapabilityId `
                @PSBoundParameters
        }
    }

    end {
    }
}
