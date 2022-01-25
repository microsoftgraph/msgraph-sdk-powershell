
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
Get connectedOrganizations from identityGovernance
.Description
Get connectedOrganizations from identityGovernance
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
.Outputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnectedOrganization
.Notes

.Link
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/get-mgentitlementmanagementconnectedorganization
#>
function Get-MgEntitlementManagementConnectedOrganization {
[OutputType([Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnectedOrganization])]
[CmdletBinding(DefaultParameterSetName='ListAll', PositionalBinding=$false)]
param(
    [Parameter()]
    [Alias('Expand')]
    [Microsoft.Graph.PowerShell.Category('Query')]
    [System.String[]]
    # Expand related entities
    ${ExpandProperty},

    [Parameter()]
    [Alias('Select')]
    [Microsoft.Graph.PowerShell.Category('Query')]
    [System.String[]]
    # Select properties to be returned
    ${Property},

    [Parameter(ParameterSetName='ListByDisplayNameEq', Mandatory)]
    [Microsoft.Graph.PowerShell.Category('Query')]
    [System.String]
    # Filter items by property values
    ${DisplayNameEq},

    [Parameter(ParameterSetName='ListByDisplayNameContains', Mandatory)]
    [Microsoft.Graph.PowerShell.Category('Query')]
    [System.String]
    # Filter items by property values
    ${DisplayNameContains},

    [Parameter(ParameterSetName='ListByDisplayNameEq')]
    [Parameter(ParameterSetName='ListByDisplayNameContains')]
    [Parameter(ParameterSetName='ListAll')]
    [Alias('OrderBy')]
    [Microsoft.Graph.PowerShell.Category('Query')]
    [System.String[]]
    # Order items by property values
    ${Sort},

    [Parameter(ParameterSetName='ListByDisplayNameEq')]
    [Parameter(ParameterSetName='ListByDisplayNameContains')]
    [Alias('Limit')]
    [Microsoft.Graph.PowerShell.Category('Query')]
    [System.Int32]
    # Show only the first n items
    ${Top},

    [Parameter(DontShow)]
    [Microsoft.Graph.PowerShell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Graph.PowerShell.Category('Runtime')]
    [Microsoft.Graph.PowerShell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Graph.PowerShell.Category('Runtime')]
    [Microsoft.Graph.PowerShell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Graph.PowerShell.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Graph.PowerShell.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Graph.PowerShell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='ListByDisplayNameEq')]
    [Parameter(ParameterSetName='ListByDisplayNameContains')]
    [Parameter(ParameterSetName='ListAll')]
    [Microsoft.Graph.PowerShell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # List all pages.
    ${All}
)

begin {

}

process {
    $outBuffer = $null
    if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
        $PSBoundParameters['OutBuffer'] = 1
    }
    $parameterSet = $PSCmdlet.ParameterSetName
    if ($parameterSet -eq "ListByDisplayNameEq") {

        $Filter = "displayName eq '{0}'" -f $DisplayNameEq
        $PSBoundParameters['Filter'] = $Filter
        $null = $PSBoundParameters.Remove('DisplayNameEq')
    } elseif ($parameterSet -eq "ListByDisplayNameContains") {

        $Filter = "contains(tolower(displayName), '{0}')" -f $DisplayNameContains
        $PSBoundParameters['Filter'] = $Filter
        $null = $PSBoundParameters.Remove('DisplayNameContains')
    }

    if ($PSBoundParameters.ContainsKey('Top') -or $PSBoundParameters.ContainsKey('All')) {

    } else {
        $PSBoundParameters['All'] = $true
    }

    Microsoft.Graph.Identity.Governance.private\Get-MgEntitlementManagementConnectedOrganization_List @PSBoundParameters
}

end {

}
}
