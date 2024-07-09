### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamScheduleTimeCard -TeamId $teamId -Top 2 -Filter "state eq 'clockedOut'" 

```
This example shows how to use the Get-MgBetaTeamScheduleTimeCard Cmdlet.

