---
external help file:
Module Name: Microsoft.Graph.DevicesApps.DeviceAppManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.deviceappmanagement/update-mgdeviceappmanagementwdacsupplementalpolicy
schema: 2.0.0
---

# Update-MgDeviceAppManagementWdacSupplementalPolicy

## SYNOPSIS
Update the navigation property wdacSupplementalPolicies in deviceAppManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceAppManagementWdacSupplementalPolicy
 -WindowsDefenderApplicationControlSupplementalPolicyId <String>
 [-Assignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]
 [-ContentFileName <String>] [-ContentInputFile <String>] [-CreationDateTime <DateTime>]
 [-DeploySummaryDeployedDeviceCount <Int32>] [-DeploySummaryFailedDeviceCount <Int32>]
 [-DeploySummaryId <String>] [-Description <String>]
 [-DeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-Version <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceAppManagementWdacSupplementalPolicy
 -WindowsDefenderApplicationControlSupplementalPolicyId <String>
 -BodyParameter <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceAppManagementWdacSupplementalPolicy -InputObject <IDevicesAppsDeviceAppManagementIdentity>
 -BodyParameter <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceAppManagementWdacSupplementalPolicy -InputObject <IDevicesAppsDeviceAppManagementIdentity>
 [-Assignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]
 [-ContentFileName <String>] [-ContentInputFile <String>] [-CreationDateTime <DateTime>]
 [-DeploySummaryDeployedDeviceCount <Int32>] [-DeploySummaryFailedDeviceCount <Int32>]
 [-DeploySummaryId <String>] [-Description <String>]
 [-DeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-Version <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property wdacSupplementalPolicies in deviceAppManagement

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

### -Assignments
The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
windowsDefenderApplicationControlSupplementalPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentFileName
The WindowsDefenderApplicationControl supplemental policy content's file name.

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

### -ContentInputFile
Input File for Content (The WindowsDefenderApplicationControl supplemental policy content in byte array format.)

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

### -CreationDateTime
The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.

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

### -DeploySummaryDeployedDeviceCount
Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.

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

### -DeploySummaryFailedDeviceCount
Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.

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

### -DeploySummaryId
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

### -Description
The description of WindowsDefenderApplicationControl supplemental policy.

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

### -DeviceStatuses
The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
To construct, see NOTES section for DEVICESTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name of WindowsDefenderApplicationControl supplemental policy.

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
Type: Microsoft.Graph.PowerShell.Models.IDevicesAppsDeviceAppManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.

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
List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.

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

### -Version
The WindowsDefenderApplicationControl supplemental policy's version.

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

### -WindowsDefenderApplicationControlSupplementalPolicyId
key: windowsDefenderApplicationControlSupplementalPolicy-id of windowsDefenderApplicationControlSupplementalPolicy

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

### Microsoft.Graph.PowerShell.Models.IDevicesAppsDeviceAppManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget

BODYPARAMETER <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy>: windowsDefenderApplicationControlSupplementalPolicy
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]`: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
  - `[Content <Byte[]>]`: The WindowsDefenderApplicationControl supplemental policy content in byte array format.
  - `[ContentFileName <String>]`: The WindowsDefenderApplicationControl supplemental policy content's file name.
  - `[CreationDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.
  - `[DeploySummaryDeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
  - `[DeploySummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
  - `[DeploySummaryId <String>]`: Read-only.
  - `[Description <String>]`: The description of WindowsDefenderApplicationControl supplemental policy.
  - `[DeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
    - `[Id <String>]`: Read-only.
    - `[DeploySummaryDeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
    - `[DeploySummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
    - `[DeploySummaryId <String>]`: Read-only.
    - `[DeploymentStatus <String>]`: windowsDefenderApplicationControlSupplementalPolicyStatuses
    - `[DeviceId <String>]`: Device ID.
    - `[DeviceName <String>]`: Device name.
    - `[LastSyncDateTime <DateTime?>]`: Last sync date time.
    - `[OSDescription <String>]`: Windows OS Version Description.
    - `[OSVersion <String>]`: Windows OS Version.
    - `[PolicyAssignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]`: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
    - `[PolicyContent <Byte[]>]`: The WindowsDefenderApplicationControl supplemental policy content in byte array format.
    - `[PolicyContentFileName <String>]`: The WindowsDefenderApplicationControl supplemental policy content's file name.
    - `[PolicyCreationDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.
    - `[PolicyDescription <String>]`: The description of WindowsDefenderApplicationControl supplemental policy.
    - `[PolicyDeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
    - `[PolicyDisplayName <String>]`: The display name of WindowsDefenderApplicationControl supplemental policy.
    - `[PolicyId <String>]`: Read-only.
    - `[PolicyLastModifiedDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.
    - `[PolicyRoleScopeTagIds <String[]>]`: List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.
    - `[PolicyVersion <String>]`: Human readable version of the WindowsDefenderApplicationControl supplemental policy.
    - `[UserName <String>]`: The name of the user of this device.
    - `[UserPrincipalName <String>]`: User Principal Name.
    - `[Version <String>]`: The WindowsDefenderApplicationControl supplemental policy's version.
  - `[DisplayName <String>]`: The display name of WindowsDefenderApplicationControl supplemental policy.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.
  - `[Version <String>]`: The WindowsDefenderApplicationControl supplemental policy's version.

DEVICESTATUSES <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
  - `[Id <String>]`: Read-only.
  - `[DeploySummaryDeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
  - `[DeploySummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
  - `[DeploySummaryId <String>]`: Read-only.
  - `[DeploymentStatus <String>]`: windowsDefenderApplicationControlSupplementalPolicyStatuses
  - `[DeviceId <String>]`: Device ID.
  - `[DeviceName <String>]`: Device name.
  - `[LastSyncDateTime <DateTime?>]`: Last sync date time.
  - `[OSDescription <String>]`: Windows OS Version Description.
  - `[OSVersion <String>]`: Windows OS Version.
  - `[PolicyAssignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]`: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
  - `[PolicyContent <Byte[]>]`: The WindowsDefenderApplicationControl supplemental policy content in byte array format.
  - `[PolicyContentFileName <String>]`: The WindowsDefenderApplicationControl supplemental policy content's file name.
  - `[PolicyCreationDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.
  - `[PolicyDescription <String>]`: The description of WindowsDefenderApplicationControl supplemental policy.
  - `[PolicyDeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
  - `[PolicyDisplayName <String>]`: The display name of WindowsDefenderApplicationControl supplemental policy.
  - `[PolicyId <String>]`: Read-only.
  - `[PolicyLastModifiedDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.
  - `[PolicyRoleScopeTagIds <String[]>]`: List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.
  - `[PolicyVersion <String>]`: Human readable version of the WindowsDefenderApplicationControl supplemental policy.
  - `[UserName <String>]`: The name of the user of this device.
  - `[UserPrincipalName <String>]`: User Principal Name.
  - `[Version <String>]`: The WindowsDefenderApplicationControl supplemental policy's version.

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

