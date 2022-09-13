###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationFido2Method -UserId $userId -Fido2AuthenticationMethodId $fido2AuthenticationMethodId
```
