### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.PersonalContacts

# A UPN can also be used as -UserId.
Get-MgBetaUserContactFolderChildFolder -UserId $userId -ContactFolderId $contactFolderId

```
This example shows how to use the Get-MgBetaUserContactFolderChildFolder Cmdlet.

