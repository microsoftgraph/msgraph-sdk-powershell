### Example 1: Using the Remove-MgBetaUserContactFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
# A UPN can also be used as -UserId.
Remove-MgBetaUserContactFolder -UserId $userId -ContactFolderId $contactFolderId
```
This example shows how to use the Remove-MgBetaUserContactFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
