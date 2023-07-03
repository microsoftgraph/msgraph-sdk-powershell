### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	description = "History - World History 1"
	displayName = "World History Level 1"
}

Update-MgEducationClass -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the Update-MgEducationClass Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

