### Example 1: Using the Get-MgBetaUserProfileWebsite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileWebsite -UserId $userId -PersonWebsiteId $personWebsiteId
```
This example shows how to use the Get-MgBetaUserProfileWebsite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileWebsite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileWebsite -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileWebsite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
