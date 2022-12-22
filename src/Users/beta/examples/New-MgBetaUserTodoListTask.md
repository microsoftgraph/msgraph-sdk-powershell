### Example 1: Using the New-MgBetaUserTodoListTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
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
New-MgBetaUserTodoListTask -UserId $userId -TodoTaskListId $todoTaskListId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserTodoListTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
