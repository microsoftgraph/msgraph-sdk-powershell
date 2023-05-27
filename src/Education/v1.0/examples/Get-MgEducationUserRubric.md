### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	displayName = "Example Credit Rubric after display name patch"
}

Update-MgEducationMeRubric -EducationRubricId $educationRubricId -BodyParameter $params
```
This example shows how to use the Get-MgEducationUserRubric Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

