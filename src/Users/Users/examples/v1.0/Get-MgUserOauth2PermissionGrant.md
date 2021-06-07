### Example 1: Get user's oAuth2PermissionGrant 

This example gets the oauth2PermissionGrants for the specified user.

```powershell
Get-MgUserOauth2permissionGrant  -UserId 'afeb5811-0582-4188-8546-4440c2b921bd' | Format-List
```

```Output
ClientId             : 202397ec-d9d7-4b95-b5a8-ff85f5ccae11
ConsentType          : Principal
Id                   : F-eYWQGKuUS7WYM4IyWyuchvEPl3fYZLhdmaX2Ic7rRBDFVooxheSaodz2KMFxtI
PrincipalId          : afeb5811-0582-4188-8546-4440c2b921bd
ResourceId           : f9106fc8-7d77-4b86-85d9-9a5f621ceeb4
Scope                :  User.Read offline_access profile openid User.Read.All Group.ReadWrite.All Directory.ReadWrite.All
AdditionalProperties : {}
```