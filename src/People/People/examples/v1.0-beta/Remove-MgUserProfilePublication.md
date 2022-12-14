### Example 1: Using the Remove-MgBetaUserProfilePublication Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfilePublication -UserId $userId -ItemPublicationId $itemPublicationId
```
This example shows how to use the Remove-MgBetaUserProfilePublication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
