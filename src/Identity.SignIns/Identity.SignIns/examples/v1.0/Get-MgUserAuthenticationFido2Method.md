### Example 1: Using the Get-MgUserAuthenticationFido2Method Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationFido2Method -UserId $userId -Fido2AuthenticationMethodId $fido2AuthenticationMethodId
```
This example shows how to use the Get-MgUserAuthenticationFido2Method Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
