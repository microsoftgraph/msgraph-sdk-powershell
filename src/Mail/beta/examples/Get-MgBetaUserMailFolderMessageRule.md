### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId -MessageRuleId $messageRuleId
```
This example shows how to use the Get-MgBetaBetaUserMailFolderMessageRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

