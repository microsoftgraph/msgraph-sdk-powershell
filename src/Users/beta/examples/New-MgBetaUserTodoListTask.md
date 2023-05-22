### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Users

$params = @{
	title = "A new task"
	categories = @(
		"Important"
	)
	linkedResources = @(
		@{
			webUrl = "http://microsoft.com"
			applicationName = "Microsoft"
			displayName = "Microsoft"
		}
	)
}

# A UPN can also be used as -UserId.
New-MgBetaUserTodoListTask -UserId $userId -TodoTaskListId $todoTaskListId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaUserTodoListTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

