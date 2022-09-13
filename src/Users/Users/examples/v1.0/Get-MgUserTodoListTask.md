###Example 1
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoListTask -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId
```
###Example 2
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoListTask -UserId $userId -TodoTaskListId $todoTaskListId
```
