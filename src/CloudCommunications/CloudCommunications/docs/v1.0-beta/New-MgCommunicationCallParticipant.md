---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/new-mgcommunicationcallparticipant
schema: 2.0.0
---

# New-MgCommunicationCallParticipant

## SYNOPSIS
Create new navigation property to participants for communications

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgCommunicationCallParticipant -CallId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Info <IMicrosoftGraphParticipantInfo1>] [-IsIdentityAnonymized] [-IsInLobby] [-IsMuted]
 [-MediaStreams <IMicrosoftGraphMediaStream1[]>] [-Metadata <String>]
 [-RecordingInfo <IMicrosoftGraphRecordingInfo1>] [-RemovedState <IMicrosoftGraphRemovedState>]
 [-RestrictedExperience <IMicrosoftGraphOnlineMeetingRestricted>] [-RosterSequenceNumber <Int64>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgCommunicationCallParticipant -CallId <String> -BodyParameter <IMicrosoftGraphParticipant1> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgCommunicationCallParticipant -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IMicrosoftGraphParticipant1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgCommunicationCallParticipant -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-Info <IMicrosoftGraphParticipantInfo1>]
 [-IsIdentityAnonymized] [-IsInLobby] [-IsMuted] [-MediaStreams <IMicrosoftGraphMediaStream1[]>]
 [-Metadata <String>] [-RecordingInfo <IMicrosoftGraphRecordingInfo1>]
 [-RemovedState <IMicrosoftGraphRemovedState>]
 [-RestrictedExperience <IMicrosoftGraphOnlineMeetingRestricted>] [-RosterSequenceNumber <Int64>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to participants for communications

## EXAMPLES

### Example 1: Code snippet
```powershell
Import-Module Microsoft.Graph.CloudCommunications

Get-MgCommunicationCallParticipant -CallId $callId
```

This example shows how to use the New-MgCommunicationCallParticipant Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
participant
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParticipant1
Parameter Sets: Create1, CreateViaIdentity1
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
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Info
participantInfo
To construct, please use Get-Help -Online and see NOTES section for INFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParticipantInfo1
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MediaStreams
The list of media streams.
To construct, please use Get-Help -Online and see NOTES section for MEDIASTREAMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMediaStream1[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecordingInfo
recordingInfo
To construct, please use Get-Help -Online and see NOTES section for RECORDINGINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecordingInfo1
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemovedState
removedState
To construct, please use Get-Help -Online and see NOTES section for REMOVEDSTATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRemovedState
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestrictedExperience
onlineMeetingRestricted
To construct, please use Get-Help -Online and see NOTES section for RESTRICTEDEXPERIENCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnlineMeetingRestricted
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RosterSequenceNumber
.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParticipant1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParticipant1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphParticipant1>: participant
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Info <IMicrosoftGraphParticipantInfo1>]`: participantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LanguageId <String>]`: The language culture string. Read-only.
    - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
    - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
    - `[Region <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location, unlike countryCode. Read-only.
  - `[IsIdentityAnonymized <Boolean?>]`: 
  - `[IsInLobby <Boolean?>]`: true if the participant is in lobby.
  - `[IsMuted <Boolean?>]`: true if the participant is muted (client or server muted).
  - `[MediaStreams <IMicrosoftGraphMediaStream1[]>]`: The list of media streams.
    - `[Direction <String>]`: mediaDirection
    - `[Label <String>]`: The media stream label.
    - `[MediaType <String>]`: 
    - `[ServerMuted <Boolean?>]`: Indicates whether the media is muted by the server.
    - `[SourceId <String>]`: The source ID.
  - `[Metadata <String>]`: A blob of data provided by the participant in the roster.
  - `[RecordingInfo <IMicrosoftGraphRecordingInfo1>]`: recordingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[InitiatedBy <IMicrosoftGraphParticipantInfo1>]`: participantInfo
    - `[Initiator <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[RecordingStatus <String>]`: recordingStatus
  - `[RemovedState <IMicrosoftGraphRemovedState>]`: removedState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Reason <String>]`: 
  - `[RestrictedExperience <IMicrosoftGraphOnlineMeetingRestricted>]`: onlineMeetingRestricted
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentSharingDisabled <String>]`: onlineMeetingContentSharingDisabledReason
    - `[VideoDisabled <String>]`: onlineMeetingVideoDisabledReason
  - `[RosterSequenceNumber <Int64?>]`: 

INFO <IMicrosoftGraphParticipantInfo1>: participantInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
  - `[EndpointType <String>]`: endpointType
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LanguageId <String>]`: The language culture string. Read-only.
  - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
  - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
  - `[Region <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location, unlike countryCode. Read-only.

INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[AudioRoutingGroupId <String>]`: The unique identifier of audioRoutingGroup
  - `[CallId <String>]`: The unique identifier of call
  - `[CallRecordId <String>]`: The unique identifier of callRecord
  - `[CallTranscriptId <String>]`: The unique identifier of callTranscript
  - `[CommsOperationId <String>]`: The unique identifier of commsOperation
  - `[ContentSharingSessionId <String>]`: The unique identifier of contentSharingSession
  - `[FromDateTime <DateTime?>]`: Usage: fromDateTime={fromDateTime}
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[MeetingRegistrationQuestionId <String>]`: The unique identifier of meetingRegistrationQuestion
  - `[OnlineMeetingId <String>]`: The unique identifier of onlineMeeting
  - `[ParticipantId <String>]`: The unique identifier of participant
  - `[PresenceId <String>]`: The unique identifier of presence
  - `[SessionId <String>]`: The unique identifier of session
  - `[ToDateTime <DateTime?>]`: Usage: toDateTime={toDateTime}
  - `[UserId <String>]`: The unique identifier of user

MEDIASTREAMS <IMicrosoftGraphMediaStream1[]>: The list of media streams.
  - `[Direction <String>]`: mediaDirection
  - `[Label <String>]`: The media stream label.
  - `[MediaType <String>]`: 
  - `[ServerMuted <Boolean?>]`: Indicates whether the media is muted by the server.
  - `[SourceId <String>]`: The source ID.

RECORDINGINFO <IMicrosoftGraphRecordingInfo1>: recordingInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[InitiatedBy <IMicrosoftGraphParticipantInfo1>]`: participantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LanguageId <String>]`: The language culture string. Read-only.
    - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
    - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
    - `[Region <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location, unlike countryCode. Read-only.
  - `[Initiator <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[RecordingStatus <String>]`: recordingStatus

REMOVEDSTATE <IMicrosoftGraphRemovedState>: removedState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Reason <String>]`: 

RESTRICTEDEXPERIENCE <IMicrosoftGraphOnlineMeetingRestricted>: onlineMeetingRestricted
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentSharingDisabled <String>]`: onlineMeetingContentSharingDisabledReason
  - `[VideoDisabled <String>]`: onlineMeetingVideoDisabledReason

## RELATED LINKS

