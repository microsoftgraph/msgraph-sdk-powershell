### Example 1
```powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	SharedWith = @{
		"6463a5ce-2119-4198-9f2a-628761df4a62" = $true
		"D95e6152-f683-4d78-9ff5-67ad180fea4a" = $false
	}
	CategoryDescriptions = @{
		Category1 = "Indoors"
		Category3 = $null
	}
}
Update-MgPlannerPlanDetail -PlannerPlanId $plannerPlanId -BodyParameter $params
```
