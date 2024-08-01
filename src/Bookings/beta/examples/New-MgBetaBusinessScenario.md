### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	"@odata.type" = "#microsoft.graph.businessScenario"
	displayName = "Contoso Order Tracking"
	uniqueName = "com.contoso.apps.ordertracking"
}

New-MgBetaBusinessScenario -BodyParameter $params

```
This example shows how to use the New-MgBetaBusinessScenario Cmdlet.

