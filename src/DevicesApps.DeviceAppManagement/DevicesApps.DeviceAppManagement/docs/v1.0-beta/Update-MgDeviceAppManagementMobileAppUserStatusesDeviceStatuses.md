---
external help file:
Module Name: Microsoft.Graph.DevicesApps.DeviceAppManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.deviceappmanagement/update-mgdeviceappmanagementmobileappuserstatusesdevicestatuses
schema: 2.0.0
---

# Update-MgDeviceAppManagementMobileAppUserStatusesDeviceStatuses

## SYNOPSIS
Update the navigation property deviceStatuses in deviceAppManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceAppManagementMobileAppUserStatusesDeviceStatuses -MobileAppId <String>
 -MobileAppInstallStatusId <String> -UserAppInstallStatusId <String> [-App <IMicrosoftGraphMobileApp>]
 [-DeviceId <String>] [-DeviceName <String>] [-DisplayVersion <String>] [-ErrorCode <Int32>] [-Id <String>]
 [-InstallState <String>] [-InstallStateDetail <String>] [-LastSyncDateTime <DateTime>]
 [-MobileAppInstallStatusValue <String>] [-OSDescription <String>] [-OSVersion <String>] [-UserName <String>]
 [-UserPrincipalName <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceAppManagementMobileAppUserStatusesDeviceStatuses -MobileAppId <String>
 -MobileAppInstallStatusId <String> -UserAppInstallStatusId <String>
 -BodyParameter <IMicrosoftGraphMobileAppInstallStatus> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceAppManagementMobileAppUserStatusesDeviceStatuses
 -InputObject <IDevicesAppsDeviceAppManagementIdentity> -BodyParameter <IMicrosoftGraphMobileAppInstallStatus>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceAppManagementMobileAppUserStatusesDeviceStatuses
 -InputObject <IDevicesAppsDeviceAppManagementIdentity> [-App <IMicrosoftGraphMobileApp>] [-DeviceId <String>]
 [-DeviceName <String>] [-DisplayVersion <String>] [-ErrorCode <Int32>] [-Id <String>]
 [-InstallState <String>] [-InstallStateDetail <String>] [-LastSyncDateTime <DateTime>]
 [-MobileAppInstallStatusValue <String>] [-OSDescription <String>] [-OSVersion <String>] [-UserName <String>]
 [-UserPrincipalName <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property deviceStatuses in deviceAppManagement

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -App
An abstract class containing the base properties for Intune mobile apps.
To construct, see NOTES section for APP properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Contains properties for the installation state of a mobile app for a device.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppInstallStatus
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceId
Device ID

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

### -DeviceName
Device name

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

### -DisplayVersion
Human readable version of the application

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

### -ErrorCode
The error code for install or uninstall failures.

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
Type: Microsoft.Graph.PowerShell.Models.IDevicesAppsDeviceAppManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InstallState
resultantAppState

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

### -InstallStateDetail
resultantAppStateDetail

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

### -LastSyncDateTime
Last sync date time

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

### -MobileAppId
key: mobileApp-id of mobileApp

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

### -MobileAppInstallStatusId
key: mobileAppInstallStatus-id of mobileAppInstallStatus

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

### -MobileAppInstallStatusValue
resultantAppState

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

### -OSDescription
OS Description

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

### -OSVersion
OS Version

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

### -UserAppInstallStatusId
key: userAppInstallStatus-id of userAppInstallStatus

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

### -UserName
Device User Name

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

### -UserPrincipalName
User Principal Name

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

### Microsoft.Graph.PowerShell.Models.IDevicesAppsDeviceAppManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppInstallStatus

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APP <IMicrosoftGraphMobileApp>: An abstract class containing the base properties for Intune mobile apps.
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphMobileAppAssignment1[]>]`: The list of group assignments for this mobile app.
    - `[Id <String>]`: Read-only.
    - `[Intent <String>]`: installIntent
    - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: mobileAppAssignmentSettings
    - `[Source <String>]`: deviceAndAppManagementAssignmentSource
    - `[SourceId <String>]`: The identifier of the source of the assignment.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
  - `[Categories <IMicrosoftGraphMobileAppCategory[]>]`: The list of categories for this app.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the app category.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.
  - `[CreatedDateTime <DateTime?>]`: The date and time the app was created.
  - `[DependentAppCount <Int32?>]`: The total number of dependencies the child app has.
  - `[Description <String>]`: The description of the app.
  - `[Developer <String>]`: The developer of the app.
  - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The list of installation states for this mobile app.
    - `[Id <String>]`: Read-only.
    - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
    - `[DeviceId <String>]`: Device ID
    - `[DeviceName <String>]`: Device name
    - `[DisplayVersion <String>]`: Human readable version of the application
    - `[ErrorCode <Int32?>]`: The error code for install or uninstall failures.
    - `[InstallState <String>]`: resultantAppState
    - `[InstallStateDetail <String>]`: resultantAppStateDetail
    - `[LastSyncDateTime <DateTime?>]`: Last sync date time
    - `[MobileAppInstallStatusValue <String>]`: resultantAppState
    - `[OSDescription <String>]`: OS Description
    - `[OSVersion <String>]`: OS Version
    - `[UserName <String>]`: Device User Name
    - `[UserPrincipalName <String>]`: User Principal Name
  - `[DisplayName <String>]`: The admin provided or imported title of the app.
  - `[InformationUrl <String>]`: The more information Url.
  - `[InstallSummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to install this app.
  - `[InstallSummaryFailedUserCount <Int32?>]`: Number of Users that have 1 or more device that failed to install this app.
  - `[InstallSummaryId <String>]`: Read-only.
  - `[InstallSummaryInstalledDeviceCount <Int32?>]`: Number of Devices that have successfully installed this app.
  - `[InstallSummaryInstalledUserCount <Int32?>]`: Number of Users whose devices have all succeeded to install this app.
  - `[InstallSummaryNotApplicableDeviceCount <Int32?>]`: Number of Devices that are not applicable for this app.
  - `[InstallSummaryNotApplicableUserCount <Int32?>]`: Number of Users whose devices were all not applicable for this app.
  - `[InstallSummaryNotInstalledDeviceCount <Int32?>]`: Number of Devices that does not have this app installed.
  - `[InstallSummaryNotInstalledUserCount <Int32?>]`: Number of Users that have 1 or more devices that did not install this app.
  - `[InstallSummaryPendingInstallDeviceCount <Int32?>]`: Number of Devices that have been notified to install this app.
  - `[InstallSummaryPendingInstallUserCount <Int32?>]`: Number of Users that have 1 or more device that have been notified to install this app and have 0 devices with failures.
  - `[IsAssigned <Boolean?>]`: The value indicating whether the app is assigned to at least one group.
  - `[IsFeatured <Boolean?>]`: The value indicating whether the app is marked as featured by the admin.
  - `[LargeIconType <String>]`: Indicates the content mime type.
  - `[LargeIconValue <Byte[]>]`: The byte array that contains the actual content.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the app was last modified.
  - `[Notes <String>]`: Notes for the app.
  - `[Owner <String>]`: The owner of the app.
  - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
  - `[Publisher <String>]`: The publisher of the app.
  - `[PublishingState <String>]`: mobileAppPublishingState
  - `[Relationships <IMicrosoftGraphMobileAppRelationship[]>]`: List of relationships for this mobile app.
    - `[Id <String>]`: Read-only.
    - `[TargetDisplayName <String>]`: The target child mobile app's display name.
    - `[TargetId <String>]`: The target child mobile app's app id.
  - `[RoleScopeTagIds <String[]>]`: List of scope tag ids for this mobile app.
  - `[UploadState <Int32?>]`: The upload state.
  - `[UserStatuses <IMicrosoftGraphUserAppInstallStatus[]>]`: The list of installation states for this mobile app.
    - `[Id <String>]`: Read-only.
    - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
    - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The install state of the app on devices.
    - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
    - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
    - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
    - `[UserName <String>]`: User name.
    - `[UserPrincipalName <String>]`: User Principal Name.

BODYPARAMETER <IMicrosoftGraphMobileAppInstallStatus>: Contains properties for the installation state of a mobile app for a device.
  - `[Id <String>]`: Read-only.
  - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
    - `[Id <String>]`: Read-only.
    - `[Assignments <IMicrosoftGraphMobileAppAssignment1[]>]`: The list of group assignments for this mobile app.
      - `[Id <String>]`: Read-only.
      - `[Intent <String>]`: installIntent
      - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: mobileAppAssignmentSettings
      - `[Source <String>]`: deviceAndAppManagementAssignmentSource
      - `[SourceId <String>]`: The identifier of the source of the assignment.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
    - `[Categories <IMicrosoftGraphMobileAppCategory[]>]`: The list of categories for this app.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The name of the app category.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.
    - `[CreatedDateTime <DateTime?>]`: The date and time the app was created.
    - `[DependentAppCount <Int32?>]`: The total number of dependencies the child app has.
    - `[Description <String>]`: The description of the app.
    - `[Developer <String>]`: The developer of the app.
    - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The list of installation states for this mobile app.
    - `[DisplayName <String>]`: The admin provided or imported title of the app.
    - `[InformationUrl <String>]`: The more information Url.
    - `[InstallSummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to install this app.
    - `[InstallSummaryFailedUserCount <Int32?>]`: Number of Users that have 1 or more device that failed to install this app.
    - `[InstallSummaryId <String>]`: Read-only.
    - `[InstallSummaryInstalledDeviceCount <Int32?>]`: Number of Devices that have successfully installed this app.
    - `[InstallSummaryInstalledUserCount <Int32?>]`: Number of Users whose devices have all succeeded to install this app.
    - `[InstallSummaryNotApplicableDeviceCount <Int32?>]`: Number of Devices that are not applicable for this app.
    - `[InstallSummaryNotApplicableUserCount <Int32?>]`: Number of Users whose devices were all not applicable for this app.
    - `[InstallSummaryNotInstalledDeviceCount <Int32?>]`: Number of Devices that does not have this app installed.
    - `[InstallSummaryNotInstalledUserCount <Int32?>]`: Number of Users that have 1 or more devices that did not install this app.
    - `[InstallSummaryPendingInstallDeviceCount <Int32?>]`: Number of Devices that have been notified to install this app.
    - `[InstallSummaryPendingInstallUserCount <Int32?>]`: Number of Users that have 1 or more device that have been notified to install this app and have 0 devices with failures.
    - `[IsAssigned <Boolean?>]`: The value indicating whether the app is assigned to at least one group.
    - `[IsFeatured <Boolean?>]`: The value indicating whether the app is marked as featured by the admin.
    - `[LargeIconType <String>]`: Indicates the content mime type.
    - `[LargeIconValue <Byte[]>]`: The byte array that contains the actual content.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the app was last modified.
    - `[Notes <String>]`: Notes for the app.
    - `[Owner <String>]`: The owner of the app.
    - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
    - `[Publisher <String>]`: The publisher of the app.
    - `[PublishingState <String>]`: mobileAppPublishingState
    - `[Relationships <IMicrosoftGraphMobileAppRelationship[]>]`: List of relationships for this mobile app.
      - `[Id <String>]`: Read-only.
      - `[TargetDisplayName <String>]`: The target child mobile app's display name.
      - `[TargetId <String>]`: The target child mobile app's app id.
    - `[RoleScopeTagIds <String[]>]`: List of scope tag ids for this mobile app.
    - `[UploadState <Int32?>]`: The upload state.
    - `[UserStatuses <IMicrosoftGraphUserAppInstallStatus[]>]`: The list of installation states for this mobile app.
      - `[Id <String>]`: Read-only.
      - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
      - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The install state of the app on devices.
      - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
      - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
      - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
      - `[UserName <String>]`: User name.
      - `[UserPrincipalName <String>]`: User Principal Name.
  - `[DeviceId <String>]`: Device ID
  - `[DeviceName <String>]`: Device name
  - `[DisplayVersion <String>]`: Human readable version of the application
  - `[ErrorCode <Int32?>]`: The error code for install or uninstall failures.
  - `[InstallState <String>]`: resultantAppState
  - `[InstallStateDetail <String>]`: resultantAppStateDetail
  - `[LastSyncDateTime <DateTime?>]`: Last sync date time
  - `[MobileAppInstallStatusValue <String>]`: resultantAppState
  - `[OSDescription <String>]`: OS Description
  - `[OSVersion <String>]`: OS Version
  - `[UserName <String>]`: Device User Name
  - `[UserPrincipalName <String>]`: User Principal Name

INPUTOBJECT <IDevicesAppsDeviceAppManagementIdentity>: Identity Parameter
  - `[AndroidManagedAppProtectionId <String>]`: key: androidManagedAppProtection-id of androidManagedAppProtection
  - `[BundleId <String>]`: 
  - `[Count <Int64?>]`: 
  - `[DefaultManagedAppProtectionId <String>]`: key: defaultManagedAppProtection-id of defaultManagedAppProtection
  - `[DeviceAppManagementTaskId <String>]`: key: deviceAppManagementTask-id of deviceAppManagementTask
  - `[DeviceId <String>]`: 
  - `[DeviceInstallStateId <String>]`: key: deviceInstallState-id of deviceInstallState
  - `[EnterpriseCodeSigningCertificateId <String>]`: key: enterpriseCodeSigningCertificate-id of enterpriseCodeSigningCertificate
  - `[IosLobAppProvisioningConfigurationAssignmentId <String>]`: key: iosLobAppProvisioningConfigurationAssignment-id of iosLobAppProvisioningConfigurationAssignment
  - `[IosLobAppProvisioningConfigurationId <String>]`: key: iosLobAppProvisioningConfiguration-id of iosLobAppProvisioningConfiguration
  - `[IosManagedAppProtectionId <String>]`: key: iosManagedAppProtection-id of iosManagedAppProtection
  - `[ManagedAppOperationId <String>]`: key: managedAppOperation-id of managedAppOperation
  - `[ManagedAppPolicyId <String>]`: key: managedAppPolicy-id of managedAppPolicy
  - `[ManagedAppRegistrationId <String>]`: key: managedAppRegistration-id of managedAppRegistration
  - `[ManagedAppStatusId <String>]`: key: managedAppStatus-id of managedAppStatus
  - `[ManagedDeviceMobileAppConfigurationAssignmentId <String>]`: key: managedDeviceMobileAppConfigurationAssignment-id of managedDeviceMobileAppConfigurationAssignment
  - `[ManagedDeviceMobileAppConfigurationDeviceStatusId <String>]`: key: managedDeviceMobileAppConfigurationDeviceStatus-id of managedDeviceMobileAppConfigurationDeviceStatus
  - `[ManagedDeviceMobileAppConfigurationId <String>]`: key: managedDeviceMobileAppConfiguration-id of managedDeviceMobileAppConfiguration
  - `[ManagedDeviceMobileAppConfigurationUserStatusId <String>]`: key: managedDeviceMobileAppConfigurationUserStatus-id of managedDeviceMobileAppConfigurationUserStatus
  - `[ManagedEBookAssignmentId <String>]`: key: managedEBookAssignment-id of managedEBookAssignment
  - `[ManagedEBookCategoryId <String>]`: key: managedEBookCategory-id of managedEBookCategory
  - `[ManagedEBookId <String>]`: key: managedEBook-id of managedEBook
  - `[ManagedMobileAppId <String>]`: key: managedMobileApp-id of managedMobileApp
  - `[MdmWindowsInformationProtectionPolicyId <String>]`: key: mdmWindowsInformationProtectionPolicy-id of mdmWindowsInformationProtectionPolicy
  - `[MobileAppAssignmentId <String>]`: key: mobileAppAssignment-id of mobileAppAssignment
  - `[MobileAppCategoryId <String>]`: key: mobileAppCategory-id of mobileAppCategory
  - `[MobileAppId <String>]`: key: mobileApp-id of mobileApp
  - `[MobileAppInstallStatusId <String>]`: key: mobileAppInstallStatus-id of mobileAppInstallStatus
  - `[MobileAppProvisioningConfigGroupAssignmentId <String>]`: key: mobileAppProvisioningConfigGroupAssignment-id of mobileAppProvisioningConfigGroupAssignment
  - `[MobileAppRelationshipId <String>]`: key: mobileAppRelationship-id of mobileAppRelationship
  - `[PolicySetAssignmentId <String>]`: key: policySetAssignment-id of policySetAssignment
  - `[PolicySetId <String>]`: key: policySet-id of policySet
  - `[PolicySetItemId <String>]`: key: policySetItem-id of policySetItem
  - `[SideLoadingKeyId <String>]`: key: sideLoadingKey-id of sideLoadingKey
  - `[Status <String>]`: 
  - `[TargetedManagedAppConfigurationId <String>]`: key: targetedManagedAppConfiguration-id of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: key: targetedManagedAppPolicyAssignment-id of targetedManagedAppPolicyAssignment
  - `[UserAppInstallStatusId <String>]`: key: userAppInstallStatus-id of userAppInstallStatus
  - `[UserInstallStateSummaryId <String>]`: key: userInstallStateSummary-id of userInstallStateSummary
  - `[UserPrincipalName <String>]`: 
  - `[VppTokenId <String>]`: key: vppToken-id of vppToken
  - `[WindowsDefenderApplicationControlSupplementalPolicyAssignmentId <String>]`: key: windowsDefenderApplicationControlSupplementalPolicyAssignment-id of windowsDefenderApplicationControlSupplementalPolicyAssignment
  - `[WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId <String>]`: key: windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus-id of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
  - `[WindowsDefenderApplicationControlSupplementalPolicyId <String>]`: key: windowsDefenderApplicationControlSupplementalPolicy-id of windowsDefenderApplicationControlSupplementalPolicy
  - `[WindowsInformationProtectionDeviceRegistrationId <String>]`: key: windowsInformationProtectionDeviceRegistration-id of windowsInformationProtectionDeviceRegistration
  - `[WindowsInformationProtectionPolicyId <String>]`: key: windowsInformationProtectionPolicy-id of windowsInformationProtectionPolicy
  - `[WindowsInformationProtectionWipeActionId <String>]`: key: windowsInformationProtectionWipeAction-id of windowsInformationProtectionWipeAction

## RELATED LINKS

