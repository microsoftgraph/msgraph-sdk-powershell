###Example 1
```
Import-Module Microsoft.Graph.Planner
$params = @{
	Name = "Development"
}
Update-MgPlannerBucket -PlannerBucketId $plannerBucketId -BodyParameter $params
```
