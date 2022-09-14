### Example 1
``` powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	Title = "title-value"
}
Update-MgPlannerPlan -PlannerPlanId $plannerPlanId -BodyParameter $params
```
