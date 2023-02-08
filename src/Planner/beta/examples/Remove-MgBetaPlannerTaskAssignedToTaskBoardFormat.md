### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	OrderHintsByAssignee = @{
		"Aaa27244-1db4-476a-a5cb-004607466324" = "8566473P 957764Jk!"
	}
}

Update-MgBetaPlannerTaskAssignedToTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaPlannerTaskAssignedToTaskBoardFormat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

