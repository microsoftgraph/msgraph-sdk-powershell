### Example 1: Using the Get-MgUserTodoListTaskLinkedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -LinkedResourceId $linkedResourceId
```
This example shows how to use the Get-MgUserTodoListTaskLinkedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserTodoListTaskLinkedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId
```
This example shows how to use the Get-MgUserTodoListTaskLinkedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
