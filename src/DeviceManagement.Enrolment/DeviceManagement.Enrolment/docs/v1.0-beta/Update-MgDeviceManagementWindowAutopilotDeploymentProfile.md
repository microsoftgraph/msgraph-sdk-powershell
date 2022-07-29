---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/update-mgdevicemanagementwindowautopilotdeploymentprofile
schema: 2.0.0
---

# Update-MgDeviceManagementWindowAutopilotDeploymentProfile

## SYNOPSIS
Update the navigation property windowsAutopilotDeploymentProfiles in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementWindowAutopilotDeploymentProfile -WindowsAutopilotDeploymentProfileId <String>
 [-AdditionalProperties <Hashtable>] [-AssignedDevices <IMicrosoftGraphWindowsAutopilotDeviceIdentity[]>]
 [-Assignments <IMicrosoftGraphWindowsAutopilotDeploymentProfileAssignment[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DeviceNameTemplate <String>] [-DeviceType <WindowsAutopilotDeviceType>]
 [-DisplayName <String>] [-EnableWhiteGlove]
 [-EnrollmentStatusScreenSettings <IMicrosoftGraphWindowsEnrollmentStatusScreenSettings>]
 [-ExtractHardwareHash] [-Id <String>] [-Language <String>] [-LastModifiedDateTime <DateTime>]
 [-ManagementServiceAppId <String>] [-OutOfBoxExperienceSettings <IMicrosoftGraphOutOfBoxExperienceSettings>]
 [-RoleScopeTagIds <String[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementWindowAutopilotDeploymentProfile -WindowsAutopilotDeploymentProfileId <String>
 -BodyParameter <IMicrosoftGraphWindowsAutopilotDeploymentProfile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementWindowAutopilotDeploymentProfile -InputObject <IDeviceManagementEnrolmentIdentity>
 -BodyParameter <IMicrosoftGraphWindowsAutopilotDeploymentProfile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementWindowAutopilotDeploymentProfile -InputObject <IDeviceManagementEnrolmentIdentity>
 [-AdditionalProperties <Hashtable>] [-AssignedDevices <IMicrosoftGraphWindowsAutopilotDeviceIdentity[]>]
 [-Assignments <IMicrosoftGraphWindowsAutopilotDeploymentProfileAssignment[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DeviceNameTemplate <String>] [-DeviceType <WindowsAutopilotDeviceType>]
 [-DisplayName <String>] [-EnableWhiteGlove]
 [-EnrollmentStatusScreenSettings <IMicrosoftGraphWindowsEnrollmentStatusScreenSettings>]
 [-ExtractHardwareHash] [-Id <String>] [-Language <String>] [-LastModifiedDateTime <DateTime>]
 [-ManagementServiceAppId <String>] [-OutOfBoxExperienceSettings <IMicrosoftGraphOutOfBoxExperienceSettings>]
 [-RoleScopeTagIds <String[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property windowsAutopilotDeploymentProfiles in deviceManagement

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

### -AssignedDevices
The list of assigned devices for the profile.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNEDDEVICES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeviceIdentity[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The list of group assignments for the profile.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeploymentProfileAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Windows Autopilot Deployment Profile
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeploymentProfile
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

### -DeviceNameTemplate
The template used to name the AutoPilot Device.
This can be a custom text and can also contain either the serial number of the device, or a randomly generated number.
The total length of the text generated by the template can be no more than 15 characters.

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

### -DeviceType
windowsAutopilotDeviceType

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsAutopilotDeviceType
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

### -EnableWhiteGlove
Enable Autopilot White Glove for the profile.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentStatusScreenSettings
Enrollment status screen setting
To construct, please use Get-Help -Online and see NOTES section for ENROLLMENTSTATUSSCREENSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsEnrollmentStatusScreenSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExtractHardwareHash
HardwareHash Extraction for the profile

```yaml
Type: System.Management.Automation.SwitchParameter
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

### -Language
Language configured on the device

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

### -ManagementServiceAppId
AzureAD management app ID used during client device-based enrollment discovery

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

### -OutOfBoxExperienceSettings
Out of box experience setting
To construct, please use Get-Help -Online and see NOTES section for OUTOFBOXEXPERIENCESETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOutOfBoxExperienceSettings
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
Scope tags for the profile.

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

### -WindowsAutopilotDeploymentProfileId
key: id of windowsAutopilotDeploymentProfile

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeploymentProfile

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNEDDEVICES <IMicrosoftGraphWindowsAutopilotDeviceIdentity[]>: The list of assigned devices for the profile.
  - `[Id <String>]`: 
  - `[AddressableUserName <String>]`: Addressable user name.
  - `[AzureActiveDirectoryDeviceId <String>]`: AAD Device ID - to be deprecated
  - `[AzureAdDeviceId <String>]`: AAD Device ID
  - `[DeploymentProfile <IMicrosoftGraphWindowsAutopilotDeploymentProfile>]`: Windows Autopilot Deployment Profile
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[AssignedDevices <IMicrosoftGraphWindowsAutopilotDeviceIdentity[]>]`: The list of assigned devices for the profile.
    - `[Assignments <IMicrosoftGraphWindowsAutopilotDeploymentProfileAssignment[]>]`: The list of group assignments for the profile.
      - `[Id <String>]`: 
      - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
      - `[SourceId <String>]`: Identifier for resource used for deployment to a group
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
    - `[CreatedDateTime <DateTime?>]`: Profile creation time
    - `[Description <String>]`: Description of the profile
    - `[DeviceNameTemplate <String>]`: The template used to name the AutoPilot Device. This can be a custom text and can also contain either the serial number of the device, or a randomly generated number. The total length of the text generated by the template can be no more than 15 characters.
    - `[DeviceType <WindowsAutopilotDeviceType?>]`: windowsAutopilotDeviceType
    - `[DisplayName <String>]`: Name of the profile
    - `[EnableWhiteGlove <Boolean?>]`: Enable Autopilot White Glove for the profile.
    - `[EnrollmentStatusScreenSettings <IMicrosoftGraphWindowsEnrollmentStatusScreenSettings>]`: Enrollment status screen setting
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowDeviceUseBeforeProfileAndAppInstallComplete <Boolean?>]`: Allow or block user to use device before profile and app installation complete
      - `[AllowDeviceUseOnInstallFailure <Boolean?>]`: Allow the user to continue using the device on installation failure
      - `[AllowLogCollectionOnInstallFailure <Boolean?>]`: Allow or block log collection on installation failure
      - `[BlockDeviceSetupRetryByUser <Boolean?>]`: Allow the user to retry the setup on installation failure
      - `[CustomErrorMessage <String>]`: Set custom error message to show upon installation failure
      - `[HideInstallationProgress <Boolean?>]`: Show or hide installation progress to user
      - `[InstallProgressTimeoutInMinutes <Int32?>]`: Set installation progress timeout in minutes
    - `[ExtractHardwareHash <Boolean?>]`: HardwareHash Extraction for the profile
    - `[Language <String>]`: Language configured on the device
    - `[LastModifiedDateTime <DateTime?>]`: Profile last modified time
    - `[ManagementServiceAppId <String>]`: AzureAD management app ID used during client device-based enrollment discovery
    - `[OutOfBoxExperienceSettings <IMicrosoftGraphOutOfBoxExperienceSettings>]`: Out of box experience setting
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceUsageType <WindowsDeviceUsageType?>]`: windowsDeviceUsageType
      - `[HideEscapeLink <Boolean?>]`: If set to true, then the user can't start over with different account, on company sign-in
      - `[HideEula <Boolean?>]`: Show or hide EULA to user
      - `[HidePrivacySettings <Boolean?>]`: Show or hide privacy settings to user
      - `[SkipKeyboardSelectionPage <Boolean?>]`: If set, then skip the keyboard selection page if Language and Region are set
      - `[UserType <String>]`: windowsUserType
    - `[RoleScopeTagIds <String[]>]`: Scope tags for the profile.
  - `[DeploymentProfileAssignedDateTime <DateTime?>]`: Profile set time of the Windows autopilot device.
  - `[DeploymentProfileAssignmentDetailedStatus <WindowsAutopilotProfileAssignmentDetailedStatus?>]`: windowsAutopilotProfileAssignmentDetailedStatus
  - `[DeploymentProfileAssignmentStatus <WindowsAutopilotProfileAssignmentStatus?>]`: windowsAutopilotProfileAssignmentStatus
  - `[DeviceAccountPassword <String>]`: Surface Hub Device Account Password
  - `[DeviceAccountUpn <String>]`: Surface Hub Device Account Upn
  - `[DeviceFriendlyName <String>]`: Surface Hub Device Friendly Name
  - `[DisplayName <String>]`: Display Name
  - `[EnrollmentState <EnrollmentState?>]`: 
  - `[GroupTag <String>]`: Group Tag of the Windows autopilot device.
  - `[IntendedDeploymentProfile <IMicrosoftGraphWindowsAutopilotDeploymentProfile>]`: Windows Autopilot Deployment Profile
  - `[LastContactedDateTime <DateTime?>]`: Intune Last Contacted Date Time of the Windows autopilot device.
  - `[ManagedDeviceId <String>]`: Managed Device ID
  - `[Manufacturer <String>]`: Oem manufacturer of the Windows autopilot device.
  - `[Model <String>]`: Model name of the Windows autopilot device.
  - `[ProductKey <String>]`: Product Key of the Windows autopilot device.
  - `[PurchaseOrderIdentifier <String>]`: Purchase Order Identifier of the Windows autopilot device.
  - `[RemediationState <WindowsAutopilotDeviceRemediationState?>]`: Device remediation status, indicating whether or not hardware has been changed for an Autopilot-registered device.
  - `[RemediationStateLastModifiedDateTime <DateTime?>]`: RemediationState set time of Autopilot device.
  - `[ResourceName <String>]`: Resource Name.
  - `[SerialNumber <String>]`: Serial number of the Windows autopilot device.
  - `[SkuNumber <String>]`: SKU Number
  - `[SystemFamily <String>]`: System Family
  - `[UserPrincipalName <String>]`: User Principal Name.

ASSIGNMENTS <IMicrosoftGraphWindowsAutopilotDeploymentProfileAssignment[]>: The list of group assignments for the profile.
  - `[Id <String>]`: 
  - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
  - `[SourceId <String>]`: Identifier for resource used for deployment to a group
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

BODYPARAMETER <IMicrosoftGraphWindowsAutopilotDeploymentProfile>: Windows Autopilot Deployment Profile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AssignedDevices <IMicrosoftGraphWindowsAutopilotDeviceIdentity[]>]`: The list of assigned devices for the profile.
    - `[Id <String>]`: 
    - `[AddressableUserName <String>]`: Addressable user name.
    - `[AzureActiveDirectoryDeviceId <String>]`: AAD Device ID - to be deprecated
    - `[AzureAdDeviceId <String>]`: AAD Device ID
    - `[DeploymentProfile <IMicrosoftGraphWindowsAutopilotDeploymentProfile>]`: Windows Autopilot Deployment Profile
    - `[DeploymentProfileAssignedDateTime <DateTime?>]`: Profile set time of the Windows autopilot device.
    - `[DeploymentProfileAssignmentDetailedStatus <WindowsAutopilotProfileAssignmentDetailedStatus?>]`: windowsAutopilotProfileAssignmentDetailedStatus
    - `[DeploymentProfileAssignmentStatus <WindowsAutopilotProfileAssignmentStatus?>]`: windowsAutopilotProfileAssignmentStatus
    - `[DeviceAccountPassword <String>]`: Surface Hub Device Account Password
    - `[DeviceAccountUpn <String>]`: Surface Hub Device Account Upn
    - `[DeviceFriendlyName <String>]`: Surface Hub Device Friendly Name
    - `[DisplayName <String>]`: Display Name
    - `[EnrollmentState <EnrollmentState?>]`: 
    - `[GroupTag <String>]`: Group Tag of the Windows autopilot device.
    - `[IntendedDeploymentProfile <IMicrosoftGraphWindowsAutopilotDeploymentProfile>]`: Windows Autopilot Deployment Profile
    - `[LastContactedDateTime <DateTime?>]`: Intune Last Contacted Date Time of the Windows autopilot device.
    - `[ManagedDeviceId <String>]`: Managed Device ID
    - `[Manufacturer <String>]`: Oem manufacturer of the Windows autopilot device.
    - `[Model <String>]`: Model name of the Windows autopilot device.
    - `[ProductKey <String>]`: Product Key of the Windows autopilot device.
    - `[PurchaseOrderIdentifier <String>]`: Purchase Order Identifier of the Windows autopilot device.
    - `[RemediationState <WindowsAutopilotDeviceRemediationState?>]`: Device remediation status, indicating whether or not hardware has been changed for an Autopilot-registered device.
    - `[RemediationStateLastModifiedDateTime <DateTime?>]`: RemediationState set time of Autopilot device.
    - `[ResourceName <String>]`: Resource Name.
    - `[SerialNumber <String>]`: Serial number of the Windows autopilot device.
    - `[SkuNumber <String>]`: SKU Number
    - `[SystemFamily <String>]`: System Family
    - `[UserPrincipalName <String>]`: User Principal Name.
  - `[Assignments <IMicrosoftGraphWindowsAutopilotDeploymentProfileAssignment[]>]`: The list of group assignments for the profile.
    - `[Id <String>]`: 
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CreatedDateTime <DateTime?>]`: Profile creation time
  - `[Description <String>]`: Description of the profile
  - `[DeviceNameTemplate <String>]`: The template used to name the AutoPilot Device. This can be a custom text and can also contain either the serial number of the device, or a randomly generated number. The total length of the text generated by the template can be no more than 15 characters.
  - `[DeviceType <WindowsAutopilotDeviceType?>]`: windowsAutopilotDeviceType
  - `[DisplayName <String>]`: Name of the profile
  - `[EnableWhiteGlove <Boolean?>]`: Enable Autopilot White Glove for the profile.
  - `[EnrollmentStatusScreenSettings <IMicrosoftGraphWindowsEnrollmentStatusScreenSettings>]`: Enrollment status screen setting
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowDeviceUseBeforeProfileAndAppInstallComplete <Boolean?>]`: Allow or block user to use device before profile and app installation complete
    - `[AllowDeviceUseOnInstallFailure <Boolean?>]`: Allow the user to continue using the device on installation failure
    - `[AllowLogCollectionOnInstallFailure <Boolean?>]`: Allow or block log collection on installation failure
    - `[BlockDeviceSetupRetryByUser <Boolean?>]`: Allow the user to retry the setup on installation failure
    - `[CustomErrorMessage <String>]`: Set custom error message to show upon installation failure
    - `[HideInstallationProgress <Boolean?>]`: Show or hide installation progress to user
    - `[InstallProgressTimeoutInMinutes <Int32?>]`: Set installation progress timeout in minutes
  - `[ExtractHardwareHash <Boolean?>]`: HardwareHash Extraction for the profile
  - `[Language <String>]`: Language configured on the device
  - `[LastModifiedDateTime <DateTime?>]`: Profile last modified time
  - `[ManagementServiceAppId <String>]`: AzureAD management app ID used during client device-based enrollment discovery
  - `[OutOfBoxExperienceSettings <IMicrosoftGraphOutOfBoxExperienceSettings>]`: Out of box experience setting
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceUsageType <WindowsDeviceUsageType?>]`: windowsDeviceUsageType
    - `[HideEscapeLink <Boolean?>]`: If set to true, then the user can't start over with different account, on company sign-in
    - `[HideEula <Boolean?>]`: Show or hide EULA to user
    - `[HidePrivacySettings <Boolean?>]`: Show or hide privacy settings to user
    - `[SkipKeyboardSelectionPage <Boolean?>]`: If set, then skip the keyboard selection page if Language and Region are set
    - `[UserType <String>]`: windowsUserType
  - `[RoleScopeTagIds <String[]>]`: Scope tags for the profile.

ENROLLMENTSTATUSSCREENSETTINGS <IMicrosoftGraphWindowsEnrollmentStatusScreenSettings>: Enrollment status screen setting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowDeviceUseBeforeProfileAndAppInstallComplete <Boolean?>]`: Allow or block user to use device before profile and app installation complete
  - `[AllowDeviceUseOnInstallFailure <Boolean?>]`: Allow the user to continue using the device on installation failure
  - `[AllowLogCollectionOnInstallFailure <Boolean?>]`: Allow or block log collection on installation failure
  - `[BlockDeviceSetupRetryByUser <Boolean?>]`: Allow the user to retry the setup on installation failure
  - `[CustomErrorMessage <String>]`: Set custom error message to show upon installation failure
  - `[HideInstallationProgress <Boolean?>]`: Show or hide installation progress to user
  - `[InstallProgressTimeoutInMinutes <Int32?>]`: Set installation progress timeout in minutes

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

OUTOFBOXEXPERIENCESETTINGS <IMicrosoftGraphOutOfBoxExperienceSettings>: Out of box experience setting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceUsageType <WindowsDeviceUsageType?>]`: windowsDeviceUsageType
  - `[HideEscapeLink <Boolean?>]`: If set to true, then the user can't start over with different account, on company sign-in
  - `[HideEula <Boolean?>]`: Show or hide EULA to user
  - `[HidePrivacySettings <Boolean?>]`: Show or hide privacy settings to user
  - `[SkipKeyboardSelectionPage <Boolean?>]`: If set, then skip the keyboard selection page if Language and Region are set
  - `[UserType <String>]`: windowsUserType

## RELATED LINKS

