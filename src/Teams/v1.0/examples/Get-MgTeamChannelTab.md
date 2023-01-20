### Example 1: Using the Get-MgTeamChannelTab Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -ExpandProperty "teamsApp" 
```
This example shows how to use the Get-MgTeamChannelTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgTeamChannelTab Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -ExpandProperty "teamsApp" -Filter "teamsApp/id eq 'com.microsoft.teamspace.tab.planner'" 
```
This example shows how to use the Get-MgTeamChannelTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
