### Example 1
```powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	Owner = "ebf3b108-5234-4e22-b93d-656d7dae5874"
	Title = "title-value"
}
New-MgPlannerPlan -BodyParameter $params
```
