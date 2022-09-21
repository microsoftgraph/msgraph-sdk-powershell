### Example 1: Using the Get-MgUserPlannerAllDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Get-MgUserPlannerAllDelta -UserId $userId
```
This example shows how to use the Get-MgUserPlannerAllDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
