### Example 1: Using the Get-MgUserOwnedDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserOwnedDevice -UserId $userId
```
This example shows how to use the Get-MgUserOwnedDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
