### Example 1: List all the pinned messages in a chat

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgChatPinnedMessage -ChatId $chatId

```
This example will list all the pinned messages in a chat

### Example 2: List all the pinned messages in a chat along with the associated chat message

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgChatPinnedMessage -ChatId $chatId -ExpandProperty "message" 

```
This example will list all the pinned messages in a chat along with the associated chat message

