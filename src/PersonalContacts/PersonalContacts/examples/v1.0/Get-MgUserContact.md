###Example 1
```
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContact -UserId $userId -ContactId $contactId
```
###Example 2
```
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Get-MgUserContact -UserId $userId
```
