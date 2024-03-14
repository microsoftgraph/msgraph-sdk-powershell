---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmanagementandroidmanagedappprotection
schema: 2.0.0
---

# Update-MgDeviceAppManagementAndroidManagedAppProtection

## SYNOPSIS
Update the properties of a androidManagedAppProtection object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceAppManagementAndroidManagedAppProtection -AndroidManagedAppProtectionId <String>
 [-AdditionalProperties <Hashtable>] [-AllowedDataStorageLocations <ManagedAppDataStorageLocation[]>]
 [-AllowedInboundDataTransferSources <ManagedAppDataTransferLevel>]
 [-AllowedOutboundClipboardSharingLevel <ManagedAppClipboardSharingLevel>]
 [-AllowedOutboundDataTransferDestinations <ManagedAppDataTransferLevel>]
 [-Apps <IMicrosoftGraphManagedMobileApp[]>]
 [-Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>] [-ContactSyncBlocked]
 [-CreatedDateTime <DateTime>] [-CustomBrowserDisplayName <String>] [-CustomBrowserPackageId <String>]
 [-DataBackupBlocked] [-DeployedAppCount <Int32>]
 [-DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>] [-Description <String>]
 [-DeviceComplianceRequired] [-DisableAppEncryptionIfDeviceEncryptionIsEnabled]
 [-DisableAppPinIfDevicePinIsSet] [-DisplayName <String>] [-EncryptAppData] [-FingerprintBlocked]
 [-Id <String>] [-IsAssigned] [-LastModifiedDateTime <DateTime>] [-ManagedBrowser <ManagedBrowserType>]
 [-ManagedBrowserToOpenLinksRequired] [-MaximumPinRetries <Int32>] [-MinimumPinLength <Int32>]
 [-MinimumRequiredAppVersion <String>] [-MinimumRequiredOSVersion <String>]
 [-MinimumRequiredPatchVersion <String>] [-MinimumWarningAppVersion <String>]
 [-MinimumWarningOSVersion <String>] [-MinimumWarningPatchVersion <String>]
 [-OrganizationalCredentialsRequired] [-PeriodBeforePinReset <TimeSpan>]
 [-PeriodOfflineBeforeAccessCheck <TimeSpan>] [-PeriodOfflineBeforeWipeIsEnforced <TimeSpan>]
 [-PeriodOnlineBeforeAccessCheck <TimeSpan>] [-PinCharacterSet <ManagedAppPinCharacterSet>] [-PinRequired]
 [-PrintBlocked] [-ResponseHeadersVariable <String>] [-SaveAsBlocked] [-ScreenCaptureBlocked]
 [-SimplePinBlocked] [-Version <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceAppManagementAndroidManagedAppProtection -AndroidManagedAppProtectionId <String>
 -BodyParameter <IMicrosoftGraphAndroidManagedAppProtection> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceAppManagementAndroidManagedAppProtection -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphAndroidManagedAppProtection> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceAppManagementAndroidManagedAppProtection -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-AllowedDataStorageLocations <ManagedAppDataStorageLocation[]>]
 [-AllowedInboundDataTransferSources <ManagedAppDataTransferLevel>]
 [-AllowedOutboundClipboardSharingLevel <ManagedAppClipboardSharingLevel>]
 [-AllowedOutboundDataTransferDestinations <ManagedAppDataTransferLevel>]
 [-Apps <IMicrosoftGraphManagedMobileApp[]>]
 [-Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>] [-ContactSyncBlocked]
 [-CreatedDateTime <DateTime>] [-CustomBrowserDisplayName <String>] [-CustomBrowserPackageId <String>]
 [-DataBackupBlocked] [-DeployedAppCount <Int32>]
 [-DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>] [-Description <String>]
 [-DeviceComplianceRequired] [-DisableAppEncryptionIfDeviceEncryptionIsEnabled]
 [-DisableAppPinIfDevicePinIsSet] [-DisplayName <String>] [-EncryptAppData] [-FingerprintBlocked]
 [-Id <String>] [-IsAssigned] [-LastModifiedDateTime <DateTime>] [-ManagedBrowser <ManagedBrowserType>]
 [-ManagedBrowserToOpenLinksRequired] [-MaximumPinRetries <Int32>] [-MinimumPinLength <Int32>]
 [-MinimumRequiredAppVersion <String>] [-MinimumRequiredOSVersion <String>]
 [-MinimumRequiredPatchVersion <String>] [-MinimumWarningAppVersion <String>]
 [-MinimumWarningOSVersion <String>] [-MinimumWarningPatchVersion <String>]
 [-OrganizationalCredentialsRequired] [-PeriodBeforePinReset <TimeSpan>]
 [-PeriodOfflineBeforeAccessCheck <TimeSpan>] [-PeriodOfflineBeforeWipeIsEnforced <TimeSpan>]
 [-PeriodOnlineBeforeAccessCheck <TimeSpan>] [-PinCharacterSet <ManagedAppPinCharacterSet>] [-PinRequired]
 [-PrintBlocked] [-ResponseHeadersVariable <String>] [-SaveAsBlocked] [-ScreenCaptureBlocked]
 [-SimplePinBlocked] [-Version <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a androidManagedAppProtection object.

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

### -AllowedDataStorageLocations
Data storage locations where a user may store managed data.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppDataStorageLocation[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedInboundDataTransferSources
Data can be transferred from/to these classes of apps

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppDataTransferLevel
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedOutboundClipboardSharingLevel
Represents the level to which the device's clipboard may be shared between apps

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppClipboardSharingLevel
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedOutboundDataTransferDestinations
Data can be transferred from/to these classes of apps

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppDataTransferLevel
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AndroidManagedAppProtectionId
The unique identifier of androidManagedAppProtection

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

### -Apps
List of apps to which the policy is deployed.
To construct, see NOTES section for APPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedMobileApp[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppPolicyAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Policy used to configure detailed management settings targeted to specific security groups and for a specified set of apps on an Android device
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedAppProtection
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContactSyncBlocked
Indicates whether contacts can be synced to the user's device.

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

### -CreatedDateTime
The date and time the policy was created.

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

### -CustomBrowserDisplayName
Friendly name of the preferred custom browser to open weblink on Android.
When this property is configured, ManagedBrowserToOpenLinksRequired should be true.

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

### -CustomBrowserPackageId
Unique identifier of the preferred custom browser to open weblink on Android.
When this property is configured, ManagedBrowserToOpenLinksRequired should be true.

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

### -DataBackupBlocked
Indicates whether the backup of a managed app's data is blocked.

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

### -DeployedAppCount
Count of apps to which the current policy is deployed.

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

### -DeploymentSummary
The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
To construct, see NOTES section for DEPLOYMENTSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicyDeploymentSummary
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The policy's description.

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

### -DeviceComplianceRequired
Indicates whether device compliance is required.

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

### -DisableAppEncryptionIfDeviceEncryptionIsEnabled
When this setting is enabled, app level encryption is disabled if device level encryption is enabled

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

### -DisableAppPinIfDevicePinIsSet
Indicates whether use of the app pin is required if the device pin is set.

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

### -DisplayName
Policy display name.

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

### -EncryptAppData
Indicates whether application data for managed apps should be encrypted

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

### -FingerprintBlocked
Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.

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

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Type: Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsAssigned
Indicates if the policy is deployed to any inclusion groups or not.

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

### -LastModifiedDateTime
Last time the policy was modified.

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

### -ManagedBrowser
Type of managed browser

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedBrowserType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedBrowserToOpenLinksRequired
Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)

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

### -MaximumPinRetries
Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.

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

### -MinimumPinLength
Minimum pin length required for an app-level pin if PinRequired is set to True

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

### -MinimumRequiredAppVersion
Versions less than the specified version will block the managed app from accessing company data.

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

### -MinimumRequiredOSVersion
Versions less than the specified version will block the managed app from accessing company data.

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

### -MinimumRequiredPatchVersion
Define the oldest required Android security patch level a user can have to gain secure access to the app.

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

### -MinimumWarningAppVersion
Versions less than the specified version will result in warning message on the managed app.

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

### -MinimumWarningOSVersion
Versions less than the specified version will result in warning message on the managed app from accessing company data.

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

### -MinimumWarningPatchVersion
Define the oldest recommended Android security patch level a user can have for secure access to the app.

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

### -OrganizationalCredentialsRequired
Indicates whether organizational credentials are required for app use.

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

### -PeriodBeforePinReset
TimePeriod before the all-level pin must be reset if PinRequired is set to True.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PeriodOfflineBeforeAccessCheck
The period after which access is checked when the device is not connected to the internet.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PeriodOfflineBeforeWipeIsEnforced
The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PeriodOnlineBeforeAccessCheck
The period after which access is checked when the device is connected to the internet.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PinCharacterSet
Character set which is to be used for a user's app PIN

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppPinCharacterSet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PinRequired
Indicates whether an app-level pin is required.

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

### -PrintBlocked
Indicates whether printing is allowed from managed apps.

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

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SaveAsBlocked
Indicates whether users may use the 'Save As' menu item to save a copy of protected files.

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

### -ScreenCaptureBlocked
Indicates whether a managed user can take screen captures of managed apps

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

### -SimplePinBlocked
Indicates whether simplePin is blocked.

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

### -Version
Version of the entity.

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

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedAppProtection

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedAppProtection

## NOTES

ALIASES

Update-MgDeviceAppMgtAndroidManagedAppProtection

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`APPS <IMicrosoftGraphManagedMobileApp[]>`: List of apps to which the policy is deployed.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Version <String>]`: Version of the entity.

`ASSIGNMENTS <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

`BODYPARAMETER <IMicrosoftGraphAndroidManagedAppProtection>`: Policy used to configure detailed management settings targeted to specific security groups and for a specified set of apps on an Android device
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
  - `[AllowedDataStorageLocations <ManagedAppDataStorageLocation[]>]`: Data storage locations where a user may store managed data.
  - `[AllowedInboundDataTransferSources <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
  - `[AllowedOutboundClipboardSharingLevel <ManagedAppClipboardSharingLevel?>]`: Represents the level to which the device's clipboard may be shared between apps
  - `[AllowedOutboundDataTransferDestinations <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
  - `[ContactSyncBlocked <Boolean?>]`: Indicates whether contacts can be synced to the user's device.
  - `[DataBackupBlocked <Boolean?>]`: Indicates whether the backup of a managed app's data is blocked.
  - `[DeviceComplianceRequired <Boolean?>]`: Indicates whether device compliance is required.
  - `[DisableAppPinIfDevicePinIsSet <Boolean?>]`: Indicates whether use of the app pin is required if the device pin is set.
  - `[FingerprintBlocked <Boolean?>]`: Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.
  - `[ManagedBrowser <ManagedBrowserType?>]`: Type of managed browser
  - `[ManagedBrowserToOpenLinksRequired <Boolean?>]`: Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)
  - `[MaximumPinRetries <Int32?>]`: Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.
  - `[MinimumPinLength <Int32?>]`: Minimum pin length required for an app-level pin if PinRequired is set to True
  - `[MinimumRequiredAppVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[MinimumRequiredOSVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[MinimumWarningAppVersion <String>]`: Versions less than the specified version will result in warning message on the managed app.
  - `[MinimumWarningOSVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data.
  - `[OrganizationalCredentialsRequired <Boolean?>]`: Indicates whether organizational credentials are required for app use.
  - `[PeriodBeforePinReset <TimeSpan?>]`: TimePeriod before the all-level pin must be reset if PinRequired is set to True.
  - `[PeriodOfflineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is not connected to the internet.
  - `[PeriodOfflineBeforeWipeIsEnforced <TimeSpan?>]`: The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.
  - `[PeriodOnlineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is connected to the internet.
  - `[PinCharacterSet <ManagedAppPinCharacterSet?>]`: Character set which is to be used for a user's app PIN
  - `[PinRequired <Boolean?>]`: Indicates whether an app-level pin is required.
  - `[PrintBlocked <Boolean?>]`: Indicates whether printing is allowed from managed apps.
  - `[SaveAsBlocked <Boolean?>]`: Indicates whether users may use the 'Save As' menu item to save a copy of protected files.
  - `[SimplePinBlocked <Boolean?>]`: Indicates whether simplePin is blocked.
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[Version <String>]`: Version of the entity.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Version <String>]`: Version of the entity.
  - `[CustomBrowserDisplayName <String>]`: Friendly name of the preferred custom browser to open weblink on Android. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.
  - `[CustomBrowserPackageId <String>]`: Unique identifier of the preferred custom browser to open weblink on Android. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.
  - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
  - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
    - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
      - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
      - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[DisplayName <String>]`: Not yet documented
    - `[LastRefreshTime <DateTime?>]`: Not yet documented
    - `[Version <String>]`: Version of the entity.
  - `[DisableAppEncryptionIfDeviceEncryptionIsEnabled <Boolean?>]`: When this setting is enabled, app level encryption is disabled if device level encryption is enabled
  - `[EncryptAppData <Boolean?>]`: Indicates whether application data for managed apps should be encrypted
  - `[MinimumRequiredPatchVersion <String>]`: Define the oldest required Android security patch level a user can have to gain secure access to the app.
  - `[MinimumWarningPatchVersion <String>]`: Define the oldest recommended Android security patch level a user can have for secure access to the app.
  - `[ScreenCaptureBlocked <Boolean?>]`: Indicates whether a managed user can take screen captures of managed apps

`DEPLOYMENTSUMMARY <IMicrosoftGraphManagedAppPolicyDeploymentSummary>`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
  - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
    - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: Not yet documented
  - `[LastRefreshTime <DateTime?>]`: Not yet documented
  - `[Version <String>]`: Version of the entity.

`INPUTOBJECT <IDevicesCorporateManagementIdentity>`: Identity Parameter
  - `[AndroidManagedAppProtectionId <String>]`: The unique identifier of androidManagedAppProtection
  - `[DefaultManagedAppProtectionId <String>]`: The unique identifier of defaultManagedAppProtection
  - `[DeviceCompliancePolicyStateId <String>]`: The unique identifier of deviceCompliancePolicyState
  - `[DeviceConfigurationStateId <String>]`: The unique identifier of deviceConfigurationState
  - `[DeviceInstallStateId <String>]`: The unique identifier of deviceInstallState
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DeviceManagementTroubleshootingEventId <String>]`: The unique identifier of deviceManagementTroubleshootingEvent
  - `[IosManagedAppProtectionId <String>]`: The unique identifier of iosManagedAppProtection
  - `[ManagedAppOperationId <String>]`: The unique identifier of managedAppOperation
  - `[ManagedAppPolicyId <String>]`: The unique identifier of managedAppPolicy
  - `[ManagedAppRegistrationId <String>]`: The unique identifier of managedAppRegistration
  - `[ManagedAppStatusId <String>]`: The unique identifier of managedAppStatus
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[ManagedDeviceMobileAppConfigurationAssignmentId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationAssignment
  - `[ManagedDeviceMobileAppConfigurationDeviceStatusId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationDeviceStatus
  - `[ManagedDeviceMobileAppConfigurationId <String>]`: The unique identifier of managedDeviceMobileAppConfiguration
  - `[ManagedDeviceMobileAppConfigurationUserStatusId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationUserStatus
  - `[ManagedEBookAssignmentId <String>]`: The unique identifier of managedEBookAssignment
  - `[ManagedEBookId <String>]`: The unique identifier of managedEBook
  - `[ManagedMobileAppId <String>]`: The unique identifier of managedMobileApp
  - `[MdmWindowsInformationProtectionPolicyId <String>]`: The unique identifier of mdmWindowsInformationProtectionPolicy
  - `[MobileAppAssignmentId <String>]`: The unique identifier of mobileAppAssignment
  - `[MobileAppCategoryId <String>]`: The unique identifier of mobileAppCategory
  - `[MobileAppContentFileId <String>]`: The unique identifier of mobileAppContentFile
  - `[MobileAppContentId <String>]`: The unique identifier of mobileAppContent
  - `[MobileAppId <String>]`: The unique identifier of mobileApp
  - `[MobileContainedAppId <String>]`: The unique identifier of mobileContainedApp
  - `[TargetedManagedAppConfigurationId <String>]`: The unique identifier of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: The unique identifier of targetedManagedAppPolicyAssignment
  - `[UserId <String>]`: The unique identifier of user
  - `[UserInstallStateSummaryId <String>]`: The unique identifier of userInstallStateSummary
  - `[VppTokenId <String>]`: The unique identifier of vppToken
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsInformationProtectionAppLockerFileId <String>]`: The unique identifier of windowsInformationProtectionAppLockerFile
  - `[WindowsInformationProtectionPolicyId <String>]`: The unique identifier of windowsInformationProtectionPolicy

## RELATED LINKS

