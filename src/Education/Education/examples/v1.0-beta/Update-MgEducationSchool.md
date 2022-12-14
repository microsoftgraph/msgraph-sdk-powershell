### Example 1: Using the Update-MgBetaEducationSchool Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DisplayName = "Fabrikam Arts High School"
	Description = "Magnate school for the arts. Los Angeles School District"
}
Update-MgBetaEducationSchool -EducationSchoolId $educationSchoolId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEducationSchool Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
