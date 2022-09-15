### Example 1: Create an access package assignment policy

```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'

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

AccessPackage            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackage1
AllowedTargetScope       : notSpecified
AutomaticRequestSettings : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAutomaticRequestSettings
Catalog                  : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog1
CreatedDateTime          : 9/15/2022 2:35:56 PM
Description              : policy for assignment
DisplayName              : New Policy
Expiration               : Microsoft.Graph.PowerShell.Models.MicrosoftGraphExpirationPattern
Id                       : c39f299c-4f4b-4065-b3ea-5b607e867738
ModifiedDateTime         : 9/15/2022 2:35:56 PM
RequestApprovalSettings  : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAssignmentApprovalSettings
RequestorSettings        : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAssignmentRequestorSettings
ReviewSettings           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAssignmentReviewSettings
SpecificAllowedTargets   : {}
AdditionalProperties     : {[@odata.context,
                           https://graph.microsoft.com/v1.0/$metadata#identityGovernance/entitlementManagement/assignmentPolicies/$entity]}
```

This example shows a request to create an access package assignment policy.
