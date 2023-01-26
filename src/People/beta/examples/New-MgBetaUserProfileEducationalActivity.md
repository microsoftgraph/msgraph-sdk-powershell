### Example 1: Using the New-MgBetaUserProfileEducationalActivity Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	CompletionMonthYear = "Date"
	EndMonthYear = "Date"
	Institution = @{
		Description = $null
		DisplayName = "Colorado State University"
		Location = @{
			Type = "business"
			PostOfficeBox = $null
			Street = "12000 E Prospect Rd"
			City = "Fort Collins"
			State = "Colorado"
			CountryOrRegion = "USA"
			PostalCode = "80525"
		}
		WebUrl = "https://www.colostate.edu"
	}
	Program = @{
		Abbreviation = "MBA"
		Activities = $null
		Awards = $null
		Description = "Master of Business Administration with a major in Entreprenuership and Finance."
		DisplayName = "Master of Business Administration"
		FieldsOfStudy = $null
		Grade = "3.9"
		Notes = $null
		WebUrl = "https://biz.colostate.edu"
	}
	StartMonthYear = "Date"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileEducationalActivity -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileEducationalActivity Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
