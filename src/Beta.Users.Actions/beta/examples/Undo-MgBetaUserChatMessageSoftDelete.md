### Example 1: Undo soft deletion of a message in a chat

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

Undo-MgBetaUserChatMessageSoftDelete -UserId $userId -ChatId $chatId -ChatMessageId $chatMessageId

```
This example will undo soft deletion of a message in a chat

