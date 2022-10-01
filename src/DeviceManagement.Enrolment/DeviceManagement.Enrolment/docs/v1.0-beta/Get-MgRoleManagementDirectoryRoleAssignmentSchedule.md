---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/get-mgrolemanagementdirectoryroleassignmentschedule
schema: 2.0.0
---

# Get-MgRoleManagementDirectoryRoleAssignmentSchedule

## SYNOPSIS
Get roleAssignmentSchedules from roleManagement

## SYNTAX

### List (Default)
```
Get-MgRoleManagementDirectoryRoleAssignmentSchedule [-ExpandProperty <String[]>] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All]
 [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgRoleManagementDirectoryRoleAssignmentSchedule -UnifiedRoleAssignmentScheduleId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgRoleManagementDirectoryRoleAssignmentSchedule -InputObject <IDeviceManagementEnrolmentIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get roleAssignmentSchedules from roleManagement

## EXAMPLES

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

This example gets all active role assignment schedules.
This includes active roles assignments that have been created and the future scheduled assignments.

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

### -UnifiedRoleAssignmentScheduleId
key: id of unifiedRoleAssignmentSchedule

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleAssignmentSchedule1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDeviceManagementEnrolmentIdentity>: Identity Parameter
  - `[AndroidDeviceOwnerEnrollmentProfileId <String>]`: key: id of androidDeviceOwnerEnrollmentProfile
  - `[AndroidForWorkEnrollmentProfileId <String>]`: key: id of androidForWorkEnrollmentProfile
  - `[AppScopeId <String>]`: key: id of appScope
  - `[AppleEnrollmentProfileAssignmentId <String>]`: key: id of appleEnrollmentProfileAssignment
  - `[AppleUserInitiatedEnrollmentProfileId <String>]`: key: id of appleUserInitiatedEnrollmentProfile
  - `[ApprovalId <String>]`: key: id of approval
  - `[ApprovalStepId <String>]`: key: id of approvalStep
  - `[DepOnboardingSettingId <String>]`: key: id of depOnboardingSetting
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceManagementAutopilotEventId <String>]`: key: id of deviceManagementAutopilotEvent
  - `[DeviceManagementAutopilotPolicyStatusDetailId <String>]`: key: id of deviceManagementAutopilotPolicyStatusDetail
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EnrollmentConfigurationAssignmentId <String>]`: key: id of enrollmentConfigurationAssignment
  - `[EnrollmentProfileId <String>]`: key: id of enrollmentProfile
  - `[ImportedAppleDeviceIdentityId <String>]`: key: id of importedAppleDeviceIdentity
  - `[ImportedDeviceIdentityId <String>]`: key: id of importedDeviceIdentity
  - `[ImportedWindowsAutopilotDeviceIdentityId <String>]`: key: id of importedWindowsAutopilotDeviceIdentity
  - `[On <String>]`: Usage: on='{on}'
  - `[UnifiedRbacResourceActionId <String>]`: key: id of unifiedRbacResourceAction
  - `[UnifiedRbacResourceNamespaceId <String>]`: key: id of unifiedRbacResourceNamespace
  - `[UnifiedRoleAssignmentId <String>]`: key: id of unifiedRoleAssignment
  - `[UnifiedRoleAssignmentMultipleId <String>]`: key: id of unifiedRoleAssignmentMultiple
  - `[UnifiedRoleAssignmentScheduleId <String>]`: key: id of unifiedRoleAssignmentSchedule
  - `[UnifiedRoleAssignmentScheduleInstanceId <String>]`: key: id of unifiedRoleAssignmentScheduleInstance
  - `[UnifiedRoleAssignmentScheduleRequestId <String>]`: key: id of unifiedRoleAssignmentScheduleRequest
  - `[UnifiedRoleDefinitionId <String>]`: key: id of unifiedRoleDefinition
  - `[UnifiedRoleDefinitionId1 <String>]`: key: id of unifiedRoleDefinition
  - `[UnifiedRoleEligibilityScheduleId <String>]`: key: id of unifiedRoleEligibilitySchedule
  - `[UnifiedRoleEligibilityScheduleInstanceId <String>]`: key: id of unifiedRoleEligibilityScheduleInstance
  - `[UnifiedRoleEligibilityScheduleRequestId <String>]`: key: id of unifiedRoleEligibilityScheduleRequest
  - `[WindowsAutopilotDeploymentProfileAssignmentId <String>]`: key: id of windowsAutopilotDeploymentProfileAssignment
  - `[WindowsAutopilotDeploymentProfileId <String>]`: key: id of windowsAutopilotDeploymentProfile
  - `[WindowsAutopilotDeviceIdentityId <String>]`: key: id of windowsAutopilotDeviceIdentity
  - `[WindowsFeatureUpdateProfileAssignmentId <String>]`: key: id of windowsFeatureUpdateProfileAssignment
  - `[WindowsFeatureUpdateProfileId <String>]`: key: id of windowsFeatureUpdateProfile

## RELATED LINKS

