### Example 1: Using the Get-MgTeamScheduleTimeCard Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleTimeCard -TeamId $teamId -TimeCardId $timeCardId
```
This example shows how to use the Get-MgTeamScheduleTimeCard Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgTeamScheduleTimeCard Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleTimeCard -TeamId $teamId -Top 2 -Filter "state eq 'clockedOut'" 
```
This example shows how to use the Get-MgTeamScheduleTimeCard Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
