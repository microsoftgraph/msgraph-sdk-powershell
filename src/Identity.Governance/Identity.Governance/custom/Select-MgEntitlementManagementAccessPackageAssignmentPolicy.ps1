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
Select matching entitlement management accessPackageAssignmentPolicy
.Description
Select matching entitlement management accessPackageAssignmentPolicy
.Inputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentPolicy
.Outputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentPolicy
.Notes

.Link
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageassignmentrequest
#>
function Select-MgEntitlementManagementAccessPackageAssignmentPolicy {
[OutputType([Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentPolicy])]
[CmdletBinding(DefaultParameterSetName='ExplicitScope', PositionalBinding=$false, ConfirmImpact='Medium')]
[Microsoft.Graph.PowerShell.Profile('v1.0-beta')]
param(
    [Parameter (ValueFromPipeline=$true)]
    [Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAssignmentPolicy[]]$Policy,

    [Parameter (Mandatory = $False,ParameterSetName = "ExplicitScope")]
    [string[]]
    $ScopeType
)

begin {

}

process {
    $policyId = $Policy.Id
    $acceptRequests = $false
    $thisScopeType = ""

    if ($Policy.RequestorSettings) {
        $acceptRequests = $Policy.RequestorSettings.AcceptRequests
        $thisScopeType = $Policy.RequestorSettings.ScopeType
    }
    $matchedScopeType = $true
    if ($null -ne $ScopeType -and $ScopeType.Length -gt 0) {
        $matchedScopeType = $false
        foreach ($s in $ScopeType) {
            if ($thisScopeType -eq $s) {
                $matchedScopeType = $true
                break
            }
        }
    }
    if ($acceptRequests -and $matchedScopeType -eq $false) {
        write-verbose "policy $policyId did not match scope type with $thisScopeType"
        return
    }

    write-output $Policy
}

end {

}
}
