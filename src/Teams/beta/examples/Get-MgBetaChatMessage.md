### Example 1: Get a message in a chat

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatMessage -ChatId $chatId -ChatMessageId $chatMessageId
```
This example shows how to use the Get-MgBetaChatMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

