### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatMessage -ChatId $chatId -Top 2 
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatMessage -ChatId $chatId -ChatMessageId $chatMessageId
```
