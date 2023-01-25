### Example 1: Using the Start-MgBetaTeamScheduleTimeCardBreak Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	AtAprovedLocation = $true
	Notes = @{
		ContentType = "text"
		Content = "start break smaple notes"
	}
}
Start-MgBetaTeamScheduleTimeCardBreak -TeamId $teamId -TimeCardId $timeCardId -BodyParameter $params
```
This example shows how to use the Start-MgBetaTeamScheduleTimeCardBreak Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
