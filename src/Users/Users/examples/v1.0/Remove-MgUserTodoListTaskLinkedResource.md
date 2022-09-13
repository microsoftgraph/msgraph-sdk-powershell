###Example 1
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Remove-MgUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -LinkedResourceId $linkedResourceId
```
