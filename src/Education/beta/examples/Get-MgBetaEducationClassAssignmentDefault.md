### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

$params = @{
	addedStudentAction = "assignIfOpen"
	notificationChannelUrl = "https://graph.microsoft.com/beta/teams('acdefc6b-2dc6-4e71-b1e9-6d9810ab1793')/channels('3da03fc4-8eac-4459-84fb-1422dc01f65e')"
}

Update-MgBetaEducationClassAssignmentDefault -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaEducationClassAssignmentDefault Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

