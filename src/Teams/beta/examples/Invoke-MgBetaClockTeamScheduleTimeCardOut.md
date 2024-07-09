### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	atAprovedLocation = $true
	notes = @{
		contentType = "text"
		content = "clock out smaple notes"
	}
}

Invoke-MgBetaClockTeamScheduleTimeCardOut -TeamId $teamId -TimeCardId $timeCardId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaClockTeamScheduleTimeCardOut Cmdlet.

