### Example 1: List all the pinned messages in a chat

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatPinnedMessage -ChatId $chatId
```
This example shows how to use the Get-MgBetaUserChatPinnedMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List all the pinned messages in a chat along with the associated chat message

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatPinnedMessage -ChatId $chatId -ExpandProperty "message"
```
This example shows how to use the Get-MgBetaUserChatPinnedMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

