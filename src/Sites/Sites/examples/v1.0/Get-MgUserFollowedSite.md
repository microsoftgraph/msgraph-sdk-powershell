### Example 1
``` powershell
Import-Module Microsoft.Graph.Sites
# A UPN can also be used as -UserId.
Get-MgUserFollowedSite -UserId $userId
```
