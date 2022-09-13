###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationPhoneMethod -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationPhoneMethod -UserId $userId
```
