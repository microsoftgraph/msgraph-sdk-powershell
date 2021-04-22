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
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/select-mgentitlementmanagementaccesspackag
#>
function Select-MgEntitlementManagementAccessPackage {
[OutputType([Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage])]
[CmdletBinding(PositionalBinding=$false, ConfirmImpact='Medium')]
[Microsoft.Graph.PowerShell.Profile('v1.0-beta')]
param(
    [Parameter (ValueFromPipeline=$true)]
    [Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackage[]]$AccessPackage

)

begin {
    $APWithZeroPolicies = 0
    $APWithNonZeroPolicies = 0
    $policyEvaluation = $false
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
    
    write-output $NewObj
}

end {
    if ($APWithNonZeroPolicies -eq 0 -and $ApWithZeroPolicies -gt 1 -and $policyEvaluation -eq $true) {
        write-warning "no access packages had any policies to evaluate"
    }
}
}
