### Example 1: Get a message in a channel

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId

```
This example will get a message in a channel

