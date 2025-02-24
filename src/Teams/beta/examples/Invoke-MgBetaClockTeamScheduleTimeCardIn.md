### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	isAtApprovedLocation = $true
	notes = @{
		contentType = "text"
		content = "clocking in"
	}
}

Invoke-MgBetaClockTeamScheduleTimeCardIn -TeamId $teamId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaClockTeamScheduleTimeCardIn Cmdlet.

