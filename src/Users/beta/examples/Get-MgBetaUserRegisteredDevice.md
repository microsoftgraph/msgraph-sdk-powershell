### Example 1: Using the Get-MgBetaUserRegisteredDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Get-MgBetaUserRegisteredDevice -UserId $userId
```
This example shows how to use the Get-MgBetaUserRegisteredDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
