### Example 1: Using the Get-MgBetaUserAuthenticationPasswordMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationPasswordMethod -UserId $userId -PasswordAuthenticationMethodId $passwordAuthenticationMethodId
```
This example shows how to use the Get-MgBetaUserAuthenticationPasswordMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserAuthenticationPasswordMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationPasswordMethod -UserId $userId
```
This example shows how to use the Get-MgBetaUserAuthenticationPasswordMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
