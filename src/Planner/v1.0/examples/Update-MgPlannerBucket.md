### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Planner

$params = @{
	name = "Development"
}

Update-MgPlannerBucket -PlannerBucketId $plannerBucketId -BodyParameter $params -IfMatch W/'"JzEtVGFzayAgQEBAQEBAQEBAQEBAQEBAWCc="' 


```
This example shows how to use the Update-MgPlannerBucket Cmdlet.

