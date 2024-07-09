### Example 1: Admin requests a direct assignment for a user already in the directory

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	requestType = "adminAdd"
	assignment = @{
		targetId = "46184453-e63b-4f20-86c2-c557ed5d5df9"
		assignmentPolicyId = "2264bf65-76ba-417b-a27d-54d291f0cbc8"
		accessPackageId = "a914b616-e04e-476b-aa37-91038f0b165b"
	}
}

New-MgEntitlementManagementAssignmentRequest -BodyParameter $params

```
This example will admin requests a direct assignment for a user already in the directory

### Example 2: Remove an assignment

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	requestType = "adminRemove"
	assignment = @{
		id = "a6bb6942-3ae1-4259-9908-0133aaee9377"
	}
}

New-MgEntitlementManagementAssignmentRequest -BodyParameter $params

```
This example will remove an assignment

### Example 3: Request an assignment by providing answers to questions

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.accessPackageAssignmentRequest"
	requestType = "userAdd"
	answers = @(
		@{
			"@odata.type" = "#microsoft.graph.accessPackageAnswerString"
			displayValue = "This is the answer to a multiple choice question"
			value = "MultipleChoiceAnswerValue"
			answeredQuestion = @{
				"@odata.type" = "#microsoft.graph.accessPackageMultipleChoiceQuestion"
				id = "8fe745e7-80b2-490d-bd22-4e708c77288c"
			}
		}
		@{
			"@odata.type" = "#microsoft.graph.accessPackageAnswerString"
			value = "This is my answer to a text input question."
			displayValue = "This is my answer."
			answeredQuestion = @{
				"@odata.type" = "#microsoft.graph.accessPackageTextInputQuestion"
				id = "7aaa18c9-8e4f-440f-bd5a-3a7ce312cbe6"
			}
		}
	)
	assignment = @{
		accessPackageId = "977c7ff4-ef8f-4910-9d31-49048ddf3120"
	}
}

New-MgEntitlementManagementAssignmentRequest -BodyParameter $params

```
This example will request an assignment by providing answers to questions

### Example 4: Request a package and provide a justification

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	requestType = "UserAdd"
	accessPackageAssignment = @{
		accessPackageId = "a914b616-e04e-476b-aa37-91038f0b165b"
	}
	justification = "Need access to New Hire access package"
}

New-MgEntitlementManagementAssignmentRequest -BodyParameter $params

```
This example will request a package and provide a justification

### Example 5: Admin requests a direct assignment for a user not yet in the directory

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	requestType = "AdminAdd"
	accessPackageAssignment = @{
		target = @{
			email = "user@contoso.com"
		}
		assignmentPolicyId = "2264bf65-76ba-417b-a27d-54d291f0cbc8"
		accessPackageId = "a914b616-e04e-476b-aa37-91038f0b165b"
	}
}

New-MgEntitlementManagementAssignmentRequest -BodyParameter $params

```
This example will admin requests a direct assignment for a user not yet in the directory

### Example 6: Request an update to answers for an assignment

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.accessPackageAssignmentRequest"
	id = "7a6ab703-0780-4b37-8445-81f679b2d75c"
	requestType = "adminUpdate"
	answers = @(
		@{
			"@odata.type" = "#microsoft.graph.accessPackageAnswerString"
			value = "UpdatedAnswerValue"
			answeredQuestion = @{
				"@odata.type" = "#microsoft.graph.accessPackageMultipleChoiceQuestion"
				id = "8fe745e7-80b2-490d-bd22-4e708c77288c"
			}
		}
		@{
			"@odata.type" = "#microsoft.graph.accessPackageAnswerString"
			value = "My updated answer."
			displayValue = "This is my updated answer to the question."
			answeredQuestion = @{
				"@odata.type" = "#microsoft.graph.accessPackageTextInputQuestion"
				id = "7aaa18c9-8e4f-440f-bd5a-3a7ce312cbe6"
			}
		}
	)
	assignment = @{
		id = "44c741c1-2cf4-40db-83b6-e0112f8e5a83"
	}
}

New-MgEntitlementManagementAssignmentRequest -BodyParameter $params

```
This example will request an update to answers for an assignment

### Example 7: Update the expiration date for an access package assignment

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.accessPackageAssignmentRequest"
	requestType = "adminUpdate"
	schedule = @{
		startDateTime = [System.DateTime]::Parse("2023-05-23T20:04:02.39Z")
		recurrence = $null
		expiration = @{
			endDateTime = [System.DateTime]::Parse("2024-07-01T00:00:00.00Z")
			duration = $null
			type = "afterDateTime"
		}
	}
	assignment = @{
		id = "329f8dac-8062-4c1b-a9b8-39b7132f9bff"
	}
}

New-MgEntitlementManagementAssignmentRequest -BodyParameter $params

```
This example will update the expiration date for an access package assignment

