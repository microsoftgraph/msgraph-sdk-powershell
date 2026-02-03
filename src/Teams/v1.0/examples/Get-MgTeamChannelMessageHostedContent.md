### Example 1: List hosted content for a channel message

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamChannelMessageHostedContent -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId

```
This example will list hosted content for a channel message

