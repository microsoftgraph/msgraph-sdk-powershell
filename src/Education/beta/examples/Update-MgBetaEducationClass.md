### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

$params = @{
	description = "History - World History 1"
	displayName = "World History Level 1"
}

Update-MgBetaEducationClass -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaEducationClass Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

