### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	detail = @{
		company = @{
			displayName = "Adventureworks Ltd."
			department = "Consulting"
			officeLocation = "AW23/344"
			address = @{
				type = "business"
				street = "123 Patriachy Ponds"
				city = "Moscow"
				countryOrRegion = "Russian Federation"
				postalCode = "RU-34621"
			}
			webUrl = "https://www.adventureworks.com"
		}
		jobTitle = "Senior Product Branding Manager II"
		role = "consulting"
	}
	isCurrent = $true
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfilePosition -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfilePosition Cmdlet.

