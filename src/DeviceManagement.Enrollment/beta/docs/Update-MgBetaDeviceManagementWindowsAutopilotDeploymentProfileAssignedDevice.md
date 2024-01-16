---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Enrollment
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.enrollment/update-mgbetadevicemanagementwindowsautopilotdeploymentprofileassigneddevice
schema: 2.0.0
---

# Update-MgBetaDeviceManagementWindowsAutopilotDeploymentProfileAssignedDevice

## SYNOPSIS
Update the navigation property assignedDevices in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementWindowsAutopilotDeploymentProfileAssignedDevice
 -WindowsAutopilotDeploymentProfileId <String> -WindowsAutopilotDeviceIdentityId <String>
 [-AdditionalProperties <Hashtable>] [-AddressableUserName <String>] [-AzureActiveDirectoryDeviceId <String>]
 [-AzureAdDeviceId <String>] [-DeploymentProfile <IMicrosoftGraphWindowsAutopilotDeploymentProfile>]
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
 [-SkuNumber <String>] [-SystemFamily <String>]
 [-UserlessEnrollmentStatus <WindowsAutopilotUserlessEnrollmentStatus>] [-UserPrincipalName <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementWindowsAutopilotDeploymentProfileAssignedDevice
 -WindowsAutopilotDeploymentProfileId <String> -WindowsAutopilotDeviceIdentityId <String>
 -BodyParameter <IMicrosoftGraphWindowsAutopilotDeviceIdentity> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaDeviceManagementWindowsAutopilotDeploymentProfileAssignedDevice
 -InputObject <IDeviceManagementEnrollmentIdentity>
 -BodyParameter <IMicrosoftGraphWindowsAutopilotDeviceIdentity> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaDeviceManagementWindowsAutopilotDeploymentProfileAssignedDevice
 -InputObject <IDeviceManagementEnrollmentIdentity> [-AdditionalProperties <Hashtable>]
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
 [-SkuNumber <String>] [-SystemFamily <String>]
 [-UserlessEnrollmentStatus <WindowsAutopilotUserlessEnrollmentStatus>] [-UserPrincipalName <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property assignedDevices in deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



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

### -AddressableUserName
Addressable user name.

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

### -AzureActiveDirectoryDeviceId
AAD Device ID - to be deprecated

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

### -AzureAdDeviceId
AAD Device ID

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

### -BodyParameter
The windowsAutopilotDeviceIdentity resource represents a Windows Autopilot Device.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeviceIdentity
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeploymentProfile
Windows Autopilot Deployment Profile
To construct, see NOTES section for DEPLOYMENTPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeploymentProfile
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Support.WindowsAutopilotProfileAssignmentDetailedStatus
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Support.WindowsAutopilotProfileAssignmentStatus
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentState
enrollmentState

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.EnrollmentState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementEnrollmentIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IntendedDeploymentProfile
Windows Autopilot Deployment Profile
To construct, see NOTES section for INTENDEDDEPLOYMENTPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeploymentProfile
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Support.WindowsAutopilotDeviceRemediationState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserlessEnrollmentStatus
Userless enrollment block status, indicating whether the next device enrollment will be blocked.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.WindowsAutopilotUserlessEnrollmentStatus
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowsAutopilotDeploymentProfileId
The unique identifier of windowsAutopilotDeploymentProfile

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

### -WindowsAutopilotDeviceIdentityId
The unique identifier of windowsAutopilotDeviceIdentity

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

### Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementEnrollmentIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeviceIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsAutopilotDeviceIdentity

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphWindowsAutopilotDeviceIdentity>`: The windowsAutopilotDeviceIdentity resource represents a Windows Autopilot Device.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AddressableUserName <String>]`: Addressable user name.
  - `[AzureActiveDirectoryDeviceId <String>]`: AAD Device ID - to be deprecated
  - `[AzureAdDeviceId <String>]`: AAD Device ID
  - `[DeploymentProfile <IMicrosoftGraphWindowsAutopilotDeploymentProfile>]`: Windows Autopilot Deployment Profile
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AssignedDevices <IMicrosoftGraphWindowsAutopilotDeviceIdentity[]>]`: The list of assigned devices for the profile.
    - `[Assignments <IMicrosoftGraphWindowsAutopilotDeploymentProfileAssignment[]>]`: The list of group assignments for the profile.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
      - `[SourceId <String>]`: Identifier for resource used for deployment to a group
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
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
  - `[EnrollmentState <EnrollmentState?>]`: enrollmentState
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
  - `[UserlessEnrollmentStatus <WindowsAutopilotUserlessEnrollmentStatus?>]`: Userless enrollment block status, indicating whether the next device enrollment will be blocked.

`DEPLOYMENTPROFILE <IMicrosoftGraphWindowsAutopilotDeploymentProfile>`: Windows Autopilot Deployment Profile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AssignedDevices <IMicrosoftGraphWindowsAutopilotDeviceIdentity[]>]`: The list of assigned devices for the profile.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
    - `[EnrollmentState <EnrollmentState?>]`: enrollmentState
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
    - `[UserlessEnrollmentStatus <WindowsAutopilotUserlessEnrollmentStatus?>]`: Userless enrollment block status, indicating whether the next device enrollment will be blocked.
  - `[Assignments <IMicrosoftGraphWindowsAutopilotDeploymentProfileAssignment[]>]`: The list of group assignments for the profile.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
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

`INPUTOBJECT <IDeviceManagementEnrollmentIdentity>`: Identity Parameter
  - `[AndroidDeviceOwnerEnrollmentProfileId <String>]`: The unique identifier of androidDeviceOwnerEnrollmentProfile
  - `[AndroidForWorkEnrollmentProfileId <String>]`: The unique identifier of androidForWorkEnrollmentProfile
  - `[AppScopeId <String>]`: The unique identifier of appScope
  - `[AppleEnrollmentProfileAssignmentId <String>]`: The unique identifier of appleEnrollmentProfileAssignment
  - `[AppleUserInitiatedEnrollmentProfileId <String>]`: The unique identifier of appleUserInitiatedEnrollmentProfile
  - `[CustomAppScopeId <String>]`: The unique identifier of customAppScope
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
  - `[UnifiedRbacResourceActionId <String>]`: The unique identifier of unifiedRbacResourceAction
  - `[UnifiedRbacResourceNamespaceId <String>]`: The unique identifier of unifiedRbacResourceNamespace
  - `[UnifiedRoleAssignmentId <String>]`: The unique identifier of unifiedRoleAssignment
  - `[UnifiedRoleAssignmentMultipleId <String>]`: The unique identifier of unifiedRoleAssignmentMultiple
  - `[UnifiedRoleDefinitionId <String>]`: The unique identifier of unifiedRoleDefinition
  - `[UnifiedRoleDefinitionId1 <String>]`: The unique identifier of unifiedRoleDefinition
  - `[WindowsAutopilotDeploymentProfileAssignmentId <String>]`: The unique identifier of windowsAutopilotDeploymentProfileAssignment
  - `[WindowsAutopilotDeploymentProfileId <String>]`: The unique identifier of windowsAutopilotDeploymentProfile
  - `[WindowsAutopilotDeviceIdentityId <String>]`: The unique identifier of windowsAutopilotDeviceIdentity
  - `[WindowsFeatureUpdateProfileAssignmentId <String>]`: The unique identifier of windowsFeatureUpdateProfileAssignment
  - `[WindowsFeatureUpdateProfileId <String>]`: The unique identifier of windowsFeatureUpdateProfile

`INTENDEDDEPLOYMENTPROFILE <IMicrosoftGraphWindowsAutopilotDeploymentProfile>`: Windows Autopilot Deployment Profile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AssignedDevices <IMicrosoftGraphWindowsAutopilotDeviceIdentity[]>]`: The list of assigned devices for the profile.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
    - `[EnrollmentState <EnrollmentState?>]`: enrollmentState
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
    - `[UserlessEnrollmentStatus <WindowsAutopilotUserlessEnrollmentStatus?>]`: Userless enrollment block status, indicating whether the next device enrollment will be blocked.
  - `[Assignments <IMicrosoftGraphWindowsAutopilotDeploymentProfileAssignment[]>]`: The list of group assignments for the profile.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
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

