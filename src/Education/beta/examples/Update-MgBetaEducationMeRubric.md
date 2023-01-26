### Example 1: Using the Update-MgBetaEducationMeRubric Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	DisplayName = "Example Credit Rubric after display name patch"
}
Update-MgBetaEducationMeRubric -EducationRubricId $educationRubricId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEducationMeRubric Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
