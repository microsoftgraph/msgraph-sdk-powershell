### Example 1: Get all active role assignment requests

```powershell
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest | Format-List

Action               : SelfActivate
ActivatedUsing       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleEligibilitySchedule
AppScope             : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId           :
ApprovalId           :
CompletedDateTime    : 5/13/2022 8:14:32 AM
CreatedBy            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphIdentitySet
CreatedDateTime      : 5/13/2022 8:14:32 AM
CustomData           :
DirectoryScope       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId     : /
Id                   : 76dd76bb-900f-470b-9bcc-1eb68bc45532
IsValidationOnly     : False
Justification        : Activate assignment
Principal            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId          : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleDefinition       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId     : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
ScheduleInfo         : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
Status               : Provisioned
TargetSchedule       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleAssignmentSchedule
TargetScheduleId     : 76dd76bb-900f-470b-9bcc-1eb68bc45532
TicketInfo           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphTicketInfo
AdditionalProperties : {}
```

This example gets all the active role assignment requests.

### Example 2: Get all active role assignment requests for a user

```powershell
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -Filter "principalId eq '6c42590f-fcf0-4922-bac6-205f7c6aa89c'" | Format-List

Action               : SelfActivate
ActivatedUsing       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleEligibilitySchedule
AppScope             : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId           :
ApprovalId           :
CompletedDateTime    : 5/13/2022 8:14:32 AM
CreatedBy            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphIdentitySet
CreatedDateTime      : 5/13/2022 8:14:32 AM
CustomData           :
DirectoryScope       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId     : /
Id                   : 76dd76bb-900f-470b-9bcc-1eb68bc45532
IsValidationOnly     : False
Justification        : Activate assignment
Principal            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId          : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleDefinition       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId     : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
ScheduleInfo         : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
Status               : Provisioned
TargetSchedule       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleAssignmentSchedule
TargetScheduleId     : 76dd76bb-900f-470b-9bcc-1eb68bc45532
TicketInfo           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphTicketInfo
AdditionalProperties : {}
```

This example gets all the active role assignment requests for the specified user.
