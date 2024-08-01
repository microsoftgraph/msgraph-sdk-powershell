### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	id = "87e1c7f7-c7f7-87e1-f7c7-e187f7c7e187"
	displayName = "All Users"
	description = "All users can request for access to the directory."
	allowedTargetScope = "allDirectoryUsers"
	automaticRequestSettings = $null
	specificAllowedTargets = @(
	)
	expiration = @{
		type = "noExpiration"
	}
	requestorSettings = @{
		enableTargetsToSelfAddAccess = $true
		enableTargetsToSelfUpdateAccess = $false
		enableTargetsToSelfRemoveAccess = $true
		allowCustomAssignmentSchedule = $false
		enableOnBehalfRequestorsToAddAccess = $false
		enableOnBehalfRequestorsToUpdateAccess = $false
		enableOnBehalfRequestorsToRemoveAccess = $false
		onBehalfRequestors = @(
		)
	}
	requestApprovalSettings = @{
		isApprovalRequiredForAdd = $true
		isApprovalRequiredForUpdate = $false
		stages = @(
			@{
				durationBeforeAutomaticDenial = "P2D"
				isApproverJustificationRequired = $false
				isEscalationEnabled = $false
				durationBeforeEscalation = "PT0S"
				primaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.requestorManager"
						managerLevel = 
					}
				)
				fallbackPrimaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.singleUser"
						userId = "e6bf4d7d-6824-4dd0-809d-5bf42d4817c2"
						description = "user"
					}
				)
				escalationApprovers = @(
				)
				fallbackEscalationApprovers = @(
				)
			}
		)
	}
	accessPackage = @{
		id = "49d2c59b-0a81-463d-a8ec-ddad3935d8a0"
	}
}

Set-MgEntitlementManagementAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId -BodyParameter $params

```
This example shows how to use the Set-MgEntitlementManagementAssignmentPolicy Cmdlet.

