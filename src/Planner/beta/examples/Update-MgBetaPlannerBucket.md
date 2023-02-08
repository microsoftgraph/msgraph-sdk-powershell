### Example 1: Using the Update-MgBetaPlannerBucket Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	Name = "Development"
}
Update-MgBetaPlannerBucket -PlannerBucketId $plannerBucketId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPlannerBucket Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
