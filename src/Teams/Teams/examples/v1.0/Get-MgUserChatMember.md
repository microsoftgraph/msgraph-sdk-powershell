### Example 1: Using the Get-MgUserChatMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
# A UPN can also be used as -UserId.
Get-MgUserChatMember -UserId $userId -ChatId $chatId
```
This example shows how to use the Get-MgUserChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
