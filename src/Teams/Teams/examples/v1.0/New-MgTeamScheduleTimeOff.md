###Example 1
```
Import-Module Microsoft.Graph.Teams
$params = @{
	UserId = "c5d0c76b-80c4-481c-be50-923cd8d680a1"
	SharedTimeOff = @{
		TimeOffReasonId = "TOR_891045ca-b5d2-406b-aa06-a3c8921245d7"
		StartDateTime = [System.DateTime]::Parse("2019-03-11T07:00:00Z")
		EndDateTime = [System.DateTime]::Parse("2019-03-12T07:00:00Z")
		Theme = "white"
	}
	DraftTimeOff = @{
		TimeOffReasonId = "TOR_891045ca-b5d2-406b-aa06-a3c8921245d7"
		StartDateTime = [System.DateTime]::Parse("2019-03-11T07:00:00Z")
		EndDateTime = [System.DateTime]::Parse("2019-03-12T07:00:00Z")
		Theme = "pink"
	}
}
New-MgTeamScheduleTimeOff -TeamId $teamId -BodyParameter $params
```
