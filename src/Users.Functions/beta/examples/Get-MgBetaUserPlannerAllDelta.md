### Example 1: Using the Get-MgBetaUserPlannerAllDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Functions
# A UPN can also be used as -UserId.
Get-MgBetaUserPlannerAllDelta -UserId $userId
```
This example shows how to use the Get-MgBetaUserPlannerAllDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
