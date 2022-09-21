### Example 1: Using the Get-MgUserPlannerRecentPlan Cmdlet
```powershell
Import-Module Microsoft.Graph.Planner
# A UPN can also be used as -UserId.
Get-MgUserPlannerRecentPlan -UserId $userId
```
This example shows how to use the Get-MgUserPlannerRecentPlan Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
