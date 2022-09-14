### Example 1: Using the Update-MgPlannerBucket Cmdlet
```powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	Name = "Development"
}
Update-MgPlannerBucket -PlannerBucketId $plannerBucketId -BodyParameter $params
```
This example shows how to use the Update-MgPlannerBucket Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
