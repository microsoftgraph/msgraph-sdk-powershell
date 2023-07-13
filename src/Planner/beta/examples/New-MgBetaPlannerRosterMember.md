### Example 1: Using the New-MgBetaPlannerRosterMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	"@odata.type" = "#microsoft.graph.plannerRosterMember"
	UserId = "String"
}
New-MgBetaPlannerRosterMember -PlannerRosterId $plannerRosterId -BodyParameter $params
```
This example shows how to use the New-MgBetaPlannerRosterMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
