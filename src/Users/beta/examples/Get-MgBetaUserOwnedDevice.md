### Example 1: Using the Get-MgBetaUserOwnedDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Get-MgBetaUserOwnedDevice -UserId $userId
```
This example shows how to use the Get-MgBetaUserOwnedDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
