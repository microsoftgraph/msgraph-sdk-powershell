### Example 1: Using the Update-MgPlannerTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	Assignments = @{
		"Fbab97d0-4932-4511-b675-204639209557" = @{
			"@odata.type" = "#microsoft.graph.plannerAssignment"
			OrderHint = "N9917 U2883!"
		}
	}
	AppliedCategories = @{
		Category3 = $true
		Category4 = $false
	}
}
Update-MgPlannerTask -PlannerTaskId $plannerTaskId -BodyParameter $params
```
This example shows how to use the Update-MgPlannerTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
