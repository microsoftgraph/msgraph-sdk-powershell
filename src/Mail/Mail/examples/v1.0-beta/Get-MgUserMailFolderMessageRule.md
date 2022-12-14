### Example 1: Using the Get-MgBetaUserMailFolderMessageRule Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
# A UPN can also be used as -UserId.
Get-MgBetaUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId -MessageRuleId $messageRuleId
```
This example shows how to use the Get-MgBetaUserMailFolderMessageRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserMailFolderMessageRule Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
# A UPN can also be used as -UserId.
Get-MgBetaUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId
```
This example shows how to use the Get-MgBetaUserMailFolderMessageRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
