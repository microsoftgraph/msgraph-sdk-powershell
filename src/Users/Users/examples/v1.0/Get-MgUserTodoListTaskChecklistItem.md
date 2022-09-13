###Example 1
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -ChecklistItemId $checklistItemId
```
###Example 2
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId
```
