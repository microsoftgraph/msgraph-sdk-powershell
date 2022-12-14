### Example 1: Using the Remove-MgBetaUserProfileWebsite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileWebsite -UserId $userId -PersonWebsiteId $personWebsiteId
```
This example shows how to use the Remove-MgBetaUserProfileWebsite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
