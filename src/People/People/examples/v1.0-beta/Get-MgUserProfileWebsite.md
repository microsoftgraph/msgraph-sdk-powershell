### Example 1: Using the Get-MgUserProfileWebsite Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileWebsite -UserId $userId -PersonWebsiteId $personWebsiteId
```
This example shows how to use the Get-MgUserProfileWebsite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileWebsite Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileWebsite -UserId $userId
```
This example shows how to use the Get-MgUserProfileWebsite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
