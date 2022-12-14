### Example 1: Using the Invoke-MgBetaTimeUserOutlook Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Functions
# A UPN can also be used as -UserId.
Invoke-MgBetaTimeUserOutlook -UserId $userId
```
This example shows how to use the Invoke-MgBetaTimeUserOutlook Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
