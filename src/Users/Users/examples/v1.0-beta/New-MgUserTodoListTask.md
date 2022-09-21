### Example 1: Using the New-MgUserTodoListTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	Title = "A new task"
	Categories = @(
		"Important"
	)
	LinkedResources = @(
		@{
			WebUrl = "http://microsoft.com"
			ApplicationName = "Microsoft"
			DisplayName = "Microsoft"
		}
	)
}
# A UPN can also be used as -UserId.
New-MgUserTodoListTask -UserId $userId -TodoTaskListId $todoTaskListId -BodyParameter $params
```
This example shows how to use the New-MgUserTodoListTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
