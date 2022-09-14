### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Remove-MgUserAuthenticationFido2Method -UserId $userId -Fido2AuthenticationMethodId $fido2AuthenticationMethodId
```
