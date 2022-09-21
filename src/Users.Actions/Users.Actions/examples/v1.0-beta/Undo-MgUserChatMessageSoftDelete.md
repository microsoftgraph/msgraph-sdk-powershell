### Example 1: Using the Undo-MgUserChatMessageSoftDelete Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
Undo-MgUserChatMessageSoftDelete -UserId $userId -ChatId $chatId -ChatMessageId $chatMessageId
```
This example shows how to use the Undo-MgUserChatMessageSoftDelete Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
