###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
Get-MgUserPresence -UserId $userId
```
###Example 2
```
Import-Module Microsoft.Graph.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgUserPresence -UserId $userId
```
