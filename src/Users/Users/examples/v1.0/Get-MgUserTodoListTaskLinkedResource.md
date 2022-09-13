###Example 1
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -LinkedResourceId $linkedResourceId
```
###Example 2
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId
```
