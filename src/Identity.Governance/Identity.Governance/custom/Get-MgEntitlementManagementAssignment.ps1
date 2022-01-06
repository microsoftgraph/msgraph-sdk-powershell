
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
Get assignments from identityGovernance
.Description
Get assignments from identityGovernance
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
.Outputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment1
.Notes

.Link
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/get-mgentitlementmanagementassignment
#>
function Get-MgEntitlementManagementAssignment {
[OutputType([Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment1])]
[CmdletBinding(DefaultParameterSetName='ListAll', PositionalBinding=$false)]
[Microsoft.Graph.PowerShell.Profile('v1.0')]
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

    [Parameter(ParameterSetName='ListByAccessPackageId', Mandatory)]
    [Microsoft.Graph.PowerShell.Category('Query')]
    [ValidateScript( {
        try {
            [System.Guid]::Parse($_) | Out-Null
            $true
        }
        catch {
            throw "$_ is not a valid ObjectID format. Valid value is a GUID format only."
        }
    })]
    [System.String]
    # Filter items by property values
    ${AccessPackageId},

    [Parameter(ParameterSetName='ListAll')]
    [Parameter(ParameterSetName='ListByAccessPackageId')]
    [Alias('OrderBy')]
    [Microsoft.Graph.PowerShell.Category('Query')]
    [System.String[]]
    # Order items by property values
    ${Sort},

    [Parameter(ParameterSetName='ListByAccessPackageId')]
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

    [Parameter(ParameterSetName='ListAll')]
    [Parameter(ParameterSetName='ListByAccessPackageId')]
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
    if ($parameterSet -eq "ListByAccessPackageId") {

        $Filter = "accessPackage/Id eq '{0}'" -f $AccessPackageId
        $PSBoundParameters['Filter'] = $Filter
        $null = $PSBoundParameters.Remove('AccessPackageId')
    }

    if ($PSBoundParameters.ContainsKey('Top') -or $PSBoundParameters.ContainsKey('All')) {

    } else {
        $PSBoundParameters['All'] = $true
    }

    Microsoft.Graph.Identity.Governance.private\Get-MgEntitlementManagementAssignment_List @PSBoundParameters

}

end {

}
}
