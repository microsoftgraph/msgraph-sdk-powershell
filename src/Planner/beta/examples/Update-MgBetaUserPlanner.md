### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	favoritePlanReferences = @{
		jd8S5gOaFk2S8aWCIAJz42QAAxtD = @{
			"@odata.type" = "#microsoft.graph.plannerFavoritePlanReference"
			orderHint = " !"
			planTitle = "Next Release Discussion"
		}
		"7oTB5aMIAE2rVo-1N-L7RmQAGX2q" = $null
	}
	recentPlanReferences = @{
		jd8S5gOaFk2S8aWCIAJz42QAAxtD = @{
			"@odata.type" = "#microsoft.graph.plannerRecentPlanReference"
			lastAccessedDateTime = "2018-01-02T22:49:46.155Z"
			planTitle = "Next Release Discussion"
		}
	}
}

# A UPN can also be used as -UserId.
Update-MgBetaUserPlanner -UserId $userId -BodyParameter $params -IfMatch W/'"JzEtVXNlckRldGFpbHMgQEBAQEBAQEBAQEBAQEBIWCc="' 


```
This example shows how to use the Update-MgBetaUserPlanner Cmdlet.

