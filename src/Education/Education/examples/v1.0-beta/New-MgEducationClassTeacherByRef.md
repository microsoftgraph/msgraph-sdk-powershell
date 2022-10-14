### Example 1: Using the New-MgEducationClassTeacherByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/education/users/14011"
}
New-MgEducationClassTeacherByRef -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassTeacherByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
