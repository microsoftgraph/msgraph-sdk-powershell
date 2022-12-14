### Example 1: Using the New-MgBetaTeamScheduleOpenShiftChangeRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	SenderMessage = "Can I take this shift?"
	OpenShiftId = "577b75d2-a927-48c0-a5d1-dc984894e7b8"
}
New-MgBetaTeamScheduleOpenShiftChangeRequest -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamScheduleOpenShiftChangeRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
