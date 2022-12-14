### Example 1: Using the Get-MgBetaUserAuthenticationFido2Method Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationFido2Method -UserId $userId -Fido2AuthenticationMethodId $fido2AuthenticationMethodId
```
This example shows how to use the Get-MgBetaUserAuthenticationFido2Method Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserAuthenticationFido2Method Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationFido2Method -UserId $userId
```
This example shows how to use the Get-MgBetaUserAuthenticationFido2Method Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
