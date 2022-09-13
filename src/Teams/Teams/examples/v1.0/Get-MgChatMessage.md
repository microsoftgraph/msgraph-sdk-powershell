###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgChatMessage -ChatId $chatId -Top 2 
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgChatMessage -ChatId $chatId -ChatMessageId $chatMessageId
```
