### Example 1: List hosted content for message in a chat

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgChatMessageHostedContent -ChatId $chatId -ChatMessageId $chatMessageId

```
This example will list hosted content for message in a chat

