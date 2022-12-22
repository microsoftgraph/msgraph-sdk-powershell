### Example 1: Using the Remove-MgBetaUserTodoList Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Remove-MgBetaUserTodoList -UserId $userId -TodoTaskListId $todoTaskListId
```
This example shows how to use the Remove-MgBetaUserTodoList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
