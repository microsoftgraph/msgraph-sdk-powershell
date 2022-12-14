### Example 1: Using the Get-MgBetaUserAuthenticationSoftwareOathMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationSoftwareOathMethod -UserId $userId -SoftwareOathAuthenticationMethodId $softwareOathAuthenticationMethodId
```
This example shows how to use the Get-MgBetaUserAuthenticationSoftwareOathMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserAuthenticationSoftwareOathMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationSoftwareOathMethod -UserId $userId
```
This example shows how to use the Get-MgBetaUserAuthenticationSoftwareOathMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
