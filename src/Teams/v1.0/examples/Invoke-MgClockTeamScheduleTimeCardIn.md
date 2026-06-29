### Example 1: Clock in as yourself

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	isAtApprovedLocation = $true
	notes = @{
		content = "Started late due to traffic"
		contentType = "text"
	}
}

Invoke-MgClockTeamScheduleTimeCardIn -TeamId $teamId -BodyParameter $params

```
This example will clock in as yourself

### Example 2: Clock in on behalf of another user

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	isAtApprovedLocation = $true
	onBehalfOfUserId = "3f29c8e7-7a41-4d8e-99d6-2b1f76c9421e"
}

Invoke-MgClockTeamScheduleTimeCardIn -TeamId $teamId -BodyParameter $params

```
This example will clock in on behalf of another user

