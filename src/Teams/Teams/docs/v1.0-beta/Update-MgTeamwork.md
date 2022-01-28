---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/update-mgteamwork
schema: 2.0.0
---

# Update-MgTeamwork

## SYNOPSIS
Update teamwork

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTeamwork [-AdditionalProperties <Hashtable>] [-Devices <IMicrosoftGraphTeamworkDevice[]>]
 [-Id <String>] [-WorkforceIntegrations <IMicrosoftGraphWorkforceIntegration[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTeamwork -BodyParameter <IMicrosoftGraphTeamwork> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update teamwork

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

### -BodyParameter
teamwork
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamwork
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Devices
.
To construct, please use Get-Help -Online and see NOTES section for DEVICES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkDevice[]
Parameter Sets: UpdateExpanded
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

### -WorkforceIntegrations
.
To construct, please use Get-Help -Online and see NOTES section for WORKFORCEINTEGRATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWorkforceIntegration[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamwork

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTeamwork>: teamwork
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Devices <IMicrosoftGraphTeamworkDevice[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Activity <IMicrosoftGraphTeamworkDeviceActivity>]`: teamworkDeviceActivity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[ActivePeripherals <IMicrosoftGraphTeamworkActivePeripherals>]`: teamworkActivePeripherals
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CommunicationSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[DisplayName <String>]`: 
          - `[ProductId <String>]`: 
          - `[VendorId <String>]`: 
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
      - `[CreatedDateTime <DateTime?>]`: 
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ActivityState <String>]`: teamworkDeviceActivityState
    - `[CompanyAssetTag <String>]`: 
    - `[Configuration <IMicrosoftGraphTeamworkDeviceConfiguration>]`: teamworkDeviceConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[CameraConfiguration <IMicrosoftGraphTeamworkCameraConfiguration>]`: teamworkCameraConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Cameras <IMicrosoftGraphTeamworkPeripheral[]>]`: 
        - `[ContentCameraConfiguration <IMicrosoftGraphTeamworkContentCameraConfiguration>]`: teamworkContentCameraConfiguration
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[IsContentCameraInverted <Boolean?>]`: 
          - `[IsContentCameraOptional <Boolean?>]`: 
          - `[IsContentEnhancementEnabled <Boolean?>]`: 
        - `[DefaultContentCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: 
      - `[DisplayConfiguration <IMicrosoftGraphTeamworkDisplayConfiguration>]`: teamworkDisplayConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ConfiguredDisplays <IMicrosoftGraphTeamworkConfiguredPeripheral[]>]`: 
          - `[IsOptional <Boolean?>]`: 
          - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[DisplayCount <Int32?>]`: 
        - `[InBuiltDisplayScreenConfiguration <IMicrosoftGraphTeamworkDisplayScreenConfiguration>]`: teamworkDisplayScreenConfiguration
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[BacklightBrightness <Int32?>]`: 
          - `[BacklightTimeout <TimeSpan?>]`: 
          - `[IsHighContrastEnabled <Boolean?>]`: 
          - `[IsScreensaverEnabled <Boolean?>]`: 
          - `[ScreensaverTimeout <TimeSpan?>]`: 
        - `[IsContentDuplicationAllowed <Boolean?>]`: 
        - `[IsDualDisplayModeEnabled <Boolean?>]`: 
      - `[HardwareConfiguration <IMicrosoftGraphTeamworkHardwareConfiguration>]`: teamworkHardwareConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Compute <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[HdmiIngest <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[ProcessorModel <String>]`: 
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[MicrophoneConfiguration <IMicrosoftGraphTeamworkMicrophoneConfiguration>]`: teamworkMicrophoneConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DefaultMicrophone <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[IsMicrophoneOptional <Boolean?>]`: 
        - `[Microphones <IMicrosoftGraphTeamworkPeripheral[]>]`: 
      - `[SoftwareVersions <IMicrosoftGraphTeamworkDeviceSoftwareVersions>]`: teamworkDeviceSoftwareVersions
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AdminAgentSoftwareVersion <String>]`: 
        - `[FirmwareSoftwareVersion <String>]`: 
        - `[OperatingSystemSoftwareVersion <String>]`: 
        - `[PartnerAgentSoftwareVersion <String>]`: 
        - `[TeamsClientSoftwareVersion <String>]`: 
      - `[SpeakerConfiguration <IMicrosoftGraphTeamworkSpeakerConfiguration>]`: teamworkSpeakerConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DefaultCommunicationSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[DefaultSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[IsCommunicationSpeakerOptional <Boolean?>]`: 
        - `[IsSpeakerOptional <Boolean?>]`: 
        - `[Speakers <IMicrosoftGraphTeamworkPeripheral[]>]`: 
      - `[SystemConfiguration <IMicrosoftGraphTeamworkSystemConfiguration>]`: teamworkSystemConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DateTimeConfiguration <IMicrosoftGraphTeamworkDateTimeConfiguration>]`: teamworkDateTimeConfiguration
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DateFormat <String>]`: 
          - `[OfficeHoursEndTime <String>]`: 
          - `[OfficeHoursStartTime <String>]`: 
          - `[TimeFormat <String>]`: 
          - `[TimeZone <String>]`: 
        - `[DefaultPassword <String>]`: 
        - `[DeviceLockTimeout <TimeSpan?>]`: 
        - `[IsDeviceLockEnabled <Boolean?>]`: 
        - `[IsLoggingEnabled <Boolean?>]`: 
        - `[IsPowerSavingEnabled <Boolean?>]`: 
        - `[IsScreenCaptureEnabled <Boolean?>]`: 
        - `[IsSilentModeEnabled <Boolean?>]`: 
        - `[Language <String>]`: 
        - `[LockPin <String>]`: 
        - `[LoggingLevel <String>]`: 
        - `[NetworkConfiguration <IMicrosoftGraphTeamworkNetworkConfiguration>]`: teamworkNetworkConfiguration
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DefaultGateway <String>]`: 
          - `[DomainName <String>]`: 
          - `[HostName <String>]`: 
          - `[IPAddress <String>]`: 
          - `[IsDhcpEnabled <Boolean?>]`: 
          - `[IsPcPortEnabled <Boolean?>]`: 
          - `[PrimaryDns <String>]`: 
          - `[SecondaryDns <String>]`: 
          - `[SubnetMask <String>]`: 
      - `[TeamsClientConfiguration <IMicrosoftGraphTeamworkTeamsClientConfiguration>]`: teamworkTeamsClientConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AccountConfiguration <IMicrosoftGraphTeamworkAccountConfiguration>]`: teamworkAccountConfiguration
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[OnPremisesCalendarSyncConfiguration <IMicrosoftGraphTeamworkOnPremisesCalendarSyncConfiguration>]`: teamworkOnPremisesCalendarSyncConfiguration
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Domain <String>]`: 
            - `[DomainUserName <String>]`: 
            - `[SmtpAddress <String>]`: 
          - `[SupportedClient <String>]`: teamworkSupportedClient
        - `[FeaturesConfiguration <IMicrosoftGraphTeamworkFeaturesConfiguration>]`: teamworkFeaturesConfiguration
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[EmailToSendLogsAndFeedback <String>]`: 
          - `[IsAutoScreenShareEnabled <Boolean?>]`: 
          - `[IsBluetoothBeaconingEnabled <Boolean?>]`: 
          - `[IsHideMeetingNamesEnabled <Boolean?>]`: 
          - `[IsSendLogsAndFeedbackEnabled <Boolean?>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[CurrentUser <IMicrosoftGraphTeamworkUserIdentity>]`: teamworkUserIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[UserIdentityType <String>]`: teamworkUserIdentityType
    - `[DeviceType <String>]`: teamworkDeviceType
    - `[HardwareDetail <IMicrosoftGraphTeamworkHardwareDetail>]`: teamworkHardwareDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MacAddresses <String[]>]`: 
      - `[Manufacturer <String>]`: 
      - `[Model <String>]`: 
      - `[SerialNumber <String>]`: 
      - `[UniqueId <String>]`: 
    - `[Health <IMicrosoftGraphTeamworkDeviceHealth>]`: teamworkDeviceHealth
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ConnectionStatus <String>]`: teamworkConnectionStatus
        - `[LastModifiedDateTime <DateTime?>]`: 
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: 
      - `[HardwareHealth <IMicrosoftGraphTeamworkHardwareHealth>]`: teamworkHardwareHealth
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ComputeHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
          - `[IsOptional <Boolean?>]`: 
          - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[HdmiIngestHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[LoginStatus <IMicrosoftGraphTeamworkLoginStatus>]`: teamworkLoginStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExchangeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
        - `[SkypeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
        - `[TeamsConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[PeripheralsHealth <IMicrosoftGraphTeamworkPeripheralsHealth>]`: teamworkPeripheralsHealth
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CommunicationSpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
        - `[ContentCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
        - `[DisplayHealthCollection <IMicrosoftGraphTeamworkPeripheralHealth[]>]`: 
        - `[MicrophoneHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
        - `[RoomCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
        - `[SpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[SoftwareUpdateHealth <IMicrosoftGraphTeamworkSoftwareUpdateHealth>]`: teamworkSoftwareUpdateHealth
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AdminAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[AvailableVersion <String>]`: 
          - `[CurrentVersion <String>]`: 
          - `[SoftwareFreshness <String>]`: teamworkSoftwareFreshness
        - `[CompanyPortalSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
        - `[FirmwareSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
        - `[OperatingSystemSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
        - `[PartnerAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
        - `[TeamsClientSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
    - `[HealthStatus <String>]`: teamworkDeviceHealthStatus
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Notes <String>]`: 
    - `[Operations <IMicrosoftGraphTeamworkDeviceOperation[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[CompletedDateTime <DateTime?>]`: 
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Error <IMicrosoftGraphOperationError>]`: operationError
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: Operation error code.
        - `[Message <String>]`: Operation error message.
      - `[LastActionBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastActionDateTime <DateTime?>]`: 
      - `[OperationType <String>]`: teamworkDeviceOperationType
      - `[StartedDateTime <DateTime?>]`: 
      - `[Status <String>]`: 
  - `[WorkforceIntegrations <IMicrosoftGraphWorkforceIntegration[]>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Id <String>]`: Read-only.
    - `[ApiVersion <Int32?>]`: API version for the call back URL. Start with 1.
    - `[DisplayName <String>]`: Name of the workforce integration.
    - `[EligibilityFilteringEnabledEntities <String>]`: eligibilityFilteringEnabledEntities
    - `[Encryption <IMicrosoftGraphWorkforceIntegrationEncryption>]`: workforceIntegrationEncryption
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Protocol <String>]`: workforceIntegrationEncryptionProtocol
      - `[Secret <String>]`: Encryption shared secret.
    - `[IsActive <Boolean?>]`: Indicates whether this workforce integration is currently active and available.
    - `[SupportedEntities <String>]`: 
    - `[Supports <String>]`: 
    - `[Url <String>]`: Workforce Integration URL for callbacks from the Shifts service.

DEVICES <IMicrosoftGraphTeamworkDevice[]>: .
  - `[Id <String>]`: Read-only.
  - `[Activity <IMicrosoftGraphTeamworkDeviceActivity>]`: teamworkDeviceActivity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ActivePeripherals <IMicrosoftGraphTeamworkActivePeripherals>]`: teamworkActivePeripherals
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CommunicationSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: 
        - `[ProductId <String>]`: 
        - `[VendorId <String>]`: 
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
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[ActivityState <String>]`: teamworkDeviceActivityState
  - `[CompanyAssetTag <String>]`: 
  - `[Configuration <IMicrosoftGraphTeamworkDeviceConfiguration>]`: teamworkDeviceConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[CameraConfiguration <IMicrosoftGraphTeamworkCameraConfiguration>]`: teamworkCameraConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Cameras <IMicrosoftGraphTeamworkPeripheral[]>]`: 
      - `[ContentCameraConfiguration <IMicrosoftGraphTeamworkContentCameraConfiguration>]`: teamworkContentCameraConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[IsContentCameraInverted <Boolean?>]`: 
        - `[IsContentCameraOptional <Boolean?>]`: 
        - `[IsContentEnhancementEnabled <Boolean?>]`: 
      - `[DefaultContentCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayConfiguration <IMicrosoftGraphTeamworkDisplayConfiguration>]`: teamworkDisplayConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConfiguredDisplays <IMicrosoftGraphTeamworkConfiguredPeripheral[]>]`: 
        - `[IsOptional <Boolean?>]`: 
        - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[DisplayCount <Int32?>]`: 
      - `[InBuiltDisplayScreenConfiguration <IMicrosoftGraphTeamworkDisplayScreenConfiguration>]`: teamworkDisplayScreenConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[BacklightBrightness <Int32?>]`: 
        - `[BacklightTimeout <TimeSpan?>]`: 
        - `[IsHighContrastEnabled <Boolean?>]`: 
        - `[IsScreensaverEnabled <Boolean?>]`: 
        - `[ScreensaverTimeout <TimeSpan?>]`: 
      - `[IsContentDuplicationAllowed <Boolean?>]`: 
      - `[IsDualDisplayModeEnabled <Boolean?>]`: 
    - `[HardwareConfiguration <IMicrosoftGraphTeamworkHardwareConfiguration>]`: teamworkHardwareConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Compute <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[HdmiIngest <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[ProcessorModel <String>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[MicrophoneConfiguration <IMicrosoftGraphTeamworkMicrophoneConfiguration>]`: teamworkMicrophoneConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DefaultMicrophone <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[IsMicrophoneOptional <Boolean?>]`: 
      - `[Microphones <IMicrosoftGraphTeamworkPeripheral[]>]`: 
    - `[SoftwareVersions <IMicrosoftGraphTeamworkDeviceSoftwareVersions>]`: teamworkDeviceSoftwareVersions
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AdminAgentSoftwareVersion <String>]`: 
      - `[FirmwareSoftwareVersion <String>]`: 
      - `[OperatingSystemSoftwareVersion <String>]`: 
      - `[PartnerAgentSoftwareVersion <String>]`: 
      - `[TeamsClientSoftwareVersion <String>]`: 
    - `[SpeakerConfiguration <IMicrosoftGraphTeamworkSpeakerConfiguration>]`: teamworkSpeakerConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DefaultCommunicationSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[DefaultSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[IsCommunicationSpeakerOptional <Boolean?>]`: 
      - `[IsSpeakerOptional <Boolean?>]`: 
      - `[Speakers <IMicrosoftGraphTeamworkPeripheral[]>]`: 
    - `[SystemConfiguration <IMicrosoftGraphTeamworkSystemConfiguration>]`: teamworkSystemConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTimeConfiguration <IMicrosoftGraphTeamworkDateTimeConfiguration>]`: teamworkDateTimeConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DateFormat <String>]`: 
        - `[OfficeHoursEndTime <String>]`: 
        - `[OfficeHoursStartTime <String>]`: 
        - `[TimeFormat <String>]`: 
        - `[TimeZone <String>]`: 
      - `[DefaultPassword <String>]`: 
      - `[DeviceLockTimeout <TimeSpan?>]`: 
      - `[IsDeviceLockEnabled <Boolean?>]`: 
      - `[IsLoggingEnabled <Boolean?>]`: 
      - `[IsPowerSavingEnabled <Boolean?>]`: 
      - `[IsScreenCaptureEnabled <Boolean?>]`: 
      - `[IsSilentModeEnabled <Boolean?>]`: 
      - `[Language <String>]`: 
      - `[LockPin <String>]`: 
      - `[LoggingLevel <String>]`: 
      - `[NetworkConfiguration <IMicrosoftGraphTeamworkNetworkConfiguration>]`: teamworkNetworkConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DefaultGateway <String>]`: 
        - `[DomainName <String>]`: 
        - `[HostName <String>]`: 
        - `[IPAddress <String>]`: 
        - `[IsDhcpEnabled <Boolean?>]`: 
        - `[IsPcPortEnabled <Boolean?>]`: 
        - `[PrimaryDns <String>]`: 
        - `[SecondaryDns <String>]`: 
        - `[SubnetMask <String>]`: 
    - `[TeamsClientConfiguration <IMicrosoftGraphTeamworkTeamsClientConfiguration>]`: teamworkTeamsClientConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccountConfiguration <IMicrosoftGraphTeamworkAccountConfiguration>]`: teamworkAccountConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[OnPremisesCalendarSyncConfiguration <IMicrosoftGraphTeamworkOnPremisesCalendarSyncConfiguration>]`: teamworkOnPremisesCalendarSyncConfiguration
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Domain <String>]`: 
          - `[DomainUserName <String>]`: 
          - `[SmtpAddress <String>]`: 
        - `[SupportedClient <String>]`: teamworkSupportedClient
      - `[FeaturesConfiguration <IMicrosoftGraphTeamworkFeaturesConfiguration>]`: teamworkFeaturesConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[EmailToSendLogsAndFeedback <String>]`: 
        - `[IsAutoScreenShareEnabled <Boolean?>]`: 
        - `[IsBluetoothBeaconingEnabled <Boolean?>]`: 
        - `[IsHideMeetingNamesEnabled <Boolean?>]`: 
        - `[IsSendLogsAndFeedbackEnabled <Boolean?>]`: 
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: 
  - `[CurrentUser <IMicrosoftGraphTeamworkUserIdentity>]`: teamworkUserIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[UserIdentityType <String>]`: teamworkUserIdentityType
  - `[DeviceType <String>]`: teamworkDeviceType
  - `[HardwareDetail <IMicrosoftGraphTeamworkHardwareDetail>]`: teamworkHardwareDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MacAddresses <String[]>]`: 
    - `[Manufacturer <String>]`: 
    - `[Model <String>]`: 
    - `[SerialNumber <String>]`: 
    - `[UniqueId <String>]`: 
  - `[Health <IMicrosoftGraphTeamworkDeviceHealth>]`: teamworkDeviceHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConnectionStatus <String>]`: teamworkConnectionStatus
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[HardwareHealth <IMicrosoftGraphTeamworkHardwareHealth>]`: teamworkHardwareHealth
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ComputeHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
        - `[IsOptional <Boolean?>]`: 
        - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[HdmiIngestHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[LoginStatus <IMicrosoftGraphTeamworkLoginStatus>]`: teamworkLoginStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExchangeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[SkypeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[TeamsConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
    - `[PeripheralsHealth <IMicrosoftGraphTeamworkPeripheralsHealth>]`: teamworkPeripheralsHealth
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CommunicationSpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[ContentCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[DisplayHealthCollection <IMicrosoftGraphTeamworkPeripheralHealth[]>]`: 
      - `[MicrophoneHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[RoomCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[SpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[SoftwareUpdateHealth <IMicrosoftGraphTeamworkSoftwareUpdateHealth>]`: teamworkSoftwareUpdateHealth
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AdminAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AvailableVersion <String>]`: 
        - `[CurrentVersion <String>]`: 
        - `[SoftwareFreshness <String>]`: teamworkSoftwareFreshness
      - `[CompanyPortalSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
      - `[FirmwareSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
      - `[OperatingSystemSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
      - `[PartnerAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
      - `[TeamsClientSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
  - `[HealthStatus <String>]`: teamworkDeviceHealthStatus
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Notes <String>]`: 
  - `[Operations <IMicrosoftGraphTeamworkDeviceOperation[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CompletedDateTime <DateTime?>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Error <IMicrosoftGraphOperationError>]`: operationError
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: Operation error code.
      - `[Message <String>]`: Operation error message.
    - `[LastActionBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastActionDateTime <DateTime?>]`: 
    - `[OperationType <String>]`: teamworkDeviceOperationType
    - `[StartedDateTime <DateTime?>]`: 
    - `[Status <String>]`: 

WORKFORCEINTEGRATIONS <IMicrosoftGraphWorkforceIntegration[]>: .
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: Read-only.
  - `[ApiVersion <Int32?>]`: API version for the call back URL. Start with 1.
  - `[DisplayName <String>]`: Name of the workforce integration.
  - `[EligibilityFilteringEnabledEntities <String>]`: eligibilityFilteringEnabledEntities
  - `[Encryption <IMicrosoftGraphWorkforceIntegrationEncryption>]`: workforceIntegrationEncryption
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Protocol <String>]`: workforceIntegrationEncryptionProtocol
    - `[Secret <String>]`: Encryption shared secret.
  - `[IsActive <Boolean?>]`: Indicates whether this workforce integration is currently active and available.
  - `[SupportedEntities <String>]`: 
  - `[Supports <String>]`: 
  - `[Url <String>]`: Workforce Integration URL for callbacks from the Shifts service.

## RELATED LINKS

