### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	completionMonthYear = "Date"
	endMonthYear = "Date"
	institution = @{
		description = $null
		displayName = "Colorado State University"
		location = @{
			type = "business"
			postOfficeBox = $null
			street = "12000 E Prospect Rd"
			city = "Fort Collins"
			state = "Colorado"
			countryOrRegion = "USA"
			postalCode = "80525"
		}
		webUrl = "https://www.colostate.edu"
	}
	program = @{
		abbreviation = "MBA"
		activities = $null
		awards = $null
		description = "Master of Business Administration with a major in Entreprenuership and Finance."
		displayName = "Master of Business Administration"
		fieldsOfStudy = $null
		grade = "3.9"
		notes = $null
		webUrl = "https://biz.colostate.edu"
	}
	startMonthYear = "Date"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileEducationalActivity -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileEducationalActivity Cmdlet.

