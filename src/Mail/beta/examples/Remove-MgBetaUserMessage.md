### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Remove-MgBetaUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Remove-MgBetaUserMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

