###Example 1
```
Import-Module Microsoft.Graph.Planner
$params = @{
	Title = "title-value"
}
Update-MgPlannerPlan -PlannerPlanId $plannerPlanId -BodyParameter $params
```
