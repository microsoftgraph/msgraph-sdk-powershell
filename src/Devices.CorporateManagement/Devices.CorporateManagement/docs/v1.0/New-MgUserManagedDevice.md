---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgusermanageddevice
schema: 2.0.0
---

# New-MgUserManagedDevice

## SYNOPSIS
Create new navigation property to managedDevices for users

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgUserManagedDevice -UserId <String> [-ActivationLockBypassCode <String>]
 [-AdditionalProperties <Hashtable>] [-AndroidSecurityPatchLevel <String>] [-AzureAdDeviceId <String>]
 [-AzureAdRegistered] [-ComplianceGracePeriodExpirationDateTime <DateTime>] [-ComplianceState <String>]
 [-ConfigurationManagerClientEnabledFeatures <IMicrosoftGraphConfigurationManagerClientEnabledFeatures1>]
 [-DeviceActionResults <IMicrosoftGraphDeviceActionResult[]>]
 [-DeviceCategory <IMicrosoftGraphDeviceCategory2>] [-DeviceCategoryDisplayName <String>]
 [-DeviceCompliancePolicyStates <IMicrosoftGraphDeviceCompliancePolicyState1[]>]
 [-DeviceConfigurationStates <IMicrosoftGraphDeviceConfigurationState1[]>] [-DeviceEnrollmentType <String>]
 [-DeviceHealthAttestationState <IMicrosoftGraphDeviceHealthAttestationState>] [-DeviceName <String>]
 [-DeviceRegistrationState <String>] [-EasActivated] [-EasActivationDateTime <DateTime>]
 [-EasDeviceId <String>] [-EmailAddress <String>] [-EnrolledDateTime <DateTime>]
 [-ExchangeAccessState <String>] [-ExchangeAccessStateReason <String>]
 [-ExchangeLastSuccessfulSyncDateTime <DateTime>] [-FreeStorageSpaceInBytes <Int64>] [-Id <String>]
 [-Imei <String>] [-IsEncrypted] [-IsSupervised] [-JailBroken <String>] [-LastSyncDateTime <DateTime>]
 [-ManagedDeviceName <String>] [-ManagedDeviceOwnerType <String>] [-ManagementAgent <String>]
 [-Manufacturer <String>] [-Meid <String>] [-Model <String>] [-OperatingSystem <String>] [-OSVersion <String>]
 [-PartnerReportedThreatState <String>] [-PhoneNumber <String>]
 [-RemoteAssistanceSessionErrorDetails <String>] [-RemoteAssistanceSessionUrl <String>]
 [-SerialNumber <String>] [-SubscriberCarrier <String>] [-TotalStorageSpaceInBytes <Int64>]
 [-UserDisplayName <String>] [-UserId1 <String>] [-UserPrincipalName <String>] [-WiFiMacAddress <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgUserManagedDevice -UserId <String> -BodyParameter <IMicrosoftGraphManagedDevice1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgUserManagedDevice -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphManagedDevice1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgUserManagedDevice -InputObject <IDevicesCorporateManagementIdentity> [-UserId <String>]
 [-ActivationLockBypassCode <String>] [-AdditionalProperties <Hashtable>]
 [-AndroidSecurityPatchLevel <String>] [-AzureAdDeviceId <String>] [-AzureAdRegistered]
 [-ComplianceGracePeriodExpirationDateTime <DateTime>] [-ComplianceState <String>]
 [-ConfigurationManagerClientEnabledFeatures <IMicrosoftGraphConfigurationManagerClientEnabledFeatures1>]
 [-DeviceActionResults <IMicrosoftGraphDeviceActionResult[]>]
 [-DeviceCategory <IMicrosoftGraphDeviceCategory2>] [-DeviceCategoryDisplayName <String>]
 [-DeviceCompliancePolicyStates <IMicrosoftGraphDeviceCompliancePolicyState1[]>]
 [-DeviceConfigurationStates <IMicrosoftGraphDeviceConfigurationState1[]>] [-DeviceEnrollmentType <String>]
 [-DeviceHealthAttestationState <IMicrosoftGraphDeviceHealthAttestationState>] [-DeviceName <String>]
 [-DeviceRegistrationState <String>] [-EasActivated] [-EasActivationDateTime <DateTime>]
 [-EasDeviceId <String>] [-EmailAddress <String>] [-EnrolledDateTime <DateTime>]
 [-ExchangeAccessState <String>] [-ExchangeAccessStateReason <String>]
 [-ExchangeLastSuccessfulSyncDateTime <DateTime>] [-FreeStorageSpaceInBytes <Int64>] [-Id <String>]
 [-Imei <String>] [-IsEncrypted] [-IsSupervised] [-JailBroken <String>] [-LastSyncDateTime <DateTime>]
 [-ManagedDeviceName <String>] [-ManagedDeviceOwnerType <String>] [-ManagementAgent <String>]
 [-Manufacturer <String>] [-Meid <String>] [-Model <String>] [-OperatingSystem <String>] [-OSVersion <String>]
 [-PartnerReportedThreatState <String>] [-PhoneNumber <String>]
 [-RemoteAssistanceSessionErrorDetails <String>] [-RemoteAssistanceSessionUrl <String>]
 [-SerialNumber <String>] [-SubscriberCarrier <String>] [-TotalStorageSpaceInBytes <Int64>]
 [-UserDisplayName <String>] [-UserPrincipalName <String>] [-WiFiMacAddress <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to managedDevices for users

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

### -ActivationLockBypassCode
Code that allows the Activation Lock on a device to be bypassed.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AndroidSecurityPatchLevel
Android security patch level

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureAdDeviceId
The unique identifier for the Azure Active Directory device.
Read only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureAdRegistered
Whether the device is Azure Active Directory registered.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Devices that are managed or pre-enrolled through Intune
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDevice1
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ComplianceGracePeriodExpirationDateTime
The DateTime when device compliance grace period expires

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ComplianceState
complianceState

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConfigurationManagerClientEnabledFeatures
configuration Manager client enabled features
To construct, see NOTES section for CONFIGURATIONMANAGERCLIENTENABLEDFEATURES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConfigurationManagerClientEnabledFeatures1
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceActionResults
List of ComplexType deviceActionResult objects.
To construct, see NOTES section for DEVICEACTIONRESULTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceActionResult[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceCategory
Device categories provides a way to organize your devices.
Using device categories, company administrators can define their own categories that make sense to their company.These categories can then be applied to a device in the Intune Azure console or selected by a user during device enrollment.
You can filter reports and create dynamic Azure Active Directory device groups based on device categories.
To construct, see NOTES section for DEVICECATEGORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceCategory2
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceCategoryDisplayName
Device category display name

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceCompliancePolicyStates
Device compliance policy states for this device.
To construct, see NOTES section for DEVICECOMPLIANCEPOLICYSTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicyState1[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceConfigurationStates
Device configuration states for this device.
To construct, see NOTES section for DEVICECONFIGURATIONSTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationState1[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceEnrollmentType
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceHealthAttestationState
deviceHealthAttestationState
To construct, see NOTES section for DEVICEHEALTHATTESTATIONSTATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceHealthAttestationState
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceName
Name of the device

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceRegistrationState
deviceRegistrationState

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EasActivated
Whether the device is Exchange ActiveSync activated.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EasActivationDateTime
Exchange ActivationSync activation time of the device.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EasDeviceId
Exchange ActiveSync Id of the device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAddress
Email(s) for the user associated with the device

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrolledDateTime
Enrollment time of the device.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExchangeAccessState
deviceManagementExchangeAccessState

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExchangeAccessStateReason
deviceManagementExchangeAccessStateReason

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExchangeLastSuccessfulSyncDateTime
Last time the device contacted Exchange.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FreeStorageSpaceInBytes
Free Storage in Bytes

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Imei
IMEI

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsEncrypted
Device encryption status

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSupervised
Device supervised status

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JailBroken
whether the device is jail broken or rooted.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastSyncDateTime
The date and time that the device last completed a successful sync with Intune.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedDeviceName
Automatically generated name to identify a device.
Can be overwritten to a user friendly name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedDeviceOwnerType
managedDeviceOwnerType

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementAgent
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manufacturer
Manufacturer of the device

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Meid
MEID

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Model
Model of the device

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OperatingSystem
Operating system of the device.
Windows, iOS, etc.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OSVersion
Operating system version of the device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PartnerReportedThreatState
managedDevicePartnerReportedHealthState

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PhoneNumber
Phone number of the device

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemoteAssistanceSessionErrorDetails
An error string that identifies issues when creating Remote Assistance session objects.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemoteAssistanceSessionUrl
Url that allows a Remote Assistance session to be established with the device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SerialNumber
SerialNumber

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriberCarrier
Subscriber Carrier

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TotalStorageSpaceInBytes
Total Storage in Bytes

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserDisplayName
User display name

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId1
Unique Identifier for the user associated with the device

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
Device user principal name

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WiFiMacAddress
Wi-Fi MAC

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDevice1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDevice1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedDevice1>: Devices that are managed or pre-enrolled through Intune
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ActivationLockBypassCode <String>]`: Code that allows the Activation Lock on a device to be bypassed.
  - `[AndroidSecurityPatchLevel <String>]`: Android security patch level
  - `[AzureAdDeviceId <String>]`: The unique identifier for the Azure Active Directory device. Read only.
  - `[AzureAdRegistered <Boolean?>]`: Whether the device is Azure Active Directory registered.
  - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
  - `[ComplianceState <String>]`: complianceState
  - `[ConfigurationManagerClientEnabledFeatures <IMicrosoftGraphConfigurationManagerClientEnabledFeatures1>]`: configuration Manager client enabled features
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CompliancePolicy <Boolean?>]`: Whether compliance policy is managed by Intune
    - `[DeviceConfiguration <Boolean?>]`: Whether device configuration is managed by Intune
    - `[Inventory <Boolean?>]`: Whether inventory is managed by Intune
    - `[ModernApps <Boolean?>]`: Whether modern application is managed by Intune
    - `[ResourceAccess <Boolean?>]`: Whether resource access is managed by Intune
    - `[WindowsUpdateForBusiness <Boolean?>]`: Whether Windows Update for Business is managed by Intune
  - `[DeviceActionResults <IMicrosoftGraphDeviceActionResult[]>]`: List of ComplexType deviceActionResult objects.
    - `[ActionName <String>]`: Action name
    - `[ActionState <String>]`: actionState
    - `[LastUpdatedDateTime <DateTime?>]`: Time the action state was last updated
    - `[StartDateTime <DateTime?>]`: Time the action was initiated
  - `[DeviceCategory <IMicrosoftGraphDeviceCategory2>]`: Device categories provides a way to organize your devices. Using device categories, company administrators can define their own categories that make sense to their company.??These categories can then be applied to a device in the Intune Azure console or selected by a user during device enrollment. You can filter reports and create dynamic Azure Active Directory device groups based on device categories.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: Optional description for the device category.
    - `[DisplayName <String>]`: Display name for the device category.
  - `[DeviceCategoryDisplayName <String>]`: Device category display name
  - `[DeviceCompliancePolicyStates <IMicrosoftGraphDeviceCompliancePolicyState1[]>]`: Device compliance policy states for this device.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the policy for this policyBase
    - `[PlatformType <String>]`: 
    - `[SettingCount <Int32?>]`: Count of how many setting a policy holds
    - `[SettingStates <IMicrosoftGraphDeviceCompliancePolicySettingState1[]>]`: 
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
  - `[DeviceConfigurationStates <IMicrosoftGraphDeviceConfigurationState1[]>]`: Device configuration states for this device.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the policy for this policyBase
    - `[PlatformType <String>]`: 
    - `[SettingCount <Int32?>]`: Count of how many setting a policy holds
    - `[SettingStates <IMicrosoftGraphDeviceConfigurationSettingState1[]>]`: 
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
  - `[DeviceName <String>]`: Name of the device
  - `[DeviceRegistrationState <String>]`: deviceRegistrationState
  - `[EasActivated <Boolean?>]`: Whether the device is Exchange ActiveSync activated.
  - `[EasActivationDateTime <DateTime?>]`: Exchange ActivationSync activation time of the device.
  - `[EasDeviceId <String>]`: Exchange ActiveSync Id of the device.
  - `[EmailAddress <String>]`: Email(s) for the user associated with the device
  - `[EnrolledDateTime <DateTime?>]`: Enrollment time of the device.
  - `[ExchangeAccessState <String>]`: deviceManagementExchangeAccessState
  - `[ExchangeAccessStateReason <String>]`: deviceManagementExchangeAccessStateReason
  - `[ExchangeLastSuccessfulSyncDateTime <DateTime?>]`: Last time the device contacted Exchange.
  - `[FreeStorageSpaceInBytes <Int64?>]`: Free Storage in Bytes
  - `[Imei <String>]`: IMEI
  - `[IsEncrypted <Boolean?>]`: Device encryption status
  - `[IsSupervised <Boolean?>]`: Device supervised status
  - `[JailBroken <String>]`: whether the device is jail broken or rooted.
  - `[LastSyncDateTime <DateTime?>]`: The date and time that the device last completed a successful sync with Intune.
  - `[ManagedDeviceName <String>]`: Automatically generated name to identify a device. Can be overwritten to a user friendly name.
  - `[ManagedDeviceOwnerType <String>]`: managedDeviceOwnerType
  - `[ManagementAgent <String>]`: 
  - `[Manufacturer <String>]`: Manufacturer of the device
  - `[Meid <String>]`: MEID
  - `[Model <String>]`: Model of the device
  - `[OSVersion <String>]`: Operating system version of the device.
  - `[OperatingSystem <String>]`: Operating system of the device. Windows, iOS, etc.
  - `[PartnerReportedThreatState <String>]`: managedDevicePartnerReportedHealthState
  - `[PhoneNumber <String>]`: Phone number of the device
  - `[RemoteAssistanceSessionErrorDetails <String>]`: An error string that identifies issues when creating Remote Assistance session objects.
  - `[RemoteAssistanceSessionUrl <String>]`: Url that allows a Remote Assistance session to be established with the device.
  - `[SerialNumber <String>]`: SerialNumber
  - `[SubscriberCarrier <String>]`: Subscriber Carrier
  - `[TotalStorageSpaceInBytes <Int64?>]`: Total Storage in Bytes
  - `[UserDisplayName <String>]`: User display name
  - `[UserId <String>]`: Unique Identifier for the user associated with the device
  - `[UserPrincipalName <String>]`: Device user principal name
  - `[WiFiMacAddress <String>]`: Wi-Fi MAC

CONFIGURATIONMANAGERCLIENTENABLEDFEATURES <IMicrosoftGraphConfigurationManagerClientEnabledFeatures1>: configuration Manager client enabled features
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CompliancePolicy <Boolean?>]`: Whether compliance policy is managed by Intune
  - `[DeviceConfiguration <Boolean?>]`: Whether device configuration is managed by Intune
  - `[Inventory <Boolean?>]`: Whether inventory is managed by Intune
  - `[ModernApps <Boolean?>]`: Whether modern application is managed by Intune
  - `[ResourceAccess <Boolean?>]`: Whether resource access is managed by Intune
  - `[WindowsUpdateForBusiness <Boolean?>]`: Whether Windows Update for Business is managed by Intune

DEVICEACTIONRESULTS <IMicrosoftGraphDeviceActionResult[]>: List of ComplexType deviceActionResult objects.
  - `[ActionName <String>]`: Action name
  - `[ActionState <String>]`: actionState
  - `[LastUpdatedDateTime <DateTime?>]`: Time the action state was last updated
  - `[StartDateTime <DateTime?>]`: Time the action was initiated

DEVICECATEGORY <IMicrosoftGraphDeviceCategory2>: Device categories provides a way to organize your devices. Using device categories, company administrators can define their own categories that make sense to their company.These categories can then be applied to a device in the Intune Azure console or selected by a user during device enrollment. You can filter reports and create dynamic Azure Active Directory device groups based on device categories.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: Optional description for the device category.
  - `[DisplayName <String>]`: Display name for the device category.

DEVICECOMPLIANCEPOLICYSTATES <IMicrosoftGraphDeviceCompliancePolicyState1[]>: Device compliance policy states for this device.
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: The name of the policy for this policyBase
  - `[PlatformType <String>]`: 
  - `[SettingCount <Int32?>]`: Count of how many setting a policy holds
  - `[SettingStates <IMicrosoftGraphDeviceCompliancePolicySettingState1[]>]`: 
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

DEVICECONFIGURATIONSTATES <IMicrosoftGraphDeviceConfigurationState1[]>: Device configuration states for this device.
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: The name of the policy for this policyBase
  - `[PlatformType <String>]`: 
  - `[SettingCount <Int32?>]`: Count of how many setting a policy holds
  - `[SettingStates <IMicrosoftGraphDeviceConfigurationSettingState1[]>]`: 
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

DEVICEHEALTHATTESTATIONSTATE <IMicrosoftGraphDeviceHealthAttestationState>: deviceHealthAttestationState
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

INPUTOBJECT <IDevicesCorporateManagementIdentity>: Identity Parameter
  - `[AndroidManagedAppProtectionId <String>]`: key: id of androidManagedAppProtection
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[BundleId <String>]`: 
  - `[Count <Int64?>]`: 
  - `[DefaultManagedAppProtectionId <String>]`: key: id of defaultManagedAppProtection
  - `[DetectedAppId <String>]`: key: id of detectedApp
  - `[DeviceAppManagementTaskId <String>]`: key: id of deviceAppManagementTask
  - `[DeviceCompliancePolicyStateId <String>]`: key: id of deviceCompliancePolicyState
  - `[DeviceConfigurationStateId <String>]`: key: id of deviceConfigurationState
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceId <String>]`: 
  - `[DeviceInstallStateId <String>]`: key: id of deviceInstallState
  - `[DeviceLogCollectionResponseId <String>]`: key: id of deviceLogCollectionResponse
  - `[DeviceManagementTroubleshootingEventId <String>]`: key: id of deviceManagementTroubleshootingEvent
  - `[EnrollmentConfigurationAssignmentId <String>]`: key: id of enrollmentConfigurationAssignment
  - `[EnterpriseCodeSigningCertificateId <String>]`: key: id of enterpriseCodeSigningCertificate
  - `[IosLobAppProvisioningConfigurationAssignmentId <String>]`: key: id of iosLobAppProvisioningConfigurationAssignment
  - `[IosLobAppProvisioningConfigurationId <String>]`: key: id of iosLobAppProvisioningConfiguration
  - `[IosManagedAppProtectionId <String>]`: key: id of iosManagedAppProtection
  - `[ManagedAppOperationId <String>]`: key: id of managedAppOperation
  - `[ManagedAppPolicyId <String>]`: key: id of managedAppPolicy
  - `[ManagedAppRegistrationId <String>]`: key: id of managedAppRegistration
  - `[ManagedAppStatusId <String>]`: key: id of managedAppStatus
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[ManagedDeviceMobileAppConfigurationAssignmentId <String>]`: key: id of managedDeviceMobileAppConfigurationAssignment
  - `[ManagedDeviceMobileAppConfigurationDeviceStatusId <String>]`: key: id of managedDeviceMobileAppConfigurationDeviceStatus
  - `[ManagedDeviceMobileAppConfigurationId <String>]`: key: id of managedDeviceMobileAppConfiguration
  - `[ManagedDeviceMobileAppConfigurationStateId <String>]`: key: id of managedDeviceMobileAppConfigurationState
  - `[ManagedDeviceMobileAppConfigurationUserStatusId <String>]`: key: id of managedDeviceMobileAppConfigurationUserStatus
  - `[ManagedEBookAssignmentId <String>]`: key: id of managedEBookAssignment
  - `[ManagedEBookCategoryId <String>]`: key: id of managedEBookCategory
  - `[ManagedEBookId <String>]`: key: id of managedEBook
  - `[ManagedMobileAppId <String>]`: key: id of managedMobileApp
  - `[MdmWindowsInformationProtectionPolicyId <String>]`: key: id of mdmWindowsInformationProtectionPolicy
  - `[MobileAppAssignmentId <String>]`: key: id of mobileAppAssignment
  - `[MobileAppCategoryId <String>]`: key: id of mobileAppCategory
  - `[MobileAppId <String>]`: key: id of mobileApp
  - `[MobileAppInstallStatusId <String>]`: key: id of mobileAppInstallStatus
  - `[MobileAppIntentAndStateId <String>]`: key: id of mobileAppIntentAndState
  - `[MobileAppProvisioningConfigGroupAssignmentId <String>]`: key: id of mobileAppProvisioningConfigGroupAssignment
  - `[MobileAppRelationshipId <String>]`: key: id of mobileAppRelationship
  - `[MobileAppTroubleshootingEventId <String>]`: key: id of mobileAppTroubleshootingEvent
  - `[OfficeClientConfigurationAssignmentId <String>]`: key: id of officeClientConfigurationAssignment
  - `[OfficeClientConfigurationId <String>]`: key: id of officeClientConfiguration
  - `[PolicySetAssignmentId <String>]`: key: id of policySetAssignment
  - `[PolicySetId <String>]`: key: id of policySet
  - `[PolicySetItemId <String>]`: key: id of policySetItem
  - `[SecurityBaselineSettingStateId <String>]`: key: id of securityBaselineSettingState
  - `[SecurityBaselineStateId <String>]`: key: id of securityBaselineState
  - `[SideLoadingKeyId <String>]`: key: id of sideLoadingKey
  - `[Status <String>]`: 
  - `[TargetedManagedAppConfigurationId <String>]`: key: id of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: key: id of targetedManagedAppPolicyAssignment
  - `[UserAppInstallStatusId <String>]`: key: id of userAppInstallStatus
  - `[UserId <String>]`: key: id of user
  - `[UserId1 <String>]`: key: id of user
  - `[UserInstallStateSummaryId <String>]`: key: id of userInstallStateSummary
  - `[UserPrincipalName <String>]`: 
  - `[VppTokenId <String>]`: key: id of vppToken
  - `[WindowsDefenderApplicationControlSupplementalPolicyAssignmentId <String>]`: key: id of windowsDefenderApplicationControlSupplementalPolicyAssignment
  - `[WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId <String>]`: key: id of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
  - `[WindowsDefenderApplicationControlSupplementalPolicyId <String>]`: key: id of windowsDefenderApplicationControlSupplementalPolicy
  - `[WindowsDeviceMalwareStateId <String>]`: key: id of windowsDeviceMalwareState
  - `[WindowsInformationProtectionDeviceRegistrationId <String>]`: key: id of windowsInformationProtectionDeviceRegistration
  - `[WindowsInformationProtectionPolicyId <String>]`: key: id of windowsInformationProtectionPolicy
  - `[WindowsInformationProtectionWipeActionId <String>]`: key: id of windowsInformationProtectionWipeAction

## RELATED LINKS

