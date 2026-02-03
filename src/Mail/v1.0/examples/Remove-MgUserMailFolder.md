### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Mail

# A UPN can also be used as -UserId.
Remove-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId
```
This example shows how to use the Remove-MgUserMailFolder Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

