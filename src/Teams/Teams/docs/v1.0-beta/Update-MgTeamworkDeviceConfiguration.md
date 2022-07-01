---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/update-mgteamworkdeviceconfiguration
schema: 2.0.0
---

# Update-MgTeamworkDeviceConfiguration

## SYNOPSIS
Update the navigation property configuration in teamwork

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTeamworkDeviceConfiguration -TeamworkDeviceId <String> [-AdditionalProperties <Hashtable>]
 [-CameraConfiguration <IMicrosoftGraphTeamworkCameraConfiguration>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-DisplayConfiguration <IMicrosoftGraphTeamworkDisplayConfiguration>]
 [-HardwareConfiguration <IMicrosoftGraphTeamworkHardwareConfiguration>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-MicrophoneConfiguration <IMicrosoftGraphTeamworkMicrophoneConfiguration>]
 [-SoftwareVersions <IMicrosoftGraphTeamworkDeviceSoftwareVersions>]
 [-SpeakerConfiguration <IMicrosoftGraphTeamworkSpeakerConfiguration>]
 [-SystemConfiguration <IMicrosoftGraphTeamworkSystemConfiguration>]
 [-TeamsClientConfiguration <IMicrosoftGraphTeamworkTeamsClientConfiguration>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTeamworkDeviceConfiguration -TeamworkDeviceId <String>
 -BodyParameter <IMicrosoftGraphTeamworkDeviceConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTeamworkDeviceConfiguration -InputObject <ITeamsIdentity>
 -BodyParameter <IMicrosoftGraphTeamworkDeviceConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTeamworkDeviceConfiguration -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-CameraConfiguration <IMicrosoftGraphTeamworkCameraConfiguration>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-DisplayConfiguration <IMicrosoftGraphTeamworkDisplayConfiguration>]
 [-HardwareConfiguration <IMicrosoftGraphTeamworkHardwareConfiguration>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-MicrophoneConfiguration <IMicrosoftGraphTeamworkMicrophoneConfiguration>]
 [-SoftwareVersions <IMicrosoftGraphTeamworkDeviceSoftwareVersions>]
 [-SpeakerConfiguration <IMicrosoftGraphTeamworkSpeakerConfiguration>]
 [-SystemConfiguration <IMicrosoftGraphTeamworkSystemConfiguration>]
 [-TeamsClientConfiguration <IMicrosoftGraphTeamworkTeamsClientConfiguration>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property configuration in teamwork

## EXAMPLES

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

### -BodyParameter
teamworkDeviceConfiguration
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkDeviceConfiguration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CameraConfiguration
teamworkCameraConfiguration
To construct, please use Get-Help -Online and see NOTES section for CAMERACONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkCameraConfiguration
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
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The UTC date and time when the device configuration document was created.

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

### -DisplayConfiguration
teamworkDisplayConfiguration
To construct, please use Get-Help -Online and see NOTES section for DISPLAYCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkDisplayConfiguration
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HardwareConfiguration
teamworkHardwareConfiguration
To construct, please use Get-Help -Online and see NOTES section for HARDWARECONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkHardwareConfiguration
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ITeamsIdentity
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
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The UTC date and time when the device configuration was last modified.

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

### -MicrophoneConfiguration
teamworkMicrophoneConfiguration
To construct, please use Get-Help -Online and see NOTES section for MICROPHONECONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkMicrophoneConfiguration
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

### -SoftwareVersions
teamworkDeviceSoftwareVersions
To construct, please use Get-Help -Online and see NOTES section for SOFTWAREVERSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkDeviceSoftwareVersions
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpeakerConfiguration
teamworkSpeakerConfiguration
To construct, please use Get-Help -Online and see NOTES section for SPEAKERCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkSpeakerConfiguration
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemConfiguration
teamworkSystemConfiguration
To construct, please use Get-Help -Online and see NOTES section for SYSTEMCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkSystemConfiguration
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsClientConfiguration
teamworkTeamsClientConfiguration
To construct, please use Get-Help -Online and see NOTES section for TEAMSCLIENTCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkTeamsClientConfiguration
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamworkDeviceId
key: id of teamworkDevice

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkDeviceConfiguration

### Microsoft.Graph.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTeamworkDeviceConfiguration>: teamworkDeviceConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CameraConfiguration <IMicrosoftGraphTeamworkCameraConfiguration>]`: teamworkCameraConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Cameras <IMicrosoftGraphTeamworkPeripheral[]>]`: 
      - `[Id <String>]`: 
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
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
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

CAMERACONFIGURATION <IMicrosoftGraphTeamworkCameraConfiguration>: teamworkCameraConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Cameras <IMicrosoftGraphTeamworkPeripheral[]>]`: 
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: Display name for the peripheral.
    - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
    - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
  - `[ContentCameraConfiguration <IMicrosoftGraphTeamworkContentCameraConfiguration>]`: teamworkContentCameraConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsContentCameraInverted <Boolean?>]`: True if the content camera is inverted.
    - `[IsContentCameraOptional <Boolean?>]`: True if the content camera is optional.
    - `[IsContentEnhancementEnabled <Boolean?>]`: True if the content enhancement is enabled.
  - `[DefaultContentCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

DISPLAYCONFIGURATION <IMicrosoftGraphTeamworkDisplayConfiguration>: teamworkDisplayConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ConfiguredDisplays <IMicrosoftGraphTeamworkConfiguredPeripheral[]>]`: The list of configured displays. Applicable only for Microsoft Teams Rooms devices.
    - `[IsOptional <Boolean?>]`: True if the current peripheral is optional. If set to false, this property is also used as part of the calculation of the health state for the device.
    - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[DisplayName <String>]`: Display name for the peripheral.
      - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
      - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
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

HARDWARECONFIGURATION <IMicrosoftGraphTeamworkHardwareConfiguration>: teamworkHardwareConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Compute <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: Display name for the peripheral.
    - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
    - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
  - `[HdmiIngest <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
  - `[ProcessorModel <String>]`: The CPU model on the device.

INPUTOBJECT <ITeamsIdentity>: Identity Parameter
  - `[AssociatedTeamInfoId <String>]`: key: id of associatedTeamInfo
  - `[ChannelId <String>]`: key: id of channel
  - `[ChatId <String>]`: key: id of chat
  - `[ChatMessageHostedContentId <String>]`: key: id of chatMessageHostedContent
  - `[ChatMessageId <String>]`: key: id of chatMessage
  - `[ChatMessageId1 <String>]`: key: id of chatMessage
  - `[ConversationMemberId <String>]`: key: id of conversationMember
  - `[DeletedTeamId <String>]`: key: id of deletedTeam
  - `[GroupId <String>]`: key: id of group
  - `[OfferShiftRequestId <String>]`: key: id of offerShiftRequest
  - `[OpenShiftChangeRequestId <String>]`: key: id of openShiftChangeRequest
  - `[OpenShiftId <String>]`: key: id of openShift
  - `[PinnedChatMessageInfoId <String>]`: key: id of pinnedChatMessageInfo
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SchedulingGroupId <String>]`: key: id of schedulingGroup
  - `[SharedWithChannelTeamInfoId <String>]`: key: id of sharedWithChannelTeamInfo
  - `[ShiftId <String>]`: key: id of shift
  - `[SwapShiftsChangeRequestId <String>]`: key: id of swapShiftsChangeRequest
  - `[TeamId <String>]`: key: id of team
  - `[TeamsAppDefinitionId <String>]`: key: id of teamsAppDefinition
  - `[TeamsAppId <String>]`: key: id of teamsApp
  - `[TeamsAppInstallationId <String>]`: key: id of teamsAppInstallation
  - `[TeamsAsyncOperationId <String>]`: key: id of teamsAsyncOperation
  - `[TeamsTabId <String>]`: key: id of teamsTab
  - `[TeamworkDeviceId <String>]`: key: id of teamworkDevice
  - `[TeamworkDeviceOperationId <String>]`: key: id of teamworkDeviceOperation
  - `[TeamworkTagId <String>]`: key: id of teamworkTag
  - `[TeamworkTagMemberId <String>]`: key: id of teamworkTagMember
  - `[TimeCardId <String>]`: key: id of timeCard
  - `[TimeOffId <String>]`: key: id of timeOff
  - `[TimeOffReasonId <String>]`: key: id of timeOffReason
  - `[TimeOffRequestId <String>]`: key: id of timeOffRequest
  - `[UserId <String>]`: key: id of user
  - `[UserScopeTeamsAppInstallationId <String>]`: key: id of userScopeTeamsAppInstallation
  - `[WorkforceIntegrationId <String>]`: key: id of workforceIntegration

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

MICROPHONECONFIGURATION <IMicrosoftGraphTeamworkMicrophoneConfiguration>: teamworkMicrophoneConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DefaultMicrophone <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: Display name for the peripheral.
    - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
    - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
  - `[IsMicrophoneOptional <Boolean?>]`: True if the configured microphone is optional. False if the microphone is not optional and the health state of the device should be computed.
  - `[Microphones <IMicrosoftGraphTeamworkPeripheral[]>]`: 

SOFTWAREVERSIONS <IMicrosoftGraphTeamworkDeviceSoftwareVersions>: teamworkDeviceSoftwareVersions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AdminAgentSoftwareVersion <String>]`: The software version for the admin agent running on the device.
  - `[FirmwareSoftwareVersion <String>]`: The software version for the firmware running on the device.
  - `[OperatingSystemSoftwareVersion <String>]`: The software version for the operating system on the device.
  - `[PartnerAgentSoftwareVersion <String>]`: The software version for the partner agent running on the device.
  - `[TeamsClientSoftwareVersion <String>]`: The software version for the Teams client running on the device.

SPEAKERCONFIGURATION <IMicrosoftGraphTeamworkSpeakerConfiguration>: teamworkSpeakerConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DefaultCommunicationSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: Display name for the peripheral.
    - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
    - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
  - `[DefaultSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
  - `[IsCommunicationSpeakerOptional <Boolean?>]`: True if the communication speaker is optional. Used to compute the health state if the communication speaker is not optional.
  - `[IsSpeakerOptional <Boolean?>]`: True if the configured speaker is optional. Used to compute the health state if the speaker is not optional.
  - `[Speakers <IMicrosoftGraphTeamworkPeripheral[]>]`: 

SYSTEMCONFIGURATION <IMicrosoftGraphTeamworkSystemConfiguration>: teamworkSystemConfiguration
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

TEAMSCLIENTCONFIGURATION <IMicrosoftGraphTeamworkTeamsClientConfiguration>: teamworkTeamsClientConfiguration
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

## RELATED LINKS

