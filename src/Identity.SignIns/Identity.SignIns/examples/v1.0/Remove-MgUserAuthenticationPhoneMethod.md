### Example 1: Using the Remove-MgUserAuthenticationPhoneMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Remove-MgUserAuthenticationPhoneMethod -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId
```
This example shows how to use the Remove-MgUserAuthenticationPhoneMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
