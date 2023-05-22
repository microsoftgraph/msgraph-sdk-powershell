### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "Vacation"
	iconType = "plane"
	isActive = $true
}

New-MgBetaTeamScheduleTimeOffReason -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaTeamScheduleTimeOffReason Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

