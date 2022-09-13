###Example 1
```
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Enable-MgUserAuthenticationPhoneMethodSmSign -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId
```
