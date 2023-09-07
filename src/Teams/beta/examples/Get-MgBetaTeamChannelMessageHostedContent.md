### Example 1: List hosted content for a channel message

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamChannelMessageHostedContent -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId

```
This example will list hosted content for a channel message

