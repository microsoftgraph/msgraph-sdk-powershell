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

### UpdateExpanded1 (Default)
```
Update-MgCommunicationCloudCommunication [-Calls <IMicrosoftGraphCall1[]>] [-Id <String>]
 [-OnlineMeetings <IMicrosoftGraphOnlineMeeting1[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgCommunicationCloudCommunication -BodyParameter <IMicrosoftGraphCloudCommunications1> [-PassThru]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudCommunications1
Parameter Sets: Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Calls
.
To construct, see NOTES section for CALLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCall1[]
Parameter Sets: UpdateExpanded1
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
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineMeetings
.
To construct, see NOTES section for ONLINEMEETINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnlineMeeting1[]
Parameter Sets: UpdateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudCommunications1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCloudCommunications1>: cloudCommunications
  - `[Id <String>]`: Read-only.
  - `[Calls <IMicrosoftGraphCall1[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CallChainId <String>]`: A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.
    - `[CallOptions <IMicrosoftGraphCallOptions>]`: callOptions
    - `[CallRoutes <IMicrosoftGraphCallRoute[]>]`: The routing information on how the call was retargeted. Read-only.
      - `[Final <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[Original <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[RoutingType <String>]`: routingType
    - `[CallbackUri <String>]`: The callback URL on which callbacks will be delivered. Must be https.
    - `[ChatInfoMessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
    - `[ChatInfoReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ChatInfoThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
    - `[Direction <String>]`: callDirection
    - `[IncomingContextObservedParticipantId <String>]`: The ID of the participant that is under observation. Read-only.
    - `[IncomingContextOnBehalfOf <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[IncomingContextSourceParticipantId <String>]`: The ID of the participant that triggered the incoming call. Read-only.
    - `[IncomingContextTransferor <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[MediaConfigRemoveFromDefaultAudioGroup <Boolean?>]`: 
    - `[MediaStateAudio <String>]`: mediaState
    - `[MeetingInfoAllowConversationWithoutHost <Boolean?>]`: 
    - `[MyParticipantId <String>]`: Read-only.
    - `[Operations <IMicrosoftGraphCommsOperation1[]>]`: Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[ClientContext <String>]`: Unique Client Context string. Max limit is 256 chars.
      - `[ResultInfoCode <Int32?>]`: The result code.
      - `[ResultInfoMessage <String>]`: The message.
      - `[ResultInfoSubcode <Int32?>]`: The result sub-code.
      - `[Status <String>]`: operationStatus
    - `[Participants <IMicrosoftGraphParticipant1[]>]`: Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[InfoCountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
      - `[InfoEndpointType <String>]`: endpointType
      - `[InfoIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[InfoLanguageId <String>]`: The language culture string. Read-only.
      - `[InfoRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
      - `[IsInLobby <Boolean?>]`: true if the participant is in lobby.
      - `[IsMuted <Boolean?>]`: true if the participant is muted (client or server muted).
      - `[MediaStreams <IMicrosoftGraphMediaStream1[]>]`: The list of media streams.
        - `[Direction <String>]`: mediaDirection
        - `[Label <String>]`: The media stream label.
        - `[MediaType <String>]`: 
        - `[ServerMuted <Boolean?>]`: If the media is muted by the server.
        - `[SourceId <String>]`: The source ID.
      - `[RecordingInfoInitiator <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[RecordingInfoRecordingStatus <String>]`: recordingStatus
    - `[RequestedModalities <String[]>]`: The list of requested modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data.
    - `[ResultInfoCode <Int32?>]`: The result code.
    - `[ResultInfoMessage <String>]`: The message.
    - `[ResultInfoSubcode <Int32?>]`: The result sub-code.
    - `[SourceCountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[SourceEndpointType <String>]`: endpointType
    - `[SourceIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[SourceLanguageId <String>]`: The language culture string. Read-only.
    - `[SourceRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
    - `[State <String>]`: 
    - `[Subject <String>]`: The subject of the conversation.
    - `[Targets <IMicrosoftGraphInvitationParticipantInfo1[]>]`: The targets of the call. Required information for creating peer to peer call.
      - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. This call will be dropped once the participant is added.
    - `[TenantId <String>]`: 
    - `[ToneInfoSequenceId <Int64?>]`: An incremental identifier used for ordering DTMF events.
    - `[ToneInfoTone <String>]`: tone
  - `[OnlineMeetings <IMicrosoftGraphOnlineMeeting1[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AudioConferencingConferenceId <String>]`: 
    - `[AudioConferencingDialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
    - `[AudioConferencingTollFreeNumber <String>]`: The toll-free number that connects to the Audio Conference Provider.
    - `[AudioConferencingTollNumber <String>]`: The toll number that connects to the Audio Conference Provider.
    - `[ChatInfoMessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
    - `[ChatInfoReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ChatInfoThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
    - `[CreationDateTime <DateTime?>]`: The meeting creation time in UTC. Read-only.
    - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
    - `[JoinWebUrl <String>]`: The join URL of the online meeting. Read-only.
    - `[OrganizerIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[OrganizerUpn <String>]`: User principal name of the participant.
    - `[ParticipantAttendees <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
      - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Upn <String>]`: User principal name of the participant.
    - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
    - `[Subject <String>]`: The subject of the online meeting.
    - `[VideoTeleconferenceId <String>]`: The video teleconferencing ID. Read-only.

CALLS <IMicrosoftGraphCall1[]>: .
  - `[Id <String>]`: Read-only.
  - `[CallChainId <String>]`: A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.
  - `[CallOptions <IMicrosoftGraphCallOptions>]`: callOptions
  - `[CallRoutes <IMicrosoftGraphCallRoute[]>]`: The routing information on how the call was retargeted. Read-only.
    - `[Final <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Original <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[RoutingType <String>]`: routingType
  - `[CallbackUri <String>]`: The callback URL on which callbacks will be delivered. Must be https.
  - `[ChatInfoMessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
  - `[ChatInfoReplyChainMessageId <String>]`: The ID of the reply message.
  - `[ChatInfoThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[Direction <String>]`: callDirection
  - `[IncomingContextObservedParticipantId <String>]`: The ID of the participant that is under observation. Read-only.
  - `[IncomingContextOnBehalfOf <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[IncomingContextSourceParticipantId <String>]`: The ID of the participant that triggered the incoming call. Read-only.
  - `[IncomingContextTransferor <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[MediaConfigRemoveFromDefaultAudioGroup <Boolean?>]`: 
  - `[MediaStateAudio <String>]`: mediaState
  - `[MeetingInfoAllowConversationWithoutHost <Boolean?>]`: 
  - `[MyParticipantId <String>]`: Read-only.
  - `[Operations <IMicrosoftGraphCommsOperation1[]>]`: Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ClientContext <String>]`: Unique Client Context string. Max limit is 256 chars.
    - `[ResultInfoCode <Int32?>]`: The result code.
    - `[ResultInfoMessage <String>]`: The message.
    - `[ResultInfoSubcode <Int32?>]`: The result sub-code.
    - `[Status <String>]`: operationStatus
  - `[Participants <IMicrosoftGraphParticipant1[]>]`: Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[InfoCountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[InfoEndpointType <String>]`: endpointType
    - `[InfoIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[InfoLanguageId <String>]`: The language culture string. Read-only.
    - `[InfoRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
    - `[IsInLobby <Boolean?>]`: true if the participant is in lobby.
    - `[IsMuted <Boolean?>]`: true if the participant is muted (client or server muted).
    - `[MediaStreams <IMicrosoftGraphMediaStream1[]>]`: The list of media streams.
      - `[Direction <String>]`: mediaDirection
      - `[Label <String>]`: The media stream label.
      - `[MediaType <String>]`: 
      - `[ServerMuted <Boolean?>]`: If the media is muted by the server.
      - `[SourceId <String>]`: The source ID.
    - `[RecordingInfoInitiator <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[RecordingInfoRecordingStatus <String>]`: recordingStatus
  - `[RequestedModalities <String[]>]`: The list of requested modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data.
  - `[ResultInfoCode <Int32?>]`: The result code.
  - `[ResultInfoMessage <String>]`: The message.
  - `[ResultInfoSubcode <Int32?>]`: The result sub-code.
  - `[SourceCountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
  - `[SourceEndpointType <String>]`: endpointType
  - `[SourceIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[SourceLanguageId <String>]`: The language culture string. Read-only.
  - `[SourceRegion <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
  - `[State <String>]`: 
  - `[Subject <String>]`: The subject of the conversation.
  - `[Targets <IMicrosoftGraphInvitationParticipantInfo1[]>]`: The targets of the call. Required information for creating peer to peer call.
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. This call will be dropped once the participant is added.
  - `[TenantId <String>]`: 
  - `[ToneInfoSequenceId <Int64?>]`: An incremental identifier used for ordering DTMF events.
  - `[ToneInfoTone <String>]`: tone

ONLINEMEETINGS <IMicrosoftGraphOnlineMeeting1[]>: .
  - `[Id <String>]`: Read-only.
  - `[AudioConferencingConferenceId <String>]`: 
  - `[AudioConferencingDialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
  - `[AudioConferencingTollFreeNumber <String>]`: The toll-free number that connects to the Audio Conference Provider.
  - `[AudioConferencingTollNumber <String>]`: The toll number that connects to the Audio Conference Provider.
  - `[ChatInfoMessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
  - `[ChatInfoReplyChainMessageId <String>]`: The ID of the reply message.
  - `[ChatInfoThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[CreationDateTime <DateTime?>]`: The meeting creation time in UTC. Read-only.
  - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
  - `[JoinWebUrl <String>]`: The join URL of the online meeting. Read-only.
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
  - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
  - `[Subject <String>]`: The subject of the online meeting.
  - `[VideoTeleconferenceId <String>]`: The video teleconferencing ID. Read-only.

## RELATED LINKS

