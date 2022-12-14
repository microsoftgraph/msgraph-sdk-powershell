### Example 1: Using the Remove-MgBetaUserAuthenticationPhoneMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Remove-MgBetaUserAuthenticationPhoneMethod -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId
```
This example shows how to use the Remove-MgBetaUserAuthenticationPhoneMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
