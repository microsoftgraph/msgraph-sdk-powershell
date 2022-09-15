### Example 1: Using the Get-MgUserAuthenticationMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationMethod -UserId $userId -AuthenticationMethodId $authenticationMethodId
```
This example shows how to use the Get-MgUserAuthenticationMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserAuthenticationMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationMethod -UserId $userId
```
This example shows how to use the Get-MgUserAuthenticationMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
