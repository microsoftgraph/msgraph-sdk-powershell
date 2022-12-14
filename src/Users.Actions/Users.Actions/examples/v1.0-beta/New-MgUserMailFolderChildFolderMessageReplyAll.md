### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

# A UPN can also be used as -UserId.
New-MgBetaUserMessageReplyAll -UserId $userId -MessageId $messageId
```
This example shows how to use the New-MgBetaUserMailFolderChildFolderMessageReplyAll Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

