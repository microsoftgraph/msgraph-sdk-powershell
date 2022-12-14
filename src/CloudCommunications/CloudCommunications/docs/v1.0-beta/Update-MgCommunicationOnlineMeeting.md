---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.cloudcommunications/update-mgcommunicationonlinemeeting
schema: 2.0.0
---

# Update-MgBetaCommunicationOnlineMeeting

## SYNOPSIS
Update the navigation property onlineMeetings in communications

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgBetaCommunicationOnlineMeeting -OnlineMeetingId <String> [-AdditionalProperties <Hashtable>]
 [-AllowAttendeeToEnableCamera] [-AllowAttendeeToEnableMic] [-AllowedPresenters <String>]
 [-AllowTeamworkReactions] [-AlternativeRecordingInputFile <String>] [-AnonymizeIdentityForRoles <String[]>]
 [-AttendanceReports <IMicrosoftGraphMeetingAttendanceReport1[]>] [-AttendeeReportInputFile <String>]
 [-AudioConferencing <IMicrosoftGraphAudioConferencing>]
 [-BroadcastSettings <IMicrosoftGraphBroadcastMeetingSettings>] [-Capabilities <String[]>]
 [-ChatInfo <IMicrosoftGraphChatInfo>] [-CreationDateTime <DateTime>] [-EndDateTime <DateTime>]
 [-ExternalId <String>] [-Id <String>] [-IsBroadcast] [-IsEntryExitAnnounced]
 [-JoinInformation <IMicrosoftGraphItemBody>] [-JoinMeetingIdSettings <IMicrosoftGraphJoinMeetingIdSettings>]
 [-JoinUrl <String>] [-JoinWebUrl <String>] [-LobbyBypassSettings <IMicrosoftGraphLobbyBypassSettings>]
 [-MeetingAttendanceReport <IMicrosoftGraphMeetingAttendanceReport1>]
 [-Participants <IMicrosoftGraphMeetingParticipants1>] [-RecordAutomatically] [-RecordingInputFile <String>]
 [-Registration <IMicrosoftGraphMeetingRegistration>] [-StartDateTime <DateTime>] [-Subject <String>]
 [-Transcripts <IMicrosoftGraphCallTranscript[]>] [-VideoTeleconferenceId <String>]
 [-VirtualAppointment <IMicrosoftGraphVirtualAppointment>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgBetaCommunicationOnlineMeeting -OnlineMeetingId <String> -BodyParameter <IMicrosoftGraphOnlineMeeting1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgBetaCommunicationOnlineMeeting -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IMicrosoftGraphOnlineMeeting1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgBetaCommunicationOnlineMeeting -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-AllowAttendeeToEnableCamera] [-AllowAttendeeToEnableMic]
 [-AllowedPresenters <String>] [-AllowTeamworkReactions] [-AlternativeRecordingInputFile <String>]
 [-AnonymizeIdentityForRoles <String[]>] [-AttendanceReports <IMicrosoftGraphMeetingAttendanceReport1[]>]
 [-AttendeeReportInputFile <String>] [-AudioConferencing <IMicrosoftGraphAudioConferencing>]
 [-BroadcastSettings <IMicrosoftGraphBroadcastMeetingSettings>] [-Capabilities <String[]>]
 [-ChatInfo <IMicrosoftGraphChatInfo>] [-CreationDateTime <DateTime>] [-EndDateTime <DateTime>]
 [-ExternalId <String>] [-Id <String>] [-IsBroadcast] [-IsEntryExitAnnounced]
 [-JoinInformation <IMicrosoftGraphItemBody>] [-JoinMeetingIdSettings <IMicrosoftGraphJoinMeetingIdSettings>]
 [-JoinUrl <String>] [-JoinWebUrl <String>] [-LobbyBypassSettings <IMicrosoftGraphLobbyBypassSettings>]
 [-MeetingAttendanceReport <IMicrosoftGraphMeetingAttendanceReport1>]
 [-Participants <IMicrosoftGraphMeetingParticipants1>] [-RecordAutomatically] [-RecordingInputFile <String>]
 [-Registration <IMicrosoftGraphMeetingRegistration>] [-StartDateTime <DateTime>] [-Subject <String>]
 [-Transcripts <IMicrosoftGraphCallTranscript[]>] [-VideoTeleconferenceId <String>]
 [-VirtualAppointment <IMicrosoftGraphVirtualAppointment>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property onlineMeetings in communications

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowAttendeeToEnableCamera
Indicates whether attendees can turn on their camera.

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

### -AllowAttendeeToEnableMic
Indicates whether attendees can turn on their microphone.

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

### -AllowedPresenters
onlineMeetingPresenters

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

### -AllowTeamworkReactions
Indicates if Teams reactions are enabled for the meeting.

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

### -AlternativeRecordingInputFile
Input File for AlternativeRecording (The content stream of the alternative recording of a Microsoft Teams live event.
Read-only.)

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

### -AnonymizeIdentityForRoles
.

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

### -AttendanceReports
The attendance reports of an online meeting.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for ATTENDANCEREPORTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingAttendanceReport1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttendeeReportInputFile
Input File for AttendeeReport (The content stream of the attendee report of a Teams live event.
Read-only.)

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

### -AudioConferencing
audioConferencing
To construct, please use Get-Help -Online and see NOTES section for AUDIOCONFERENCING properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAudioConferencing
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
onlineMeeting
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnlineMeeting1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BroadcastSettings
broadcastMeetingSettings
To construct, please use Get-Help -Online and see NOTES section for BROADCASTSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBroadcastMeetingSettings
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Capabilities
.

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

### -ChatInfo
chatInfo
To construct, please use Get-Help -Online and see NOTES section for CHATINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphChatInfo
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreationDateTime
The meeting creation time in UTC.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
The meeting end time in UTC.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalId
The external ID.
A custom ID.
Optional.

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
The unique idenfier for an entity.
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsBroadcast
Indicates whether this is a Teams live event.

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

### -IsEntryExitAnnounced
Indicates whether to announce when callers join or leave.

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

### -JoinInformation
itemBody
To construct, please use Get-Help -Online and see NOTES section for JOININFORMATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphItemBody
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JoinMeetingIdSettings
joinMeetingIdSettings
To construct, please use Get-Help -Online and see NOTES section for JOINMEETINGIDSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphJoinMeetingIdSettings
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JoinUrl
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

### -JoinWebUrl
The join URL of the online meeting.
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

### -LobbyBypassSettings
lobbyBypassSettings
To construct, please use Get-Help -Online and see NOTES section for LOBBYBYPASSSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLobbyBypassSettings
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MeetingAttendanceReport
meetingAttendanceReport
To construct, please use Get-Help -Online and see NOTES section for MEETINGATTENDANCEREPORT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingAttendanceReport1
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineMeetingId
key: id of onlineMeeting

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

### -Participants
meetingParticipants
To construct, please use Get-Help -Online and see NOTES section for PARTICIPANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingParticipants1
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

### -RecordAutomatically
Indicates whether to record the meeting automatically.

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

### -RecordingInputFile
Input File for Recording (The content stream of the recording of a Teams live event.
Read-only.)

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

### -Registration
meetingRegistration
To construct, please use Get-Help -Online and see NOTES section for REGISTRATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingRegistration
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
The meeting start time in UTC.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
The subject of the online meeting.

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

### -Transcripts
The transcripts of an online meeting.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for TRANSCRIPTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCallTranscript[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VideoTeleconferenceId
The video teleconferencing ID.
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

### -VirtualAppointment
virtualAppointment
To construct, please use Get-Help -Online and see NOTES section for VIRTUALAPPOINTMENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphVirtualAppointment
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

### Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnlineMeeting1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ATTENDANCEREPORTS <IMicrosoftGraphMeetingAttendanceReport1[]>: The attendance reports of an online meeting. Read-only.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AttendanceRecords <IMicrosoftGraphAttendanceRecord1[]>]`: List of attendance records of an attendance report. Read-only.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AttendanceIntervals <IMicrosoftGraphAttendanceInterval[]>]`: List of time periods between joining and leaving a meeting.
      - `[DurationInSeconds <Int32?>]`: Duration of the meeting interval in seconds; that is, the difference between joinDateTime and leaveDateTime.
      - `[JoinDateTime <DateTime?>]`: The time the attendee joined in UTC.
      - `[LeaveDateTime <DateTime?>]`: The time the attendee left in UTC.
    - `[EmailAddress <String>]`: Email address of the user associated with this atttendance record.
    - `[Identity <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[RegistrantId <String>]`: Unique identifier of a meetingRegistrant. Presents when the participant has registered for the meeting.
    - `[Role <String>]`: Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.
    - `[TotalAttendanceInSeconds <Int32?>]`: Total duration of the attendances in seconds.
  - `[MeetingEndDateTime <DateTime?>]`: UTC time when the meeting ended. Read-only.
  - `[MeetingStartDateTime <DateTime?>]`: UTC time when the meeting started. Read-only.
  - `[TotalParticipantCount <Int32?>]`: Total number of participants. Read-only.

AUDIOCONFERENCING <IMicrosoftGraphAudioConferencing>: audioConferencing
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ConferenceId <String>]`: The conference id of the online meeting.
  - `[DialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
  - `[TollFreeNumber <String>]`: 
  - `[TollFreeNumbers <String[]>]`: List of toll-free numbers that are displayed in the meeting invite.
  - `[TollNumber <String>]`: 
  - `[TollNumbers <String[]>]`: List of toll numbers that are displayed in the meeting invite.

BODYPARAMETER <IMicrosoftGraphOnlineMeeting1>: onlineMeeting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AllowAttendeeToEnableCamera <Boolean?>]`: Indicates whether attendees can turn on their camera.
  - `[AllowAttendeeToEnableMic <Boolean?>]`: Indicates whether attendees can turn on their microphone.
  - `[AllowTeamworkReactions <Boolean?>]`: Indicates if Teams reactions are enabled for the meeting.
  - `[AllowedPresenters <String>]`: onlineMeetingPresenters
  - `[AlternativeRecording <Byte[]>]`: The content stream of the alternative recording of a Microsoft Teams live event. Read-only.
  - `[AnonymizeIdentityForRoles <String[]>]`: 
  - `[AttendanceReports <IMicrosoftGraphMeetingAttendanceReport1[]>]`: The attendance reports of an online meeting. Read-only.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AttendanceRecords <IMicrosoftGraphAttendanceRecord1[]>]`: List of attendance records of an attendance report. Read-only.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[AttendanceIntervals <IMicrosoftGraphAttendanceInterval[]>]`: List of time periods between joining and leaving a meeting.
        - `[DurationInSeconds <Int32?>]`: Duration of the meeting interval in seconds; that is, the difference between joinDateTime and leaveDateTime.
        - `[JoinDateTime <DateTime?>]`: The time the attendee joined in UTC.
        - `[LeaveDateTime <DateTime?>]`: The time the attendee left in UTC.
      - `[EmailAddress <String>]`: Email address of the user associated with this atttendance record.
      - `[Identity <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[RegistrantId <String>]`: Unique identifier of a meetingRegistrant. Presents when the participant has registered for the meeting.
      - `[Role <String>]`: Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.
      - `[TotalAttendanceInSeconds <Int32?>]`: Total duration of the attendances in seconds.
    - `[MeetingEndDateTime <DateTime?>]`: UTC time when the meeting ended. Read-only.
    - `[MeetingStartDateTime <DateTime?>]`: UTC time when the meeting started. Read-only.
    - `[TotalParticipantCount <Int32?>]`: Total number of participants. Read-only.
  - `[AttendeeReport <Byte[]>]`: The content stream of the attendee report of a Teams live event. Read-only.
  - `[AudioConferencing <IMicrosoftGraphAudioConferencing>]`: audioConferencing
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConferenceId <String>]`: The conference id of the online meeting.
    - `[DialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
    - `[TollFreeNumber <String>]`: 
    - `[TollFreeNumbers <String[]>]`: List of toll-free numbers that are displayed in the meeting invite.
    - `[TollNumber <String>]`: 
    - `[TollNumbers <String[]>]`: List of toll numbers that are displayed in the meeting invite.
  - `[BroadcastSettings <IMicrosoftGraphBroadcastMeetingSettings>]`: broadcastMeetingSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedAudience <String>]`: broadcastMeetingAudience
    - `[Captions <IMicrosoftGraphBroadcastMeetingCaptionSettings>]`: broadcastMeetingCaptionSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsCaptionEnabled <Boolean?>]`: Indicates whether captions are enabled for this Teams live event.
      - `[SpokenLanguage <String>]`: The spoken language.
      - `[TranslationLanguages <String[]>]`: The translation languages (choose up to 6).
    - `[IsAttendeeReportEnabled <Boolean?>]`: Indicates whether attendee report is enabled for this Teams live event. Default value is false.
    - `[IsQuestionAndAnswerEnabled <Boolean?>]`: Indicates whether Q&A is enabled for this Teams live event. Default value is false.
    - `[IsRecordingEnabled <Boolean?>]`: Indicates whether recording is enabled for this Teams live event. Default value is false.
    - `[IsVideoOnDemandEnabled <Boolean?>]`: Indicates whether video on demand is enabled for this Teams live event. Default value is false.
  - `[Capabilities <String[]>]`: 
  - `[ChatInfo <IMicrosoftGraphChatInfo>]`: chatInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
    - `[ReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[CreationDateTime <DateTime?>]`: The meeting creation time in UTC. Read-only.
  - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
  - `[ExternalId <String>]`: The external ID. A custom ID. Optional.
  - `[IsBroadcast <Boolean?>]`: Indicates whether this is a Teams live event.
  - `[IsEntryExitAnnounced <Boolean?>]`: Indicates whether to announce when callers join or leave.
  - `[JoinInformation <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[JoinMeetingIdSettings <IMicrosoftGraphJoinMeetingIdSettings>]`: joinMeetingIdSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsPasscodeRequired <Boolean?>]`: Indicates whether a passcode is required to join a meeting when using joinMeetingId. Optional.
    - `[JoinMeetingId <String>]`: The meeting ID to be used to join a meeting. Optional. Read-only.
    - `[Passcode <String>]`: The passcode to join a meeting.  Optional. Read-only.
  - `[JoinUrl <String>]`: 
  - `[JoinWebUrl <String>]`: The join URL of the online meeting. Read-only.
  - `[LobbyBypassSettings <IMicrosoftGraphLobbyBypassSettings>]`: lobbyBypassSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsDialInBypassEnabled <Boolean?>]`: Specifies whether or not to always let dial-in callers bypass the lobby. Optional.
    - `[Scope <String>]`: lobbyBypassScope
  - `[MeetingAttendanceReport <IMicrosoftGraphMeetingAttendanceReport1>]`: meetingAttendanceReport
  - `[Participants <IMicrosoftGraphMeetingParticipants1>]`: meetingParticipants
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Attendees <IMicrosoftGraphMeetingParticipantInfo1[]>]`: Information of the meeting attendees.
      - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[Role <String>]`: 
      - `[Upn <String>]`: User principal name of the participant.
    - `[Contributors <IMicrosoftGraphMeetingParticipantInfo1[]>]`: 
    - `[Organizer <IMicrosoftGraphMeetingParticipantInfo1>]`: meetingParticipantInfo
    - `[Producers <IMicrosoftGraphMeetingParticipantInfo1[]>]`: 
  - `[RecordAutomatically <Boolean?>]`: Indicates whether to record the meeting automatically.
  - `[Recording <Byte[]>]`: The content stream of the recording of a Teams live event. Read-only.
  - `[Registration <IMicrosoftGraphMeetingRegistration>]`: meetingRegistration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedRegistrant <String>]`: meetingAudience
    - `[Registrants <IMicrosoftGraphMeetingRegistrantBase[]>]`: Registrants of the online meeting.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[JoinWebUrl <String>]`: A unique web URL for the registrant to join the meeting. Read-only.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CustomQuestions <IMicrosoftGraphMeetingRegistrationQuestion[]>]`: Custom registration questions.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[AnswerInputType <String>]`: answerInputType
      - `[AnswerOptions <String[]>]`: Answer options when answerInputType is radioButton.
      - `[DisplayName <String>]`: Display name of the custom registration question.
      - `[IsRequired <Boolean?>]`: Indicates whether the question is required. Default value is false.
    - `[Description <String>]`: The description of the meeting.
    - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
    - `[RegistrationPageViewCount <Int32?>]`: The number of times the registration page has been visited. Read-only.
    - `[RegistrationPageWebUrl <String>]`: The URL of the registration page. Read-only.
    - `[Speakers <IMicrosoftGraphMeetingSpeaker[]>]`: The meeting speaker's information.
      - `[Bio <String>]`: Bio of the speaker.
      - `[DisplayName <String>]`: Display name of the speaker.
    - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
    - `[Subject <String>]`: The subject of the meeting.
  - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
  - `[Subject <String>]`: The subject of the online meeting.
  - `[Transcripts <IMicrosoftGraphCallTranscript[]>]`: The transcripts of an online meeting. Read-only.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Content <Byte[]>]`: A field representing the content of the transcript. Read-only.
    - `[CreatedDateTime <DateTime?>]`: Date and time at which the transcript was created. Read-only.
  - `[VideoTeleconferenceId <String>]`: The video teleconferencing ID. Read-only.
  - `[VirtualAppointment <IMicrosoftGraphVirtualAppointment>]`: virtualAppointment
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AppointmentClientJoinWebUrl <String>]`: The join web URL of the virtual appointment for clients with waiting room and browser join. Optional.
    - `[AppointmentClients <IMicrosoftGraphVirtualAppointmentUser[]>]`: The client information for the virtual appointment, including name, email, and SMS phone number. Optional.
      - `[DisplayName <String>]`: The display name of the user who participates in a virtual appointment. Optional.
      - `[EmailAddress <String>]`: The email address of the user who participates in a virtual appointment. Optional.
      - `[SmsCapablePhoneNumber <String>]`: The phone number for sending SMS texts for the user who participates in a virtual appointment. Optional.
    - `[ExternalAppointmentId <String>]`: The identifier of the appointment from the scheduling system, associated with the current virtual appointment. Optional.
    - `[ExternalAppointmentUrl <String>]`: The URL of the appointment resource from the scheduling system, associated with the current virtual appointment. Optional.
    - `[Settings <IMicrosoftGraphVirtualAppointmentSettings>]`: virtualAppointmentSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowClientToJoinUsingBrowser <Boolean?>]`: Indicates whether the client can use the browser to join a virtual appointment. If set to false, the client can only use Microsoft Teams to join. Optional.

BROADCASTSETTINGS <IMicrosoftGraphBroadcastMeetingSettings>: broadcastMeetingSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowedAudience <String>]`: broadcastMeetingAudience
  - `[Captions <IMicrosoftGraphBroadcastMeetingCaptionSettings>]`: broadcastMeetingCaptionSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsCaptionEnabled <Boolean?>]`: Indicates whether captions are enabled for this Teams live event.
    - `[SpokenLanguage <String>]`: The spoken language.
    - `[TranslationLanguages <String[]>]`: The translation languages (choose up to 6).
  - `[IsAttendeeReportEnabled <Boolean?>]`: Indicates whether attendee report is enabled for this Teams live event. Default value is false.
  - `[IsQuestionAndAnswerEnabled <Boolean?>]`: Indicates whether Q&A is enabled for this Teams live event. Default value is false.
  - `[IsRecordingEnabled <Boolean?>]`: Indicates whether recording is enabled for this Teams live event. Default value is false.
  - `[IsVideoOnDemandEnabled <Boolean?>]`: Indicates whether video on demand is enabled for this Teams live event. Default value is false.

CHATINFO <IMicrosoftGraphChatInfo>: chatInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
  - `[ReplyChainMessageId <String>]`: The ID of the reply message.
  - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.

INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AttendanceRecordId <String>]`: key: id of attendanceRecord
  - `[AudioRoutingGroupId <String>]`: key: id of audioRoutingGroup
  - `[CallId <String>]`: key: id of call
  - `[CallRecordId <String>]`: key: id of callRecord
  - `[CallTranscriptId <String>]`: key: id of callTranscript
  - `[CommsOperationId <String>]`: key: id of commsOperation
  - `[ContentSharingSessionId <String>]`: key: id of contentSharingSession
  - `[MeetingAttendanceReportId <String>]`: key: id of meetingAttendanceReport
  - `[MeetingRegistrationQuestionId <String>]`: key: id of meetingRegistrationQuestion
  - `[OnlineMeetingId <String>]`: key: id of onlineMeeting
  - `[ParticipantId <String>]`: key: id of participant
  - `[PresenceId <String>]`: key: id of presence
  - `[SessionId <String>]`: key: id of session
  - `[UserId <String>]`: key: id of user

JOININFORMATION <IMicrosoftGraphItemBody>: itemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: The content of the item.
  - `[ContentType <String>]`: bodyType

JOINMEETINGIDSETTINGS <IMicrosoftGraphJoinMeetingIdSettings>: joinMeetingIdSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsPasscodeRequired <Boolean?>]`: Indicates whether a passcode is required to join a meeting when using joinMeetingId. Optional.
  - `[JoinMeetingId <String>]`: The meeting ID to be used to join a meeting. Optional. Read-only.
  - `[Passcode <String>]`: The passcode to join a meeting.  Optional. Read-only.

LOBBYBYPASSSETTINGS <IMicrosoftGraphLobbyBypassSettings>: lobbyBypassSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsDialInBypassEnabled <Boolean?>]`: Specifies whether or not to always let dial-in callers bypass the lobby. Optional.
  - `[Scope <String>]`: lobbyBypassScope

MEETINGATTENDANCEREPORT <IMicrosoftGraphMeetingAttendanceReport1>: meetingAttendanceReport
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AttendanceRecords <IMicrosoftGraphAttendanceRecord1[]>]`: List of attendance records of an attendance report. Read-only.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AttendanceIntervals <IMicrosoftGraphAttendanceInterval[]>]`: List of time periods between joining and leaving a meeting.
      - `[DurationInSeconds <Int32?>]`: Duration of the meeting interval in seconds; that is, the difference between joinDateTime and leaveDateTime.
      - `[JoinDateTime <DateTime?>]`: The time the attendee joined in UTC.
      - `[LeaveDateTime <DateTime?>]`: The time the attendee left in UTC.
    - `[EmailAddress <String>]`: Email address of the user associated with this atttendance record.
    - `[Identity <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[RegistrantId <String>]`: Unique identifier of a meetingRegistrant. Presents when the participant has registered for the meeting.
    - `[Role <String>]`: Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.
    - `[TotalAttendanceInSeconds <Int32?>]`: Total duration of the attendances in seconds.
  - `[MeetingEndDateTime <DateTime?>]`: UTC time when the meeting ended. Read-only.
  - `[MeetingStartDateTime <DateTime?>]`: UTC time when the meeting started. Read-only.
  - `[TotalParticipantCount <Int32?>]`: Total number of participants. Read-only.

PARTICIPANTS <IMicrosoftGraphMeetingParticipants1>: meetingParticipants
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Attendees <IMicrosoftGraphMeetingParticipantInfo1[]>]`: Information of the meeting attendees.
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Role <String>]`: 
    - `[Upn <String>]`: User principal name of the participant.
  - `[Contributors <IMicrosoftGraphMeetingParticipantInfo1[]>]`: 
  - `[Organizer <IMicrosoftGraphMeetingParticipantInfo1>]`: meetingParticipantInfo
  - `[Producers <IMicrosoftGraphMeetingParticipantInfo1[]>]`: 

REGISTRATION <IMicrosoftGraphMeetingRegistration>: meetingRegistration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowedRegistrant <String>]`: meetingAudience
  - `[Registrants <IMicrosoftGraphMeetingRegistrantBase[]>]`: Registrants of the online meeting.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[JoinWebUrl <String>]`: A unique web URL for the registrant to join the meeting. Read-only.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CustomQuestions <IMicrosoftGraphMeetingRegistrationQuestion[]>]`: Custom registration questions.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AnswerInputType <String>]`: answerInputType
    - `[AnswerOptions <String[]>]`: Answer options when answerInputType is radioButton.
    - `[DisplayName <String>]`: Display name of the custom registration question.
    - `[IsRequired <Boolean?>]`: Indicates whether the question is required. Default value is false.
  - `[Description <String>]`: The description of the meeting.
  - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
  - `[RegistrationPageViewCount <Int32?>]`: The number of times the registration page has been visited. Read-only.
  - `[RegistrationPageWebUrl <String>]`: The URL of the registration page. Read-only.
  - `[Speakers <IMicrosoftGraphMeetingSpeaker[]>]`: The meeting speaker's information.
    - `[Bio <String>]`: Bio of the speaker.
    - `[DisplayName <String>]`: Display name of the speaker.
  - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
  - `[Subject <String>]`: The subject of the meeting.

TRANSCRIPTS <IMicrosoftGraphCallTranscript[]>: The transcripts of an online meeting. Read-only.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Content <Byte[]>]`: A field representing the content of the transcript. Read-only.
  - `[CreatedDateTime <DateTime?>]`: Date and time at which the transcript was created. Read-only.

VIRTUALAPPOINTMENT <IMicrosoftGraphVirtualAppointment>: virtualAppointment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AppointmentClientJoinWebUrl <String>]`: The join web URL of the virtual appointment for clients with waiting room and browser join. Optional.
  - `[AppointmentClients <IMicrosoftGraphVirtualAppointmentUser[]>]`: The client information for the virtual appointment, including name, email, and SMS phone number. Optional.
    - `[DisplayName <String>]`: The display name of the user who participates in a virtual appointment. Optional.
    - `[EmailAddress <String>]`: The email address of the user who participates in a virtual appointment. Optional.
    - `[SmsCapablePhoneNumber <String>]`: The phone number for sending SMS texts for the user who participates in a virtual appointment. Optional.
  - `[ExternalAppointmentId <String>]`: The identifier of the appointment from the scheduling system, associated with the current virtual appointment. Optional.
  - `[ExternalAppointmentUrl <String>]`: The URL of the appointment resource from the scheduling system, associated with the current virtual appointment. Optional.
  - `[Settings <IMicrosoftGraphVirtualAppointmentSettings>]`: virtualAppointmentSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowClientToJoinUsingBrowser <Boolean?>]`: Indicates whether the client can use the browser to join a virtual appointment. If set to false, the client can only use Microsoft Teams to join. Optional.

## RELATED LINKS

