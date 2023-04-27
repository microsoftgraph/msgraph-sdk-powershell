---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/get-mgrolemanagementdirectoryroleassignmentscheduleinstance
schema: 2.0.0
---

# Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstance

## SYNOPSIS
Get roleAssignmentScheduleInstances from roleManagement

## SYNTAX

### List (Default)
```
Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstance [-ExpandProperty <String[]>] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All]
 [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstance -UnifiedRoleAssignmentScheduleInstanceId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstance -InputObject <IDeviceManagementEnrolmentIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get roleAssignmentScheduleInstances from roleManagement

## EXAMPLES

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

## PARAMETERS

### -All
List all pages.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: System.String
Parameter Sets: List
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementEnrolmentIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnifiedRoleAssignmentScheduleInstanceId
The unique identifier of unifiedRoleAssignmentScheduleInstance

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDeviceManagementEnrolmentIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleAssignmentScheduleInstance1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDeviceManagementEnrolmentIdentity>: Identity Parameter
  - `[AndroidDeviceOwnerEnrollmentProfileId <String>]`: The unique identifier of androidDeviceOwnerEnrollmentProfile
  - `[AndroidForWorkEnrollmentProfileId <String>]`: The unique identifier of androidForWorkEnrollmentProfile
  - `[AppScopeId <String>]`: The unique identifier of appScope
  - `[AppleEnrollmentProfileAssignmentId <String>]`: The unique identifier of appleEnrollmentProfileAssignment
  - `[AppleUserInitiatedEnrollmentProfileId <String>]`: The unique identifier of appleUserInitiatedEnrollmentProfile
  - `[ApprovalId <String>]`: The unique identifier of approval
  - `[ApprovalStepId <String>]`: The unique identifier of approvalStep
  - `[DepOnboardingSettingId <String>]`: The unique identifier of depOnboardingSetting
  - `[DeviceEnrollmentConfigurationId <String>]`: The unique identifier of deviceEnrollmentConfiguration
  - `[DeviceManagementAutopilotEventId <String>]`: The unique identifier of deviceManagementAutopilotEvent
  - `[DeviceManagementAutopilotPolicyStatusDetailId <String>]`: The unique identifier of deviceManagementAutopilotPolicyStatusDetail
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EnrollmentConfigurationAssignmentId <String>]`: The unique identifier of enrollmentConfigurationAssignment
  - `[EnrollmentProfileId <String>]`: The unique identifier of enrollmentProfile
  - `[ImportedAppleDeviceIdentityId <String>]`: The unique identifier of importedAppleDeviceIdentity
  - `[ImportedDeviceIdentityId <String>]`: The unique identifier of importedDeviceIdentity
  - `[ImportedWindowsAutopilotDeviceIdentityId <String>]`: The unique identifier of importedWindowsAutopilotDeviceIdentity
  - `[On <String>]`: Usage: on='{on}'
  - `[UnifiedRbacResourceActionId <String>]`: The unique identifier of unifiedRbacResourceAction
  - `[UnifiedRbacResourceNamespaceId <String>]`: The unique identifier of unifiedRbacResourceNamespace
  - `[UnifiedRoleAssignmentId <String>]`: The unique identifier of unifiedRoleAssignment
  - `[UnifiedRoleAssignmentMultipleId <String>]`: The unique identifier of unifiedRoleAssignmentMultiple
  - `[UnifiedRoleAssignmentScheduleId <String>]`: The unique identifier of unifiedRoleAssignmentSchedule
  - `[UnifiedRoleAssignmentScheduleInstanceId <String>]`: The unique identifier of unifiedRoleAssignmentScheduleInstance
  - `[UnifiedRoleAssignmentScheduleRequestId <String>]`: The unique identifier of unifiedRoleAssignmentScheduleRequest
  - `[UnifiedRoleDefinitionId <String>]`: The unique identifier of unifiedRoleDefinition
  - `[UnifiedRoleDefinitionId1 <String>]`: The unique identifier of unifiedRoleDefinition
  - `[UnifiedRoleEligibilityScheduleId <String>]`: The unique identifier of unifiedRoleEligibilitySchedule
  - `[UnifiedRoleEligibilityScheduleInstanceId <String>]`: The unique identifier of unifiedRoleEligibilityScheduleInstance
  - `[UnifiedRoleEligibilityScheduleRequestId <String>]`: The unique identifier of unifiedRoleEligibilityScheduleRequest
  - `[WindowsAutopilotDeploymentProfileAssignmentId <String>]`: The unique identifier of windowsAutopilotDeploymentProfileAssignment
  - `[WindowsAutopilotDeploymentProfileId <String>]`: The unique identifier of windowsAutopilotDeploymentProfile
  - `[WindowsAutopilotDeviceIdentityId <String>]`: The unique identifier of windowsAutopilotDeviceIdentity
  - `[WindowsFeatureUpdateProfileAssignmentId <String>]`: The unique identifier of windowsFeatureUpdateProfileAssignment
  - `[WindowsFeatureUpdateProfileId <String>]`: The unique identifier of windowsFeatureUpdateProfile

## RELATED LINKS

