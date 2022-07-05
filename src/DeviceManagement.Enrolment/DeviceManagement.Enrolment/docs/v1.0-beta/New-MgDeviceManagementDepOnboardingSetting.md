---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/new-mgdevicemanagementdeponboardingsetting
schema: 2.0.0
---

# New-MgDeviceManagementDepOnboardingSetting

## SYNOPSIS
Create new navigation property to depOnboardingSettings for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementDepOnboardingSetting [-AdditionalProperties <Hashtable>] [-AppleIdentifier <String>]
 [-DataSharingConsentGranted] [-DefaultIosEnrollmentProfile <IMicrosoftGraphDepIosEnrollmentProfile>]
 [-DefaultMacOSEnrollmentProfile <IMicrosoftGraphDepMacOSEnrollmentProfile>]
 [-EnrollmentProfiles <IMicrosoftGraphEnrollmentProfile[]>] [-Id <String>]
 [-ImportedAppleDeviceIdentities <IMicrosoftGraphImportedAppleDeviceIdentity[]>]
 [-LastModifiedDateTime <DateTime>] [-LastSuccessfulSyncDateTime <DateTime>] [-LastSyncErrorCode <Int32>]
 [-LastSyncTriggeredDateTime <DateTime>] [-RoleScopeTagIds <String[]>] [-ShareTokenWithSchoolDataSyncService]
 [-SyncedDeviceCount <Int32>] [-TokenExpirationDateTime <DateTime>] [-TokenName <String>]
 [-TokenType <DepTokenType>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementDepOnboardingSetting -BodyParameter <IMicrosoftGraphDepOnboardingSetting> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to depOnboardingSettings for deviceManagement

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

### -AppleIdentifier
The Apple ID used to obtain the current token.

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

### -BodyParameter
The depOnboardingSetting represents an instance of the Apple DEP service being onboarded to Intune.
The onboarded service instance manages an Apple Token used to synchronize data between Apple and Intune.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDepOnboardingSetting
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DataSharingConsentGranted
Consent granted for data sharing with Apple Dep Service

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

### -DefaultIosEnrollmentProfile
The DepIOSEnrollmentProfile resource represents an Apple Device Enrollment Program (DEP) enrollment profile specific to iOS configuration.
This type of profile must be assigned to Apple DEP serial numbers before the corresponding devices can enroll via DEP.
To construct, please use Get-Help -Online and see NOTES section for DEFAULTIOSENROLLMENTPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDepIosEnrollmentProfile
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultMacOSEnrollmentProfile
The DepMacOSEnrollmentProfile resource represents an Apple Device Enrollment Program (DEP) enrollment profile specific to macOS configuration.
This type of profile must be assigned to Apple DEP serial numbers before the corresponding devices can enroll via DEP.
To construct, please use Get-Help -Online and see NOTES section for DEFAULTMACOSENROLLMENTPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDepMacOSEnrollmentProfile
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentProfiles
The enrollment profiles.
To construct, please use Get-Help -Online and see NOTES section for ENROLLMENTPROFILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEnrollmentProfile[]
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

### -ImportedAppleDeviceIdentities
The imported Apple device identities.
To construct, please use Get-Help -Online and see NOTES section for IMPORTEDAPPLEDEVICEIDENTITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImportedAppleDeviceIdentity[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
When the service was onboarded.

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

### -LastSuccessfulSyncDateTime
When the service last syned with Intune

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

### -LastSyncErrorCode
Error code reported by Apple during last dep sync.

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

### -LastSyncTriggeredDateTime
When Intune last requested a sync.

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

### -ShareTokenWithSchoolDataSyncService
Whether or not the Dep token sharing is enabled with the School Data Sync service.

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

### -SyncedDeviceCount
Gets synced device count

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

### -TokenExpirationDateTime
When the token will expire.

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

### -TokenName
Friendly Name for Dep Token

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

### -TokenType
depTokenType

```yaml
Type: Microsoft.Graph.PowerShell.Support.DepTokenType
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDepOnboardingSetting

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDepOnboardingSetting

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDepOnboardingSetting>: The depOnboardingSetting represents an instance of the Apple DEP service being onboarded to Intune. The onboarded service instance manages an Apple Token used to synchronize data between Apple and Intune.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppleIdentifier <String>]`: The Apple ID used to obtain the current token.
  - `[DataSharingConsentGranted <Boolean?>]`: Consent granted for data sharing with Apple Dep Service
  - `[DefaultIosEnrollmentProfile <IMicrosoftGraphDepIosEnrollmentProfile>]`: The DepIOSEnrollmentProfile resource represents an Apple Device Enrollment Program (DEP) enrollment profile specific to iOS configuration. This type of profile must be assigned to Apple DEP serial numbers before the corresponding devices can enroll via DEP.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AppleIdDisabled <Boolean?>]`: Indicates if Apple id setup pane is disabled
    - `[ApplePayDisabled <Boolean?>]`: Indicates if Apple pay setup pane is disabled
    - `[ConfigurationWebUrl <Boolean?>]`: URL for setup assistant login
    - `[DeviceNameTemplate <String>]`: Sets a literal or name pattern.
    - `[DiagnosticsDisabled <Boolean?>]`: Indicates if diagnostics setup pane is disabled
    - `[DisplayToneSetupDisabled <Boolean?>]`: Indicates if displaytone setup screen is disabled
    - `[IsDefault <Boolean?>]`: Indicates if this is the default profile
    - `[IsMandatory <Boolean?>]`: Indicates if the profile is mandatory
    - `[LocationDisabled <Boolean?>]`: Indicates if Location service setup pane is disabled
    - `[PrivacyPaneDisabled <Boolean?>]`: Indicates if privacy screen is disabled
    - `[ProfileRemovalDisabled <Boolean?>]`: Indicates if the profile removal option is disabled
    - `[RestoreBlocked <Boolean?>]`: Indicates if Restore setup pane is blocked
    - `[ScreenTimeScreenDisabled <Boolean?>]`: Indicates if screen timeout setup is disabled
    - `[SiriDisabled <Boolean?>]`: Indicates if siri setup pane is disabled
    - `[SupervisedModeEnabled <Boolean?>]`: Supervised mode, True to enable, false otherwise. See https://docs.microsoft.com/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.
    - `[SupportDepartment <String>]`: Support department information
    - `[SupportPhoneNumber <String>]`: Support phone number
    - `[TermsAndConditionsDisabled <Boolean?>]`: Indicates if 'Terms and Conditions' setup pane is disabled
    - `[TouchIdDisabled <Boolean?>]`: Indicates if touch id setup pane is disabled
    - `[ConfigurationEndpointUrl <String>]`: Configuration endpoint url to use for Enrollment
    - `[Description <String>]`: Description of the profile
    - `[DisplayName <String>]`: Name of the profile
    - `[EnableAuthenticationViaCompanyPortal <Boolean?>]`: Indicates to authenticate with Apple Setup Assistant instead of Company Portal.
    - `[RequireCompanyPortalOnSetupAssistantEnrolledDevices <Boolean?>]`: Indicates that Company Portal is required on setup assistant enrolled devices
    - `[RequiresUserAuthentication <Boolean?>]`: Indicates if the profile requires user authentication
    - `[Id <String>]`: 
    - `[AppearanceScreenDisabled <Boolean?>]`: Indicates if Apperance screen is disabled
    - `[AwaitDeviceConfiguredConfirmation <Boolean?>]`: Indicates if the device will need to wait for configured confirmation
    - `[CarrierActivationUrl <String>]`: Carrier URL for activating device eSIM.
    - `[CompanyPortalVppTokenId <String>]`: If set, indicates which Vpp token should be used to deploy the Company Portal w/ device licensing. 'enableAuthenticationViaCompanyPortal' must be set in order for this property to be set.
    - `[DeviceToDeviceMigrationDisabled <Boolean?>]`: Indicates if Device To Device Migration is disabled
    - `[EnableSharedIPad <Boolean?>]`: This indicates whether the device is to be enrolled in a mode which enables multi user scenarios. Only applicable in shared iPads.
    - `[EnableSingleAppEnrollmentMode <Boolean?>]`: Tells the device to enable single app mode and apply app-lock during enrollment. Default is false. 'enableAuthenticationViaCompanyPortal' and 'companyPortalVppTokenId' must be set for this property to be set.
    - `[ExpressLanguageScreenDisabled <Boolean?>]`: Indicates if Express Language screen is disabled
    - `[ForceTemporarySession <Boolean?>]`: Indicates if temporary sessions is enabled
    - `[HomeButtonScreenDisabled <Boolean?>]`: Indicates if home button sensitivity screen is disabled
    - `[IMessageAndFaceTimeScreenDisabled <Boolean?>]`: Indicates if iMessage and FaceTime screen is disabled
    - `[ITunesPairingMode <ITunesPairingMode?>]`: iTunesPairingMode
    - `[ManagementCertificates <IMicrosoftGraphManagementCertificateWithThumbprint[]>]`: Management certificates for Apple Configurator
      - `[Certificate <String>]`: The Base 64 encoded management certificate
      - `[Thumbprint <String>]`: The thumbprint of the management certificate
    - `[OnBoardingScreenDisabled <Boolean?>]`: Indicates if onboarding setup screen is disabled
    - `[PassCodeDisabled <Boolean?>]`: Indicates if Passcode setup pane is disabled
    - `[PasscodeLockGracePeriodInSeconds <Int32?>]`: Indicates timeout before locked screen requires the user to enter the device passocde to unlock it
    - `[PreferredLanguageScreenDisabled <Boolean?>]`: Indicates if Preferred language screen is disabled
    - `[RestoreCompletedScreenDisabled <Boolean?>]`: Indicates if Weclome screen is disabled
    - `[RestoreFromAndroidDisabled <Boolean?>]`: Indicates if Restore from Android is disabled
    - `[SharedIPadMaximumUserCount <Int32?>]`: This specifies the maximum number of users that can use a shared iPad. Only applicable in shared iPad mode.
    - `[SimSetupScreenDisabled <Boolean?>]`: Indicates if the SIMSetup screen is disabled
    - `[SoftwareUpdateScreenDisabled <Boolean?>]`: Indicates if the mandatory sofware update screen is disabled
    - `[TemporarySessionTimeoutInSeconds <Int32?>]`: Indicates timeout of temporary session
    - `[UpdateCompleteScreenDisabled <Boolean?>]`: Indicates if Weclome screen is disabled
    - `[UserSessionTimeoutInSeconds <Int32?>]`: Indicates timeout of temporary session
    - `[UserlessSharedAadModeEnabled <Boolean?>]`: Indicates that this apple device is designated to support 'shared device mode' scenarios. This is distinct from the 'shared iPad' scenario. See https://docs.microsoft.com/mem/intune/enrollment/device-enrollment-shared-ios
    - `[WatchMigrationScreenDisabled <Boolean?>]`: Indicates if the watch migration screen is disabled
    - `[WelcomeScreenDisabled <Boolean?>]`: Indicates if Weclome screen is disabled
    - `[ZoomDisabled <Boolean?>]`: Indicates if zoom setup pane is disabled
  - `[DefaultMacOSEnrollmentProfile <IMicrosoftGraphDepMacOSEnrollmentProfile>]`: The DepMacOSEnrollmentProfile resource represents an Apple Device Enrollment Program (DEP) enrollment profile specific to macOS configuration. This type of profile must be assigned to Apple DEP serial numbers before the corresponding devices can enroll via DEP.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AppleIdDisabled <Boolean?>]`: Indicates if Apple id setup pane is disabled
    - `[ApplePayDisabled <Boolean?>]`: Indicates if Apple pay setup pane is disabled
    - `[ConfigurationWebUrl <Boolean?>]`: URL for setup assistant login
    - `[DeviceNameTemplate <String>]`: Sets a literal or name pattern.
    - `[DiagnosticsDisabled <Boolean?>]`: Indicates if diagnostics setup pane is disabled
    - `[DisplayToneSetupDisabled <Boolean?>]`: Indicates if displaytone setup screen is disabled
    - `[IsDefault <Boolean?>]`: Indicates if this is the default profile
    - `[IsMandatory <Boolean?>]`: Indicates if the profile is mandatory
    - `[LocationDisabled <Boolean?>]`: Indicates if Location service setup pane is disabled
    - `[PrivacyPaneDisabled <Boolean?>]`: Indicates if privacy screen is disabled
    - `[ProfileRemovalDisabled <Boolean?>]`: Indicates if the profile removal option is disabled
    - `[RestoreBlocked <Boolean?>]`: Indicates if Restore setup pane is blocked
    - `[ScreenTimeScreenDisabled <Boolean?>]`: Indicates if screen timeout setup is disabled
    - `[SiriDisabled <Boolean?>]`: Indicates if siri setup pane is disabled
    - `[SupervisedModeEnabled <Boolean?>]`: Supervised mode, True to enable, false otherwise. See https://docs.microsoft.com/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.
    - `[SupportDepartment <String>]`: Support department information
    - `[SupportPhoneNumber <String>]`: Support phone number
    - `[TermsAndConditionsDisabled <Boolean?>]`: Indicates if 'Terms and Conditions' setup pane is disabled
    - `[TouchIdDisabled <Boolean?>]`: Indicates if touch id setup pane is disabled
    - `[ConfigurationEndpointUrl <String>]`: Configuration endpoint url to use for Enrollment
    - `[Description <String>]`: Description of the profile
    - `[DisplayName <String>]`: Name of the profile
    - `[EnableAuthenticationViaCompanyPortal <Boolean?>]`: Indicates to authenticate with Apple Setup Assistant instead of Company Portal.
    - `[RequireCompanyPortalOnSetupAssistantEnrolledDevices <Boolean?>]`: Indicates that Company Portal is required on setup assistant enrolled devices
    - `[RequiresUserAuthentication <Boolean?>]`: Indicates if the profile requires user authentication
    - `[Id <String>]`: 
    - `[AccessibilityScreenDisabled <Boolean?>]`: Indicates if Accessibility screen is disabled
    - `[AutoUnlockWithWatchDisabled <Boolean?>]`: Indicates if UnlockWithWatch screen is disabled
    - `[ChooseYourLockScreenDisabled <Boolean?>]`: Indicates if iCloud Documents and Desktop screen is disabled
    - `[FileVaultDisabled <Boolean?>]`: Indicates if file vault is disabled
    - `[ICloudDiagnosticsDisabled <Boolean?>]`: Indicates if iCloud Analytics screen is disabled
    - `[ICloudStorageDisabled <Boolean?>]`: Indicates if iCloud Documents and Desktop screen is disabled
    - `[PassCodeDisabled <Boolean?>]`: Indicates if Passcode setup pane is disabled
    - `[RegistrationDisabled <Boolean?>]`: Indicates if registration is disabled
    - `[ZoomDisabled <Boolean?>]`: Indicates if zoom setup pane is disabled
  - `[EnrollmentProfiles <IMicrosoftGraphEnrollmentProfile[]>]`: The enrollment profiles.
    - `[Id <String>]`: 
    - `[ConfigurationEndpointUrl <String>]`: Configuration endpoint url to use for Enrollment
    - `[Description <String>]`: Description of the profile
    - `[DisplayName <String>]`: Name of the profile
    - `[EnableAuthenticationViaCompanyPortal <Boolean?>]`: Indicates to authenticate with Apple Setup Assistant instead of Company Portal.
    - `[RequireCompanyPortalOnSetupAssistantEnrolledDevices <Boolean?>]`: Indicates that Company Portal is required on setup assistant enrolled devices
    - `[RequiresUserAuthentication <Boolean?>]`: Indicates if the profile requires user authentication
  - `[ImportedAppleDeviceIdentities <IMicrosoftGraphImportedAppleDeviceIdentity[]>]`: The imported Apple device identities.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: Created Date Time of the device
    - `[Description <String>]`: The description of the device
    - `[DiscoverySource <DiscoverySource?>]`: discoverySource
    - `[EnrollmentState <EnrollmentState?>]`: 
    - `[IsDeleted <Boolean?>]`: Indicates if the device is deleted from Apple Business Manager
    - `[IsSupervised <Boolean?>]`: Indicates if the Apple device is supervised. More information is at: https://support.apple.com/en-us/HT202837
    - `[LastContactedDateTime <DateTime?>]`: Last Contacted Date Time of the device
    - `[Platform <Platform?>]`: platform
    - `[RequestedEnrollmentProfileAssignmentDateTime <DateTime?>]`: The time enrollment profile was assigned to the device
    - `[RequestedEnrollmentProfileId <String>]`: Enrollment profile Id admin intends to apply to the device during next enrollment
    - `[SerialNumber <String>]`: Device serial number
  - `[LastModifiedDateTime <DateTime?>]`: When the service was onboarded.
  - `[LastSuccessfulSyncDateTime <DateTime?>]`: When the service last syned with Intune
  - `[LastSyncErrorCode <Int32?>]`: Error code reported by Apple during last dep sync.
  - `[LastSyncTriggeredDateTime <DateTime?>]`: When Intune last requested a sync.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[ShareTokenWithSchoolDataSyncService <Boolean?>]`: Whether or not the Dep token sharing is enabled with the School Data Sync service.
  - `[SyncedDeviceCount <Int32?>]`: Gets synced device count
  - `[TokenExpirationDateTime <DateTime?>]`: When the token will expire.
  - `[TokenName <String>]`: Friendly Name for Dep Token
  - `[TokenType <DepTokenType?>]`: depTokenType

DEFAULTIOSENROLLMENTPROFILE <IMicrosoftGraphDepIosEnrollmentProfile>: The DepIOSEnrollmentProfile resource represents an Apple Device Enrollment Program (DEP) enrollment profile specific to iOS configuration. This type of profile must be assigned to Apple DEP serial numbers before the corresponding devices can enroll via DEP.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AppleIdDisabled <Boolean?>]`: Indicates if Apple id setup pane is disabled
  - `[ApplePayDisabled <Boolean?>]`: Indicates if Apple pay setup pane is disabled
  - `[ConfigurationWebUrl <Boolean?>]`: URL for setup assistant login
  - `[DeviceNameTemplate <String>]`: Sets a literal or name pattern.
  - `[DiagnosticsDisabled <Boolean?>]`: Indicates if diagnostics setup pane is disabled
  - `[DisplayToneSetupDisabled <Boolean?>]`: Indicates if displaytone setup screen is disabled
  - `[IsDefault <Boolean?>]`: Indicates if this is the default profile
  - `[IsMandatory <Boolean?>]`: Indicates if the profile is mandatory
  - `[LocationDisabled <Boolean?>]`: Indicates if Location service setup pane is disabled
  - `[PrivacyPaneDisabled <Boolean?>]`: Indicates if privacy screen is disabled
  - `[ProfileRemovalDisabled <Boolean?>]`: Indicates if the profile removal option is disabled
  - `[RestoreBlocked <Boolean?>]`: Indicates if Restore setup pane is blocked
  - `[ScreenTimeScreenDisabled <Boolean?>]`: Indicates if screen timeout setup is disabled
  - `[SiriDisabled <Boolean?>]`: Indicates if siri setup pane is disabled
  - `[SupervisedModeEnabled <Boolean?>]`: Supervised mode, True to enable, false otherwise. See https://docs.microsoft.com/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.
  - `[SupportDepartment <String>]`: Support department information
  - `[SupportPhoneNumber <String>]`: Support phone number
  - `[TermsAndConditionsDisabled <Boolean?>]`: Indicates if 'Terms and Conditions' setup pane is disabled
  - `[TouchIdDisabled <Boolean?>]`: Indicates if touch id setup pane is disabled
  - `[ConfigurationEndpointUrl <String>]`: Configuration endpoint url to use for Enrollment
  - `[Description <String>]`: Description of the profile
  - `[DisplayName <String>]`: Name of the profile
  - `[EnableAuthenticationViaCompanyPortal <Boolean?>]`: Indicates to authenticate with Apple Setup Assistant instead of Company Portal.
  - `[RequireCompanyPortalOnSetupAssistantEnrolledDevices <Boolean?>]`: Indicates that Company Portal is required on setup assistant enrolled devices
  - `[RequiresUserAuthentication <Boolean?>]`: Indicates if the profile requires user authentication
  - `[Id <String>]`: 
  - `[AppearanceScreenDisabled <Boolean?>]`: Indicates if Apperance screen is disabled
  - `[AwaitDeviceConfiguredConfirmation <Boolean?>]`: Indicates if the device will need to wait for configured confirmation
  - `[CarrierActivationUrl <String>]`: Carrier URL for activating device eSIM.
  - `[CompanyPortalVppTokenId <String>]`: If set, indicates which Vpp token should be used to deploy the Company Portal w/ device licensing. 'enableAuthenticationViaCompanyPortal' must be set in order for this property to be set.
  - `[DeviceToDeviceMigrationDisabled <Boolean?>]`: Indicates if Device To Device Migration is disabled
  - `[EnableSharedIPad <Boolean?>]`: This indicates whether the device is to be enrolled in a mode which enables multi user scenarios. Only applicable in shared iPads.
  - `[EnableSingleAppEnrollmentMode <Boolean?>]`: Tells the device to enable single app mode and apply app-lock during enrollment. Default is false. 'enableAuthenticationViaCompanyPortal' and 'companyPortalVppTokenId' must be set for this property to be set.
  - `[ExpressLanguageScreenDisabled <Boolean?>]`: Indicates if Express Language screen is disabled
  - `[ForceTemporarySession <Boolean?>]`: Indicates if temporary sessions is enabled
  - `[HomeButtonScreenDisabled <Boolean?>]`: Indicates if home button sensitivity screen is disabled
  - `[IMessageAndFaceTimeScreenDisabled <Boolean?>]`: Indicates if iMessage and FaceTime screen is disabled
  - `[ITunesPairingMode <ITunesPairingMode?>]`: iTunesPairingMode
  - `[ManagementCertificates <IMicrosoftGraphManagementCertificateWithThumbprint[]>]`: Management certificates for Apple Configurator
    - `[Certificate <String>]`: The Base 64 encoded management certificate
    - `[Thumbprint <String>]`: The thumbprint of the management certificate
  - `[OnBoardingScreenDisabled <Boolean?>]`: Indicates if onboarding setup screen is disabled
  - `[PassCodeDisabled <Boolean?>]`: Indicates if Passcode setup pane is disabled
  - `[PasscodeLockGracePeriodInSeconds <Int32?>]`: Indicates timeout before locked screen requires the user to enter the device passocde to unlock it
  - `[PreferredLanguageScreenDisabled <Boolean?>]`: Indicates if Preferred language screen is disabled
  - `[RestoreCompletedScreenDisabled <Boolean?>]`: Indicates if Weclome screen is disabled
  - `[RestoreFromAndroidDisabled <Boolean?>]`: Indicates if Restore from Android is disabled
  - `[SharedIPadMaximumUserCount <Int32?>]`: This specifies the maximum number of users that can use a shared iPad. Only applicable in shared iPad mode.
  - `[SimSetupScreenDisabled <Boolean?>]`: Indicates if the SIMSetup screen is disabled
  - `[SoftwareUpdateScreenDisabled <Boolean?>]`: Indicates if the mandatory sofware update screen is disabled
  - `[TemporarySessionTimeoutInSeconds <Int32?>]`: Indicates timeout of temporary session
  - `[UpdateCompleteScreenDisabled <Boolean?>]`: Indicates if Weclome screen is disabled
  - `[UserSessionTimeoutInSeconds <Int32?>]`: Indicates timeout of temporary session
  - `[UserlessSharedAadModeEnabled <Boolean?>]`: Indicates that this apple device is designated to support 'shared device mode' scenarios. This is distinct from the 'shared iPad' scenario. See https://docs.microsoft.com/mem/intune/enrollment/device-enrollment-shared-ios
  - `[WatchMigrationScreenDisabled <Boolean?>]`: Indicates if the watch migration screen is disabled
  - `[WelcomeScreenDisabled <Boolean?>]`: Indicates if Weclome screen is disabled
  - `[ZoomDisabled <Boolean?>]`: Indicates if zoom setup pane is disabled

DEFAULTMACOSENROLLMENTPROFILE <IMicrosoftGraphDepMacOSEnrollmentProfile>: The DepMacOSEnrollmentProfile resource represents an Apple Device Enrollment Program (DEP) enrollment profile specific to macOS configuration. This type of profile must be assigned to Apple DEP serial numbers before the corresponding devices can enroll via DEP.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AppleIdDisabled <Boolean?>]`: Indicates if Apple id setup pane is disabled
  - `[ApplePayDisabled <Boolean?>]`: Indicates if Apple pay setup pane is disabled
  - `[ConfigurationWebUrl <Boolean?>]`: URL for setup assistant login
  - `[DeviceNameTemplate <String>]`: Sets a literal or name pattern.
  - `[DiagnosticsDisabled <Boolean?>]`: Indicates if diagnostics setup pane is disabled
  - `[DisplayToneSetupDisabled <Boolean?>]`: Indicates if displaytone setup screen is disabled
  - `[IsDefault <Boolean?>]`: Indicates if this is the default profile
  - `[IsMandatory <Boolean?>]`: Indicates if the profile is mandatory
  - `[LocationDisabled <Boolean?>]`: Indicates if Location service setup pane is disabled
  - `[PrivacyPaneDisabled <Boolean?>]`: Indicates if privacy screen is disabled
  - `[ProfileRemovalDisabled <Boolean?>]`: Indicates if the profile removal option is disabled
  - `[RestoreBlocked <Boolean?>]`: Indicates if Restore setup pane is blocked
  - `[ScreenTimeScreenDisabled <Boolean?>]`: Indicates if screen timeout setup is disabled
  - `[SiriDisabled <Boolean?>]`: Indicates if siri setup pane is disabled
  - `[SupervisedModeEnabled <Boolean?>]`: Supervised mode, True to enable, false otherwise. See https://docs.microsoft.com/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.
  - `[SupportDepartment <String>]`: Support department information
  - `[SupportPhoneNumber <String>]`: Support phone number
  - `[TermsAndConditionsDisabled <Boolean?>]`: Indicates if 'Terms and Conditions' setup pane is disabled
  - `[TouchIdDisabled <Boolean?>]`: Indicates if touch id setup pane is disabled
  - `[ConfigurationEndpointUrl <String>]`: Configuration endpoint url to use for Enrollment
  - `[Description <String>]`: Description of the profile
  - `[DisplayName <String>]`: Name of the profile
  - `[EnableAuthenticationViaCompanyPortal <Boolean?>]`: Indicates to authenticate with Apple Setup Assistant instead of Company Portal.
  - `[RequireCompanyPortalOnSetupAssistantEnrolledDevices <Boolean?>]`: Indicates that Company Portal is required on setup assistant enrolled devices
  - `[RequiresUserAuthentication <Boolean?>]`: Indicates if the profile requires user authentication
  - `[Id <String>]`: 
  - `[AccessibilityScreenDisabled <Boolean?>]`: Indicates if Accessibility screen is disabled
  - `[AutoUnlockWithWatchDisabled <Boolean?>]`: Indicates if UnlockWithWatch screen is disabled
  - `[ChooseYourLockScreenDisabled <Boolean?>]`: Indicates if iCloud Documents and Desktop screen is disabled
  - `[FileVaultDisabled <Boolean?>]`: Indicates if file vault is disabled
  - `[ICloudDiagnosticsDisabled <Boolean?>]`: Indicates if iCloud Analytics screen is disabled
  - `[ICloudStorageDisabled <Boolean?>]`: Indicates if iCloud Documents and Desktop screen is disabled
  - `[PassCodeDisabled <Boolean?>]`: Indicates if Passcode setup pane is disabled
  - `[RegistrationDisabled <Boolean?>]`: Indicates if registration is disabled
  - `[ZoomDisabled <Boolean?>]`: Indicates if zoom setup pane is disabled

ENROLLMENTPROFILES <IMicrosoftGraphEnrollmentProfile[]>: The enrollment profiles.
  - `[Id <String>]`: 
  - `[ConfigurationEndpointUrl <String>]`: Configuration endpoint url to use for Enrollment
  - `[Description <String>]`: Description of the profile
  - `[DisplayName <String>]`: Name of the profile
  - `[EnableAuthenticationViaCompanyPortal <Boolean?>]`: Indicates to authenticate with Apple Setup Assistant instead of Company Portal.
  - `[RequireCompanyPortalOnSetupAssistantEnrolledDevices <Boolean?>]`: Indicates that Company Portal is required on setup assistant enrolled devices
  - `[RequiresUserAuthentication <Boolean?>]`: Indicates if the profile requires user authentication

IMPORTEDAPPLEDEVICEIDENTITIES <IMicrosoftGraphImportedAppleDeviceIdentity[]>: The imported Apple device identities.
  - `[Id <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: Created Date Time of the device
  - `[Description <String>]`: The description of the device
  - `[DiscoverySource <DiscoverySource?>]`: discoverySource
  - `[EnrollmentState <EnrollmentState?>]`: 
  - `[IsDeleted <Boolean?>]`: Indicates if the device is deleted from Apple Business Manager
  - `[IsSupervised <Boolean?>]`: Indicates if the Apple device is supervised. More information is at: https://support.apple.com/en-us/HT202837
  - `[LastContactedDateTime <DateTime?>]`: Last Contacted Date Time of the device
  - `[Platform <Platform?>]`: platform
  - `[RequestedEnrollmentProfileAssignmentDateTime <DateTime?>]`: The time enrollment profile was assigned to the device
  - `[RequestedEnrollmentProfileId <String>]`: Enrollment profile Id admin intends to apply to the device during next enrollment
  - `[SerialNumber <String>]`: Device serial number

## RELATED LINKS

