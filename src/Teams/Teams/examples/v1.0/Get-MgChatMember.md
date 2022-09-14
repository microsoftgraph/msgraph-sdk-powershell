### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatMember -ChatId $chatId -ConversationMemberId $conversationMemberId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatMember -ChatId $chatId
```
