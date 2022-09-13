###Example 1
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoList -UserId $userId
```
###Example 2
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoList -UserId $userId -TodoTaskListId $todoTaskListId
```
