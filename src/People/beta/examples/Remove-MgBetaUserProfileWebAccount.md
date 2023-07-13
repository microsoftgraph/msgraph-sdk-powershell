### Example 1: Using the Remove-MgBetaUserProfileWebAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileWebAccount -UserId $userId -WebAccountId $webAccountId
```
This example shows how to use the Remove-MgBetaUserProfileWebAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
