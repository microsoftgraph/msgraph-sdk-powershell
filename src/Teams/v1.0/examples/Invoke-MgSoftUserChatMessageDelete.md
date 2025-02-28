### Example 1: Soft-delete message in a chat

```powershell

Import-Module Microsoft.Graph.Teams

Invoke-MgSoftUserChatMessageDelete -UserId $userId -ChatId $chatId -ChatMessageId $chatMessageId

```
This example will soft-delete message in a chat

