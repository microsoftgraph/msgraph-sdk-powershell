---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/update-mgdevicemanagementwindowfeatureupdateprofile
schema: 2.0.0
---

# Update-MgDeviceManagementWindowFeatureUpdateProfile

## SYNOPSIS
Update the navigation property windowsFeatureUpdateProfiles in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementWindowFeatureUpdateProfile -WindowsFeatureUpdateProfileId <String>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphWindowsFeatureUpdateProfileAssignment[]>]
 [-CreatedDateTime <DateTime>] [-DeployableContentDisplayName <String>] [-Description <String>]
 [-DisplayName <String>] [-EndOfSupportDate <DateTime>] [-FeatureUpdateVersion <String>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-RolloutSettings <IMicrosoftGraphWindowsUpdateRolloutSettings>] [-PassThru] [-Confirm] [-WhatIf]
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
 [-DisplayName <String>] [-EndOfSupportDate <DateTime>] [-FeatureUpdateVersion <String>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-RolloutSettings <IMicrosoftGraphWindowsUpdateRolloutSettings>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property windowsFeatureUpdateProfiles in deviceManagement

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
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

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

### -RolloutSettings
A complex type to store the windows update rollout settings including offer start date time, offer end date time, and days between each set of offers.
To construct, please use Get-Help -Online and see NOTES section for ROLLOUTSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdateRolloutSettings
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
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

BODYPARAMETER <IMicrosoftGraphWindowsFeatureUpdateProfile>: Windows Feature Update Profile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphWindowsFeatureUpdateProfileAssignment[]>]`: The list of group assignments of the profile.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CreatedDateTime <DateTime?>]`: The date time that the profile was created.
  - `[DeployableContentDisplayName <String>]`: Friendly display name of the quality update profile deployable content
  - `[Description <String>]`: The description of the profile which is specified by the user.
  - `[DisplayName <String>]`: The display name of the profile.
  - `[EndOfSupportDate <DateTime?>]`: The last supported date for a feature update
  - `[FeatureUpdateVersion <String>]`: The feature update version that will be deployed to the devices targeted by this profile. The version could be any supported version for example 1709, 1803 or 1809 and so on.
  - `[LastModifiedDateTime <DateTime?>]`: The date time that the profile was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Feature Update entity.
  - `[RolloutSettings <IMicrosoftGraphWindowsUpdateRolloutSettings>]`: A complex type to store the windows update rollout settings including offer start date time, offer end date time, and days between each set of offers.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[OfferEndDateTimeInUtc <DateTime?>]`: The feature update's ending  of release date and time to be set, update, and displayed for a feature Update profile for example: 2020-06-09T10:00:00Z.
    - `[OfferIntervalInDays <Int32?>]`: The number of day(s) between each set of offers to be set, updated, and displayed for a feature update profile, for example: if OfferStartDateTimeInUTC is 2020-06-09T10:00:00Z, and OfferIntervalInDays is 1, then the next two sets of offers will be made consecutively on 2020-06-10T10:00:00Z (next day at the same specified time) and 2020-06-11T10:00:00Z (next next day at the same specified time) with 1 day in between each set of offers.
    - `[OfferStartDateTimeInUtc <DateTime?>]`: The feature update's starting date and time to be set, update, and displayed for a feature Update profile for example: 2020-06-09T10:00:00Z.

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

ROLLOUTSETTINGS <IMicrosoftGraphWindowsUpdateRolloutSettings>: A complex type to store the windows update rollout settings including offer start date time, offer end date time, and days between each set of offers.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[OfferEndDateTimeInUtc <DateTime?>]`: The feature update's ending  of release date and time to be set, update, and displayed for a feature Update profile for example: 2020-06-09T10:00:00Z.
  - `[OfferIntervalInDays <Int32?>]`: The number of day(s) between each set of offers to be set, updated, and displayed for a feature update profile, for example: if OfferStartDateTimeInUTC is 2020-06-09T10:00:00Z, and OfferIntervalInDays is 1, then the next two sets of offers will be made consecutively on 2020-06-10T10:00:00Z (next day at the same specified time) and 2020-06-11T10:00:00Z (next next day at the same specified time) with 1 day in between each set of offers.
  - `[OfferStartDateTimeInUtc <DateTime?>]`: The feature update's starting date and time to be set, update, and displayed for a feature Update profile for example: 2020-06-09T10:00:00Z.

## RELATED LINKS

