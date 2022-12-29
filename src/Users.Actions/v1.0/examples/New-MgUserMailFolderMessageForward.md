### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users.Actions

# A UPN can also be used as -UserId.
New-MgUserMessageForward -UserId $userId -MessageId $messageId
```
This example shows how to use the New-MgUserMailFolderMessageForward Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

