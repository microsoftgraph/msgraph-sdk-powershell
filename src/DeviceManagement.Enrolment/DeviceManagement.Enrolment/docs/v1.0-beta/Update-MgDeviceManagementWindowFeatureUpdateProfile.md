---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/update-mgdevicemanagementwindowfeatureupdateprofile
schema: 2.0.0
---

# Update-MgDeviceManagementWindowFeatureUpdateProfile

## SYNOPSIS
A collection of windows feature update profiles

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementWindowFeatureUpdateProfile -WindowsFeatureUpdateProfileId <String>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphWindowsFeatureUpdateProfileAssignment[]>]
 [-CreatedDateTime <DateTime>] [-DeployableContentDisplayName <String>] [-Description <String>]
 [-DeviceUpdateStates <IMicrosoftGraphWindowsUpdateState[]>] [-DisplayName <String>]
 [-EndOfSupportDate <DateTime>] [-FeatureUpdateVersion <String>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementWindowFeatureUpdateProfile -WindowsFeatureUpdateProfileId <String>
 -BodyParameter <IMicrosoftGraphWindowsFeatureUpdateProfile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementWindowFeatureUpdateProfile -InputObject <IDeviceManagementEnrolmentIdentity>
 -BodyParameter <IMicrosoftGraphWindowsFeatureUpdateProfile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementWindowFeatureUpdateProfile -InputObject <IDeviceManagementEnrolmentIdentity>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphWindowsFeatureUpdateProfileAssignment[]>]
 [-CreatedDateTime <DateTime>] [-DeployableContentDisplayName <String>] [-Description <String>]
 [-DeviceUpdateStates <IMicrosoftGraphWindowsUpdateState[]>] [-DisplayName <String>]
 [-EndOfSupportDate <DateTime>] [-FeatureUpdateVersion <String>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
A collection of windows feature update profiles

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

### -Assignments
The list of group assignments of the profile.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsFeatureUpdateProfileAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Windows Feature Update Profile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsFeatureUpdateProfile
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date time that the profile was created.

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

### -DeployableContentDisplayName
Friendly display name of the quality update profile deployable content

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

### -Description
The description of the profile which is specified by the user.

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

### -DeviceUpdateStates
The list of device states this profile targeted to
To construct, see NOTES section for DEVICEUPDATESTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdateState[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name of the profile.

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

### -EndOfSupportDate
The last supported date for a feature update

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

### -FeatureUpdateVersion
The feature update version that will be deployed to the devices targeted by this profile.
The version could be any supported version for example 1709, 1803 or 1809 and so on.

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
Read-only.

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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
The date time that the profile was last modified.

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

### -RoleScopeTagIds
List of Scope Tags for this Feature Update entity.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowsFeatureUpdateProfileId
key: id of windowsFeatureUpdateProfile

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsFeatureUpdateProfile

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphWindowsFeatureUpdateProfileAssignment[]>: The list of group assignments of the profile.
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType

BODYPARAMETER <IMicrosoftGraphWindowsFeatureUpdateProfile>: Windows Feature Update Profile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphWindowsFeatureUpdateProfileAssignment[]>]`: The list of group assignments of the profile.
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType
  - `[CreatedDateTime <DateTime?>]`: The date time that the profile was created.
  - `[DeployableContentDisplayName <String>]`: Friendly display name of the quality update profile deployable content
  - `[Description <String>]`: The description of the profile which is specified by the user.
  - `[DeviceUpdateStates <IMicrosoftGraphWindowsUpdateState[]>]`: The list of device states this profile targeted to
    - `[Id <String>]`: Read-only.
    - `[DeviceDisplayName <String>]`: Device display name.
    - `[DeviceId <String>]`: The id of the device.
    - `[FeatureUpdateVersion <String>]`: The current feature update version of the device.
    - `[LastScanDateTime <DateTime?>]`: The date time that the Windows Update Agent did a successful scan.
    - `[LastSyncDateTime <DateTime?>]`: Last date time that the device sync with with Microsoft Intune.
    - `[QualityUpdateVersion <String>]`: The Quality Update Version of the device.
    - `[Status <String>]`: windowsUpdateStatus
    - `[UserId <String>]`: The id of the user.
    - `[UserPrincipalName <String>]`: User principal name.
  - `[DisplayName <String>]`: The display name of the profile.
  - `[EndOfSupportDate <DateTime?>]`: The last supported date for a feature update
  - `[FeatureUpdateVersion <String>]`: The feature update version that will be deployed to the devices targeted by this profile. The version could be any supported version for example 1709, 1803 or 1809 and so on.
  - `[LastModifiedDateTime <DateTime?>]`: The date time that the profile was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Feature Update entity.

DEVICEUPDATESTATES <IMicrosoftGraphWindowsUpdateState[]>: The list of device states this profile targeted to
  - `[Id <String>]`: Read-only.
  - `[DeviceDisplayName <String>]`: Device display name.
  - `[DeviceId <String>]`: The id of the device.
  - `[FeatureUpdateVersion <String>]`: The current feature update version of the device.
  - `[LastScanDateTime <DateTime?>]`: The date time that the Windows Update Agent did a successful scan.
  - `[LastSyncDateTime <DateTime?>]`: Last date time that the device sync with with Microsoft Intune.
  - `[QualityUpdateVersion <String>]`: The Quality Update Version of the device.
  - `[Status <String>]`: windowsUpdateStatus
  - `[UserId <String>]`: The id of the user.
  - `[UserPrincipalName <String>]`: User principal name.

INPUTOBJECT <IDeviceManagementEnrolmentIdentity>: Identity Parameter
  - `[AndroidDeviceOwnerEnrollmentProfileId <String>]`: key: id of androidDeviceOwnerEnrollmentProfile
  - `[AndroidForWorkEnrollmentProfileId <String>]`: key: id of androidForWorkEnrollmentProfile
  - `[AppScopeId <String>]`: key: id of appScope
  - `[AppScopeId1 <String>]`: Usage: appScopeId={appScopeId}
  - `[AppleEnrollmentProfileAssignmentId <String>]`: key: id of appleEnrollmentProfileAssignment
  - `[AppleUserInitiatedEnrollmentProfileId <String>]`: key: id of appleUserInitiatedEnrollmentProfile
  - `[ApprovalId <String>]`: key: id of approval
  - `[ApprovalStepId <String>]`: key: id of approvalStep
  - `[DepOnboardingSettingId <String>]`: key: id of depOnboardingSetting
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceManagementAutopilotEventId <String>]`: key: id of deviceManagementAutopilotEvent
  - `[DeviceManagementAutopilotPolicyStatusDetailId <String>]`: key: id of deviceManagementAutopilotPolicyStatusDetail
  - `[DirectoryScopeId <String>]`: Usage: directoryScopeId={directoryScopeId}
  - `[EnrollmentConfigurationAssignmentId <String>]`: key: id of enrollmentConfigurationAssignment
  - `[EnrollmentProfileId <String>]`: key: id of enrollmentProfile
  - `[ImportedAppleDeviceIdentityId <String>]`: key: id of importedAppleDeviceIdentity
  - `[ImportedDeviceIdentityId <String>]`: key: id of importedDeviceIdentity
  - `[ImportedWindowsAutopilotDeviceIdentityId <String>]`: key: id of importedWindowsAutopilotDeviceIdentity
  - `[On <String>]`: Usage: on={on}
  - `[PrincipalId <String>]`: Usage: principalId={principalId}
  - `[RoleDefinitionId <String>]`: Usage: roleDefinitionId={roleDefinitionId}
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
  - `[WindowsUpdateStateId <String>]`: key: id of windowsUpdateState

## RELATED LINKS

