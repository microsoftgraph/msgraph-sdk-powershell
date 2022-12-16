### Example 1: Using the Remove-MgUserTodoListTaskLinkedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Remove-MgUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -LinkedResourceId $linkedResourceId
```
This example shows how to use the Remove-MgUserTodoListTaskLinkedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
