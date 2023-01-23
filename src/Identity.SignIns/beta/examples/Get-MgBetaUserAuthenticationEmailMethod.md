### Example 1: Using the Get-MgBetaUserAuthenticationEmailMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationEmailMethod -UserId $userId -EmailAuthenticationMethodId $emailAuthenticationMethodId
```
This example shows how to use the Get-MgBetaUserAuthenticationEmailMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserAuthenticationEmailMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationEmailMethod -UserId $userId
```
This example shows how to use the Get-MgBetaUserAuthenticationEmailMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
