### Example 1: Soft-delete message of a reply

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Invoke-MgBetaSoftTeamChannelMessageReplyDelete -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -ChatMessageId1 $chatMessageId1

```
This example will soft-delete message of a reply

