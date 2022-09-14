### Example 1: Using the Update-MgEducationMeRubric Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DisplayName = "Example Credit Rubric after display name patch"
}
Update-MgEducationMeRubric -EducationRubricId $educationRubricId -BodyParameter $params
```
This example shows how to use the Update-MgEducationMeRubric Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
