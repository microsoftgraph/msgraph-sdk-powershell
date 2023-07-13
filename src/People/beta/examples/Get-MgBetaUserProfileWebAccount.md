### Example 1: Using the Get-MgBetaUserProfileWebAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileWebAccount -UserId $userId -WebAccountId $webAccountId
```
This example shows how to use the Get-MgBetaUserProfileWebAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileWebAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileWebAccount -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileWebAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
