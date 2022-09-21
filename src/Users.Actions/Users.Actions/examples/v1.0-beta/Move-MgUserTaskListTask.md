### Example 1: Using the Move-MgUserTaskListTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	DestinationTaskListId = "AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAuAAAAAAAboFsPFj7gQqFxG"
}
# A UPN can also be used as -UserId.
Move-MgUserTaskListTask -UserId $userId -BaseTaskListId $baseTaskListId -BaseTaskId $baseTaskId -BodyParameter $params
```
This example shows how to use the Move-MgUserTaskListTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
