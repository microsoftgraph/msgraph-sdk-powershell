### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -ConversationMemberId $conversationMemberId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId
```
