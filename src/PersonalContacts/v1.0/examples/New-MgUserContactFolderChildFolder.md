### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.PersonalContacts

# A UPN can also be used as -UserId.
Get-MgUserContactFolderChildFolder -UserId $userId -ContactFolderId $contactFolderId
```
This example shows how to use the New-MgUserContactFolderChildFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

