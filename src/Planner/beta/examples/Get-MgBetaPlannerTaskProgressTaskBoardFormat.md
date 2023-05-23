### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Planner

$params = @{
	orderHint = "A6673H Ejkl!"
}

Update-MgBetaPlannerTaskProgressTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params-If-Match W/"JzEtVGFzayAgQEBAQEBAQEBAQEBAQEBAWCc="
```
This example shows how to use the Get-MgBetaBetaPlannerTaskProgressTaskBoardFormat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

