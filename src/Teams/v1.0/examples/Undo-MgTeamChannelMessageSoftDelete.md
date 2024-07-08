### Example 1: Undo soft deletion of a message in a channel

```powershell

Import-Module Microsoft.Graph.Teams

Undo-MgTeamChannelMessageSoftDelete -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId

```
This example will undo soft deletion of a message in a channel

### Example 2: Undo soft deletion of a message of a reply in a channel

```powershell

Import-Module Microsoft.Graph.Teams

Undo-MgTeamChannelMessageSoftDelete -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId

```
This example will undo soft deletion of a message of a reply in a channel

