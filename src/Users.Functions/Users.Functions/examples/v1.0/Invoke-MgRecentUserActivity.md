### Example 1: Using the Invoke-MgRecentUserActivity Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Invoke-MgRecentUserActivity -UserId $userId
```
This example shows how to use the Invoke-MgRecentUserActivity Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
