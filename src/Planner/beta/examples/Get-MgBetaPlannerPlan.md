### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Planner

$params = @{
	title = "title-value"
}

Update-MgBetaPlannerPlan -PlannerPlanId $plannerPlanId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaPlannerPlan Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

