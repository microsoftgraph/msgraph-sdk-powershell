### Example 1: Using the Remove-MgUserTodoListTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Remove-MgUserTodoListTask -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId
```
This example shows how to use the Remove-MgUserTodoListTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
