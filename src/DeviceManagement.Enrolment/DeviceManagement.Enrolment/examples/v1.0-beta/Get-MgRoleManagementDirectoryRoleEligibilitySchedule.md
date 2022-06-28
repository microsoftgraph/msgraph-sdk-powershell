### Example 1: Get all eligibility schedules

```powershell
Get-MgRoleManagementDirectoryRoleEligibilitySchedule | Format-List

AppScope             : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId           :
CreatedDateTime      : 2/15/2022 3:11:22 PM
CreatedUsing         : 78222acb-04d0-4f9f-9d5e-52fb75658d32
DirectoryScope       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId     : /
Id                   : 78222acb-04d0-4f9f-9d5e-52fb75658d32
MemberType           : Direct
ModifiedDateTime     : 1/1/0001 8:00:00 AM
Principal            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId          : 50a2bbd7-302c-4572-b6b0-7c8cc0bce7b7
RoleDefinition       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId     : 9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3
ScheduleInfo         : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
Status               : Provisioned
AdditionalProperties : {}

AppScope             : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId           :
CreatedDateTime      : 5/13/2022 7:39:08 AM
CreatedUsing         : 8554c1e7-b359-41b9-802e-4beabddec142
DirectoryScope       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId     : /
Id                   : 8554c1e7-b359-41b9-802e-4beabddec142
MemberType           : Direct
ModifiedDateTime     : 1/1/0001 8:00:00 AM
Principal            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId          : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleDefinition       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId     : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
ScheduleInfo         : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
Status               : Provisioned
AdditionalProperties : {}
```

This example returns all eligible role assignment schedules. This includes eligible roles that have been created and the future scheduled assignments.

### Example 2: Get all eligibility schedules for specific user

```powershell
Get-MgRoleManagementDirectoryRoleEligibilitySchedule -Filter "principalId eq '6c42590f-fcf0-4922-bac6-205f7c6aa89c'"  | Format-List

AppScope             : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId           :
CreatedDateTime      : 5/13/2022 7:39:08 AM
CreatedUsing         : 8554c1e7-b359-41b9-802e-4beabddec142
DirectoryScope       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId     : /
Id                   : 8554c1e7-b359-41b9-802e-4beabddec142
MemberType           : Direct
ModifiedDateTime     : 1/1/0001 8:00:00 AM
Principal            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId          : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleDefinition       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId     : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
ScheduleInfo         : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
Status               : Provisioned
AdditionalProperties : {}
```

This example returns all eligible role assignment schedules for the specified user.
