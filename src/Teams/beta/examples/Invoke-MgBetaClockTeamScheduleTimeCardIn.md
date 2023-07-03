### Example 1: Using the Invoke-MgBetaClockTeamScheduleTimeCardIn Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	AtAprovedLocation = $true
	Notes = @{
		ContentType = "text"
		Content = "clock in notes"
	}
}
Invoke-MgBetaClockTeamScheduleTimeCardIn -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaClockTeamScheduleTimeCardIn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
