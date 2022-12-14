### Example 1: Using the Get-MgBetaUserContactFolderContact Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgBetaUserContactFolderContact -UserId $userId -ContactFolderId $contactFolderId
```
This example shows how to use the Get-MgBetaUserContactFolderContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
