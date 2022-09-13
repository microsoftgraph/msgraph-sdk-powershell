###Example 1
```
Import-Module Microsoft.Graph.Teams
# A UPN can also be used as -UserId.
Get-MgUserChatMember -UserId $userId -ChatId $chatId
```
