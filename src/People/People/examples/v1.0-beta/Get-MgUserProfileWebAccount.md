### Example 1: Using the Get-MgUserProfileWebAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileWebAccount -UserId $userId -WebAccountId $webAccountId
```
This example shows how to use the Get-MgUserProfileWebAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileWebAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileWebAccount -UserId $userId
```
This example shows how to use the Get-MgUserProfileWebAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
