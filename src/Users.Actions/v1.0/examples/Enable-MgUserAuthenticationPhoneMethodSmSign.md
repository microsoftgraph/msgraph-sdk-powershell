### Example 1: Using the Enable-MgUserAuthenticationPhoneMethodSmSign Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Enable-MgUserAuthenticationPhoneMethodSmSign -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId
```
This example shows how to use the Enable-MgUserAuthenticationPhoneMethodSmSign Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
