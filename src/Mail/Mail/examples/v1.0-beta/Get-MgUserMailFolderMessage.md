### Example 1: Using the Get-MgBetaUserMailFolderMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
# A UPN can also be used as -UserId.
Get-MgBetaUserMailFolderMessage -UserId $userId -MailFolderId $mailFolderId
```
This example shows how to use the Get-MgBetaUserMailFolderMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
