### Example 1: Using the New-MgUserTodoListTaskChecklistItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	DisplayName = "Final sign-off from the team"
}
# A UPN can also be used as -UserId.
New-MgUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the New-MgUserTodoListTaskChecklistItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
