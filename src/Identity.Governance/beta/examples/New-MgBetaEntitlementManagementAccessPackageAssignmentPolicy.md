### Example 1: Create a direct assignment policy

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	accessPackageId = "56ff43fd-6b05-48df-9634-956a777fce6d"
	displayName = "direct"
	description = "direct assignments by administrator"
	accessReviewSettings = $null
	requestorSettings = @{
		scopeType = "NoSubjects"
		acceptRequests = $true
		allowedRequestors = @(
		)
	}
	requestApprovalSettings = @{
		isApprovalRequired = $false
		isApprovalRequiredForExtension = $false
		isRequestorJustificationRequired = $false
		approvalMode = "NoApproval"
		approvalStages = @(
		)
	}
}

New-MgBetaEntitlementManagementAccessPackageAssignmentPolicy -BodyParameter $params

```
This example will create a direct assignment policy

### Example 2: Create a policy for users from other organizations to request

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	accessPackageId = "string (identifier)"
	displayName = "Users from connected organizations can request"
	description = "Allow users from configured connected organizations to request and be approved by their sponsors"
	canExtend = $false
	durationInDays = 365
	expirationDateTime = $null
	requestorSettings = @{
		scopeType = "AllExistingConnectedOrganizationSubjects"
		acceptRequests = $true
		allowedRequestors = @(
		)
	}
	requestApprovalSettings = @{
		isApprovalRequired = $true
		isApprovalRequiredForExtension = $false
		isRequestorJustificationRequired = $true
		approvalMode = "Serial"
		approvalStages = @(
			@{
				approvalStageTimeOutInDays = 14
				isApproverJustificationRequired = $true
				isEscalationEnabled = $true
				escalationTimeInMinutes = 11520
				primaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.groupMembers"
						isBackup = $true
						id = "string (identifier)"
						description = "group for users from connected organizations which have no external sponsor"
					}
					@{
						"@odata.type" = "#microsoft.graph.externalSponsors"
						isBackup = $false
					}
				)
				escalationApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.singleUser"
						isBackup = $true
						id = "string (identifier)"
						description = "user if the external sponsor does not respond"
					}
				)
			}
			@{
				approvalStageTimeOutInDays = 14
				isApproverJustificationRequired = $true
				isEscalationEnabled = $true
				escalationTimeInMinutes = 11520
				primaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.groupMembers"
						isBackup = $true
						id = "string (identifier)"
						description = "group for users from connected organizations which have no internal sponsor"
					}
					@{
						"@odata.type" = "#microsoft.graph.internalSponsors"
						isBackup = $false
					}
				)
				escalationApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.singleUser"
						isBackup = $true
						id = "string (identifier)"
						description = "user if the internal sponsor does not respond"
					}
				)
			}
		)
	}
	accessReviewSettings = @{
		isEnabled = $true
		recurrenceType = "quarterly"
		reviewerType = "Self"
		startDateTime = [System.DateTime]::Parse("2020-04-01T07:59:59.998Z")
		durationInDays = 25
		reviewers = @(
		)
	}
}

New-MgBetaEntitlementManagementAccessPackageAssignmentPolicy -BodyParameter $params

```
This example will create a policy for users from other organizations to request

### Example 3: Create assignment policy with questions

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	accessPackageId = "b2eba9a1-b357-42ee-83a8-336522ed6cbf"
	displayName = "Users from connected organizations can request"
	description = "Allow users from configured connected organizations to request and be approved by their sponsors"
	canExtend = $false
	durationInDays = 365
	expirationDateTime = $null
	requestorSettings = @{
		scopeType = "AllExistingConnectedOrganizationSubjects"
		acceptRequests = $true
	}
	requestApprovalSettings = @{
		isApprovalRequired = $true
		isApprovalRequiredForExtension = $false
		isRequestorJustificationRequired = $true
		approvalMode = "SingleStage"
		approvalStages = @(
			@{
				approvalStageTimeOutInDays = 14
				isApproverJustificationRequired = $true
				isEscalationEnabled = $false
				escalationTimeInMinutes = 11520
				primaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.groupMembers"
						isBackup = $true
						id = "d2dcb9a1-a445-42ee-83a8-476522ed6cbf"
						description = "group for users from connected organizations which have no external sponsor"
					}
					@{
						"@odata.type" = "#microsoft.graph.externalSponsors"
						isBackup = $false
					}
				)
			}
		)
	}
	questions = @(
		@{
			isRequired = $false
			text = @{
				defaultText = "what state are you from?"
				localizedTexts = @(
					@{
						text = "¿De qué estado eres?"
						languageCode = "es"
					}
				)
			}
			"@odata.type" = "#microsoft.graph.accessPackageMultipleChoiceQuestion"
			choices = @(
				@{
					actualValue = "AZ"
					displayValue = @{
						localizedTexts = @(
							@{
								text = "Arizona"
								languageCode = "es"
							}
						)
					}
				}
				@{
					actualValue = "CA"
					displayValue = @{
						localizedTexts = @(
							@{
								text = "California"
								languageCode = "es"
							}
						)
					}
				}
				@{
					actualValue = "OH"
					displayValue = @{
						localizedTexts = @(
							@{
								text = "Ohio"
								languageCode = "es"
							}
						)
					}
				}
			)
			allowsMultipleSelection = $false
		}
		@{
			isRequired = $false
			text = @{
				defaultText = "Who is your manager?"
				localizedTexts = @(
					@{
						text = "por qué necesita acceso a este paquete"
						languageCode = "es"
					}
				)
			}
			"@odata.type" = "#microsoft.graph.accessPackageTextInputQuestion"
			isSingleLineQuestion = $false
		}
	)
}

New-MgBetaEntitlementManagementAccessPackageAssignmentPolicy -BodyParameter $params

```
This example will create assignment policy with questions

### Example 4: Create a policy and specify the stages to trigger pre-defined custom workflow extensions

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "extension-policy"
	description = "test"
	accessPackageId = "ba5807c7-2aa9-4c8a-907e-4a17ee587500"
	expiration = @{
		type = "afterDuration"
		duration = "P365D"
	}
	canExtend = $false
	requestApprovalSettings = $null
	requestorSettings = @{
		acceptRequests = $true
		scopeType = "AllExistingDirectorySubjects"
		allowedRequestors = @(
		)
		isOnBehalfAllowed = $false
	}
	accessReviewSettings = $null
	questions = @(
	)
	customExtensionHandlers = @(
		@{
			stage = "assignmentRequestCreated"
			customExtension = @{
				id = "219f57b6-7983-45a1-be01-2c228b7a43f8"
			}
		}
		@{
			stage = "assignmentRequestGranted"
			customExtension = @{
				id = "219f57b6-7983-45a1-be01-2c228b7a43f8"
			}
		}
	)
}

New-MgBetaEntitlementManagementAccessPackageAssignmentPolicy -BodyParameter $params

```
This example will create a policy and specify the stages to trigger pre-defined custom workflow extensions

### Example 5: Create a policy and specify the stages to trigger pre-defined access package custom extensions

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "extension-policy"
	description = "test"
	accessPackageId = "ba5807c7-2aa9-4c8a-907e-4a17ee587500"
	expiration = @{
		type = "afterDuration"
		duration = "P365D"
	}
	canExtend = $false
	requestApprovalSettings = $null
	requestorSettings = @{
		acceptRequests = $true
		scopeType = "AllExistingDirectorySubjects"
		allowedRequestors = @(
		)
		isOnBehalfAllowed = $false
	}
	accessReviewSettings = $null
	questions = @(
	)
	customExtensionStageSettings = @(
		@{
			stage = "assignmentRequestCreated"
			customExtension = @{
				id = "219f57b6-7983-45a1-be01-2c228b7a43f8"
			}
		}
		@{
			stage = "assignmentRequestGranted"
			customExtension = @{
				id = "219f57b6-7983-45a1-be01-2c228b7a43f8"
			}
		}
	)
}

New-MgBetaEntitlementManagementAccessPackageAssignmentPolicy -BodyParameter $params

```
This example will create a policy and specify the stages to trigger pre-defined access package custom extensions

### Example 6: Create a policy with a verifiable credential requirement

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "policy-with-verified-id"
	description = "test"
	accessPackageId = "ba5807c7-2aa9-4c8a-907e-4a17ee587500"
	expiration = @{
		type = "afterDuration"
		duration = "P365D"
	}
	canExtend = $false
	requestApprovalSettings = $null
	requestorSettings = @{
		acceptRequests = $true
		scopeType = "AllExistingDirectorySubjects"
		allowedRequestors = @(
		)
		isOnBehalfAllowed = $false
	}
	accessReviewSettings = $null
	questions = @(
	)
	customExtensionHandlers = @(
	)
	verifiableCredentialSettings = @{
		credentialTypes = @(
			@{
				issuers = @(
				"did:ion:EiAlrenrtD3Lsw0GlbzS1O2YFdy3Xtu8yo35W<SNIP>..."
			)
			credentialType = "VerifiedCredentialExpert"
		}
	)
}
}

New-MgBetaEntitlementManagementAccessPackageAssignmentPolicy -BodyParameter $params

```
This example will create a policy with a verifiable credential requirement

