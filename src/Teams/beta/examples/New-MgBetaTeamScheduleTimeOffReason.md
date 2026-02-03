### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "Vacation"
	code = "VacationCode"
	iconType = "plane"
	isActive = $true
}

New-MgBetaTeamScheduleTimeOffReason -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgBetaTeamScheduleTimeOffReason Cmdlet.

