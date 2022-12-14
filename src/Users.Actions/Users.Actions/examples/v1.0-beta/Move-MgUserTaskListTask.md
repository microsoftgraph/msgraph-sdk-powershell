### Example 1: Using the Move-MgBetaUserTaskListTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	DestinationTaskListId = "AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAuAAAAAAAboFsPFj7gQqFxG"
}
# A UPN can also be used as -UserId.
Move-MgBetaUserTaskListTask -UserId $userId -BaseTaskListId $baseTaskListId -BaseTaskId $baseTaskId -BodyParameter $params
```
This example shows how to use the Move-MgBetaUserTaskListTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
