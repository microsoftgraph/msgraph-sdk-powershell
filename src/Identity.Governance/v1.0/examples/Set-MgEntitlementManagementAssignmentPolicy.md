### Example 1: Using the Set-MgEntitlementManagementAssignmentPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Id = "87e1c7f7-c7f7-87e1-f7c7-e187f7c7e187"
	DisplayName = "All Users"
	Description = "All users can request for access to the directory."
	AllowedTargetScope = "allDirectoryUsers"
	AutomaticRequestSettings = $null
	SpecificAllowedTargets = @(
	)
	Expiration = @{
		Type = "noExpiration"
	}
	RequestorSettings = @{
		EnableTargetsToSelfAddAccess = $true
		EnableTargetsToSelfUpdateAccess = $false
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
				DurationBeforeAutomaticDenial = "P2D"
				IsApproverJustificationRequired = $false
				IsEscalationEnabled = $false
				DurationBeforeEscalation = "PT0S"
				PrimaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.requestorManager"
						ManagerLevel = 
					}
				)
				FallbackPrimaryApprovers = @(
					@{
						"@odata.type" = "#microsoft.graph.singleUser"
						UserId = "e6bf4d7d-6824-4dd0-809d-5bf42d4817c2"
						Description = "user"
					}
				)
				EscalationApprovers = @(
				)
				FallbackEscalationApprovers = @(
				)
			}
		)
	}
	AccessPackage = @{
		Id = "49d2c59b-0a81-463d-a8ec-ddad3935d8a0"
	}
}
Set-MgEntitlementManagementAssignmentPolicy -AccessPackageAssignmentPolicyId $accessPackageAssignmentPolicyId -BodyParameter $params
```
This example shows how to use the Set-MgEntitlementManagementAssignmentPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
