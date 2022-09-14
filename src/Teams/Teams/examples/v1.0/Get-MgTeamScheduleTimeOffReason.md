### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleTimeOffReason -TeamId $teamId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleTimeOffReason -TeamId $teamId -TimeOffReasonId $timeOffReasonId
```
