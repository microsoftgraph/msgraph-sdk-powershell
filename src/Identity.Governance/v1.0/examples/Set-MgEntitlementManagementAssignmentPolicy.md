### Example 1: Update the details of a policy

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
This example will update the details of a policy

### Example 2: Remove the customExtensionStageSettings from a policy

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	id = "5540a08f-8ab5-43f6-a923-015275799197"
	displayName = "policy with access package custom workflow extension"
	description = "Run specified access package custom workflow extension at different stages."
	accessPackageId = "ba5807c7-2aa9-4c8a-907e-4a17ee587500"
	expiration = @{
		type = "afterDuration"
		duration = "P365D"
	}
	requestApprovalSettings = $null
	requestorSettings = @{
		acceptRequests = $true
		scopeType = "AllExistingDirectorySubjects"
		allowedRequestors = @(
		)
	}
	accessReviewSettings = $null
	customExtensionStageSettings = @(
	)
}

Set-MgEntitlementManagementAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId -BodyParameter $params

```
This example will remove the customextensionstagesettings from a policy

### Example 3: Update the customExtensionStageSettings for a policy

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "API Created policy with updated customExtensionStageSettings"
	description = "policy with updated customExtensionStageSettings"
	allowedTargetScope = "notSpecified"
	specificAllowedTargets = @(
	)
	expiration = @{
		endDateTime = $null
		duration = $null
		type = "noExpiration"
	}
	requestorSettings = @{
		enableTargetsToSelfAddAccess = $false
		enableTargetsToSelfUpdateAccess = $false
		enableTargetsToSelfRemoveAccess = $false
		allowCustomAssignmentSchedule = $true
		enableOnBehalfRequestorsToAddAccess = $false
		enableOnBehalfRequestorsToUpdateAccess = $false
		enableOnBehalfRequestorsToRemoveAccess = $false
		onBehalfRequestors = @(
		)
	}
	requestApprovalSettings = @{
		isApprovalRequiredForAdd = $false
		isApprovalRequiredForUpdate = $false
		stages = @(
		)
	}
	accessPackage = @{
		id = "f9afd2e3-7486-40df-9c35-aa2ae108c495"
	}
	customExtensionStageSettings = @(
		@{
			stage = "assignmentRequestCreated"
			customExtension = @{
				"@odata.type" = "#microsoft.graph.accessPackageAssignmentRequestWorkflowExtension"
				id = "bebe7873-1f0d-4db9-b6c3-01f7ebfe8476"
			}
		}
	)
}

Set-MgEntitlementManagementAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId -BodyParameter $params

```
This example will update the customextensionstagesettings for a policy

