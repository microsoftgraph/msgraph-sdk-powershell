### Example 1: Using the Get-MgUserAuthenticationSoftwareOathMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationSoftwareOathMethod -UserId $userId -SoftwareOathAuthenticationMethodId $softwareOathAuthenticationMethodId
```
This example shows how to use the Get-MgUserAuthenticationSoftwareOathMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserAuthenticationSoftwareOathMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationSoftwareOathMethod -UserId $userId
```
This example shows how to use the Get-MgUserAuthenticationSoftwareOathMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
