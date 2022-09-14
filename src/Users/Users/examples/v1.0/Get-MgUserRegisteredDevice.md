### Example 1: Using the Get-MgUserRegisteredDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserRegisteredDevice -UserId $userId
```
This example shows how to use the Get-MgUserRegisteredDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
