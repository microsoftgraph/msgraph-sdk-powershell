### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.BusinessScenario

$params = @{
	target = @{
		"@odata.type" = "microsoft.graph.businessScenarioGroupTarget"
		taskTargetKind = "group"
		groupId = "7a339254-4b2b-4410-b295-c890a16776ee"
	}
}

Get-MgBetaSolutionBusinessScenarioPlannerPlan -BusinessScenarioId $businessScenarioId -BodyParameter $params

```
This example shows how to use the Get-MgBetaSolutionBusinessScenarioPlannerPlan Cmdlet.

