### Example 1
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
