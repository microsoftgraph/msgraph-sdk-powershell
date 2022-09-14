### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMessage -TeamId $teamId -Filter "lastModifiedDateTime gt 2019-11-01T00:00:00Z and lastModifiedDateTime lt 2021-11-01T00:00:00Z" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -Top 3 
```
