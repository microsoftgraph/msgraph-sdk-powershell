### Example 1: Using the New-MgEducationSchoolClassByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/education/classes/11006"
}
New-MgEducationSchoolClassByRef -EducationSchoolId $educationSchoolId -BodyParameter $params
```
This example shows how to use the New-MgEducationSchoolClassByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
