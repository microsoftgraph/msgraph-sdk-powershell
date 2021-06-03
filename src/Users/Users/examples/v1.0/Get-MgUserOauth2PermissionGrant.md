### Example 1: Get user's oAuth2PermissionGrant 
```powershell
PS C:\> Get-MgUserOauth2permissionGrant  -UserId "68550c41-18a3-495e-aa1d-cf628c171b48"

Id                                                               ClientId                             ConsentType PrincipalId                          ResourceId                           Scope
--                                                               --------                             ----------- -----------                          ----------                           -----
F-eYWQGKuUS7WYM4IyWyuchvEPl3fYZLhdmaX2Ic7rRBDFVooxheSaodz2KMFxtI 5998e717-8a01-44b9-bb59-83382325b2b9 Principal   68550c41-18a3-495e-aa1d-cf628c171b48 f9106fc8-7d77-4b86-85d9-9a5f621ceeb4  User.Read offline_access profile
```

This example gets Get oauth2PermissionGrants for the specified user.
