### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.BusinessScenario

$params = @{
	"@odata.type" = "#microsoft.graph.businessScenario"
	displayName = "Contoso Order Tracking"
	uniqueName = "com.contoso.apps.ordertracking"
}

New-MgBetaSolutionBusinessScenario -BodyParameter $params

```
This example shows how to use the New-MgBetaSolutionBusinessScenario Cmdlet.

