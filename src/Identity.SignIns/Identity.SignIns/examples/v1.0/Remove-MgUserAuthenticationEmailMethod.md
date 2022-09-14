### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Remove-MgUserAuthenticationEmailMethod -UserId $userId -EmailAuthenticationMethodId $emailAuthenticationMethodId
```
