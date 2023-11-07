---
external help file:
Module Name: Microsoft.Graph.Beta.Bookings
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.bookings/update-mgbetavirtualeventwebinarregistration
schema: 2.0.0
---

# Update-MgBetaVirtualEventWebinarRegistration

## SYNOPSIS
Update the navigation property registrations in solutions

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaVirtualEventWebinarRegistration -VirtualEventRegistrationId <String>
 -VirtualEventWebinarId <String> [-AdditionalProperties <Hashtable>] [-CancelationDateTime <DateTime>]
 [-Email <String>] [-FirstName <String>] [-Id <String>] [-LastName <String>]
 [-RegistrationDateTime <DateTime>]
 [-RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>]
 [-Sessions <IMicrosoftGraphVirtualEventSession[]>] [-Status <String>] [-UserId <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaVirtualEventWebinarRegistration -VirtualEventRegistrationId <String>
 -VirtualEventWebinarId <String> -BodyParameter <IMicrosoftGraphVirtualEventRegistration> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaVirtualEventWebinarRegistration -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphVirtualEventRegistration> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaVirtualEventWebinarRegistration -InputObject <IBookingsIdentity>
 [-AdditionalProperties <Hashtable>] [-CancelationDateTime <DateTime>] [-Email <String>] [-FirstName <String>]
 [-Id <String>] [-LastName <String>] [-RegistrationDateTime <DateTime>]
 [-RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>]
 [-Sessions <IMicrosoftGraphVirtualEventSession[]>] [-Status <String>] [-UserId <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property registrations in solutions

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



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
virtualEventRegistration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphVirtualEventRegistration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CancelationDateTime
Date and time when the registrant cancels their registration for the virtual event.
Only appears when applicable.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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

### -Email
Email address of the registrant.

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

### -FirstName
First name of the registrant.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IBookingsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastName
Last name of the registrant.

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

### -RegistrationDateTime
Date and time when the registrant registers for the virtual event.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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

### -RegistrationQuestionAnswers
The registrant's answer to the registration questions.
To construct, see NOTES section for REGISTRATIONQUESTIONANSWERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sessions
Sessions of the webinar.
To construct, see NOTES section for SESSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphVirtualEventSession[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
virtualEventAttendeeRegistrationStatus

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

### -UserId
The registrant's ID in Azure Active Directory (Azure AD).
Only appears when the registrant is registered in Azure AD.

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

### -VirtualEventRegistrationId
The unique identifier of virtualEventRegistration

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

### -VirtualEventWebinarId
The unique identifier of virtualEventWebinar

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

### Microsoft.Graph.Beta.PowerShell.Models.IBookingsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphVirtualEventRegistration

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphVirtualEventRegistration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphVirtualEventRegistration>`: virtualEventRegistration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CancelationDateTime <DateTime?>]`: Date and time when the registrant cancels their registration for the virtual event. Only appears when applicable. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Email <String>]`: Email address of the registrant.
  - `[FirstName <String>]`: First name of the registrant.
  - `[LastName <String>]`: Last name of the registrant.
  - `[RegistrationDateTime <DateTime?>]`: Date and time when the registrant registers for the virtual event. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>]`: The registrant's answer to the registration questions.
    - `[BooleanValue <Boolean?>]`: Boolean answer of the virtualEventRegistrationQuestion. Only appears when answerInputType is boolean.
    - `[DisplayName <String>]`: Display name of the registration question.
    - `[MultiChoiceValues <String[]>]`: Collection of text answer of the virtualEventRegistrationQuestion. Only appears when answerInputType is multiChoice.
    - `[QuestionId <String>]`: id of the virtualEventRegistrationQuestion.
    - `[Value <String>]`: Text answer of the virtualEventRegistrationQuestion. Appears when answerInputType is text, multilineText or singleChoice.
  - `[Sessions <IMicrosoftGraphVirtualEventSession[]>]`: Sessions of the webinar.
    - `[AllowAttendeeToEnableCamera <Boolean?>]`: Indicates whether attendees can turn on their camera.
    - `[AllowAttendeeToEnableMic <Boolean?>]`: Indicates whether attendees can turn on their microphone.
    - `[AllowMeetingChat <String>]`: meetingChatMode
    - `[AllowParticipantsToChangeName <Boolean?>]`: Specifies if participants are allowed to rename themselves in an instance of the meeting.
    - `[AllowRecording <Boolean?>]`: Indicates whether recording is enabled for the meeting.
    - `[AllowTeamworkReactions <Boolean?>]`: Indicates if Teams reactions are enabled for the meeting.
    - `[AllowTranscription <Boolean?>]`: Indicates whether transcription is enabled for the meeting.
    - `[AllowedPresenters <String>]`: onlineMeetingPresenters
    - `[AlternativeRecording <Byte[]>]`: 
    - `[AnonymizeIdentityForRoles <String[]>]`: Specifies whose identity will be anonymized in the meeting. Possible values are: attendee. The attendee value cannot be removed through a PATCH operation once added.
    - `[AttendanceReports <IMicrosoftGraphMeetingAttendanceReport[]>]`: The attendance reports of an online meeting. Read-only.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AttendanceRecords <IMicrosoftGraphAttendanceRecord[]>]`: List of attendance records of an attendance report. Read-only.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[AttendanceIntervals <IMicrosoftGraphAttendanceInterval[]>]`: List of time periods between joining and leaving a meeting.
          - `[DurationInSeconds <Int32?>]`: Duration of the meeting interval in seconds; that is, the difference between joinDateTime and leaveDateTime.
          - `[JoinDateTime <DateTime?>]`: The time the attendee joined in UTC.
          - `[LeaveDateTime <DateTime?>]`: The time the attendee left in UTC.
        - `[EmailAddress <String>]`: Email address of the user associated with this attendance record.
        - `[Identity <IMicrosoftGraphIdentity>]`: identity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
          - `[Id <String>]`: The identifier of the identity. This property is read-only.
        - `[RegistrantId <String>]`: Unique identifier of a meetingRegistrant. Presents when the participant has registered for the meeting.
        - `[Role <String>]`: Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.
        - `[TotalAttendanceInSeconds <Int32?>]`: Total duration of the attendances in seconds.
      - `[MeetingEndDateTime <DateTime?>]`: UTC time when the meeting ended. Read-only.
      - `[MeetingStartDateTime <DateTime?>]`: UTC time when the meeting started. Read-only.
      - `[TotalParticipantCount <Int32?>]`: Total number of participants. Read-only.
    - `[AttendeeReport <Byte[]>]`: 
    - `[AudioConferencing <IMicrosoftGraphAudioConferencing>]`: audioConferencing
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConferenceId <String>]`: The conference id of the online meeting.
      - `[DialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
      - `[TollFreeNumber <String>]`: 
      - `[TollFreeNumbers <String[]>]`: List of toll-free numbers that are displayed in the meeting invite.
      - `[TollNumber <String>]`: 
      - `[TollNumbers <String[]>]`: List of toll numbers that are displayed in the meeting invite.
    - `[BroadcastRecording <Byte[]>]`: 
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
      - `[MessageId <String>]`: The unique identifier for a message in a Microsoft Teams channel.
      - `[ReplyChainMessageId <String>]`: The ID of the reply message.
      - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
    - `[ChatRestrictions <IMicrosoftGraphChatRestrictions>]`: chatRestrictions
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowTextOnly <Boolean?>]`: 
    - `[CreationDateTime <DateTime?>]`: The meeting creation time in UTC. Read-only.
    - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
    - `[ExternalId <String>]`: The external ID. A custom ID. Optional.
    - `[IsBroadcast <Boolean?>]`: 
    - `[IsEndToEndEncryptionEnabled <Boolean?>]`: 
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
    - `[MeetingAttendanceReport <IMicrosoftGraphMeetingAttendanceReport>]`: meetingAttendanceReport
    - `[Participants <IMicrosoftGraphMeetingParticipants>]`: meetingParticipants
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Attendees <IMicrosoftGraphMeetingParticipantInfo[]>]`: Information of the meeting attendees.
        - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[Device <IMicrosoftGraphIdentity>]`: identity
          - `[User <IMicrosoftGraphIdentity>]`: identity
        - `[Role <String>]`: onlineMeetingRole
        - `[Upn <String>]`: User principal name of the participant.
      - `[Contributors <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
      - `[Organizer <IMicrosoftGraphMeetingParticipantInfo>]`: meetingParticipantInfo
      - `[Producers <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
    - `[RecordAutomatically <Boolean?>]`: Indicates whether to record the meeting automatically.
    - `[Recording <Byte[]>]`: 
    - `[Recordings <IMicrosoftGraphCallRecording[]>]`: The recordings of an online meeting. Read-only.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Content <Byte[]>]`: The content of the recording. Read-only.
      - `[CreatedDateTime <DateTime?>]`: Date and time at which the recording was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[MeetingId <String>]`: The unique identifier of the onlineMeeting related to this recording. Read-only.
      - `[MeetingOrganizer <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[MeetingOrganizerId <String>]`: The unique identifier of the organizer of the onlineMeeting related to this recording. Read-only.
      - `[RecordingContentUrl <String>]`: The URL which can be used to access the content of the recording. Read-only.
    - `[Registration <IMicrosoftGraphMeetingRegistration>]`: meetingRegistration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowedRegistrant <String>]`: meetingAudience
      - `[Registrants <IMicrosoftGraphMeetingRegistrantBase[]>]`: Registrants of the online meeting.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[JoinWebUrl <String>]`: A unique web URL for the registrant to join the meeting. Read-only.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CustomQuestions <IMicrosoftGraphMeetingRegistrationQuestion[]>]`: Custom registration questions.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
    - `[ShareMeetingChatHistoryDefault <String>]`: meetingChatHistoryDefaultMode
    - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
    - `[Subject <String>]`: The subject of the online meeting.
    - `[Transcripts <IMicrosoftGraphCallTranscript[]>]`: The transcripts of an online meeting. Read-only.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Content <Byte[]>]`: The content of the transcript. Read-only.
      - `[CreatedDateTime <DateTime?>]`: Date and time at which the transcript was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[MeetingId <String>]`: The unique identifier of the online meeting related to this transcript. Read-only.
      - `[MeetingOrganizer <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[MeetingOrganizerId <String>]`: The unique identifier of the organizer of the onlineMeeting related to this transcript. Read-only.
      - `[MetadataContent <Byte[]>]`: The time-aligned metadata of the utterances in the transcript. Read-only.
      - `[TranscriptContentUrl <String>]`: The URL which can be used to access the content of the transcript. Read-only.
    - `[VideoTeleconferenceId <String>]`: The video teleconferencing ID. Read-only.
    - `[WatermarkProtection <IMicrosoftGraphWatermarkProtectionValues>]`: watermarkProtectionValues
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabledForContentSharing <Boolean?>]`: Indicates whether to apply a watermark to any shared content.
      - `[IsEnabledForVideo <Boolean?>]`: Indicates whether to apply a watermark to everyone's video feed.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Registrations <IMicrosoftGraphVirtualEventRegistration[]>]`: Registration records of this virtual event session.
  - `[Status <String>]`: virtualEventAttendeeRegistrationStatus
  - `[UserId <String>]`: The registrant's ID in Azure Active Directory (Azure AD). Only appears when the registrant is registered in Azure AD.

`INPUTOBJECT <IBookingsIdentity>`: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[BookingAppointmentId <String>]`: The unique identifier of bookingAppointment
  - `[BookingBusinessId <String>]`: The unique identifier of bookingBusiness
  - `[BookingCurrencyId <String>]`: The unique identifier of bookingCurrency
  - `[BookingCustomQuestionId <String>]`: The unique identifier of bookingCustomQuestion
  - `[BookingCustomerId <String>]`: The unique identifier of bookingCustomer
  - `[BookingServiceId <String>]`: The unique identifier of bookingService
  - `[BookingStaffMemberId <String>]`: The unique identifier of bookingStaffMember
  - `[BusinessScenarioId <String>]`: The unique identifier of businessScenario
  - `[BusinessScenarioTaskId <String>]`: The unique identifier of businessScenarioTask
  - `[CallRecordingId <String>]`: The unique identifier of callRecording
  - `[CallTranscriptId <String>]`: The unique identifier of callTranscript
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[MeetingRegistrantBaseId <String>]`: The unique identifier of meetingRegistrantBase
  - `[MeetingRegistrationQuestionId <String>]`: The unique identifier of meetingRegistrationQuestion
  - `[PlannerPlanConfigurationLocalizationId <String>]`: The unique identifier of plannerPlanConfigurationLocalization
  - `[VirtualEventId <String>]`: The unique identifier of virtualEvent
  - `[VirtualEventPresenterId <String>]`: The unique identifier of virtualEventPresenter
  - `[VirtualEventRegistrationId <String>]`: The unique identifier of virtualEventRegistration
  - `[VirtualEventSessionId <String>]`: The unique identifier of virtualEventSession
  - `[VirtualEventWebinarId <String>]`: The unique identifier of virtualEventWebinar

`REGISTRATIONQUESTIONANSWERS <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>`: The registrant's answer to the registration questions.
  - `[BooleanValue <Boolean?>]`: Boolean answer of the virtualEventRegistrationQuestion. Only appears when answerInputType is boolean.
  - `[DisplayName <String>]`: Display name of the registration question.
  - `[MultiChoiceValues <String[]>]`: Collection of text answer of the virtualEventRegistrationQuestion. Only appears when answerInputType is multiChoice.
  - `[QuestionId <String>]`: id of the virtualEventRegistrationQuestion.
  - `[Value <String>]`: Text answer of the virtualEventRegistrationQuestion. Appears when answerInputType is text, multilineText or singleChoice.

`SESSIONS <IMicrosoftGraphVirtualEventSession[]>`: Sessions of the webinar.
  - `[AllowAttendeeToEnableCamera <Boolean?>]`: Indicates whether attendees can turn on their camera.
  - `[AllowAttendeeToEnableMic <Boolean?>]`: Indicates whether attendees can turn on their microphone.
  - `[AllowMeetingChat <String>]`: meetingChatMode
  - `[AllowParticipantsToChangeName <Boolean?>]`: Specifies if participants are allowed to rename themselves in an instance of the meeting.
  - `[AllowRecording <Boolean?>]`: Indicates whether recording is enabled for the meeting.
  - `[AllowTeamworkReactions <Boolean?>]`: Indicates if Teams reactions are enabled for the meeting.
  - `[AllowTranscription <Boolean?>]`: Indicates whether transcription is enabled for the meeting.
  - `[AllowedPresenters <String>]`: onlineMeetingPresenters
  - `[AlternativeRecording <Byte[]>]`: 
  - `[AnonymizeIdentityForRoles <String[]>]`: Specifies whose identity will be anonymized in the meeting. Possible values are: attendee. The attendee value cannot be removed through a PATCH operation once added.
  - `[AttendanceReports <IMicrosoftGraphMeetingAttendanceReport[]>]`: The attendance reports of an online meeting. Read-only.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AttendanceRecords <IMicrosoftGraphAttendanceRecord[]>]`: List of attendance records of an attendance report. Read-only.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AttendanceIntervals <IMicrosoftGraphAttendanceInterval[]>]`: List of time periods between joining and leaving a meeting.
        - `[DurationInSeconds <Int32?>]`: Duration of the meeting interval in seconds; that is, the difference between joinDateTime and leaveDateTime.
        - `[JoinDateTime <DateTime?>]`: The time the attendee joined in UTC.
        - `[LeaveDateTime <DateTime?>]`: The time the attendee left in UTC.
      - `[EmailAddress <String>]`: Email address of the user associated with this attendance record.
      - `[Identity <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[RegistrantId <String>]`: Unique identifier of a meetingRegistrant. Presents when the participant has registered for the meeting.
      - `[Role <String>]`: Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.
      - `[TotalAttendanceInSeconds <Int32?>]`: Total duration of the attendances in seconds.
    - `[MeetingEndDateTime <DateTime?>]`: UTC time when the meeting ended. Read-only.
    - `[MeetingStartDateTime <DateTime?>]`: UTC time when the meeting started. Read-only.
    - `[TotalParticipantCount <Int32?>]`: Total number of participants. Read-only.
  - `[AttendeeReport <Byte[]>]`: 
  - `[AudioConferencing <IMicrosoftGraphAudioConferencing>]`: audioConferencing
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConferenceId <String>]`: The conference id of the online meeting.
    - `[DialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
    - `[TollFreeNumber <String>]`: 
    - `[TollFreeNumbers <String[]>]`: List of toll-free numbers that are displayed in the meeting invite.
    - `[TollNumber <String>]`: 
    - `[TollNumbers <String[]>]`: List of toll numbers that are displayed in the meeting invite.
  - `[BroadcastRecording <Byte[]>]`: 
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
    - `[MessageId <String>]`: The unique identifier for a message in a Microsoft Teams channel.
    - `[ReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[ChatRestrictions <IMicrosoftGraphChatRestrictions>]`: chatRestrictions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowTextOnly <Boolean?>]`: 
  - `[CreationDateTime <DateTime?>]`: The meeting creation time in UTC. Read-only.
  - `[EndDateTime <DateTime?>]`: The meeting end time in UTC.
  - `[ExternalId <String>]`: The external ID. A custom ID. Optional.
  - `[IsBroadcast <Boolean?>]`: 
  - `[IsEndToEndEncryptionEnabled <Boolean?>]`: 
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
  - `[MeetingAttendanceReport <IMicrosoftGraphMeetingAttendanceReport>]`: meetingAttendanceReport
  - `[Participants <IMicrosoftGraphMeetingParticipants>]`: meetingParticipants
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Attendees <IMicrosoftGraphMeetingParticipantInfo[]>]`: Information of the meeting attendees.
      - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[Role <String>]`: onlineMeetingRole
      - `[Upn <String>]`: User principal name of the participant.
    - `[Contributors <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
    - `[Organizer <IMicrosoftGraphMeetingParticipantInfo>]`: meetingParticipantInfo
    - `[Producers <IMicrosoftGraphMeetingParticipantInfo[]>]`: 
  - `[RecordAutomatically <Boolean?>]`: Indicates whether to record the meeting automatically.
  - `[Recording <Byte[]>]`: 
  - `[Recordings <IMicrosoftGraphCallRecording[]>]`: The recordings of an online meeting. Read-only.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Content <Byte[]>]`: The content of the recording. Read-only.
    - `[CreatedDateTime <DateTime?>]`: Date and time at which the recording was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[MeetingId <String>]`: The unique identifier of the onlineMeeting related to this recording. Read-only.
    - `[MeetingOrganizer <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[MeetingOrganizerId <String>]`: The unique identifier of the organizer of the onlineMeeting related to this recording. Read-only.
    - `[RecordingContentUrl <String>]`: The URL which can be used to access the content of the recording. Read-only.
  - `[Registration <IMicrosoftGraphMeetingRegistration>]`: meetingRegistration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedRegistrant <String>]`: meetingAudience
    - `[Registrants <IMicrosoftGraphMeetingRegistrantBase[]>]`: Registrants of the online meeting.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[JoinWebUrl <String>]`: A unique web URL for the registrant to join the meeting. Read-only.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CustomQuestions <IMicrosoftGraphMeetingRegistrationQuestion[]>]`: Custom registration questions.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
  - `[ShareMeetingChatHistoryDefault <String>]`: meetingChatHistoryDefaultMode
  - `[StartDateTime <DateTime?>]`: The meeting start time in UTC.
  - `[Subject <String>]`: The subject of the online meeting.
  - `[Transcripts <IMicrosoftGraphCallTranscript[]>]`: The transcripts of an online meeting. Read-only.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Content <Byte[]>]`: The content of the transcript. Read-only.
    - `[CreatedDateTime <DateTime?>]`: Date and time at which the transcript was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[MeetingId <String>]`: The unique identifier of the online meeting related to this transcript. Read-only.
    - `[MeetingOrganizer <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[MeetingOrganizerId <String>]`: The unique identifier of the organizer of the onlineMeeting related to this transcript. Read-only.
    - `[MetadataContent <Byte[]>]`: The time-aligned metadata of the utterances in the transcript. Read-only.
    - `[TranscriptContentUrl <String>]`: The URL which can be used to access the content of the transcript. Read-only.
  - `[VideoTeleconferenceId <String>]`: The video teleconferencing ID. Read-only.
  - `[WatermarkProtection <IMicrosoftGraphWatermarkProtectionValues>]`: watermarkProtectionValues
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabledForContentSharing <Boolean?>]`: Indicates whether to apply a watermark to any shared content.
    - `[IsEnabledForVideo <Boolean?>]`: Indicates whether to apply a watermark to everyone's video feed.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Registrations <IMicrosoftGraphVirtualEventRegistration[]>]`: Registration records of this virtual event session.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CancelationDateTime <DateTime?>]`: Date and time when the registrant cancels their registration for the virtual event. Only appears when applicable. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Email <String>]`: Email address of the registrant.
    - `[FirstName <String>]`: First name of the registrant.
    - `[LastName <String>]`: Last name of the registrant.
    - `[RegistrationDateTime <DateTime?>]`: Date and time when the registrant registers for the virtual event. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>]`: The registrant's answer to the registration questions.
      - `[BooleanValue <Boolean?>]`: Boolean answer of the virtualEventRegistrationQuestion. Only appears when answerInputType is boolean.
      - `[DisplayName <String>]`: Display name of the registration question.
      - `[MultiChoiceValues <String[]>]`: Collection of text answer of the virtualEventRegistrationQuestion. Only appears when answerInputType is multiChoice.
      - `[QuestionId <String>]`: id of the virtualEventRegistrationQuestion.
      - `[Value <String>]`: Text answer of the virtualEventRegistrationQuestion. Appears when answerInputType is text, multilineText or singleChoice.
    - `[Sessions <IMicrosoftGraphVirtualEventSession[]>]`: Sessions of the webinar.
    - `[Status <String>]`: virtualEventAttendeeRegistrationStatus
    - `[UserId <String>]`: The registrant's ID in Azure Active Directory (Azure AD). Only appears when the registrant is registered in Azure AD.

## RELATED LINKS

