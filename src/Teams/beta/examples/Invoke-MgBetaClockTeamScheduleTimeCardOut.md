### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	isAtApprovedLocation = $true
	notes = @{
		contentType = "text"
		content = "clocking out"
	}
}

Invoke-MgBetaClockTeamScheduleTimeCardOut -TeamId $teamId -TimeCardId $timeCardId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaClockTeamScheduleTimeCardOut Cmdlet.

