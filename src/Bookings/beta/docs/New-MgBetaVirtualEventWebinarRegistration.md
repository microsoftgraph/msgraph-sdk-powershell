---
external help file:
Module Name: Microsoft.Graph.Beta.Bookings
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.bookings/new-mgbetavirtualeventwebinarregistration
schema: 2.0.0
---

# New-MgBetaVirtualEventWebinarRegistration

## SYNOPSIS
Create new navigation property to registrations for solutions

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaVirtualEventWebinarRegistration -VirtualEventWebinarId <String> [-AdditionalProperties <Hashtable>]
 [-CancelationDateTime <DateTime>] [-Email <String>] [-FirstName <String>] [-Id <String>] [-LastName <String>]
 [-RegistrationDateTime <DateTime>]
 [-RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>]
 [-ResponseHeadersVariable <String>] [-Sessions <IMicrosoftGraphVirtualEventSession[]>] [-Status <String>]
 [-UserId <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaVirtualEventWebinarRegistration -VirtualEventWebinarId <String>
 -BodyParameter <IMicrosoftGraphVirtualEventRegistration> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaVirtualEventWebinarRegistration -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphVirtualEventRegistration> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaVirtualEventWebinarRegistration -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-CancelationDateTime <DateTime>] [-Email <String>] [-FirstName <String>] [-Id <String>] [-LastName <String>]
 [-RegistrationDateTime <DateTime>]
 [-RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>]
 [-ResponseHeadersVariable <String>] [-Sessions <IMicrosoftGraphVirtualEventSession[]>] [-Status <String>]
 [-UserId <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to registrations for solutions

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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: Create, CreateViaIdentity
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sessions
.
To construct, see NOTES section for SESSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphVirtualEventSession[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The registrant's ID in Microsoft Entra ID.
Only appears when the registrant is registered in Microsoft Entra ID.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VirtualEventWebinarId
The unique identifier of virtualEventWebinar

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
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

### System.Collections.IDictionary

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
  - `[Sessions <IMicrosoftGraphVirtualEventSession[]>]`: 
    - `[AllowAttendeeToEnableCamera <Boolean?>]`: Indicates whether attendees can turn on their camera.
    - `[AllowAttendeeToEnableMic <Boolean?>]`: Indicates whether attendees can turn on their microphone.
    - `[AllowMeetingChat <String>]`: meetingChatMode
    - `[AllowParticipantsToChangeName <Boolean?>]`: Specifies if participants are allowed to rename themselves in an instance of the meeting.
    - `[AllowRecording <Boolean?>]`: Indicates whether recording is enabled for the meeting.
    - `[AllowTeamworkReactions <Boolean?>]`: Indicates if Teams reactions are enabled for the meeting.
    - `[AllowTranscription <Boolean?>]`: Indicates whether transcription is enabled for the meeting.
    - `[AllowedPresenters <String>]`: onlineMeetingPresenters
    - `[AnonymizeIdentityForRoles <String[]>]`: Specifies whose identity is anonymized in the meeting. Possible values are: attendee. The attendee value can't be removed through a PATCH operation once added.
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
          - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
        - `[RegistrantId <String>]`: Unique identifier of a meetingRegistrant. Presents when the participant has registered for the meeting.
        - `[Role <String>]`: Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.
        - `[TotalAttendanceInSeconds <Int32?>]`: Total duration of the attendances in seconds.
      - `[MeetingEndDateTime <DateTime?>]`: UTC time when the meeting ended. Read-only.
      - `[MeetingStartDateTime <DateTime?>]`: UTC time when the meeting started. Read-only.
      - `[TotalParticipantCount <Int32?>]`: Total number of participants. Read-only.
    - `[AudioConferencing <IMicrosoftGraphAudioConferencing>]`: audioConferencing
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConferenceId <String>]`: The conference id of the online meeting.
      - `[DialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
      - `[TollFreeNumber <String>]`: 
      - `[TollFreeNumbers <String[]>]`: List of toll-free numbers that are displayed in the meeting invite.
      - `[TollNumber <String>]`: 
      - `[TollNumbers <String[]>]`: List of toll numbers that are displayed in the meeting invite.
    - `[ChatInfo <IMicrosoftGraphChatInfo>]`: chatInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MessageId <String>]`: The unique identifier for a message in a Microsoft Teams channel.
      - `[ReplyChainMessageId <String>]`: The ID of the reply message.
      - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
    - `[ChatRestrictions <IMicrosoftGraphChatRestrictions>]`: chatRestrictions
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowTextOnly <Boolean?>]`: 
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
    - `[JoinWebUrl <String>]`: The join URL of the online meeting. Read-only.
    - `[LobbyBypassSettings <IMicrosoftGraphLobbyBypassSettings>]`: lobbyBypassSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsDialInBypassEnabled <Boolean?>]`: Specifies whether or not to always let dial-in callers bypass the lobby. Optional.
      - `[Scope <String>]`: lobbyBypassScope
    - `[RecordAutomatically <Boolean?>]`: Indicates whether to record the meeting automatically.
    - `[ShareMeetingChatHistoryDefault <String>]`: meetingChatHistoryDefaultMode
    - `[Subject <String>]`: The subject of the online meeting.
    - `[VideoTeleconferenceId <String>]`: The video teleconferencing ID. Read-only.
    - `[WatermarkProtection <IMicrosoftGraphWatermarkProtectionValues>]`: watermarkProtectionValues
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabledForContentSharing <Boolean?>]`: Indicates whether to apply a watermark to any shared content.
      - `[IsEnabledForVideo <Boolean?>]`: Indicates whether to apply a watermark to everyone's video feed.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[EndDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
      - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
    - `[Presenters <IMicrosoftGraphVirtualEventPresenter[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Email <String>]`: Email address of the presenter.
      - `[Identity <IMicrosoftGraphCommunicationsUserIdentity>]`: communicationsUserIdentity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
        - `[TenantId <String>]`: The user's tenant ID.
      - `[PresenterDetails <IMicrosoftGraphVirtualEventPresenterDetails>]`: virtualEventPresenterDetails
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Bio <IMicrosoftGraphItemBody>]`: itemBody
        - `[Company <String>]`: The presenter's company name.
        - `[JobTitle <String>]`: The presenter's job title.
        - `[LinkedInProfileWebUrl <String>]`: The presenter's LinkedIn profile URL.
        - `[PersonalSiteWebUrl <String>]`: The presenter's personal website URL.
        - `[TwitterProfileWebUrl <String>]`: The presenter's Twitter profile URL.
      - `[ProfilePhoto <Byte[]>]`: 
      - `[Sessions <IMicrosoftGraphVirtualEventSession[]>]`: 
    - `[Registrations <IMicrosoftGraphVirtualEventRegistration[]>]`: 
    - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[Status <String>]`: virtualEventAttendeeRegistrationStatus
  - `[UserId <String>]`: The registrant's ID in Microsoft Entra ID. Only appears when the registrant is registered in Microsoft Entra ID.

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
  - `[JoinWebUrl <String>]`: Alternate key of virtualEventSession
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[PlannerPlanConfigurationLocalizationId <String>]`: The unique identifier of plannerPlanConfigurationLocalization
  - `[Role <String>]`: Usage: role='{role}'
  - `[UniqueName <String>]`: Alternate key of businessScenario
  - `[UserId <String>]`: Usage: userId='{userId}'
  - `[VirtualEventId <String>]`: The unique identifier of virtualEvent
  - `[VirtualEventPresenterId <String>]`: The unique identifier of virtualEventPresenter
  - `[VirtualEventRegistrationId <String>]`: The unique identifier of virtualEventRegistration
  - `[VirtualEventSessionId <String>]`: The unique identifier of virtualEventSession
  - `[VirtualEventTownhallId <String>]`: The unique identifier of virtualEventTownhall
  - `[VirtualEventWebinarId <String>]`: The unique identifier of virtualEventWebinar

`REGISTRATIONQUESTIONANSWERS <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>`: The registrant's answer to the registration questions.
  - `[BooleanValue <Boolean?>]`: Boolean answer of the virtualEventRegistrationQuestion. Only appears when answerInputType is boolean.
  - `[DisplayName <String>]`: Display name of the registration question.
  - `[MultiChoiceValues <String[]>]`: Collection of text answer of the virtualEventRegistrationQuestion. Only appears when answerInputType is multiChoice.
  - `[QuestionId <String>]`: id of the virtualEventRegistrationQuestion.
  - `[Value <String>]`: Text answer of the virtualEventRegistrationQuestion. Appears when answerInputType is text, multilineText or singleChoice.

`SESSIONS <IMicrosoftGraphVirtualEventSession[]>`: .
  - `[AllowAttendeeToEnableCamera <Boolean?>]`: Indicates whether attendees can turn on their camera.
  - `[AllowAttendeeToEnableMic <Boolean?>]`: Indicates whether attendees can turn on their microphone.
  - `[AllowMeetingChat <String>]`: meetingChatMode
  - `[AllowParticipantsToChangeName <Boolean?>]`: Specifies if participants are allowed to rename themselves in an instance of the meeting.
  - `[AllowRecording <Boolean?>]`: Indicates whether recording is enabled for the meeting.
  - `[AllowTeamworkReactions <Boolean?>]`: Indicates if Teams reactions are enabled for the meeting.
  - `[AllowTranscription <Boolean?>]`: Indicates whether transcription is enabled for the meeting.
  - `[AllowedPresenters <String>]`: onlineMeetingPresenters
  - `[AnonymizeIdentityForRoles <String[]>]`: Specifies whose identity is anonymized in the meeting. Possible values are: attendee. The attendee value can't be removed through a PATCH operation once added.
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
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
      - `[RegistrantId <String>]`: Unique identifier of a meetingRegistrant. Presents when the participant has registered for the meeting.
      - `[Role <String>]`: Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.
      - `[TotalAttendanceInSeconds <Int32?>]`: Total duration of the attendances in seconds.
    - `[MeetingEndDateTime <DateTime?>]`: UTC time when the meeting ended. Read-only.
    - `[MeetingStartDateTime <DateTime?>]`: UTC time when the meeting started. Read-only.
    - `[TotalParticipantCount <Int32?>]`: Total number of participants. Read-only.
  - `[AudioConferencing <IMicrosoftGraphAudioConferencing>]`: audioConferencing
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConferenceId <String>]`: The conference id of the online meeting.
    - `[DialinUrl <String>]`: A URL to the externally-accessible web page that contains dial-in information.
    - `[TollFreeNumber <String>]`: 
    - `[TollFreeNumbers <String[]>]`: List of toll-free numbers that are displayed in the meeting invite.
    - `[TollNumber <String>]`: 
    - `[TollNumbers <String[]>]`: List of toll numbers that are displayed in the meeting invite.
  - `[ChatInfo <IMicrosoftGraphChatInfo>]`: chatInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MessageId <String>]`: The unique identifier for a message in a Microsoft Teams channel.
    - `[ReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[ChatRestrictions <IMicrosoftGraphChatRestrictions>]`: chatRestrictions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowTextOnly <Boolean?>]`: 
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
  - `[JoinWebUrl <String>]`: The join URL of the online meeting. Read-only.
  - `[LobbyBypassSettings <IMicrosoftGraphLobbyBypassSettings>]`: lobbyBypassSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsDialInBypassEnabled <Boolean?>]`: Specifies whether or not to always let dial-in callers bypass the lobby. Optional.
    - `[Scope <String>]`: lobbyBypassScope
  - `[RecordAutomatically <Boolean?>]`: Indicates whether to record the meeting automatically.
  - `[ShareMeetingChatHistoryDefault <String>]`: meetingChatHistoryDefaultMode
  - `[Subject <String>]`: The subject of the online meeting.
  - `[VideoTeleconferenceId <String>]`: The video teleconferencing ID. Read-only.
  - `[WatermarkProtection <IMicrosoftGraphWatermarkProtectionValues>]`: watermarkProtectionValues
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabledForContentSharing <Boolean?>]`: Indicates whether to apply a watermark to any shared content.
    - `[IsEnabledForVideo <Boolean?>]`: Indicates whether to apply a watermark to everyone's video feed.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[EndDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
    - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
  - `[Presenters <IMicrosoftGraphVirtualEventPresenter[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Email <String>]`: Email address of the presenter.
    - `[Identity <IMicrosoftGraphCommunicationsUserIdentity>]`: communicationsUserIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
      - `[TenantId <String>]`: The user's tenant ID.
    - `[PresenterDetails <IMicrosoftGraphVirtualEventPresenterDetails>]`: virtualEventPresenterDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Bio <IMicrosoftGraphItemBody>]`: itemBody
      - `[Company <String>]`: The presenter's company name.
      - `[JobTitle <String>]`: The presenter's job title.
      - `[LinkedInProfileWebUrl <String>]`: The presenter's LinkedIn profile URL.
      - `[PersonalSiteWebUrl <String>]`: The presenter's personal website URL.
      - `[TwitterProfileWebUrl <String>]`: The presenter's Twitter profile URL.
    - `[ProfilePhoto <Byte[]>]`: 
    - `[Sessions <IMicrosoftGraphVirtualEventSession[]>]`: 
  - `[Registrations <IMicrosoftGraphVirtualEventRegistration[]>]`: 
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
    - `[Sessions <IMicrosoftGraphVirtualEventSession[]>]`: 
    - `[Status <String>]`: virtualEventAttendeeRegistrationStatus
    - `[UserId <String>]`: The registrant's ID in Microsoft Entra ID. Only appears when the registrant is registered in Microsoft Entra ID.
  - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

## RELATED LINKS

