### Example 1: Using the Get-MgBetaUserContactFolderChildFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgBetaUserContactFolderChildFolder -UserId $userId -ContactFolderId $contactFolderId
```
This example shows how to use the Get-MgBetaUserContactFolderChildFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
