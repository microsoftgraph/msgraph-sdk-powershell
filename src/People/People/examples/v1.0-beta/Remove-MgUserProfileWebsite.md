### Example 1: Using the Remove-MgUserProfileWebsite Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileWebsite -UserId $userId -PersonWebsiteId $personWebsiteId
```
This example shows how to use the Remove-MgUserProfileWebsite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
