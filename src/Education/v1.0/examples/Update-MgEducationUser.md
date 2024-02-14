### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	displayName = "Rogelio Cazares"
	givenName = "Rogelio"
	middleName = "Fernando"
	surname = "Cazares"
}

Update-MgEducationUser -EducationUserId $educationUserId -BodyParameter $params

```
This example shows how to use the Update-MgEducationUser Cmdlet.

