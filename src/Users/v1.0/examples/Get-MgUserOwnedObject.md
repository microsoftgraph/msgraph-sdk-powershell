### Example 1: Using the Get-MgUserOwnedObject Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserOwnedObject -UserId $userId
```
This example shows how to use the Get-MgUserOwnedObject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
