### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	atAprovedLocation = $true
	notes = @{
		contentType = "text"
		content = "clock in notes"
	}
}

Invoke-MgBetaClockTeamScheduleTimeCardIn -TeamId $teamId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaClockTeamScheduleTimeCardIn Cmdlet.

