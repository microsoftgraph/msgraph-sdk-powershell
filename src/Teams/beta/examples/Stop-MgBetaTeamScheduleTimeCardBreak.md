### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	atAprovedLocation = $true
	notes = @{
		contentType = "text"
		content = "end break smaple notes"
	}
}

Stop-MgBetaTeamScheduleTimeCardBreak -TeamId $teamId -TimeCardId $timeCardId -BodyParameter $params

```
This example shows how to use the Stop-MgBetaTeamScheduleTimeCardBreak Cmdlet.

