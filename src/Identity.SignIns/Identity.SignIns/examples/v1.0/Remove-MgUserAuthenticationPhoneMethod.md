###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Remove-MgUserAuthenticationPhoneMethod -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId
```
