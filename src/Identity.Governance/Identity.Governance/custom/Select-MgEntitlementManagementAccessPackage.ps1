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
Select matching entitlement management accessPackage
.Description
Select matching entitlement management accessPackage
.Inputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage
.Outputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage
.Notes

.Link
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/select-mgentitlementmanagementaccesspackage
#>
function Select-MgEntitlementManagementAccessPackage {
[OutputType([Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage])]
[CmdletBinding(PositionalBinding=$false, ConfirmImpact='Medium')]
[Microsoft.Graph.PowerShell.Profile('v1.0-beta')]
param(
    [Parameter (ValueFromPipeline=$true)]
    [Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackage[]]$AccessPackage,

    [Parameter (Mandatory = $False)]
    [switch]
    $PolicyWithNoApprovalRequiredForRequest,

    [Parameter (Mandatory = $False)]
    [string[]]
    $PolicyWithScopeType

)

begin {
    $APWithZeroPolicies = 0
    $APWithNonZeroPolicies = 0
    $policyEvaluation = $false

    if ($PolicyWithNoApprovalRequiredForRequest -or ($null -ne $PolicyWithScopeType -and $PolicyWithScopeType.Length -gt 0)) {
        $policyEvaluation = $true
    }
}

process {

    $NewObj = $AccessPackage
    $accessPackageId = ""
    try {
        $accessPackageId = $AccessPackage.Id
    } catch {
        write-verbose "no access package id"
        return
    }

    if ($policyEvaluation) {
        $inputPolicyCount = 0
        try {
            if ($AccessPackage.AccessPackageAssignmentPolicies) {
                $inputPolicyCount = $AccessPackage.AccessPackageAssignmentPolicies.Length

            }
        } catch {
            write-verbose "no policies in $accessPackageId"
            $APWithZeroPolicies++
            return
        }
        if ($inputPolicyCount -eq 0) {
            $APWithZeroPolicies++
            return
        }

        $APWithNonZeroPolicies++

        $matchingPolicyCount = 0
        $matchingPolicies = @()
        foreach ($p in $AccessPackage.AccessPackageAssignmentPolicies) {
            $thisMatch = $null

            $thisMatch = @(Select-MgEntitlementManagementAccessPackageAssignmentPolicy -ScopeType $PolicyWithScopeType -NoApprovalRequiredForRequest:$PolicyWithNoApprovalRequiredForRequest -Policy $p)

            if ($null -eq $thisMatch  -or $thisMatch.Length -eq 0) {
                # not a match
            } else {
                $matchingPolicies += $thisMatch[0]
            }
        }
        $matchingPolicyCount = $matchingPolicies.Length
        if ($matchingPolicyCount -eq 0) {
                write-verbose "skipping $accessPackageId as $inputPolicyCount policies has 0 matching"
                return
        } elseif ($inputPolicyCount -ne $matchingPolicyCount) {
            write-verbose "changing $accessPackageId from $inputPolicyCount to $MatchingPolicyCount"

            $NewObj = $AccessPackage.PSObject.Copy()
            $NewObj | Add-Member -MemberType NoteProperty -Name AccessPackageAssignmentPolicies -Value $matchingPolicies -Force
        } else {
            write-verbose "all $inputPolicyCount policies of $accessPackageId are relevant"
        }

    }

    write-output $NewObj
}

end {
    if ($APWithNonZeroPolicies -eq 0 -and $ApWithZeroPolicies -gt 1 -and $policyEvaluation -eq $true) {
        write-warning "no access packages had any policies to evaluate"
    }
}
}
