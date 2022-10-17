### Example 1: Using the Set-MgEntitlementManagementAccessPackageAssignmentPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Id = "4540a08f-8ab5-43f6-a923-015275799197"
	DisplayName = "policy with custom access package workflow extension"
	Description = "Run specified custom access package workflow extension at different stages."
	AccessPackageId = "ba5807c7-2aa9-4c8a-907e-4a17ee587500"
	RequestApprovalSettings = $null
	RequestorSettings = @{
		AcceptRequests = $true
		ScopeType = "AllExistingDirectorySubjects"
		AllowedRequestors = @(
		)
	}
	AccessReviewSettings = $null
	CustomExtensionHandlers = @(
	)
}
Set-MgEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId -BodyParameter $params
```
This example shows how to use the Set-MgEntitlementManagementAccessPackageAssignmentPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Set-MgEntitlementManagementAccessPackageAssignmentPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Id = "b2eba9a1-b357-42ee-83a8-336522ed6cbf"
	AccessPackageId = "4c02f928-7752-49aa-8fc8-e286d973a965"
	DisplayName = "All Users"
	Description = "All users can request for access to the directory."
	CanExtend = $false
	DurationInDays = 365
	ExpirationDateTime = $null
	RequestorSettings = @{
		ScopeType = "AllExistingConnectedOrganizationSubjects"
		AcceptRequests = $true
		AllowedRequestors = @(
		)
	}
	RequestApprovalSettings = @{
		IsApprovalRequired = $true
		IsApprovalRequiredForExtension = $false
		IsRequestorJustificationRequired = $true
		ApprovalMode = "SingleStage"
		ApprovalStages = @(
			@{
				ApprovalStageTimeOutInDays = 14
				IsApproverJustificationRequired = $true
				IsEscalationEnabled = $false
				EscalationTimeInMinutes = 11520
				PrimaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.groupMembers"
						IsBackup = $true
						Id = "d2dcb9a1-a445-42ee-83a8-476522ed6cbf"
						Description = "group for users from connected organizations which have no external sponsor"
					}
					@{
						"@odata.type" = "#microsoft.graph.externalSponsors"
						IsBackup = $false
					}
				)
			}
		)
	}
	Questions = @(
		@{
			IsRequired = $false
			Text = @{
				DefaultText = "what state are you from?"
				LocalizedTexts = @(
					@{
						Text = "¿De qué estado eres?"
						LanguageCode = "es"
					}
				)
			}
			"@odata.type" = "#microsoft.graph.accessPackageMultipleChoiceQuestion"
			Choices = @(
			)
			AllowsMultipleSelection = $false
		}
		@{
			IsRequired = $false
			Text = @{
				DefaultText = "Who is your manager?"
				LocalizedTexts = @(
					@{
						Text = "por qué necesita acceso a este paquete"
						LanguageCode = "es"
					}
				)
			}
			"@odata.type" = "#microsoft.graph.accessPackageTextInputQuestion"
			IsSingleLineQuestion = $false
		}
	)
}
Set-MgEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId -BodyParameter $params
```
This example shows how to use the Set-MgEntitlementManagementAccessPackageAssignmentPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
