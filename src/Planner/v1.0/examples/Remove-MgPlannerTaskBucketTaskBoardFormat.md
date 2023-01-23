### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Planner

$params = @{
	OrderHint = "A6673H Ejkl!"
}

Update-MgPlannerTaskBucketTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params
```
This example shows how to use the Remove-MgPlannerTaskBucketTaskBoardFormat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

