### Example 1: Create an eligible role assignment

```powershell
$params = @{
  "PrincipalId" = "6c42590f-fcf0-4922-bac6-205f7c6aa89c"
  "RoleDefinitionId" = "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
  "Justification" = "Add eligible assignment"
  "DirectoryScopeId" = "/"
  "Action" = "AdminAssign"
  "ScheduleInfo" = @{
    "StartDateTime" = Get-Date
    "Expiration" = @{
      "Type" = "AfterDuration"
      "Duration" = "PT10H"
      }
    }
   }

New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest -BodyParameter $params | 
  Format-List Id, Status, Action, AppScopeId, DirectoryScopeId, RoleDefinitionId, IsValidationOnly, Justification, PrincipalId, CompletedDateTime, CreatedDateTime

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
CreatedDateTime   : 5/13/2022 7:39:05 AM
```

This example creates an eligible role assignment for user **6c42590f-fcf0-4922-bac6-205f7c6aa89c** for 10 hours for the specified role. An eligible role doesn't give a user access to the permissions defined for the role. It can potentially be activated to allow the user access to those permissions.

### Example 2: Extend an eligible role assignment

```powershell
$params = @{
  "PrincipalId" = "6c42590f-fcf0-4922-bac6-205f7c6aa89c"
  "RoleDefinitionId" = "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
  "Justification" = "Extend eligible assignment"
  "DirectoryScopeId" = "/"
  "Action" = "AdminExtend"
  "ScheduleInfo" = @{
    "StartDateTime" = Get-Date
    "Expiration" = @{
      "Type" = "AfterDateTime"
      "EndDateTime" = (Get-Date).AddDays(5)
      }
  }
}

New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest -BodyParameter $params | 
  Format-List Id, Status, Action, AppScopeId, DirectoryScopeId, RoleDefinitionId, IsValidationOnly, Justification, PrincipalId, CompletedDateTime, CreatedDateTime

Id                : 8b91032b-8172-4096-92c3-d91d2e446c2d
Status            : Provisioned
Action            : AdminExtend
AppScopeId        :
DirectoryScopeId  : /
RoleDefinitionId  : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
IsValidationOnly  : False
Justification     : Extend eligible assignment
PrincipalId       : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
CompletedDateTime : 5/13/2022 8:00:22 AM
CreatedDateTime   : 5/13/2022 8:00:19 AM
```

This example extends an eligible role assignment for user **6c42590f-fcf0-4922-bac6-205f7c6aa89c** to 5 days.

### Example 3: Remove an eligible role assignment

```powershell
$params = @{
  "PrincipalId" = "6c42590f-fcf0-4922-bac6-205f7c6aa89c"
  "RoleDefinitionId" = "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
  "Justification" = "Remove eligible assignment"
  "DirectoryScopeId" = "/"
  "Action" = "AdminRemove"
}

New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest -BodyParameter $params |
  Format-List Id, Status, Action, AppScopeId, DirectoryScopeId, RoleDefinitionID, IsValidationOnly, Justification, PrincipalId, CompletedDateTime, CreatedDateTime, TargetScheduleID

Id                : 5e30aede-ba5e-4182-9dd0-5b2141dd7520
Status            : Revoked
Action            : AdminRemove
AppScopeId        :
DirectoryScopeId  : /
RoleDefinitionId  : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
IsValidationOnly  : False
Justification     : Remove eligible assignment
PrincipalId       : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
CompletedDateTime :
CreatedDateTime   : 5/13/2022 9:31:14 AM
TargetScheduleId  :
```

This example removes an eligible role assignment for user **6c42590f-fcf0-4922-bac6-205f7c6aa89c**.
