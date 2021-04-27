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
Create a new entitlement management accessPackageAssignment
.Description
Create a new entitlement management accessPackageAssignment
.Inputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment
.Outputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment
.Notes

.Link
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageassignment
#>
function New-MgEntitlementManagementAccessPackageAssignment {
[OutputType([Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment])]
[CmdletBinding(DefaultParameterSetName='BulkAddExistingUser', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
[Microsoft.Graph.PowerShell.Profile('v1.0-beta')]
param(

    [Parameter(Mandatory = $True,
        ParameterSetName='BulkAddExistingGroupMember')]
    [PSCustomObject[]]$RequiredGroupMember,

    [Parameter(Mandatory = $True,
        ParameterSetName='BulkAddExistingUser')]
    [ValidateScript( {
            try {
                [System.Guid]::Parse($_) | Out-Null
                $true
            }
            catch {
                throw "$_ is not a valid GUID"
            }
        })]
    [string[]]$RequiredUserId,

    [Parameter()]
    [Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAssignment[]]$ExistingAssignment,

    [Parameter(ParameterSetName='BulkAddExistingUser')]
    [Parameter(ParameterSetName='BulkAddExistingGroupMember')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAnswer[]]
    # Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.
    # To construct, see NOTES section for ANSWERS properties and create a hash table.
    ${Answers},

    [Parameter(ParameterSetName='BulkAddExistingUser')]
    [Parameter(ParameterSetName='BulkAddExistingGroupMember')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [System.String]
    # The requestor's supplied justification.
    ${Justification},

    [Parameter(ParameterSetName='BulkAddExistingUser')]
    [Parameter(ParameterSetName='BulkAddExistingGroupMember')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [string]
    ${StartDate},

    [Parameter(Mandatory = $True,
        ParameterSetName='BulkAddExistingUser')]
    [Parameter(Mandatory = $True,
    ParameterSetName='BulkAddExistingGroupMember')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [ValidateScript( {
            try {
                [System.Guid]::Parse($_) | Out-Null
                $true
            }
            catch {
                throw "$_ is not a valid ObjectID format. Valid value is a GUID format only."
            }
        })]
    [string]
    ${AccessPackageId},

    [Parameter(Mandatory = $True,
        ParameterSetName='BulkAddExistingUser')]
    [Parameter(Mandatory = $True,
        ParameterSetName='BulkAddExistingGroupMember')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [ValidateScript( {
            try {
                [System.Guid]::Parse($_) | Out-Null
                $true
            }
            catch {
                throw "$_ is not a valid ObjectID format. Valid value is a GUID format only."
            }
        })]
    [string]
    ${AssignmentPolicyId},

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

}

end {

}
}
