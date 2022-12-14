### Example 1: Using the Get-MgBetaUserTaskListDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Functions
# A UPN can also be used as -UserId.
Get-MgBetaUserTaskListDelta -UserId $userId
```
This example shows how to use the Get-MgBetaUserTaskListDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
