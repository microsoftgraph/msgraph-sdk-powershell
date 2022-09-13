###Example 1
```
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "Vacation"
	IconType = "plane"
	IsActive = $true
}
New-MgTeamScheduleTimeOffReason -TeamId $teamId -BodyParameter $params
```
