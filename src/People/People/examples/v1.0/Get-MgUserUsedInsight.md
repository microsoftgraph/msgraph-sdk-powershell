###Example 1
```
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserUsedInsight -UserId $userId -Sort "LastUsed/LastAccessedDateTime desc" 
```
###Example 2
```
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserUsedInsight -UserId $userId
```
