### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -ExpandProperty "teamsApp" 
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -ExpandProperty "teamsApp" -Filter "teamsApp/id eq 'com.microsoft.teamspace.tab.planner'" 
```
