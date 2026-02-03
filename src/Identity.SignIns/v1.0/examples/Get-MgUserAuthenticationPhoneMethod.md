### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

# A UPN can also be used as -UserId.
Get-MgUserAuthenticationPhoneMethod -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId
```
This example shows how to use the Get-MgUserAuthenticationPhoneMethod Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

