### Example 1: Using the Update-MgEducationSchool Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DisplayName = "Fabrikam Arts High School"
	Description = "Magnate school for the arts. Los Angeles School District"
}
Update-MgEducationSchool -EducationSchoolId $educationSchoolId -BodyParameter $params
```
This example shows how to use the Update-MgEducationSchool Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
