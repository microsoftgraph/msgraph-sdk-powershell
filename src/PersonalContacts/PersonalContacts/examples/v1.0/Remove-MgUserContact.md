###Example 1
```
Import-Module Microsoft.Graph.PersonalContacts
# A UPN can also be used as -UserId.
Remove-MgUserContact -UserId $userId -ContactId $contactId
```
