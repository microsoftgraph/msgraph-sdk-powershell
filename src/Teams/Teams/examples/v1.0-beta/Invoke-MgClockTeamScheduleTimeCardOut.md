### Example 1: Using the Invoke-MgClockTeamScheduleTimeCardOut Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	AtAprovedLocation = $true
	Notes = @{
		ContentType = "text"
		Content = "clock out smaple notes"
	}
}
Invoke-MgClockTeamScheduleTimeCardOut -TeamId $teamId -TimeCardId $timeCardId -BodyParameter $params
```
This example shows how to use the Invoke-MgClockTeamScheduleTimeCardOut Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
