### Example 1: Using the New-MgTeamScheduleTimeOffReason Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "Vacation"
	IconType = "plane"
	IsActive = $true
}
New-MgTeamScheduleTimeOffReason -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgTeamScheduleTimeOffReason Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
