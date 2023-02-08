### Example 1: Using the Remove-MgBetaUserProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfile -UserId $userId
```
This example shows how to use the Remove-MgBetaUserProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
