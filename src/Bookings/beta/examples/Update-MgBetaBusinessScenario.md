### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	ownerAppIds = @(
	"44109254-4b2b-7a33-76ee-c890a167b295"
"13eb9d8b-1d63-4153-9417-3a69ab200a78"
)
}

Update-MgBetaBusinessScenario -BusinessScenarioId $businessScenarioId -BodyParameter $params

```
This example shows how to use the Update-MgBetaBusinessScenario Cmdlet.

