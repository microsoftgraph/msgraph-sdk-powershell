### Example 1
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	DisplayName = "buy cake"
}
# A UPN can also be used as -UserId.
Update-MgUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -ChecklistItemId $checklistItemId -BodyParameter $params
```
