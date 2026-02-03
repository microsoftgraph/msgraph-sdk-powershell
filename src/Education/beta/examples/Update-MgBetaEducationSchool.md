### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	displayName = "Fabrikam Arts High School"
	description = "Magnate school for the arts. Los Angeles School District"
}

Update-MgBetaEducationSchool -EducationSchoolId $educationSchoolId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEducationSchool Cmdlet.

