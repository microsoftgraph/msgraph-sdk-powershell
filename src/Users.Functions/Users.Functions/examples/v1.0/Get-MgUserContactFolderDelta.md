### Example 1
``` powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Get-MgUserContactFolderDelta -UserId $userId
```
