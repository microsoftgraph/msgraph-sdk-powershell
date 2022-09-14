### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleShift -TeamId $teamId -Filter "sharedShift/startDateTime ge 2019-03-11T00:00:00.000Z and sharedShift/endDateTime le 2019-03-18T00:00:00.000Z and draftShift/startDateTime ge 2019-03-11T00:00:00.000Z and draftShift/endDateTime le 2019-03-18T00:00:00.000Z" 
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleShift -TeamId $teamId -ShiftId $shiftId
```
