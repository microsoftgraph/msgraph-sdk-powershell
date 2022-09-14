### Example 1
``` powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Enable-MgUserAuthenticationPhoneMethodSmSign -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId
```
