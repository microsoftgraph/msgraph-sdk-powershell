### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Remove-MgUserAuthenticationMicrosoftAuthenticatorMethod -UserId $userId -MicrosoftAuthenticatorAuthenticationMethodId $microsoftAuthenticatorAuthenticationMethodId
```
