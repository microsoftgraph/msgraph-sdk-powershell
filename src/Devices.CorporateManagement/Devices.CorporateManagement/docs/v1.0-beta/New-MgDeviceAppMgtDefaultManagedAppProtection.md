---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtdefaultmanagedappprotection
schema: 2.0.0
---

# New-MgDeviceAppMgtDefaultManagedAppProtection

## SYNOPSIS
Create new navigation property to defaultManagedAppProtections for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppMgtDefaultManagedAppProtection [-AdditionalProperties <Hashtable>]
 [-AllowedAndroidDeviceManufacturers <String>] [-AllowedAndroidDeviceModels <String[]>]
 [-AllowedDataIngestionLocations <ManagedAppDataIngestionLocation[]>]
 [-AllowedDataStorageLocations <ManagedAppDataStorageLocation[]>]
 [-AllowedInboundDataTransferSources <ManagedAppDataTransferLevel>] [-AllowedIosDeviceModels <String>]
 [-AllowedOutboundClipboardSharingExceptionLength <Int32>]
 [-AllowedOutboundClipboardSharingLevel <ManagedAppClipboardSharingLevel>]
 [-AllowedOutboundDataTransferDestinations <ManagedAppDataTransferLevel>]
 [-AppActionIfAndroidDeviceManufacturerNotAllowed <ManagedAppRemediationAction>]
 [-AppActionIfAndroidDeviceModelNotAllowed <ManagedAppRemediationAction>]
 [-AppActionIfAndroidSafetyNetAppsVerificationFailed <ManagedAppRemediationAction>]
 [-AppActionIfAndroidSafetyNetDeviceAttestationFailed <ManagedAppRemediationAction>]
 [-AppActionIfDeviceComplianceRequired <ManagedAppRemediationAction>]
 [-AppActionIfDeviceLockNotSet <ManagedAppRemediationAction>]
 [-AppActionIfDevicePasscodeComplexityLessThanHigh <ManagedAppRemediationAction>]
 [-AppActionIfDevicePasscodeComplexityLessThanLow <ManagedAppRemediationAction>]
 [-AppActionIfDevicePasscodeComplexityLessThanMedium <ManagedAppRemediationAction>]
 [-AppActionIfIosDeviceModelNotAllowed <ManagedAppRemediationAction>]
 [-AppActionIfMaximumPinRetriesExceeded <ManagedAppRemediationAction>]
 [-AppActionIfUnableToAuthenticateUser <ManagedAppRemediationAction>]
 [-AppDataEncryptionType <ManagedAppDataEncryptionType>] [-Apps <IMicrosoftGraphManagedMobileApp[]>]
 [-BiometricAuthenticationBlocked] [-BlockAfterCompanyPortalUpdateDeferralInDays <Int32>]
 [-BlockDataIngestionIntoOrganizationDocuments] [-ConnectToVpnOnLaunch] [-ContactSyncBlocked]
 [-CreatedDateTime <DateTime>] [-CustomBrowserDisplayName <String>] [-CustomBrowserPackageId <String>]
 [-CustomBrowserProtocol <String>] [-CustomDialerAppDisplayName <String>] [-CustomDialerAppPackageId <String>]
 [-CustomDialerAppProtocol <String>] [-CustomSettings <IMicrosoftGraphKeyValuePair[]>] [-DataBackupBlocked]
 [-DeployedAppCount <Int32>] [-DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]
 [-Description <String>] [-DeviceComplianceRequired] [-DeviceLockRequired]
 [-DialerRestrictionLevel <ManagedAppPhoneNumberRedirectLevel>]
 [-DisableAppEncryptionIfDeviceEncryptionIsEnabled] [-DisableAppPinIfDevicePinIsSet]
 [-DisableProtectionOfManagedOutboundOpenInData] [-DisplayName <String>] [-EncryptAppData]
 [-ExemptedAppPackages <IMicrosoftGraphKeyValuePair[]>]
 [-ExemptedAppProtocols <IMicrosoftGraphKeyValuePair[]>] [-FaceIdBlocked] [-FilterOpenInToOnlyManagedApps]
 [-FingerprintAndBiometricEnabled] [-FingerprintBlocked]
 [-GracePeriodToBlockAppsDuringOffClockHours <TimeSpan>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-ManagedBrowser <ManagedBrowserType>] [-ManagedBrowserToOpenLinksRequired]
 [-MaximumAllowedDeviceThreatLevel <ManagedAppDeviceThreatLevel>] [-MaximumPinRetries <Int32>]
 [-MaximumRequiredOSVersion <String>] [-MaximumWarningOSVersion <String>] [-MaximumWipeOSVersion <String>]
 [-MinimumPinLength <Int32>] [-MinimumRequiredAppVersion <String>]
 [-MinimumRequiredCompanyPortalVersion <String>] [-MinimumRequiredOSVersion <String>]
 [-MinimumRequiredPatchVersion <String>] [-MinimumRequiredSdkVersion <String>]
 [-MinimumWarningAppVersion <String>] [-MinimumWarningCompanyPortalVersion <String>]
 [-MinimumWarningOSVersion <String>] [-MinimumWarningPatchVersion <String>] [-MinimumWipeAppVersion <String>]
 [-MinimumWipeCompanyPortalVersion <String>] [-MinimumWipeOSVersion <String>]
 [-MinimumWipePatchVersion <String>] [-MinimumWipeSdkVersion <String>]
 [-MobileThreatDefenseRemediationAction <ManagedAppRemediationAction>]
 [-NotificationRestriction <ManagedAppNotificationRestriction>] [-OrganizationalCredentialsRequired]
 [-PeriodBeforePinReset <TimeSpan>] [-PeriodOfflineBeforeAccessCheck <TimeSpan>]
 [-PeriodOfflineBeforeWipeIsEnforced <TimeSpan>] [-PeriodOnlineBeforeAccessCheck <TimeSpan>]
 [-PinCharacterSet <ManagedAppPinCharacterSet>] [-PinRequired]
 [-PinRequiredInsteadOfBiometricTimeout <TimeSpan>] [-PreviousPinBlockCount <Int32>] [-PrintBlocked]
 [-ProtectInboundDataFromUnknownSources] [-RequireClass3Biometrics]
 [-RequiredAndroidSafetyNetAppsVerificationType <AndroidManagedAppSafetyNetAppsVerificationType>]
 [-RequiredAndroidSafetyNetDeviceAttestationType <AndroidManagedAppSafetyNetDeviceAttestationType>]
 [-RequiredAndroidSafetyNetEvaluationType <AndroidManagedAppSafetyNetEvaluationType>]
 [-RequirePinAfterBiometricChange] [-RoleScopeTagIds <String[]>] [-SaveAsBlocked] [-ScreenCaptureBlocked]
 [-SimplePinBlocked] [-ThirdPartyKeyboardsBlocked] [-Version <String>]
 [-WarnAfterCompanyPortalUpdateDeferralInDays <Int32>] [-WipeAfterCompanyPortalUpdateDeferralInDays <Int32>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtDefaultManagedAppProtection -BodyParameter <IMicrosoftGraphDefaultManagedAppProtection>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to defaultManagedAppProtections for deviceAppManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedAndroidDeviceManufacturers
Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work.
(Android only)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedAndroidDeviceModels
List of device models allowed, as a string, for the managed app to work.
(Android Only)

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedDataIngestionLocations
Data storage locations where a user may store managed data.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppDataIngestionLocation[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedIosDeviceModels
Semicolon seperated list of device models allowed, as a string, for the managed app to work.
(iOS Only)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedOutboundClipboardSharingExceptionLength
Specify the number of characters that may be cut or copied from Org data and accounts to any application.
This setting overrides the AllowedOutboundClipboardSharingLevel restriction.
Default value of '0' means no exception is allowed.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfAndroidDeviceManufacturerNotAllowed
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfAndroidDeviceModelNotAllowed
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfAndroidSafetyNetAppsVerificationFailed
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfAndroidSafetyNetDeviceAttestationFailed
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfDeviceComplianceRequired
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfDeviceLockNotSet
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfDevicePasscodeComplexityLessThanHigh
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfDevicePasscodeComplexityLessThanLow
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfDevicePasscodeComplexityLessThanMedium
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfIosDeviceModelNotAllowed
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfMaximumPinRetriesExceeded
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActionIfUnableToAuthenticateUser
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppDataEncryptionType
Represents the level to which app data is encrypted for managed apps

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppDataEncryptionType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Apps
List of apps to which the policy is deployed.
To construct, please use Get-Help -Online and see NOTES section for APPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedMobileApp[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BiometricAuthenticationBlocked
Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True.
(Android Only)

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockAfterCompanyPortalUpdateDeferralInDays
Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockDataIngestionIntoOrganizationDocuments
Indicates whether a user can bring data into org documents.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Policy used to configure detailed management settings for a specified set of apps for all users not targeted by a TargetedManagedAppProtection Policy
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDefaultManagedAppProtection
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConnectToVpnOnLaunch
Whether the app should connect to the configured VPN on launch (Android only).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContactSyncBlocked
Indicates whether contacts can be synced to the user's device.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomBrowserDisplayName
Friendly name of the preferred custom browser to open weblink on Android.
(Android only)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomBrowserPackageId
Unique identifier of a custom browser to open weblink on Android.
(Android only)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomBrowserProtocol
A custom browser protocol to open weblink on iOS.
(iOS only)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomDialerAppDisplayName
Friendly name of a custom dialer app to click-to-open a phone number on Android.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomDialerAppPackageId
PackageId of a custom dialer app to click-to-open a phone number on Android.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomDialerAppProtocol
Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomSettings
A set of string key and string value pairs to be sent to the affected users, unalterned by this service
To construct, please use Get-Help -Online and see NOTES section for CUSTOMSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentSummary
The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
To construct, please use Get-Help -Online and see NOTES section for DEPLOYMENTSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicyDeploymentSummary
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceLockRequired
Defines if any kind of lock must be required on device.
(android only)

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DialerRestrictionLevel
The classes of apps that are allowed to click-to-open a phone number, for making phone calls or sending text messages.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppPhoneNumberRedirectLevel
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableAppEncryptionIfDeviceEncryptionIsEnabled
When this setting is enabled, app level encryption is disabled if device level encryption is enabled.
(Android only)

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisableProtectionOfManagedOutboundOpenInData
Disable protection of data transferred to other apps through IOS OpenIn option.
This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps.
(iOS Only)

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EncryptAppData
Indicates whether managed-app data should be encrypted.
(Android only)

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExemptedAppPackages
Android App packages in this list will be exempt from the policy and will be able to receive data from managed apps.
(Android only)
To construct, please use Get-Help -Online and see NOTES section for EXEMPTEDAPPPACKAGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExemptedAppProtocols
iOS Apps in this list will be exempt from the policy and will be able to receive data from managed apps.
(iOS Only)
To construct, please use Get-Help -Online and see NOTES section for EXEMPTEDAPPPROTOCOLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FaceIdBlocked
Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.
(iOS Only)

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterOpenInToOnlyManagedApps
Defines if open-in operation is supported from the managed app to the filesharing locations selected.
This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False.
(iOS Only)

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FingerprintAndBiometricEnabled
Indicate to the client to enable both biometrics and fingerprints for the app.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GracePeriodToBlockAppsDuringOffClockHours
A grace period before blocking app access during off clock hours.

```yaml
Type: System.TimeSpan
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaximumAllowedDeviceThreatLevel
The maxium threat level allowed for an app to be compliant.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppDeviceThreatLevel
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaximumRequiredOSVersion
Versions bigger than the specified version will block the managed app from accessing company data.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaximumWarningOSVersion
Versions bigger than the specified version will block the managed app from accessing company data.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaximumWipeOSVersion
Versions bigger than the specified version will block the managed app from accessing company data.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumRequiredCompanyPortalVersion
Minimum version of the Company portal that must be installed on the device or app access will be blocked

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumRequiredPatchVersion
Define the oldest required Android security patch level a user can have to gain secure access to the app.
(Android only)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumRequiredSdkVersion
Versions less than the specified version will block the managed app from accessing company data.
(iOS Only)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumWarningCompanyPortalVersion
Minimum version of the Company portal that must be installed on the device or the user will receive a warning

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumWarningPatchVersion
Define the oldest recommended Android security patch level a user can have for secure access to the app.
(Android only)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumWipeAppVersion
Versions less than or equal to the specified version will wipe the managed app and the associated company data.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumWipeCompanyPortalVersion
Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumWipeOSVersion
Versions less than or equal to the specified version will wipe the managed app and the associated company data.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumWipePatchVersion
Android security patch level less than or equal to the specified value will wipe the managed app and the associated company data.
(Android only)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumWipeSdkVersion
Versions less than the specified version will block the managed app from accessing company data.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileThreatDefenseRemediationAction
An admin initiated action to be applied on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppRemediationAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationRestriction
Restrict managed app notification

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppNotificationRestriction
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PinRequiredInsteadOfBiometricTimeout
Timeout in minutes for an app pin instead of non biometrics passcode

```yaml
Type: System.TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreviousPinBlockCount
Requires a pin to be unique from the number specified in this property.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectInboundDataFromUnknownSources
Protect incoming data from unknown source.
This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps.
(iOS Only)

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequireClass3Biometrics
Require user to apply Class 3 Biometrics on their Android device.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequiredAndroidSafetyNetAppsVerificationType
An admin enforced Android SafetyNet Device Attestation requirement on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.AndroidManagedAppSafetyNetAppsVerificationType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequiredAndroidSafetyNetDeviceAttestationType
An admin enforced Android SafetyNet Device Attestation requirement on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.AndroidManagedAppSafetyNetDeviceAttestationType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequiredAndroidSafetyNetEvaluationType
An admin enforced Android SafetyNet evaluation type requirement on a managed app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.AndroidManagedAppSafetyNetEvaluationType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequirePinAfterBiometricChange
A PIN prompt will override biometric prompts if class 3 biometrics are updated on the device.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTagIds
List of Scope Tags for this Entity instance.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScreenCaptureBlocked
Indicates whether screen capture is blocked.
(Android only)

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ThirdPartyKeyboardsBlocked
Defines if third party keyboards are allowed while accessing a managed app.
(iOS Only)

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WarnAfterCompanyPortalUpdateDeferralInDays
Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WipeAfterCompanyPortalUpdateDeferralInDays
Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDefaultManagedAppProtection

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDefaultManagedAppProtection

## NOTES

ALIASES

### New-MgDeviceAppManagementDefaultManagedAppProtection

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPS <IMicrosoftGraphManagedMobileApp[]>: List of apps to which the policy is deployed.
  - `[Id <String>]`: 
  - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Version <String>]`: Version of the entity.

BODYPARAMETER <IMicrosoftGraphDefaultManagedAppProtection>: Policy used to configure detailed management settings for a specified set of apps for all users not targeted by a TargetedManagedAppProtection Policy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

CUSTOMSETTINGS <IMicrosoftGraphKeyValuePair[]>: A set of string key and string value pairs to be sent to the affected users, unalterned by this service
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

DEPLOYMENTSUMMARY <IMicrosoftGraphManagedAppPolicyDeploymentSummary>: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
  - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
    - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: Not yet documented
  - `[LastRefreshTime <DateTime?>]`: Not yet documented
  - `[Version <String>]`: Version of the entity.

EXEMPTEDAPPPACKAGES <IMicrosoftGraphKeyValuePair[]>: Android App packages in this list will be exempt from the policy and will be able to receive data from managed apps. (Android only)
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

EXEMPTEDAPPPROTOCOLS <IMicrosoftGraphKeyValuePair[]>: iOS Apps in this list will be exempt from the policy and will be able to receive data from managed apps. (iOS Only)
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

## RELATED LINKS

