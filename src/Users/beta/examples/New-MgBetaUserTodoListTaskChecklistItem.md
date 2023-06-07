### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Users

$params = @{
	displayName = "Final sign-off from the team"
}

# A UPN can also be used as -UserId.
New-MgBetaUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserTodoListTaskChecklistItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

