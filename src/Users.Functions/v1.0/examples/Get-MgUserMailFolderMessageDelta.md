### Example 1: Using the Get-MgUserMailFolderMessageDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Get-MgUserMailFolderMessageDelta -UserId $userId -MailFolderId $mailFolderId
```
This example shows how to use the Get-MgUserMailFolderMessageDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
