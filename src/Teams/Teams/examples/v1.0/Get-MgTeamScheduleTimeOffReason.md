###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleTimeOffReason -TeamId $teamId
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleTimeOffReason -TeamId $teamId -TimeOffReasonId $timeOffReasonId
```
