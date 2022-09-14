### Example 1
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
