### Example 1: Using the Update-MgBetaUserTodoListTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	DueDateTime = @{
		DateTime = "2020-07-25T16:00:00"
		TimeZone = "Eastern Standard Time"
	}
}
# A UPN can also be used as -UserId.
Update-MgBetaUserTodoListTask -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserTodoListTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
