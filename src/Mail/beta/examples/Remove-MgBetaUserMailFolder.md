### Example 1: Using the Remove-MgBetaUserMailFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
# A UPN can also be used as -UserId.
Remove-MgBetaUserMailFolder -UserId $userId -MailFolderId $mailFolderId
```
This example shows how to use the Remove-MgBetaUserMailFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
