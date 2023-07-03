### Example 1: Using the Remove-MgBetaUserProfilePosition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfilePosition -UserId $userId -WorkPositionId $workPositionId
```
This example shows how to use the Remove-MgBetaUserProfilePosition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
