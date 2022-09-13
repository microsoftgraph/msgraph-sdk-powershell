###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelSharedWithTeam -TeamId $teamId -ChannelId $channelId -SharedWithChannelTeamInfoId $sharedWithChannelTeamInfoId
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelSharedWithTeam -TeamId $teamId -ChannelId $channelId
```
