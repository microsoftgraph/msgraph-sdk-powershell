### Example 1
```powershell
Import-Module Microsoft.Graph.CrossDeviceExperiences
# A UPN can also be used as -UserId.
Remove-MgUserActivity -UserId $userId -UserActivityId $userActivityId
```
