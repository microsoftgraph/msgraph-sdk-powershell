### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users

$params = @{
	displayName = "buy cake"
}

# A UPN can also be used as -UserId.
Update-MgUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -ChecklistItemId $checklistItemId -BodyParameter $params
```
This example shows how to use the Get-MgUserTodoListTaskChecklistItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

