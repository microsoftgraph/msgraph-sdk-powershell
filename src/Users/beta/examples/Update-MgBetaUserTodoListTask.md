### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Users

$params = @{
	dueDateTime = @{
		dateTime = "2020-07-25T16:00:00"
		timeZone = "Eastern Standard Time"
	}
}

# A UPN can also be used as -UserId.
Update-MgBetaUserTodoListTask -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaUserTodoListTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

