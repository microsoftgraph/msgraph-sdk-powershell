###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationEmailMethod -UserId $userId -EmailAuthenticationMethodId $emailAuthenticationMethodId
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationEmailMethod -UserId $userId
```
