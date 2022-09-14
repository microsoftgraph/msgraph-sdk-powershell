### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "Vacation"
	IconType = "plane"
	IsActive = $true
}
New-MgTeamScheduleTimeOffReason -TeamId $teamId -BodyParameter $params
```
