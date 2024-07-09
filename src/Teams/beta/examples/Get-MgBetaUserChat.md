### Example 1: Get a user's one on one chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserChat -UserId $userId -ChatId $chatId

```
This example will get a user's one on one chat

