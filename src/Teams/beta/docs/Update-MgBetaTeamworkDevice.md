---
external help file:
Module Name: Microsoft.Graph.Beta.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.teams/update-mgbetateamworkdevice
schema: 2.0.0
---

# Update-MgBetaTeamworkDevice

## SYNOPSIS
Update the navigation property devices in teamwork

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTeamworkDevice -TeamworkDeviceId <String> [-Activity <IMicrosoftGraphTeamworkDeviceActivity>]
 [-ActivityState <String>] [-AdditionalProperties <Hashtable>] [-CompanyAssetTag <String>]
 [-Configuration <IMicrosoftGraphTeamworkDeviceConfiguration>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-CurrentUser <IMicrosoftGraphTeamworkUserIdentity>] [-DeviceType <String>]
 [-HardwareDetail <IMicrosoftGraphTeamworkHardwareDetail>] [-Health <IMicrosoftGraphTeamworkDeviceHealth>]
 [-HealthStatus <String>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Notes <String>] [-Operations <IMicrosoftGraphTeamworkDeviceOperation[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaTeamworkDevice -TeamworkDeviceId <String> -BodyParameter <IMicrosoftGraphTeamworkDevice>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaTeamworkDevice -InputObject <ITeamsIdentity> -BodyParameter <IMicrosoftGraphTeamworkDevice>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaTeamworkDevice -InputObject <ITeamsIdentity> [-Activity <IMicrosoftGraphTeamworkDeviceActivity>]
 [-ActivityState <String>] [-AdditionalProperties <Hashtable>] [-CompanyAssetTag <String>]
 [-Configuration <IMicrosoftGraphTeamworkDeviceConfiguration>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-CurrentUser <IMicrosoftGraphTeamworkUserIdentity>] [-DeviceType <String>]
 [-HardwareDetail <IMicrosoftGraphTeamworkHardwareDetail>] [-Health <IMicrosoftGraphTeamworkDeviceHealth>]
 [-HealthStatus <String>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Notes <String>] [-Operations <IMicrosoftGraphTeamworkDeviceOperation[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property devices in teamwork

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -Activity
teamworkDeviceActivity
To construct, see NOTES section for ACTIVITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkDeviceActivity
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivityState
teamworkDeviceActivityState

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

### -BodyParameter
teamworkDevice
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkDevice
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyAssetTag
The company asset tag assigned by the admin on the device.

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

### -Configuration
teamworkDeviceConfiguration
To construct, see NOTES section for CONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkDeviceConfiguration
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The UTC date and time when the device was enrolled to the tenant.

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

### -CurrentUser
teamworkUserIdentity
To construct, see NOTES section for CURRENTUSER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkUserIdentity
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceType
teamworkDeviceType

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

### -HardwareDetail
teamworkHardwareDetail
To construct, see NOTES section for HARDWAREDETAIL properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkHardwareDetail
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Health
teamworkDeviceHealth
To construct, see NOTES section for HEALTH properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkDeviceHealth
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HealthStatus
teamworkDeviceHealthStatus

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
Type: Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The UTC date and time when the device detail was last modified.

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

### -Notes
The notes added by the admin to the device.

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

### -Operations
The async operations on the device.
To construct, see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkDeviceOperation[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamworkDeviceId
The unique identifier of teamworkDevice

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkDevice

### Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamworkDevice

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACTIVITY <IMicrosoftGraphTeamworkDeviceActivity>`: teamworkDeviceActivity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActivePeripherals <IMicrosoftGraphTeamworkActivePeripherals>]`: teamworkActivePeripherals
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CommunicationSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DisplayName <String>]`: Display name for the peripheral.
      - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
      - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
    - `[ContentCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[Microphone <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[RoomCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[Speaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The UTC date and time when the device activity document was created.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The UTC date and time when the device activity detail was last modified.

`BODYPARAMETER <IMicrosoftGraphTeamworkDevice>`: teamworkDevice
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Activity <IMicrosoftGraphTeamworkDeviceActivity>]`: teamworkDeviceActivity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ActivePeripherals <IMicrosoftGraphTeamworkActivePeripherals>]`: teamworkActivePeripherals
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CommunicationSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[DisplayName <String>]`: Display name for the peripheral.
        - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
        - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
      - `[ContentCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[Microphone <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[RoomCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[Speaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: The UTC date and time when the device activity document was created.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The UTC date and time when the device activity detail was last modified.
  - `[ActivityState <String>]`: teamworkDeviceActivityState
  - `[CompanyAssetTag <String>]`: The company asset tag assigned by the admin on the device.
  - `[Configuration <IMicrosoftGraphTeamworkDeviceConfiguration>]`: teamworkDeviceConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CameraConfiguration <IMicrosoftGraphTeamworkCameraConfiguration>]`: teamworkCameraConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Cameras <IMicrosoftGraphTeamworkPeripheral[]>]`: 
      - `[ContentCameraConfiguration <IMicrosoftGraphTeamworkContentCameraConfiguration>]`: teamworkContentCameraConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[IsContentCameraInverted <Boolean?>]`: True if the content camera is inverted.
        - `[IsContentCameraOptional <Boolean?>]`: True if the content camera is optional.
        - `[IsContentEnhancementEnabled <Boolean?>]`: True if the content enhancement is enabled.
      - `[DefaultContentCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The UTC date and time when the device configuration document was created.
    - `[DisplayConfiguration <IMicrosoftGraphTeamworkDisplayConfiguration>]`: teamworkDisplayConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConfiguredDisplays <IMicrosoftGraphTeamworkConfiguredPeripheral[]>]`: The list of configured displays. Applicable only for Microsoft Teams Rooms devices.
        - `[IsOptional <Boolean?>]`: True if the current peripheral is optional. If set to false, this property is also used as part of the calculation of the health state for the device.
        - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[DisplayCount <Int32?>]`: Total number of connected displays, including the inbuilt display. Applicable only for Teams Rooms devices.
      - `[InBuiltDisplayScreenConfiguration <IMicrosoftGraphTeamworkDisplayScreenConfiguration>]`: teamworkDisplayScreenConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[BacklightBrightness <Int32?>]`: The brightness level on the device (0-100). Not applicable for Microsoft Teams Rooms devices.
        - `[BacklightTimeout <TimeSpan?>]`: Timeout for backlight (30-3600 secs). Not applicable for Teams Rooms devices.
        - `[IsHighContrastEnabled <Boolean?>]`: True if high contrast mode is enabled. Not applicable for Teams Rooms devices.
        - `[IsScreensaverEnabled <Boolean?>]`: True if screensaver is enabled. Not applicable for Teams Rooms devices.
        - `[ScreensaverTimeout <TimeSpan?>]`: Screensaver timeout from 30 to 3600 secs. Not applicable for Teams Rooms devices.
      - `[IsContentDuplicationAllowed <Boolean?>]`: True if content duplication is allowed. Applicable only for Teams Rooms devices.
      - `[IsDualDisplayModeEnabled <Boolean?>]`: True if dual display mode is enabled. If isDualDisplayModeEnabled is true, then the content will be displayed on both front of room screens instead of just the one screen, when it is shared via the HDMI ingest module on the Microsoft Teams Rooms device. Applicable only for Teams Rooms devices.
    - `[HardwareConfiguration <IMicrosoftGraphTeamworkHardwareConfiguration>]`: teamworkHardwareConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Compute <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[HdmiIngest <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[ProcessorModel <String>]`: The CPU model on the device.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The UTC date and time when the device configuration was last modified.
    - `[MicrophoneConfiguration <IMicrosoftGraphTeamworkMicrophoneConfiguration>]`: teamworkMicrophoneConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DefaultMicrophone <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[IsMicrophoneOptional <Boolean?>]`: True if the configured microphone is optional. False if the microphone is not optional and the health state of the device should be computed.
      - `[Microphones <IMicrosoftGraphTeamworkPeripheral[]>]`: 
    - `[SoftwareVersions <IMicrosoftGraphTeamworkDeviceSoftwareVersions>]`: teamworkDeviceSoftwareVersions
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AdminAgentSoftwareVersion <String>]`: The software version for the admin agent running on the device.
      - `[FirmwareSoftwareVersion <String>]`: The software version for the firmware running on the device.
      - `[OperatingSystemSoftwareVersion <String>]`: The software version for the operating system on the device.
      - `[PartnerAgentSoftwareVersion <String>]`: The software version for the partner agent running on the device.
      - `[TeamsClientSoftwareVersion <String>]`: The software version for the Teams client running on the device.
    - `[SpeakerConfiguration <IMicrosoftGraphTeamworkSpeakerConfiguration>]`: teamworkSpeakerConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DefaultCommunicationSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[DefaultSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[IsCommunicationSpeakerOptional <Boolean?>]`: True if the communication speaker is optional. Used to compute the health state if the communication speaker is not optional.
      - `[IsSpeakerOptional <Boolean?>]`: True if the configured speaker is optional. Used to compute the health state if the speaker is not optional.
      - `[Speakers <IMicrosoftGraphTeamworkPeripheral[]>]`: 
    - `[SystemConfiguration <IMicrosoftGraphTeamworkSystemConfiguration>]`: teamworkSystemConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTimeConfiguration <IMicrosoftGraphTeamworkDateTimeConfiguration>]`: teamworkDateTimeConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DateFormat <String>]`: The date format for the device.
        - `[OfficeHoursEndTime <String>]`: The time of the day when the device is turned off.
        - `[OfficeHoursStartTime <String>]`: The time of the day when the device is turned on.
        - `[TimeFormat <String>]`: The time format for the device.
        - `[TimeZone <String>]`: The time zone to which the office hours apply.
      - `[DefaultPassword <String>]`: The default password for the device. Write-Only.
      - `[DeviceLockTimeout <TimeSpan?>]`: The device lock timeout in seconds.
      - `[IsDeviceLockEnabled <Boolean?>]`: True if the device lock is enabled.
      - `[IsLoggingEnabled <Boolean?>]`: True if logging is enabled.
      - `[IsPowerSavingEnabled <Boolean?>]`: True if power saving is enabled.
      - `[IsScreenCaptureEnabled <Boolean?>]`: True if screen capture is enabled.
      - `[IsSilentModeEnabled <Boolean?>]`: True if silent mode is enabled.
      - `[Language <String>]`: The language option for the device.
      - `[LockPin <String>]`: The pin that unlocks the device. Write-Only.
      - `[LoggingLevel <String>]`: The logging level for the device.
      - `[NetworkConfiguration <IMicrosoftGraphTeamworkNetworkConfiguration>]`: teamworkNetworkConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DefaultGateway <String>]`: The default gateway is the path used to pass information when the destination is unknown to the device.
        - `[DomainName <String>]`: The network domain of the device, for example, contoso.com.
        - `[HostName <String>]`: The device name on a network.
        - `[IPAddress <String>]`: The IP address is a numerical label that uniquely identifies every device connected to the internet.
        - `[IsDhcpEnabled <Boolean?>]`: True if DHCP is enabled.
        - `[IsPcPortEnabled <Boolean?>]`: True if the PC port is enabled.
        - `[PrimaryDns <String>]`: A primary DNS is the first point of contact for a device that translates the hostname into an IP address.
        - `[SecondaryDns <String>]`: A secondary DNS is used when the primary DNS is not available.
        - `[SubnetMask <String>]`: A subnet mask is a number that distinguishes the network address and the host address within an IP address.
    - `[TeamsClientConfiguration <IMicrosoftGraphTeamworkTeamsClientConfiguration>]`: teamworkTeamsClientConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccountConfiguration <IMicrosoftGraphTeamworkAccountConfiguration>]`: teamworkAccountConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[OnPremisesCalendarSyncConfiguration <IMicrosoftGraphTeamworkOnPremisesCalendarSyncConfiguration>]`: teamworkOnPremisesCalendarSyncConfiguration
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Domain <String>]`: The fully qualified domain name (FQDN) of the Skype for Business Server. Use the Exchange domain if the Skype for Business SIP domain is different from the Exchange domain of the user.
          - `[DomainUserName <String>]`: The domain and username of the console device, for example, Seattle/RanierConf.
          - `[SmtpAddress <String>]`: The Simple Mail Transfer Protocol (SMTP) address of the user account. This is only required if a different user principal name (UPN) is used to sign in to Exchange other than Microsoft Teams and Skype for Business. This is a common scenario in a hybrid environment where an on-premises Exchange server is used.
        - `[SupportedClient <String>]`: teamworkSupportedClient
      - `[FeaturesConfiguration <IMicrosoftGraphTeamworkFeaturesConfiguration>]`: teamworkFeaturesConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[EmailToSendLogsAndFeedback <String>]`: Email address to send logs and feedback.
        - `[IsAutoScreenShareEnabled <Boolean?>]`: True if auto screen shared is enabled.
        - `[IsBluetoothBeaconingEnabled <Boolean?>]`: True if Bluetooth beaconing is enabled.
        - `[IsHideMeetingNamesEnabled <Boolean?>]`: True if hiding meeting names is enabled.
        - `[IsSendLogsAndFeedbackEnabled <Boolean?>]`: True if sending logs and feedback is enabled.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: The UTC date and time when the device was enrolled to the tenant.
  - `[CurrentUser <IMicrosoftGraphTeamworkUserIdentity>]`: teamworkUserIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[UserIdentityType <String>]`: teamworkUserIdentityType
  - `[DeviceType <String>]`: teamworkDeviceType
  - `[HardwareDetail <IMicrosoftGraphTeamworkHardwareDetail>]`: teamworkHardwareDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MacAddresses <String[]>]`: MAC address.
    - `[Manufacturer <String>]`: Device manufacturer.
    - `[Model <String>]`: Devie model.
    - `[SerialNumber <String>]`: Device serial number.
    - `[UniqueId <String>]`: The unique identifier for the device.
  - `[Health <IMicrosoftGraphTeamworkDeviceHealth>]`: teamworkDeviceHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConnectionStatus <String>]`: teamworkConnectionStatus
      - `[LastModifiedDateTime <DateTime?>]`: Time at which the state was last changed. For example, indicates connected since when the state is connected and disconnected since when the state is disconnected.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The UTC date and time when the device health document was created.
    - `[HardwareHealth <IMicrosoftGraphTeamworkHardwareHealth>]`: teamworkHardwareHealth
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ComputeHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
        - `[IsOptional <Boolean?>]`: True if the peripheral is optional. Used for health computation.
        - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[HdmiIngestHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The UTC date and time when the device health detail was last modified.
    - `[LoginStatus <IMicrosoftGraphTeamworkLoginStatus>]`: teamworkLoginStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExchangeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[SkypeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[TeamsConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
    - `[PeripheralsHealth <IMicrosoftGraphTeamworkPeripheralsHealth>]`: teamworkPeripheralsHealth
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CommunicationSpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[ContentCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[DisplayHealthCollection <IMicrosoftGraphTeamworkPeripheralHealth[]>]`: The health details about displays.
      - `[MicrophoneHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[RoomCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[SpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[SoftwareUpdateHealth <IMicrosoftGraphTeamworkSoftwareUpdateHealth>]`: teamworkSoftwareUpdateHealth
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AdminAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AvailableVersion <String>]`: The available software version to update.
        - `[CurrentVersion <String>]`: The current software version.
        - `[SoftwareFreshness <String>]`: teamworkSoftwareFreshness
      - `[CompanyPortalSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
      - `[FirmwareSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
      - `[OperatingSystemSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
      - `[PartnerAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
      - `[TeamsClientSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
  - `[HealthStatus <String>]`: teamworkDeviceHealthStatus
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The UTC date and time when the device detail was last modified.
  - `[Notes <String>]`: The notes added by the admin to the device.
  - `[Operations <IMicrosoftGraphTeamworkDeviceOperation[]>]`: The async operations on the device.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CompletedDateTime <DateTime?>]`: Time at which the operation reached a final state (for example, Successful, Failed, and Cancelled).
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The UTC date and time when the device operation was created.
    - `[Error <IMicrosoftGraphOperationError>]`: operationError
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: Operation error code.
      - `[Message <String>]`: Operation error message.
    - `[LastActionBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastActionDateTime <DateTime?>]`: The UTC date and time when the device operation was last modified.
    - `[OperationType <String>]`: teamworkDeviceOperationType
    - `[StartedDateTime <DateTime?>]`: Time at which the operation was started.
    - `[Status <String>]`: The current status of the async operation, for example, Queued, Scheduled, InProgress,  Successful, Cancelled, and Failed.

`CONFIGURATION <IMicrosoftGraphTeamworkDeviceConfiguration>`: teamworkDeviceConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CameraConfiguration <IMicrosoftGraphTeamworkCameraConfiguration>]`: teamworkCameraConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Cameras <IMicrosoftGraphTeamworkPeripheral[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DisplayName <String>]`: Display name for the peripheral.
      - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
      - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
    - `[ContentCameraConfiguration <IMicrosoftGraphTeamworkContentCameraConfiguration>]`: teamworkContentCameraConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsContentCameraInverted <Boolean?>]`: True if the content camera is inverted.
      - `[IsContentCameraOptional <Boolean?>]`: True if the content camera is optional.
      - `[IsContentEnhancementEnabled <Boolean?>]`: True if the content enhancement is enabled.
    - `[DefaultContentCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The UTC date and time when the device configuration document was created.
  - `[DisplayConfiguration <IMicrosoftGraphTeamworkDisplayConfiguration>]`: teamworkDisplayConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfiguredDisplays <IMicrosoftGraphTeamworkConfiguredPeripheral[]>]`: The list of configured displays. Applicable only for Microsoft Teams Rooms devices.
      - `[IsOptional <Boolean?>]`: True if the current peripheral is optional. If set to false, this property is also used as part of the calculation of the health state for the device.
      - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[DisplayCount <Int32?>]`: Total number of connected displays, including the inbuilt display. Applicable only for Teams Rooms devices.
    - `[InBuiltDisplayScreenConfiguration <IMicrosoftGraphTeamworkDisplayScreenConfiguration>]`: teamworkDisplayScreenConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BacklightBrightness <Int32?>]`: The brightness level on the device (0-100). Not applicable for Microsoft Teams Rooms devices.
      - `[BacklightTimeout <TimeSpan?>]`: Timeout for backlight (30-3600 secs). Not applicable for Teams Rooms devices.
      - `[IsHighContrastEnabled <Boolean?>]`: True if high contrast mode is enabled. Not applicable for Teams Rooms devices.
      - `[IsScreensaverEnabled <Boolean?>]`: True if screensaver is enabled. Not applicable for Teams Rooms devices.
      - `[ScreensaverTimeout <TimeSpan?>]`: Screensaver timeout from 30 to 3600 secs. Not applicable for Teams Rooms devices.
    - `[IsContentDuplicationAllowed <Boolean?>]`: True if content duplication is allowed. Applicable only for Teams Rooms devices.
    - `[IsDualDisplayModeEnabled <Boolean?>]`: True if dual display mode is enabled. If isDualDisplayModeEnabled is true, then the content will be displayed on both front of room screens instead of just the one screen, when it is shared via the HDMI ingest module on the Microsoft Teams Rooms device. Applicable only for Teams Rooms devices.
  - `[HardwareConfiguration <IMicrosoftGraphTeamworkHardwareConfiguration>]`: teamworkHardwareConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Compute <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[HdmiIngest <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[ProcessorModel <String>]`: The CPU model on the device.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The UTC date and time when the device configuration was last modified.
  - `[MicrophoneConfiguration <IMicrosoftGraphTeamworkMicrophoneConfiguration>]`: teamworkMicrophoneConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DefaultMicrophone <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[IsMicrophoneOptional <Boolean?>]`: True if the configured microphone is optional. False if the microphone is not optional and the health state of the device should be computed.
    - `[Microphones <IMicrosoftGraphTeamworkPeripheral[]>]`: 
  - `[SoftwareVersions <IMicrosoftGraphTeamworkDeviceSoftwareVersions>]`: teamworkDeviceSoftwareVersions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AdminAgentSoftwareVersion <String>]`: The software version for the admin agent running on the device.
    - `[FirmwareSoftwareVersion <String>]`: The software version for the firmware running on the device.
    - `[OperatingSystemSoftwareVersion <String>]`: The software version for the operating system on the device.
    - `[PartnerAgentSoftwareVersion <String>]`: The software version for the partner agent running on the device.
    - `[TeamsClientSoftwareVersion <String>]`: The software version for the Teams client running on the device.
  - `[SpeakerConfiguration <IMicrosoftGraphTeamworkSpeakerConfiguration>]`: teamworkSpeakerConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DefaultCommunicationSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[DefaultSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[IsCommunicationSpeakerOptional <Boolean?>]`: True if the communication speaker is optional. Used to compute the health state if the communication speaker is not optional.
    - `[IsSpeakerOptional <Boolean?>]`: True if the configured speaker is optional. Used to compute the health state if the speaker is not optional.
    - `[Speakers <IMicrosoftGraphTeamworkPeripheral[]>]`: 
  - `[SystemConfiguration <IMicrosoftGraphTeamworkSystemConfiguration>]`: teamworkSystemConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DateTimeConfiguration <IMicrosoftGraphTeamworkDateTimeConfiguration>]`: teamworkDateTimeConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateFormat <String>]`: The date format for the device.
      - `[OfficeHoursEndTime <String>]`: The time of the day when the device is turned off.
      - `[OfficeHoursStartTime <String>]`: The time of the day when the device is turned on.
      - `[TimeFormat <String>]`: The time format for the device.
      - `[TimeZone <String>]`: The time zone to which the office hours apply.
    - `[DefaultPassword <String>]`: The default password for the device. Write-Only.
    - `[DeviceLockTimeout <TimeSpan?>]`: The device lock timeout in seconds.
    - `[IsDeviceLockEnabled <Boolean?>]`: True if the device lock is enabled.
    - `[IsLoggingEnabled <Boolean?>]`: True if logging is enabled.
    - `[IsPowerSavingEnabled <Boolean?>]`: True if power saving is enabled.
    - `[IsScreenCaptureEnabled <Boolean?>]`: True if screen capture is enabled.
    - `[IsSilentModeEnabled <Boolean?>]`: True if silent mode is enabled.
    - `[Language <String>]`: The language option for the device.
    - `[LockPin <String>]`: The pin that unlocks the device. Write-Only.
    - `[LoggingLevel <String>]`: The logging level for the device.
    - `[NetworkConfiguration <IMicrosoftGraphTeamworkNetworkConfiguration>]`: teamworkNetworkConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DefaultGateway <String>]`: The default gateway is the path used to pass information when the destination is unknown to the device.
      - `[DomainName <String>]`: The network domain of the device, for example, contoso.com.
      - `[HostName <String>]`: The device name on a network.
      - `[IPAddress <String>]`: The IP address is a numerical label that uniquely identifies every device connected to the internet.
      - `[IsDhcpEnabled <Boolean?>]`: True if DHCP is enabled.
      - `[IsPcPortEnabled <Boolean?>]`: True if the PC port is enabled.
      - `[PrimaryDns <String>]`: A primary DNS is the first point of contact for a device that translates the hostname into an IP address.
      - `[SecondaryDns <String>]`: A secondary DNS is used when the primary DNS is not available.
      - `[SubnetMask <String>]`: A subnet mask is a number that distinguishes the network address and the host address within an IP address.
  - `[TeamsClientConfiguration <IMicrosoftGraphTeamworkTeamsClientConfiguration>]`: teamworkTeamsClientConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccountConfiguration <IMicrosoftGraphTeamworkAccountConfiguration>]`: teamworkAccountConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[OnPremisesCalendarSyncConfiguration <IMicrosoftGraphTeamworkOnPremisesCalendarSyncConfiguration>]`: teamworkOnPremisesCalendarSyncConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Domain <String>]`: The fully qualified domain name (FQDN) of the Skype for Business Server. Use the Exchange domain if the Skype for Business SIP domain is different from the Exchange domain of the user.
        - `[DomainUserName <String>]`: The domain and username of the console device, for example, Seattle/RanierConf.
        - `[SmtpAddress <String>]`: The Simple Mail Transfer Protocol (SMTP) address of the user account. This is only required if a different user principal name (UPN) is used to sign in to Exchange other than Microsoft Teams and Skype for Business. This is a common scenario in a hybrid environment where an on-premises Exchange server is used.
      - `[SupportedClient <String>]`: teamworkSupportedClient
    - `[FeaturesConfiguration <IMicrosoftGraphTeamworkFeaturesConfiguration>]`: teamworkFeaturesConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EmailToSendLogsAndFeedback <String>]`: Email address to send logs and feedback.
      - `[IsAutoScreenShareEnabled <Boolean?>]`: True if auto screen shared is enabled.
      - `[IsBluetoothBeaconingEnabled <Boolean?>]`: True if Bluetooth beaconing is enabled.
      - `[IsHideMeetingNamesEnabled <Boolean?>]`: True if hiding meeting names is enabled.
      - `[IsSendLogsAndFeedbackEnabled <Boolean?>]`: True if sending logs and feedback is enabled.

`CREATEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`CURRENTUSER <IMicrosoftGraphTeamworkUserIdentity>`: teamworkUserIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
  - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[UserIdentityType <String>]`: teamworkUserIdentityType

`HARDWAREDETAIL <IMicrosoftGraphTeamworkHardwareDetail>`: teamworkHardwareDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MacAddresses <String[]>]`: MAC address.
  - `[Manufacturer <String>]`: Device manufacturer.
  - `[Model <String>]`: Devie model.
  - `[SerialNumber <String>]`: Device serial number.
  - `[UniqueId <String>]`: The unique identifier for the device.

`HEALTH <IMicrosoftGraphTeamworkDeviceHealth>`: teamworkDeviceHealth
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConnectionStatus <String>]`: teamworkConnectionStatus
    - `[LastModifiedDateTime <DateTime?>]`: Time at which the state was last changed. For example, indicates connected since when the state is connected and disconnected since when the state is disconnected.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The UTC date and time when the device health document was created.
  - `[HardwareHealth <IMicrosoftGraphTeamworkHardwareHealth>]`: teamworkHardwareHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ComputeHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[IsOptional <Boolean?>]`: True if the peripheral is optional. Used for health computation.
      - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[DisplayName <String>]`: Display name for the peripheral.
        - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
        - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
    - `[HdmiIngestHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The UTC date and time when the device health detail was last modified.
  - `[LoginStatus <IMicrosoftGraphTeamworkLoginStatus>]`: teamworkLoginStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExchangeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
    - `[SkypeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
    - `[TeamsConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
  - `[PeripheralsHealth <IMicrosoftGraphTeamworkPeripheralsHealth>]`: teamworkPeripheralsHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CommunicationSpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[ContentCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[DisplayHealthCollection <IMicrosoftGraphTeamworkPeripheralHealth[]>]`: The health details about displays.
    - `[MicrophoneHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[RoomCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[SpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
  - `[SoftwareUpdateHealth <IMicrosoftGraphTeamworkSoftwareUpdateHealth>]`: teamworkSoftwareUpdateHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AdminAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AvailableVersion <String>]`: The available software version to update.
      - `[CurrentVersion <String>]`: The current software version.
      - `[SoftwareFreshness <String>]`: teamworkSoftwareFreshness
    - `[CompanyPortalSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
    - `[FirmwareSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
    - `[OperatingSystemSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
    - `[PartnerAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
    - `[TeamsClientSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus

`INPUTOBJECT <ITeamsIdentity>`: Identity Parameter
  - `[AssociatedTeamInfoId <String>]`: The unique identifier of associatedTeamInfo
  - `[ChannelId <String>]`: The unique identifier of channel
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageHostedContentId <String>]`: The unique identifier of chatMessageHostedContent
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[ChatMessageId1 <String>]`: The unique identifier of chatMessage
  - `[ConversationMemberId <String>]`: The unique identifier of conversationMember
  - `[DayNoteId <String>]`: The unique identifier of dayNote
  - `[DeletedChatId <String>]`: The unique identifier of deletedChat
  - `[DeletedTeamId <String>]`: The unique identifier of deletedTeam
  - `[GroupId <String>]`: The unique identifier of group
  - `[OfferShiftRequestId <String>]`: The unique identifier of offerShiftRequest
  - `[OpenShiftChangeRequestId <String>]`: The unique identifier of openShiftChangeRequest
  - `[OpenShiftId <String>]`: The unique identifier of openShift
  - `[PinnedChatMessageInfoId <String>]`: The unique identifier of pinnedChatMessageInfo
  - `[ResourceSpecificPermissionGrantId <String>]`: The unique identifier of resourceSpecificPermissionGrant
  - `[SchedulingGroupId <String>]`: The unique identifier of schedulingGroup
  - `[SharedWithChannelTeamInfoId <String>]`: The unique identifier of sharedWithChannelTeamInfo
  - `[ShiftId <String>]`: The unique identifier of shift
  - `[SwapShiftsChangeRequestId <String>]`: The unique identifier of swapShiftsChangeRequest
  - `[TeamId <String>]`: The unique identifier of team
  - `[TeamTemplateDefinitionId <String>]`: The unique identifier of teamTemplateDefinition
  - `[TeamTemplateId <String>]`: The unique identifier of teamTemplate
  - `[TeamsAppDefinitionId <String>]`: The unique identifier of teamsAppDefinition
  - `[TeamsAppId <String>]`: The unique identifier of teamsApp
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TeamsAsyncOperationId <String>]`: The unique identifier of teamsAsyncOperation
  - `[TeamsTabId <String>]`: The unique identifier of teamsTab
  - `[TeamworkDeviceId <String>]`: The unique identifier of teamworkDevice
  - `[TeamworkDeviceOperationId <String>]`: The unique identifier of teamworkDeviceOperation
  - `[TeamworkTagId <String>]`: The unique identifier of teamworkTag
  - `[TeamworkTagMemberId <String>]`: The unique identifier of teamworkTagMember
  - `[TimeCardId <String>]`: The unique identifier of timeCard
  - `[TimeOffId <String>]`: The unique identifier of timeOff
  - `[TimeOffReasonId <String>]`: The unique identifier of timeOffReason
  - `[TimeOffRequestId <String>]`: The unique identifier of timeOffRequest
  - `[UserId <String>]`: The unique identifier of user
  - `[UserScopeTeamsAppInstallationId <String>]`: The unique identifier of userScopeTeamsAppInstallation
  - `[WorkforceIntegrationId <String>]`: The unique identifier of workforceIntegration

`LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`OPERATIONS <IMicrosoftGraphTeamworkDeviceOperation[]>`: The async operations on the device.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CompletedDateTime <DateTime?>]`: Time at which the operation reached a final state (for example, Successful, Failed, and Cancelled).
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The UTC date and time when the device operation was created.
  - `[Error <IMicrosoftGraphOperationError>]`: operationError
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <String>]`: Operation error code.
    - `[Message <String>]`: Operation error message.
  - `[LastActionBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastActionDateTime <DateTime?>]`: The UTC date and time when the device operation was last modified.
  - `[OperationType <String>]`: teamworkDeviceOperationType
  - `[StartedDateTime <DateTime?>]`: Time at which the operation was started.
  - `[Status <String>]`: The current status of the async operation, for example, Queued, Scheduled, InProgress,  Successful, Cancelled, and Failed.

## RELATED LINKS

