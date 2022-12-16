### Example 1: Using the Update-MgUserTodoListTaskChecklistItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	DisplayName = "buy cake"
}
# A UPN can also be used as -UserId.
Update-MgUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -ChecklistItemId $checklistItemId -BodyParameter $params
```
This example shows how to use the Update-MgUserTodoListTaskChecklistItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
