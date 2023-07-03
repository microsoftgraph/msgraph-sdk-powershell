### Example 1: Using the Invoke-MgBetaInvalidateUserRefreshToken Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
# A UPN can also be used as -UserId.
Invoke-MgBetaInvalidateUserRefreshToken -UserId $userId
```
This example shows how to use the Invoke-MgBetaInvalidateUserRefreshToken Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
