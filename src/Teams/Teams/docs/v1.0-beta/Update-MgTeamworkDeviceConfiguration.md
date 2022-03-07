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
.

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
.

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
  - `[Id <String>]`: Read-only.
  - `[CameraConfiguration <IMicrosoftGraphTeamworkCameraConfiguration>]`: teamworkCameraConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Cameras <IMicrosoftGraphTeamworkPeripheral[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: 
      - `[ProductId <String>]`: 
      - `[VendorId <String>]`: 
    - `[ContentCameraConfiguration <IMicrosoftGraphTeamworkContentCameraConfiguration>]`: teamworkContentCameraConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsContentCameraInverted <Boolean?>]`: 
      - `[IsContentCameraOptional <Boolean?>]`: 
      - `[IsContentEnhancementEnabled <Boolean?>]`: 
    - `[DefaultContentCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
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

CAMERACONFIGURATION <IMicrosoftGraphTeamworkCameraConfiguration>: teamworkCameraConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Cameras <IMicrosoftGraphTeamworkPeripheral[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[ProductId <String>]`: 
    - `[VendorId <String>]`: 
  - `[ContentCameraConfiguration <IMicrosoftGraphTeamworkContentCameraConfiguration>]`: teamworkContentCameraConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsContentCameraInverted <Boolean?>]`: 
    - `[IsContentCameraOptional <Boolean?>]`: 
    - `[IsContentEnhancementEnabled <Boolean?>]`: 
  - `[DefaultContentCamera <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

DISPLAYCONFIGURATION <IMicrosoftGraphTeamworkDisplayConfiguration>: teamworkDisplayConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ConfiguredDisplays <IMicrosoftGraphTeamworkConfiguredPeripheral[]>]`: 
    - `[IsOptional <Boolean?>]`: 
    - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: 
      - `[ProductId <String>]`: 
      - `[VendorId <String>]`: 
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

HARDWARECONFIGURATION <IMicrosoftGraphTeamworkHardwareConfiguration>: teamworkHardwareConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Compute <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[ProductId <String>]`: 
    - `[VendorId <String>]`: 
  - `[HdmiIngest <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
  - `[ProcessorModel <String>]`: 

INPUTOBJECT <ITeamsIdentity>: Identity Parameter
  - `[ChannelId <String>]`: key: id of channel
  - `[ChatId <String>]`: key: id of chat
  - `[ChatMessageHostedContentId <String>]`: key: id of chatMessageHostedContent
  - `[ChatMessageId <String>]`: key: id of chatMessage
  - `[ChatMessageId1 <String>]`: key: id of chatMessage
  - `[ConversationMemberId <String>]`: key: id of conversationMember
  - `[GroupId <String>]`: key: id of group
  - `[OfferShiftRequestId <String>]`: key: id of offerShiftRequest
  - `[OpenShiftChangeRequestId <String>]`: key: id of openShiftChangeRequest
  - `[OpenShiftId <String>]`: key: id of openShift
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SchedulingGroupId <String>]`: key: id of schedulingGroup
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
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

MICROPHONECONFIGURATION <IMicrosoftGraphTeamworkMicrophoneConfiguration>: teamworkMicrophoneConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DefaultMicrophone <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[ProductId <String>]`: 
    - `[VendorId <String>]`: 
  - `[IsMicrophoneOptional <Boolean?>]`: 
  - `[Microphones <IMicrosoftGraphTeamworkPeripheral[]>]`: 

SOFTWAREVERSIONS <IMicrosoftGraphTeamworkDeviceSoftwareVersions>: teamworkDeviceSoftwareVersions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AdminAgentSoftwareVersion <String>]`: 
  - `[FirmwareSoftwareVersion <String>]`: 
  - `[OperatingSystemSoftwareVersion <String>]`: 
  - `[PartnerAgentSoftwareVersion <String>]`: 
  - `[TeamsClientSoftwareVersion <String>]`: 

SPEAKERCONFIGURATION <IMicrosoftGraphTeamworkSpeakerConfiguration>: teamworkSpeakerConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DefaultCommunicationSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[ProductId <String>]`: 
    - `[VendorId <String>]`: 
  - `[DefaultSpeaker <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
  - `[IsCommunicationSpeakerOptional <Boolean?>]`: 
  - `[IsSpeakerOptional <Boolean?>]`: 
  - `[Speakers <IMicrosoftGraphTeamworkPeripheral[]>]`: 

SYSTEMCONFIGURATION <IMicrosoftGraphTeamworkSystemConfiguration>: teamworkSystemConfiguration
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

TEAMSCLIENTCONFIGURATION <IMicrosoftGraphTeamworkTeamsClientConfiguration>: teamworkTeamsClientConfiguration
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

## RELATED LINKS

