### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	userId = "c5d0c76b-80c4-481c-be50-923cd8d680a1"
	sharedTimeOff = @{
		timeOffReasonId = "TOR_891045ca-b5d2-406b-aa06-a3c8921245d7"
		startDateTime = [System.DateTime]::Parse("2019-03-11T07:00:00Z")
		endDateTime = [System.DateTime]::Parse("2019-03-12T07:00:00Z")
		theme = "white"
	}
	draftTimeOff = @{
		timeOffReasonId = "TOR_891045ca-b5d2-406b-aa06-a3c8921245d7"
		startDateTime = [System.DateTime]::Parse("2019-03-11T07:00:00Z")
		endDateTime = [System.DateTime]::Parse("2019-03-12T07:00:00Z")
		theme = "pink"
	}
}

New-MgBetaTeamScheduleTimeOff -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamScheduleTimeOff Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

