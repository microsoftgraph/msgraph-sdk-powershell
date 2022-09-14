### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	NotifyTeam = $true
	StartDateTime = [System.DateTime]::Parse("2018-10-08T00:00:00.000Z")
	EndDateTime = [System.DateTime]::Parse("2018-10-15T00:00:00.000Z")
}
Invoke-MgShareTeamSchedule -TeamId $teamId -BodyParameter $params
```
