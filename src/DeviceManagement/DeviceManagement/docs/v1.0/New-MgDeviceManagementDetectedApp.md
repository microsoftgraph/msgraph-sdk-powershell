---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementdetectedapp
schema: 2.0.0
---

# New-MgDeviceManagementDetectedApp

## SYNOPSIS
The list of detected apps associated with a device.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceManagementDetectedApp [-AdditionalProperties <Hashtable>] [-DeviceCount <Int32>]
 [-DisplayName <String>] [-Id <String>] [-ManagedDevices <IMicrosoftGraphManagedDevice1[]>]
 [-SizeInByte <Int64>] [-Version <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create1
```
New-MgDeviceManagementDetectedApp -BodyParameter <IMicrosoftGraphDetectedApp1> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
The list of detected apps associated with a device.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
A managed or unmanaged app that is installed on a managed device.
Unmanaged apps will only appear for devices marked as corporate owned.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDetectedApp1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceCount
The number of devices that have installed this application

```yaml
Type: Int32
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Name of the discovered application.
Read-only

```yaml
Type: String
Parameter Sets: CreateExpanded1
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
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedDevices
The devices that have the discovered application installed
To construct, see NOTES section for MANAGEDDEVICES properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedDevice1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SizeInByte
Discovered application size in bytes.
Read-only

```yaml
Type: Int64
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Version of the discovered application.
Read-only

```yaml
Type: String
Parameter Sets: CreateExpanded1
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDetectedApp1
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDetectedApp1
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDetectedApp1>: A managed or unmanaged app that is installed on a managed device. Unmanaged apps will only appear for devices marked as corporate owned.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[DeviceCount <Int32?>]`: The number of devices that have installed this application
  - `[DisplayName <String>]`: Name of the discovered application. Read-only
  - `[ManagedDevices <IMicrosoftGraphManagedDevice1[]>]`: The devices that have the discovered application installed
    - `[Id <String>]`: Read-only.
    - `[ActivationLockBypassCode <String>]`: Code that allows the Activation Lock on a device to be bypassed. This property is read-only.
    - `[AndroidSecurityPatchLevel <String>]`: Android security patch level. This property is read-only.
    - `[AzureAdDeviceId <String>]`: The unique identifier for the Azure Active Directory device. Read only. This property is read-only.
    - `[AzureAdRegistered <Boolean?>]`: Whether the device is Azure Active Directory registered. This property is read-only.
    - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires. This property is read-only.
    - `[ComplianceState <String>]`: complianceState
    - `[ConfigurationManagerClientEnabledFeatures <IMicrosoftGraphConfigurationManagerClientEnabledFeatures>]`: configuration Manager client enabled features
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CompliancePolicy <Boolean?>]`: Whether compliance policy is managed by Intune
      - `[DeviceConfiguration <Boolean?>]`: Whether device configuration is managed by Intune
      - `[Inventory <Boolean?>]`: Whether inventory is managed by Intune
      - `[ModernApps <Boolean?>]`: Whether modern application is managed by Intune
      - `[ResourceAccess <Boolean?>]`: Whether resource access is managed by Intune
      - `[WindowsUpdateForBusiness <Boolean?>]`: Whether Windows Update for Business is managed by Intune
    - `[DeviceActionResults <IMicrosoftGraphDeviceActionResult[]>]`: List of ComplexType deviceActionResult objects. This property is read-only.
      - `[ActionName <String>]`: Action name
      - `[ActionState <String>]`: actionState
      - `[LastUpdatedDateTime <DateTime?>]`: Time the action state was last updated
      - `[StartDateTime <DateTime?>]`: Time the action was initiated
    - `[DeviceCategory <IMicrosoftGraphDeviceCategory>]`: Device categories provides a way to organize your devices. Using device categories, company administrators can define their own categories that make sense to their company. These categories can then be applied to a device in the Intune Azure console or selected by a user during device enrollment. You can filter reports and create dynamic Azure Active Directory device groups based on device categories.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Description <String>]`: Optional description for the device category.
      - `[DisplayName <String>]`: Display name for the device category.
    - `[DeviceCategoryDisplayName <String>]`: Device category display name. This property is read-only.
    - `[DeviceCompliancePolicyStates <IMicrosoftGraphDeviceCompliancePolicyState[]>]`: Device compliance policy states for this device.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The name of the policy for this policyBase
      - `[PlatformType <String>]`: 
      - `[SettingCount <Int32?>]`: Count of how many setting a policy holds
      - `[SettingStates <IMicrosoftGraphDeviceCompliancePolicySettingState[]>]`: 
        - `[CurrentValue <String>]`: Current value of setting on device
        - `[ErrorCode <Int64?>]`: Error code for the setting
        - `[ErrorDescription <String>]`: Error description
        - `[InstanceDisplayName <String>]`: Name of setting instance that is being reported.
        - `[Setting <String>]`: The setting that is being reported
        - `[SettingName <String>]`: Localized/user friendly setting name that is being reported
        - `[Sources <IMicrosoftGraphSettingSource[]>]`: Contributing policies
          - `[DisplayName <String>]`: Not yet documented
          - `[Id <String>]`: Not yet documented
        - `[State <String>]`: complianceStatus
        - `[UserEmail <String>]`: UserEmail
        - `[UserId <String>]`: UserId
        - `[UserName <String>]`: UserName
        - `[UserPrincipalName <String>]`: UserPrincipalName.
      - `[State <String>]`: complianceStatus
      - `[Version <Int32?>]`: The version of the policy
    - `[DeviceConfigurationStates <IMicrosoftGraphDeviceConfigurationState[]>]`: Device configuration states for this device.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The name of the policy for this policyBase
      - `[PlatformType <String>]`: 
      - `[SettingCount <Int32?>]`: Count of how many setting a policy holds
      - `[SettingStates <IMicrosoftGraphDeviceConfigurationSettingState[]>]`: 
        - `[CurrentValue <String>]`: Current value of setting on device
        - `[ErrorCode <Int64?>]`: Error code for the setting
        - `[ErrorDescription <String>]`: Error description
        - `[InstanceDisplayName <String>]`: Name of setting instance that is being reported.
        - `[Setting <String>]`: The setting that is being reported
        - `[SettingName <String>]`: Localized/user friendly setting name that is being reported
        - `[Sources <IMicrosoftGraphSettingSource[]>]`: Contributing policies
        - `[State <String>]`: complianceStatus
        - `[UserEmail <String>]`: UserEmail
        - `[UserId <String>]`: UserId
        - `[UserName <String>]`: UserName
        - `[UserPrincipalName <String>]`: UserPrincipalName.
      - `[State <String>]`: complianceStatus
      - `[Version <Int32?>]`: The version of the policy
    - `[DeviceEnrollmentType <String>]`: 
    - `[DeviceHealthAttestationState <IMicrosoftGraphDeviceHealthAttestationState>]`: deviceHealthAttestationState
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AttestationIdentityKey <String>]`: TWhen an Attestation Identity Key (AIK) is present on a device, it indicates that the device has an endorsement key (EK) certificate.
      - `[BitLockerStatus <String>]`: On or Off of BitLocker Drive Encryption
      - `[BootAppSecurityVersion <String>]`: The security version number of the Boot Application
      - `[BootDebugging <String>]`: When bootDebugging is enabled, the device is used in development and testing
      - `[BootManagerSecurityVersion <String>]`: The security version number of the Boot Application
      - `[BootManagerVersion <String>]`: The version of the Boot Manager
      - `[BootRevisionListInfo <String>]`: The Boot Revision List that was loaded during initial boot on the attested device
      - `[CodeIntegrity <String>]`: When code integrity is enabled, code execution is restricted to integrity verified code
      - `[CodeIntegrityCheckVersion <String>]`: The version of the Boot Manager
      - `[CodeIntegrityPolicy <String>]`: The Code Integrity policy that is controlling the security of the boot environment
      - `[ContentNamespaceUrl <String>]`: The DHA report version. (Namespace version)
      - `[ContentVersion <String>]`: The HealthAttestation state schema version
      - `[DataExcutionPolicy <String>]`: DEP Policy defines a set of hardware and software technologies that perform additional checks on memory
      - `[DeviceHealthAttestationStatus <String>]`: The DHA report version. (Namespace version)
      - `[EarlyLaunchAntiMalwareDriverProtection <String>]`: ELAM provides protection for the computers in your network when they start up
      - `[HealthAttestationSupportedStatus <String>]`: This attribute indicates if DHA is supported for the device
      - `[HealthStatusMismatchInfo <String>]`: This attribute appears if DHA-Service detects an integrity issue
      - `[IssuedDateTime <DateTime?>]`: The DateTime when device was evaluated or issued to MDM
      - `[LastUpdateDateTime <String>]`: The Timestamp of the last update.
      - `[OperatingSystemKernelDebugging <String>]`: When operatingSystemKernelDebugging is enabled, the device is used in development and testing
      - `[OperatingSystemRevListInfo <String>]`: The Operating System Revision List that was loaded during initial boot on the attested device
      - `[Pcr0 <String>]`: The measurement that is captured in PCR[0]
      - `[PcrHashAlgorithm <String>]`: Informational attribute that identifies the HASH algorithm that was used by TPM
      - `[ResetCount <Int64?>]`: The number of times a PC device has hibernated or resumed
      - `[RestartCount <Int64?>]`: The number of times a PC device has rebooted
      - `[SafeMode <String>]`: Safe mode is a troubleshooting option for Windows that starts your computer in a limited state
      - `[SecureBoot <String>]`: When Secure Boot is enabled, the core components must have the correct cryptographic signatures
      - `[SecureBootConfigurationPolicyFingerPrint <String>]`: Fingerprint of the Custom Secure Boot Configuration Policy
      - `[TestSigning <String>]`: When test signing is allowed, the device does not enforce signature validation during boot
      - `[TpmVersion <String>]`: The security version number of the Boot Application
      - `[VirtualSecureMode <String>]`: VSM is a container that protects high value assets from a compromised kernel
      - `[WindowsPe <String>]`: Operating system running with limited services that is used to prepare a computer for Windows
    - `[DeviceName <String>]`: Name of the device. This property is read-only.
    - `[DeviceRegistrationState <String>]`: deviceRegistrationState
    - `[EasActivated <Boolean?>]`: Whether the device is Exchange ActiveSync activated. This property is read-only.
    - `[EasActivationDateTime <DateTime?>]`: Exchange ActivationSync activation time of the device. This property is read-only.
    - `[EasDeviceId <String>]`: Exchange ActiveSync Id of the device. This property is read-only.
    - `[EmailAddress <String>]`: Email(s) for the user associated with the device. This property is read-only.
    - `[EnrolledDateTime <DateTime?>]`: Enrollment time of the device. This property is read-only.
    - `[EthernetMacAddress <String>]`: Ethernet MAC. This property is read-only.
    - `[ExchangeAccessState <String>]`: deviceManagementExchangeAccessState
    - `[ExchangeAccessStateReason <String>]`: deviceManagementExchangeAccessStateReason
    - `[ExchangeLastSuccessfulSyncDateTime <DateTime?>]`: Last time the device contacted Exchange. This property is read-only.
    - `[FreeStorageSpaceInBytes <Int64?>]`: Free Storage in Bytes. This property is read-only.
    - `[Iccid <String>]`: Integrated Circuit Card Identifier, it is A SIM card's unique identification number. This property is read-only.
    - `[Imei <String>]`: IMEI. This property is read-only.
    - `[IsEncrypted <Boolean?>]`: Device encryption status. This property is read-only.
    - `[IsSupervised <Boolean?>]`: Device supervised status. This property is read-only.
    - `[JailBroken <String>]`: whether the device is jail broken or rooted. This property is read-only.
    - `[LastSyncDateTime <DateTime?>]`: The date and time that the device last completed a successful sync with Intune. This property is read-only.
    - `[ManagedDeviceName <String>]`: Automatically generated name to identify a device. Can be overwritten to a user friendly name.
    - `[ManagedDeviceOwnerType <String>]`: managedDeviceOwnerType
    - `[ManagementAgent <String>]`: 
    - `[Manufacturer <String>]`: Manufacturer of the device. This property is read-only.
    - `[Meid <String>]`: MEID. This property is read-only.
    - `[Model <String>]`: Model of the device. This property is read-only.
    - `[Notes <String>]`: Notes on the device created by IT Admin
    - `[OSVersion <String>]`: Operating system version of the device. This property is read-only.
    - `[OperatingSystem <String>]`: Operating system of the device. Windows, iOS, etc. This property is read-only.
    - `[PartnerReportedThreatState <String>]`: managedDevicePartnerReportedHealthState
    - `[PhoneNumber <String>]`: Phone number of the device. This property is read-only.
    - `[PhysicalMemoryInBytes <Int64?>]`: Total Memory in Bytes. This property is read-only.
    - `[RemoteAssistanceSessionErrorDetails <String>]`: An error string that identifies issues when creating Remote Assistance session objects. This property is read-only.
    - `[RemoteAssistanceSessionUrl <String>]`: Url that allows a Remote Assistance session to be established with the device. This property is read-only.
    - `[SerialNumber <String>]`: SerialNumber. This property is read-only.
    - `[SubscriberCarrier <String>]`: Subscriber Carrier. This property is read-only.
    - `[TotalStorageSpaceInBytes <Int64?>]`: Total Storage in Bytes. This property is read-only.
    - `[Udid <String>]`: Unique Device Identifier for iOS and macOS devices. This property is read-only.
    - `[UserDisplayName <String>]`: User display name. This property is read-only.
    - `[UserId <String>]`: Unique Identifier for the user associated with the device. This property is read-only.
    - `[UserPrincipalName <String>]`: Device user principal name. This property is read-only.
    - `[WiFiMacAddress <String>]`: Wi-Fi MAC. This property is read-only.
  - `[SizeInByte <Int64?>]`: Discovered application size in bytes. Read-only
  - `[Version <String>]`: Version of the discovered application. Read-only

MANAGEDDEVICES <IMicrosoftGraphManagedDevice1[]>: The devices that have the discovered application installed
  - `[Id <String>]`: Read-only.
  - `[ActivationLockBypassCode <String>]`: Code that allows the Activation Lock on a device to be bypassed. This property is read-only.
  - `[AndroidSecurityPatchLevel <String>]`: Android security patch level. This property is read-only.
  - `[AzureAdDeviceId <String>]`: The unique identifier for the Azure Active Directory device. Read only. This property is read-only.
  - `[AzureAdRegistered <Boolean?>]`: Whether the device is Azure Active Directory registered. This property is read-only.
  - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires. This property is read-only.
  - `[ComplianceState <String>]`: complianceState
  - `[ConfigurationManagerClientEnabledFeatures <IMicrosoftGraphConfigurationManagerClientEnabledFeatures>]`: configuration Manager client enabled features
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CompliancePolicy <Boolean?>]`: Whether compliance policy is managed by Intune
    - `[DeviceConfiguration <Boolean?>]`: Whether device configuration is managed by Intune
    - `[Inventory <Boolean?>]`: Whether inventory is managed by Intune
    - `[ModernApps <Boolean?>]`: Whether modern application is managed by Intune
    - `[ResourceAccess <Boolean?>]`: Whether resource access is managed by Intune
    - `[WindowsUpdateForBusiness <Boolean?>]`: Whether Windows Update for Business is managed by Intune
  - `[DeviceActionResults <IMicrosoftGraphDeviceActionResult[]>]`: List of ComplexType deviceActionResult objects. This property is read-only.
    - `[ActionName <String>]`: Action name
    - `[ActionState <String>]`: actionState
    - `[LastUpdatedDateTime <DateTime?>]`: Time the action state was last updated
    - `[StartDateTime <DateTime?>]`: Time the action was initiated
  - `[DeviceCategory <IMicrosoftGraphDeviceCategory>]`: Device categories provides a way to organize your devices. Using device categories, company administrators can define their own categories that make sense to their company. These categories can then be applied to a device in the Intune Azure console or selected by a user during device enrollment. You can filter reports and create dynamic Azure Active Directory device groups based on device categories.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: Optional description for the device category.
    - `[DisplayName <String>]`: Display name for the device category.
  - `[DeviceCategoryDisplayName <String>]`: Device category display name. This property is read-only.
  - `[DeviceCompliancePolicyStates <IMicrosoftGraphDeviceCompliancePolicyState[]>]`: Device compliance policy states for this device.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the policy for this policyBase
    - `[PlatformType <String>]`: 
    - `[SettingCount <Int32?>]`: Count of how many setting a policy holds
    - `[SettingStates <IMicrosoftGraphDeviceCompliancePolicySettingState[]>]`: 
      - `[CurrentValue <String>]`: Current value of setting on device
      - `[ErrorCode <Int64?>]`: Error code for the setting
      - `[ErrorDescription <String>]`: Error description
      - `[InstanceDisplayName <String>]`: Name of setting instance that is being reported.
      - `[Setting <String>]`: The setting that is being reported
      - `[SettingName <String>]`: Localized/user friendly setting name that is being reported
      - `[Sources <IMicrosoftGraphSettingSource[]>]`: Contributing policies
        - `[DisplayName <String>]`: Not yet documented
        - `[Id <String>]`: Not yet documented
      - `[State <String>]`: complianceStatus
      - `[UserEmail <String>]`: UserEmail
      - `[UserId <String>]`: UserId
      - `[UserName <String>]`: UserName
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[State <String>]`: complianceStatus
    - `[Version <Int32?>]`: The version of the policy
  - `[DeviceConfigurationStates <IMicrosoftGraphDeviceConfigurationState[]>]`: Device configuration states for this device.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the policy for this policyBase
    - `[PlatformType <String>]`: 
    - `[SettingCount <Int32?>]`: Count of how many setting a policy holds
    - `[SettingStates <IMicrosoftGraphDeviceConfigurationSettingState[]>]`: 
      - `[CurrentValue <String>]`: Current value of setting on device
      - `[ErrorCode <Int64?>]`: Error code for the setting
      - `[ErrorDescription <String>]`: Error description
      - `[InstanceDisplayName <String>]`: Name of setting instance that is being reported.
      - `[Setting <String>]`: The setting that is being reported
      - `[SettingName <String>]`: Localized/user friendly setting name that is being reported
      - `[Sources <IMicrosoftGraphSettingSource[]>]`: Contributing policies
      - `[State <String>]`: complianceStatus
      - `[UserEmail <String>]`: UserEmail
      - `[UserId <String>]`: UserId
      - `[UserName <String>]`: UserName
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[State <String>]`: complianceStatus
    - `[Version <Int32?>]`: The version of the policy
  - `[DeviceEnrollmentType <String>]`: 
  - `[DeviceHealthAttestationState <IMicrosoftGraphDeviceHealthAttestationState>]`: deviceHealthAttestationState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AttestationIdentityKey <String>]`: TWhen an Attestation Identity Key (AIK) is present on a device, it indicates that the device has an endorsement key (EK) certificate.
    - `[BitLockerStatus <String>]`: On or Off of BitLocker Drive Encryption
    - `[BootAppSecurityVersion <String>]`: The security version number of the Boot Application
    - `[BootDebugging <String>]`: When bootDebugging is enabled, the device is used in development and testing
    - `[BootManagerSecurityVersion <String>]`: The security version number of the Boot Application
    - `[BootManagerVersion <String>]`: The version of the Boot Manager
    - `[BootRevisionListInfo <String>]`: The Boot Revision List that was loaded during initial boot on the attested device
    - `[CodeIntegrity <String>]`: When code integrity is enabled, code execution is restricted to integrity verified code
    - `[CodeIntegrityCheckVersion <String>]`: The version of the Boot Manager
    - `[CodeIntegrityPolicy <String>]`: The Code Integrity policy that is controlling the security of the boot environment
    - `[ContentNamespaceUrl <String>]`: The DHA report version. (Namespace version)
    - `[ContentVersion <String>]`: The HealthAttestation state schema version
    - `[DataExcutionPolicy <String>]`: DEP Policy defines a set of hardware and software technologies that perform additional checks on memory
    - `[DeviceHealthAttestationStatus <String>]`: The DHA report version. (Namespace version)
    - `[EarlyLaunchAntiMalwareDriverProtection <String>]`: ELAM provides protection for the computers in your network when they start up
    - `[HealthAttestationSupportedStatus <String>]`: This attribute indicates if DHA is supported for the device
    - `[HealthStatusMismatchInfo <String>]`: This attribute appears if DHA-Service detects an integrity issue
    - `[IssuedDateTime <DateTime?>]`: The DateTime when device was evaluated or issued to MDM
    - `[LastUpdateDateTime <String>]`: The Timestamp of the last update.
    - `[OperatingSystemKernelDebugging <String>]`: When operatingSystemKernelDebugging is enabled, the device is used in development and testing
    - `[OperatingSystemRevListInfo <String>]`: The Operating System Revision List that was loaded during initial boot on the attested device
    - `[Pcr0 <String>]`: The measurement that is captured in PCR[0]
    - `[PcrHashAlgorithm <String>]`: Informational attribute that identifies the HASH algorithm that was used by TPM
    - `[ResetCount <Int64?>]`: The number of times a PC device has hibernated or resumed
    - `[RestartCount <Int64?>]`: The number of times a PC device has rebooted
    - `[SafeMode <String>]`: Safe mode is a troubleshooting option for Windows that starts your computer in a limited state
    - `[SecureBoot <String>]`: When Secure Boot is enabled, the core components must have the correct cryptographic signatures
    - `[SecureBootConfigurationPolicyFingerPrint <String>]`: Fingerprint of the Custom Secure Boot Configuration Policy
    - `[TestSigning <String>]`: When test signing is allowed, the device does not enforce signature validation during boot
    - `[TpmVersion <String>]`: The security version number of the Boot Application
    - `[VirtualSecureMode <String>]`: VSM is a container that protects high value assets from a compromised kernel
    - `[WindowsPe <String>]`: Operating system running with limited services that is used to prepare a computer for Windows
  - `[DeviceName <String>]`: Name of the device. This property is read-only.
  - `[DeviceRegistrationState <String>]`: deviceRegistrationState
  - `[EasActivated <Boolean?>]`: Whether the device is Exchange ActiveSync activated. This property is read-only.
  - `[EasActivationDateTime <DateTime?>]`: Exchange ActivationSync activation time of the device. This property is read-only.
  - `[EasDeviceId <String>]`: Exchange ActiveSync Id of the device. This property is read-only.
  - `[EmailAddress <String>]`: Email(s) for the user associated with the device. This property is read-only.
  - `[EnrolledDateTime <DateTime?>]`: Enrollment time of the device. This property is read-only.
  - `[EthernetMacAddress <String>]`: Ethernet MAC. This property is read-only.
  - `[ExchangeAccessState <String>]`: deviceManagementExchangeAccessState
  - `[ExchangeAccessStateReason <String>]`: deviceManagementExchangeAccessStateReason
  - `[ExchangeLastSuccessfulSyncDateTime <DateTime?>]`: Last time the device contacted Exchange. This property is read-only.
  - `[FreeStorageSpaceInBytes <Int64?>]`: Free Storage in Bytes. This property is read-only.
  - `[Iccid <String>]`: Integrated Circuit Card Identifier, it is A SIM card's unique identification number. This property is read-only.
  - `[Imei <String>]`: IMEI. This property is read-only.
  - `[IsEncrypted <Boolean?>]`: Device encryption status. This property is read-only.
  - `[IsSupervised <Boolean?>]`: Device supervised status. This property is read-only.
  - `[JailBroken <String>]`: whether the device is jail broken or rooted. This property is read-only.
  - `[LastSyncDateTime <DateTime?>]`: The date and time that the device last completed a successful sync with Intune. This property is read-only.
  - `[ManagedDeviceName <String>]`: Automatically generated name to identify a device. Can be overwritten to a user friendly name.
  - `[ManagedDeviceOwnerType <String>]`: managedDeviceOwnerType
  - `[ManagementAgent <String>]`: 
  - `[Manufacturer <String>]`: Manufacturer of the device. This property is read-only.
  - `[Meid <String>]`: MEID. This property is read-only.
  - `[Model <String>]`: Model of the device. This property is read-only.
  - `[Notes <String>]`: Notes on the device created by IT Admin
  - `[OSVersion <String>]`: Operating system version of the device. This property is read-only.
  - `[OperatingSystem <String>]`: Operating system of the device. Windows, iOS, etc. This property is read-only.
  - `[PartnerReportedThreatState <String>]`: managedDevicePartnerReportedHealthState
  - `[PhoneNumber <String>]`: Phone number of the device. This property is read-only.
  - `[PhysicalMemoryInBytes <Int64?>]`: Total Memory in Bytes. This property is read-only.
  - `[RemoteAssistanceSessionErrorDetails <String>]`: An error string that identifies issues when creating Remote Assistance session objects. This property is read-only.
  - `[RemoteAssistanceSessionUrl <String>]`: Url that allows a Remote Assistance session to be established with the device. This property is read-only.
  - `[SerialNumber <String>]`: SerialNumber. This property is read-only.
  - `[SubscriberCarrier <String>]`: Subscriber Carrier. This property is read-only.
  - `[TotalStorageSpaceInBytes <Int64?>]`: Total Storage in Bytes. This property is read-only.
  - `[Udid <String>]`: Unique Device Identifier for iOS and macOS devices. This property is read-only.
  - `[UserDisplayName <String>]`: User display name. This property is read-only.
  - `[UserId <String>]`: Unique Identifier for the user associated with the device. This property is read-only.
  - `[UserPrincipalName <String>]`: Device user principal name. This property is read-only.
  - `[WiFiMacAddress <String>]`: Wi-Fi MAC. This property is read-only.

## RELATED LINKS

## RELATED LINKS
