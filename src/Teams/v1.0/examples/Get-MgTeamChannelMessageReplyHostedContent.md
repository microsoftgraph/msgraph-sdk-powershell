### Example 1: List hosted content for reply to a channel message

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamChannelMessageReplyHostedContent -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -ChatMessageId1 $chatMessageId1

```
This example will list hosted content for reply to a channel message

