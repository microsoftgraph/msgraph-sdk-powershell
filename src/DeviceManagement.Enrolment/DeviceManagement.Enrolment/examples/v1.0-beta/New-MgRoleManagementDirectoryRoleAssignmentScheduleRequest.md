### Example 1: User activates an eligible role assignment

```powershell
$params = @{
  "PrincipalId" = "6c42590f-fcf0-4922-bac6-205f7c6aa89c"
  "RoleDefinitionId" = "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
  "Justification" = "Activate assignment"
  "DirectoryScopeId" = "/"
  "Action" = "SelfActivate"
  "ScheduleInfo" = @{
    "StartDateTime" = Get-Date
    "Expiration" = @{
       "Type" = "AfterDuration"
       "Duration" = "PT3H"
       }
     }
    }

New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -BodyParameter $params |
  Format-List Id, Status, Action, AppScopeId, DirectoryScopeId, RoleDefinitionID, IsValidationOnly, Justification, PrincipalId, CompletedDateTime, CreatedDateTime, TargetScheduleID


Id                : 76dd76bb-900f-470b-9bcc-1eb68bc45532
Status            : Provisioned
Action            : SelfActivate
AppScopeId        :
DirectoryScopeId  : /
RoleDefinitionId  : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
IsValidationOnly  : False
Justification     : Activate assignment
PrincipalId       : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
CompletedDateTime : 5/13/2022 8:14:32 AM
CreatedDateTime   : 5/13/2022 8:14:30 AM
TargetScheduleId  : 76dd76bb-900f-470b-9bcc-1eb68bc45532
```

In this example, the user activates an eligible role assignment for 3 hours. An active role assignment allows the user access to all permissions defined for that role for the defined duration.

### Example 2: Admin creates an active role assignment

```powershell
$params = @{
  "PrincipalId" = "6c42590f-fcf0-4922-bac6-205f7c6aa89c"
  "RoleDefinitionId" = "9360feb5-f418-4baa-8175-e2a00bac4301"
  "Justification" = "Add active role assignment"
  "DirectoryScopeId" = "/"
  "Action" = "AdminAssign"
  "ScheduleInfo" = @{
     "StartDateTime" = Get-Date
     "Expiration" = @{
        "Type" = "AfterDuration"
        "Duration" = "PT30H"
        }
      }
     }

New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -BodyParameter $params |
  Format-List Id, Status, Action, AppScopeId, DirectoryScopeId, RoleDefinitionID, IsValidationOnly, Justification, PrincipalId, CompletedDateTime, CreatedDateTime, TargetScheduleID

Id                : 9e98256e-58af-4d02-89ce-5134e2fe5508
Status            : Provisioned
Action            : AdminAssign
AppScopeId        :
DirectoryScopeId  : /
RoleDefinitionId  : 9360feb5-f418-4baa-8175-e2a00bac4301
IsValidationOnly  : False
Justification     : Add active role assignment
PrincipalId       : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
CompletedDateTime : 5/13/2022 8:33:37 AM
CreatedDateTime   : 5/13/2022 8:33:36 AM
TargetScheduleId  : 9e98256e-58af-4d02-89ce-5134e2fe5508
```

In this example, an admin creates an active role assignment for the specified user for the specified duration.

### Example 3: User deactivates an active role assignment

```powershell
$params = @{
  "PrincipalId" = "6c42590f-fcf0-4922-bac6-205f7c6aa89c"
  "RoleDefinitionId" = "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
  "Justification" = "Deactivate assignment"
  "DirectoryScopeId" = "/"
  "Action" = "SelfDeactivate"
  }

New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -BodyParameter $params |
  Format-List Id, Status, Action, AppScopeId, DirectoryScopeId, RoleDefinitionID, IsValidationOnly, Justification, PrincipalId, CompletedDateTime, CreatedDateTime, TargetScheduleID

Id                : 2ce935eb-633d-47ee-8dd1-bffc48a79e53
Status            : Revoked
Action            : SelfDeactivate
AppScopeId        :
DirectoryScopeId  : /
RoleDefinitionId  : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
IsValidationOnly  : False
Justification     : Deactivate assignment
PrincipalId       : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
CompletedDateTime :
CreatedDateTime   : 5/13/2022 9:27:09 AM
TargetScheduleId  :
```

In this example, the user deactivates an active role assignment. They will no longer have access to the permissions defined for that role.
