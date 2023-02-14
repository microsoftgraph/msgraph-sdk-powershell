### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamScheduleTimeOff -TeamId $teamId -Filter "sharedTimeOff/startDateTime ge 2019-03-11T00:00:00.000Z and sharedTimeOff/endDateTime le 2019-03-18T00:00:00.000Z and draftTimeOff/startDateTime ge 2019-03-11T00:00:00.000Z and draftTimeOff/endDateTime le 2019-03-18T00:00:00.000Z"
```
This example shows how to use the New-MgGroupTeamScheduleTimeOff Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

