### Example 1: Using the New-MgBetaPlannerBucket Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	Name = "Advertising"
	PlanId = "xqQg5FS2LkCp935s-FIFm2QAFkHM"
	OrderHint = " !"
}
New-MgBetaPlannerBucket -BodyParameter $params
```
This example shows how to use the New-MgBetaPlannerBucket Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
