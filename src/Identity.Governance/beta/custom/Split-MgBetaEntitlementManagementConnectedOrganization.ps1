
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
Split elements of a connectedOrganization
.Description
Split elements of one or more Azure AD entitlement management connected organizations, returned by Get-MgBetaEntitlementManagementConnectedOrganization, to simplify reporting.
.Inputs
Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConnectedOrganization

.Link
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/split-mgbetaentitlementmanagementconnectedorganization
#>
function Split-MgBetaEntitlementManagementConnectedOrganization {
[CmdletBinding(DefaultParameterSetName='SplitByIdentitySource', PositionalBinding=$false, ConfirmImpact='Medium')]
param(

    [Parameter(ValueFromPipeline=$true,ParameterSetName='SplitByIdentitySource')]
    [Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConnectedOrganization[]]
    # The connected organization.
    ${ConnectedOrganization},

    [Parameter(Mandatory=$true, ParameterSetName='SplitByIdentitySource')]
    [switch]
    ${ByIdentitySource}

)

begin {

}

process {
    if ($ByIdentitySource) {

        if ($null -ne $ConnectedOrganization.IdentitySources) {
            foreach ($is in $ConnectedOrganization.IdentitySources) {
                # identity sources, as an abstract class, does not have any properties

                $aObj = [pscustomobject]@{
                    ConnectedOrganizationId = $ConnectedOrganization.Id
                }
            
                $addl = $is.AdditionalProperties
                foreach ($k in $addl.Keys) {
                    $isk = $k
                    $aObj | Add-Member -MemberType NoteProperty -Name $isk -Value $addl[$k] -Force
                }

                write-output $aObj
            }
        }
    }
}

end {

}
}
