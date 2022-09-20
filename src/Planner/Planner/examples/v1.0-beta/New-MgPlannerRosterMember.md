### Example 1: Using the New-MgPlannerRosterMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	"@odata.type" = "#microsoft.graph.plannerRosterMember"
	UserId = "String"
}
New-MgPlannerRosterMember -PlannerRosterId $plannerRosterId -BodyParameter $params
```
This example shows how to use the New-MgPlannerRosterMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
