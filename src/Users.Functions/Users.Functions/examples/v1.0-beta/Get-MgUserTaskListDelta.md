### Example 1: Using the Get-MgUserTaskListDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Get-MgUserTaskListDelta -UserId $userId
```
This example shows how to use the Get-MgUserTaskListDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
