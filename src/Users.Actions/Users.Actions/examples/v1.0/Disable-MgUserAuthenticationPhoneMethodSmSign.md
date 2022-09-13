###Example 1
```
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Disable-MgUserAuthenticationPhoneMethodSmSign -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId
```
