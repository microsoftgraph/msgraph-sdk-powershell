---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/new-mgdevicemanagementwindowautopilotdeploymentprofileassigneddevice
schema: 2.0.0
---

# New-MgDeviceManagementWindowAutopilotDeploymentProfileAssignedDevice

## SYNOPSIS
Create new navigation property to assignedDevices for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementWindowAutopilotDeploymentProfileAssignedDevice
 -WindowsAutopilotDeploymentProfileId <String> [-AdditionalProperties <Hashtable>]
 [-AddressableUserName <String>] [-AzureActiveDirectoryDeviceId <String>] [-AzureAdDeviceId <String>]
 [-DeploymentProfile <IMicrosoftGraphWindowsAutopilotDeploymentProfile>]
 [-DeploymentProfileAssignedDateTime <DateTime>]
 [-DeploymentProfileAssignmentDetailedStatus <WindowsAutopilotProfileAssignmentDetailedStatus>]
 [-DeploymentProfileAssignmentStatus <WindowsAutopilotProfileAssignmentStatus>]
 [-DeviceAccountPassword <String>] [-DeviceAccountUpn <String>] [-DeviceFriendlyName <String>]
 [-DisplayName <String>] [-EnrollmentState <EnrollmentState>] [-GroupTag <String>] [-Id <String>]
 [-IntendedDeploymentProfile <IMicrosoftGraphWindowsAutopilotDeploymentProfile>]
 [-LastContactedDateTime <DateTime>] [-ManagedDeviceId <String>] [-Manufacturer <String>] [-Model <String>]
 [-ProductKey <String>] [-PurchaseOrderIdentifier <String>]
 [-RemediationState <WindowsAutopilotDeviceRemediationState>]
 [-RemediationStateLastModifiedDateTime <DateTime>] [-ResourceName <String>] [-SerialNumber <String>]
 [-SkuNumber <String>] [-SystemFamily <String>] [-UserPrincipalName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementWindowAutopilotDeploymentProfileAssignedDevice
 -WindowsAutopilotDeploymentProfileId <String> -BodyParameter <IMicrosoftGraphWindowsAutopilotDeviceIdentity>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgDeviceManagementWindowAutopilotDeploymentProfileAssignedDevice
 -InputObject <IDeviceManagementEnrolmentIdentity>
 -BodyParameter <IMicrosoftGraphWindowsAutopilotDeviceIdentity> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgDeviceManagementWindowAutopilotDeploymentProfileAssignedDevice
 -InputObject <IDeviceManagementEnrolmentIdentity> [-AdditionalProperties <Hashtable>]
 [-AddressableUserName <String>] [-AzureActiveDirectoryDeviceId <String>] [-AzureAdDeviceId <String>]
 [-DeploymentProfile <IMicrosoftGraphWindowsAutopilotDeploymentProfile>]
 [-DeploymentProfileAssignedDateTime <DateTime>]
 [-DeploymentProfileAssignmentDetailedStatus <WindowsAutopilotProfileAssignmentDetailedStatus>]
 [-DeploymentProfileAssignmentStatus <WindowsAutopilotProfileAssignmentStatus>]
 [-DeviceAccountPassword <String>] [-DeviceAccountUpn <String>] [-DeviceFriendlyName <String>]
 [-DisplayName <String>] [-EnrollmentState <EnrollmentState>] [-GroupTag <String>] [-Id <String>]
 [-IntendedDeploymentProfile <IMicrosoftGraphWindowsAutopilotDeploymentProfile>]
 [-LastContactedDateTime <DateTime>] [-ManagedDeviceId <String>] [-Manufacturer <String>] [-Model <String>]
 [-ProductKey <String>] [-PurchaseOrderIdentifier <String>]
 [-RemediationState <WindowsAutopilotDeviceRemediationState>]
 [-RemediationStateLastModifiedDateTime <DateTime>] [-ResourceName <String>] [-SerialNumber <String>]
 [-SkuNumber <String>] [-SystemFamily <String>] [-UserPrincipalName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to assignedDevices for deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddressableUserName
Addressable user name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureActiveDirectoryDeviceId
AAD Device ID - to be deprecated

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureAdDeviceId
AAD Device ID

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The windowsAutopilotDeviceIdentity resource represents a Windows Autopilot Device.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeviceIdentity
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeploymentProfile
Windows Autopilot Deployment Profile
To construct, please use Get-Help -Online and see NOTES section for DEPLOYMENTPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeploymentProfile
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentProfileAssignedDateTime
Profile set time of the Windows autopilot device.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentProfileAssignmentDetailedStatus
windowsAutopilotProfileAssignmentDetailedStatus

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsAutopilotProfileAssignmentDetailedStatus
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentProfileAssignmentStatus
windowsAutopilotProfileAssignmentStatus

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsAutopilotProfileAssignmentStatus
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceAccountPassword
Surface Hub Device Account Password

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceAccountUpn
Surface Hub Device Account Upn

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceFriendlyName
Surface Hub Device Friendly Name

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display Name

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentState
.

```yaml
Type: Microsoft.Graph.PowerShell.Support.EnrollmentState
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupTag
Group Tag of the Windows autopilot device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IntendedDeploymentProfile
Windows Autopilot Deployment Profile
To construct, please use Get-Help -Online and see NOTES section for INTENDEDDEPLOYMENTPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeploymentProfile
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastContactedDateTime
Intune Last Contacted Date Time of the Windows autopilot device.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedDeviceId
Managed Device ID

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manufacturer
Oem manufacturer of the Windows autopilot device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Model
Model name of the Windows autopilot device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProductKey
Product Key of the Windows autopilot device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PurchaseOrderIdentifier
Purchase Order Identifier of the Windows autopilot device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemediationState
Device remediation status, indicating whether or not hardware has been changed for an Autopilot-registered device.

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsAutopilotDeviceRemediationState
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemediationStateLastModifiedDateTime
RemediationState set time of Autopilot device.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceName
Resource Name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SerialNumber
Serial number of the Windows autopilot device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuNumber
SKU Number

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemFamily
System Family

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
User Principal Name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: Create, CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeviceIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeviceIdentity

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphWindowsAutopilotDeviceIdentity>: The windowsAutopilotDeviceIdentity resource represents a Windows Autopilot Device.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

DEPLOYMENTPROFILE <IMicrosoftGraphWindowsAutopilotDeploymentProfile>: Windows Autopilot Deployment Profile
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

INTENDEDDEPLOYMENTPROFILE <IMicrosoftGraphWindowsAutopilotDeploymentProfile>: Windows Autopilot Deployment Profile
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

## RELATED LINKS

