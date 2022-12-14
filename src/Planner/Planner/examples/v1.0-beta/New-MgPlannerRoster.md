### Example 1: Using the New-MgBetaPlannerRoster Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	"@odata.type" = "#microsoft.graph.plannerRoster"
}
New-MgBetaPlannerRoster -BodyParameter $params
```
This example shows how to use the New-MgBetaPlannerRoster Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
