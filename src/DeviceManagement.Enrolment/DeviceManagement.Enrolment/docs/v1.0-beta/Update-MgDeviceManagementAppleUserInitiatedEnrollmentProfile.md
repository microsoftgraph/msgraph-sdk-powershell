---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/update-mgdevicemanagementappleuserinitiatedenrollmentprofile
schema: 2.0.0
---

# Update-MgDeviceManagementAppleUserInitiatedEnrollmentProfile

## SYNOPSIS
Update the navigation property appleUserInitiatedEnrollmentProfiles in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementAppleUserInitiatedEnrollmentProfile -AppleUserInitiatedEnrollmentProfileId <String>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphAppleEnrollmentProfileAssignment[]>]
 [-AvailableEnrollmentTypeOptions <IMicrosoftGraphAppleOwnerTypeEnrollmentType[]>]
 [-CreatedDateTime <DateTime>] [-DefaultEnrollmentType <AppleUserInitiatedEnrollmentType>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Platform <DevicePlatformType>] [-Priority <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementAppleUserInitiatedEnrollmentProfile -AppleUserInitiatedEnrollmentProfileId <String>
 -BodyParameter <IMicrosoftGraphAppleUserInitiatedEnrollmentProfile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementAppleUserInitiatedEnrollmentProfile -InputObject <IDeviceManagementEnrolmentIdentity>
 -BodyParameter <IMicrosoftGraphAppleUserInitiatedEnrollmentProfile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementAppleUserInitiatedEnrollmentProfile -InputObject <IDeviceManagementEnrolmentIdentity>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphAppleEnrollmentProfileAssignment[]>]
 [-AvailableEnrollmentTypeOptions <IMicrosoftGraphAppleOwnerTypeEnrollmentType[]>]
 [-CreatedDateTime <DateTime>] [-DefaultEnrollmentType <AppleUserInitiatedEnrollmentType>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Platform <DevicePlatformType>] [-Priority <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property appleUserInitiatedEnrollmentProfiles in deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppleUserInitiatedEnrollmentProfileId
key: id of appleUserInitiatedEnrollmentProfile

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The list of assignments for this profile.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppleEnrollmentProfileAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailableEnrollmentTypeOptions
List of available enrollment type options
To construct, please use Get-Help -Online and see NOTES section for AVAILABLEENROLLMENTTYPEOPTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppleOwnerTypeEnrollmentType[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The enrollmentProfile resource represents a collection of configurations which must be provided pre-enrollment to enable enrolling certain devices whose identities have been pre-staged.
Pre-staged device identities are assigned to this type of profile to apply the profile's configurations at enrollment of the corresponding device.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppleUserInitiatedEnrollmentProfile
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Profile creation time

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultEnrollmentType
appleUserInitiatedEnrollmentType

```yaml
Type: Microsoft.Graph.PowerShell.Support.AppleUserInitiatedEnrollmentType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description of the profile

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Name of the profile

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
Profile last modified time

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Platform
Supported platform types.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DevicePlatformType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
Priority, 0 is highest

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDeviceManagementEnrolmentIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppleUserInitiatedEnrollmentProfile

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphAppleEnrollmentProfileAssignment[]>: The list of assignments for this profile.
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

AVAILABLEENROLLMENTTYPEOPTIONS <IMicrosoftGraphAppleOwnerTypeEnrollmentType[]>: List of available enrollment type options
  - `[EnrollmentType <AppleUserInitiatedEnrollmentType?>]`: appleUserInitiatedEnrollmentType
  - `[OwnerType <ManagedDeviceOwnerType?>]`: Owner type of device.

BODYPARAMETER <IMicrosoftGraphAppleUserInitiatedEnrollmentProfile>: The enrollmentProfile resource represents a collection of configurations which must be provided pre-enrollment to enable enrolling certain devices whose identities have been pre-staged. Pre-staged device identities are assigned to this type of profile to apply the profile's configurations at enrollment of the corresponding device.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphAppleEnrollmentProfileAssignment[]>]`: The list of assignments for this profile.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[AvailableEnrollmentTypeOptions <IMicrosoftGraphAppleOwnerTypeEnrollmentType[]>]`: List of available enrollment type options
    - `[EnrollmentType <AppleUserInitiatedEnrollmentType?>]`: appleUserInitiatedEnrollmentType
    - `[OwnerType <ManagedDeviceOwnerType?>]`: Owner type of device.
  - `[CreatedDateTime <DateTime?>]`: Profile creation time
  - `[DefaultEnrollmentType <AppleUserInitiatedEnrollmentType?>]`: appleUserInitiatedEnrollmentType
  - `[Description <String>]`: Description of the profile
  - `[DisplayName <String>]`: Name of the profile
  - `[LastModifiedDateTime <DateTime?>]`: Profile last modified time
  - `[Platform <DevicePlatformType?>]`: Supported platform types.
  - `[Priority <Int32?>]`: Priority, 0 is highest

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

