### Example 1
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/education/users/14011"
}
New-MgEducationClassTeacherByRef -EducationClassId $educationClassId -BodyParameter $params
```
