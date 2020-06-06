---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/update-mgcommunicationcall
schema: 2.0.0
---

# Update-MgCommunicationCall

## SYNOPSIS
Update the navigation property calls in communications

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgCommunicationCall -CallId <String> [-CallbackUri <String>] [-CallChainId <String>]
 [-CallOptions <IMicrosoftGraphCallOptions>] [-CallRoutes <IMicrosoftGraphCallRoute[]>]
 [-ChatInfoMessageId <String>] [-ChatInfoReplyChainMessageId <String>] [-ChatInfoThreadId <String>]
 [-Direction <String>] [-Id <String>] [-IncomingContextObservedParticipantId <String>]
 [-IncomingContextOnBehalfOf <IMicrosoftGraphIdentitySet>] [-IncomingContextSourceParticipantId <String>]
 [-IncomingContextTransferor <IMicrosoftGraphIdentitySet>] [-MediaConfigRemoveFromDefaultAudioGroup]
 [-MediaStateAudio <String>] [-MeetingInfoAllowConversationWithoutHost] [-MyParticipantId <String>]
 [-Operations <IMicrosoftGraphCommsOperation1[]>] [-Participants <IMicrosoftGraphParticipant1[]>]
 [-RequestedModalities <String[]>] [-ResultInfoCode <Int32>] [-ResultInfoMessage <String>]
 [-ResultInfoSubcode <Int32>] [-SourceCountryCode <String>] [-SourceEndpointType <String>]
 [-SourceIdentity <IMicrosoftGraphIdentitySet>] [-SourceLanguageId <String>] [-SourceRegion <String>]
 [-State <String>] [-Subject <String>] [-Targets <IMicrosoftGraphInvitationParticipantInfo1[]>]
 [-TenantId <String>] [-ToneInfoSequenceId <Int64>] [-ToneInfoTone <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgCommunicationCall -CallId <String> -BodyParameter <IMicrosoftGraphCall1> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgCommunicationCall -InputObject <ICloudCommunicationsIdentity> -BodyParameter <IMicrosoftGraphCall1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgCommunicationCall -InputObject <ICloudCommunicationsIdentity> [-CallbackUri <String>]
 [-CallChainId <String>] [-CallOptions <IMicrosoftGraphCallOptions>]
 [-CallRoutes <IMicrosoftGraphCallRoute[]>] [-ChatInfoMessageId <String>]
 [-ChatInfoReplyChainMessageId <String>] [-ChatInfoThreadId <String>] [-Direction <String>] [-Id <String>]
 [-IncomingContextObservedParticipantId <String>] [-IncomingContextOnBehalfOf <IMicrosoftGraphIdentitySet>]
 [-IncomingContextSourceParticipantId <String>] [-IncomingContextTransferor <IMicrosoftGraphIdentitySet>]
 [-MediaConfigRemoveFromDefaultAudioGroup] [-MediaStateAudio <String>]
 [-MeetingInfoAllowConversationWithoutHost] [-MyParticipantId <String>]
 [-Operations <IMicrosoftGraphCommsOperation1[]>] [-Participants <IMicrosoftGraphParticipant1[]>]
 [-RequestedModalities <String[]>] [-ResultInfoCode <Int32>] [-ResultInfoMessage <String>]
 [-ResultInfoSubcode <Int32>] [-SourceCountryCode <String>] [-SourceEndpointType <String>]
 [-SourceIdentity <IMicrosoftGraphIdentitySet>] [-SourceLanguageId <String>] [-SourceRegion <String>]
 [-State <String>] [-Subject <String>] [-Targets <IMicrosoftGraphInvitationParticipantInfo1[]>]
 [-TenantId <String>] [-ToneInfoSequenceId <Int64>] [-ToneInfoTone <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property calls in communications

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
call
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCall1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CallbackUri
The callback URL on which callbacks will be delivered.
Must be https.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallChainId
A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.
This needs to be copied over from Microsoft.Graph.Call.CallChainId.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallId
key: call-id of call

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallOptions
callOptions

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallOptions
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallRoutes
The routing information on how the call was retargeted.
Read-only.
To construct, see NOTES section for CALLROUTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRoute[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChatInfoMessageId
The unique identifier of a message in a Microsoft Teams channel.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChatInfoReplyChainMessageId
The ID of the reply message.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChatInfoThreadId
The unique identifier for a thread in Microsoft Teams.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Direction
callDirection

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncomingContextObservedParticipantId
The ID of the participant that is under observation.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncomingContextOnBehalfOf
identitySet
To construct, see NOTES section for INCOMINGCONTEXTONBEHALFOF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncomingContextSourceParticipantId
The ID of the participant that triggered the incoming call.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncomingContextTransferor
identitySet
To construct, see NOTES section for INCOMINGCONTEXTTRANSFEROR properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MediaConfigRemoveFromDefaultAudioGroup
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MediaStateAudio
mediaState

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MeetingInfoAllowConversationWithoutHost
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MyParticipantId
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Operations
Read-only.
Nullable.
To construct, see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCommsOperation1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Participants
Read-only.
Nullable.
To construct, see NOTES section for PARTICIPANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParticipant1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -RequestedModalities
The list of requested modalities.
Possible values are: unknown, audio, video, videoBasedScreenSharing, data.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResultInfoCode
The result code.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResultInfoMessage
The message.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResultInfoSubcode
The result sub-code.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceCountryCode
The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceEndpointType
endpointType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceIdentity
identitySet
To construct, see NOTES section for SOURCEIDENTITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceLanguageId
The language culture string.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceRegion
The home region of the participant.
This can be a country, a continent, or a larger geographic region.
This does not change based on the participant's current physical location.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
The subject of the conversation.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Targets
The targets of the call.
Required information for creating peer to peer call.
To construct, see NOTES section for TARGETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToneInfoSequenceId
An incremental identifier used for ordering DTMF events.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToneInfoTone
tone

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCall1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCall1>: call
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

CALLROUTES <IMicrosoftGraphCallRoute[]>: The routing information on how the call was retargeted. Read-only.
  - `[Final <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Original <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[RoutingType <String>]`: routingType

INCOMINGCONTEXTONBEHALFOF <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

INCOMINGCONTEXTTRANSFEROR <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AudioRoutingGroupId <String>]`: key: audioRoutingGroup-id of audioRoutingGroup
  - `[CallId <String>]`: key: call-id of call
  - `[CallRecordId <String>]`: key: callRecord-id of callRecord
  - `[CommsOperationId <String>]`: key: commsOperation-id of commsOperation
  - `[OnlineMeetingId <String>]`: key: onlineMeeting-id of onlineMeeting
  - `[ParticipantId <String>]`: key: participant-id of participant
  - `[SegmentId <String>]`: key: segment-id of segment
  - `[SessionId <String>]`: key: session-id of session

OPERATIONS <IMicrosoftGraphCommsOperation1[]>: Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[ClientContext <String>]`: Unique Client Context string. Max limit is 256 chars.
  - `[ResultInfoCode <Int32?>]`: The result code.
  - `[ResultInfoMessage <String>]`: The message.
  - `[ResultInfoSubcode <Int32?>]`: The result sub-code.
  - `[Status <String>]`: operationStatus

PARTICIPANTS <IMicrosoftGraphParticipant1[]>: Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[InfoCountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
  - `[InfoEndpointType <String>]`: endpointType
  - `[InfoIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
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

SOURCEIDENTITY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

TARGETS <IMicrosoftGraphInvitationParticipantInfo1[]>: The targets of the call. Required information for creating peer to peer call.
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. This call will be dropped once the participant is added.

## RELATED LINKS

