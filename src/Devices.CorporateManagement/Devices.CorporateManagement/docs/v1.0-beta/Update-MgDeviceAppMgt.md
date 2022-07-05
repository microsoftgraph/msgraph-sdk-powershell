---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgt
schema: 2.0.0
---

# Update-MgDeviceAppMgt

## SYNOPSIS
Update deviceAppManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceAppMgt [-AdditionalProperties <Hashtable>]
 [-AndroidManagedAppProtections <IMicrosoftGraphAndroidManagedAppProtection[]>]
 [-DefaultManagedAppProtections <IMicrosoftGraphDefaultManagedAppProtection[]>]
 [-DeviceAppManagementTasks <IMicrosoftGraphDeviceAppManagementTask[]>]
 [-EnterpriseCodeSigningCertificates <IMicrosoftGraphEnterpriseCodeSigningCertificate[]>] [-Id <String>]
 [-IosLobAppProvisioningConfigurations <IMicrosoftGraphIosLobAppProvisioningConfiguration[]>]
 [-IosManagedAppProtections <IMicrosoftGraphIosManagedAppProtection[]>]
 [-IsEnabledForMicrosoftStoreForBusiness] [-ManagedAppPolicies <IMicrosoftGraphManagedAppPolicy[]>]
 [-ManagedAppRegistrations <IMicrosoftGraphManagedAppRegistration[]>]
 [-ManagedAppStatuses <IMicrosoftGraphManagedAppStatus[]>]
 [-ManagedEBookCategories <IMicrosoftGraphManagedEBookCategory[]>]
 [-ManagedEBooks <IMicrosoftGraphManagedEBook[]>]
 [-MdmWindowsInformationProtectionPolicies <IMicrosoftGraphMdmWindowsInformationProtectionPolicy[]>]
 [-MicrosoftStoreForBusinessLanguage <String>]
 [-MicrosoftStoreForBusinessLastCompletedApplicationSyncTime <DateTime>]
 [-MicrosoftStoreForBusinessLastSuccessfulSyncDateTime <DateTime>]
 [-MicrosoftStoreForBusinessPortalSelection <MicrosoftStoreForBusinessPortalSelectionOptions>]
 [-MobileAppCategories <IMicrosoftGraphMobileAppCategory[]>]
 [-MobileAppConfigurations <IMicrosoftGraphManagedDeviceMobileAppConfiguration[]>]
 [-MobileApps <IMicrosoftGraphMobileApp[]>] [-PolicySets <IMicrosoftGraphPolicySet[]>]
 [-SideLoadingKeys <IMicrosoftGraphSideLoadingKey[]>]
 [-SymantecCodeSigningCertificate <IMicrosoftGraphSymantecCodeSigningCertificate>]
 [-TargetedManagedAppConfigurations <IMicrosoftGraphTargetedManagedAppConfiguration[]>]
 [-VppTokens <IMicrosoftGraphVppToken[]>]
 [-WdacSupplementalPolicies <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy[]>]
 [-WindowsInformationProtectionDeviceRegistrations <IMicrosoftGraphWindowsInformationProtectionDeviceRegistration[]>]
 [-WindowsInformationProtectionPolicies <IMicrosoftGraphWindowsInformationProtectionPolicy[]>]
 [-WindowsInformationProtectionWipeActions <IMicrosoftGraphWindowsInformationProtectionWipeAction[]>]
 [-WindowsManagedAppProtections <IMicrosoftGraphWindowsManagedAppProtection[]>]
 [-WindowsManagementApp <IMicrosoftGraphWindowsManagementApp>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceAppMgt -BodyParameter <IMicrosoftGraphDeviceAppManagement> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update deviceAppManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AndroidManagedAppProtections
Android managed app policies.
To construct, please use Get-Help -Online and see NOTES section for ANDROIDMANAGEDAPPPROTECTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedAppProtection[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Singleton entity that acts as a container for all device app management functionality.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAppManagement
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultManagedAppProtections
Default managed app policies.
To construct, please use Get-Help -Online and see NOTES section for DEFAULTMANAGEDAPPPROTECTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDefaultManagedAppProtection[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceAppManagementTasks
Device app management tasks.
To construct, please use Get-Help -Online and see NOTES section for DEVICEAPPMANAGEMENTTASKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAppManagementTask[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnterpriseCodeSigningCertificates
The Windows Enterprise Code Signing Certificate.
To construct, please use Get-Help -Online and see NOTES section for ENTERPRISECODESIGNINGCERTIFICATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEnterpriseCodeSigningCertificate[]
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IosLobAppProvisioningConfigurations
The IOS Lob App Provisioning Configurations.
To construct, please use Get-Help -Online and see NOTES section for IOSLOBAPPPROVISIONINGCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIosLobAppProvisioningConfiguration[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IosManagedAppProtections
iOS managed app policies.
To construct, please use Get-Help -Online and see NOTES section for IOSMANAGEDAPPPROTECTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIosManagedAppProtection[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsEnabledForMicrosoftStoreForBusiness
Whether the account is enabled for syncing applications from the Microsoft Store for Business.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedAppPolicies
Managed app policies.
To construct, please use Get-Help -Online and see NOTES section for MANAGEDAPPPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicy[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedAppRegistrations
The managed app registrations.
To construct, please use Get-Help -Online and see NOTES section for MANAGEDAPPREGISTRATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppRegistration[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedAppStatuses
The managed app statuses.
To construct, please use Get-Help -Online and see NOTES section for MANAGEDAPPSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppStatus[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedEBookCategories
The mobile eBook categories.
To construct, please use Get-Help -Online and see NOTES section for MANAGEDEBOOKCATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedEBookCategory[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedEBooks
The Managed eBook.
To construct, please use Get-Help -Online and see NOTES section for MANAGEDEBOOKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedEBook[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MdmWindowsInformationProtectionPolicies
Windows information protection for apps running on devices which are MDM enrolled.
To construct, please use Get-Help -Online and see NOTES section for MDMWINDOWSINFORMATIONPROTECTIONPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMdmWindowsInformationProtectionPolicy[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MicrosoftStoreForBusinessLanguage
The locale information used to sync applications from the Microsoft Store for Business.
Cultures that are specific to a country/region.
The names of these cultures follow RFC 4646 (Windows Vista and later).
The format is \<languagecode2\>-\<country/regioncode2\>, where \<languagecode2\> is a lowercase two-letter code derived from ISO 639-1 and \<country/regioncode2\> is an uppercase two-letter code derived from ISO 3166.
For example, en-US for English (United States) is a specific culture.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MicrosoftStoreForBusinessLastCompletedApplicationSyncTime
The last time an application sync from the Microsoft Store for Business was completed.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MicrosoftStoreForBusinessLastSuccessfulSyncDateTime
The last time the apps from the Microsoft Store for Business were synced successfully for the account.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MicrosoftStoreForBusinessPortalSelection
Portal to which admin syncs available Microsoft Store for Business apps.
This is available in the Intune Admin Console.

```yaml
Type: Microsoft.Graph.PowerShell.Support.MicrosoftStoreForBusinessPortalSelectionOptions
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileAppCategories
The mobile app categories.
To construct, please use Get-Help -Online and see NOTES section for MOBILEAPPCATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppCategory[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileAppConfigurations
The Managed Device Mobile Application Configurations.
To construct, please use Get-Help -Online and see NOTES section for MOBILEAPPCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfiguration[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileApps
The mobile apps.
To construct, please use Get-Help -Online and see NOTES section for MOBILEAPPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp[]
Parameter Sets: UpdateExpanded
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

### -PolicySets
The PolicySet of Policies and Applications
To construct, please use Get-Help -Online and see NOTES section for POLICYSETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPolicySet[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SideLoadingKeys
Side Loading Keys that are required for the Windows 8 and 8.1 Apps installation.
To construct, please use Get-Help -Online and see NOTES section for SIDELOADINGKEYS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSideLoadingKey[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SymantecCodeSigningCertificate
symantecCodeSigningCertificate
To construct, please use Get-Help -Online and see NOTES section for SYMANTECCODESIGNINGCERTIFICATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSymantecCodeSigningCertificate
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetedManagedAppConfigurations
Targeted managed app configurations.
To construct, please use Get-Help -Online and see NOTES section for TARGETEDMANAGEDAPPCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppConfiguration[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VppTokens
List of Vpp tokens for this organization.
To construct, please use Get-Help -Online and see NOTES section for VPPTOKENS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVppToken[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WdacSupplementalPolicies
The collection of Windows Defender Application Control Supplemental Policies.
To construct, please use Get-Help -Online and see NOTES section for WDACSUPPLEMENTALPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowsInformationProtectionDeviceRegistrations
Windows information protection device registrations that are not MDM enrolled.
To construct, please use Get-Help -Online and see NOTES section for WINDOWSINFORMATIONPROTECTIONDEVICEREGISTRATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionDeviceRegistration[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowsInformationProtectionPolicies
Windows information protection for apps running on devices which are not MDM enrolled.
To construct, please use Get-Help -Online and see NOTES section for WINDOWSINFORMATIONPROTECTIONPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionPolicy[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowsInformationProtectionWipeActions
Windows information protection wipe actions.
To construct, please use Get-Help -Online and see NOTES section for WINDOWSINFORMATIONPROTECTIONWIPEACTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionWipeAction[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowsManagedAppProtections
Windows managed app policies.
To construct, please use Get-Help -Online and see NOTES section for WINDOWSMANAGEDAPPPROTECTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsManagedAppProtection[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowsManagementApp
Windows management app entity.
To construct, please use Get-Help -Online and see NOTES section for WINDOWSMANAGEMENTAPP properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsManagementApp
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAppManagement

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgDeviceAppManagement

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ANDROIDMANAGEDAPPPROTECTIONS <IMicrosoftGraphAndroidManagedAppProtection[]>: Android managed app policies.
  - `[AppGroupType <TargetedManagedAppGroupType?>]`: Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps
  - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    - `[Id <String>]`: 
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
  - `[TargetedAppManagementLevels <AppManagementLevel?>]`: Management levels for apps
  - `[AllowedDataIngestionLocations <ManagedAppDataIngestionLocation[]>]`: Data storage locations where a user may store managed data.
  - `[AllowedDataStorageLocations <ManagedAppDataStorageLocation[]>]`: Data storage locations where a user may store managed data.
  - `[AllowedInboundDataTransferSources <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
  - `[AllowedOutboundClipboardSharingExceptionLength <Int32?>]`: Specify the number of characters that may be cut or copied from Org data and accounts to any application. This setting overrides the AllowedOutboundClipboardSharingLevel restriction. Default value of '0' means no exception is allowed.
  - `[AllowedOutboundClipboardSharingLevel <ManagedAppClipboardSharingLevel?>]`: Represents the level to which the device's clipboard may be shared between apps
  - `[AllowedOutboundDataTransferDestinations <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
  - `[AppActionIfDeviceComplianceRequired <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfMaximumPinRetriesExceeded <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfUnableToAuthenticateUser <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[BlockDataIngestionIntoOrganizationDocuments <Boolean?>]`: Indicates whether a user can bring data into org documents.
  - `[ContactSyncBlocked <Boolean?>]`: Indicates whether contacts can be synced to the user's device.
  - `[DataBackupBlocked <Boolean?>]`: Indicates whether the backup of a managed app's data is blocked.
  - `[DeviceComplianceRequired <Boolean?>]`: Indicates whether device compliance is required.
  - `[DialerRestrictionLevel <ManagedAppPhoneNumberRedirectLevel?>]`: The classes of apps that are allowed to click-to-open a phone number, for making phone calls or sending text messages.
  - `[DisableAppPinIfDevicePinIsSet <Boolean?>]`: Indicates whether use of the app pin is required if the device pin is set.
  - `[FingerprintBlocked <Boolean?>]`: Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.
  - `[GracePeriodToBlockAppsDuringOffClockHours <TimeSpan?>]`: A grace period before blocking app access during off clock hours.
  - `[ManagedBrowser <ManagedBrowserType?>]`: Type of managed browser
  - `[ManagedBrowserToOpenLinksRequired <Boolean?>]`: Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)
  - `[MaximumAllowedDeviceThreatLevel <ManagedAppDeviceThreatLevel?>]`: The maxium threat level allowed for an app to be compliant.
  - `[MaximumPinRetries <Int32?>]`: Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.
  - `[MaximumRequiredOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
  - `[MaximumWarningOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
  - `[MaximumWipeOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
  - `[MinimumPinLength <Int32?>]`: Minimum pin length required for an app-level pin if PinRequired is set to True
  - `[MinimumRequiredAppVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[MinimumRequiredOSVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[MinimumWarningAppVersion <String>]`: Versions less than the specified version will result in warning message on the managed app.
  - `[MinimumWarningOSVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data.
  - `[MinimumWipeAppVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
  - `[MinimumWipeOSVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
  - `[MobileThreatDefenseRemediationAction <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[NotificationRestriction <ManagedAppNotificationRestriction?>]`: Restrict managed app notification
  - `[OrganizationalCredentialsRequired <Boolean?>]`: Indicates whether organizational credentials are required for app use.
  - `[PeriodBeforePinReset <TimeSpan?>]`: TimePeriod before the all-level pin must be reset if PinRequired is set to True.
  - `[PeriodOfflineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is not connected to the internet.
  - `[PeriodOfflineBeforeWipeIsEnforced <TimeSpan?>]`: The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.
  - `[PeriodOnlineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is connected to the internet.
  - `[PinCharacterSet <ManagedAppPinCharacterSet?>]`: Character set which is to be used for a user's app PIN
  - `[PinRequired <Boolean?>]`: Indicates whether an app-level pin is required.
  - `[PinRequiredInsteadOfBiometricTimeout <TimeSpan?>]`: Timeout in minutes for an app pin instead of non biometrics passcode
  - `[PreviousPinBlockCount <Int32?>]`: Requires a pin to be unique from the number specified in this property.
  - `[PrintBlocked <Boolean?>]`: Indicates whether printing is allowed from managed apps.
  - `[SaveAsBlocked <Boolean?>]`: Indicates whether users may use the 'Save As' menu item to save a copy of protected files.
  - `[SimplePinBlocked <Boolean?>]`: Indicates whether simplePin is blocked.
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.
  - `[Id <String>]`: 
  - `[AllowedAndroidDeviceManufacturers <String>]`: Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work.
  - `[AllowedAndroidDeviceModels <String[]>]`: List of device models allowed, as a string, for the managed app to work.
  - `[AppActionIfAndroidDeviceManufacturerNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfAndroidDeviceModelNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfAndroidSafetyNetAppsVerificationFailed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfAndroidSafetyNetDeviceAttestationFailed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfDeviceLockNotSet <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfDevicePasscodeComplexityLessThanHigh <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfDevicePasscodeComplexityLessThanLow <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfDevicePasscodeComplexityLessThanMedium <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[ApprovedKeyboards <IMicrosoftGraphKeyValuePair[]>]`: If Keyboard Restriction is enabled, only keyboards in this approved list will be allowed. A key should be Android package id for a keyboard and value should be a friendly name
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[Id <String>]`: 
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Version <String>]`: Version of the entity.
  - `[BiometricAuthenticationBlocked <Boolean?>]`: Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True.
  - `[BlockAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.
  - `[ConnectToVpnOnLaunch <Boolean?>]`: Whether the app should connect to the configured VPN on launch.
  - `[CustomBrowserDisplayName <String>]`: Friendly name of the preferred custom browser to open weblink on Android.
  - `[CustomBrowserPackageId <String>]`: Unique identifier of a custom browser to open weblink on Android.
  - `[CustomDialerAppDisplayName <String>]`: Friendly name of a custom dialer app to click-to-open a phone number on Android.
  - `[CustomDialerAppPackageId <String>]`: PackageId of a custom dialer app to click-to-open a phone number on Android.
  - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
  - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
    - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
      - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
      - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[DisplayName <String>]`: Not yet documented
    - `[LastRefreshTime <DateTime?>]`: Not yet documented
    - `[Version <String>]`: Version of the entity.
  - `[DeviceLockRequired <Boolean?>]`: Defines if any kind of lock must be required on android device
  - `[DisableAppEncryptionIfDeviceEncryptionIsEnabled <Boolean?>]`: When this setting is enabled, app level encryption is disabled if device level encryption is enabled
  - `[EncryptAppData <Boolean?>]`: Indicates whether application data for managed apps should be encrypted
  - `[ExemptedAppPackages <IMicrosoftGraphKeyValuePair[]>]`: App packages in this list will be exempt from the policy and will be able to receive data from managed apps.
  - `[FingerprintAndBiometricEnabled <Boolean?>]`: If null, this setting will be ignored. If false both fingerprints and biometrics will not be enabled. If true, both fingerprints and biometrics will be enabled.
  - `[KeyboardsRestricted <Boolean?>]`: Indicates if keyboard restriction is enabled. If enabled list of approved keyboards must be provided as well.
  - `[MinimumRequiredCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or app access will be blocked
  - `[MinimumRequiredPatchVersion <String>]`: Define the oldest required Android security patch level a user can have to gain secure access to the app.
  - `[MinimumWarningCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or the user will receive a warning
  - `[MinimumWarningPatchVersion <String>]`: Define the oldest recommended Android security patch level a user can have for secure access to the app.
  - `[MinimumWipeCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped
  - `[MinimumWipePatchVersion <String>]`: Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data.
  - `[RequireClass3Biometrics <Boolean?>]`: Require user to apply Class 3 Biometrics on their Android device.
  - `[RequirePinAfterBiometricChange <Boolean?>]`: A PIN prompt will override biometric prompts if class 3 biometrics are updated on the device.
  - `[RequiredAndroidSafetyNetAppsVerificationType <AndroidManagedAppSafetyNetAppsVerificationType?>]`: An admin enforced Android SafetyNet Device Attestation requirement on a managed app.
  - `[RequiredAndroidSafetyNetDeviceAttestationType <AndroidManagedAppSafetyNetDeviceAttestationType?>]`: An admin enforced Android SafetyNet Device Attestation requirement on a managed app.
  - `[RequiredAndroidSafetyNetEvaluationType <AndroidManagedAppSafetyNetEvaluationType?>]`: An admin enforced Android SafetyNet evaluation type requirement on a managed app.
  - `[ScreenCaptureBlocked <Boolean?>]`: Indicates whether a managed user can take screen captures of managed apps
  - `[WarnAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning
  - `[WipeAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped

BODYPARAMETER <IMicrosoftGraphDeviceAppManagement>: Singleton entity that acts as a container for all device app management functionality.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AndroidManagedAppProtections <IMicrosoftGraphAndroidManagedAppProtection[]>]`: Android managed app policies.
    - `[AppGroupType <TargetedManagedAppGroupType?>]`: Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps
    - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
      - `[Id <String>]`: 
      - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
      - `[SourceId <String>]`: Identifier for resource used for deployment to a group
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
    - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
    - `[TargetedAppManagementLevels <AppManagementLevel?>]`: Management levels for apps
    - `[AllowedDataIngestionLocations <ManagedAppDataIngestionLocation[]>]`: Data storage locations where a user may store managed data.
    - `[AllowedDataStorageLocations <ManagedAppDataStorageLocation[]>]`: Data storage locations where a user may store managed data.
    - `[AllowedInboundDataTransferSources <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
    - `[AllowedOutboundClipboardSharingExceptionLength <Int32?>]`: Specify the number of characters that may be cut or copied from Org data and accounts to any application. This setting overrides the AllowedOutboundClipboardSharingLevel restriction. Default value of '0' means no exception is allowed.
    - `[AllowedOutboundClipboardSharingLevel <ManagedAppClipboardSharingLevel?>]`: Represents the level to which the device's clipboard may be shared between apps
    - `[AllowedOutboundDataTransferDestinations <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
    - `[AppActionIfDeviceComplianceRequired <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfMaximumPinRetriesExceeded <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfUnableToAuthenticateUser <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[BlockDataIngestionIntoOrganizationDocuments <Boolean?>]`: Indicates whether a user can bring data into org documents.
    - `[ContactSyncBlocked <Boolean?>]`: Indicates whether contacts can be synced to the user's device.
    - `[DataBackupBlocked <Boolean?>]`: Indicates whether the backup of a managed app's data is blocked.
    - `[DeviceComplianceRequired <Boolean?>]`: Indicates whether device compliance is required.
    - `[DialerRestrictionLevel <ManagedAppPhoneNumberRedirectLevel?>]`: The classes of apps that are allowed to click-to-open a phone number, for making phone calls or sending text messages.
    - `[DisableAppPinIfDevicePinIsSet <Boolean?>]`: Indicates whether use of the app pin is required if the device pin is set.
    - `[FingerprintBlocked <Boolean?>]`: Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.
    - `[GracePeriodToBlockAppsDuringOffClockHours <TimeSpan?>]`: A grace period before blocking app access during off clock hours.
    - `[ManagedBrowser <ManagedBrowserType?>]`: Type of managed browser
    - `[ManagedBrowserToOpenLinksRequired <Boolean?>]`: Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)
    - `[MaximumAllowedDeviceThreatLevel <ManagedAppDeviceThreatLevel?>]`: The maxium threat level allowed for an app to be compliant.
    - `[MaximumPinRetries <Int32?>]`: Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.
    - `[MaximumRequiredOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
    - `[MaximumWarningOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
    - `[MaximumWipeOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
    - `[MinimumPinLength <Int32?>]`: Minimum pin length required for an app-level pin if PinRequired is set to True
    - `[MinimumRequiredAppVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
    - `[MinimumRequiredOSVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
    - `[MinimumWarningAppVersion <String>]`: Versions less than the specified version will result in warning message on the managed app.
    - `[MinimumWarningOSVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data.
    - `[MinimumWipeAppVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
    - `[MinimumWipeOSVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
    - `[MobileThreatDefenseRemediationAction <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[NotificationRestriction <ManagedAppNotificationRestriction?>]`: Restrict managed app notification
    - `[OrganizationalCredentialsRequired <Boolean?>]`: Indicates whether organizational credentials are required for app use.
    - `[PeriodBeforePinReset <TimeSpan?>]`: TimePeriod before the all-level pin must be reset if PinRequired is set to True.
    - `[PeriodOfflineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is not connected to the internet.
    - `[PeriodOfflineBeforeWipeIsEnforced <TimeSpan?>]`: The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.
    - `[PeriodOnlineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is connected to the internet.
    - `[PinCharacterSet <ManagedAppPinCharacterSet?>]`: Character set which is to be used for a user's app PIN
    - `[PinRequired <Boolean?>]`: Indicates whether an app-level pin is required.
    - `[PinRequiredInsteadOfBiometricTimeout <TimeSpan?>]`: Timeout in minutes for an app pin instead of non biometrics passcode
    - `[PreviousPinBlockCount <Int32?>]`: Requires a pin to be unique from the number specified in this property.
    - `[PrintBlocked <Boolean?>]`: Indicates whether printing is allowed from managed apps.
    - `[SaveAsBlocked <Boolean?>]`: Indicates whether users may use the 'Save As' menu item to save a copy of protected files.
    - `[SimplePinBlocked <Boolean?>]`: Indicates whether simplePin is blocked.
    - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
    - `[Description <String>]`: The policy's description.
    - `[DisplayName <String>]`: Policy display name.
    - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Version <String>]`: Version of the entity.
    - `[Id <String>]`: 
    - `[AllowedAndroidDeviceManufacturers <String>]`: Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work.
    - `[AllowedAndroidDeviceModels <String[]>]`: List of device models allowed, as a string, for the managed app to work.
    - `[AppActionIfAndroidDeviceManufacturerNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfAndroidDeviceModelNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfAndroidSafetyNetAppsVerificationFailed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfAndroidSafetyNetDeviceAttestationFailed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfDeviceLockNotSet <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfDevicePasscodeComplexityLessThanHigh <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfDevicePasscodeComplexityLessThanLow <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfDevicePasscodeComplexityLessThanMedium <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[ApprovedKeyboards <IMicrosoftGraphKeyValuePair[]>]`: If Keyboard Restriction is enabled, only keyboards in this approved list will be allowed. A key should be Android package id for a keyboard and value should be a friendly name
      - `[Name <String>]`: Name for this key-value pair
      - `[Value <String>]`: Value for this key-value pair
    - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
      - `[Id <String>]`: 
      - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Version <String>]`: Version of the entity.
    - `[BiometricAuthenticationBlocked <Boolean?>]`: Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True.
    - `[BlockAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.
    - `[ConnectToVpnOnLaunch <Boolean?>]`: Whether the app should connect to the configured VPN on launch.
    - `[CustomBrowserDisplayName <String>]`: Friendly name of the preferred custom browser to open weblink on Android.
    - `[CustomBrowserPackageId <String>]`: Unique identifier of a custom browser to open weblink on Android.
    - `[CustomDialerAppDisplayName <String>]`: Friendly name of a custom dialer app to click-to-open a phone number on Android.
    - `[CustomDialerAppPackageId <String>]`: PackageId of a custom dialer app to click-to-open a phone number on Android.
    - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
    - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
      - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
        - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
        - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[DisplayName <String>]`: Not yet documented
      - `[LastRefreshTime <DateTime?>]`: Not yet documented
      - `[Version <String>]`: Version of the entity.
    - `[DeviceLockRequired <Boolean?>]`: Defines if any kind of lock must be required on android device
    - `[DisableAppEncryptionIfDeviceEncryptionIsEnabled <Boolean?>]`: When this setting is enabled, app level encryption is disabled if device level encryption is enabled
    - `[EncryptAppData <Boolean?>]`: Indicates whether application data for managed apps should be encrypted
    - `[ExemptedAppPackages <IMicrosoftGraphKeyValuePair[]>]`: App packages in this list will be exempt from the policy and will be able to receive data from managed apps.
    - `[FingerprintAndBiometricEnabled <Boolean?>]`: If null, this setting will be ignored. If false both fingerprints and biometrics will not be enabled. If true, both fingerprints and biometrics will be enabled.
    - `[KeyboardsRestricted <Boolean?>]`: Indicates if keyboard restriction is enabled. If enabled list of approved keyboards must be provided as well.
    - `[MinimumRequiredCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or app access will be blocked
    - `[MinimumRequiredPatchVersion <String>]`: Define the oldest required Android security patch level a user can have to gain secure access to the app.
    - `[MinimumWarningCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or the user will receive a warning
    - `[MinimumWarningPatchVersion <String>]`: Define the oldest recommended Android security patch level a user can have for secure access to the app.
    - `[MinimumWipeCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped
    - `[MinimumWipePatchVersion <String>]`: Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data.
    - `[RequireClass3Biometrics <Boolean?>]`: Require user to apply Class 3 Biometrics on their Android device.
    - `[RequirePinAfterBiometricChange <Boolean?>]`: A PIN prompt will override biometric prompts if class 3 biometrics are updated on the device.
    - `[RequiredAndroidSafetyNetAppsVerificationType <AndroidManagedAppSafetyNetAppsVerificationType?>]`: An admin enforced Android SafetyNet Device Attestation requirement on a managed app.
    - `[RequiredAndroidSafetyNetDeviceAttestationType <AndroidManagedAppSafetyNetDeviceAttestationType?>]`: An admin enforced Android SafetyNet Device Attestation requirement on a managed app.
    - `[RequiredAndroidSafetyNetEvaluationType <AndroidManagedAppSafetyNetEvaluationType?>]`: An admin enforced Android SafetyNet evaluation type requirement on a managed app.
    - `[ScreenCaptureBlocked <Boolean?>]`: Indicates whether a managed user can take screen captures of managed apps
    - `[WarnAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning
    - `[WipeAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped
  - `[DefaultManagedAppProtections <IMicrosoftGraphDefaultManagedAppProtection[]>]`: Default managed app policies.
    - `[AllowedDataIngestionLocations <ManagedAppDataIngestionLocation[]>]`: Data storage locations where a user may store managed data.
    - `[AllowedDataStorageLocations <ManagedAppDataStorageLocation[]>]`: Data storage locations where a user may store managed data.
    - `[AllowedInboundDataTransferSources <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
    - `[AllowedOutboundClipboardSharingExceptionLength <Int32?>]`: Specify the number of characters that may be cut or copied from Org data and accounts to any application. This setting overrides the AllowedOutboundClipboardSharingLevel restriction. Default value of '0' means no exception is allowed.
    - `[AllowedOutboundClipboardSharingLevel <ManagedAppClipboardSharingLevel?>]`: Represents the level to which the device's clipboard may be shared between apps
    - `[AllowedOutboundDataTransferDestinations <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
    - `[AppActionIfDeviceComplianceRequired <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfMaximumPinRetriesExceeded <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfUnableToAuthenticateUser <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[BlockDataIngestionIntoOrganizationDocuments <Boolean?>]`: Indicates whether a user can bring data into org documents.
    - `[ContactSyncBlocked <Boolean?>]`: Indicates whether contacts can be synced to the user's device.
    - `[DataBackupBlocked <Boolean?>]`: Indicates whether the backup of a managed app's data is blocked.
    - `[DeviceComplianceRequired <Boolean?>]`: Indicates whether device compliance is required.
    - `[DialerRestrictionLevel <ManagedAppPhoneNumberRedirectLevel?>]`: The classes of apps that are allowed to click-to-open a phone number, for making phone calls or sending text messages.
    - `[DisableAppPinIfDevicePinIsSet <Boolean?>]`: Indicates whether use of the app pin is required if the device pin is set.
    - `[FingerprintBlocked <Boolean?>]`: Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.
    - `[GracePeriodToBlockAppsDuringOffClockHours <TimeSpan?>]`: A grace period before blocking app access during off clock hours.
    - `[ManagedBrowser <ManagedBrowserType?>]`: Type of managed browser
    - `[ManagedBrowserToOpenLinksRequired <Boolean?>]`: Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)
    - `[MaximumAllowedDeviceThreatLevel <ManagedAppDeviceThreatLevel?>]`: The maxium threat level allowed for an app to be compliant.
    - `[MaximumPinRetries <Int32?>]`: Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.
    - `[MaximumRequiredOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
    - `[MaximumWarningOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
    - `[MaximumWipeOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
    - `[MinimumPinLength <Int32?>]`: Minimum pin length required for an app-level pin if PinRequired is set to True
    - `[MinimumRequiredAppVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
    - `[MinimumRequiredOSVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
    - `[MinimumWarningAppVersion <String>]`: Versions less than the specified version will result in warning message on the managed app.
    - `[MinimumWarningOSVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data.
    - `[MinimumWipeAppVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
    - `[MinimumWipeOSVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
    - `[MobileThreatDefenseRemediationAction <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[NotificationRestriction <ManagedAppNotificationRestriction?>]`: Restrict managed app notification
    - `[OrganizationalCredentialsRequired <Boolean?>]`: Indicates whether organizational credentials are required for app use.
    - `[PeriodBeforePinReset <TimeSpan?>]`: TimePeriod before the all-level pin must be reset if PinRequired is set to True.
    - `[PeriodOfflineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is not connected to the internet.
    - `[PeriodOfflineBeforeWipeIsEnforced <TimeSpan?>]`: The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.
    - `[PeriodOnlineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is connected to the internet.
    - `[PinCharacterSet <ManagedAppPinCharacterSet?>]`: Character set which is to be used for a user's app PIN
    - `[PinRequired <Boolean?>]`: Indicates whether an app-level pin is required.
    - `[PinRequiredInsteadOfBiometricTimeout <TimeSpan?>]`: Timeout in minutes for an app pin instead of non biometrics passcode
    - `[PreviousPinBlockCount <Int32?>]`: Requires a pin to be unique from the number specified in this property.
    - `[PrintBlocked <Boolean?>]`: Indicates whether printing is allowed from managed apps.
    - `[SaveAsBlocked <Boolean?>]`: Indicates whether users may use the 'Save As' menu item to save a copy of protected files.
    - `[SimplePinBlocked <Boolean?>]`: Indicates whether simplePin is blocked.
    - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
    - `[Description <String>]`: The policy's description.
    - `[DisplayName <String>]`: Policy display name.
    - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Version <String>]`: Version of the entity.
    - `[Id <String>]`: 
    - `[AllowedAndroidDeviceManufacturers <String>]`: Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work. (Android only)
    - `[AllowedAndroidDeviceModels <String[]>]`: List of device models allowed, as a string, for the managed app to work. (Android Only)
    - `[AllowedIosDeviceModels <String>]`: Semicolon seperated list of device models allowed, as a string, for the managed app to work. (iOS Only)
    - `[AppActionIfAndroidDeviceManufacturerNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfAndroidDeviceModelNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfAndroidSafetyNetAppsVerificationFailed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfAndroidSafetyNetDeviceAttestationFailed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfDeviceLockNotSet <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfDevicePasscodeComplexityLessThanHigh <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfDevicePasscodeComplexityLessThanLow <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfDevicePasscodeComplexityLessThanMedium <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfIosDeviceModelNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppDataEncryptionType <ManagedAppDataEncryptionType?>]`: Represents the level to which app data is encrypted for managed apps
    - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[BiometricAuthenticationBlocked <Boolean?>]`: Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True. (Android Only)
    - `[BlockAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.
    - `[ConnectToVpnOnLaunch <Boolean?>]`: Whether the app should connect to the configured VPN on launch (Android only).
    - `[CustomBrowserDisplayName <String>]`: Friendly name of the preferred custom browser to open weblink on Android. (Android only)
    - `[CustomBrowserPackageId <String>]`: Unique identifier of a custom browser to open weblink on Android. (Android only)
    - `[CustomBrowserProtocol <String>]`: A custom browser protocol to open weblink on iOS. (iOS only)
    - `[CustomDialerAppDisplayName <String>]`: Friendly name of a custom dialer app to click-to-open a phone number on Android.
    - `[CustomDialerAppPackageId <String>]`: PackageId of a custom dialer app to click-to-open a phone number on Android.
    - `[CustomDialerAppProtocol <String>]`: Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.
    - `[CustomSettings <IMicrosoftGraphKeyValuePair[]>]`: A set of string key and string value pairs to be sent to the affected users, unalterned by this service
    - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
    - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    - `[DeviceLockRequired <Boolean?>]`: Defines if any kind of lock must be required on device. (android only)
    - `[DisableAppEncryptionIfDeviceEncryptionIsEnabled <Boolean?>]`: When this setting is enabled, app level encryption is disabled if device level encryption is enabled. (Android only)
    - `[DisableProtectionOfManagedOutboundOpenInData <Boolean?>]`: Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps. (iOS Only)
    - `[EncryptAppData <Boolean?>]`: Indicates whether managed-app data should be encrypted. (Android only)
    - `[ExemptedAppPackages <IMicrosoftGraphKeyValuePair[]>]`: Android App packages in this list will be exempt from the policy and will be able to receive data from managed apps. (Android only)
    - `[ExemptedAppProtocols <IMicrosoftGraphKeyValuePair[]>]`: iOS Apps in this list will be exempt from the policy and will be able to receive data from managed apps. (iOS Only)
    - `[FaceIdBlocked <Boolean?>]`: Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True. (iOS Only)
    - `[FilterOpenInToOnlyManagedApps <Boolean?>]`: Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False. (iOS Only)
    - `[FingerprintAndBiometricEnabled <Boolean?>]`: Indicate to the client to enable both biometrics and fingerprints for the app.
    - `[MinimumRequiredCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or app access will be blocked
    - `[MinimumRequiredPatchVersion <String>]`: Define the oldest required Android security patch level a user can have to gain secure access to the app. (Android only)
    - `[MinimumRequiredSdkVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data. (iOS Only)
    - `[MinimumWarningCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or the user will receive a warning
    - `[MinimumWarningPatchVersion <String>]`: Define the oldest recommended Android security patch level a user can have for secure access to the app. (Android only)
    - `[MinimumWipeCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped
    - `[MinimumWipePatchVersion <String>]`: Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data. (Android only)
    - `[MinimumWipeSdkVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
    - `[ProtectInboundDataFromUnknownSources <Boolean?>]`: Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps. (iOS Only)
    - `[RequireClass3Biometrics <Boolean?>]`: Require user to apply Class 3 Biometrics on their Android device.
    - `[RequirePinAfterBiometricChange <Boolean?>]`: A PIN prompt will override biometric prompts if class 3 biometrics are updated on the device.
    - `[RequiredAndroidSafetyNetAppsVerificationType <AndroidManagedAppSafetyNetAppsVerificationType?>]`: An admin enforced Android SafetyNet Device Attestation requirement on a managed app.
    - `[RequiredAndroidSafetyNetDeviceAttestationType <AndroidManagedAppSafetyNetDeviceAttestationType?>]`: An admin enforced Android SafetyNet Device Attestation requirement on a managed app.
    - `[RequiredAndroidSafetyNetEvaluationType <AndroidManagedAppSafetyNetEvaluationType?>]`: An admin enforced Android SafetyNet evaluation type requirement on a managed app.
    - `[ScreenCaptureBlocked <Boolean?>]`: Indicates whether screen capture is blocked. (Android only)
    - `[ThirdPartyKeyboardsBlocked <Boolean?>]`: Defines if third party keyboards are allowed while accessing a managed app. (iOS Only)
    - `[WarnAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning
    - `[WipeAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped
  - `[DeviceAppManagementTasks <IMicrosoftGraphDeviceAppManagementTask[]>]`: Device app management tasks.
    - `[Id <String>]`: 
    - `[AssignedTo <String>]`: The name or email of the admin this task is assigned to.
    - `[Category <DeviceAppManagementTaskCategory?>]`: Device app management task category.
    - `[CreatedDateTime <DateTime?>]`: The created date.
    - `[Creator <String>]`: The email address of the creator.
    - `[CreatorNotes <String>]`: Notes from the creator.
    - `[Description <String>]`: The description.
    - `[DisplayName <String>]`: The name.
    - `[DueDateTime <DateTime?>]`: The due date.
    - `[Priority <DeviceAppManagementTaskPriority?>]`: Device app management task priority.
    - `[Status <DeviceAppManagementTaskStatus?>]`: Device app management task status.
  - `[EnterpriseCodeSigningCertificates <IMicrosoftGraphEnterpriseCodeSigningCertificate[]>]`: The Windows Enterprise Code Signing Certificate.
    - `[Id <String>]`: 
    - `[Content <Byte[]>]`: The Windows Enterprise Code-Signing Certificate in the raw data format.
    - `[ExpirationDateTime <DateTime?>]`: The Cert Expiration Date.
    - `[Issuer <String>]`: The Issuer value for the cert.
    - `[IssuerName <String>]`: The Issuer Name for the cert.
    - `[Status <String>]`: certificateStatus
    - `[Subject <String>]`: The Subject Value for the cert.
    - `[SubjectName <String>]`: The Subject Name for the cert.
    - `[UploadDateTime <DateTime?>]`: The date time of CodeSigning Cert when it is uploaded.
  - `[IosLobAppProvisioningConfigurations <IMicrosoftGraphIosLobAppProvisioningConfiguration[]>]`: The IOS Lob App Provisioning Configurations.
    - `[Id <String>]`: 
    - `[Assignments <IMicrosoftGraphIosLobAppProvisioningConfigurationAssignment[]>]`: The associated group assignments for IosLobAppProvisioningConfiguration.
      - `[Id <String>]`: 
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
    - `[Description <String>]`: Admin provided description of the Device Configuration.
    - `[DeviceStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus[]>]`: The list of device installation states for this mobile app configuration.
      - `[Id <String>]`: 
      - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
      - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
      - `[DeviceModel <String>]`: The device model that is being reported
      - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
      - `[Platform <Int32?>]`: Platform of the device that is being reported
      - `[Status <String>]`: complianceStatus
      - `[UserName <String>]`: The User Name that is being reported
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[DisplayName <String>]`: Admin provided name of the device configuration.
    - `[ExpirationDateTime <DateTime?>]`: Optional profile expiration date and time.
    - `[GroupAssignments <IMicrosoftGraphMobileAppProvisioningConfigGroupAssignment[]>]`: The associated group assignments.
      - `[Id <String>]`: 
      - `[TargetGroupId <String>]`: The ID of the AAD group in which the app provisioning configuration is being targeted.
    - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
    - `[Payload <Byte[]>]`: Payload. (UTF8 encoded byte array)
    - `[PayloadFileName <String>]`: Payload file name (.mobileprovision
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this iOS LOB app provisioning configuration entity.
    - `[UserStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>]`: The list of user installation states for this mobile app configuration.
      - `[Id <String>]`: 
      - `[DevicesCount <Int32?>]`: Devices count for that user.
      - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
      - `[Status <String>]`: complianceStatus
      - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[Version <Int32?>]`: Version of the device configuration.
  - `[IosManagedAppProtections <IMicrosoftGraphIosManagedAppProtection[]>]`: iOS managed app policies.
    - `[AppGroupType <TargetedManagedAppGroupType?>]`: Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps
    - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
    - `[TargetedAppManagementLevels <AppManagementLevel?>]`: Management levels for apps
    - `[AllowedDataIngestionLocations <ManagedAppDataIngestionLocation[]>]`: Data storage locations where a user may store managed data.
    - `[AllowedDataStorageLocations <ManagedAppDataStorageLocation[]>]`: Data storage locations where a user may store managed data.
    - `[AllowedInboundDataTransferSources <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
    - `[AllowedOutboundClipboardSharingExceptionLength <Int32?>]`: Specify the number of characters that may be cut or copied from Org data and accounts to any application. This setting overrides the AllowedOutboundClipboardSharingLevel restriction. Default value of '0' means no exception is allowed.
    - `[AllowedOutboundClipboardSharingLevel <ManagedAppClipboardSharingLevel?>]`: Represents the level to which the device's clipboard may be shared between apps
    - `[AllowedOutboundDataTransferDestinations <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
    - `[AppActionIfDeviceComplianceRequired <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfMaximumPinRetriesExceeded <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppActionIfUnableToAuthenticateUser <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[BlockDataIngestionIntoOrganizationDocuments <Boolean?>]`: Indicates whether a user can bring data into org documents.
    - `[ContactSyncBlocked <Boolean?>]`: Indicates whether contacts can be synced to the user's device.
    - `[DataBackupBlocked <Boolean?>]`: Indicates whether the backup of a managed app's data is blocked.
    - `[DeviceComplianceRequired <Boolean?>]`: Indicates whether device compliance is required.
    - `[DialerRestrictionLevel <ManagedAppPhoneNumberRedirectLevel?>]`: The classes of apps that are allowed to click-to-open a phone number, for making phone calls or sending text messages.
    - `[DisableAppPinIfDevicePinIsSet <Boolean?>]`: Indicates whether use of the app pin is required if the device pin is set.
    - `[FingerprintBlocked <Boolean?>]`: Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.
    - `[GracePeriodToBlockAppsDuringOffClockHours <TimeSpan?>]`: A grace period before blocking app access during off clock hours.
    - `[ManagedBrowser <ManagedBrowserType?>]`: Type of managed browser
    - `[ManagedBrowserToOpenLinksRequired <Boolean?>]`: Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)
    - `[MaximumAllowedDeviceThreatLevel <ManagedAppDeviceThreatLevel?>]`: The maxium threat level allowed for an app to be compliant.
    - `[MaximumPinRetries <Int32?>]`: Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.
    - `[MaximumRequiredOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
    - `[MaximumWarningOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
    - `[MaximumWipeOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
    - `[MinimumPinLength <Int32?>]`: Minimum pin length required for an app-level pin if PinRequired is set to True
    - `[MinimumRequiredAppVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
    - `[MinimumRequiredOSVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
    - `[MinimumWarningAppVersion <String>]`: Versions less than the specified version will result in warning message on the managed app.
    - `[MinimumWarningOSVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data.
    - `[MinimumWipeAppVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
    - `[MinimumWipeOSVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
    - `[MobileThreatDefenseRemediationAction <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[NotificationRestriction <ManagedAppNotificationRestriction?>]`: Restrict managed app notification
    - `[OrganizationalCredentialsRequired <Boolean?>]`: Indicates whether organizational credentials are required for app use.
    - `[PeriodBeforePinReset <TimeSpan?>]`: TimePeriod before the all-level pin must be reset if PinRequired is set to True.
    - `[PeriodOfflineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is not connected to the internet.
    - `[PeriodOfflineBeforeWipeIsEnforced <TimeSpan?>]`: The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.
    - `[PeriodOnlineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is connected to the internet.
    - `[PinCharacterSet <ManagedAppPinCharacterSet?>]`: Character set which is to be used for a user's app PIN
    - `[PinRequired <Boolean?>]`: Indicates whether an app-level pin is required.
    - `[PinRequiredInsteadOfBiometricTimeout <TimeSpan?>]`: Timeout in minutes for an app pin instead of non biometrics passcode
    - `[PreviousPinBlockCount <Int32?>]`: Requires a pin to be unique from the number specified in this property.
    - `[PrintBlocked <Boolean?>]`: Indicates whether printing is allowed from managed apps.
    - `[SaveAsBlocked <Boolean?>]`: Indicates whether users may use the 'Save As' menu item to save a copy of protected files.
    - `[SimplePinBlocked <Boolean?>]`: Indicates whether simplePin is blocked.
    - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
    - `[Description <String>]`: The policy's description.
    - `[DisplayName <String>]`: Policy display name.
    - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Version <String>]`: Version of the entity.
    - `[Id <String>]`: 
    - `[AllowedIosDeviceModels <String>]`: Semicolon seperated list of device models allowed, as a string, for the managed app to work.
    - `[AppActionIfIosDeviceModelNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[AppDataEncryptionType <ManagedAppDataEncryptionType?>]`: Represents the level to which app data is encrypted for managed apps
    - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[CustomBrowserProtocol <String>]`: A custom browser protocol to open weblink on iOS.
    - `[CustomDialerAppProtocol <String>]`: Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.
    - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
    - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    - `[DisableProtectionOfManagedOutboundOpenInData <Boolean?>]`: Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps.
    - `[ExemptedAppProtocols <IMicrosoftGraphKeyValuePair[]>]`: Apps in this list will be exempt from the policy and will be able to receive data from managed apps.
    - `[ExemptedUniversalLinks <String[]>]`: A list of custom urls that are allowed to invocate an unmanaged app
    - `[FaceIdBlocked <Boolean?>]`: Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.
    - `[FilterOpenInToOnlyManagedApps <Boolean?>]`: Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False.
    - `[ManagedUniversalLinks <String[]>]`: A list of custom urls that are allowed to invocate a managed app
    - `[MinimumRequiredSdkVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
    - `[MinimumWipeSdkVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
    - `[ProtectInboundDataFromUnknownSources <Boolean?>]`: Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps.
    - `[ThirdPartyKeyboardsBlocked <Boolean?>]`: Defines if third party keyboards are allowed while accessing a managed app
  - `[IsEnabledForMicrosoftStoreForBusiness <Boolean?>]`: Whether the account is enabled for syncing applications from the Microsoft Store for Business.
  - `[ManagedAppPolicies <IMicrosoftGraphManagedAppPolicy[]>]`: Managed app policies.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
    - `[Description <String>]`: The policy's description.
    - `[DisplayName <String>]`: Policy display name.
    - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Version <String>]`: Version of the entity.
  - `[ManagedAppRegistrations <IMicrosoftGraphManagedAppRegistration[]>]`: The managed app registrations.
    - `[Id <String>]`: 
    - `[AppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[ApplicationVersion <String>]`: App version
    - `[AppliedPolicies <IMicrosoftGraphManagedAppPolicy[]>]`: Zero or more policys already applied on the registered app when it last synchronized with managment service.
    - `[AzureAdDeviceId <String>]`: The Azure Active Directory Device identifier of the host device. Value could be empty even when the host device is Azure Active Directory registered.
    - `[CreatedDateTime <DateTime?>]`: Date and time of creation
    - `[DeviceManufacturer <String>]`: The device manufacturer for the current app registration
    - `[DeviceModel <String>]`: The device model for the current app registration
    - `[DeviceName <String>]`: Host device name
    - `[DeviceTag <String>]`: App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.
    - `[DeviceType <String>]`: Host device type
    - `[FlaggedReasons <ManagedAppFlaggedReason[]>]`: Zero or more reasons an app registration is flagged. E.g. app running on rooted device
    - `[IntendedPolicies <IMicrosoftGraphManagedAppPolicy[]>]`: Zero or more policies admin intended for the app as of now.
    - `[LastSyncDateTime <DateTime?>]`: Date and time of last the app synced with management service.
    - `[ManagedDeviceId <String>]`: The Managed Device identifier of the host device. Value could be empty even when the host device is managed.
    - `[ManagementSdkVersion <String>]`: App management SDK version
    - `[Operations <IMicrosoftGraphManagedAppOperation[]>]`: Zero or more long running operations triggered on the app registration.
      - `[Id <String>]`: 
      - `[DisplayName <String>]`: The operation name.
      - `[LastModifiedDateTime <DateTime?>]`: The last time the app operation was modified.
      - `[State <String>]`: The current state of the operation
      - `[Version <String>]`: Version of the entity.
    - `[PlatformVersion <String>]`: Operating System version
    - `[UserId <String>]`: The user Id to who this app registration belongs.
    - `[Version <String>]`: Version of the entity.
  - `[ManagedAppStatuses <IMicrosoftGraphManagedAppStatus[]>]`: The managed app statuses.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: Friendly name of the status report.
    - `[Version <String>]`: Version of the entity.
  - `[ManagedEBookCategories <IMicrosoftGraphManagedEBookCategory[]>]`: The mobile eBook categories.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The name of the eBook category.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the ManagedEBookCategory was last modified.
  - `[ManagedEBooks <IMicrosoftGraphManagedEBook[]>]`: The Managed eBook.
    - `[Id <String>]`: 
    - `[Assignments <IMicrosoftGraphManagedEBookAssignment[]>]`: The list of assignments for this eBook.
      - `[Id <String>]`: 
      - `[InstallIntent <InstallIntent?>]`: Possible values for the install intent chosen by the admin.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[Categories <IMicrosoftGraphManagedEBookCategory[]>]`: The list of categories for this eBook.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the eBook file was created.
    - `[Description <String>]`: Description.
    - `[DeviceStates <IMicrosoftGraphDeviceInstallState[]>]`: The list of installation states for this eBook.
      - `[Id <String>]`: 
      - `[DeviceId <String>]`: Device Id.
      - `[DeviceName <String>]`: Device name.
      - `[ErrorCode <String>]`: The error code for install failures.
      - `[InstallState <InstallState?>]`: Possible values for install state.
      - `[LastSyncDateTime <DateTime?>]`: Last sync date and time.
      - `[OSDescription <String>]`: OS Description.
      - `[OSVersion <String>]`: OS Version.
      - `[UserName <String>]`: Device User Name.
    - `[DisplayName <String>]`: Name of the eBook.
    - `[InformationUrl <String>]`: The more information Url.
    - `[InstallSummary <IMicrosoftGraphEBookInstallSummary>]`: Contains properties for the installation summary of a book for a device.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[FailedDeviceCount <Int32?>]`: Number of Devices that have failed to install this book.
      - `[FailedUserCount <Int32?>]`: Number of Users that have 1 or more device that failed to install this book.
      - `[InstalledDeviceCount <Int32?>]`: Number of Devices that have successfully installed this book.
      - `[InstalledUserCount <Int32?>]`: Number of Users whose devices have all succeeded to install this book.
      - `[NotInstalledDeviceCount <Int32?>]`: Number of Devices that does not have this book installed.
      - `[NotInstalledUserCount <Int32?>]`: Number of Users that did not install this book.
    - `[LargeCover <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Type <String>]`: Indicates the content mime type.
      - `[Value <Byte[]>]`: The byte array that contains the actual content.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the eBook was last modified.
    - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
    - `[PublishedDateTime <DateTime?>]`: The date and time when the eBook was published.
    - `[Publisher <String>]`: Publisher.
    - `[UserStateSummary <IMicrosoftGraphUserInstallStateSummary[]>]`: The list of installation states for this eBook.
      - `[Id <String>]`: 
      - `[DeviceStates <IMicrosoftGraphDeviceInstallState[]>]`: The install state of the eBook.
      - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
      - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
      - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
      - `[UserName <String>]`: User name.
  - `[MdmWindowsInformationProtectionPolicies <IMicrosoftGraphMdmWindowsInformationProtectionPolicy[]>]`: Windows information protection for apps running on devices which are MDM enrolled.
    - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of security groups targeted for policy.
    - `[AzureRightsManagementServicesAllowed <Boolean?>]`: Specifies whether to allow Azure RMS encryption for WIP
    - `[DataRecoveryCertificate <IMicrosoftGraphWindowsInformationProtectionDataRecoveryCertificate>]`: Windows Information Protection DataRecoveryCertificate
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Certificate <Byte[]>]`: Data recovery Certificate
      - `[Description <String>]`: Data recovery Certificate description
      - `[ExpirationDateTime <DateTime?>]`: Data recovery Certificate expiration datetime
      - `[SubjectName <String>]`: Data recovery Certificate subject name
    - `[EnforcementLevel <WindowsInformationProtectionEnforcementLevel?>]`: Possible values for WIP Protection enforcement levels
    - `[EnterpriseDomain <String>]`: Primary enterprise domain
    - `[EnterpriseIPRanges <IMicrosoftGraphWindowsInformationProtectionIPRangeCollection[]>]`: Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to
      - `[DisplayName <String>]`: Display name
      - `[Ranges <IMicrosoftGraphIPRange[]>]`: Collection of ip ranges
    - `[EnterpriseIPRangesAreAuthoritative <Boolean?>]`: Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false
    - `[EnterpriseInternalProxyServers <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is the comma-separated list of internal proxy servers. For example, '157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59'. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies
      - `[DisplayName <String>]`: Display name
      - `[Resources <String[]>]`: Collection of resources
    - `[EnterpriseNetworkDomainNames <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to
    - `[EnterpriseProtectedDomainNames <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: List of enterprise domains to be protected
    - `[EnterpriseProxiedDomains <IMicrosoftGraphWindowsInformationProtectionProxiedDomainCollection[]>]`: Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy
      - `[DisplayName <String>]`: Display name
      - `[ProxiedDomains <IMicrosoftGraphProxiedDomain[]>]`: Collection of proxied domains
        - `[IPAddressOrFqdn <String>]`: The IP address or FQDN
        - `[Proxy <String>]`: Proxy IP or FQDN
    - `[EnterpriseProxyServers <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is a list of proxy servers. Any server not on this list is considered non-enterprise
    - `[EnterpriseProxyServersAreAuthoritative <Boolean?>]`: Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false
    - `[ExemptAppLockerFiles <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>]`: Another way to input exempt apps through xml files
      - `[Id <String>]`: 
      - `[DisplayName <String>]`: The friendly name
      - `[File <Byte[]>]`: File as a byte array
      - `[FileHash <String>]`: SHA256 hash of the file
      - `[Version <String>]`: Version of the entity.
    - `[ExemptApps <IMicrosoftGraphWindowsInformationProtectionApp[]>]`: Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.
      - `[Denied <Boolean?>]`: If true, app is denied protection or exemption.
      - `[Description <String>]`: The app's description.
      - `[DisplayName <String>]`: App display name.
      - `[ProductName <String>]`: The product name.
      - `[PublisherName <String>]`: The publisher name
    - `[IconsVisible <Boolean?>]`: Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app
    - `[IndexingEncryptedStoresOrItemsBlocked <Boolean?>]`: This switch is for the Windows Search Indexer, to allow or disallow indexing of items
    - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
    - `[NeutralDomainResources <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: List of domain names that can used for work or personal resource
    - `[ProtectedAppLockerFiles <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>]`: Another way to input protected apps through xml files
    - `[ProtectedApps <IMicrosoftGraphWindowsInformationProtectionApp[]>]`: Protected applications can access enterprise data and the data handled by those applications are protected with encryption
    - `[ProtectionUnderLockConfigRequired <Boolean?>]`: Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured
    - `[RevokeOnUnenrollDisabled <Boolean?>]`: This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don't revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.
    - `[RightsManagementServicesTemplateId <String>]`: TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access
    - `[SmbAutoEncryptedFileExtensions <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary
    - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
    - `[Description <String>]`: The policy's description.
    - `[DisplayName <String>]`: Policy display name.
    - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Version <String>]`: Version of the entity.
    - `[Id <String>]`: 
  - `[MicrosoftStoreForBusinessLanguage <String>]`: The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is <languagecode2>-<country/regioncode2>, where <languagecode2> is a lowercase two-letter code derived from ISO 639-1 and <country/regioncode2> is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.
  - `[MicrosoftStoreForBusinessLastCompletedApplicationSyncTime <DateTime?>]`: The last time an application sync from the Microsoft Store for Business was completed.
  - `[MicrosoftStoreForBusinessLastSuccessfulSyncDateTime <DateTime?>]`: The last time the apps from the Microsoft Store for Business were synced successfully for the account.
  - `[MicrosoftStoreForBusinessPortalSelection <MicrosoftStoreForBusinessPortalSelectionOptions?>]`: Portal to which admin syncs available Microsoft Store for Business apps. This is available in the Intune Admin Console.
  - `[MobileAppCategories <IMicrosoftGraphMobileAppCategory[]>]`: The mobile app categories.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The name of the app category.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.
  - `[MobileAppConfigurations <IMicrosoftGraphManagedDeviceMobileAppConfiguration[]>]`: The Managed Device Mobile Application Configurations.
    - `[Id <String>]`: 
    - `[Assignments <IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]>]`: The list of group assignemenets for app configration.
      - `[Id <String>]`: 
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
    - `[Description <String>]`: Admin provided description of the Device Configuration.
    - `[DeviceStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary>]`: Contains properties, inherited properties and actions for an MDM mobile app configuration device status summary.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
      - `[ConflictCount <Int32?>]`: Number of devices in conflict
      - `[ErrorCount <Int32?>]`: Number of error devices
      - `[FailedCount <Int32?>]`: Number of failed devices
      - `[LastUpdateDateTime <DateTime?>]`: Last update time
      - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
      - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
      - `[PendingCount <Int32?>]`: Number of pending devices
      - `[SuccessCount <Int32?>]`: Number of succeeded devices
    - `[DeviceStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus[]>]`: List of ManagedDeviceMobileAppConfigurationDeviceStatus.
    - `[DisplayName <String>]`: Admin provided name of the device configuration.
    - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this App configuration entity.
    - `[TargetedMobileApps <String[]>]`: the associated app.
    - `[UserStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary>]`: Contains properties, inherited properties and actions for an MDM mobile app configuration user status summary.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
      - `[ConflictCount <Int32?>]`: Number of users in conflict
      - `[ErrorCount <Int32?>]`: Number of error Users
      - `[FailedCount <Int32?>]`: Number of failed Users
      - `[LastUpdateDateTime <DateTime?>]`: Last update time
      - `[NotApplicableCount <Int32?>]`: Number of not applicable users
      - `[PendingCount <Int32?>]`: Number of pending Users
      - `[SuccessCount <Int32?>]`: Number of succeeded Users
    - `[UserStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>]`: List of ManagedDeviceMobileAppConfigurationUserStatus.
    - `[Version <Int32?>]`: Version of the device configuration.
  - `[MobileApps <IMicrosoftGraphMobileApp[]>]`: The mobile apps.
    - `[Id <String>]`: 
    - `[Assignments <IMicrosoftGraphMobileAppAssignment[]>]`: The list of group assignments for this mobile app.
      - `[Id <String>]`: 
      - `[Intent <InstallIntent?>]`: Possible values for the install intent chosen by the admin.
      - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: Abstract class to contain properties used to assign a mobile app to a group.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
      - `[SourceId <String>]`: The identifier of the source of the assignment.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[Categories <IMicrosoftGraphMobileAppCategory[]>]`: The list of categories for this app.
    - `[CreatedDateTime <DateTime?>]`: The date and time the app was created.
    - `[DependentAppCount <Int32?>]`: The total number of dependencies the child app has.
    - `[Description <String>]`: The description of the app.
    - `[Developer <String>]`: The developer of the app.
    - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The list of installation states for this mobile app.
      - `[Id <String>]`: 
      - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
      - `[DeviceId <String>]`: Device ID
      - `[DeviceName <String>]`: Device name
      - `[DisplayVersion <String>]`: Human readable version of the application
      - `[ErrorCode <Int32?>]`: The error code for install or uninstall failures.
      - `[InstallState <ResultantAppState?>]`: A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.
      - `[InstallStateDetail <ResultantAppStateDetail?>]`: Enum indicating additional details regarding why an application has a particular install state.
      - `[LastSyncDateTime <DateTime?>]`: Last sync date time
      - `[MobileAppInstallStatusValue <ResultantAppState?>]`: A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.
      - `[OSDescription <String>]`: OS Description
      - `[OSVersion <String>]`: OS Version
      - `[UserName <String>]`: Device User Name
      - `[UserPrincipalName <String>]`: User Principal Name
    - `[DisplayName <String>]`: The admin provided or imported title of the app.
    - `[InformationUrl <String>]`: The more information Url.
    - `[InstallSummary <IMicrosoftGraphMobileAppInstallSummary>]`: Contains properties for the installation summary of a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[FailedDeviceCount <Int32?>]`: Number of Devices that have failed to install this app.
      - `[FailedUserCount <Int32?>]`: Number of Users that have 1 or more device that failed to install this app.
      - `[InstalledDeviceCount <Int32?>]`: Number of Devices that have successfully installed this app.
      - `[InstalledUserCount <Int32?>]`: Number of Users whose devices have all succeeded to install this app.
      - `[NotApplicableDeviceCount <Int32?>]`: Number of Devices that are not applicable for this app.
      - `[NotApplicableUserCount <Int32?>]`: Number of Users whose devices were all not applicable for this app.
      - `[NotInstalledDeviceCount <Int32?>]`: Number of Devices that does not have this app installed.
      - `[NotInstalledUserCount <Int32?>]`: Number of Users that have 1 or more devices that did not install this app.
      - `[PendingInstallDeviceCount <Int32?>]`: Number of Devices that have been notified to install this app.
      - `[PendingInstallUserCount <Int32?>]`: Number of Users that have 1 or more device that have been notified to install this app and have 0 devices with failures.
    - `[IsAssigned <Boolean?>]`: The value indicating whether the app is assigned to at least one group.
    - `[IsFeatured <Boolean?>]`: The value indicating whether the app is marked as featured by the admin.
    - `[LargeIcon <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the app was last modified.
    - `[Notes <String>]`: Notes for the app.
    - `[Owner <String>]`: The owner of the app.
    - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
    - `[Publisher <String>]`: The publisher of the app.
    - `[PublishingState <MobileAppPublishingState?>]`: Indicates the publishing state of an app.
    - `[Relationships <IMicrosoftGraphMobileAppRelationship[]>]`: List of relationships for this mobile app.
      - `[Id <String>]`: 
      - `[TargetDisplayName <String>]`: The target mobile app's display name.
      - `[TargetDisplayVersion <String>]`: The target mobile app's display version.
      - `[TargetId <String>]`: The target mobile app's app id.
      - `[TargetPublisher <String>]`: The target mobile app's publisher.
      - `[TargetType <MobileAppRelationshipType?>]`: Indicates whether the target of a relationship is the parent or the child in the relationship.
    - `[RoleScopeTagIds <String[]>]`: List of scope tag ids for this mobile app.
    - `[SupersededAppCount <Int32?>]`: The total number of apps this app is directly or indirectly superseded by.
    - `[SupersedingAppCount <Int32?>]`: The total number of apps this app directly or indirectly supersedes.
    - `[UploadState <Int32?>]`: The upload state.
    - `[UserStatuses <IMicrosoftGraphUserAppInstallStatus[]>]`: The list of installation states for this mobile app.
      - `[Id <String>]`: 
      - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
      - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The install state of the app on devices.
      - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
      - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
      - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
      - `[UserName <String>]`: User name.
      - `[UserPrincipalName <String>]`: User Principal Name.
  - `[PolicySets <IMicrosoftGraphPolicySet[]>]`: The PolicySet of Policies and Applications
    - `[Id <String>]`: 
    - `[Assignments <IMicrosoftGraphPolicySetAssignment[]>]`: Assignments of the PolicySet.
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySetAssignment.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[CreatedDateTime <DateTime?>]`: Creation time of the PolicySet.
    - `[Description <String>]`: Description of the PolicySet.
    - `[DisplayName <String>]`: DisplayName of the PolicySet.
    - `[ErrorCode <ErrorCode?>]`: errorCode
    - `[GuidedDeploymentTags <String[]>]`: Tags of the guided deployment
    - `[Items <IMicrosoftGraphPolicySetItem[]>]`: Items of the PolicySet with maximum count 100.
      - `[Id <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: Creation time of the PolicySetItem.
      - `[DisplayName <String>]`: DisplayName of the PolicySetItem.
      - `[ErrorCode <ErrorCode?>]`: errorCode
      - `[GuidedDeploymentTags <String[]>]`: Tags of the guided deployment
      - `[ItemType <String>]`: policySetType of the PolicySetItem.
      - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySetItem.
      - `[PayloadId <String>]`: PayloadId of the PolicySetItem.
      - `[Status <PolicySetStatus?>]`: The enum to specify the status of PolicySet.
    - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySet.
    - `[RoleScopeTags <String[]>]`: RoleScopeTags of the PolicySet
    - `[Status <PolicySetStatus?>]`: The enum to specify the status of PolicySet.
  - `[SideLoadingKeys <IMicrosoftGraphSideLoadingKey[]>]`: Side Loading Keys that are required for the Windows 8 and 8.1 Apps installation.
    - `[Id <String>]`: 
    - `[Description <String>]`: Side Loading Key description displayed to the ITPro Admins..
    - `[DisplayName <String>]`: Side Loading Key Name displayed to the ITPro Admins.
    - `[LastUpdatedDateTime <String>]`: Side Loading Key Last Updated Date displayed to the ITPro Admins.
    - `[TotalActivation <Int32?>]`: Side Loading Key Total Activation displayed to the ITPro Admins.
    - `[Value <String>]`: Side Loading Key Value, it is 5x5 value, seperated by hiphens.
  - `[SymantecCodeSigningCertificate <IMicrosoftGraphSymantecCodeSigningCertificate>]`: symantecCodeSigningCertificate
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Content <Byte[]>]`: The Windows Symantec Code-Signing Certificate in the raw data format.
    - `[ExpirationDateTime <DateTime?>]`: The Cert Expiration Date.
    - `[Issuer <String>]`: The Issuer value for the cert.
    - `[IssuerName <String>]`: The Issuer Name for the cert.
    - `[Password <String>]`: The Password required for .pfx file.
    - `[Status <String>]`: certificateStatus
    - `[Subject <String>]`: The Subject value for the cert.
    - `[SubjectName <String>]`: The Subject Name for the cert.
    - `[UploadDateTime <DateTime?>]`: The Type of the CodeSigning Cert as Symantec Cert.
  - `[TargetedManagedAppConfigurations <IMicrosoftGraphTargetedManagedAppConfiguration[]>]`: Targeted managed app configurations.
    - `[CustomSettings <IMicrosoftGraphKeyValuePair[]>]`: A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
    - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
    - `[Description <String>]`: The policy's description.
    - `[DisplayName <String>]`: Policy display name.
    - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Version <String>]`: Version of the entity.
    - `[Id <String>]`: 
    - `[AppGroupType <TargetedManagedAppGroupType?>]`: Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps
    - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
    - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
  - `[VppTokens <IMicrosoftGraphVppToken[]>]`: List of Vpp tokens for this organization.
    - `[Id <String>]`: 
    - `[AppleId <String>]`: The apple Id associated with the given Apple Volume Purchase Program Token.
    - `[AutomaticallyUpdateApps <Boolean?>]`: Whether or not apps for the VPP token will be automatically updated.
    - `[ClaimTokenManagementFromExternalMdm <Boolean?>]`: Admin consent to allow claiming token management from external MDM.
    - `[CountryOrRegion <String>]`: Whether or not apps for the VPP token will be automatically updated.
    - `[DataSharingConsentGranted <Boolean?>]`: Consent granted for data sharing with the Apple Volume Purchase Program.
    - `[DisplayName <String>]`: An admin specified token friendly name.
    - `[ExpirationDateTime <DateTime?>]`: The expiration date time of the Apple Volume Purchase Program Token.
    - `[LastModifiedDateTime <DateTime?>]`: Last modification date time associated with the Apple Volume Purchase Program Token.
    - `[LastSyncDateTime <DateTime?>]`: The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.
    - `[LastSyncStatus <VppTokenSyncStatus?>]`: Possible sync statuses associated with an Apple Volume Purchase Program token.
    - `[LocationName <String>]`: Token location returned from Apple VPP.
    - `[OrganizationName <String>]`: The organization associated with the Apple Volume Purchase Program Token
    - `[RoleScopeTagIds <String[]>]`: Role Scope Tags IDs assigned to this entity.
    - `[State <VppTokenState?>]`: Possible states associated with an Apple Volume Purchase Program token.
    - `[Token <String>]`: The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.
    - `[TokenActionResults <IMicrosoftGraphVppTokenActionResult[]>]`: The collection of statuses of the actions performed on the Apple Volume Purchase Program Token.
      - `[ActionName <String>]`: Action name
      - `[ActionState <String>]`: actionState
      - `[LastUpdatedDateTime <DateTime?>]`: Time the action state was last updated
      - `[StartDateTime <DateTime?>]`: Time the action was initiated
    - `[VppTokenAccountType <VppTokenAccountType?>]`: Possible types of an Apple Volume Purchase Program token.
  - `[WdacSupplementalPolicies <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy[]>]`: The collection of Windows Defender Application Control Supplemental Policies.
    - `[Id <String>]`: 
    - `[Assignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]`: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
      - `[Id <String>]`: 
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[Content <Byte[]>]`: The WindowsDefenderApplicationControl supplemental policy content in byte array format.
    - `[ContentFileName <String>]`: The WindowsDefenderApplicationControl supplemental policy content's file name.
    - `[CreationDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.
    - `[DeploySummary <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>]`: Contains properties for the deployment summary of a WindowsDefenderApplicationControl supplemental policy.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[DeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
      - `[FailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
    - `[Description <String>]`: The description of WindowsDefenderApplicationControl supplemental policy.
    - `[DeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
      - `[Id <String>]`: 
      - `[DeploymentStatus <WindowsDefenderApplicationControlSupplementalPolicyStatuses?>]`: Enum values for the various WindowsDefenderApplicationControl supplemental policy deployment statuses.
      - `[DeviceId <String>]`: Device ID.
      - `[DeviceName <String>]`: Device name.
      - `[LastSyncDateTime <DateTime?>]`: Last sync date time.
      - `[OSDescription <String>]`: Windows OS Version Description.
      - `[OSVersion <String>]`: Windows OS Version.
      - `[Policy <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy>]`: windowsDefenderApplicationControlSupplementalPolicy
      - `[PolicyVersion <String>]`: Human readable version of the WindowsDefenderApplicationControl supplemental policy.
      - `[UserName <String>]`: The name of the user of this device.
      - `[UserPrincipalName <String>]`: User Principal Name.
    - `[DisplayName <String>]`: The display name of WindowsDefenderApplicationControl supplemental policy.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.
    - `[Version <String>]`: The WindowsDefenderApplicationControl supplemental policy's version.
  - `[WindowsInformationProtectionDeviceRegistrations <IMicrosoftGraphWindowsInformationProtectionDeviceRegistration[]>]`: Windows information protection device registrations that are not MDM enrolled.
    - `[Id <String>]`: 
    - `[DeviceMacAddress <String>]`: Device Mac address.
    - `[DeviceName <String>]`: Device name.
    - `[DeviceRegistrationId <String>]`: Device identifier for this device registration record.
    - `[DeviceType <String>]`: Device type, for example, Windows laptop VS Windows phone.
    - `[LastCheckInDateTime <DateTime?>]`: Last checkin time of the device.
    - `[UserId <String>]`: UserId associated with this device registration record.
  - `[WindowsInformationProtectionPolicies <IMicrosoftGraphWindowsInformationProtectionPolicy[]>]`: Windows information protection for apps running on devices which are not MDM enrolled.
    - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of security groups targeted for policy.
    - `[AzureRightsManagementServicesAllowed <Boolean?>]`: Specifies whether to allow Azure RMS encryption for WIP
    - `[DataRecoveryCertificate <IMicrosoftGraphWindowsInformationProtectionDataRecoveryCertificate>]`: Windows Information Protection DataRecoveryCertificate
    - `[EnforcementLevel <WindowsInformationProtectionEnforcementLevel?>]`: Possible values for WIP Protection enforcement levels
    - `[EnterpriseDomain <String>]`: Primary enterprise domain
    - `[EnterpriseIPRanges <IMicrosoftGraphWindowsInformationProtectionIPRangeCollection[]>]`: Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to
    - `[EnterpriseIPRangesAreAuthoritative <Boolean?>]`: Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false
    - `[EnterpriseInternalProxyServers <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is the comma-separated list of internal proxy servers. For example, '157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59'. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies
    - `[EnterpriseNetworkDomainNames <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to
    - `[EnterpriseProtectedDomainNames <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: List of enterprise domains to be protected
    - `[EnterpriseProxiedDomains <IMicrosoftGraphWindowsInformationProtectionProxiedDomainCollection[]>]`: Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy
    - `[EnterpriseProxyServers <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is a list of proxy servers. Any server not on this list is considered non-enterprise
    - `[EnterpriseProxyServersAreAuthoritative <Boolean?>]`: Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false
    - `[ExemptAppLockerFiles <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>]`: Another way to input exempt apps through xml files
    - `[ExemptApps <IMicrosoftGraphWindowsInformationProtectionApp[]>]`: Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.
    - `[IconsVisible <Boolean?>]`: Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app
    - `[IndexingEncryptedStoresOrItemsBlocked <Boolean?>]`: This switch is for the Windows Search Indexer, to allow or disallow indexing of items
    - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
    - `[NeutralDomainResources <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: List of domain names that can used for work or personal resource
    - `[ProtectedAppLockerFiles <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>]`: Another way to input protected apps through xml files
    - `[ProtectedApps <IMicrosoftGraphWindowsInformationProtectionApp[]>]`: Protected applications can access enterprise data and the data handled by those applications are protected with encryption
    - `[ProtectionUnderLockConfigRequired <Boolean?>]`: Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured
    - `[RevokeOnUnenrollDisabled <Boolean?>]`: This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don't revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.
    - `[RightsManagementServicesTemplateId <String>]`: TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access
    - `[SmbAutoEncryptedFileExtensions <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary
    - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
    - `[Description <String>]`: The policy's description.
    - `[DisplayName <String>]`: Policy display name.
    - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Version <String>]`: Version of the entity.
    - `[Id <String>]`: 
    - `[DaysWithoutContactBeforeUnenroll <Int32?>]`: Offline interval before app data is wiped (days)
    - `[MdmEnrollmentUrl <String>]`: Enrollment url for the MDM
    - `[MinutesOfInactivityBeforeDeviceLock <Int32?>]`: Specifies the maximum amount of time (in minutes) allowed after the device is idle that will cause the device to become PIN or password locked.   Range is an integer X where 0 <= X <= 999.
    - `[NumberOfPastPinsRemembered <Int32?>]`: Integer value that specifies the number of past PINs that can be associated to a user account that can't be reused. The largest number you can configure for this policy setting is 50. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then storage of previous PINs is not required. This node was added in Windows 10, version 1511. Default is 0.
    - `[PasswordMaximumAttemptCount <Int32?>]`: The number of authentication failures allowed before the device will be wiped. A value of 0 disables device wipe functionality. Range is an integer X where 4 <= X <= 16 for desktop and 0 <= X <= 999 for mobile devices.
    - `[PinExpirationDays <Int32?>]`: Integer value specifies the period of time (in days) that a PIN can be used before the system requires the user to change it. The largest number you can configure for this policy setting is 730. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then the user's PIN will never expire. This node was added in Windows 10, version 1511. Default is 0.
    - `[PinLowercaseLetters <WindowsInformationProtectionPinCharacterRequirements?>]`: Pin Character Requirements
    - `[PinMinimumLength <Int32?>]`: Integer value that sets the minimum number of characters required for the PIN. Default value is 4. The lowest number you can configure for this policy setting is 4. The largest number you can configure must be less than the number configured in the Maximum PIN length policy setting or the number 127, whichever is the lowest.
    - `[PinSpecialCharacters <WindowsInformationProtectionPinCharacterRequirements?>]`: Pin Character Requirements
    - `[PinUppercaseLetters <WindowsInformationProtectionPinCharacterRequirements?>]`: Pin Character Requirements
    - `[RevokeOnMdmHandoffDisabled <Boolean?>]`: New property in RS2, pending documentation
    - `[WindowsHelloForBusinessBlocked <Boolean?>]`: Boolean value that sets Windows Hello for Business as a method for signing into Windows.
  - `[WindowsInformationProtectionWipeActions <IMicrosoftGraphWindowsInformationProtectionWipeAction[]>]`: Windows information protection wipe actions.
    - `[Id <String>]`: 
    - `[LastCheckInDateTime <DateTime?>]`: Last checkin time of the device that was targeted by this wipe action.
    - `[Status <String>]`: actionState
    - `[TargetedDeviceMacAddress <String>]`: Targeted device Mac address.
    - `[TargetedDeviceName <String>]`: Targeted device name.
    - `[TargetedDeviceRegistrationId <String>]`: The DeviceRegistrationId being targeted by this wipe action.
    - `[TargetedUserId <String>]`: The UserId being targeted by this wipe action.
  - `[WindowsManagedAppProtections <IMicrosoftGraphWindowsManagedAppProtection[]>]`: Windows managed app policies.
    - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
    - `[Description <String>]`: The policy's description.
    - `[DisplayName <String>]`: Policy display name.
    - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Version <String>]`: Version of the entity.
    - `[Id <String>]`: 
    - `[AllowedInboundDataTransferSources <WindowsManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
    - `[AllowedOutboundClipboardSharingLevel <WindowsManagedAppClipboardSharingLevel?>]`: Represents the level to which the device's clipboard may be shared between apps
    - `[AllowedOutboundDataTransferDestinations <WindowsManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
    - `[AppActionIfUnableToAuthenticateUser <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    - `[DeployedAppCount <Int32?>]`: Indicates the total number of applications for which the current policy is deployed.
    - `[IsAssigned <Boolean?>]`: When TRUE, indicates that the policy is deployed to some inclusion groups. When FALSE, indicates that the policy is not deployed to any inclusion groups. Default value is FALSE.
    - `[MaximumAllowedDeviceThreatLevel <ManagedAppDeviceThreatLevel?>]`: The maxium threat level allowed for an app to be compliant.
    - `[MaximumRequiredOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
    - `[MaximumWarningOSVersion <String>]`: Versions bigger than the specified version will result in warning message on the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
    - `[MaximumWipeOSVersion <String>]`: Versions bigger than the specified version will wipe the managed app and the associated company data. For example: '8.1.0' or '13.1.1'.
    - `[MinimumRequiredAppVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
    - `[MinimumRequiredOSVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
    - `[MinimumRequiredSdkVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
    - `[MinimumWarningAppVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
    - `[MinimumWarningOSVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
    - `[MinimumWipeAppVersion <String>]`: Versions less than the specified version will wipe the managed app and the associated company data. For example: '8.1.0' or '13.1.1'.
    - `[MinimumWipeOSVersion <String>]`: Versions less than the specified version will wipe the managed app and the associated company data. For example: '8.1.0' or '13.1.1'.
    - `[MinimumWipeSdkVersion <String>]`: Versions less than the specified version will wipe the managed app and the associated company data. For example: '8.1.0' or '13.1.1'.
    - `[MobileThreatDefenseRemediationAction <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
    - `[PeriodOfflineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is not connected to the internet. For example, PT5M indicates that the interval is 5 minutes in duration. A timespan value of PT0S indicates that access will be blocked immediately when the device is not connected to the internet.
    - `[PeriodOfflineBeforeWipeIsEnforced <TimeSpan?>]`: The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped. For example, P5D indicates that the interval is 5 days in duration. A timespan value of PT0S indicates that managed data will never be wiped when the device is not connected to the internet.
    - `[PrintBlocked <Boolean?>]`: When TRUE, indicates that printing is blocked from managed apps. When FALSE, indicates that printing is allowed from managed apps. Default value is FALSE.
  - `[WindowsManagementApp <IMicrosoftGraphWindowsManagementApp>]`: Windows management app entity.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[AvailableVersion <String>]`: Windows management app available version.
    - `[HealthStates <IMicrosoftGraphWindowsManagementAppHealthState[]>]`: The list of health states for installed Windows management app.
      - `[Id <String>]`: 
      - `[DeviceName <String>]`: Name of the device on which Windows management app is installed.
      - `[DeviceOSVersion <String>]`: Windows 10 OS version of the device on which Windows management app is installed.
      - `[HealthState <HealthState?>]`: Indicates health state of the Windows management app.
      - `[InstalledVersion <String>]`: Windows management app installed version.
      - `[LastCheckInDateTime <DateTime?>]`: Windows management app last check-in time.
    - `[ManagedInstaller <ManagedInstallerStatus?>]`: ManagedInstallerStatus
    - `[ManagedInstallerConfiguredDateTime <String>]`: Managed Installer Configured Date Time

DEFAULTMANAGEDAPPPROTECTIONS <IMicrosoftGraphDefaultManagedAppProtection[]>: Default managed app policies.
  - `[AllowedDataIngestionLocations <ManagedAppDataIngestionLocation[]>]`: Data storage locations where a user may store managed data.
  - `[AllowedDataStorageLocations <ManagedAppDataStorageLocation[]>]`: Data storage locations where a user may store managed data.
  - `[AllowedInboundDataTransferSources <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
  - `[AllowedOutboundClipboardSharingExceptionLength <Int32?>]`: Specify the number of characters that may be cut or copied from Org data and accounts to any application. This setting overrides the AllowedOutboundClipboardSharingLevel restriction. Default value of '0' means no exception is allowed.
  - `[AllowedOutboundClipboardSharingLevel <ManagedAppClipboardSharingLevel?>]`: Represents the level to which the device's clipboard may be shared between apps
  - `[AllowedOutboundDataTransferDestinations <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
  - `[AppActionIfDeviceComplianceRequired <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfMaximumPinRetriesExceeded <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfUnableToAuthenticateUser <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[BlockDataIngestionIntoOrganizationDocuments <Boolean?>]`: Indicates whether a user can bring data into org documents.
  - `[ContactSyncBlocked <Boolean?>]`: Indicates whether contacts can be synced to the user's device.
  - `[DataBackupBlocked <Boolean?>]`: Indicates whether the backup of a managed app's data is blocked.
  - `[DeviceComplianceRequired <Boolean?>]`: Indicates whether device compliance is required.
  - `[DialerRestrictionLevel <ManagedAppPhoneNumberRedirectLevel?>]`: The classes of apps that are allowed to click-to-open a phone number, for making phone calls or sending text messages.
  - `[DisableAppPinIfDevicePinIsSet <Boolean?>]`: Indicates whether use of the app pin is required if the device pin is set.
  - `[FingerprintBlocked <Boolean?>]`: Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.
  - `[GracePeriodToBlockAppsDuringOffClockHours <TimeSpan?>]`: A grace period before blocking app access during off clock hours.
  - `[ManagedBrowser <ManagedBrowserType?>]`: Type of managed browser
  - `[ManagedBrowserToOpenLinksRequired <Boolean?>]`: Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)
  - `[MaximumAllowedDeviceThreatLevel <ManagedAppDeviceThreatLevel?>]`: The maxium threat level allowed for an app to be compliant.
  - `[MaximumPinRetries <Int32?>]`: Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.
  - `[MaximumRequiredOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
  - `[MaximumWarningOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
  - `[MaximumWipeOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
  - `[MinimumPinLength <Int32?>]`: Minimum pin length required for an app-level pin if PinRequired is set to True
  - `[MinimumRequiredAppVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[MinimumRequiredOSVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[MinimumWarningAppVersion <String>]`: Versions less than the specified version will result in warning message on the managed app.
  - `[MinimumWarningOSVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data.
  - `[MinimumWipeAppVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
  - `[MinimumWipeOSVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
  - `[MobileThreatDefenseRemediationAction <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[NotificationRestriction <ManagedAppNotificationRestriction?>]`: Restrict managed app notification
  - `[OrganizationalCredentialsRequired <Boolean?>]`: Indicates whether organizational credentials are required for app use.
  - `[PeriodBeforePinReset <TimeSpan?>]`: TimePeriod before the all-level pin must be reset if PinRequired is set to True.
  - `[PeriodOfflineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is not connected to the internet.
  - `[PeriodOfflineBeforeWipeIsEnforced <TimeSpan?>]`: The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.
  - `[PeriodOnlineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is connected to the internet.
  - `[PinCharacterSet <ManagedAppPinCharacterSet?>]`: Character set which is to be used for a user's app PIN
  - `[PinRequired <Boolean?>]`: Indicates whether an app-level pin is required.
  - `[PinRequiredInsteadOfBiometricTimeout <TimeSpan?>]`: Timeout in minutes for an app pin instead of non biometrics passcode
  - `[PreviousPinBlockCount <Int32?>]`: Requires a pin to be unique from the number specified in this property.
  - `[PrintBlocked <Boolean?>]`: Indicates whether printing is allowed from managed apps.
  - `[SaveAsBlocked <Boolean?>]`: Indicates whether users may use the 'Save As' menu item to save a copy of protected files.
  - `[SimplePinBlocked <Boolean?>]`: Indicates whether simplePin is blocked.
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.
  - `[Id <String>]`: 
  - `[AllowedAndroidDeviceManufacturers <String>]`: Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work. (Android only)
  - `[AllowedAndroidDeviceModels <String[]>]`: List of device models allowed, as a string, for the managed app to work. (Android Only)
  - `[AllowedIosDeviceModels <String>]`: Semicolon seperated list of device models allowed, as a string, for the managed app to work. (iOS Only)
  - `[AppActionIfAndroidDeviceManufacturerNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfAndroidDeviceModelNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfAndroidSafetyNetAppsVerificationFailed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfAndroidSafetyNetDeviceAttestationFailed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfDeviceLockNotSet <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfDevicePasscodeComplexityLessThanHigh <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfDevicePasscodeComplexityLessThanLow <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfDevicePasscodeComplexityLessThanMedium <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfIosDeviceModelNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppDataEncryptionType <ManagedAppDataEncryptionType?>]`: Represents the level to which app data is encrypted for managed apps
  - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[Id <String>]`: 
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Version <String>]`: Version of the entity.
  - `[BiometricAuthenticationBlocked <Boolean?>]`: Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True. (Android Only)
  - `[BlockAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.
  - `[ConnectToVpnOnLaunch <Boolean?>]`: Whether the app should connect to the configured VPN on launch (Android only).
  - `[CustomBrowserDisplayName <String>]`: Friendly name of the preferred custom browser to open weblink on Android. (Android only)
  - `[CustomBrowserPackageId <String>]`: Unique identifier of a custom browser to open weblink on Android. (Android only)
  - `[CustomBrowserProtocol <String>]`: A custom browser protocol to open weblink on iOS. (iOS only)
  - `[CustomDialerAppDisplayName <String>]`: Friendly name of a custom dialer app to click-to-open a phone number on Android.
  - `[CustomDialerAppPackageId <String>]`: PackageId of a custom dialer app to click-to-open a phone number on Android.
  - `[CustomDialerAppProtocol <String>]`: Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.
  - `[CustomSettings <IMicrosoftGraphKeyValuePair[]>]`: A set of string key and string value pairs to be sent to the affected users, unalterned by this service
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
  - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
    - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
      - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
      - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[DisplayName <String>]`: Not yet documented
    - `[LastRefreshTime <DateTime?>]`: Not yet documented
    - `[Version <String>]`: Version of the entity.
  - `[DeviceLockRequired <Boolean?>]`: Defines if any kind of lock must be required on device. (android only)
  - `[DisableAppEncryptionIfDeviceEncryptionIsEnabled <Boolean?>]`: When this setting is enabled, app level encryption is disabled if device level encryption is enabled. (Android only)
  - `[DisableProtectionOfManagedOutboundOpenInData <Boolean?>]`: Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps. (iOS Only)
  - `[EncryptAppData <Boolean?>]`: Indicates whether managed-app data should be encrypted. (Android only)
  - `[ExemptedAppPackages <IMicrosoftGraphKeyValuePair[]>]`: Android App packages in this list will be exempt from the policy and will be able to receive data from managed apps. (Android only)
  - `[ExemptedAppProtocols <IMicrosoftGraphKeyValuePair[]>]`: iOS Apps in this list will be exempt from the policy and will be able to receive data from managed apps. (iOS Only)
  - `[FaceIdBlocked <Boolean?>]`: Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True. (iOS Only)
  - `[FilterOpenInToOnlyManagedApps <Boolean?>]`: Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False. (iOS Only)
  - `[FingerprintAndBiometricEnabled <Boolean?>]`: Indicate to the client to enable both biometrics and fingerprints for the app.
  - `[MinimumRequiredCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or app access will be blocked
  - `[MinimumRequiredPatchVersion <String>]`: Define the oldest required Android security patch level a user can have to gain secure access to the app. (Android only)
  - `[MinimumRequiredSdkVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data. (iOS Only)
  - `[MinimumWarningCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or the user will receive a warning
  - `[MinimumWarningPatchVersion <String>]`: Define the oldest recommended Android security patch level a user can have for secure access to the app. (Android only)
  - `[MinimumWipeCompanyPortalVersion <String>]`: Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped
  - `[MinimumWipePatchVersion <String>]`: Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data. (Android only)
  - `[MinimumWipeSdkVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[ProtectInboundDataFromUnknownSources <Boolean?>]`: Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps. (iOS Only)
  - `[RequireClass3Biometrics <Boolean?>]`: Require user to apply Class 3 Biometrics on their Android device.
  - `[RequirePinAfterBiometricChange <Boolean?>]`: A PIN prompt will override biometric prompts if class 3 biometrics are updated on the device.
  - `[RequiredAndroidSafetyNetAppsVerificationType <AndroidManagedAppSafetyNetAppsVerificationType?>]`: An admin enforced Android SafetyNet Device Attestation requirement on a managed app.
  - `[RequiredAndroidSafetyNetDeviceAttestationType <AndroidManagedAppSafetyNetDeviceAttestationType?>]`: An admin enforced Android SafetyNet Device Attestation requirement on a managed app.
  - `[RequiredAndroidSafetyNetEvaluationType <AndroidManagedAppSafetyNetEvaluationType?>]`: An admin enforced Android SafetyNet evaluation type requirement on a managed app.
  - `[ScreenCaptureBlocked <Boolean?>]`: Indicates whether screen capture is blocked. (Android only)
  - `[ThirdPartyKeyboardsBlocked <Boolean?>]`: Defines if third party keyboards are allowed while accessing a managed app. (iOS Only)
  - `[WarnAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning
  - `[WipeAfterCompanyPortalUpdateDeferralInDays <Int32?>]`: Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped

DEVICEAPPMANAGEMENTTASKS <IMicrosoftGraphDeviceAppManagementTask[]>: Device app management tasks.
  - `[Id <String>]`: 
  - `[AssignedTo <String>]`: The name or email of the admin this task is assigned to.
  - `[Category <DeviceAppManagementTaskCategory?>]`: Device app management task category.
  - `[CreatedDateTime <DateTime?>]`: The created date.
  - `[Creator <String>]`: The email address of the creator.
  - `[CreatorNotes <String>]`: Notes from the creator.
  - `[Description <String>]`: The description.
  - `[DisplayName <String>]`: The name.
  - `[DueDateTime <DateTime?>]`: The due date.
  - `[Priority <DeviceAppManagementTaskPriority?>]`: Device app management task priority.
  - `[Status <DeviceAppManagementTaskStatus?>]`: Device app management task status.

ENTERPRISECODESIGNINGCERTIFICATES <IMicrosoftGraphEnterpriseCodeSigningCertificate[]>: The Windows Enterprise Code Signing Certificate.
  - `[Id <String>]`: 
  - `[Content <Byte[]>]`: The Windows Enterprise Code-Signing Certificate in the raw data format.
  - `[ExpirationDateTime <DateTime?>]`: The Cert Expiration Date.
  - `[Issuer <String>]`: The Issuer value for the cert.
  - `[IssuerName <String>]`: The Issuer Name for the cert.
  - `[Status <String>]`: certificateStatus
  - `[Subject <String>]`: The Subject Value for the cert.
  - `[SubjectName <String>]`: The Subject Name for the cert.
  - `[UploadDateTime <DateTime?>]`: The date time of CodeSigning Cert when it is uploaded.

IOSLOBAPPPROVISIONINGCONFIGURATIONS <IMicrosoftGraphIosLobAppProvisioningConfiguration[]>: The IOS Lob App Provisioning Configurations.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphIosLobAppProvisioningConfigurationAssignment[]>]`: The associated group assignments for IosLobAppProvisioningConfiguration.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
  - `[Description <String>]`: Admin provided description of the Device Configuration.
  - `[DeviceStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus[]>]`: The list of device installation states for this mobile app configuration.
    - `[Id <String>]`: 
    - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
    - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
    - `[DeviceModel <String>]`: The device model that is being reported
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Platform <Int32?>]`: Platform of the device that is being reported
    - `[Status <String>]`: complianceStatus
    - `[UserName <String>]`: The User Name that is being reported
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[DisplayName <String>]`: Admin provided name of the device configuration.
  - `[ExpirationDateTime <DateTime?>]`: Optional profile expiration date and time.
  - `[GroupAssignments <IMicrosoftGraphMobileAppProvisioningConfigGroupAssignment[]>]`: The associated group assignments.
    - `[Id <String>]`: 
    - `[TargetGroupId <String>]`: The ID of the AAD group in which the app provisioning configuration is being targeted.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[Payload <Byte[]>]`: Payload. (UTF8 encoded byte array)
  - `[PayloadFileName <String>]`: Payload file name (.mobileprovision
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this iOS LOB app provisioning configuration entity.
  - `[UserStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>]`: The list of user installation states for this mobile app configuration.
    - `[Id <String>]`: 
    - `[DevicesCount <Int32?>]`: Devices count for that user.
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[Version <Int32?>]`: Version of the device configuration.

IOSMANAGEDAPPPROTECTIONS <IMicrosoftGraphIosManagedAppProtection[]>: iOS managed app policies.
  - `[AppGroupType <TargetedManagedAppGroupType?>]`: Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps
  - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    - `[Id <String>]`: 
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
  - `[TargetedAppManagementLevels <AppManagementLevel?>]`: Management levels for apps
  - `[AllowedDataIngestionLocations <ManagedAppDataIngestionLocation[]>]`: Data storage locations where a user may store managed data.
  - `[AllowedDataStorageLocations <ManagedAppDataStorageLocation[]>]`: Data storage locations where a user may store managed data.
  - `[AllowedInboundDataTransferSources <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
  - `[AllowedOutboundClipboardSharingExceptionLength <Int32?>]`: Specify the number of characters that may be cut or copied from Org data and accounts to any application. This setting overrides the AllowedOutboundClipboardSharingLevel restriction. Default value of '0' means no exception is allowed.
  - `[AllowedOutboundClipboardSharingLevel <ManagedAppClipboardSharingLevel?>]`: Represents the level to which the device's clipboard may be shared between apps
  - `[AllowedOutboundDataTransferDestinations <ManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
  - `[AppActionIfDeviceComplianceRequired <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfMaximumPinRetriesExceeded <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppActionIfUnableToAuthenticateUser <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[BlockDataIngestionIntoOrganizationDocuments <Boolean?>]`: Indicates whether a user can bring data into org documents.
  - `[ContactSyncBlocked <Boolean?>]`: Indicates whether contacts can be synced to the user's device.
  - `[DataBackupBlocked <Boolean?>]`: Indicates whether the backup of a managed app's data is blocked.
  - `[DeviceComplianceRequired <Boolean?>]`: Indicates whether device compliance is required.
  - `[DialerRestrictionLevel <ManagedAppPhoneNumberRedirectLevel?>]`: The classes of apps that are allowed to click-to-open a phone number, for making phone calls or sending text messages.
  - `[DisableAppPinIfDevicePinIsSet <Boolean?>]`: Indicates whether use of the app pin is required if the device pin is set.
  - `[FingerprintBlocked <Boolean?>]`: Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.
  - `[GracePeriodToBlockAppsDuringOffClockHours <TimeSpan?>]`: A grace period before blocking app access during off clock hours.
  - `[ManagedBrowser <ManagedBrowserType?>]`: Type of managed browser
  - `[ManagedBrowserToOpenLinksRequired <Boolean?>]`: Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)
  - `[MaximumAllowedDeviceThreatLevel <ManagedAppDeviceThreatLevel?>]`: The maxium threat level allowed for an app to be compliant.
  - `[MaximumPinRetries <Int32?>]`: Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.
  - `[MaximumRequiredOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
  - `[MaximumWarningOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
  - `[MaximumWipeOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data.
  - `[MinimumPinLength <Int32?>]`: Minimum pin length required for an app-level pin if PinRequired is set to True
  - `[MinimumRequiredAppVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[MinimumRequiredOSVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[MinimumWarningAppVersion <String>]`: Versions less than the specified version will result in warning message on the managed app.
  - `[MinimumWarningOSVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data.
  - `[MinimumWipeAppVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
  - `[MinimumWipeOSVersion <String>]`: Versions less than or equal to the specified version will wipe the managed app and the associated company data.
  - `[MobileThreatDefenseRemediationAction <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[NotificationRestriction <ManagedAppNotificationRestriction?>]`: Restrict managed app notification
  - `[OrganizationalCredentialsRequired <Boolean?>]`: Indicates whether organizational credentials are required for app use.
  - `[PeriodBeforePinReset <TimeSpan?>]`: TimePeriod before the all-level pin must be reset if PinRequired is set to True.
  - `[PeriodOfflineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is not connected to the internet.
  - `[PeriodOfflineBeforeWipeIsEnforced <TimeSpan?>]`: The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.
  - `[PeriodOnlineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is connected to the internet.
  - `[PinCharacterSet <ManagedAppPinCharacterSet?>]`: Character set which is to be used for a user's app PIN
  - `[PinRequired <Boolean?>]`: Indicates whether an app-level pin is required.
  - `[PinRequiredInsteadOfBiometricTimeout <TimeSpan?>]`: Timeout in minutes for an app pin instead of non biometrics passcode
  - `[PreviousPinBlockCount <Int32?>]`: Requires a pin to be unique from the number specified in this property.
  - `[PrintBlocked <Boolean?>]`: Indicates whether printing is allowed from managed apps.
  - `[SaveAsBlocked <Boolean?>]`: Indicates whether users may use the 'Save As' menu item to save a copy of protected files.
  - `[SimplePinBlocked <Boolean?>]`: Indicates whether simplePin is blocked.
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.
  - `[Id <String>]`: 
  - `[AllowedIosDeviceModels <String>]`: Semicolon seperated list of device models allowed, as a string, for the managed app to work.
  - `[AppActionIfIosDeviceModelNotAllowed <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[AppDataEncryptionType <ManagedAppDataEncryptionType?>]`: Represents the level to which app data is encrypted for managed apps
  - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[Id <String>]`: 
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Version <String>]`: Version of the entity.
  - `[CustomBrowserProtocol <String>]`: A custom browser protocol to open weblink on iOS.
  - `[CustomDialerAppProtocol <String>]`: Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.
  - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
  - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
    - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
      - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
      - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[DisplayName <String>]`: Not yet documented
    - `[LastRefreshTime <DateTime?>]`: Not yet documented
    - `[Version <String>]`: Version of the entity.
  - `[DisableProtectionOfManagedOutboundOpenInData <Boolean?>]`: Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps.
  - `[ExemptedAppProtocols <IMicrosoftGraphKeyValuePair[]>]`: Apps in this list will be exempt from the policy and will be able to receive data from managed apps.
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[ExemptedUniversalLinks <String[]>]`: A list of custom urls that are allowed to invocate an unmanaged app
  - `[FaceIdBlocked <Boolean?>]`: Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.
  - `[FilterOpenInToOnlyManagedApps <Boolean?>]`: Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False.
  - `[ManagedUniversalLinks <String[]>]`: A list of custom urls that are allowed to invocate a managed app
  - `[MinimumRequiredSdkVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[MinimumWipeSdkVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data.
  - `[ProtectInboundDataFromUnknownSources <Boolean?>]`: Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps.
  - `[ThirdPartyKeyboardsBlocked <Boolean?>]`: Defines if third party keyboards are allowed while accessing a managed app

MANAGEDAPPPOLICIES <IMicrosoftGraphManagedAppPolicy[]>: Managed app policies.
  - `[Id <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.

MANAGEDAPPREGISTRATIONS <IMicrosoftGraphManagedAppRegistration[]>: The managed app registrations.
  - `[Id <String>]`: 
  - `[AppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ApplicationVersion <String>]`: App version
  - `[AppliedPolicies <IMicrosoftGraphManagedAppPolicy[]>]`: Zero or more policys already applied on the registered app when it last synchronized with managment service.
    - `[Id <String>]`: 
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
  - `[FlaggedReasons <ManagedAppFlaggedReason[]>]`: Zero or more reasons an app registration is flagged. E.g. app running on rooted device
  - `[IntendedPolicies <IMicrosoftGraphManagedAppPolicy[]>]`: Zero or more policies admin intended for the app as of now.
  - `[LastSyncDateTime <DateTime?>]`: Date and time of last the app synced with management service.
  - `[ManagedDeviceId <String>]`: The Managed Device identifier of the host device. Value could be empty even when the host device is managed.
  - `[ManagementSdkVersion <String>]`: App management SDK version
  - `[Operations <IMicrosoftGraphManagedAppOperation[]>]`: Zero or more long running operations triggered on the app registration.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The operation name.
    - `[LastModifiedDateTime <DateTime?>]`: The last time the app operation was modified.
    - `[State <String>]`: The current state of the operation
    - `[Version <String>]`: Version of the entity.
  - `[PlatformVersion <String>]`: Operating System version
  - `[UserId <String>]`: The user Id to who this app registration belongs.
  - `[Version <String>]`: Version of the entity.

MANAGEDAPPSTATUSES <IMicrosoftGraphManagedAppStatus[]>: The managed app statuses.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: Friendly name of the status report.
  - `[Version <String>]`: Version of the entity.

MANAGEDEBOOKCATEGORIES <IMicrosoftGraphManagedEBookCategory[]>: The mobile eBook categories.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The name of the eBook category.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the ManagedEBookCategory was last modified.

MANAGEDEBOOKS <IMicrosoftGraphManagedEBook[]>: The Managed eBook.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphManagedEBookAssignment[]>]`: The list of assignments for this eBook.
    - `[Id <String>]`: 
    - `[InstallIntent <InstallIntent?>]`: Possible values for the install intent chosen by the admin.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[Categories <IMicrosoftGraphManagedEBookCategory[]>]`: The list of categories for this eBook.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The name of the eBook category.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the ManagedEBookCategory was last modified.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the eBook file was created.
  - `[Description <String>]`: Description.
  - `[DeviceStates <IMicrosoftGraphDeviceInstallState[]>]`: The list of installation states for this eBook.
    - `[Id <String>]`: 
    - `[DeviceId <String>]`: Device Id.
    - `[DeviceName <String>]`: Device name.
    - `[ErrorCode <String>]`: The error code for install failures.
    - `[InstallState <InstallState?>]`: Possible values for install state.
    - `[LastSyncDateTime <DateTime?>]`: Last sync date and time.
    - `[OSDescription <String>]`: OS Description.
    - `[OSVersion <String>]`: OS Version.
    - `[UserName <String>]`: Device User Name.
  - `[DisplayName <String>]`: Name of the eBook.
  - `[InformationUrl <String>]`: The more information Url.
  - `[InstallSummary <IMicrosoftGraphEBookInstallSummary>]`: Contains properties for the installation summary of a book for a device.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[FailedDeviceCount <Int32?>]`: Number of Devices that have failed to install this book.
    - `[FailedUserCount <Int32?>]`: Number of Users that have 1 or more device that failed to install this book.
    - `[InstalledDeviceCount <Int32?>]`: Number of Devices that have successfully installed this book.
    - `[InstalledUserCount <Int32?>]`: Number of Users whose devices have all succeeded to install this book.
    - `[NotInstalledDeviceCount <Int32?>]`: Number of Devices that does not have this book installed.
    - `[NotInstalledUserCount <Int32?>]`: Number of Users that did not install this book.
  - `[LargeCover <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: Indicates the content mime type.
    - `[Value <Byte[]>]`: The byte array that contains the actual content.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the eBook was last modified.
  - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
  - `[PublishedDateTime <DateTime?>]`: The date and time when the eBook was published.
  - `[Publisher <String>]`: Publisher.
  - `[UserStateSummary <IMicrosoftGraphUserInstallStateSummary[]>]`: The list of installation states for this eBook.
    - `[Id <String>]`: 
    - `[DeviceStates <IMicrosoftGraphDeviceInstallState[]>]`: The install state of the eBook.
    - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
    - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
    - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
    - `[UserName <String>]`: User name.

MDMWINDOWSINFORMATIONPROTECTIONPOLICIES <IMicrosoftGraphMdmWindowsInformationProtectionPolicy[]>: Windows information protection for apps running on devices which are MDM enrolled.
  - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of security groups targeted for policy.
    - `[Id <String>]`: 
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[AzureRightsManagementServicesAllowed <Boolean?>]`: Specifies whether to allow Azure RMS encryption for WIP
  - `[DataRecoveryCertificate <IMicrosoftGraphWindowsInformationProtectionDataRecoveryCertificate>]`: Windows Information Protection DataRecoveryCertificate
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Certificate <Byte[]>]`: Data recovery Certificate
    - `[Description <String>]`: Data recovery Certificate description
    - `[ExpirationDateTime <DateTime?>]`: Data recovery Certificate expiration datetime
    - `[SubjectName <String>]`: Data recovery Certificate subject name
  - `[EnforcementLevel <WindowsInformationProtectionEnforcementLevel?>]`: Possible values for WIP Protection enforcement levels
  - `[EnterpriseDomain <String>]`: Primary enterprise domain
  - `[EnterpriseIPRanges <IMicrosoftGraphWindowsInformationProtectionIPRangeCollection[]>]`: Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to
    - `[DisplayName <String>]`: Display name
    - `[Ranges <IMicrosoftGraphIPRange[]>]`: Collection of ip ranges
  - `[EnterpriseIPRangesAreAuthoritative <Boolean?>]`: Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false
  - `[EnterpriseInternalProxyServers <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is the comma-separated list of internal proxy servers. For example, '157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59'. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies
    - `[DisplayName <String>]`: Display name
    - `[Resources <String[]>]`: Collection of resources
  - `[EnterpriseNetworkDomainNames <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to
  - `[EnterpriseProtectedDomainNames <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: List of enterprise domains to be protected
  - `[EnterpriseProxiedDomains <IMicrosoftGraphWindowsInformationProtectionProxiedDomainCollection[]>]`: Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy
    - `[DisplayName <String>]`: Display name
    - `[ProxiedDomains <IMicrosoftGraphProxiedDomain[]>]`: Collection of proxied domains
      - `[IPAddressOrFqdn <String>]`: The IP address or FQDN
      - `[Proxy <String>]`: Proxy IP or FQDN
  - `[EnterpriseProxyServers <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is a list of proxy servers. Any server not on this list is considered non-enterprise
  - `[EnterpriseProxyServersAreAuthoritative <Boolean?>]`: Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false
  - `[ExemptAppLockerFiles <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>]`: Another way to input exempt apps through xml files
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The friendly name
    - `[File <Byte[]>]`: File as a byte array
    - `[FileHash <String>]`: SHA256 hash of the file
    - `[Version <String>]`: Version of the entity.
  - `[ExemptApps <IMicrosoftGraphWindowsInformationProtectionApp[]>]`: Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.
    - `[Denied <Boolean?>]`: If true, app is denied protection or exemption.
    - `[Description <String>]`: The app's description.
    - `[DisplayName <String>]`: App display name.
    - `[ProductName <String>]`: The product name.
    - `[PublisherName <String>]`: The publisher name
  - `[IconsVisible <Boolean?>]`: Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app
  - `[IndexingEncryptedStoresOrItemsBlocked <Boolean?>]`: This switch is for the Windows Search Indexer, to allow or disallow indexing of items
  - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
  - `[NeutralDomainResources <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: List of domain names that can used for work or personal resource
  - `[ProtectedAppLockerFiles <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>]`: Another way to input protected apps through xml files
  - `[ProtectedApps <IMicrosoftGraphWindowsInformationProtectionApp[]>]`: Protected applications can access enterprise data and the data handled by those applications are protected with encryption
  - `[ProtectionUnderLockConfigRequired <Boolean?>]`: Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured
  - `[RevokeOnUnenrollDisabled <Boolean?>]`: This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don't revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.
  - `[RightsManagementServicesTemplateId <String>]`: TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access
  - `[SmbAutoEncryptedFileExtensions <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.
  - `[Id <String>]`: 

MOBILEAPPCATEGORIES <IMicrosoftGraphMobileAppCategory[]>: The mobile app categories.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The name of the app category.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.

MOBILEAPPCONFIGURATIONS <IMicrosoftGraphManagedDeviceMobileAppConfiguration[]>: The Managed Device Mobile Application Configurations.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]>]`: The list of group assignemenets for app configration.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
  - `[Description <String>]`: Admin provided description of the Device Configuration.
  - `[DeviceStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary>]`: Contains properties, inherited properties and actions for an MDM mobile app configuration device status summary.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ConflictCount <Int32?>]`: Number of devices in conflict
    - `[ErrorCount <Int32?>]`: Number of error devices
    - `[FailedCount <Int32?>]`: Number of failed devices
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
    - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
    - `[PendingCount <Int32?>]`: Number of pending devices
    - `[SuccessCount <Int32?>]`: Number of succeeded devices
  - `[DeviceStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus[]>]`: List of ManagedDeviceMobileAppConfigurationDeviceStatus.
    - `[Id <String>]`: 
    - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
    - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
    - `[DeviceModel <String>]`: The device model that is being reported
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Platform <Int32?>]`: Platform of the device that is being reported
    - `[Status <String>]`: complianceStatus
    - `[UserName <String>]`: The User Name that is being reported
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[DisplayName <String>]`: Admin provided name of the device configuration.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this App configuration entity.
  - `[TargetedMobileApps <String[]>]`: the associated app.
  - `[UserStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary>]`: Contains properties, inherited properties and actions for an MDM mobile app configuration user status summary.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ConflictCount <Int32?>]`: Number of users in conflict
    - `[ErrorCount <Int32?>]`: Number of error Users
    - `[FailedCount <Int32?>]`: Number of failed Users
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable users
    - `[PendingCount <Int32?>]`: Number of pending Users
    - `[SuccessCount <Int32?>]`: Number of succeeded Users
  - `[UserStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>]`: List of ManagedDeviceMobileAppConfigurationUserStatus.
    - `[Id <String>]`: 
    - `[DevicesCount <Int32?>]`: Devices count for that user.
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[Version <Int32?>]`: Version of the device configuration.

MOBILEAPPS <IMicrosoftGraphMobileApp[]>: The mobile apps.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphMobileAppAssignment[]>]`: The list of group assignments for this mobile app.
    - `[Id <String>]`: 
    - `[Intent <InstallIntent?>]`: Possible values for the install intent chosen by the admin.
    - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: Abstract class to contain properties used to assign a mobile app to a group.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: The identifier of the source of the assignment.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[Categories <IMicrosoftGraphMobileAppCategory[]>]`: The list of categories for this app.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The name of the app category.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.
  - `[CreatedDateTime <DateTime?>]`: The date and time the app was created.
  - `[DependentAppCount <Int32?>]`: The total number of dependencies the child app has.
  - `[Description <String>]`: The description of the app.
  - `[Developer <String>]`: The developer of the app.
  - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The list of installation states for this mobile app.
    - `[Id <String>]`: 
    - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
    - `[DeviceId <String>]`: Device ID
    - `[DeviceName <String>]`: Device name
    - `[DisplayVersion <String>]`: Human readable version of the application
    - `[ErrorCode <Int32?>]`: The error code for install or uninstall failures.
    - `[InstallState <ResultantAppState?>]`: A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.
    - `[InstallStateDetail <ResultantAppStateDetail?>]`: Enum indicating additional details regarding why an application has a particular install state.
    - `[LastSyncDateTime <DateTime?>]`: Last sync date time
    - `[MobileAppInstallStatusValue <ResultantAppState?>]`: A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.
    - `[OSDescription <String>]`: OS Description
    - `[OSVersion <String>]`: OS Version
    - `[UserName <String>]`: Device User Name
    - `[UserPrincipalName <String>]`: User Principal Name
  - `[DisplayName <String>]`: The admin provided or imported title of the app.
  - `[InformationUrl <String>]`: The more information Url.
  - `[InstallSummary <IMicrosoftGraphMobileAppInstallSummary>]`: Contains properties for the installation summary of a mobile app.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[FailedDeviceCount <Int32?>]`: Number of Devices that have failed to install this app.
    - `[FailedUserCount <Int32?>]`: Number of Users that have 1 or more device that failed to install this app.
    - `[InstalledDeviceCount <Int32?>]`: Number of Devices that have successfully installed this app.
    - `[InstalledUserCount <Int32?>]`: Number of Users whose devices have all succeeded to install this app.
    - `[NotApplicableDeviceCount <Int32?>]`: Number of Devices that are not applicable for this app.
    - `[NotApplicableUserCount <Int32?>]`: Number of Users whose devices were all not applicable for this app.
    - `[NotInstalledDeviceCount <Int32?>]`: Number of Devices that does not have this app installed.
    - `[NotInstalledUserCount <Int32?>]`: Number of Users that have 1 or more devices that did not install this app.
    - `[PendingInstallDeviceCount <Int32?>]`: Number of Devices that have been notified to install this app.
    - `[PendingInstallUserCount <Int32?>]`: Number of Users that have 1 or more device that have been notified to install this app and have 0 devices with failures.
  - `[IsAssigned <Boolean?>]`: The value indicating whether the app is assigned to at least one group.
  - `[IsFeatured <Boolean?>]`: The value indicating whether the app is marked as featured by the admin.
  - `[LargeIcon <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: Indicates the content mime type.
    - `[Value <Byte[]>]`: The byte array that contains the actual content.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the app was last modified.
  - `[Notes <String>]`: Notes for the app.
  - `[Owner <String>]`: The owner of the app.
  - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
  - `[Publisher <String>]`: The publisher of the app.
  - `[PublishingState <MobileAppPublishingState?>]`: Indicates the publishing state of an app.
  - `[Relationships <IMicrosoftGraphMobileAppRelationship[]>]`: List of relationships for this mobile app.
    - `[Id <String>]`: 
    - `[TargetDisplayName <String>]`: The target mobile app's display name.
    - `[TargetDisplayVersion <String>]`: The target mobile app's display version.
    - `[TargetId <String>]`: The target mobile app's app id.
    - `[TargetPublisher <String>]`: The target mobile app's publisher.
    - `[TargetType <MobileAppRelationshipType?>]`: Indicates whether the target of a relationship is the parent or the child in the relationship.
  - `[RoleScopeTagIds <String[]>]`: List of scope tag ids for this mobile app.
  - `[SupersededAppCount <Int32?>]`: The total number of apps this app is directly or indirectly superseded by.
  - `[SupersedingAppCount <Int32?>]`: The total number of apps this app directly or indirectly supersedes.
  - `[UploadState <Int32?>]`: The upload state.
  - `[UserStatuses <IMicrosoftGraphUserAppInstallStatus[]>]`: The list of installation states for this mobile app.
    - `[Id <String>]`: 
    - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
    - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The install state of the app on devices.
    - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
    - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
    - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
    - `[UserName <String>]`: User name.
    - `[UserPrincipalName <String>]`: User Principal Name.

POLICYSETS <IMicrosoftGraphPolicySet[]>: The PolicySet of Policies and Applications
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphPolicySetAssignment[]>]`: Assignments of the PolicySet.
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySetAssignment.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CreatedDateTime <DateTime?>]`: Creation time of the PolicySet.
  - `[Description <String>]`: Description of the PolicySet.
  - `[DisplayName <String>]`: DisplayName of the PolicySet.
  - `[ErrorCode <ErrorCode?>]`: errorCode
  - `[GuidedDeploymentTags <String[]>]`: Tags of the guided deployment
  - `[Items <IMicrosoftGraphPolicySetItem[]>]`: Items of the PolicySet with maximum count 100.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: Creation time of the PolicySetItem.
    - `[DisplayName <String>]`: DisplayName of the PolicySetItem.
    - `[ErrorCode <ErrorCode?>]`: errorCode
    - `[GuidedDeploymentTags <String[]>]`: Tags of the guided deployment
    - `[ItemType <String>]`: policySetType of the PolicySetItem.
    - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySetItem.
    - `[PayloadId <String>]`: PayloadId of the PolicySetItem.
    - `[Status <PolicySetStatus?>]`: The enum to specify the status of PolicySet.
  - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySet.
  - `[RoleScopeTags <String[]>]`: RoleScopeTags of the PolicySet
  - `[Status <PolicySetStatus?>]`: The enum to specify the status of PolicySet.

SIDELOADINGKEYS <IMicrosoftGraphSideLoadingKey[]>: Side Loading Keys that are required for the Windows 8 and 8.1 Apps installation.
  - `[Id <String>]`: 
  - `[Description <String>]`: Side Loading Key description displayed to the ITPro Admins..
  - `[DisplayName <String>]`: Side Loading Key Name displayed to the ITPro Admins.
  - `[LastUpdatedDateTime <String>]`: Side Loading Key Last Updated Date displayed to the ITPro Admins.
  - `[TotalActivation <Int32?>]`: Side Loading Key Total Activation displayed to the ITPro Admins.
  - `[Value <String>]`: Side Loading Key Value, it is 5x5 value, seperated by hiphens.

SYMANTECCODESIGNINGCERTIFICATE <IMicrosoftGraphSymantecCodeSigningCertificate>: symantecCodeSigningCertificate
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Content <Byte[]>]`: The Windows Symantec Code-Signing Certificate in the raw data format.
  - `[ExpirationDateTime <DateTime?>]`: The Cert Expiration Date.
  - `[Issuer <String>]`: The Issuer value for the cert.
  - `[IssuerName <String>]`: The Issuer Name for the cert.
  - `[Password <String>]`: The Password required for .pfx file.
  - `[Status <String>]`: certificateStatus
  - `[Subject <String>]`: The Subject value for the cert.
  - `[SubjectName <String>]`: The Subject Name for the cert.
  - `[UploadDateTime <DateTime?>]`: The Type of the CodeSigning Cert as Symantec Cert.

TARGETEDMANAGEDAPPCONFIGURATIONS <IMicrosoftGraphTargetedManagedAppConfiguration[]>: Targeted managed app configurations.
  - `[CustomSettings <IMicrosoftGraphKeyValuePair[]>]`: A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.
  - `[Id <String>]`: 
  - `[AppGroupType <TargetedManagedAppGroupType?>]`: Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps
  - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[Id <String>]`: 
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Version <String>]`: Version of the entity.
  - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    - `[Id <String>]`: 
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
  - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
    - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
      - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
      - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[DisplayName <String>]`: Not yet documented
    - `[LastRefreshTime <DateTime?>]`: Not yet documented
    - `[Version <String>]`: Version of the entity.
  - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.

VPPTOKENS <IMicrosoftGraphVppToken[]>: List of Vpp tokens for this organization.
  - `[Id <String>]`: 
  - `[AppleId <String>]`: The apple Id associated with the given Apple Volume Purchase Program Token.
  - `[AutomaticallyUpdateApps <Boolean?>]`: Whether or not apps for the VPP token will be automatically updated.
  - `[ClaimTokenManagementFromExternalMdm <Boolean?>]`: Admin consent to allow claiming token management from external MDM.
  - `[CountryOrRegion <String>]`: Whether or not apps for the VPP token will be automatically updated.
  - `[DataSharingConsentGranted <Boolean?>]`: Consent granted for data sharing with the Apple Volume Purchase Program.
  - `[DisplayName <String>]`: An admin specified token friendly name.
  - `[ExpirationDateTime <DateTime?>]`: The expiration date time of the Apple Volume Purchase Program Token.
  - `[LastModifiedDateTime <DateTime?>]`: Last modification date time associated with the Apple Volume Purchase Program Token.
  - `[LastSyncDateTime <DateTime?>]`: The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.
  - `[LastSyncStatus <VppTokenSyncStatus?>]`: Possible sync statuses associated with an Apple Volume Purchase Program token.
  - `[LocationName <String>]`: Token location returned from Apple VPP.
  - `[OrganizationName <String>]`: The organization associated with the Apple Volume Purchase Program Token
  - `[RoleScopeTagIds <String[]>]`: Role Scope Tags IDs assigned to this entity.
  - `[State <VppTokenState?>]`: Possible states associated with an Apple Volume Purchase Program token.
  - `[Token <String>]`: The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.
  - `[TokenActionResults <IMicrosoftGraphVppTokenActionResult[]>]`: The collection of statuses of the actions performed on the Apple Volume Purchase Program Token.
    - `[ActionName <String>]`: Action name
    - `[ActionState <String>]`: actionState
    - `[LastUpdatedDateTime <DateTime?>]`: Time the action state was last updated
    - `[StartDateTime <DateTime?>]`: Time the action was initiated
  - `[VppTokenAccountType <VppTokenAccountType?>]`: Possible types of an Apple Volume Purchase Program token.

WDACSUPPLEMENTALPOLICIES <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy[]>: The collection of Windows Defender Application Control Supplemental Policies.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]`: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[Content <Byte[]>]`: The WindowsDefenderApplicationControl supplemental policy content in byte array format.
  - `[ContentFileName <String>]`: The WindowsDefenderApplicationControl supplemental policy content's file name.
  - `[CreationDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.
  - `[DeploySummary <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>]`: Contains properties for the deployment summary of a WindowsDefenderApplicationControl supplemental policy.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
    - `[FailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
  - `[Description <String>]`: The description of WindowsDefenderApplicationControl supplemental policy.
  - `[DeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
    - `[Id <String>]`: 
    - `[DeploymentStatus <WindowsDefenderApplicationControlSupplementalPolicyStatuses?>]`: Enum values for the various WindowsDefenderApplicationControl supplemental policy deployment statuses.
    - `[DeviceId <String>]`: Device ID.
    - `[DeviceName <String>]`: Device name.
    - `[LastSyncDateTime <DateTime?>]`: Last sync date time.
    - `[OSDescription <String>]`: Windows OS Version Description.
    - `[OSVersion <String>]`: Windows OS Version.
    - `[Policy <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy>]`: windowsDefenderApplicationControlSupplementalPolicy
    - `[PolicyVersion <String>]`: Human readable version of the WindowsDefenderApplicationControl supplemental policy.
    - `[UserName <String>]`: The name of the user of this device.
    - `[UserPrincipalName <String>]`: User Principal Name.
  - `[DisplayName <String>]`: The display name of WindowsDefenderApplicationControl supplemental policy.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.
  - `[Version <String>]`: The WindowsDefenderApplicationControl supplemental policy's version.

WINDOWSINFORMATIONPROTECTIONDEVICEREGISTRATIONS <IMicrosoftGraphWindowsInformationProtectionDeviceRegistration[]>: Windows information protection device registrations that are not MDM enrolled.
  - `[Id <String>]`: 
  - `[DeviceMacAddress <String>]`: Device Mac address.
  - `[DeviceName <String>]`: Device name.
  - `[DeviceRegistrationId <String>]`: Device identifier for this device registration record.
  - `[DeviceType <String>]`: Device type, for example, Windows laptop VS Windows phone.
  - `[LastCheckInDateTime <DateTime?>]`: Last checkin time of the device.
  - `[UserId <String>]`: UserId associated with this device registration record.

WINDOWSINFORMATIONPROTECTIONPOLICIES <IMicrosoftGraphWindowsInformationProtectionPolicy[]>: Windows information protection for apps running on devices which are not MDM enrolled.
  - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of security groups targeted for policy.
    - `[Id <String>]`: 
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[AzureRightsManagementServicesAllowed <Boolean?>]`: Specifies whether to allow Azure RMS encryption for WIP
  - `[DataRecoveryCertificate <IMicrosoftGraphWindowsInformationProtectionDataRecoveryCertificate>]`: Windows Information Protection DataRecoveryCertificate
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Certificate <Byte[]>]`: Data recovery Certificate
    - `[Description <String>]`: Data recovery Certificate description
    - `[ExpirationDateTime <DateTime?>]`: Data recovery Certificate expiration datetime
    - `[SubjectName <String>]`: Data recovery Certificate subject name
  - `[EnforcementLevel <WindowsInformationProtectionEnforcementLevel?>]`: Possible values for WIP Protection enforcement levels
  - `[EnterpriseDomain <String>]`: Primary enterprise domain
  - `[EnterpriseIPRanges <IMicrosoftGraphWindowsInformationProtectionIPRangeCollection[]>]`: Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to
    - `[DisplayName <String>]`: Display name
    - `[Ranges <IMicrosoftGraphIPRange[]>]`: Collection of ip ranges
  - `[EnterpriseIPRangesAreAuthoritative <Boolean?>]`: Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false
  - `[EnterpriseInternalProxyServers <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is the comma-separated list of internal proxy servers. For example, '157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59'. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies
    - `[DisplayName <String>]`: Display name
    - `[Resources <String[]>]`: Collection of resources
  - `[EnterpriseNetworkDomainNames <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to
  - `[EnterpriseProtectedDomainNames <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: List of enterprise domains to be protected
  - `[EnterpriseProxiedDomains <IMicrosoftGraphWindowsInformationProtectionProxiedDomainCollection[]>]`: Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy
    - `[DisplayName <String>]`: Display name
    - `[ProxiedDomains <IMicrosoftGraphProxiedDomain[]>]`: Collection of proxied domains
      - `[IPAddressOrFqdn <String>]`: The IP address or FQDN
      - `[Proxy <String>]`: Proxy IP or FQDN
  - `[EnterpriseProxyServers <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: This is a list of proxy servers. Any server not on this list is considered non-enterprise
  - `[EnterpriseProxyServersAreAuthoritative <Boolean?>]`: Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false
  - `[ExemptAppLockerFiles <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>]`: Another way to input exempt apps through xml files
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The friendly name
    - `[File <Byte[]>]`: File as a byte array
    - `[FileHash <String>]`: SHA256 hash of the file
    - `[Version <String>]`: Version of the entity.
  - `[ExemptApps <IMicrosoftGraphWindowsInformationProtectionApp[]>]`: Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.
    - `[Denied <Boolean?>]`: If true, app is denied protection or exemption.
    - `[Description <String>]`: The app's description.
    - `[DisplayName <String>]`: App display name.
    - `[ProductName <String>]`: The product name.
    - `[PublisherName <String>]`: The publisher name
  - `[IconsVisible <Boolean?>]`: Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app
  - `[IndexingEncryptedStoresOrItemsBlocked <Boolean?>]`: This switch is for the Windows Search Indexer, to allow or disallow indexing of items
  - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
  - `[NeutralDomainResources <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: List of domain names that can used for work or personal resource
  - `[ProtectedAppLockerFiles <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>]`: Another way to input protected apps through xml files
  - `[ProtectedApps <IMicrosoftGraphWindowsInformationProtectionApp[]>]`: Protected applications can access enterprise data and the data handled by those applications are protected with encryption
  - `[ProtectionUnderLockConfigRequired <Boolean?>]`: Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured
  - `[RevokeOnUnenrollDisabled <Boolean?>]`: This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don't revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.
  - `[RightsManagementServicesTemplateId <String>]`: TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access
  - `[SmbAutoEncryptedFileExtensions <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]`: Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.
  - `[Id <String>]`: 
  - `[DaysWithoutContactBeforeUnenroll <Int32?>]`: Offline interval before app data is wiped (days)
  - `[MdmEnrollmentUrl <String>]`: Enrollment url for the MDM
  - `[MinutesOfInactivityBeforeDeviceLock <Int32?>]`: Specifies the maximum amount of time (in minutes) allowed after the device is idle that will cause the device to become PIN or password locked.   Range is an integer X where 0 <= X <= 999.
  - `[NumberOfPastPinsRemembered <Int32?>]`: Integer value that specifies the number of past PINs that can be associated to a user account that can't be reused. The largest number you can configure for this policy setting is 50. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then storage of previous PINs is not required. This node was added in Windows 10, version 1511. Default is 0.
  - `[PasswordMaximumAttemptCount <Int32?>]`: The number of authentication failures allowed before the device will be wiped. A value of 0 disables device wipe functionality. Range is an integer X where 4 <= X <= 16 for desktop and 0 <= X <= 999 for mobile devices.
  - `[PinExpirationDays <Int32?>]`: Integer value specifies the period of time (in days) that a PIN can be used before the system requires the user to change it. The largest number you can configure for this policy setting is 730. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then the user's PIN will never expire. This node was added in Windows 10, version 1511. Default is 0.
  - `[PinLowercaseLetters <WindowsInformationProtectionPinCharacterRequirements?>]`: Pin Character Requirements
  - `[PinMinimumLength <Int32?>]`: Integer value that sets the minimum number of characters required for the PIN. Default value is 4. The lowest number you can configure for this policy setting is 4. The largest number you can configure must be less than the number configured in the Maximum PIN length policy setting or the number 127, whichever is the lowest.
  - `[PinSpecialCharacters <WindowsInformationProtectionPinCharacterRequirements?>]`: Pin Character Requirements
  - `[PinUppercaseLetters <WindowsInformationProtectionPinCharacterRequirements?>]`: Pin Character Requirements
  - `[RevokeOnMdmHandoffDisabled <Boolean?>]`: New property in RS2, pending documentation
  - `[WindowsHelloForBusinessBlocked <Boolean?>]`: Boolean value that sets Windows Hello for Business as a method for signing into Windows.

WINDOWSINFORMATIONPROTECTIONWIPEACTIONS <IMicrosoftGraphWindowsInformationProtectionWipeAction[]>: Windows information protection wipe actions.
  - `[Id <String>]`: 
  - `[LastCheckInDateTime <DateTime?>]`: Last checkin time of the device that was targeted by this wipe action.
  - `[Status <String>]`: actionState
  - `[TargetedDeviceMacAddress <String>]`: Targeted device Mac address.
  - `[TargetedDeviceName <String>]`: Targeted device name.
  - `[TargetedDeviceRegistrationId <String>]`: The DeviceRegistrationId being targeted by this wipe action.
  - `[TargetedUserId <String>]`: The UserId being targeted by this wipe action.

WINDOWSMANAGEDAPPPROTECTIONS <IMicrosoftGraphWindowsManagedAppProtection[]>: Windows managed app policies.
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.
  - `[Id <String>]`: 
  - `[AllowedInboundDataTransferSources <WindowsManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
  - `[AllowedOutboundClipboardSharingLevel <WindowsManagedAppClipboardSharingLevel?>]`: Represents the level to which the device's clipboard may be shared between apps
  - `[AllowedOutboundDataTransferDestinations <WindowsManagedAppDataTransferLevel?>]`: Data can be transferred from/to these classes of apps
  - `[AppActionIfUnableToAuthenticateUser <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[Id <String>]`: 
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Version <String>]`: Version of the entity.
  - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    - `[Id <String>]`: 
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[DeployedAppCount <Int32?>]`: Indicates the total number of applications for which the current policy is deployed.
  - `[IsAssigned <Boolean?>]`: When TRUE, indicates that the policy is deployed to some inclusion groups. When FALSE, indicates that the policy is not deployed to any inclusion groups. Default value is FALSE.
  - `[MaximumAllowedDeviceThreatLevel <ManagedAppDeviceThreatLevel?>]`: The maxium threat level allowed for an app to be compliant.
  - `[MaximumRequiredOSVersion <String>]`: Versions bigger than the specified version will block the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
  - `[MaximumWarningOSVersion <String>]`: Versions bigger than the specified version will result in warning message on the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
  - `[MaximumWipeOSVersion <String>]`: Versions bigger than the specified version will wipe the managed app and the associated company data. For example: '8.1.0' or '13.1.1'.
  - `[MinimumRequiredAppVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
  - `[MinimumRequiredOSVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
  - `[MinimumRequiredSdkVersion <String>]`: Versions less than the specified version will block the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
  - `[MinimumWarningAppVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
  - `[MinimumWarningOSVersion <String>]`: Versions less than the specified version will result in warning message on the managed app from accessing company data. For example: '8.1.0' or '13.1.1'.
  - `[MinimumWipeAppVersion <String>]`: Versions less than the specified version will wipe the managed app and the associated company data. For example: '8.1.0' or '13.1.1'.
  - `[MinimumWipeOSVersion <String>]`: Versions less than the specified version will wipe the managed app and the associated company data. For example: '8.1.0' or '13.1.1'.
  - `[MinimumWipeSdkVersion <String>]`: Versions less than the specified version will wipe the managed app and the associated company data. For example: '8.1.0' or '13.1.1'.
  - `[MobileThreatDefenseRemediationAction <ManagedAppRemediationAction?>]`: An admin initiated action to be applied on a managed app.
  - `[PeriodOfflineBeforeAccessCheck <TimeSpan?>]`: The period after which access is checked when the device is not connected to the internet. For example, PT5M indicates that the interval is 5 minutes in duration. A timespan value of PT0S indicates that access will be blocked immediately when the device is not connected to the internet.
  - `[PeriodOfflineBeforeWipeIsEnforced <TimeSpan?>]`: The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped. For example, P5D indicates that the interval is 5 days in duration. A timespan value of PT0S indicates that managed data will never be wiped when the device is not connected to the internet.
  - `[PrintBlocked <Boolean?>]`: When TRUE, indicates that printing is blocked from managed apps. When FALSE, indicates that printing is allowed from managed apps. Default value is FALSE.

WINDOWSMANAGEMENTAPP <IMicrosoftGraphWindowsManagementApp>: Windows management app entity.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AvailableVersion <String>]`: Windows management app available version.
  - `[HealthStates <IMicrosoftGraphWindowsManagementAppHealthState[]>]`: The list of health states for installed Windows management app.
    - `[Id <String>]`: 
    - `[DeviceName <String>]`: Name of the device on which Windows management app is installed.
    - `[DeviceOSVersion <String>]`: Windows 10 OS version of the device on which Windows management app is installed.
    - `[HealthState <HealthState?>]`: Indicates health state of the Windows management app.
    - `[InstalledVersion <String>]`: Windows management app installed version.
    - `[LastCheckInDateTime <DateTime?>]`: Windows management app last check-in time.
  - `[ManagedInstaller <ManagedInstallerStatus?>]`: ManagedInstallerStatus
  - `[ManagedInstallerConfiguredDateTime <String>]`: Managed Installer Configured Date Time

## RELATED LINKS

