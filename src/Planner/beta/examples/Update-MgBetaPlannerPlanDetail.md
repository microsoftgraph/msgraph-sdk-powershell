### Example 1: Using the Update-MgBetaPlannerPlanDetail Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
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
Update-MgBetaPlannerPlanDetail -PlannerPlanId $plannerPlanId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPlannerPlanDetail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
