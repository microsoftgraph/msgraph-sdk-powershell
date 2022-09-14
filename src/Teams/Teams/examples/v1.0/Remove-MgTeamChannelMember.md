### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
Remove-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -ConversationMemberId $conversationMemberId
```
