### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

$params = @{
	displayName = "Example Credit Rubric after display name patch"
}

Update-MgBetaEducationMeRubric -EducationRubricId $educationRubricId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEducationMeRubric Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

