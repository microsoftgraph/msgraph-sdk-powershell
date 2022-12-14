### Example 1: Using the Update-MgBetaEducationClass Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	Description = "History - World History 1"
	DisplayName = "World History Level 1"
}
Update-MgBetaEducationClass -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEducationClass Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
