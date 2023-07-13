### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

# A UPN can also be used as -UserId.
New-MgBetaUserMessageForward -UserId $userId -MessageId $messageId
```
This example shows how to use the New-MgBetaUserMailFolderMessageForward Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

