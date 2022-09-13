###Example 1
```
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContactFolder -UserId $userId -ContactFolderId $contactFolderId
```
###Example 2
```
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContactFolder -UserId $userId
```
