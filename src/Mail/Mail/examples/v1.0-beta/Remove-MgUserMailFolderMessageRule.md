### Example 1: Using the Remove-MgBetaUserMailFolderMessageRule Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
# A UPN can also be used as -UserId.
Remove-MgBetaUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId -MessageRuleId $messageRuleId
```
This example shows how to use the Remove-MgBetaUserMailFolderMessageRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
