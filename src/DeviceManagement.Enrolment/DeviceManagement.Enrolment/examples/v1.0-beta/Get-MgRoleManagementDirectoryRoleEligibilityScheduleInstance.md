### Example 1: Get all eligibility schedule instances

```powershell
Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstance | Format-List

AppScope                  : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId                :
DirectoryScope            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId          : /
EndDateTime               : 5/13/2022 5:39:07 PM
Id                        : 4-PYiFWPHkqVOpuYmLiHaw9ZQmzw_CJJusYgX3xqqJw-1-e
MemberType                : Direct
Principal                 : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId               : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleDefinition            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId          : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
RoleEligibilityScheduleId : 8554c1e7-b359-41b9-802e-4beabddec142
StartDateTime             : 5/13/2022 7:39:08 AM
AdditionalProperties      : {}

AppScope                  : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId                :
DirectoryScope            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId          : /
EndDateTime               : 5/16/2022 3:00:54 PM
Id                        : kl2Jm9Msx0SdAqasLV6lw9e7olAsMHJFtrB8jMC857c-1-e
MemberType                : Direct
Principal                 : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId               : 50a2bbd7-302c-4572-b6b0-7c8cc0bce7b7
RoleDefinition            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId          : 9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3
RoleEligibilityScheduleId : 78222acb-04d0-4f9f-9d5e-52fb75658d32
StartDateTime             : 2/15/2022 3:11:22 PM
AdditionalProperties      : {}
```

This examples get all created eligible role assignments.

### Example 2: Get all eligibility schedule instances for a specific user

```powershell
Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstance -Filter "principalId eq '6c42590f-fcf0-4922-bac6-205f7c6aa89c'"  | Format-List

AppScope                  : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAppScope
AppScopeId                :
DirectoryScope            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
DirectoryScopeId          : /
EndDateTime               : 5/13/2022 5:39:07 PM
Id                        : 4-PYiFWPHkqVOpuYmLiHaw9ZQmzw_CJJusYgX3xqqJw-1-e
MemberType                : Direct
Principal                 : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDirectoryObject
PrincipalId               : 6c42590f-fcf0-4922-bac6-205f7c6aa89c
RoleDefinition            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphUnifiedRoleDefinition
RoleDefinitionId          : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
RoleEligibilityScheduleId : 8554c1e7-b359-41b9-802e-4beabddec142
StartDateTime             : 5/13/2022 7:39:08 AM
AdditionalProperties      : {}
```

This example gets all the created eligible role assignments for the specified user.
