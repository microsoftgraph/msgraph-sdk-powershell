### Example 1: Using the Get-MgUserTodoList Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoList -UserId $userId
```
This example shows how to use the Get-MgUserTodoList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserTodoList Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoList -UserId $userId -TodoTaskListId $todoTaskListId
```
This example shows how to use the Get-MgUserTodoList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
