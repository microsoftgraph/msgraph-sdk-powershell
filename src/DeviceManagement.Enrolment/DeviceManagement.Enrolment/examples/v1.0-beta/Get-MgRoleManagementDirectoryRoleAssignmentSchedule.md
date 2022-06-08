### Example 1: Get all assignment schedules

```powershell
Get-MgRoleManagementDirectoryRoleAssignmentSchedule | Format-List

ActivatedUsing       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleEligibilitySchedule
AppScope             : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId           :
AssignmentType       : Assigned
CreatedDateTime      :
CreatedUsing         :
DirectoryScope       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId     : /
Id                   : 4-PYiFWPHkqVOpuYmLiHa_CWtrDUYhRNsQq0vuB-N3E-1
MemberType           : Direct
ModifiedDateTime     :
Principal            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId          : b0b696f0-62d4-4d14-b10a-b4bee07e3771
RoleDefinition       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId     : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
ScheduleInfo         : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
Status               : Provisioned
AdditionalProperties : {}

ActivatedUsing       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleEligibilitySchedule
AppScope             : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId           :
AssignmentType       : Activated
CreatedDateTime      : 5/13/2022 8:14:33 AM
CreatedUsing         : 76dd76bb-900f-470b-9bcc-1eb68bc45532
DirectoryScope       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId     : /
Id                   : 76dd76bb-900f-470b-9bcc-1eb68bc45532
MemberType           : Direct
ModifiedDateTime     :
Principal            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId          : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleDefinition       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId     : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
ScheduleInfo         : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
Status               : Provisioned
AdditionalProperties : {}
```

This example gets all active role assignment schedules. This includes active roles assignments that have been created and the future scheduled assignments.

### Example 2: Get all assignment schedules for a user

```powershell
Get-MgRoleManagementDirectoryRoleAssignmentSchedule -Filter "principalId eq '6c42590f-fcf0-4922-bac6-205f7c6aa89c'” 

ActivatedUsing       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleEligibilitySchedule
AppScope             : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId           :
AssignmentType       : Activated
CreatedDateTime      : 5/13/2022 8:14:33 AM
CreatedUsing         : 76dd76bb-900f-470b-9bcc-1eb68bc45532
DirectoryScope       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId     : /
Id                   : 76dd76bb-900f-470b-9bcc-1eb68bc45532
MemberType           : Direct
ModifiedDateTime     :
Principal            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId          : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleDefinition       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId     : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
ScheduleInfo         : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
Status               : Provisioned
AdditionalProperties : {}

ActivatedUsing       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleEligibilitySchedule
AppScope             : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId           :
AssignmentType       : Assigned
CreatedDateTime      : 5/13/2022 8:33:37 AM
CreatedUsing         : 9e98256e-58af-4d02-89ce-5134e2fe5508
DirectoryScope       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId     : /
Id                   : 9e98256e-58af-4d02-89ce-5134e2fe5508
MemberType           : Direct
ModifiedDateTime     :
Principal            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId          : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleDefinition       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId     : 9360feb5-f418-4baa-8175-e2a00bac4301
ScheduleInfo         : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
Status               : Provisioned
AdditionalProperties : {}
```

This example gets all active role assignment schedules for a user.
