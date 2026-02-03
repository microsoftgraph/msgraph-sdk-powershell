### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	"@odata.type" = "#microsoft.graph.plannerRosterMember"
	userId = "String"
}

New-MgBetaPlannerRosterMember -PlannerRosterId $plannerRosterId -BodyParameter $params

```
This example shows how to use the New-MgBetaPlannerRosterMember Cmdlet.

