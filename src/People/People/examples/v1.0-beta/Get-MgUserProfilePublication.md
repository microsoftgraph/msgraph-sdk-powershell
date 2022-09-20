### Example 1: Using the Get-MgUserProfilePublication Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfilePublication -UserId $userId -ItemPublicationId $itemPublicationId
```
This example shows how to use the Get-MgUserProfilePublication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfilePublication Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfilePublication -UserId $userId
```
This example shows how to use the Get-MgUserProfilePublication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
