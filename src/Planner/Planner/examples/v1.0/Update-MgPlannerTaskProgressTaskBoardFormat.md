###Example 1
```
Import-Module Microsoft.Graph.Planner
$params = @{
	OrderHint = "A6673H Ejkl!"
}
Update-MgPlannerTaskProgressTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params
```
