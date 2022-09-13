###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgUserAuthenticationTemporaryAccessPassMethod -UserId $userId -TemporaryAccessPassAuthenticationMethodId $temporaryAccessPassAuthenticationMethodId
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgUserAuthenticationTemporaryAccessPassMethod -UserId $userId
```
