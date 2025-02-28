### Example 1: Soft-delete message in a chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Invoke-MgBetaSoftUserChatMessageDelete -UserId $userId -ChatId $chatId -ChatMessageId $chatMessageId

```
This example will soft-delete message in a chat

