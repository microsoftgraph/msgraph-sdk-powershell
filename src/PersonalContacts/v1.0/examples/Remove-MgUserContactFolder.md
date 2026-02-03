### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.PersonalContacts

# A UPN can also be used as -UserId.
Remove-MgUserContactFolder -UserId $userId -ContactFolderId $contactFolderId
```
This example shows how to use the Remove-MgUserContactFolder Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

