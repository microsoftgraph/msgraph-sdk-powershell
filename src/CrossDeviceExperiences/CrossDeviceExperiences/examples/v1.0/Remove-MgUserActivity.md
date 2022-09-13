###Example 1
```
Import-Module Microsoft.Graph.CrossDeviceExperiences
# A UPN can also be used as -UserId.
Remove-MgUserActivity -UserId $userId -UserActivityId $userActivityId
```
