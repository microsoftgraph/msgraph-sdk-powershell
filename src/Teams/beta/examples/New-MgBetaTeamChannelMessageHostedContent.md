### Example 1: List hosted content for a channel message

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamChannelMessageHostedContent -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId
```
This example shows how to use the New-MgBetaTeamChannelMessageHostedContent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List hosted content for reply to a channel message

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamChannelMessageReplyHostedContent -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -ChatMessageId1 $chatMessageId1
```
This example shows how to use the New-MgBetaTeamChannelMessageHostedContent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: List hosted content for message in a chat

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatMessageHostedContent -ChatId $chatId -ChatMessageId $chatMessageId
```
This example shows how to use the New-MgBetaTeamChannelMessageHostedContent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

