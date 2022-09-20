### Example 1: Using the New-MgPlannerTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Planner
$params = @{
	PlanId = "xqQg5FS2LkCp935s-FIFm2QAFkHM"
	BucketId = "hsOf2dhOJkqyYYZEtdzDe2QAIUCR"
	Title = "Update client list"
	Assignments = @{
		"Fbab97d0-4932-4511-b675-204639209557" = @{
			"@odata.type" = "#microsoft.graph.plannerAssignment"
			OrderHint = " !"
		}
	}
}
New-MgPlannerTask -BodyParameter $params
```
This example shows how to use the New-MgPlannerTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
