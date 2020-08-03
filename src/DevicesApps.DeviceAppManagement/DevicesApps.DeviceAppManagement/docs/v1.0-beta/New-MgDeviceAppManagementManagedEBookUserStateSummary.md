---
external help file:
Module Name: Microsoft.Graph.DevicesApps.DeviceAppManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.deviceappmanagement/new-mgdeviceappmanagementmanagedebookuserstatesummary
schema: 2.0.0
---

# New-MgDeviceAppManagementManagedEBookUserStateSummary

## SYNOPSIS
Create new navigation property to userStateSummary for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppManagementManagedEBookUserStateSummary -ManagedEBookId <String>
 [-DeviceStates <IMicrosoftGraphDeviceInstallState[]>] [-FailedDeviceCount <Int32>] [-Id <String>]
 [-InstalledDeviceCount <Int32>] [-NotInstalledDeviceCount <Int32>] [-UserName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceAppManagementManagedEBookUserStateSummary -ManagedEBookId <String>
 -BodyParameter <IMicrosoftGraphUserInstallStateSummary> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgDeviceAppManagementManagedEBookUserStateSummary -InputObject <IDevicesAppsDeviceAppManagementIdentity>
 -BodyParameter <IMicrosoftGraphUserInstallStateSummary> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgDeviceAppManagementManagedEBookUserStateSummary -InputObject <IDevicesAppsDeviceAppManagementIdentity>
 [-DeviceStates <IMicrosoftGraphDeviceInstallState[]>] [-FailedDeviceCount <Int32>] [-Id <String>]
 [-InstalledDeviceCount <Int32>] [-NotInstalledDeviceCount <Int32>] [-UserName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userStateSummary for deviceAppManagement

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

### -BodyParameter
Contains properties for the installation state summary for a user.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserInstallStateSummary
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceStates
The install state of the eBook.
To construct, see NOTES section for DEVICESTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceInstallState[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FailedDeviceCount
Failed Device Count.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesAppsDeviceAppManagementIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InstalledDeviceCount
Installed Device Count.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedEBookId
key: managedEBook-id of managedEBook

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

### -NotInstalledDeviceCount
Not installed device count.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserName
User name.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserInstallStateSummary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserInstallStateSummary

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserInstallStateSummary>: Contains properties for the installation state summary for a user.
  - `[Id <String>]`: Read-only.
  - `[DeviceStates <IMicrosoftGraphDeviceInstallState[]>]`: The install state of the eBook.
    - `[Id <String>]`: Read-only.
    - `[DeviceId <String>]`: Device Id.
    - `[DeviceName <String>]`: Device name.
    - `[ErrorCode <String>]`: The error code for install failures.
    - `[InstallState <String>]`: installState
    - `[LastSyncDateTime <DateTime?>]`: Last sync date and time.
    - `[OSDescription <String>]`: OS Description.
    - `[OSVersion <String>]`: OS Version.
    - `[UserName <String>]`: Device User Name.
  - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
  - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
  - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
  - `[UserName <String>]`: User name.

DEVICESTATES <IMicrosoftGraphDeviceInstallState[]>: The install state of the eBook.
  - `[Id <String>]`: Read-only.
  - `[DeviceId <String>]`: Device Id.
  - `[DeviceName <String>]`: Device name.
  - `[ErrorCode <String>]`: The error code for install failures.
  - `[InstallState <String>]`: installState
  - `[LastSyncDateTime <DateTime?>]`: Last sync date and time.
  - `[OSDescription <String>]`: OS Description.
  - `[OSVersion <String>]`: OS Version.
  - `[UserName <String>]`: Device User Name.

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

