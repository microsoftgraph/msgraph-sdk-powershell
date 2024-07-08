### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

# A UPN can also be used as -UserId.
Enable-MgUserAuthenticationPhoneMethodSmsSignIn -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId

```
This example shows how to use the Enable-MgUserAuthenticationPhoneMethodSmsSignIn Cmdlet.

