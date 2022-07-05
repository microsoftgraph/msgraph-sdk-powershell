---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementmanageddevice
schema: 2.0.0
---

# Update-MgDeviceManagementManagedDevice

## SYNOPSIS
Update the navigation property managedDevices in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementManagedDevice -ManagedDeviceId <String> [-ActivationLockBypassCode <String>]
 [-AdditionalProperties <Hashtable>] [-AndroidSecurityPatchLevel <String>] [-AzureAdDeviceId <String>]
 [-AzureAdRegistered] [-ComplianceGracePeriodExpirationDateTime <DateTime>]
 [-ComplianceState <ComplianceState>]
 [-ConfigurationManagerClientEnabledFeatures <IMicrosoftGraphConfigurationManagerClientEnabledFeatures>]
 [-DeviceActionResults <IMicrosoftGraphDeviceActionResult[]>]
 [-DeviceCategory <IMicrosoftGraphDeviceCategory>] [-DeviceCategoryDisplayName <String>]
 [-DeviceCompliancePolicyStates <IMicrosoftGraphDeviceCompliancePolicyState[]>]
 [-DeviceConfigurationStates <IMicrosoftGraphDeviceConfigurationState[]>]
 [-DeviceEnrollmentType <DeviceEnrollmentType>]
 [-DeviceHealthAttestationState <IMicrosoftGraphDeviceHealthAttestationState>] [-DeviceName <String>]
 [-DeviceRegistrationState <DeviceRegistrationState>] [-EasActivated] [-EasActivationDateTime <DateTime>]
 [-EasDeviceId <String>] [-EmailAddress <String>] [-EnrolledDateTime <DateTime>]
 [-EthernetMacAddress <String>] [-ExchangeAccessState <DeviceManagementExchangeAccessState>]
 [-ExchangeAccessStateReason <DeviceManagementExchangeAccessStateReason>]
 [-ExchangeLastSuccessfulSyncDateTime <DateTime>] [-FreeStorageSpaceInBytes <Int64>] [-Iccid <String>]
 [-Id <String>] [-Imei <String>] [-IsEncrypted] [-IsSupervised] [-JailBroken <String>]
 [-LastSyncDateTime <DateTime>] [-ManagedDeviceName <String>]
 [-ManagedDeviceOwnerType <ManagedDeviceOwnerType>] [-ManagementAgent <ManagementAgentType>]
 [-Manufacturer <String>] [-Meid <String>] [-Model <String>] [-Notes <String>] [-OperatingSystem <String>]
 [-OSVersion <String>] [-PartnerReportedThreatState <ManagedDevicePartnerReportedHealthState>]
 [-PhoneNumber <String>] [-PhysicalMemoryInBytes <Int64>] [-RemoteAssistanceSessionErrorDetails <String>]
 [-RemoteAssistanceSessionUrl <String>] [-SerialNumber <String>] [-SubscriberCarrier <String>]
 [-TotalStorageSpaceInBytes <Int64>] [-Udid <String>] [-UserDisplayName <String>] [-UserId <String>]
 [-UserPrincipalName <String>] [-WiFiMacAddress <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementManagedDevice -ManagedDeviceId <String> -BodyParameter <IMicrosoftGraphManagedDevice>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementManagedDevice -InputObject <IDeviceManagementIdentity>
 -BodyParameter <IMicrosoftGraphManagedDevice> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementManagedDevice -InputObject <IDeviceManagementIdentity>
 [-ActivationLockBypassCode <String>] [-AdditionalProperties <Hashtable>]
 [-AndroidSecurityPatchLevel <String>] [-AzureAdDeviceId <String>] [-AzureAdRegistered]
 [-ComplianceGracePeriodExpirationDateTime <DateTime>] [-ComplianceState <ComplianceState>]
 [-ConfigurationManagerClientEnabledFeatures <IMicrosoftGraphConfigurationManagerClientEnabledFeatures>]
 [-DeviceActionResults <IMicrosoftGraphDeviceActionResult[]>]
 [-DeviceCategory <IMicrosoftGraphDeviceCategory>] [-DeviceCategoryDisplayName <String>]
 [-DeviceCompliancePolicyStates <IMicrosoftGraphDeviceCompliancePolicyState[]>]
 [-DeviceConfigurationStates <IMicrosoftGraphDeviceConfigurationState[]>]
 [-DeviceEnrollmentType <DeviceEnrollmentType>]
 [-DeviceHealthAttestationState <IMicrosoftGraphDeviceHealthAttestationState>] [-DeviceName <String>]
 [-DeviceRegistrationState <DeviceRegistrationState>] [-EasActivated] [-EasActivationDateTime <DateTime>]
 [-EasDeviceId <String>] [-EmailAddress <String>] [-EnrolledDateTime <DateTime>]
 [-EthernetMacAddress <String>] [-ExchangeAccessState <DeviceManagementExchangeAccessState>]
 [-ExchangeAccessStateReason <DeviceManagementExchangeAccessStateReason>]
 [-ExchangeLastSuccessfulSyncDateTime <DateTime>] [-FreeStorageSpaceInBytes <Int64>] [-Iccid <String>]
 [-Id <String>] [-Imei <String>] [-IsEncrypted] [-IsSupervised] [-JailBroken <String>]
 [-LastSyncDateTime <DateTime>] [-ManagedDeviceName <String>]
 [-ManagedDeviceOwnerType <ManagedDeviceOwnerType>] [-ManagementAgent <ManagementAgentType>]
 [-Manufacturer <String>] [-Meid <String>] [-Model <String>] [-Notes <String>] [-OperatingSystem <String>]
 [-OSVersion <String>] [-PartnerReportedThreatState <ManagedDevicePartnerReportedHealthState>]
 [-PhoneNumber <String>] [-PhysicalMemoryInBytes <Int64>] [-RemoteAssistanceSessionErrorDetails <String>]
 [-RemoteAssistanceSessionUrl <String>] [-SerialNumber <String>] [-SubscriberCarrier <String>]
 [-TotalStorageSpaceInBytes <Int64>] [-Udid <String>] [-UserDisplayName <String>] [-UserId <String>]
 [-UserPrincipalName <String>] [-WiFiMacAddress <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property managedDevices in deviceManagement

## EXAMPLES

## PARAMETERS

### -ActivationLockBypassCode
Code that allows the Activation Lock on a device to be bypassed.
This property is read-only.

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

### -AndroidSecurityPatchLevel
Android security patch level.
This property is read-only.

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

### -AzureAdDeviceId
The unique identifier for the Azure Active Directory device.
Read only.
This property is read-only.

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

### -AzureAdRegistered
Whether the device is Azure Active Directory registered.
This property is read-only.

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

### -BodyParameter
Devices that are managed or pre-enrolled through Intune
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDevice
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ComplianceGracePeriodExpirationDateTime
The DateTime when device compliance grace period expires.
This property is read-only.

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

### -ComplianceState
Compliance state.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ComplianceState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConfigurationManagerClientEnabledFeatures
configuration Manager client enabled features
To construct, please use Get-Help -Online and see NOTES section for CONFIGURATIONMANAGERCLIENTENABLEDFEATURES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConfigurationManagerClientEnabledFeatures
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceActionResults
List of ComplexType deviceActionResult objects.
This property is read-only.
To construct, please use Get-Help -Online and see NOTES section for DEVICEACTIONRESULTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceActionResult[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceCategory
Device categories provides a way to organize your devices.
Using device categories, company administrators can define their own categories that make sense to their company.
These categories can then be applied to a device in the Intune Azure console or selected by a user during device enrollment.
You can filter reports and create dynamic Azure Active Directory device groups based on device categories.
To construct, please use Get-Help -Online and see NOTES section for DEVICECATEGORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceCategory
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceCategoryDisplayName
Device category display name.
This property is read-only.

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

### -DeviceCompliancePolicyStates
Device compliance policy states for this device.
To construct, please use Get-Help -Online and see NOTES section for DEVICECOMPLIANCEPOLICYSTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicyState[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceConfigurationStates
Device configuration states for this device.
To construct, please use Get-Help -Online and see NOTES section for DEVICECONFIGURATIONSTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationState[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceEnrollmentType
Possible ways of adding a mobile device to management.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceEnrollmentType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceHealthAttestationState
deviceHealthAttestationState
To construct, please use Get-Help -Online and see NOTES section for DEVICEHEALTHATTESTATIONSTATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceHealthAttestationState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceName
Name of the device.
This property is read-only.

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

### -DeviceRegistrationState
Device registration status.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceRegistrationState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EasActivated
Whether the device is Exchange ActiveSync activated.
This property is read-only.

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

### -EasActivationDateTime
Exchange ActivationSync activation time of the device.
This property is read-only.

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

### -EasDeviceId
Exchange ActiveSync Id of the device.
This property is read-only.

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

### -EmailAddress
Email(s) for the user associated with the device.
This property is read-only.

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

### -EnrolledDateTime
Enrollment time of the device.
This property is read-only.

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

### -EthernetMacAddress
Ethernet MAC.
This property is read-only.

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

### -ExchangeAccessState
Device Exchange Access State.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementExchangeAccessState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExchangeAccessStateReason
Device Exchange Access State Reason.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementExchangeAccessStateReason
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExchangeLastSuccessfulSyncDateTime
Last time the device contacted Exchange.
This property is read-only.

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

### -FreeStorageSpaceInBytes
Free Storage in Bytes.
This property is read-only.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Iccid
Integrated Circuit Card Identifier, it is A SIM card's unique identification number.
This property is read-only.

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
.

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

### -Imei
IMEI.
This property is read-only.

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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsEncrypted
Device encryption status.
This property is read-only.

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

### -IsSupervised
Device supervised status.
This property is read-only.

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

### -JailBroken
whether the device is jail broken or rooted.
This property is read-only.

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
The date and time that the device last completed a successful sync with Intune.
This property is read-only.

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

### -ManagedDeviceId
key: id of managedDevice

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

### -ManagedDeviceName
Automatically generated name to identify a device.
Can be overwritten to a user friendly name.

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

### -ManagedDeviceOwnerType
Owner type of device.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedDeviceOwnerType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementAgent
Management agent type.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagementAgentType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manufacturer
Manufacturer of the device.
This property is read-only.

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

### -Meid
MEID.
This property is read-only.

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

### -Model
Model of the device.
This property is read-only.

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

### -Notes
Notes on the device created by IT Admin

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

### -OperatingSystem
Operating system of the device.
Windows, iOS, etc.
This property is read-only.

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
Operating system version of the device.
This property is read-only.

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

### -PartnerReportedThreatState
Available health states for the Device Health API

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedDevicePartnerReportedHealthState
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

### -PhoneNumber
Phone number of the device.
This property is read-only.

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

### -PhysicalMemoryInBytes
Total Memory in Bytes.
This property is read-only.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemoteAssistanceSessionErrorDetails
An error string that identifies issues when creating Remote Assistance session objects.
This property is read-only.

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

### -RemoteAssistanceSessionUrl
Url that allows a Remote Assistance session to be established with the device.
This property is read-only.

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

### -SerialNumber
SerialNumber.
This property is read-only.

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

### -SubscriberCarrier
Subscriber Carrier.
This property is read-only.

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

### -TotalStorageSpaceInBytes
Total Storage in Bytes.
This property is read-only.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Udid
Unique Device Identifier for iOS and macOS devices.
This property is read-only.

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

### -UserDisplayName
User display name.
This property is read-only.

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

### -UserId
Unique Identifier for the user associated with the device.
This property is read-only.

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
Device user principal name.
This property is read-only.

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

### -WiFiMacAddress
Wi-Fi MAC.
This property is read-only.

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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDevice

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedDevice>: Devices that are managed or pre-enrolled through Intune
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ActivationLockBypassCode <String>]`: Code that allows the Activation Lock on a device to be bypassed. This property is read-only.
  - `[AndroidSecurityPatchLevel <String>]`: Android security patch level. This property is read-only.
  - `[AzureAdDeviceId <String>]`: The unique identifier for the Azure Active Directory device. Read only. This property is read-only.
  - `[AzureAdRegistered <Boolean?>]`: Whether the device is Azure Active Directory registered. This property is read-only.
  - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires. This property is read-only.
  - `[ComplianceState <ComplianceState?>]`: Compliance state.
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
    - `[ActionState <ActionState?>]`: State of the action on the device
    - `[LastUpdatedDateTime <DateTime?>]`: Time the action state was last updated
    - `[StartDateTime <DateTime?>]`: Time the action was initiated
  - `[DeviceCategory <IMicrosoftGraphDeviceCategory>]`: Device categories provides a way to organize your devices. Using device categories, company administrators can define their own categories that make sense to their company. These categories can then be applied to a device in the Intune Azure console or selected by a user during device enrollment. You can filter reports and create dynamic Azure Active Directory device groups based on device categories.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Description <String>]`: Optional description for the device category.
    - `[DisplayName <String>]`: Display name for the device category.
  - `[DeviceCategoryDisplayName <String>]`: Device category display name. This property is read-only.
  - `[DeviceCompliancePolicyStates <IMicrosoftGraphDeviceCompliancePolicyState[]>]`: Device compliance policy states for this device.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The name of the policy for this policyBase
    - `[PlatformType <PolicyPlatformType?>]`: Supported platform types for policies.
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
        - `[SourceType <String>]`: settingSourceType
      - `[State <String>]`: complianceStatus
      - `[UserEmail <String>]`: UserEmail
      - `[UserId <String>]`: UserId
      - `[UserName <String>]`: UserName
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[State <String>]`: complianceStatus
    - `[Version <Int32?>]`: The version of the policy
  - `[DeviceConfigurationStates <IMicrosoftGraphDeviceConfigurationState[]>]`: Device configuration states for this device.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The name of the policy for this policyBase
    - `[PlatformType <PolicyPlatformType?>]`: Supported platform types for policies.
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
  - `[DeviceEnrollmentType <DeviceEnrollmentType?>]`: Possible ways of adding a mobile device to management.
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
  - `[DeviceRegistrationState <DeviceRegistrationState?>]`: Device registration status.
  - `[EasActivated <Boolean?>]`: Whether the device is Exchange ActiveSync activated. This property is read-only.
  - `[EasActivationDateTime <DateTime?>]`: Exchange ActivationSync activation time of the device. This property is read-only.
  - `[EasDeviceId <String>]`: Exchange ActiveSync Id of the device. This property is read-only.
  - `[EmailAddress <String>]`: Email(s) for the user associated with the device. This property is read-only.
  - `[EnrolledDateTime <DateTime?>]`: Enrollment time of the device. This property is read-only.
  - `[EthernetMacAddress <String>]`: Ethernet MAC. This property is read-only.
  - `[ExchangeAccessState <DeviceManagementExchangeAccessState?>]`: Device Exchange Access State.
  - `[ExchangeAccessStateReason <DeviceManagementExchangeAccessStateReason?>]`: Device Exchange Access State Reason.
  - `[ExchangeLastSuccessfulSyncDateTime <DateTime?>]`: Last time the device contacted Exchange. This property is read-only.
  - `[FreeStorageSpaceInBytes <Int64?>]`: Free Storage in Bytes. This property is read-only.
  - `[Iccid <String>]`: Integrated Circuit Card Identifier, it is A SIM card's unique identification number. This property is read-only.
  - `[Imei <String>]`: IMEI. This property is read-only.
  - `[IsEncrypted <Boolean?>]`: Device encryption status. This property is read-only.
  - `[IsSupervised <Boolean?>]`: Device supervised status. This property is read-only.
  - `[JailBroken <String>]`: whether the device is jail broken or rooted. This property is read-only.
  - `[LastSyncDateTime <DateTime?>]`: The date and time that the device last completed a successful sync with Intune. This property is read-only.
  - `[ManagedDeviceName <String>]`: Automatically generated name to identify a device. Can be overwritten to a user friendly name.
  - `[ManagedDeviceOwnerType <ManagedDeviceOwnerType?>]`: Owner type of device.
  - `[ManagementAgent <ManagementAgentType?>]`: Management agent type.
  - `[Manufacturer <String>]`: Manufacturer of the device. This property is read-only.
  - `[Meid <String>]`: MEID. This property is read-only.
  - `[Model <String>]`: Model of the device. This property is read-only.
  - `[Notes <String>]`: Notes on the device created by IT Admin
  - `[OSVersion <String>]`: Operating system version of the device. This property is read-only.
  - `[OperatingSystem <String>]`: Operating system of the device. Windows, iOS, etc. This property is read-only.
  - `[PartnerReportedThreatState <ManagedDevicePartnerReportedHealthState?>]`: Available health states for the Device Health API
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

CONFIGURATIONMANAGERCLIENTENABLEDFEATURES <IMicrosoftGraphConfigurationManagerClientEnabledFeatures>: configuration Manager client enabled features
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CompliancePolicy <Boolean?>]`: Whether compliance policy is managed by Intune
  - `[DeviceConfiguration <Boolean?>]`: Whether device configuration is managed by Intune
  - `[Inventory <Boolean?>]`: Whether inventory is managed by Intune
  - `[ModernApps <Boolean?>]`: Whether modern application is managed by Intune
  - `[ResourceAccess <Boolean?>]`: Whether resource access is managed by Intune
  - `[WindowsUpdateForBusiness <Boolean?>]`: Whether Windows Update for Business is managed by Intune

DEVICEACTIONRESULTS <IMicrosoftGraphDeviceActionResult[]>: List of ComplexType deviceActionResult objects. This property is read-only.
  - `[ActionName <String>]`: Action name
  - `[ActionState <ActionState?>]`: State of the action on the device
  - `[LastUpdatedDateTime <DateTime?>]`: Time the action state was last updated
  - `[StartDateTime <DateTime?>]`: Time the action was initiated

DEVICECATEGORY <IMicrosoftGraphDeviceCategory>: Device categories provides a way to organize your devices. Using device categories, company administrators can define their own categories that make sense to their company. These categories can then be applied to a device in the Intune Azure console or selected by a user during device enrollment. You can filter reports and create dynamic Azure Active Directory device groups based on device categories.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Description <String>]`: Optional description for the device category.
  - `[DisplayName <String>]`: Display name for the device category.

DEVICECOMPLIANCEPOLICYSTATES <IMicrosoftGraphDeviceCompliancePolicyState[]>: Device compliance policy states for this device.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The name of the policy for this policyBase
  - `[PlatformType <PolicyPlatformType?>]`: Supported platform types for policies.
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
      - `[SourceType <String>]`: settingSourceType
    - `[State <String>]`: complianceStatus
    - `[UserEmail <String>]`: UserEmail
    - `[UserId <String>]`: UserId
    - `[UserName <String>]`: UserName
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[State <String>]`: complianceStatus
  - `[Version <Int32?>]`: The version of the policy

DEVICECONFIGURATIONSTATES <IMicrosoftGraphDeviceConfigurationState[]>: Device configuration states for this device.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The name of the policy for this policyBase
  - `[PlatformType <PolicyPlatformType?>]`: Supported platform types for policies.
  - `[SettingCount <Int32?>]`: Count of how many setting a policy holds
  - `[SettingStates <IMicrosoftGraphDeviceConfigurationSettingState[]>]`: 
    - `[CurrentValue <String>]`: Current value of setting on device
    - `[ErrorCode <Int64?>]`: Error code for the setting
    - `[ErrorDescription <String>]`: Error description
    - `[InstanceDisplayName <String>]`: Name of setting instance that is being reported.
    - `[Setting <String>]`: The setting that is being reported
    - `[SettingName <String>]`: Localized/user friendly setting name that is being reported
    - `[Sources <IMicrosoftGraphSettingSource[]>]`: Contributing policies
      - `[DisplayName <String>]`: Not yet documented
      - `[Id <String>]`: Not yet documented
      - `[SourceType <String>]`: settingSourceType
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

INPUTOBJECT <IDeviceManagementIdentity>: Identity Parameter
  - `[AdvancedThreatProtectionOnboardingDeviceSettingStateId <String>]`: key: id of advancedThreatProtectionOnboardingDeviceSettingState
  - `[AndroidForWorkAppConfigurationSchemaId <String>]`: key: id of androidForWorkAppConfigurationSchema
  - `[AndroidManagedStoreAppConfigurationSchemaId <String>]`: key: id of androidManagedStoreAppConfigurationSchema
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AssignmentFilterEvaluationStatusDetailsId <String>]`: key: id of assignmentFilterEvaluationStatusDetails
  - `[DataSharingConsentId <String>]`: key: id of dataSharingConsent
  - `[DetectedAppId <String>]`: key: id of detectedApp
  - `[DeviceAndAppManagementAssignmentFilterId <String>]`: key: id of deviceAndAppManagementAssignmentFilter
  - `[DeviceCategoryId <String>]`: key: id of deviceCategory
  - `[DeviceComplianceActionItemId <String>]`: key: id of deviceComplianceActionItem
  - `[DeviceComplianceDeviceStatusId <String>]`: key: id of deviceComplianceDeviceStatus
  - `[DeviceCompliancePolicyAssignmentId <String>]`: key: id of deviceCompliancePolicyAssignment
  - `[DeviceCompliancePolicyId <String>]`: key: id of deviceCompliancePolicy
  - `[DeviceCompliancePolicySettingStateSummaryId <String>]`: key: id of deviceCompliancePolicySettingStateSummary
  - `[DeviceCompliancePolicyStateId <String>]`: key: id of deviceCompliancePolicyState
  - `[DeviceComplianceScheduledActionForRuleId <String>]`: key: id of deviceComplianceScheduledActionForRule
  - `[DeviceComplianceSettingStateId <String>]`: key: id of deviceComplianceSettingState
  - `[DeviceComplianceUserStatusId <String>]`: key: id of deviceComplianceUserStatus
  - `[DeviceConfigurationAssignmentId <String>]`: key: id of deviceConfigurationAssignment
  - `[DeviceConfigurationConflictSummaryId <String>]`: key: id of deviceConfigurationConflictSummary
  - `[DeviceConfigurationDeviceStatusId <String>]`: key: id of deviceConfigurationDeviceStatus
  - `[DeviceConfigurationGroupAssignmentId <String>]`: key: id of deviceConfigurationGroupAssignment
  - `[DeviceConfigurationId <String>]`: key: id of deviceConfiguration
  - `[DeviceConfigurationStateId <String>]`: key: id of deviceConfigurationState
  - `[DeviceConfigurationUserStatusId <String>]`: key: id of deviceConfigurationUserStatus
  - `[DeviceHealthScriptAssignmentId <String>]`: key: id of deviceHealthScriptAssignment
  - `[DeviceHealthScriptDeviceStateId <String>]`: key: id of deviceHealthScriptDeviceState
  - `[DeviceHealthScriptId <String>]`: key: id of deviceHealthScript
  - `[DeviceLogCollectionResponseId <String>]`: key: id of deviceLogCollectionResponse
  - `[DeviceManagementComplianceActionItemId <String>]`: key: id of deviceManagementComplianceActionItem
  - `[DeviceManagementCompliancePolicyId <String>]`: key: id of deviceManagementCompliancePolicy
  - `[DeviceManagementComplianceScheduledActionForRuleId <String>]`: key: id of deviceManagementComplianceScheduledActionForRule
  - `[DeviceManagementConfigurationPolicyAssignmentId <String>]`: key: id of deviceManagementConfigurationPolicyAssignment
  - `[DeviceManagementConfigurationPolicyId <String>]`: key: id of deviceManagementConfigurationPolicy
  - `[DeviceManagementConfigurationPolicyTemplateId <String>]`: key: id of deviceManagementConfigurationPolicyTemplate
  - `[DeviceManagementConfigurationSettingDefinitionId <String>]`: key: id of deviceManagementConfigurationSettingDefinition
  - `[DeviceManagementConfigurationSettingId <String>]`: key: id of deviceManagementConfigurationSetting
  - `[DeviceManagementConfigurationSettingTemplateId <String>]`: key: id of deviceManagementConfigurationSettingTemplate
  - `[DeviceManagementDerivedCredentialSettingsId <String>]`: key: id of deviceManagementDerivedCredentialSettings
  - `[DeviceManagementIntentAssignmentId <String>]`: key: id of deviceManagementIntentAssignment
  - `[DeviceManagementIntentDeviceSettingStateSummaryId <String>]`: key: id of deviceManagementIntentDeviceSettingStateSummary
  - `[DeviceManagementIntentDeviceStateId <String>]`: key: id of deviceManagementIntentDeviceState
  - `[DeviceManagementIntentId <String>]`: key: id of deviceManagementIntent
  - `[DeviceManagementIntentSettingCategoryId <String>]`: key: id of deviceManagementIntentSettingCategory
  - `[DeviceManagementIntentUserStateId <String>]`: key: id of deviceManagementIntentUserState
  - `[DeviceManagementResourceAccessProfileAssignmentId <String>]`: key: id of deviceManagementResourceAccessProfileAssignment
  - `[DeviceManagementResourceAccessProfileBaseId <String>]`: key: id of deviceManagementResourceAccessProfileBase
  - `[DeviceManagementScriptAssignmentId <String>]`: key: id of deviceManagementScriptAssignment
  - `[DeviceManagementScriptDeviceStateId <String>]`: key: id of deviceManagementScriptDeviceState
  - `[DeviceManagementScriptGroupAssignmentId <String>]`: key: id of deviceManagementScriptGroupAssignment
  - `[DeviceManagementScriptId <String>]`: key: id of deviceManagementScript
  - `[DeviceManagementScriptUserStateId <String>]`: key: id of deviceManagementScriptUserState
  - `[DeviceManagementSettingCategoryId <String>]`: key: id of deviceManagementSettingCategory
  - `[DeviceManagementSettingDefinitionId <String>]`: key: id of deviceManagementSettingDefinition
  - `[DeviceManagementSettingInstanceId <String>]`: key: id of deviceManagementSettingInstance
  - `[DeviceManagementTemplateId <String>]`: key: id of deviceManagementTemplate
  - `[DeviceManagementTemplateId1 <String>]`: key: id of deviceManagementTemplate
  - `[DeviceManagementTemplateSettingCategoryId <String>]`: key: id of deviceManagementTemplateSettingCategory
  - `[DeviceManagementTroubleshootingEventId <String>]`: key: id of deviceManagementTroubleshootingEvent
  - `[DeviceShellScriptId <String>]`: key: id of deviceShellScript
  - `[EmbeddedSimActivationCodePoolAssignmentId <String>]`: key: id of embeddedSIMActivationCodePoolAssignment
  - `[EmbeddedSimActivationCodePoolId <String>]`: key: id of embeddedSIMActivationCodePool
  - `[EmbeddedSimDeviceStateId <String>]`: key: id of embeddedSIMDeviceState
  - `[GroupPolicyConfigurationAssignmentId <String>]`: key: id of groupPolicyConfigurationAssignment
  - `[GroupPolicyConfigurationId <String>]`: key: id of groupPolicyConfiguration
  - `[GroupPolicyDefinitionValueId <String>]`: key: id of groupPolicyDefinitionValue
  - `[GroupPolicyPresentationValueId <String>]`: key: id of groupPolicyPresentationValue
  - `[LocalizedNotificationMessageId <String>]`: key: id of localizedNotificationMessage
  - `[MacOSSoftwareUpdateAccountSummaryId <String>]`: key: id of macOSSoftwareUpdateAccountSummary
  - `[MacOSSoftwareUpdateCategorySummaryId <String>]`: key: id of macOSSoftwareUpdateCategorySummary
  - `[MacOSSoftwareUpdateStateSummaryId <String>]`: key: id of macOSSoftwareUpdateStateSummary
  - `[MalwareStateForWindowsDeviceId <String>]`: key: id of malwareStateForWindowsDevice
  - `[ManagedDeviceEncryptionStateId <String>]`: key: id of managedDeviceEncryptionState
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[ManagedDeviceMobileAppConfigurationStateId <String>]`: key: id of managedDeviceMobileAppConfigurationState
  - `[MicrosoftTunnelConfigurationId <String>]`: key: id of microsoftTunnelConfiguration
  - `[MicrosoftTunnelHealthThresholdId <String>]`: key: id of microsoftTunnelHealthThreshold
  - `[MicrosoftTunnelServerId <String>]`: key: id of microsoftTunnelServer
  - `[MicrosoftTunnelServerLogCollectionResponseId <String>]`: key: id of microsoftTunnelServerLogCollectionResponse
  - `[MicrosoftTunnelSiteId <String>]`: key: id of microsoftTunnelSite
  - `[MobileAppTroubleshootingEventId <String>]`: key: id of mobileAppTroubleshootingEvent
  - `[NotificationMessageTemplateId <String>]`: key: id of notificationMessageTemplate
  - `[RemoteActionAuditId <String>]`: key: id of remoteActionAudit
  - `[SecurityBaselineSettingStateId <String>]`: key: id of securityBaselineSettingState
  - `[SecurityBaselineStateId <String>]`: key: id of securityBaselineState
  - `[SettingStateDeviceSummaryId <String>]`: key: id of settingStateDeviceSummary
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetailsId <String>]`: key: id of userExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId <String>]`: key: id of userExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionId <String>]`: key: id of userExperienceAnalyticsAppHealthAppPerformanceByAppVersion
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionId <String>]`: key: id of userExperienceAnalyticsAppHealthAppPerformanceByOSVersion
  - `[UserExperienceAnalyticsAppHealthApplicationPerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthApplicationPerformance
  - `[UserExperienceAnalyticsAppHealthDeviceModelPerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthDeviceModelPerformance
  - `[UserExperienceAnalyticsAppHealthDevicePerformanceDetailsId <String>]`: key: id of userExperienceAnalyticsAppHealthDevicePerformanceDetails
  - `[UserExperienceAnalyticsAppHealthDevicePerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthDevicePerformance
  - `[UserExperienceAnalyticsAppHealthOSVersionPerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthOSVersionPerformance
  - `[UserExperienceAnalyticsBaselineId <String>]`: key: id of userExperienceAnalyticsBaseline
  - `[UserExperienceAnalyticsBatteryHealthAppImpactId <String>]`: key: id of userExperienceAnalyticsBatteryHealthAppImpact
  - `[UserExperienceAnalyticsBatteryHealthDeviceAppImpactId <String>]`: key: id of userExperienceAnalyticsBatteryHealthDeviceAppImpact
  - `[UserExperienceAnalyticsBatteryHealthDevicePerformanceId <String>]`: key: id of userExperienceAnalyticsBatteryHealthDevicePerformance
  - `[UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistoryId <String>]`: key: id of userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory
  - `[UserExperienceAnalyticsBatteryHealthModelPerformanceId <String>]`: key: id of userExperienceAnalyticsBatteryHealthModelPerformance
  - `[UserExperienceAnalyticsBatteryHealthOSPerformanceId <String>]`: key: id of userExperienceAnalyticsBatteryHealthOsPerformance
  - `[UserExperienceAnalyticsCategoryId <String>]`: key: id of userExperienceAnalyticsCategory
  - `[UserExperienceAnalyticsDevicePerformanceId <String>]`: key: id of userExperienceAnalyticsDevicePerformance
  - `[UserExperienceAnalyticsDeviceScopeId <String>]`: key: id of userExperienceAnalyticsDeviceScope
  - `[UserExperienceAnalyticsDeviceScoresId <String>]`: key: id of userExperienceAnalyticsDeviceScores
  - `[UserExperienceAnalyticsDeviceStartupHistoryId <String>]`: key: id of userExperienceAnalyticsDeviceStartupHistory
  - `[UserExperienceAnalyticsDeviceStartupProcessId <String>]`: key: id of userExperienceAnalyticsDeviceStartupProcess
  - `[UserExperienceAnalyticsDeviceStartupProcessPerformanceId <String>]`: key: id of userExperienceAnalyticsDeviceStartupProcessPerformance
  - `[UserExperienceAnalyticsDeviceWithoutCloudIdentityId <String>]`: key: id of userExperienceAnalyticsDeviceWithoutCloudIdentity
  - `[UserExperienceAnalyticsImpactingProcessId <String>]`: key: id of userExperienceAnalyticsImpactingProcess
  - `[UserExperienceAnalyticsMetricHistoryId <String>]`: key: id of userExperienceAnalyticsMetricHistory
  - `[UserExperienceAnalyticsMetricId <String>]`: key: id of userExperienceAnalyticsMetric
  - `[UserExperienceAnalyticsModelScoresId <String>]`: key: id of userExperienceAnalyticsModelScores
  - `[UserExperienceAnalyticsNotAutopilotReadyDeviceId <String>]`: key: id of userExperienceAnalyticsNotAutopilotReadyDevice
  - `[UserExperienceAnalyticsRemoteConnectionId <String>]`: key: id of userExperienceAnalyticsRemoteConnection
  - `[UserExperienceAnalyticsResourcePerformanceId <String>]`: key: id of userExperienceAnalyticsResourcePerformance
  - `[UserExperienceAnalyticsScoreHistoryId <String>]`: key: id of userExperienceAnalyticsScoreHistory
  - `[UserExperienceAnalyticsWorkFromAnywhereDeviceId <String>]`: key: id of userExperienceAnalyticsWorkFromAnywhereDevice
  - `[UserExperienceAnalyticsWorkFromAnywhereMetricId <String>]`: key: id of userExperienceAnalyticsWorkFromAnywhereMetric
  - `[UserExperienceAnalyticsWorkFromAnywhereModelPerformanceId <String>]`: key: id of userExperienceAnalyticsWorkFromAnywhereModelPerformance
  - `[WindowsDeviceMalwareStateId <String>]`: key: id of windowsDeviceMalwareState
  - `[WindowsInformationProtectionAppLearningSummaryId <String>]`: key: id of windowsInformationProtectionAppLearningSummary
  - `[WindowsInformationProtectionNetworkLearningSummaryId <String>]`: key: id of windowsInformationProtectionNetworkLearningSummary
  - `[WindowsMalwareInformationId <String>]`: key: id of windowsMalwareInformation

## RELATED LINKS

