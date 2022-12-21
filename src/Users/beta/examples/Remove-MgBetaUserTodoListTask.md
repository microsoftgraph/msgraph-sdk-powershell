### Example 1: Using the Remove-MgBetaUserTodoListTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Remove-MgBetaUserTodoListTask -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId
```
This example shows how to use the Remove-MgBetaUserTodoListTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
