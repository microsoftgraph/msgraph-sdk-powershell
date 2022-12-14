### Example 1: Using the Update-MgBetaPlannerTaskProgressTaskBoardFormat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	OrderHint = "A6673H Ejkl!"
}
Update-MgBetaPlannerTaskProgressTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPlannerTaskProgressTaskBoardFormat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
