### Example 1: Soft-delete message in a channel

```powershell

Import-Module Microsoft.Graph.Teams

Invoke-MgSoftTeamChannelMessageDelete -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId

```
This example will soft-delete message in a channel

