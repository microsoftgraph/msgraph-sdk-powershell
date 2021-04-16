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
Create a new entitlement management accessPackageAssignmentRequest
.Description
Create a new entitlement management accessPackageAssignmentRequest
.Inputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentRequest
.Outputs
Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentRequest
.Notes

.Link
https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageassignmentrequest
#>
function New-MgEntitlementManagementAccessPackageAssignmentRequest {
[OutputType([Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentRequest])]
[CmdletBinding(DefaultParameterSetName='RequestAdminAdd', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
[Microsoft.Graph.PowerShell.Profile('v1.0-beta')]
param(

    [Parameter(ParameterSetName='RequestAdminAdd')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAnswer[]]
    # Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.
    # To construct, see NOTES section for ANSWERS properties and create a hash table.
    ${Answers},

    [Parameter(ParameterSetName='RequestAdminAdd')]
    [Parameter(ParameterSetName='RequestAdminRemove')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [System.String]
    # The requestor's supplied justification.
    ${Justification},

    [Parameter(ParameterSetName='RequestAdminAdd')]
    [Parameter(ParameterSetName='RequestAdminRemove')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [System.String]
    # One of UserAdd, UserRemove, AdminAdd, AdminRemove or SystemRemove.
    # A request from the user themselves would have requestType of UserAdd or UserRemove.
    ${RequestType},

    [Parameter(ParameterSetName='RequestAdminAdd')]
    [Microsoft.Graph.PowerShell.Category('Body')]
    [string]
    ${StartDate},    

    [Parameter(Mandatory = $true,
        ParameterSetName='RequestAdminRemove')]
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
    ${AccessPackageAssignmentId},

    [Parameter(Mandatory = $True,
        ParameterSetName='RequestAdminAdd')]
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
        ParameterSetName='RequestAdminAdd')]
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

    [Parameter(Mandatory = $True,
        ParameterSetName='RequestAdminAdd')]
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
    ${TargetId},

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
      
      if ($RequestType -eq $null -or $RequestType.Length -eq 0) {
          if ($AccessPackageAssignmentId -ne $null -and $AccessPackageAssignmentId.Length -ne 0) {
              $RequestType = "AdminRemove"
          } else {
              $RequestType = "AdminAdd"
          }
          write-debug "setting requesttype $RequestType"
      }
  
      if ($RequestType -ne "AdminRemove") {
         if ($null -ne $StartDate -or $StartDate.Length -eq 0) {
              $now = Get-Date
              $ts = Get-Date $now.ToUniversalTime() -format "s"
              $StartDate = $ts + "Z"
          }
      }
  
      $AccessPackageAssignmentRequestBodyAccessPackageAssignment = new-object microsoft.graph.powershell.models.MicrosoftGraphAccessPackageAssignment
      if ($AccessPackageAssignmentId -ne $null -and $AccessPackageAssignmentId.Length -ne 0) {
          $AccessPackageAssignmentRequestBodyAccessPackageAssignment.Id = $AccessPackageAssignmentId
      }
      if ($TargetId -ne $null -and $TargetId.Length -ne 0) {
          $AccessPackageAssignmentRequestBodyAccessPackageAssignment.TargetId = $TargetId
      }
      if ($AssignmentPolicyId -ne $null -and $AssignmentPolicyId.Length -ne 0) {
          $AccessPackageAssignmentRequestBodyAccessPackageAssignment.AssignmentPolicyId = $AssignmentPolicyId
      }
      if ($AccessPackageId -ne $null -and $AccessPackageId.Length -ne 0) {
          $AccessPackageAssignmentRequestBodyAccessPackageAssignment.AccessPackageId = $AccessPackageId
      }
      
      if ($null -ne $StartDate -and $StartDate.Length -ne 0) {
          $AccessPackageAssignmentRequestBodyAccessPackageAssignment.Schedule = new-object Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
          $AccessPackageAssignmentRequestBodyAccessPackageAssignment.Schedule.StartDateTime = $StartDate
      }
    
      $null = $PSBoundParameters.Remove("AccessPackageAssignmentId")
      $null = $PSBoundParameters.Remove("AccessPackageId")
      $null = $PSBoundParameters.Remove("AssignmentPolicyId")
      $null = $PSBoundParameters.Remove("TargetId")
      $null = $PSBoundParameters.Remove("StartDate")

      $PSBoundParameters['AccessPackageAssignment'] = $AccessPackageAssignmentRequestBodyAccessPackageAssignment

      $PSBoundParameters['Answers'] = $Answers
      if ($Justification -ne $null -and $Justification.Length -ne 0) {
        $PSBoundParameters['Justification'] = $Justification
      }
      $PSBoundParameters['RequestType'] = $RequestType
  
      try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $subecmd = 'Microsoft.Graph.Identity.Governance.private\New-MgEntitlementManagementAccessPackageAssignmentRequest_CreateExpanded'
        
        $subWrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($subecmd), [System.Management.Automation.CommandTypes]::Cmdlet)
        $subScriptCmd = {& $subWrappedCmd @PSBoundParameters}
        $steppablePipeline = $subScriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
  
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
