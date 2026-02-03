### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	notifyTeam = $true
	startDateTime = [System.DateTime]::Parse("2018-10-08T00:00:00.000Z")
	endDateTime = [System.DateTime]::Parse("2018-10-15T00:00:00.000Z")
}

Invoke-MgShareTeamSchedule -TeamId $teamId -BodyParameter $params

```
This example shows how to use the Invoke-MgShareTeamSchedule Cmdlet.

