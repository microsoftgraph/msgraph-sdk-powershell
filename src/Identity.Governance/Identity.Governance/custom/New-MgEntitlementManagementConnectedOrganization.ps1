
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
Create new connectedOrganization
.Description
Create a new connected organization, for use in an Azure AD Entitlement Management policy.
.Example
PS C:\> New-MgEntitlementManagementConnectedOrganization -DomainName microsoft.com

Id
--
a19c861f-c110-423c-a8bb-b54230a036c9

.Outputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnectedOrganization
.Link
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementconnectedorganization
#>
function New-MgEntitlementManagementConnectedOrganization {
[OutputType([Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnectedOrganization])]
[CmdletBinding(DefaultParameterSetName='CreateWithDomainIdentitySource', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
[Microsoft.Graph.PowerShell.Profile('v1.0-beta')]
param(

    [Parameter(ParameterSetName='CreateWithDomainIdentitySource')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [System.String]
    # The description of the connected organization.
    ${Description},

    [Parameter(ParameterSetName='CreateWithDomainIdentitySource')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [System.String]
    # The display name of the connected organization.
    ${DisplayName},

    [Parameter(Mandatory = $True, ParameterSetName='CreateWithDomainIdentitySource')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [System.String]
    # The domain name of the connected organization identity source.
    ${DomainName},

    [Parameter(ParameterSetName='CreateWithDomainIdentitySource')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [System.String]
    # connectedOrganizationState
    ${State},

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
    ${ProxyUseDefaultCredentials}
)

begin {

}

process {
    $outBuffer = $null
    if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
          $PSBoundParameters['OutBuffer'] = 1
    }

    if ($DomainName -ne $null -and $DomainName.Length -gt 0) {
        $dis = new-object Microsoft.Graph.PowerShell.Models.MicrosoftGraphIdentitySource
        $dis.AdditionalProperties['@odata.type'] = "microsoft.graph.domainidentitysource"
        if ($null -eq $DisplayName -or $DisplayName.Length -eq 0) {
          $dis.AdditionalProperties['displayName'] = $DomainName
        } else {
          $dis.AdditionalProperties['displayName'] = $DisplayName
        }
        
        $dis.AdditionalProperties['domainName'] = $DomainName

        # automatic conversion of single object into array of 1 element
        $PSBoundParameters['IdentitySources'] = $dis

        $null = $PSBoundParameters.Remove("DomainName")

        if ($null -eq $DisplayName -or $DisplayName.Length -eq 0) {
            $PSBoundParameters['DisplayName'] = $DomainName
        }
    }

    Microsoft.Graph.Identity.Governance.private\New-MgEntitlementManagementConnectedOrganization_CreateExpanded @PSBoundParameters
}

end {

}
}
