###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationPasswordMethod -UserId $userId -PasswordAuthenticationMethodId $passwordAuthenticationMethodId
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationPasswordMethod -UserId $userId
```
