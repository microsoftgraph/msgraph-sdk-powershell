### Example 1: Using the Remove-MgUserTodoList Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Remove-MgUserTodoList -UserId $userId -TodoTaskListId $todoTaskListId
```
This example shows how to use the Remove-MgUserTodoList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
