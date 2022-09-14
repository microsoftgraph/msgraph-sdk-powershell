### Example 1
``` powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserUsedInsight -UserId $userId -Sort "LastUsed/LastAccessedDateTime desc" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserUsedInsight -UserId $userId
```
