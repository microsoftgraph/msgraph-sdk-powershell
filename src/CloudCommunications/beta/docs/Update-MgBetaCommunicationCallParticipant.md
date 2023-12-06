---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.cloudcommunications/update-mgbetacommunicationcallparticipant
schema: 2.0.0
---

# Update-MgBetaCommunicationCallParticipant

## SYNOPSIS
Update the navigation property participants in communications

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaCommunicationCallParticipant -CallId <String> -ParticipantId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-Info <IMicrosoftGraphParticipantInfo>]
 [-IsIdentityAnonymized] [-IsInLobby] [-IsMuted] [-MediaStreams <IMicrosoftGraphMediaStream[]>]
 [-Metadata <String>] [-PreferredDisplayName <String>] [-RecordingInfo <IMicrosoftGraphRecordingInfo>]
 [-RemovedState <IMicrosoftGraphRemovedState>]
 [-RestrictedExperience <IMicrosoftGraphOnlineMeetingRestricted>] [-RosterSequenceNumber <Int64>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaCommunicationCallParticipant -CallId <String> -ParticipantId <String>
 -BodyParameter <IMicrosoftGraphParticipant> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaCommunicationCallParticipant -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IMicrosoftGraphParticipant> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaCommunicationCallParticipant -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-Info <IMicrosoftGraphParticipantInfo>]
 [-IsIdentityAnonymized] [-IsInLobby] [-IsMuted] [-MediaStreams <IMicrosoftGraphMediaStream[]>]
 [-Metadata <String>] [-PreferredDisplayName <String>] [-RecordingInfo <IMicrosoftGraphRecordingInfo>]
 [-RemovedState <IMicrosoftGraphRemovedState>]
 [-RestrictedExperience <IMicrosoftGraphOnlineMeetingRestricted>] [-RosterSequenceNumber <Int64>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property participants in communications

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
participant
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphParticipant
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CallId
The unique identifier of call

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

### -Info
participantInfo
To construct, see NOTES section for INFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphParticipantInfo
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
Type: Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsIdentityAnonymized
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
```

### -IsInLobby
true if the participant is in lobby.

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

### -IsMuted
true if the participant is muted (client or server muted).

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

### -MediaStreams
The list of media streams.
To construct, see NOTES section for MEDIASTREAMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMediaStream[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Metadata
A blob of data provided by the participant in the roster.

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

### -ParticipantId
The unique identifier of participant

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

### -PreferredDisplayName
The participant's preferred display name that overrides the original display name.

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

### -RecordingInfo
recordingInfo
To construct, see NOTES section for RECORDINGINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecordingInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemovedState
removedState
To construct, see NOTES section for REMOVEDSTATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRemovedState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestrictedExperience
onlineMeetingRestricted
To construct, see NOTES section for RESTRICTEDEXPERIENCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnlineMeetingRestricted
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RosterSequenceNumber
Indicates the roster sequence number the participant was last updated in.

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

### Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphParticipant

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphParticipant

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphParticipant>`: participant
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Info <IMicrosoftGraphParticipantInfo>]`: participantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LanguageId <String>]`: The language culture string. Read-only.
    - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
    - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
    - `[Region <String>]`: The home region of the participant, and can be a country, a continent, or a larger geographic region. The region doesn't change based on the participant's current physical location, unlike countryCode. Read-only.
  - `[IsIdentityAnonymized <Boolean?>]`: 
  - `[IsInLobby <Boolean?>]`: true if the participant is in lobby.
  - `[IsMuted <Boolean?>]`: true if the participant is muted (client or server muted).
  - `[MediaStreams <IMicrosoftGraphMediaStream[]>]`: The list of media streams.
    - `[Direction <String>]`: mediaDirection
    - `[Label <String>]`: The media stream label.
    - `[MediaType <String>]`: modality
    - `[ServerMuted <Boolean?>]`: Indicates whether the server has muted the media.
    - `[SourceId <String>]`: The source ID.
  - `[Metadata <String>]`: A blob of data provided by the participant in the roster.
  - `[PreferredDisplayName <String>]`: The participant's preferred display name that overrides the original display name.
  - `[RecordingInfo <IMicrosoftGraphRecordingInfo>]`: recordingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[InitiatedBy <IMicrosoftGraphParticipantInfo>]`: participantInfo
    - `[Initiator <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[RecordingStatus <String>]`: recordingStatus
  - `[RemovedState <IMicrosoftGraphRemovedState>]`: removedState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Reason <String>]`: The removal reason for the participant resource.
  - `[RestrictedExperience <IMicrosoftGraphOnlineMeetingRestricted>]`: onlineMeetingRestricted
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentSharingDisabled <String>]`: onlineMeetingContentSharingDisabledReason
    - `[VideoDisabled <String>]`: onlineMeetingVideoDisabledReason
  - `[RosterSequenceNumber <Int64?>]`: Indicates the roster sequence number the participant was last updated in.

`INFO <IMicrosoftGraphParticipantInfo>`: participantInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
  - `[EndpointType <String>]`: endpointType
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LanguageId <String>]`: The language culture string. Read-only.
  - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
  - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
  - `[Region <String>]`: The home region of the participant, and can be a country, a continent, or a larger geographic region. The region doesn't change based on the participant's current physical location, unlike countryCode. Read-only.

`INPUTOBJECT <ICloudCommunicationsIdentity>`: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[AudioRoutingGroupId <String>]`: The unique identifier of audioRoutingGroup
  - `[CallId <String>]`: The unique identifier of call
  - `[CallRecordId <String>]`: The unique identifier of callRecord
  - `[CallRecordingId <String>]`: The unique identifier of callRecording
  - `[CallTranscriptId <String>]`: The unique identifier of callTranscript
  - `[CommsOperationId <String>]`: The unique identifier of commsOperation
  - `[ContentSharingSessionId <String>]`: The unique identifier of contentSharingSession
  - `[FromDateTime <DateTime?>]`: Usage: fromDateTime={fromDateTime}
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[MeetingRegistrantBaseId <String>]`: The unique identifier of meetingRegistrantBase
  - `[MeetingRegistrationQuestionId <String>]`: The unique identifier of meetingRegistrationQuestion
  - `[OnlineMeetingId <String>]`: The unique identifier of onlineMeeting
  - `[ParticipantId <String>]`: The unique identifier of participant
  - `[PresenceId <String>]`: The unique identifier of presence
  - `[SessionId <String>]`: The unique identifier of session
  - `[ToDateTime <DateTime?>]`: Usage: toDateTime={toDateTime}
  - `[UserId <String>]`: The unique identifier of user

`MEDIASTREAMS <IMicrosoftGraphMediaStream[]>`: The list of media streams.
  - `[Direction <String>]`: mediaDirection
  - `[Label <String>]`: The media stream label.
  - `[MediaType <String>]`: modality
  - `[ServerMuted <Boolean?>]`: Indicates whether the server has muted the media.
  - `[SourceId <String>]`: The source ID.

`RECORDINGINFO <IMicrosoftGraphRecordingInfo>`: recordingInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[InitiatedBy <IMicrosoftGraphParticipantInfo>]`: participantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LanguageId <String>]`: The language culture string. Read-only.
    - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
    - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
    - `[Region <String>]`: The home region of the participant, and can be a country, a continent, or a larger geographic region. The region doesn't change based on the participant's current physical location, unlike countryCode. Read-only.
  - `[Initiator <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[RecordingStatus <String>]`: recordingStatus

`REMOVEDSTATE <IMicrosoftGraphRemovedState>`: removedState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Reason <String>]`: The removal reason for the participant resource.

`RESTRICTEDEXPERIENCE <IMicrosoftGraphOnlineMeetingRestricted>`: onlineMeetingRestricted
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentSharingDisabled <String>]`: onlineMeetingContentSharingDisabledReason
  - `[VideoDisabled <String>]`: onlineMeetingVideoDisabledReason

## RELATED LINKS

