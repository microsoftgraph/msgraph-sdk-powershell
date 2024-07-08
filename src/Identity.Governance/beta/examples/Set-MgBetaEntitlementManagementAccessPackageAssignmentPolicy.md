### Example 1: Update the details of a policy

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	id = "b2eba9a1-b357-42ee-83a8-336522ed6cbf"
	accessPackageId = "4c02f928-7752-49aa-8fc8-e286d973a965"
	displayName = "All Users"
	description = "All users can request for access to the directory."
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

Set-MgBetaEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId -BodyParameter $params

```
This example will update the details of a policy

### Example 2: Remove the customExtensionHandlers and verifiableCredentialSettings from a policy

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	id = "4540a08f-8ab5-43f6-a923-015275799197"
	displayName = "policy with custom access package workflow extension"
	description = "Run specified custom access package workflow extension at different stages."
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
	customExtensionHandlers = @(
	)
}

Set-MgBetaEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId -BodyParameter $params

```
This example will remove the customextensionhandlers and verifiablecredentialsettings from a policy

### Example 3: Remove the customExtensionStageSettings from a policy

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

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
	customExtensionHandlers = @(
	)
}

Set-MgBetaEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId -BodyParameter $params

```
This example will remove the customextensionstagesettings from a policy

