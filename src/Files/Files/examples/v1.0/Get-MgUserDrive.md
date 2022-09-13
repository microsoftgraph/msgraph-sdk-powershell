###Example 1
```
Import-Module Microsoft.Graph.Files
# A UPN can also be used as -UserId.
Get-MgUserDrive -UserId $userId
```
###Example 2
```
Import-Module Microsoft.Graph.Files
Get-MgUserDrive -UserId $userId
```
