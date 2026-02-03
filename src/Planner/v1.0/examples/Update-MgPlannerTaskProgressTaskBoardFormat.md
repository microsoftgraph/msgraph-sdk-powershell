### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Planner

$params = @{
	orderHint = "A6673H Ejkl!"
}

Update-MgPlannerTaskProgressTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params -IfMatch W/'"JzEtVGFzayAgQEBAQEBAQEBAQEBAQEBAWCc="' 


```
This example shows how to use the Update-MgPlannerTaskProgressTaskBoardFormat Cmdlet.

