### Example 1: Using the Revoke-MgUserSign Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Revoke-MgUserSign -UserId $userId
```
This example shows how to use the Revoke-MgUserSign Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
