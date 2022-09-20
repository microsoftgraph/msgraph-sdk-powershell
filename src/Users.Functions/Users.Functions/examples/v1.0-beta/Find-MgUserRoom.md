### Example 1: Using the Find-MgUserRoom Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Find-MgUserRoom -UserId $userId
```
This example shows how to use the Find-MgUserRoom Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
