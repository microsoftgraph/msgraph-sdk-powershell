### Example 1: Using the Get-MgUserContactFolderContact Cmdlet
```powershell
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContactFolderContact -UserId $userId -ContactFolderId $contactFolderId
```
This example shows how to use the Get-MgUserContactFolderContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
