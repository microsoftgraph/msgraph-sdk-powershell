### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	container = @{
		containerId = "groupId"
		type = "group"
	}
}

Move-MgBetaPlannerPlanToContainer -PlannerPlanId $plannerPlanId -BodyParameter $params

```
This example shows how to use the Move-MgBetaPlannerPlanToContainer Cmdlet.

