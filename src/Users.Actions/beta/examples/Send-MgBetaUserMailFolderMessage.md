### Example 1: Send an existing draft message

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

# A UPN can also be used as -UserId.
Send-MgBetaUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Send-MgBetaUserMailFolderMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

