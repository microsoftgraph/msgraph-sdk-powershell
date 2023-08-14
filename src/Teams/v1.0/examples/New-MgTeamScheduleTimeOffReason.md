### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	displayName = "Vacation"
	iconType = "plane"
	isActive = $true
}

New-MgTeamScheduleTimeOffReason -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgTeamScheduleTimeOffReason Cmdlet.

