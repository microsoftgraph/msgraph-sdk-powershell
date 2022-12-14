### Example 1: Using the Update-MgBetaPlannerTaskBucketTaskBoardFormat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	OrderHint = "A6673H Ejkl!"
}
Update-MgBetaPlannerTaskBucketTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPlannerTaskBucketTaskBoardFormat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
