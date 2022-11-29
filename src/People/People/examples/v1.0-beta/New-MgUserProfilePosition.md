### Example 1: Using the New-MgUserProfilePosition Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Detail = @{
		Company = @{
			DisplayName = "Adventureworks Ltd."
			Department = "Consulting"
			OfficeLocation = "AW23/344"
			Address = @{
				Type = "business"
				Street = "123 Patriachy Ponds"
				City = "Moscow"
				CountryOrRegion = "Russian Federation"
				PostalCode = "RU-34621"
			}
			WebUrl = "https://www.adventureworks.com"
		}
		JobTitle = "Senior Product Branding Manager II"
		Role = "consulting"
	}
	IsCurrent = $true
}
# A UPN can also be used as -UserId.
New-MgUserProfilePosition -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfilePosition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
