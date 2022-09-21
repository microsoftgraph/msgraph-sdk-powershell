### Example 1: Using the New-MgPlannerBucket Cmdlet
```powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	Name = "Advertising"
	PlanId = "xqQg5FS2LkCp935s-FIFm2QAFkHM"
	OrderHint = " !"
}
New-MgPlannerBucket -BodyParameter $params
```
This example shows how to use the New-MgPlannerBucket Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
