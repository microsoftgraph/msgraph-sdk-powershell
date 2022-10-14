### Example 1: Using the Get-MgUserTaskListTaskDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Get-MgUserTaskListTaskDelta -UserId $userId -BaseTaskListId $baseTaskListId
```
This example shows how to use the Get-MgUserTaskListTaskDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
