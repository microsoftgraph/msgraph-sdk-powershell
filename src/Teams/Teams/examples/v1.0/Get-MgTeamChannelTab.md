###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -ExpandProperty "teamsApp" 
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -ExpandProperty "teamsApp" -Filter "teamsApp/id eq 'com.microsoft.teamspace.tab.planner'" 
```
