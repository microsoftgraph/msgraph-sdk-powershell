---
external help file:
Module Name: Microsoft.Graph.DevicesApps.DeviceAppManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.deviceappmanagement/update-mgdeviceappmanagementmanagedappregistration
schema: 2.0.0
---

# Update-MgDeviceAppManagementManagedAppRegistration

## SYNOPSIS
Update the navigation property managedAppRegistrations in deviceAppManagement

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDeviceAppManagementManagedAppRegistration -ManagedAppRegistrationId <String>
 [-AppIdentifier <IMicrosoftGraphMobileAppIdentifier>] [-ApplicationVersion <String>]
 [-AppliedPolicies <IMicrosoftGraphManagedAppPolicy1[]>] [-AzureAdDeviceId <String>]
 [-CreatedDateTime <DateTime>] [-DeviceManufacturer <String>] [-DeviceModel <String>] [-DeviceName <String>]
 [-DeviceTag <String>] [-DeviceType <String>] [-FlaggedReasons <String[]>] [-Id <String>]
 [-IntendedPolicies <IMicrosoftGraphManagedAppPolicy1[]>] [-LastSyncDateTime <DateTime>]
 [-ManagedDeviceId <String>] [-ManagementSdkVersion <String>]
 [-Operations <IMicrosoftGraphManagedAppOperation[]>] [-PlatformVersion <String>] [-UserId <String>]
 [-Version <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgDeviceAppManagementManagedAppRegistration -ManagedAppRegistrationId <String>
 -BodyParameter <IMicrosoftGraphManagedAppRegistration1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgDeviceAppManagementManagedAppRegistration -InputObject <IDevicesAppsDeviceAppManagementIdentity>
 -BodyParameter <IMicrosoftGraphManagedAppRegistration1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgDeviceAppManagementManagedAppRegistration -InputObject <IDevicesAppsDeviceAppManagementIdentity>
 [-AppIdentifier <IMicrosoftGraphMobileAppIdentifier>] [-ApplicationVersion <String>]
 [-AppliedPolicies <IMicrosoftGraphManagedAppPolicy1[]>] [-AzureAdDeviceId <String>]
 [-CreatedDateTime <DateTime>] [-DeviceManufacturer <String>] [-DeviceModel <String>] [-DeviceName <String>]
 [-DeviceTag <String>] [-DeviceType <String>] [-FlaggedReasons <String[]>] [-Id <String>]
 [-IntendedPolicies <IMicrosoftGraphManagedAppPolicy1[]>] [-LastSyncDateTime <DateTime>]
 [-ManagedDeviceId <String>] [-ManagementSdkVersion <String>]
 [-Operations <IMicrosoftGraphManagedAppOperation[]>] [-PlatformVersion <String>] [-UserId <String>]
 [-Version <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property managedAppRegistrations in deviceAppManagement

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

### -AppIdentifier
mobileAppIdentifier

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppIdentifier
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationVersion
App version

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppliedPolicies
Zero or more policys already applied on the registered app when it last synchronized with managment service.
To construct, see NOTES section for APPLIEDPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicy1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureAdDeviceId
The Azure Active Directory Device identifier of the host device.
Value could be empty even when the host device is Azure Active Directory registered.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppRegistration1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Date and time of creation

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceManufacturer
The device manufacturer for the current app registration

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceModel
The device model for the current app registration

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceName
Host device name

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceTag
App management SDK generated tag, which helps relate apps hosted on the same device.
Not guaranteed to relate apps in all conditions.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceType
Host device type

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FlaggedReasons
Zero or more reasons an app registration is flagged.
E.g.
app running on rooted device

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IntendedPolicies
Zero or more policies admin intended for the app as of now.
To construct, see NOTES section for INTENDEDPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicy1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastSyncDateTime
Date and time of last the app synced with management service.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedAppRegistrationId
key: managedAppRegistration-id of managedAppRegistration

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedDeviceId
The Managed Device identifier of the host device.
Value could be empty even when the host device is managed.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementSdkVersion
App management SDK version

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Operations
Zero or more long running operations triggered on the app registration.
To construct, see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppOperation[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -PlatformVersion
Operating System version

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The user Id to who this app registration belongs.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Version of the entity.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppRegistration1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPLIEDPOLICIES <IMicrosoftGraphManagedAppPolicy1[]>: Zero or more policys already applied on the registered app when it last synchronized with managment service.
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.

BODYPARAMETER <IMicrosoftGraphManagedAppRegistration1>: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
  - `[Id <String>]`: Read-only.
  - `[AppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: mobileAppIdentifier
  - `[ApplicationVersion <String>]`: App version
  - `[AppliedPolicies <IMicrosoftGraphManagedAppPolicy1[]>]`: Zero or more policys already applied on the registered app when it last synchronized with managment service.
    - `[Id <String>]`: Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
    - `[Description <String>]`: The policy's description.
    - `[DisplayName <String>]`: Policy display name.
    - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Version <String>]`: Version of the entity.
  - `[AzureAdDeviceId <String>]`: The Azure Active Directory Device identifier of the host device. Value could be empty even when the host device is Azure Active Directory registered.
  - `[CreatedDateTime <DateTime?>]`: Date and time of creation
  - `[DeviceManufacturer <String>]`: The device manufacturer for the current app registration 
  - `[DeviceModel <String>]`: The device model for the current app registration 
  - `[DeviceName <String>]`: Host device name
  - `[DeviceTag <String>]`: App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.
  - `[DeviceType <String>]`: Host device type
  - `[FlaggedReasons <String[]>]`: Zero or more reasons an app registration is flagged. E.g. app running on rooted device
  - `[IntendedPolicies <IMicrosoftGraphManagedAppPolicy1[]>]`: Zero or more policies admin intended for the app as of now.
  - `[LastSyncDateTime <DateTime?>]`: Date and time of last the app synced with management service.
  - `[ManagedDeviceId <String>]`: The Managed Device identifier of the host device. Value could be empty even when the host device is managed.
  - `[ManagementSdkVersion <String>]`: App management SDK version
  - `[Operations <IMicrosoftGraphManagedAppOperation[]>]`: Zero or more long running operations triggered on the app registration.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The operation name.
    - `[LastModifiedDateTime <DateTime?>]`: The last time the app operation was modified.
    - `[State <String>]`: The current state of the operation
    - `[Version <String>]`: Version of the entity.
  - `[PlatformVersion <String>]`: Operating System version
  - `[UserId <String>]`: The user Id to who this app registration belongs.
  - `[Version <String>]`: Version of the entity.

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

INTENDEDPOLICIES <IMicrosoftGraphManagedAppPolicy1[]>: Zero or more policies admin intended for the app as of now.
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.

OPERATIONS <IMicrosoftGraphManagedAppOperation[]>: Zero or more long running operations triggered on the app registration.
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: The operation name.
  - `[LastModifiedDateTime <DateTime?>]`: The last time the app operation was modified.
  - `[State <String>]`: The current state of the operation
  - `[Version <String>]`: Version of the entity.

## RELATED LINKS

