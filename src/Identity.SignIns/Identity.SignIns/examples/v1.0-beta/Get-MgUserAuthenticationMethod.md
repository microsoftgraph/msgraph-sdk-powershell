### Example 1: Using the Get-MgBetaUserAuthenticationMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationMethod -UserId $userId -AuthenticationMethodId $authenticationMethodId
```
This example shows how to use the Get-MgBetaUserAuthenticationMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserAuthenticationMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationMethod -UserId $userId
```
This example shows how to use the Get-MgBetaUserAuthenticationMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
