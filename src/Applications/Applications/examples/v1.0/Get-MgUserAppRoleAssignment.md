### Example 1: Get assigned user roles

This command gets all the application roles that the selected user has been assigned.

```powershell
 Get-MgUserAppRoleAssignment -UserId "529827aa-d058-4821-a012-4de3ce093955" | 
  Format-List Id, AppRoleID, CreationTimeStamp, PrincipalDisplayName,PrincipalId, PrincipalType, ResourceDisplayName
```

```Output
Id                   : QQxVaKMYXkmqHc9ijBcbSFkvIqIpOSdOjXRyNBWe_zE
AppRoleId            : 00000000-0000-0000-0000-000000000000
PrincipalDisplayName : MOD Administrator
PrincipalId          : 529827aa-d058-4821-a012-4de3ce093955
PrincipalType        : User
ResourceDisplayName  : MOD Demo Platform UnifiedApiConsumer

Id                   : QQxVaKMYXkmqHc9ijBcbSDXNn98ZHl9Gg4yTKKIIUFA
AppRoleId            : 00000000-0000-0000-0000-000000000000
PrincipalDisplayName : MOD Administrator
PrincipalId          : 529827aa-d058-4821-a012-4de3ce093955
PrincipalType        : User
ResourceDisplayName  : dxprovisioning-worker-mfa
```