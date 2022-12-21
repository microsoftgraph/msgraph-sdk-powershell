### Example 1: Using the Get-MgBetaUserOwnedObject Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Get-MgBetaUserOwnedObject -UserId $userId
```
This example shows how to use the Get-MgBetaUserOwnedObject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
