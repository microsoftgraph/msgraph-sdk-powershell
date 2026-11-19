### Example 1: Create a direct assignment policy

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "New Policy"
	description = "policy for assignment"
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
		id = "a2e1ca1e-4e56-47d2-9daa-e2ba8d12a82b"
	}
}

New-MgEntitlementManagementAssignmentPolicy -BodyParameter $params

```
This example will create a direct assignment policy

### Example 2: Create a policy for users from other organizations to request

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "policy for external access requests"
	description = "policy for users from connected organizations to request access, with two stages of approval."
	allowedTargetScope = "allConfiguredConnectedOrganizationUsers"
	specificAllowedTargets = @(
	)
	expiration = @{
		type = "noExpiration"
	}
	requestorSettings = @{
		enableTargetsToSelfAddAccess = $true
		enableTargetsToSelfUpdateAccess = $true
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
				durationBeforeAutomaticDenial = "P14D"
				isApproverJustificationRequired = $false
				isEscalationEnabled = $false
				durationBeforeEscalation = "PT0S"
				primaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.internalSponsors"
					}
				)
				fallbackPrimaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.singleUser"
						userId = "7deff43e-1f17-44ef-9e5f-d516b0ba11d4"
					}
					@{
						"@odata.type" = "#microsoft.graph.groupMembers"
						groupId = "1623f912-5e86-41c2-af47-39dd67582b66"
					}
				)
				escalationApprovers = @(
				)
				fallbackEscalationApprovers = @(
				)
			}
			@{
				durationBeforeAutomaticDenial = "P14D"
				isApproverJustificationRequired = $false
				isEscalationEnabled = $false
				durationBeforeEscalation = "PT0S"
				primaryApprovers = @(
				)
				fallbackPrimaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.singleUser"
						userId = "46184453-e63b-4f20-86c2-c557ed5d5df9"
					}
					@{
						"@odata.type" = "#microsoft.graph.groupMembers"
						groupId = "1623f912-5e86-41c2-af47-39dd67582b66"
					}
				)
				escalationApprovers = @(
				)
				fallbackEscalationApprovers = @(
				)
			}
		)
	}
	reviewSettings = @{
		isEnabled = $true
		expirationBehavior = "keepAccess"
		isRecommendationEnabled = $true
		isReviewerJustificationRequired = $true
		isSelfReview = $false
		schedule = @{
			startDateTime = [System.DateTime]::Parse("2022-07-02T06:59:59.998Z")
			expiration = @{
				duration = "P14D"
				type = "afterDuration"
			}
			recurrence = @{
				pattern = @{
					type = "absoluteMonthly"
					interval = 3
					month = 0
					dayOfMonth = 0
					daysOfWeek = @(
					)
				}
				range = @{
					type = "noEnd"
					numberOfOccurrences = 0
				}
			}
		}
		primaryReviewers = @(
			@{
				"@odata.type" = "#microsoft.graph.groupMembers"
				groupId = "1623f912-5e86-41c2-af47-39dd67582b66"
			}
		)
		fallbackReviewers = @(
		)
	}
	accessPackage = @{
		id = "a2e1ca1e-4e56-47d2-9daa-e2ba8d12a82b"
	}
}

New-MgEntitlementManagementAssignmentPolicy -BodyParameter $params

```
This example will create a policy for users from other organizations to request

### Example 3: Create a policy that automatically creates assignments based on a membership rule

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "Sales department users"
	description = "All users from sales department"
	allowedTargetScope = "specificDirectoryUsers"
	specificAllowedTargets = @(
		@{
			"@odata.type" = "#microsoft.graph.attributeRuleMembers"
			description = "Membership rule for all users from sales department"
			membershipRule = "(user.department -eq "Sales")"
		}
	)
	automaticRequestSettings = @{
		requestAccessForAllowedTargets = $true
		removeAccessWhenTargetLeavesAllowedTargets = $true
		gracePeriodBeforeAccessRemoval = "P7D"
	}
	accessPackage = @{
		id = "8a36831e-1527-4b2b-aff2-81259a8d8e76"
	}
}

New-MgEntitlementManagementAssignmentPolicy -BodyParameter $params

```
This example will create a policy that automatically creates assignments based on a membership rule

### Example 4: Create a policy where requestors are asked to answer questions while requesting access to provide additional information to approvers

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "A Policy With Questions"
	description = ""
	allowedTargetScope = "allMemberUsers"
	expiration = @{
		type = "noExpiration"
	}
	requestorSettings = @{
		enableTargetsToSelfAddAccess = "true"
		enableTargetsToSelfUpdateAccess = "true"
		enableTargetsToSelfRemoveAccess = "true"
	}
	requestApprovalSettings = @{
		isApprovalRequiredForAdd = "true"
		isApprovalRequiredForUpdate = "true"
		stages = @(
			@{
				durationBeforeAutomaticDenial = "P7D"
				isApproverJustificationRequired = "false"
				isEscalationEnabled = "false"
				fallbackPrimaryApprovers = @(
				)
				escalationApprovers = @(
				)
				fallbackEscalationApprovers = @(
				)
				primaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.singleUser"
						userId = "08a551cb-575a-4343-b914-f6e42798bd20"
					}
				)
			}
		)
	}
	questions = @(
		@{
			"@odata.type" = "#microsoft.graph.accessPackageMultipleChoiceQuestion"
			sequence = "1"
			isRequired = "true"
			isAnswerEditable = "true"
			text = "What country are you working from?"
			isMultipleSelectionAllowed = "false"
			choices = @(
				@{
					"@odata.type" = "microsoft.graph.accessPackageAnswerChoice"
					actualValue = "KE"
					text = "Kenya"
				}
				@{
					"@odata.type" = "microsoft.graph.accessPackageAnswerChoice"
					actualValue = "US"
					text = "United States"
				}
				@{
					"@odata.type" = "microsoft.graph.accessPackageAnswerChoice"
					actualValue = "GY"
					text = "Guyana"
				}
				@{
					"@odata.type" = "microsoft.graph.accessPackageAnswerChoice"
					actualValue = "BD"
					text = "Bangladesh"
				}
				@{
					"@odata.type" = "microsoft.graph.accessPackageAnswerChoice"
					actualValue = "JP"
					text = "Japan"
				}
			)
		}
		@{
			"@odata.type" = "#microsoft.graph.accessPackageTextInputQuestion"
			sequence = "2"
			isRequired = "true"
			isAnswerEditable = "true"
			text = "What do you do for work?"
			localizations = @(
				@{
					languageCode = "fr-CA"
					text = "Que fais-tu comme travail?"
				}
			)
			isSingleLineQuestion = "false"
			regexPattern = "[a-zA-Z]+[a-zA-Z\s]*"
		}
	)
	accessPackage = @{
		id = "977c7ff4-ef8f-4910-9d31-49048ddf3120"
	}
}

New-MgEntitlementManagementAssignmentPolicy -BodyParameter $params

```
This example will create a policy where requestors are asked to answer questions while requesting access to provide additional information to approvers

### Example 5: Create a policy and specify the stages to trigger predefined access package custom extensions

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "customExtensionStageSettings policy"
	description = "policy with specified stages for custom extension assignment"
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
		id = "5ad1eb64-15f7-4614-b419-05d11ee266bf"
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

New-MgEntitlementManagementAssignmentPolicy -BodyParameter $params

```
This example will create a policy and specify the stages to trigger predefined access package custom extensions

### Example 6: Create a policy used to determine approvers dynamically from a Logic App

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	"@odata.context" = "https://graph.microsoft.com/v1.0/$metadata#identityGovernance/entitlementManagement/accessPackageAssignmentPolicies/$entity"
	displayName = "Dynamic approver policy"
	description = "Dynamic approver policy"
	canExtend = $false
	durationInDays = 
	expirationDateTime = $null
	accessPackageId = "fc29cdca-57f6-47e3-b20c-3fa18e4826ac"
	accessReviewSettings = $null
	questions = @(
	)
	accessPackageNotificationSettings = @{
		isAssignmentNotificationDisabled = $false
	}
	verifiableCredentialSettings = @{
		credentialTypes = @(
		)
	}
	requestorSettings = @{
		scopeType = "AllExistingDirectorySubjects"
		acceptRequests = $true
		allowedRequestors = @(
		)
	}
	requestApprovalSettings = @{
		isApprovalRequired = $true
		isApprovalRequiredForExtension = $false
		isRequestorJustificationRequired = $true
		approvalMode = "SingleStage"
		approvalStages = @(
			@{
				"@odata.type" = "#microsoft.graph.accessPackageDynamicApprovalStage"
				customExtension = @{
					"@odata.type" = "#microsoft.graph.accessPackageAssignmentRequestWorkflowExtension"
					id = "52036a43-10b5-444d-a1a2-d4f240420239"
				}
			}
		)
	}
	customExtensionStageSettings = @(
		@{
			stage = "assignmentRequestDeterminingApprovalRequirements"
			customExtension = @{
				"@odata.type" = "#microsoft.graph.accessPackageAssignmentRequestWorkflowExtension"
				id = "52036a43-10b5-444d-a1a2-d4f240420239"
			}
		}
	)
}

New-MgEntitlementManagementAssignmentPolicy -BodyParameter $params

```
This example will create a policy used to determine approvers dynamically from a logic app

