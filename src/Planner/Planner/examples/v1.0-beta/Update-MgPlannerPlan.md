### Example 1: Using the Update-MgBetaPlannerPlan Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	Title = "title-value"
}
Update-MgBetaPlannerPlan -PlannerPlanId $plannerPlanId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPlannerPlan Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
