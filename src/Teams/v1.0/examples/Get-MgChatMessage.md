### Example 1: Get a message in a chat

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChatMessage -ChatId $chatId -ChatMessageId $chatMessageId
```
This example shows how to use the Get-MgChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get a message in a channel

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId
```
This example shows how to use the Get-MgChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Get reply to a message in a channel

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamChannelMessageReply -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -ChatMessageId1 $chatMessageId1
```
This example shows how to use the Get-MgChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

