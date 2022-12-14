### Example 1: Using the Get-MgBetaTeamScheduleTimeCard Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeamScheduleTimeCard -TeamId $teamId -TimeCardId $timeCardId
```
This example shows how to use the Get-MgBetaTeamScheduleTimeCard Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaTeamScheduleTimeCard Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeamScheduleTimeCard -TeamId $teamId -Top 2 -Filter "state eq 'clockedOut'" 
```
This example shows how to use the Get-MgBetaTeamScheduleTimeCard Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
