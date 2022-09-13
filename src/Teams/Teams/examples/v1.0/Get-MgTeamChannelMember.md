###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -ConversationMemberId $conversationMemberId
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId
```
