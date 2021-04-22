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
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/select-mgentitlementmanagementaccesspackageassignmentpolicy
#>
function Select-MgEntitlementManagementAccessPackageAssignmentPolicy {
[OutputType([Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentPolicy])]
[CmdletBinding(DefaultParameterSetName='ExplicitScope', PositionalBinding=$false, ConfirmImpact='Medium')]
[Microsoft.Graph.PowerShell.Profile('v1.0-beta')]
param(
    [Parameter (ValueFromPipeline=$true)]
    [Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAssignmentPolicy[]]$Policy,

    [Parameter (Mandatory = $False)]
    [switch]
    $NoApprovalRequiredForRequest,

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

    if ($NoApprovalRequiredForRequest -and $acceptRequests -eq $true) {
        $approvalIsRequiredForRequest = $false

        if ($Policy.RequestApprovalSettings) {
            $isApprovalRequired = $Policy.RequestApprovalSettings.isApprovalRequired
            $isApprovalRequiredForExtension = $Policy.RequestApprovalSettings.isApprovalRequiredForExtension

            $isApprovalOverride = $true

            if ($Policy.RequestApprovalSettings.ApprovalMode -eq "NoApproval") {
                $isApprovalOverride = $false
            }
            if ($Policy.RequestApprovalSettings.ApprovalStages -eq $null -or $Policy.RequestApprovalSettings.ApprovalStages.Length -eq 0) {
                $isApprovalOverride = $false
            }

            if ($isApprovalRequired -eq $true -and $isApprovalOverride -eq $true) {
                $approvalIsRequiredForRequest = $true
            } else {
                write-verbose "policy $policyId did not require approval $isApprovalRequired $isApprovalRequiredForExtension $isApprovalOverride"
            }

        }

        if ($approvalIsRequiredForRequest) {
            write-verbose "policy $policyId requires approval"
            return
        }
    }

    if ($NoApprovalRequiredForRequest -and $acceptRequests -eq $false) {
        # does not accept requests
        write-verbose "policy $policyId does not accept requests"
        return
    }
    if ($NoApprovalRequiredForRequest -and ($null -eq $ScopeType -or $ScopeType.Length -eq 0) -and $thisScopeType -eq "NoSubjects") {
        write-verbose "policy $policyId has no subjects in scope"
        return
    }

    write-output $Policy
}

end {

}
}
