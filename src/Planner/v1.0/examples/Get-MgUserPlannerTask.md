### Example 1: Using the Get-MgUserPlannerTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Planner
# A UPN can also be used as -UserId.
Get-MgUserPlannerTask -UserId $userId
```
This example shows how to use the Get-MgUserPlannerTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
