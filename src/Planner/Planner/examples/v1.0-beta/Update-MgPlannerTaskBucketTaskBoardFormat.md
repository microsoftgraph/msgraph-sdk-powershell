### Example 1: Using the Update-MgPlannerTaskBucketTaskBoardFormat Cmdlet
```powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	OrderHint = "A6673H Ejkl!"
}
Update-MgPlannerTaskBucketTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params
```
This example shows how to use the Update-MgPlannerTaskBucketTaskBoardFormat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
