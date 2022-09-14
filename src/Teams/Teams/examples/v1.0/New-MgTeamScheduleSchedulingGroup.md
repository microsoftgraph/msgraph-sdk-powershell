### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "Cashiers"
	IsActive = $true
	UserIds = @(
		"c5d0c76b-80c4-481c-be50-923cd8d680a1"
		"2a4296b3-a28a-44ba-bc66-0274b9b95851"
	)
}
New-MgTeamScheduleSchedulingGroup -TeamId $teamId -BodyParameter $params
```
