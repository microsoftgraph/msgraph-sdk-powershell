### Example 1: Send an existing draft message

```powershellImport-Module Microsoft.Graph.Users.Actions

# A UPN can also be used as -UserId.
Send-MgUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Send-MgUserMailFolderMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

