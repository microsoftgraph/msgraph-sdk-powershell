### Example 1: Undo soft deletion of a message in a channel

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Undo-MgBetaTeamChannelMessageSoftDelete -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId

```
This example will undo soft deletion of a message in a channel

### Example 2: Undo soft deletion of a message of a reply in a channel

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Undo-MgBetaTeamChannelMessageSoftDelete -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId

```
This example will undo soft deletion of a message of a reply in a channel

