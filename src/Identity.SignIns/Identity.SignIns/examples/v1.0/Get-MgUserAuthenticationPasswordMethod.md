### Example 1: Using the Get-MgUserAuthenticationPasswordMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationPasswordMethod -UserId $userId -PasswordAuthenticationMethodId $passwordAuthenticationMethodId
```
This example shows how to use the Get-MgUserAuthenticationPasswordMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserAuthenticationPasswordMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationPasswordMethod -UserId $userId
```
This example shows how to use the Get-MgUserAuthenticationPasswordMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
