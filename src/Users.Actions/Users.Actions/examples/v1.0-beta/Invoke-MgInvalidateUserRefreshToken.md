### Example 1: Using the Invoke-MgInvalidateUserRefreshToken Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Invoke-MgInvalidateUserRefreshToken -UserId $userId
```
This example shows how to use the Invoke-MgInvalidateUserRefreshToken Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
