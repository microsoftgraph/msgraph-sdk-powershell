### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

$params = @{
	"@odata.type" = "#microsoft.graph.educationUser"
	primaryRole = "String"
	middleName = "String"
	externalSource = "String"
	externalSourceDetail = "String"
	residenceAddress = @{
		"@odata.type" = "microsoft.graph.physicalAddress"
	}
	mailingAddress = @{
		"@odata.type" = "microsoft.graph.physicalAddress"
	}
	student = @{
		"@odata.type" = "microsoft.graph.educationStudent"
	}
	teacher = @{
		"@odata.type" = "microsoft.graph.educationTeacher"
	}
	createdBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
	accountEnabled = "Boolean"
	assignedLicenses = @(
		@{
			"@odata.type" = "microsoft.graph.assignedLicense"
		}
	)
	assignedPlans = @(
		@{
			"@odata.type" = "microsoft.graph.assignedPlan"
		}
	)
	businessPhones = @(
		"String"
	)
	department = "String"
	displayName = "String"
	givenName = "String"
	mail = "String"
	mailNickname = "String"
	mobilePhone = "String"
	passwordPolicies = "String"
	passwordProfile = @{
		"@odata.type" = "microsoft.graph.passwordProfile"
	}
	officeLocation = "String"
	preferredLanguage = "String"
	provisionedPlans = @(
		@{
			"@odata.type" = "microsoft.graph.provisionedPlan"
		}
	)
	refreshTokensValidFromDateTime = [System.DateTime]::Parse("String (timestamp)")
	showInAddressList = "Boolean"
	surname = "String"
	usageLocation = "String"
	userPrincipalName = "String"
	userType = "String"
	onPremisesInfo = @{
		"@odata.type" = "microsoft.graph.educationOnPremisesInfo"
	}
}

New-MgBetaEducationUser -BodyParameter $params
```
This example shows how to use the New-MgBetaEducationUser Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

