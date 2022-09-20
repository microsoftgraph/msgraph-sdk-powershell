### Example 1: Using the Remove-MgUserProfileWebAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileWebAccount -UserId $userId -WebAccountId $webAccountId
```
This example shows how to use the Remove-MgUserProfileWebAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
