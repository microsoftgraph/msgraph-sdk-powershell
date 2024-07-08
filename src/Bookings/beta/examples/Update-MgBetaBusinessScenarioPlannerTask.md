### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	"@odata.type" = "#microsoft.graph.businessScenarioTask"
	title = "Customer order #12010"
	percentComplete = 20
	priority = 1
	businessScenarioProperties = @{
		externalObjectVersion = "000003"
	}
}

Update-MgBetaBusinessScenarioPlannerTask -BusinessScenarioId $businessScenarioId -BusinessScenarioTaskId $businessScenarioTaskId -BodyParameter $params

```
This example shows how to use the Update-MgBetaBusinessScenarioPlannerTask Cmdlet.

