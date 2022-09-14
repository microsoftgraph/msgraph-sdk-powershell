### Example 1: Using the Get-MgUserMailFolderMessageRule Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId -MessageRuleId $messageRuleId
```
This example shows how to use the Get-MgUserMailFolderMessageRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserMailFolderMessageRule Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId
```
This example shows how to use the Get-MgUserMailFolderMessageRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
