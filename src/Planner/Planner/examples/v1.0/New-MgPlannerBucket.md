###Example 1
```
Import-Module Microsoft.Graph.Planner
$params = @{
	Name = "Advertising"
	PlanId = "xqQg5FS2LkCp935s-FIFm2QAFkHM"
	OrderHint = " !"
}
New-MgPlannerBucket -BodyParameter $params
```
