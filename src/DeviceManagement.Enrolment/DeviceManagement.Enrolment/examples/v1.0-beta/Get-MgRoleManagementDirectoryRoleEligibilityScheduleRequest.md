### Example 1: Get all role eligibility requests

```powershell
Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequest | 
  Format-List  Id, Status, Action, AppScopeId, DirectoryScopeId, RoleDefinitionId, IsValidationOnly, Justification, PrincipalId, CompletedDateTime, CreatedDateTime, TargetScheduleID

Id                : 8554c1e7-b359-41b9-802e-4beabddec142
Status            : Provisioned
Action            : AdminAssign
AppScopeId        :
DirectoryScopeId  : /
RoleDefinitionId  : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
IsValidationOnly  : False
Justification     : Add eligible assignment
PrincipalId       : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
CompletedDateTime : 5/13/2022 7:39:07 AM
CreatedDateTime   : 5/13/2022 7:39:07 AM
TargetScheduleId  : 8554c1e7-b359-41b9-802e-4beabddec142
```

This example gets all role eligibility requests.

### Example 2: Get all role eligibility requests for a user

```powershell
Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequest -Filter "principalId eq '6c42590f-fcf0-4922-bac6-205f7c6aa89c'" | 
  Format-List  Id, Status, Action, AppScopeId, DirectoryScopeId, RoleDefinitionId, IsValidationOnly, Justification, PrincipalId, CompletedDateTime, CreatedDateTime, TargetScheduleID

Id                : 1ab90e94-1e26-4ce2-be98-b8e848fed14d
Status            : Provisioned
Action            : AdminAssign
AppScopeId        :
DirectoryScopeId  : /
RoleDefinitionId  : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
IsValidationOnly  : False
Justification     : Add eligible assignment
PrincipalId       : d29e358a-a443-4d83-98b3-499a5405bb5b
CompletedDateTime : 3/22/2022 11:05:48 AM
CreatedDateTime   : 3/22/2022 11:05:48 AM
TargetScheduleId  : 1ab90e94-1e26-4ce2-be98-b8e848fed14d
```

This example gets all role eligibility requests for the specified user.
