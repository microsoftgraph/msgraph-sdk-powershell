### Example 1: Get a message in a chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatMessage -ChatId $chatId -ChatMessageId $chatMessageId

```
This example will get a message in a chat

