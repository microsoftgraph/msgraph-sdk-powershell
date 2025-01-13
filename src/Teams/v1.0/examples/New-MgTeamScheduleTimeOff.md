### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	userId = "aa162a04-bec6-4b81-ba99-96caa7b2b24d"
	sharedTimeOff = @{
		timeOffReasonId = "TOR_29a5ba96-c7ef-4e76-bec6-055323746314"
		startDateTime = [System.DateTime]::Parse("2024-10-10T19:00:00Z")
		endDateTime = [System.DateTime]::Parse("2024-10-10T20:00:00Z")
		theme = "blue"
	}
	draftTimeOff = $null
	isStagedForDeletion = $false
}

New-MgTeamScheduleTimeOff -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgTeamScheduleTimeOff Cmdlet.

