### Example 1: Using the New-MgBetaTeamScheduleTimeOffReason Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	DisplayName = "Vacation"
	IconType = "plane"
	IsActive = $true
}
New-MgBetaTeamScheduleTimeOffReason -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamScheduleTimeOffReason Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
