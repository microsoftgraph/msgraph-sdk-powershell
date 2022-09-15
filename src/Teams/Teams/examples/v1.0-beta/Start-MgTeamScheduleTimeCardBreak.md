### Example 1: Using the Start-MgTeamScheduleTimeCardBreak Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	AtAprovedLocation = $true
	Notes = @{
		ContentType = "text"
		Content = "start break smaple notes"
	}
}
Start-MgTeamScheduleTimeCardBreak -TeamId $teamId -TimeCardId $timeCardId -BodyParameter $params
```
This example shows how to use the Start-MgTeamScheduleTimeCardBreak Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
