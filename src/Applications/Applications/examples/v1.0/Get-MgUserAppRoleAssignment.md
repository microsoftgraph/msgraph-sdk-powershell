### Example 1: Get assigned user roles
```powershell
PS C:\> Get-MgUserAppRoleAssignment -UserId <string>

Id                                          AppRoleId                            CreationTimestamp PrincipalDisplayName PrincipalId                          PrincipalType ResourceDisplayName                  ResourceId
--                                          ---------                            ----------------- -------------------- -----------                          ------------- -------------------                  ----------
QQxVaKMYXkmqHc9ijBcbSFkvIqIpOSdOjXRyNBWe_zE 00000000-0000-0000-0000-000000000000                   MOD Administrator    68550c41-18a3-495e-aa1d-cf628c171b48 User          MOD Demo Platform UnifiedApiConsumer a06ea9ab-3ec6-41f0-a891-16654144ff1c
QQxVaKMYXkmqHc9ijBcbSDXNn98ZHl9Gg4yTKKIIUFA 00000000-0000-0000-0000-000000000000                   MOD Administrator    68550c41-18a3-495e-aa1d-cf628c171b48 User          dxprovisioning-worker-mfa            d7e1ac22-f8e2-42f6-b711-fb0ea77693de
```

This command gets all the application roles that the selected userid has been assigned. 
