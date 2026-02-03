### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	displayName = "Dion Matheson"
	givenName = "Dion"
	middleName = $null
	surname = "Matheson"
	mail = "DionM@contoso.com"
	mobilePhone = "+1 (253) 555-0101"
	createdBy = @{
		user = @{
			displayName = "Susana Rocha"
			id = "14012"
		}
	}
	externalSource = "sis"
	mailingAddress = @{
		city = "Los Angeles"
		countryOrRegion = "United States"
		postalCode = "98055"
		state = "CA"
		street = "12345 Main St."
	}
	primaryRole = "student"
	residenceAddress = @{
		city = "Los Angeles"
		countryOrRegion = "United States"
		postalCode = "98055"
		state = "CA"
		street = "12345 Main St."
	}
}

New-MgBetaEducationUser -BodyParameter $params

```
This example shows how to use the New-MgBetaEducationUser Cmdlet.

