### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

# A UPN can also be used as -UserId.
Get-MgBetaUserChatMember -UserId $userId -ChatId $chatId
```
This example shows how to use the New-MgBetaUserChatMember Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

