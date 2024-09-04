### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	enabled = $true
	timeZone = "America/Chicago"
}

Set-MgTeamSchedule -TeamId $teamId -BodyParameter $params

```
This example shows how to use the Set-MgTeamSchedule Cmdlet.

