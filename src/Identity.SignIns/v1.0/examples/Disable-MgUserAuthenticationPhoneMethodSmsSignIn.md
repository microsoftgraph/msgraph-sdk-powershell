### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

# A UPN can also be used as -UserId.
Disable-MgUserAuthenticationPhoneMethodSmsSignIn -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId

```
This example shows how to use the Disable-MgUserAuthenticationPhoneMethodSmsSignIn Cmdlet.

