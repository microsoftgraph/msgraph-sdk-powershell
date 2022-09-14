### Example 1
``` powershell
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
