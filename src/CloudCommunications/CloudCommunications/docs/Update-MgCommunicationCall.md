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

### UpdateExpanded (Default)
```
Update-MgCommunicationCall -CallId <String> [-ActiveModalities <String[]>] [-AnsweredByCountryCode <String>]
 [-AnsweredByEndpointType <String>] [-AnsweredByIdentity <IMicrosoftGraphIdentitySet>]
 [-AnsweredByLanguageId <String>] [-AnsweredByRegion <String>]
 [-AudioRoutingGroups <IMicrosoftGraphAudioRoutingGroup[]>] [-CallbackUri <String>]
 [-CallOptions <IMicrosoftGraphCallOptions>] [-CallRoutes <IMicrosoftGraphCallRoute[]>]
 [-ChatInfoMessageId <String>] [-ChatInfoReplyChainMessageId <String>] [-ChatInfoThreadId <String>]
 [-Direction <String>] [-Id <String>] [-IncomingContextObservedParticipantId <String>]
 [-IncomingContextOnBehalfOf <IMicrosoftGraphIdentitySet>] [-IncomingContextSourceParticipantId <String>]
 [-IncomingContextTransferor <IMicrosoftGraphIdentitySet>] [-MediaConfigRemoveFromDefaultAudioGroup]
 [-MediaStateAudio <String>] [-MeetingCapabilityAllowAnonymousUsersToDialOut]
 [-MeetingCapabilityAllowAnonymousUsersToStartMeeting] [-MeetingCapabilityAutoAdmittedUsers <String>]
 [-MeetingInfoAllowConversationWithoutHost] [-MyParticipantId <String>]
 [-Operations <IMicrosoftGraphCommsOperation[]>] [-Participants <IMicrosoftGraphParticipant[]>]
 [-RequestedModalities <String[]>] [-ResultInfoCode <Int32>] [-ResultInfoMessage <String>]
 [-ResultInfoSubcode <Int32>] [-RingingTimeoutInSeconds <Int32>] [-RoutingPolicies <String[]>]
 [-SourceCountryCode <String>] [-SourceEndpointType <String>] [-SourceIdentity <IMicrosoftGraphIdentitySet>]
 [-SourceLanguageId <String>] [-SourceRegion <String>] [-State <String>] [-Subject <String>]
 [-Targets <IMicrosoftGraphInvitationParticipantInfo[]>] [-TenantId <String>] [-TerminationReason <String>]
 [-ToneInfoSequenceId <Int64>] [-ToneInfoTone <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgCommunicationCall -CallId <String> -BodyParameter <IMicrosoftGraphCall> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgCommunicationCall -InputObject <ICloudCommunicationsIdentity> -BodyParameter <IMicrosoftGraphCall>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgCommunicationCall -InputObject <ICloudCommunicationsIdentity> [-ActiveModalities <String[]>]
 [-AnsweredByCountryCode <String>] [-AnsweredByEndpointType <String>]
 [-AnsweredByIdentity <IMicrosoftGraphIdentitySet>] [-AnsweredByLanguageId <String>]
 [-AnsweredByRegion <String>] [-AudioRoutingGroups <IMicrosoftGraphAudioRoutingGroup[]>]
 [-CallbackUri <String>] [-CallOptions <IMicrosoftGraphCallOptions>]
 [-CallRoutes <IMicrosoftGraphCallRoute[]>] [-ChatInfoMessageId <String>]
 [-ChatInfoReplyChainMessageId <String>] [-ChatInfoThreadId <String>] [-Direction <String>] [-Id <String>]
 [-IncomingContextObservedParticipantId <String>] [-IncomingContextOnBehalfOf <IMicrosoftGraphIdentitySet>]
 [-IncomingContextSourceParticipantId <String>] [-IncomingContextTransferor <IMicrosoftGraphIdentitySet>]
 [-MediaConfigRemoveFromDefaultAudioGroup] [-MediaStateAudio <String>]
 [-MeetingCapabilityAllowAnonymousUsersToDialOut] [-MeetingCapabilityAllowAnonymousUsersToStartMeeting]
 [-MeetingCapabilityAutoAdmittedUsers <String>] [-MeetingInfoAllowConversationWithoutHost]
 [-MyParticipantId <String>] [-Operations <IMicrosoftGraphCommsOperation[]>]
 [-Participants <IMicrosoftGraphParticipant[]>] [-RequestedModalities <String[]>] [-ResultInfoCode <Int32>]
 [-ResultInfoMessage <String>] [-ResultInfoSubcode <Int32>] [-RingingTimeoutInSeconds <Int32>]
 [-RoutingPolicies <String[]>] [-SourceCountryCode <String>] [-SourceEndpointType <String>]
 [-SourceIdentity <IMicrosoftGraphIdentitySet>] [-SourceLanguageId <String>] [-SourceRegion <String>]
 [-State <String>] [-Subject <String>] [-Targets <IMicrosoftGraphInvitationParticipantInfo[]>]
 [-TenantId <String>] [-TerminationReason <String>] [-ToneInfoSequenceId <Int64>] [-ToneInfoTone <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
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

### -ActiveModalities
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AnsweredByCountryCode
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
Dynamic: False
```

### -AnsweredByEndpointType
endpointType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AnsweredByIdentity
identitySet
To construct, see NOTES section for ANSWEREDBYIDENTITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AnsweredByLanguageId
The language culture string.
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
Dynamic: False
```

### -AnsweredByRegion
The home region of the participant.
This can be a country, a continent, or a larger geographic region.
This does not change based on the participant's current physical location.
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
Dynamic: False
```

### -AudioRoutingGroups
.
To construct, see NOTES section for AUDIOROUTINGGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAudioRoutingGroup[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
call
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCall
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CallbackUri
The callback URL on which callbacks will be delivered.
Must be https.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CallId
key: call-id of call

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CallOptions
callOptions

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallOptions
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CallRoutes
.
To construct, see NOTES section for CALLROUTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCallRoute[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ChatInfoMessageId
The unique identifier of a message in a Microsoft Teams channel.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ChatInfoReplyChainMessageId
The ID of the reply message.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ChatInfoThreadId
The unique identifier for a thread in Microsoft Teams.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Direction
callDirection

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IncomingContextObservedParticipantId
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
Dynamic: False
```

### -IncomingContextOnBehalfOf
identitySet
To construct, see NOTES section for INCOMINGCONTEXTONBEHALFOF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IncomingContextSourceParticipantId
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
Dynamic: False
```

### -IncomingContextTransferor
identitySet
To construct, see NOTES section for INCOMINGCONTEXTTRANSFEROR properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -MediaConfigRemoveFromDefaultAudioGroup
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MediaStateAudio
mediaState

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MeetingCapabilityAllowAnonymousUsersToDialOut
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MeetingCapabilityAllowAnonymousUsersToStartMeeting
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MeetingCapabilityAutoAdmittedUsers
autoAdmittedUsersType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MeetingInfoAllowConversationWithoutHost
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MyParticipantId
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
Dynamic: False
```

### -Operations
Read-only.
Nullable.
To construct, see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCommsOperation[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Participants
Read-only.
Nullable.
To construct, see NOTES section for PARTICIPANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParticipant[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -RequestedModalities
The list of requested modalities.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResultInfoCode
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResultInfoMessage
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
Dynamic: False
```

### -ResultInfoSubcode
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RingingTimeoutInSeconds
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoutingPolicies
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceCountryCode
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
Dynamic: False
```

### -SourceEndpointType
endpointType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceIdentity
identitySet
To construct, see NOTES section for SOURCEIDENTITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceLanguageId
The language culture string.
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
Dynamic: False
```

### -SourceRegion
The home region of the participant.
This can be a country, a continent, or a larger geographic region.
This does not change based on the participant's current physical location.
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
Dynamic: False
```

### -State
callState

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Subject
The subject of the conversation.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Targets
The targets of the call.
Required information for creating peer to peer call.
To construct, see NOTES section for TARGETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TenantId
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
Dynamic: False
```

### -TerminationReason
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
Dynamic: False
```

### -ToneInfoSequenceId
An incremental identifier used for ordering DTMF events.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ToneInfoTone
tone

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCall

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ANSWEREDBYIDENTITY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

#### AUDIOROUTINGGROUPS <IMicrosoftGraphAudioRoutingGroup[]>: .
  - `[Id <String>]`: Read-only.
  - `[Receivers <String[]>]`: 
  - `[RoutingMode <String>]`: routingMode
  - `[Sources <String[]>]`: 

#### BODYPARAMETER <IMicrosoftGraphCall>: call
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

#### CALLROUTES <IMicrosoftGraphCallRoute[]>: .
  - `[Final <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Original <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[RoutingType <String>]`: routingType

#### INCOMINGCONTEXTONBEHALFOF <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

#### INCOMINGCONTEXTTRANSFEROR <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

#### INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AudioRoutingGroupId <String>]`: key: audioRoutingGroup-id of audioRoutingGroup
  - `[CallId <String>]`: key: call-id of call
  - `[CallRecordId <String>]`: key: callRecord-id of callRecord
  - `[CommsOperationId <String>]`: key: commsOperation-id of commsOperation
  - `[OnlineMeetingId <String>]`: key: onlineMeeting-id of onlineMeeting
  - `[ParticipantId <String>]`: key: participant-id of participant
  - `[SegmentId <String>]`: key: segment-id of segment
  - `[SessionId <String>]`: key: session-id of session

#### OPERATIONS <IMicrosoftGraphCommsOperation[]>: Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[ClientContext <String>]`: Unique Client Context string. Max limit is 256 chars.
  - `[ResultInfoCode <Int32?>]`: 
  - `[ResultInfoMessage <String>]`: 
  - `[ResultInfoSubcode <Int32?>]`: 
  - `[Status <String>]`: operationStatus

#### PARTICIPANTS <IMicrosoftGraphParticipant[]>: Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[InfoCountryCode <String>]`: 
  - `[InfoEndpointType <String>]`: endpointType
  - `[InfoIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
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

#### SOURCEIDENTITY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

#### TARGETS <IMicrosoftGraphInvitationParticipantInfo[]>: The targets of the call. Required information for creating peer to peer call.
  - `[EndpointType <String>]`: endpointType
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. This call will be dropped once the participant is added.

## RELATED LINKS

