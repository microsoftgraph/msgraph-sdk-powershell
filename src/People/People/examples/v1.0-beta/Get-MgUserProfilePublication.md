### Example 1: Using the Get-MgBetaUserProfilePublication Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfilePublication -UserId $userId -ItemPublicationId $itemPublicationId
```
This example shows how to use the Get-MgBetaUserProfilePublication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfilePublication Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfilePublication -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfilePublication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
