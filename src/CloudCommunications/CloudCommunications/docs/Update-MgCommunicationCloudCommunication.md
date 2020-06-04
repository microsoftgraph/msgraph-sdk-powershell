---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/update-mgcommunicationcloudcommunication
schema: 2.0.0
---

# Update-MgCommunicationCloudCommunication

## SYNOPSIS
Update communications

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgCommunicationCloudCommunication [-CallRecords <IMicrosoftGraphCallRecordsCallRecord[]>]
 [-Calls <IMicrosoftGraphCall[]>] [-Id <String>] [-OnlineMeetings <IMicrosoftGraphOnlineMeeting[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgCommunicationCloudCommunication -BodyParameter <IMicrosoftGraphCloudCommunications> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update communications

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

### -BodyParameter
cloudCommunications
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudCommunications
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CallRecords
.
To construct, see NOTES section for CALLRECORDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRecordsCallRecord[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Calls
.
To construct, see NOTES section for CALLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCall[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -OnlineMeetings
.
To construct, see NOTES section for ONLINEMEETINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnlineMeeting[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudCommunications

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphCloudCommunications>: cloudCommunications
  - `[Id <String>]`: Read-only.
  - `[CallRecords <IMicrosoftGraphCallRecordsCallRecord[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[EndDateTime <DateTime?>]`: 
    - `[JoinWebUrl <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Modalities <String[]>]`: 
    - `[Organizer <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Participants <IMicrosoftGraphIdentitySet[]>]`: 
    - `[Sessions <IMicrosoftGraphCallRecordsSession[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[CalleeUserAgentApplicationVersion <String>]`: 
      - `[CalleeUserAgentHeaderValue <String>]`: 
      - `[CallerUserAgentApplicationVersion <String>]`: 
      - `[CallerUserAgentHeaderValue <String>]`: 
      - `[EndDateTime <DateTime?>]`: 
      - `[FailureInfoReason <String>]`: 
      - `[FailureInfoStage <String>]`: failureStage
      - `[Modalities <String[]>]`: 
      - `[Segments <IMicrosoftGraphCallRecordsSegment[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[CalleeUserAgentApplicationVersion <String>]`: 
        - `[CalleeUserAgentHeaderValue <String>]`: 
        - `[CallerUserAgentApplicationVersion <String>]`: 
        - `[CallerUserAgentHeaderValue <String>]`: 
        - `[EndDateTime <DateTime?>]`: 
        - `[FailureInfoReason <String>]`: 
        - `[FailureInfoStage <String>]`: failureStage
        - `[Media <IMicrosoftGraphCallRecordsMedia[]>]`: 
          - `[CalleeDeviceCaptureDeviceDriver <String>]`: 
          - `[CalleeDeviceCaptureDeviceName <String>]`: 
          - `[CalleeDeviceCaptureNotFunctioningEventRatio <Single?>]`: 
          - `[CalleeDeviceClippingEventRatio <Single?>]`: 
          - `[CalleeDeviceCpuInsufficentEventRatio <Single?>]`: 
          - `[CalleeDeviceGlitchEventRatio <Single?>]`: 
          - `[CalleeDeviceHowlingEventCount <Int32?>]`: 
          - `[CalleeDeviceInitialSignalLevelRootMeanSquare <Single?>]`: 
          - `[CalleeDeviceLowSpeechLevelEventRatio <Single?>]`: 
          - `[CalleeDeviceLowSpeechToNoiseEventRatio <Single?>]`: 
          - `[CalleeDeviceMicGlitchRate <Single?>]`: 
          - `[CalleeDeviceReceivedNoiseLevel <Int32?>]`: 
          - `[CalleeDeviceReceivedSignalLevel <Int32?>]`: 
          - `[CalleeDeviceRenderDeviceDriver <String>]`: 
          - `[CalleeDeviceRenderDeviceName <String>]`: 
          - `[CalleeDeviceRenderMuteEventRatio <Single?>]`: 
          - `[CalleeDeviceRenderNotFunctioningEventRatio <Single?>]`: 
          - `[CalleeDeviceRenderZeroVolumeEventRatio <Single?>]`: 
          - `[CalleeDeviceSentNoiseLevel <Int32?>]`: 
          - `[CalleeDeviceSentSignalLevel <Int32?>]`: 
          - `[CalleeDeviceSpeakerGlitchRate <Single?>]`: 
          - `[CalleeNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
            - `[BandwidthLowEventRatio <Single?>]`: 
            - `[BasicServiceSetIdentifier <String>]`: 
            - `[ConnectionType <String>]`: networkConnectionType
            - `[DelayEventRatio <Single?>]`: 
            - `[DnsSuffix <String>]`: 
            - `[IPAddress <String>]`: 
            - `[LinkSpeed <Int64?>]`: 
            - `[MacAddress <String>]`: 
            - `[Port <Int32?>]`: 
            - `[ReceivedQualityEventRatio <Single?>]`: 
            - `[ReflexiveIPAddress <String>]`: 
            - `[RelayIPAddress <String>]`: 
            - `[RelayPort <Int32?>]`: 
            - `[SentQualityEventRatio <Single?>]`: 
            - `[Subnet <String>]`: 
            - `[WifiBand <String>]`: wifiBand
            - `[WifiBatteryCharge <Int32?>]`: 
            - `[WifiChannel <Int32?>]`: 
            - `[WifiMicrosoftDriver <String>]`: 
            - `[WifiMicrosoftDriverVersion <String>]`: 
            - `[WifiRadioType <String>]`: wifiRadioType
            - `[WifiSignalStrength <Int32?>]`: 
            - `[WifiVendorDriver <String>]`: 
            - `[WifiVendorDriverVersion <String>]`: 
          - `[CallerDeviceCaptureDeviceDriver <String>]`: 
          - `[CallerDeviceCaptureDeviceName <String>]`: 
          - `[CallerDeviceCaptureNotFunctioningEventRatio <Single?>]`: 
          - `[CallerDeviceClippingEventRatio <Single?>]`: 
          - `[CallerDeviceCpuInsufficentEventRatio <Single?>]`: 
          - `[CallerDeviceGlitchEventRatio <Single?>]`: 
          - `[CallerDeviceHowlingEventCount <Int32?>]`: 
          - `[CallerDeviceInitialSignalLevelRootMeanSquare <Single?>]`: 
          - `[CallerDeviceLowSpeechLevelEventRatio <Single?>]`: 
          - `[CallerDeviceLowSpeechToNoiseEventRatio <Single?>]`: 
          - `[CallerDeviceMicGlitchRate <Single?>]`: 
          - `[CallerDeviceReceivedNoiseLevel <Int32?>]`: 
          - `[CallerDeviceReceivedSignalLevel <Int32?>]`: 
          - `[CallerDeviceRenderDeviceDriver <String>]`: 
          - `[CallerDeviceRenderDeviceName <String>]`: 
          - `[CallerDeviceRenderMuteEventRatio <Single?>]`: 
          - `[CallerDeviceRenderNotFunctioningEventRatio <Single?>]`: 
          - `[CallerDeviceRenderZeroVolumeEventRatio <Single?>]`: 
          - `[CallerDeviceSentNoiseLevel <Int32?>]`: 
          - `[CallerDeviceSentSignalLevel <Int32?>]`: 
          - `[CallerDeviceSpeakerGlitchRate <Single?>]`: 
          - `[CallerNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
          - `[Label <String>]`: 
          - `[Streams <IMicrosoftGraphCallRecordsMediaStream[]>]`: 
            - `[AverageAudioDegradation <Single?>]`: 
            - `[AverageAudioNetworkJitter <TimeSpan?>]`: 
            - `[AverageBandwidthEstimate <Int64?>]`: 
            - `[AverageJitter <TimeSpan?>]`: 
            - `[AveragePacketLossRate <Single?>]`: 
            - `[AverageRatioOfConcealedSamples <Single?>]`: 
            - `[AverageReceivedFrameRate <Single?>]`: 
            - `[AverageRoundTripTime <TimeSpan?>]`: 
            - `[AverageVideoFrameLossPercentage <Single?>]`: 
            - `[AverageVideoFrameRate <Single?>]`: 
            - `[AverageVideoPacketLossRate <Single?>]`: 
            - `[EndDateTime <DateTime?>]`: 
            - `[LowFrameRateRatio <Single?>]`: 
            - `[LowVideoProcessingCapabilityRatio <Single?>]`: 
            - `[MaxAudioNetworkJitter <TimeSpan?>]`: 
            - `[MaxJitter <TimeSpan?>]`: 
            - `[MaxPacketLossRate <Single?>]`: 
            - `[MaxRatioOfConcealedSamples <Single?>]`: 
            - `[MaxRoundTripTime <TimeSpan?>]`: 
            - `[PacketUtilization <Int64?>]`: 
            - `[PostForwardErrorCorrectionPacketLossRate <Single?>]`: 
            - `[StartDateTime <DateTime?>]`: 
            - `[StreamDirection <String>]`: mediaStreamDirection
            - `[StreamId <String>]`: 
            - `[WasMediaBypassed <Boolean?>]`: 
        - `[StartDateTime <DateTime?>]`: 
      - `[StartDateTime <DateTime?>]`: 
    - `[StartDateTime <DateTime?>]`: 
    - `[Type <String>]`: callType
    - `[Version <Int64?>]`: 
  - `[Calls <IMicrosoftGraphCall[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ActiveModalities <String[]>]`: 
    - `[AnsweredByCountryCode <String>]`: 
    - `[AnsweredByEndpointType <String>]`: endpointType
    - `[AnsweredByIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[AnsweredByLanguageId <String>]`: The language culture string. Read-only.
    - `[AnsweredByRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
    - `[AudioRoutingGroups <IMicrosoftGraphAudioRoutingGroup[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Receivers <String[]>]`: 
      - `[RoutingMode <String>]`: routingMode
      - `[Sources <String[]>]`: 
    - `[CallOptions <IMicrosoftGraphCallOptions>]`: callOptions
    - `[CallRoutes <IMicrosoftGraphCallRoute[]>]`: 
      - `[Final <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Original <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[RoutingType <String>]`: routingType
    - `[CallbackUri <String>]`: The callback URL on which callbacks will be delivered. Must be https.
    - `[ChatInfoMessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
    - `[ChatInfoReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ChatInfoThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
    - `[Direction <String>]`: callDirection
    - `[IncomingContextObservedParticipantId <String>]`: 
    - `[IncomingContextOnBehalfOf <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[IncomingContextSourceParticipantId <String>]`: 
    - `[IncomingContextTransferor <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[MediaConfigRemoveFromDefaultAudioGroup <Boolean?>]`: 
    - `[MediaStateAudio <String>]`: mediaState
    - `[MeetingCapabilityAllowAnonymousUsersToDialOut <Boolean?>]`: 
    - `[MeetingCapabilityAllowAnonymousUsersToStartMeeting <Boolean?>]`: 
    - `[MeetingCapabilityAutoAdmittedUsers <String>]`: autoAdmittedUsersType
    - `[MeetingInfoAllowConversationWithoutHost <Boolean?>]`: 
    - `[MyParticipantId <String>]`: Read-only.
    - `[Operations <IMicrosoftGraphCommsOperation[]>]`: Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[ClientContext <String>]`: Unique Client Context string. Max limit is 256 chars.
      - `[ResultInfoCode <Int32?>]`: 
      - `[ResultInfoMessage <String>]`: 
      - `[ResultInfoSubcode <Int32?>]`: 
      - `[Status <String>]`: operationStatus
    - `[Participants <IMicrosoftGraphParticipant[]>]`: Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[InfoCountryCode <String>]`: 
      - `[InfoEndpointType <String>]`: endpointType
      - `[InfoIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[InfoLanguageId <String>]`: The language culture string. Read-only.
      - `[InfoRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
      - `[InitiatedByCountryCode <String>]`: 
      - `[InitiatedByEndpointType <String>]`: endpointType
      - `[InitiatedByIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[InitiatedByLanguageId <String>]`: The language culture string. Read-only.
      - `[InitiatedByRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
      - `[IsInLobby <Boolean?>]`: true if the participant is in lobby.
      - `[IsMuted <Boolean?>]`: true if the participant is muted (client or server muted).
      - `[MediaStreams <IMicrosoftGraphMediaStream[]>]`: The list of media streams.
        - `[Direction <String>]`: mediaDirection
        - `[Label <String>]`: The media stream label.
        - `[MediaType <String>]`: modality
        - `[ServerMuted <Boolean?>]`: If the media is muted by the server.
        - `[SourceId <String>]`: The source ID.
      - `[Metadata <String>]`: 
      - `[RecordingInfoInitiator <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[RecordingInfoRecordingStatus <String>]`: recordingStatus
    - `[RequestedModalities <String[]>]`: The list of requested modalities.
    - `[ResultInfoCode <Int32?>]`: 
    - `[ResultInfoMessage <String>]`: 
    - `[ResultInfoSubcode <Int32?>]`: 
    - `[RingingTimeoutInSeconds <Int32?>]`: 
    - `[RoutingPolicies <String[]>]`: 
    - `[SourceCountryCode <String>]`: 
    - `[SourceEndpointType <String>]`: endpointType
    - `[SourceIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[SourceLanguageId <String>]`: The language culture string. Read-only.
    - `[SourceRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
    - `[State <String>]`: callState
    - `[Subject <String>]`: The subject of the conversation.
    - `[Targets <IMicrosoftGraphInvitationParticipantInfo[]>]`: The targets of the call. Required information for creating peer to peer call.
      - `[EndpointType <String>]`: endpointType
      - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. This call will be dropped once the participant is added.
    - `[TenantId <String>]`: 
    - `[TerminationReason <String>]`: 
    - `[ToneInfoSequenceId <Int64?>]`: An incremental identifier used for ordering DTMF events.
    - `[ToneInfoTone <String>]`: tone
  - `[OnlineMeetings <IMicrosoftGraphOnlineMeeting[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessLevel <String>]`: accessLevel
    - `[AudioConferencingConferenceId <String>]`: 
    - `[AudioConferencingDialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
    - `[AudioConferencingTollFreeNumber <String>]`: The toll-free number that connects to the Audio Conference Provider.
    - `[AudioConferencingTollNumber <String>]`: The toll number that connects to the Audio Conference Provider.
    - `[CanceledDateTime <DateTime?>]`: 
    - `[Capabilities <String[]>]`: 
    - `[ChatInfoMessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
    - `[ChatInfoReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ChatInfoThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
    - `[CreationDateTime <DateTime?>]`: The meeting creation time in UTC. Read-only.
    - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
    - `[EntryExitAnnouncement <Boolean?>]`: 
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[IsBroadcast <Boolean?>]`: 
    - `[IsCancelled <Boolean?>]`: 
    - `[JoinUrl <String>]`: 
    - `[OrganizerIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[OrganizerUpn <String>]`: User principal name of the participant.
    - `[ParticipantAttendees <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
      - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Upn <String>]`: User principal name of the participant.
    - `[ParticipantContributors <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
    - `[ParticipantProducers <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
    - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
    - `[Subject <String>]`: The subject of the online meeting.
    - `[VideoTeleconferenceId <String>]`: The video teleconferencing ID. Read-only.

#### CALLRECORDS <IMicrosoftGraphCallRecordsCallRecord[]>: .
  - `[Id <String>]`: Read-only.
  - `[EndDateTime <DateTime?>]`: 
  - `[JoinWebUrl <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Modalities <String[]>]`: 
  - `[Organizer <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Participants <IMicrosoftGraphIdentitySet[]>]`: 
  - `[Sessions <IMicrosoftGraphCallRecordsSession[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CalleeUserAgentApplicationVersion <String>]`: 
    - `[CalleeUserAgentHeaderValue <String>]`: 
    - `[CallerUserAgentApplicationVersion <String>]`: 
    - `[CallerUserAgentHeaderValue <String>]`: 
    - `[EndDateTime <DateTime?>]`: 
    - `[FailureInfoReason <String>]`: 
    - `[FailureInfoStage <String>]`: failureStage
    - `[Modalities <String[]>]`: 
    - `[Segments <IMicrosoftGraphCallRecordsSegment[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[CalleeUserAgentApplicationVersion <String>]`: 
      - `[CalleeUserAgentHeaderValue <String>]`: 
      - `[CallerUserAgentApplicationVersion <String>]`: 
      - `[CallerUserAgentHeaderValue <String>]`: 
      - `[EndDateTime <DateTime?>]`: 
      - `[FailureInfoReason <String>]`: 
      - `[FailureInfoStage <String>]`: failureStage
      - `[Media <IMicrosoftGraphCallRecordsMedia[]>]`: 
        - `[CalleeDeviceCaptureDeviceDriver <String>]`: 
        - `[CalleeDeviceCaptureDeviceName <String>]`: 
        - `[CalleeDeviceCaptureNotFunctioningEventRatio <Single?>]`: 
        - `[CalleeDeviceClippingEventRatio <Single?>]`: 
        - `[CalleeDeviceCpuInsufficentEventRatio <Single?>]`: 
        - `[CalleeDeviceGlitchEventRatio <Single?>]`: 
        - `[CalleeDeviceHowlingEventCount <Int32?>]`: 
        - `[CalleeDeviceInitialSignalLevelRootMeanSquare <Single?>]`: 
        - `[CalleeDeviceLowSpeechLevelEventRatio <Single?>]`: 
        - `[CalleeDeviceLowSpeechToNoiseEventRatio <Single?>]`: 
        - `[CalleeDeviceMicGlitchRate <Single?>]`: 
        - `[CalleeDeviceReceivedNoiseLevel <Int32?>]`: 
        - `[CalleeDeviceReceivedSignalLevel <Int32?>]`: 
        - `[CalleeDeviceRenderDeviceDriver <String>]`: 
        - `[CalleeDeviceRenderDeviceName <String>]`: 
        - `[CalleeDeviceRenderMuteEventRatio <Single?>]`: 
        - `[CalleeDeviceRenderNotFunctioningEventRatio <Single?>]`: 
        - `[CalleeDeviceRenderZeroVolumeEventRatio <Single?>]`: 
        - `[CalleeDeviceSentNoiseLevel <Int32?>]`: 
        - `[CalleeDeviceSentSignalLevel <Int32?>]`: 
        - `[CalleeDeviceSpeakerGlitchRate <Single?>]`: 
        - `[CalleeNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
          - `[BandwidthLowEventRatio <Single?>]`: 
          - `[BasicServiceSetIdentifier <String>]`: 
          - `[ConnectionType <String>]`: networkConnectionType
          - `[DelayEventRatio <Single?>]`: 
          - `[DnsSuffix <String>]`: 
          - `[IPAddress <String>]`: 
          - `[LinkSpeed <Int64?>]`: 
          - `[MacAddress <String>]`: 
          - `[Port <Int32?>]`: 
          - `[ReceivedQualityEventRatio <Single?>]`: 
          - `[ReflexiveIPAddress <String>]`: 
          - `[RelayIPAddress <String>]`: 
          - `[RelayPort <Int32?>]`: 
          - `[SentQualityEventRatio <Single?>]`: 
          - `[Subnet <String>]`: 
          - `[WifiBand <String>]`: wifiBand
          - `[WifiBatteryCharge <Int32?>]`: 
          - `[WifiChannel <Int32?>]`: 
          - `[WifiMicrosoftDriver <String>]`: 
          - `[WifiMicrosoftDriverVersion <String>]`: 
          - `[WifiRadioType <String>]`: wifiRadioType
          - `[WifiSignalStrength <Int32?>]`: 
          - `[WifiVendorDriver <String>]`: 
          - `[WifiVendorDriverVersion <String>]`: 
        - `[CallerDeviceCaptureDeviceDriver <String>]`: 
        - `[CallerDeviceCaptureDeviceName <String>]`: 
        - `[CallerDeviceCaptureNotFunctioningEventRatio <Single?>]`: 
        - `[CallerDeviceClippingEventRatio <Single?>]`: 
        - `[CallerDeviceCpuInsufficentEventRatio <Single?>]`: 
        - `[CallerDeviceGlitchEventRatio <Single?>]`: 
        - `[CallerDeviceHowlingEventCount <Int32?>]`: 
        - `[CallerDeviceInitialSignalLevelRootMeanSquare <Single?>]`: 
        - `[CallerDeviceLowSpeechLevelEventRatio <Single?>]`: 
        - `[CallerDeviceLowSpeechToNoiseEventRatio <Single?>]`: 
        - `[CallerDeviceMicGlitchRate <Single?>]`: 
        - `[CallerDeviceReceivedNoiseLevel <Int32?>]`: 
        - `[CallerDeviceReceivedSignalLevel <Int32?>]`: 
        - `[CallerDeviceRenderDeviceDriver <String>]`: 
        - `[CallerDeviceRenderDeviceName <String>]`: 
        - `[CallerDeviceRenderMuteEventRatio <Single?>]`: 
        - `[CallerDeviceRenderNotFunctioningEventRatio <Single?>]`: 
        - `[CallerDeviceRenderZeroVolumeEventRatio <Single?>]`: 
        - `[CallerDeviceSentNoiseLevel <Int32?>]`: 
        - `[CallerDeviceSentSignalLevel <Int32?>]`: 
        - `[CallerDeviceSpeakerGlitchRate <Single?>]`: 
        - `[CallerNetwork <IMicrosoftGraphCallRecordsNetworkInfo>]`: networkInfo
        - `[Label <String>]`: 
        - `[Streams <IMicrosoftGraphCallRecordsMediaStream[]>]`: 
          - `[AverageAudioDegradation <Single?>]`: 
          - `[AverageAudioNetworkJitter <TimeSpan?>]`: 
          - `[AverageBandwidthEstimate <Int64?>]`: 
          - `[AverageJitter <TimeSpan?>]`: 
          - `[AveragePacketLossRate <Single?>]`: 
          - `[AverageRatioOfConcealedSamples <Single?>]`: 
          - `[AverageReceivedFrameRate <Single?>]`: 
          - `[AverageRoundTripTime <TimeSpan?>]`: 
          - `[AverageVideoFrameLossPercentage <Single?>]`: 
          - `[AverageVideoFrameRate <Single?>]`: 
          - `[AverageVideoPacketLossRate <Single?>]`: 
          - `[EndDateTime <DateTime?>]`: 
          - `[LowFrameRateRatio <Single?>]`: 
          - `[LowVideoProcessingCapabilityRatio <Single?>]`: 
          - `[MaxAudioNetworkJitter <TimeSpan?>]`: 
          - `[MaxJitter <TimeSpan?>]`: 
          - `[MaxPacketLossRate <Single?>]`: 
          - `[MaxRatioOfConcealedSamples <Single?>]`: 
          - `[MaxRoundTripTime <TimeSpan?>]`: 
          - `[PacketUtilization <Int64?>]`: 
          - `[PostForwardErrorCorrectionPacketLossRate <Single?>]`: 
          - `[StartDateTime <DateTime?>]`: 
          - `[StreamDirection <String>]`: mediaStreamDirection
          - `[StreamId <String>]`: 
          - `[WasMediaBypassed <Boolean?>]`: 
      - `[StartDateTime <DateTime?>]`: 
    - `[StartDateTime <DateTime?>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[Type <String>]`: callType
  - `[Version <Int64?>]`: 

#### CALLS <IMicrosoftGraphCall[]>: .
  - `[Id <String>]`: Read-only.
  - `[ActiveModalities <String[]>]`: 
  - `[AnsweredByCountryCode <String>]`: 
  - `[AnsweredByEndpointType <String>]`: endpointType
  - `[AnsweredByIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[AnsweredByLanguageId <String>]`: The language culture string. Read-only.
  - `[AnsweredByRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
  - `[AudioRoutingGroups <IMicrosoftGraphAudioRoutingGroup[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Receivers <String[]>]`: 
    - `[RoutingMode <String>]`: routingMode
    - `[Sources <String[]>]`: 
  - `[CallOptions <IMicrosoftGraphCallOptions>]`: callOptions
  - `[CallRoutes <IMicrosoftGraphCallRoute[]>]`: 
    - `[Final <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Original <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[RoutingType <String>]`: routingType
  - `[CallbackUri <String>]`: The callback URL on which callbacks will be delivered. Must be https.
  - `[ChatInfoMessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
  - `[ChatInfoReplyChainMessageId <String>]`: The ID of the reply message.
  - `[ChatInfoThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[Direction <String>]`: callDirection
  - `[IncomingContextObservedParticipantId <String>]`: 
  - `[IncomingContextOnBehalfOf <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[IncomingContextSourceParticipantId <String>]`: 
  - `[IncomingContextTransferor <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[MediaConfigRemoveFromDefaultAudioGroup <Boolean?>]`: 
  - `[MediaStateAudio <String>]`: mediaState
  - `[MeetingCapabilityAllowAnonymousUsersToDialOut <Boolean?>]`: 
  - `[MeetingCapabilityAllowAnonymousUsersToStartMeeting <Boolean?>]`: 
  - `[MeetingCapabilityAutoAdmittedUsers <String>]`: autoAdmittedUsersType
  - `[MeetingInfoAllowConversationWithoutHost <Boolean?>]`: 
  - `[MyParticipantId <String>]`: Read-only.
  - `[Operations <IMicrosoftGraphCommsOperation[]>]`: Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ClientContext <String>]`: Unique Client Context string. Max limit is 256 chars.
    - `[ResultInfoCode <Int32?>]`: 
    - `[ResultInfoMessage <String>]`: 
    - `[ResultInfoSubcode <Int32?>]`: 
    - `[Status <String>]`: operationStatus
  - `[Participants <IMicrosoftGraphParticipant[]>]`: Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[InfoCountryCode <String>]`: 
    - `[InfoEndpointType <String>]`: endpointType
    - `[InfoIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[InfoLanguageId <String>]`: The language culture string. Read-only.
    - `[InfoRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
    - `[InitiatedByCountryCode <String>]`: 
    - `[InitiatedByEndpointType <String>]`: endpointType
    - `[InitiatedByIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[InitiatedByLanguageId <String>]`: The language culture string. Read-only.
    - `[InitiatedByRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
    - `[IsInLobby <Boolean?>]`: true if the participant is in lobby.
    - `[IsMuted <Boolean?>]`: true if the participant is muted (client or server muted).
    - `[MediaStreams <IMicrosoftGraphMediaStream[]>]`: The list of media streams.
      - `[Direction <String>]`: mediaDirection
      - `[Label <String>]`: The media stream label.
      - `[MediaType <String>]`: modality
      - `[ServerMuted <Boolean?>]`: If the media is muted by the server.
      - `[SourceId <String>]`: The source ID.
    - `[Metadata <String>]`: 
    - `[RecordingInfoInitiator <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[RecordingInfoRecordingStatus <String>]`: recordingStatus
  - `[RequestedModalities <String[]>]`: The list of requested modalities.
  - `[ResultInfoCode <Int32?>]`: 
  - `[ResultInfoMessage <String>]`: 
  - `[ResultInfoSubcode <Int32?>]`: 
  - `[RingingTimeoutInSeconds <Int32?>]`: 
  - `[RoutingPolicies <String[]>]`: 
  - `[SourceCountryCode <String>]`: 
  - `[SourceEndpointType <String>]`: endpointType
  - `[SourceIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[SourceLanguageId <String>]`: The language culture string. Read-only.
  - `[SourceRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
  - `[State <String>]`: callState
  - `[Subject <String>]`: The subject of the conversation.
  - `[Targets <IMicrosoftGraphInvitationParticipantInfo[]>]`: The targets of the call. Required information for creating peer to peer call.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. This call will be dropped once the participant is added.
  - `[TenantId <String>]`: 
  - `[TerminationReason <String>]`: 
  - `[ToneInfoSequenceId <Int64?>]`: An incremental identifier used for ordering DTMF events.
  - `[ToneInfoTone <String>]`: tone

#### ONLINEMEETINGS <IMicrosoftGraphOnlineMeeting[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessLevel <String>]`: accessLevel
  - `[AudioConferencingConferenceId <String>]`: 
  - `[AudioConferencingDialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
  - `[AudioConferencingTollFreeNumber <String>]`: The toll-free number that connects to the Audio Conference Provider.
  - `[AudioConferencingTollNumber <String>]`: The toll number that connects to the Audio Conference Provider.
  - `[CanceledDateTime <DateTime?>]`: 
  - `[Capabilities <String[]>]`: 
  - `[ChatInfoMessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
  - `[ChatInfoReplyChainMessageId <String>]`: The ID of the reply message.
  - `[ChatInfoThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[CreationDateTime <DateTime?>]`: The meeting creation time in UTC. Read-only.
  - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
  - `[EntryExitAnnouncement <Boolean?>]`: 
  - `[ExpirationDateTime <DateTime?>]`: 
  - `[IsBroadcast <Boolean?>]`: 
  - `[IsCancelled <Boolean?>]`: 
  - `[JoinUrl <String>]`: 
  - `[OrganizerIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[OrganizerUpn <String>]`: User principal name of the participant.
  - `[ParticipantAttendees <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Upn <String>]`: User principal name of the participant.
  - `[ParticipantContributors <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
  - `[ParticipantProducers <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
  - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
  - `[Subject <String>]`: The subject of the online meeting.
  - `[VideoTeleconferenceId <String>]`: The video teleconferencing ID. Read-only.

## RELATED LINKS

