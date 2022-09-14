### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatMessageHostedContent -ChatId $chatId -ChatMessageId $chatMessageId -ChatMessageHostedContentId $chatMessageHostedContentId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatMessageHostedContent -ChatId $chatId -ChatMessageId $chatMessageId
```
