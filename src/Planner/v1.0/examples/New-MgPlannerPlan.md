### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Planner

$params = @{
	container = @{
		url = "https://graph.microsoft.com/beta/groups/ebf3b108-5234-4e22-b93d-656d7dae5874"
	}
	title = "title-value"
}

New-MgPlannerPlan -BodyParameter $params

```
This example shows how to use the New-MgPlannerPlan Cmdlet.

