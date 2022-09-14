### Example 1
``` powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserOwnedObject -UserId $userId
```
