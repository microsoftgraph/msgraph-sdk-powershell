### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Planner

$params = @{
	title = "title-value"
}

Update-MgPlannerPlan -PlannerPlanId $plannerPlanId -BodyParameter $params

```
This example shows how to use the Update-MgPlannerPlan Cmdlet.

