### Example 1: Code snippet

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
This example shows how to use the New-MgEntitlementManagementAssignmentPolicy Cmdlet.

### Example 2: Code snippet

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
This example shows how to use the New-MgEntitlementManagementAssignmentPolicy Cmdlet.

### Example 3: Code snippet

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
This example shows how to use the New-MgEntitlementManagementAssignmentPolicy Cmdlet.

### Example 4: Code snippet

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
This example shows how to use the New-MgEntitlementManagementAssignmentPolicy Cmdlet.

