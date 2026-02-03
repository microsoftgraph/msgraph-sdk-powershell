### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users

# A UPN can also be used as -UserId.
Remove-MgBetaUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -ChecklistItemId $checklistItemId
```
This example shows how to use the Remove-MgBetaUserTodoListTaskChecklistItem Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

