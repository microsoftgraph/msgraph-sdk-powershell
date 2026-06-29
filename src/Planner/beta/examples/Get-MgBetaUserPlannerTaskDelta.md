### Example 1: Get delta on tasks assigned to a user

```powershell

Import-Module Microsoft.Graph.Beta.Planner

# A UPN can also be used as -UserId.
Get-MgBetaUserPlannerTaskDelta -UserId $userId

```
This example will get delta on tasks assigned to a user

