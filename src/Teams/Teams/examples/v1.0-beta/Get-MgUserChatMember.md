### Example 1: Using the Get-MgBetaUserChatMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
# A UPN can also be used as -UserId.
Get-MgBetaUserChatMember -UserId $userId -ChatId $chatId
```
This example shows how to use the Get-MgBetaUserChatMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
