###Example 1
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserOwnedDevice -UserId $userId
```
