### Example 1: Using the Get-MgTeamScheduleShift Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleShift -TeamId $teamId -Filter "sharedShift/startDateTime ge 2019-03-11T00:00:00.000Z and sharedShift/endDateTime le 2019-03-18T00:00:00.000Z and draftShift/startDateTime ge 2019-03-11T00:00:00.000Z and draftShift/endDateTime le 2019-03-18T00:00:00.000Z" 
```
This example shows how to use the Get-MgTeamScheduleShift Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgTeamScheduleShift Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleShift -TeamId $teamId -ShiftId $shiftId
```
This example shows how to use the Get-MgTeamScheduleShift Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
