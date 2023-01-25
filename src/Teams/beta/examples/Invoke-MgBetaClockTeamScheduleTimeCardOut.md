### Example 1: Using the Invoke-MgBetaClockTeamScheduleTimeCardOut Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	AtAprovedLocation = $true
	Notes = @{
		ContentType = "text"
		Content = "clock out smaple notes"
	}
}
Invoke-MgBetaClockTeamScheduleTimeCardOut -TeamId $teamId -TimeCardId $timeCardId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaClockTeamScheduleTimeCardOut Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
