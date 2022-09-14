### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelSharedWithTeam -TeamId $teamId -ChannelId $channelId -SharedWithChannelTeamInfoId $sharedWithChannelTeamInfoId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelSharedWithTeam -TeamId $teamId -ChannelId $channelId
```
