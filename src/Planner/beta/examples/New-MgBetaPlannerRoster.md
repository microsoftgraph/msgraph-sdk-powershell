### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	"@odata.type" = "#microsoft.graph.plannerRoster"
}

New-MgBetaPlannerRoster -BodyParameter $params

```
This example shows how to use the New-MgBetaPlannerRoster Cmdlet.

