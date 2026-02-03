### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Planner

$params = @{
	name = "Development"
}

Update-MgBetaPlannerBucket -PlannerBucketId $plannerBucketId -BodyParameter $params -IfMatch W/'"JzEtVGFzayAgQEBAQEBAQEBAQEBAQEBAWCc="' 


```
This example shows how to use the Update-MgBetaPlannerBucket Cmdlet.

