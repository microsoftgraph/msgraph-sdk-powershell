### Example 1: Using the Update-MgEducationUser Cmdlet
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
