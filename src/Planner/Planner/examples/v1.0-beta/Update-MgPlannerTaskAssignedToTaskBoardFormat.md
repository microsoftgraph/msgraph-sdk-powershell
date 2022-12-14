### Example 1: Using the Update-MgBetaPlannerTaskAssignedToTaskBoardFormat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	OrderHintsByAssignee = @{
		"Aaa27244-1db4-476a-a5cb-004607466324" = "8566473P 957764Jk!"
	}
}
Update-MgBetaPlannerTaskAssignedToTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPlannerTaskAssignedToTaskBoardFormat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
