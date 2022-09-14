### Example 1: Using the Remove-MgTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Remove-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -ConversationMemberId $conversationMemberId
```
This example shows how to use the Remove-MgTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
