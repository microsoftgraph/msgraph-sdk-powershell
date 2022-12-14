### Example 1: Using the Remove-MgBetaUserProfileEmail Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileEmail -UserId $userId -ItemEmailId $itemEmailId
```
This example shows how to use the Remove-MgBetaUserProfileEmail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
