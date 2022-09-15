### Example 1: Using the Remove-MgUserProfileEmail Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileEmail -UserId $userId -ItemEmailId $itemEmailId
```
This example shows how to use the Remove-MgUserProfileEmail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
