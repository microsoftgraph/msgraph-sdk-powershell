### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Planner

$params = @{
	title = "title-value"
}

Update-MgPlannerPlan -PlannerPlanId $plannerPlanId -BodyParameter $params
```
This example shows how to use the Update-MgPlannerPlan Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

