### Example 1: Using the Invoke-MgBetaShareTeamSchedule Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	NotifyTeam = $true
	StartDateTime = [System.DateTime]::Parse("2018-10-08T00:00:00.000Z")
	EndDateTime = [System.DateTime]::Parse("2018-10-15T00:00:00.000Z")
}
Invoke-MgBetaShareTeamSchedule -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaShareTeamSchedule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
