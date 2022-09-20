### Example 1: Using the Remove-MgUserProfilePosition Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfilePosition -UserId $userId -WorkPositionId $workPositionId
```
This example shows how to use the Remove-MgUserProfilePosition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
