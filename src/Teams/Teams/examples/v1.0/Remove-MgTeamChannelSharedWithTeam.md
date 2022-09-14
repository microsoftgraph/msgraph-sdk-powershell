### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Remove-MgTeamChannelSharedWithTeam -TeamId $teamId -ChannelId $channelId -SharedWithChannelTeamInfoId $sharedWithChannelTeamInfoId
```
