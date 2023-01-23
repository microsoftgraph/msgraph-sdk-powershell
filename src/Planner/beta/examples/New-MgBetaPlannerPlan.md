### Example 1: Using the New-MgBetaPlannerPlan Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	Container = @{
		Url = "https://graph.microsoft.com/beta/groups/ebf3b108-5234-4e22-b93d-656d7dae5874"
	}
	Title = "title-value"
}
New-MgBetaPlannerPlan -BodyParameter $params
```
This example shows how to use the New-MgBetaPlannerPlan Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
