### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	displayName = "Fabrikam Arts High School"
	description = "Magnate school for the arts. Los Angeles School District"
}

Update-MgEducationSchool -EducationSchoolId $educationSchoolId -BodyParameter $params
```
This example shows how to use the Get-MgEducationSchool Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

