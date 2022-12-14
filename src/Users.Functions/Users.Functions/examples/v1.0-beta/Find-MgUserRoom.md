### Example 1: Using the Find-MgBetaUserRoom Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Functions
# A UPN can also be used as -UserId.
Find-MgBetaUserRoom -UserId $userId
```
This example shows how to use the Find-MgBetaUserRoom Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
