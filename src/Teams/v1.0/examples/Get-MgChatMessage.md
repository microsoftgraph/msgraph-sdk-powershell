### Example 1: Get a message in a chat

```powershell
Import-Module Microsoft.Graph.Teams

Get-MgChatMessage -ChatId $chatId -ChatMessageId $chatMessageId
```
This example shows how to use the Get-MgChatMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

