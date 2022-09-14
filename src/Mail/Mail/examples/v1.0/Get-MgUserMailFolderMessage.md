### Example 1: Using the Get-MgUserMailFolderMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolderMessage -UserId $userId -MailFolderId $mailFolderId
```
This example shows how to use the Get-MgUserMailFolderMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
