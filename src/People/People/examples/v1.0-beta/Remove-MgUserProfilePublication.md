### Example 1: Using the Remove-MgUserProfilePublication Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfilePublication -UserId $userId -ItemPublicationId $itemPublicationId
```
This example shows how to use the Remove-MgUserProfilePublication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
