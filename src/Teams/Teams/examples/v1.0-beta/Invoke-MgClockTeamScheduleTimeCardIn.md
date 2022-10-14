### Example 1: Using the Invoke-MgClockTeamScheduleTimeCardIn Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	AtAprovedLocation = $true
	Notes = @{
		ContentType = "text"
		Content = "clock in notes"
	}
}
Invoke-MgClockTeamScheduleTimeCardIn -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Invoke-MgClockTeamScheduleTimeCardIn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
