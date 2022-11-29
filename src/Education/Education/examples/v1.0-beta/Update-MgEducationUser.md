### Example 1: Using the Update-MgEducationUser Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	RelatedContacts = @(
		@{
			DisplayName = "Father Time"
			EmailAddress = "father@time.com"
			MobilePhone = "4251231234"
			Relationship = "guardian"
			AccessConsent = $true
		}
		@{
			DisplayName = "Mother Nature"
			EmailAddress = "mother@nature.co.uk"
			MobilePhone = "3251231234"
			Relationship = "parent"
			AccessConsent = $true
		}
	)
}
Update-MgEducationUser -EducationUserId $educationUserId -BodyParameter $params
```
This example shows how to use the Update-MgEducationUser Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgEducationUser Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DisplayName = "Rogelio Cazares"
	GivenName = "Rogelio"
	MiddleName = "Fernando"
	Surname = "Cazares"
}
Update-MgEducationUser -EducationUserId $educationUserId -BodyParameter $params
```
This example shows how to use the Update-MgEducationUser Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Update-MgEducationUser Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DisplayName = "Rogelio Cazares"
	GivenName = "Rogelio"
	MiddleName = "Fernando"
	Surname = "Cazares"
}
Update-MgEducationUser -EducationUserId $educationUserId -BodyParameter $params
```
This example shows how to use the Update-MgEducationUser Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
