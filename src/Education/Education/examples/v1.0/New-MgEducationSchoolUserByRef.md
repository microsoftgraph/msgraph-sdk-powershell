### Example 1: Using the New-MgEducationSchoolUserByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/education/users/14008"
}
New-MgEducationSchoolUserByRef -EducationSchoolId $educationSchoolId -BodyParameter $params
```
This example shows how to use the New-MgEducationSchoolUserByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
