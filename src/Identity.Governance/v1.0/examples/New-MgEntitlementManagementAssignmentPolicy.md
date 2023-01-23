### Example 1: Using the New-MgEntitlementManagementAssignmentPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "policy for external access requests"
	Description = "policy for users from connected organizations to request access, with two stages of approval."
	AllowedTargetScope = "allConfiguredConnectedOrganizationUsers"
	SpecificAllowedTargets = @(
	)
	Expiration = @{
		Type = "noExpiration"
	}
	RequestorSettings = @{
		EnableTargetsToSelfAddAccess = $true
		EnableTargetsToSelfUpdateAccess = $true
		EnableTargetsToSelfRemoveAccess = $true
		AllowCustomAssignmentSchedule = $false
		EnableOnBehalfRequestorsToAddAccess = $false
		EnableOnBehalfRequestorsToUpdateAccess = $false
		EnableOnBehalfRequestorsToRemoveAccess = $false
		OnBehalfRequestors = @(
		)
	}
	RequestApprovalSettings = @{
		IsApprovalRequiredForAdd = $true
		IsApprovalRequiredForUpdate = $false
		Stages = @(
			@{
				DurationBeforeAutomaticDenial = "P14D"
				IsApproverJustificationRequired = $false
				IsEscalationEnabled = $false
				DurationBeforeEscalation = "PT0S"
				PrimaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.internalSponsors"
					}
				)
				FallbackPrimaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.singleUser"
						UserId = "7deff43e-1f17-44ef-9e5f-d516b0ba11d4"
					}
					@{
						"@odata.type" = "#microsoft.graph.groupMembers"
						GroupId = "1623f912-5e86-41c2-af47-39dd67582b66"
					}
				)
				EscalationApprovers = @(
				)
				FallbackEscalationApprovers = @(
				)
			}
			@{
				DurationBeforeAutomaticDenial = "P14D"
				IsApproverJustificationRequired = $false
				IsEscalationEnabled = $false
				DurationBeforeEscalation = "PT0S"
				PrimaryApprovers = @(
				)
				FallbackPrimaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.singleUser"
						UserId = "46184453-e63b-4f20-86c2-c557ed5d5df9"
					}
					@{
						"@odata.type" = "#microsoft.graph.groupMembers"
						GroupId = "1623f912-5e86-41c2-af47-39dd67582b66"
					}
				)
				EscalationApprovers = @(
				)
				FallbackEscalationApprovers = @(
				)
			}
		)
	}
	ReviewSettings = @{
		IsEnabled = $true
		ExpirationBehavior = "keepAccess"
		IsRecommendationEnabled = $true
		IsReviewerJustificationRequired = $true
		IsSelfReview = $false
		Schedule = @{
			StartDateTime = [System.DateTime]::Parse("2022-07-02T06:59:59.998Z")
			Expiration = @{
				Duration = "P14D"
				Type = "afterDuration"
			}
			Recurrence = @{
				Pattern = @{
					Type = "absoluteMonthly"
					Interval = 3
					Month = 0
					DayOfMonth = 0
					DaysOfWeek = @(
					)
				}
				Range = @{
					Type = "noEnd"
					NumberOfOccurrences = 0
				}
			}
		}
		PrimaryReviewers = @(
			@{
				"@odata.type" = "#microsoft.graph.groupMembers"
				GroupId = "1623f912-5e86-41c2-af47-39dd67582b66"
			}
		)
		FallbackReviewers = @(
		)
	}
	AccessPackage = @{
		Id = "a2e1ca1e-4e56-47d2-9daa-e2ba8d12a82b"
	}
}
New-MgEntitlementManagementAssignmentPolicy -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementAssignmentPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgEntitlementManagementAssignmentPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "New Policy"
	Description = "policy for assignment"
	AllowedTargetScope = "notSpecified"
	SpecificAllowedTargets = @(
	)
	Expiration = @{
		EndDateTime = $null
		Duration = $null
		Type = "noExpiration"
	}
	RequestorSettings = @{
		EnableTargetsToSelfAddAccess = $false
		EnableTargetsToSelfUpdateAccess = $false
		EnableTargetsToSelfRemoveAccess = $false
		AllowCustomAssignmentSchedule = $true
		EnableOnBehalfRequestorsToAddAccess = $false
		EnableOnBehalfRequestorsToUpdateAccess = $false
		EnableOnBehalfRequestorsToRemoveAccess = $false
		OnBehalfRequestors = @(
		)
	}
	RequestApprovalSettings = @{
		IsApprovalRequiredForAdd = $false
		IsApprovalRequiredForUpdate = $false
		Stages = @(
		)
	}
	AccessPackage = @{
		Id = "a2e1ca1e-4e56-47d2-9daa-e2ba8d12a82b"
	}
}
New-MgEntitlementManagementAssignmentPolicy -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementAssignmentPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
