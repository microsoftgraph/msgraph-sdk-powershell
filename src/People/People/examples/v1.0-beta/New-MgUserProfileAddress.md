### Example 1: Using the New-MgBetaUserProfileAddress Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	DisplayName = "Home"
	Detail = @{
		Type = "home"
		PostOfficeBox = $null
		Street = "221B Baker Street"
		City = "London"
		State = $null
		CountryOrRegion = "United Kingdom"
		PostalCode = "E14 3TD"
	}
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileAddress -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileAddress Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
