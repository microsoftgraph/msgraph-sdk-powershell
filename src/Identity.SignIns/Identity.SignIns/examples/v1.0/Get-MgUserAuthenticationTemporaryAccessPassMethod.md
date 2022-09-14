### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgUserAuthenticationTemporaryAccessPassMethod -UserId $userId -TemporaryAccessPassAuthenticationMethodId $temporaryAccessPassAuthenticationMethodId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgUserAuthenticationTemporaryAccessPassMethod -UserId $userId
```
