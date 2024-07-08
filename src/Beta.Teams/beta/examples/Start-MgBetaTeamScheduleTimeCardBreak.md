### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	atAprovedLocation = $true
	notes = @{
		contentType = "text"
		content = "start break smaple notes"
	}
}

Start-MgBetaTeamScheduleTimeCardBreak -TeamId $teamId -TimeCardId $timeCardId -BodyParameter $params

```
This example shows how to use the Start-MgBetaTeamScheduleTimeCardBreak Cmdlet.

