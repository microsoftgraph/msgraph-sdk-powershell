###Example 1
```
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContactFolderChildFolder -UserId $userId -ContactFolderId $contactFolderId
```
