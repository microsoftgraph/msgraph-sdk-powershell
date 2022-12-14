### Example 1: Using the Update-MgBetaUserPlanner Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	FavoritePlanReferences = @{
		Jd8S5gOaFk2S8aWCIAJz42QAAxtD = @{
			"@odata.type" = "#microsoft.graph.plannerFavoritePlanReference"
			OrderHint = " !"
			PlanTitle = "Next Release Discussion"
		}
		"7oTB5aMIAE2rVo-1N-L7RmQAGX2q" = $null
	}
	RecentPlanReferences = @{
		Jd8S5gOaFk2S8aWCIAJz42QAAxtD = @{
			"@odata.type" = "#microsoft.graph.plannerRecentPlanReference"
			LastAccessedDateTime = "2018-01-02T22:49:46.155Z"
			PlanTitle = "Next Release Discussion"
		}
	}
}
# A UPN can also be used as -UserId.
Update-MgBetaUserPlanner -UserId $userId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserPlanner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
