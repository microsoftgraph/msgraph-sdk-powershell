###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleTimeOff -TeamId $teamId -Filter "sharedTimeOff/startDateTime ge 2019-03-11T00:00:00.000Z and sharedTimeOff/endDateTime le 2019-03-18T00:00:00.000Z and draftTimeOff/startDateTime ge 2019-03-11T00:00:00.000Z and draftTimeOff/endDateTime le 2019-03-18T00:00:00.000Z" 
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamScheduleTimeOff -TeamId $teamId -TimeOffId $timeOffId
```
