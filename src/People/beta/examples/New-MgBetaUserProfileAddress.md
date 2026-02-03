### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	displayName = "Home"
	detail = @{
		type = "home"
		postOfficeBox = $null
		street = "221B Baker Street"
		city = "London"
		state = $null
		countryOrRegion = "United Kingdom"
		postalCode = "E14 3TD"
	}
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileAddress -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileAddress Cmdlet.

