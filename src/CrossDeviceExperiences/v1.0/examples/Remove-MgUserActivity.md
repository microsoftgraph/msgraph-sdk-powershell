### Example 1: Using the Remove-MgUserActivity Cmdlet
```powershell
Import-Module Microsoft.Graph.CrossDeviceExperiences
# A UPN can also be used as -UserId.
Remove-MgUserActivity -UserId $userId -UserActivityId $userActivityId
```
This example shows how to use the Remove-MgUserActivity Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
