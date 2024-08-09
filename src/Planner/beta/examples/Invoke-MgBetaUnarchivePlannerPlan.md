### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	justification = "String"
}

Invoke-MgBetaUnarchivePlannerPlan -PlannerPlanId $plannerPlanId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaUnarchivePlannerPlan Cmdlet.

