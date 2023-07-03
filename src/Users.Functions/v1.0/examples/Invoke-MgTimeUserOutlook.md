### Example 1: Using the Invoke-MgTimeUserOutlook Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Invoke-MgTimeUserOutlook -UserId $userId
```
This example shows how to use the Invoke-MgTimeUserOutlook Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
