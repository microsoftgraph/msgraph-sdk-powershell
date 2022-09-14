### Example 1
```powershell
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContactFolderContact -UserId $userId -ContactFolderId $contactFolderId
```
