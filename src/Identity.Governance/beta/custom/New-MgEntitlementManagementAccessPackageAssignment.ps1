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
Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment
.Outputs
Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment
.Notes

.Link
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgbetaentitlementmanagementaccesspackageassignment
#>
function New-MgBetaEntitlementManagementAccessPackageAssignment {
[OutputType([Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment])]
[CmdletBinding(DefaultParameterSetName='CreateMultipleRequestAdminAddExistingUser', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(

    [Parameter(Mandatory = $True,
        ParameterSetName='CreateMultipleRequestAdminAddExistingGroupMember')]
    [PSCustomObject[]]$RequiredGroupMember,

    [Parameter(Mandatory = $True,
        ParameterSetName='CreateMultipleRequestAdminAddExistingUser')]
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

    [Parameter(ParameterSetName='CreateMultipleRequestAdminAddExistingUser')]
    [Parameter(ParameterSetName='CreateMultipleRequestAdminAddExistingGroupMember')]
    [Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphAccessPackageAssignment[]]$ExistingAssignment,

    [Parameter(ParameterSetName='CreateMultipleRequestAdminAddExistingUser')]
    [Parameter(ParameterSetName='CreateMultipleRequestAdminAddExistingGroupMember')]
    [Microsoft.Graph.Beta.PowerShell.Category('Body')]
    [Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccessPackageAnswer[]]
    # Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.
    # To construct, see NOTES section for ANSWERS properties and create a hash table.
    ${Answers},

    [Parameter(ParameterSetName='CreateMultipleRequestAdminAddExistingUser')]
    [Parameter(ParameterSetName='CreateMultipleRequestAdminAddExistingGroupMember')]
    [Microsoft.Graph.Beta.PowerShell.Category('Body')]
    [System.String]
    # The requestor's supplied justification.
    ${Justification},

    [Parameter(ParameterSetName='CreateMultipleRequestAdminAddExistingUser')]
    [Parameter(ParameterSetName='CreateMultipleRequestAdminAddExistingGroupMember')]
    [Microsoft.Graph.Beta.PowerShell.Category('Body')]
    [string]
    ${StartDate},

    [Parameter(Mandatory = $True,
        ParameterSetName='CreateMultipleRequestAdminAddExistingUser')]
    [Parameter(Mandatory = $True,
    ParameterSetName='CreateMultipleRequestAdminAddExistingGroupMember')]
    [Microsoft.Graph.Beta.PowerShell.Category('Body')]
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
        ParameterSetName='CreateMultipleRequestAdminAddExistingUser')]
    [Parameter(Mandatory = $True,
        ParameterSetName='CreateMultipleRequestAdminAddExistingGroupMember')]
    [Microsoft.Graph.Beta.PowerShell.Category('Body')]
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
    [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
    [Microsoft.Graph.Beta.PowerShell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
    [Microsoft.Graph.Beta.PowerShell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Graph.Beta.PowerShell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    $alreadyDelivered = 0
    $misdelivers = 0
    $expires = 0
    $notDelivered = 0
    $nonUsers = 0

    if ($null -eq $StartDate  -or $StartDate.Length -eq 0) {
        $now = Get-Date
        $ts = Get-Date $now.ToUniversalTime() -format "s"
        $StartDate = $ts + "Z"
    }

    if ($null -eq $Justification) {
        $Justification = ""
    }

    if ($PSBoundParameters.ContainsKey("ExistingAssignment") -eq $false) {
        write-verbose "retrieving existing assignments on $AccessPackageId"
        $ExistingAssignment = Get-MgBetaEntitlementManagementAccessPackageAssignment -AccessPackageId $AccessPackageId -All -expandproperty target
        $eac = $ExistingAssignment.Length
        write-verbose "retrieved existing assignments $eac"
    }

    $delivereds = @{ }
    $misdelivereds = @{ }
    $expireds = @{ }
    $noTarget = 0

    if ($null -ne $ExistingAssignment) {
       foreach ($a in $ExistingAssignment) {
            if ($null -eq $a.Target) {
                $noTarget++
                continue
            }
            if ($a.target.type -ne "User") {
                $noTarget++
                continue
            }
            $uid = $a.Target.ObjectId
            if ($a.AssignmentState -eq "Delivered") {
                $delivereds.$uid = $a
            } elseif ($a.AssignmentState -eq "Expired") {
                $expireds.$uid = $a
            } elseif ($a.AssignmentState -eq "Delivering") {
                $delivereds.$uid = $a
            } else {
                $state = $a.AssignmentState
                write-verbose "assignment to $uid in state $state"
                $misdelivereds.$uid = $a
            }
        }

        write-verbose "existing assignments no target user $noTarget"
    }

    if ($null -ne $RequiredGroupMember) {
        foreach ($m in $RequiredGroupMember) {
            if ($m.ContainsKey("@odata.type")) {
                $membertype = $m.AdditionalProperties["@odata.type"]
                # do not include nested groups, devices or service principals
                if ($membertype -ne '#microsoft.graph.user') {
                    $nonUsers++
                    continue
                }
            }
            $uid = $m.Id
            $RequiredUserId += $uid

        }
    }
  
}

process {
    foreach ($uid in $RequiredUserId) {
        if ($delivereds.ContainsKey($uid)) {
            $alreadyDelivered++
        }
        else {
            if ($misdelivereds.ContainsKey($uid)) {
                $misdelivers++
            }
            else {

                if ($expireds.ContainsKey($uid)) {
                    $expires++
                }
                else {
                    $notDelivered++
                }

                if($PSCmdlet.ShouldProcess($uid,"Add Request")) {
                    try {
                        $res = New-MgBetaEntitlementManagementAccessPackageAssignmentRequest -RequestType "AdminAdd" `
                            -AccessPackageId $AccessPackageId -AssignmentPolicyId $AssignmentPolicyId -TargetId $uid `
                            -StartDate $StartDate -Justification $Justification
                        write-output $res
                    } catch {
                        if ($ErrorActionPreference -eq "Continue") {
                            write-error "error on assignment $_"
                            $misdelivers++
                            continue
                        }
                        throw
                    }
                }
            }
        }
    }
}

end {
    write-verbose "already delivered $alreadyDelivered mis-delivers $misdelivers expired $expires needing delivered $notDelivered nonusers $nonUsers"
}
}
