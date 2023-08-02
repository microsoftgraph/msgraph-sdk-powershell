### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Planner

$params = @{
	planId = "xqQg5FS2LkCp935s-FIFm2QAFkHM"
	bucketId = "hsOf2dhOJkqyYYZEtdzDe2QAIUCR"
	title = "Update client list"
	assignments = @{
		"fbab97d0-4932-4511-b675-204639209557" = @{
			"@odata.type" = "#microsoft.graph.plannerAssignment"
			orderHint = " !"
		}
	}
}

New-MgPlannerTask -BodyParameter $params

```
This example shows how to use the New-MgPlannerTask Cmdlet.

