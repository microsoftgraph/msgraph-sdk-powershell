### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Users

# A UPN can also be used as -UserId.
Get-MgBetaUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -ChecklistItemId $checklistItemId
```
This example shows how to use the Get-MgBetaUserTodoListTaskChecklistItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

