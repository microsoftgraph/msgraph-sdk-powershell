### Example 1: Using the Update-MgUserTodoListTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	DueDateTime = @{
		DateTime = "2020-07-25T16:00:00"
		TimeZone = "Eastern Standard Time"
	}
}
# A UPN can also be used as -UserId.
Update-MgUserTodoListTask -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the Update-MgUserTodoListTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
