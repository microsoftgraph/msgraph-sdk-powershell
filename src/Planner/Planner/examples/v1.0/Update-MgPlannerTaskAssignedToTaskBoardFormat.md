### Example 1: Using the Update-MgPlannerTaskAssignedToTaskBoardFormat Cmdlet
```powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	OrderHintsByAssignee = @{
		"Aaa27244-1db4-476a-a5cb-004607466324" = "8566473P 957764Jk!"
	}
}
Update-MgPlannerTaskAssignedToTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params
```
This example shows how to use the Update-MgPlannerTaskAssignedToTaskBoardFormat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
