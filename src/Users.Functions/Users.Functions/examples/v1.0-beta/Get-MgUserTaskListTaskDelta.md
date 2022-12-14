### Example 1: Using the Get-MgBetaUserTaskListTaskDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Functions
# A UPN can also be used as -UserId.
Get-MgBetaUserTaskListTaskDelta -UserId $userId -BaseTaskListId $baseTaskListId
```
This example shows how to use the Get-MgBetaUserTaskListTaskDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
