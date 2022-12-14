### Example 1: Using the Update-MgBetaUserTodoListTaskChecklistItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	DisplayName = "buy cake"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -ChecklistItemId $checklistItemId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserTodoListTaskChecklistItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
