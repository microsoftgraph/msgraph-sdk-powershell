### Example 1: Using the Remove-MgBetaUserActivity Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CrossDeviceExperiences
# A UPN can also be used as -UserId.
Remove-MgBetaUserActivity -UserId $userId -UserActivityId $userActivityId
```
This example shows how to use the Remove-MgBetaUserActivity Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
