### Example 1: Using the New-MgPlannerRoster Cmdlet
```powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	"@odata.type" = "#microsoft.graph.plannerRoster"
}
New-MgPlannerRoster -BodyParameter $params
```
This example shows how to use the New-MgPlannerRoster Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
