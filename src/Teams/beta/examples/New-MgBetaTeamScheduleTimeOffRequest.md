### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	senderMessage = "Need a break"
	timeOffReasonId = "TOR_08c42f26-9b83-492c-bf52-f3609eb083e3"
	senderUserId = "3f2504e0-4f89-11d3-9a0c-0305e82c3301"
	startDateTime = [System.DateTime]::Parse("2025-05-26T07:00:00Z")
	endDateTime = [System.DateTime]::Parse("2025-05-27T07:00:00Z")
}

New-MgBetaTeamScheduleTimeOffRequest -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgBetaTeamScheduleTimeOffRequest Cmdlet.

