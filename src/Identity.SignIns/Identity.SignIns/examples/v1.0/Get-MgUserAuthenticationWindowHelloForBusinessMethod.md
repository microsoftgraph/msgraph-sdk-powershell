### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgUserAuthenticationWindowHelloForBusinessMethod -UserId $userId -WindowsHelloForBusinessAuthenticationMethodId $windowsHelloForBusinessAuthenticationMethodId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgUserAuthenticationWindowHelloForBusinessMethod -UserId $userId
```
