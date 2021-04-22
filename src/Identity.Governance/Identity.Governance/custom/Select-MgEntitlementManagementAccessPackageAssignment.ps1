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
Select matching entitlement management accessPackageAssignment
.Description
Select matching entitlement management accessPackageAssignment
.Inputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment
.Outputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment
.Notes

.Link
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/select-mgentitlementmanagementaccesspackageassignment
#>
function Select-MgEntitlementManagementAccessPackageAssignment {
[OutputType([Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment])]
[CmdletBinding(DefaultParameterSetName='ExplicitAssignmentState', PositionalBinding=$false, ConfirmImpact='Medium')]
[Microsoft.Graph.PowerShell.Profile('v1.0-beta')]
param(
    [Parameter (ValueFromPipeline=$true)]
    [Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAssignment[]]$Assignment,

    [Parameter (Mandatory = $False,ParameterSetName = "ExplicitAssignmentState")]
    [string[]]
    $AssignmentState
)

begin {

}

process {
    $assignmentId = $Assignment.Id
    $thisAssignmentState = $Assignment.AssignmentState
    
    $matchedAssignmentState = $true
    if ($null -ne $AssignmentState -and $AssignmentState.Length -gt 0) {
        $matchedAssignmentState = $false
        foreach ($s in $AssignmentState) {
            if ($thisAssignmentState -eq $s) {
                $matchedAssignmentState = $true
                break
            }
        }
    }
    if ($matchedAssignmentState -eq $false) {
        write-verbose "assignment $assignmentId did not match assignment state with $thisAssignmentState"
        return
    }

    write-output $Assignment
}

end {

}
}
