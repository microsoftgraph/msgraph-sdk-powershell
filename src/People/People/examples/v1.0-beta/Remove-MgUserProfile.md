### Example 1: Using the Remove-MgUserProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfile -UserId $userId
```
This example shows how to use the Remove-MgUserProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
