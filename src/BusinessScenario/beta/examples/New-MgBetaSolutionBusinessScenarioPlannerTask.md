### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.BusinessScenario

$params = @{
	title = "Customer order #12010"
	percentComplete = 0
	priority = 5
	target = @{
		"@odata.type" = "microsoft.graph.businessScenarioGroupTarget"
		taskTargetKind = "group"
		groupId = "7a339254-4b2b-4410-b295-c890a16776ee"
	}
	businessScenarioProperties = @{
		externalObjectId = "Order#12010"
		externalContextId = "Warehouse-CA-36"
		externalObjectVersion = "000001"
		webUrl = "https://ordertracking.contoso.com/view?id=12010"
		externalBucketId = "deliveryBucket"
	}
}

New-MgBetaSolutionBusinessScenarioPlannerTask -BusinessScenarioId $businessScenarioId -BodyParameter $params

```
This example shows how to use the New-MgBetaSolutionBusinessScenarioPlannerTask Cmdlet.

