### Example 1: Get all role assignment schedule instances

```powershell
Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstance | Format-List

ActivatedUsing           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleEligibilityScheduleInstance
AppScope                 : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId               :
AssignmentType           : Assigned
DirectoryScope           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId         : /
EndDateTime              :
Id                       : 4-PYiFWPHkqVOpuYmLiHa_CWtrDUYhRNsQq0vuB-N3E-1
MemberType               : Direct
Principal                : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId              : b0b696f0-62d4-4d14-b10a-b4bee07e3771
RoleAssignmentOriginId   : 4-PYiFWPHkqVOpuYmLiHa_CWtrDUYhRNsQq0vuB-N3E-1
RoleAssignmentScheduleId : 4-PYiFWPHkqVOpuYmLiHa_CWtrDUYhRNsQq0vuB-N3E-1
RoleDefinition           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId         : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
StartDateTime            :
AdditionalProperties     : {}

ActivatedUsing           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleEligibilityScheduleInstance
AppScope                 : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId               :
AssignmentType           : Activated
DirectoryScope           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId         : /
EndDateTime              : 5/13/2022 11:14:32 AM
Id                       : 4-PYiFWPHkqVOpuYmLiHaw9ZQmzw_CJJusYgX3xqqJw-1
MemberType               : Direct
Principal                : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId              : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleAssignmentOriginId   : 4-PYiFWPHkqVOpuYmLiHaw9ZQmzw_CJJusYgX3xqqJw-1
RoleAssignmentScheduleId : 76dd76bb-900f-470b-9bcc-1eb68bc45532
RoleDefinition           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId         : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
StartDateTime            : 5/13/2022 8:14:33 AM
AdditionalProperties     : {}

ActivatedUsing           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleEligibilityScheduleInstance
AppScope                 : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId               :
AssignmentType           : Assigned
DirectoryScope           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId         : /
EndDateTime              :
Id                       : lAPpYvVpN0KRkAEhdxReEENupG7coEFEgfvZ4yNW5ic-1
MemberType               : Direct
Principal                : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId              : 6ea46e43-a0dc-4441-81fb-d9e32356e627
RoleAssignmentOriginId   : lAPpYvVpN0KRkAEhdxReEENupG7coEFEgfvZ4yNW5ic-1
RoleAssignmentScheduleId : lAPpYvVpN0KRkAEhdxReEENupG7coEFEgfvZ4yNW5ic-1
RoleDefinition           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId         : 62e90394-69f5-4237-9190-012177145e10
StartDateTime            :
AdditionalProperties     : {}
```

This examples get all created active role assignments.

### Example 2: Get all role assignment schedule instances for a user

```powershell
Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstance -Filter "principalId eq '6c42590f-fcf0-4922-bac6-205f7c6aa89c'" | Format-List

ActivatedUsing           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleEligibilityScheduleInstance
AppScope                 : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId               :
AssignmentType           : Activated
DirectoryScope           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId         : /
EndDateTime              : 5/13/2022 11:14:32 AM
Id                       : 4-PYiFWPHkqVOpuYmLiHaw9ZQmzw_CJJusYgX3xqqJw-1
MemberType               : Direct
Principal                : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId              : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleAssignmentOriginId   : 4-PYiFWPHkqVOpuYmLiHaw9ZQmzw_CJJusYgX3xqqJw-1
RoleAssignmentScheduleId : 76dd76bb-900f-470b-9bcc-1eb68bc45532
RoleDefinition           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId         : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
StartDateTime            : 5/13/2022 8:14:33 AM
AdditionalProperties     : {}
```

This examples get all created active role assignments for the specified user.
