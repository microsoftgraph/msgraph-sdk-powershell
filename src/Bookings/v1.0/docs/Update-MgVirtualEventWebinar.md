---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.bookings/update-mgvirtualeventwebinar
schema: 2.0.0
---

# Update-MgVirtualEventWebinar

## SYNOPSIS
Update the navigation property webinars in solutions

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgVirtualEventWebinar -VirtualEventWebinarId <String> [-AdditionalProperties <Hashtable>]
 [-Audience <String>] [-CoOrganizers <IMicrosoftGraphCommunicationsUserIdentity[]>]
 [-CreatedBy <IMicrosoftGraphCommunicationsIdentitySet>] [-Description <IMicrosoftGraphItemBody>]
 [-DisplayName <String>] [-EndDateTime <IMicrosoftGraphDateTimeZone>] [-Id <String>]
 [-Registrations <IMicrosoftGraphVirtualEventRegistration[]>] [-ResponseHeadersVariable <String>]
 [-Sessions <IMicrosoftGraphVirtualEventSession[]>] [-StartDateTime <IMicrosoftGraphDateTimeZone>]
 [-Status <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgVirtualEventWebinar -VirtualEventWebinarId <String>
 -BodyParameter <IMicrosoftGraphVirtualEventWebinar> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgVirtualEventWebinar -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphVirtualEventWebinar> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgVirtualEventWebinar -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-Audience <String>] [-CoOrganizers <IMicrosoftGraphCommunicationsUserIdentity[]>]
 [-CreatedBy <IMicrosoftGraphCommunicationsIdentitySet>] [-Description <IMicrosoftGraphItemBody>]
 [-DisplayName <String>] [-EndDateTime <IMicrosoftGraphDateTimeZone>] [-Id <String>]
 [-Registrations <IMicrosoftGraphVirtualEventRegistration[]>] [-ResponseHeadersVariable <String>]
 [-Sessions <IMicrosoftGraphVirtualEventSession[]>] [-StartDateTime <IMicrosoftGraphDateTimeZone>]
 [-Status <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property webinars in solutions

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

### -Audience
meetingAudience

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

### -BodyParameter
virtualEventWebinar
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualEventWebinar
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CoOrganizers
Identity information of coorganizers of the webinar.
To construct, see NOTES section for COORGANIZERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCommunicationsUserIdentity[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
communicationsIdentitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCommunicationsIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
itemBody
To construct, see NOTES section for DESCRIPTION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemBody
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name of the virtual event.

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

### -EndDateTime
dateTimeTimeZone
To construct, see NOTES section for ENDDATETIME properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDateTimeZone
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IBookingsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Registrations
Registration records of the webinar.
To construct, see NOTES section for REGISTRATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualEventRegistration[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Sessions for the virtual event.
To construct, see NOTES section for SESSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualEventSession[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
dateTimeTimeZone
To construct, see NOTES section for STARTDATETIME properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDateTimeZone
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
virtualEventStatus

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

### Microsoft.Graph.PowerShell.Models.IBookingsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualEventWebinar

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualEventWebinar

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphVirtualEventWebinar>`: virtualEventWebinar
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphCommunicationsIdentitySet>]`: communicationsIdentitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[ApplicationInstance <IMicrosoftGraphIdentity>]`: identity
    - `[AssertedIdentity <IMicrosoftGraphIdentity>]`: identity
    - `[AzureCommunicationServicesUser <IMicrosoftGraphIdentity>]`: identity
    - `[Encrypted <IMicrosoftGraphIdentity>]`: identity
    - `[EndpointType <String>]`: endpointType
    - `[Guest <IMicrosoftGraphIdentity>]`: identity
    - `[OnPremises <IMicrosoftGraphIdentity>]`: identity
    - `[Phone <IMicrosoftGraphIdentity>]`: identity
  - `[Description <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[DisplayName <String>]`: Display name of the virtual event.
  - `[EndDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Sessions <IMicrosoftGraphVirtualEventSession[]>]`: Sessions for the virtual event.
    - `[AllowAttendeeToEnableCamera <Boolean?>]`: Indicates whether attendees can turn on their camera.
    - `[AllowAttendeeToEnableMic <Boolean?>]`: Indicates whether attendees can turn on their microphone.
    - `[AllowMeetingChat <String>]`: meetingChatMode
    - `[AllowParticipantsToChangeName <Boolean?>]`: Specifies if participants are allowed to rename themselves in an instance of the meeting.
    - `[AllowTeamworkReactions <Boolean?>]`: Indicates if Teams reactions are enabled for the meeting.
    - `[AllowedPresenters <String>]`: onlineMeetingPresenters
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
      - `[MessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
      - `[ReplyChainMessageId <String>]`: The ID of the reply message.
      - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
    - `[IsEntryExitAnnounced <Boolean?>]`: Indicates whether to announce when callers join or leave.
    - `[JoinInformation <IMicrosoftGraphItemBody>]`: itemBody
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
    - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[Status <String>]`: virtualEventStatus
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Audience <String>]`: meetingAudience
  - `[CoOrganizers <IMicrosoftGraphCommunicationsUserIdentity[]>]`: Identity information of coorganizers of the webinar.
    - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[TenantId <String>]`: The user's tenant ID.
  - `[Registrations <IMicrosoftGraphVirtualEventRegistration[]>]`: Registration records of the webinar.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CancelationDateTime <DateTime?>]`: Date and time when the registrant cancels their registration for the virtual event. Only appears when applicable. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Email <String>]`: Email address of the registrant.
    - `[FirstName <String>]`: First name of the registrant.
    - `[LastName <String>]`: Last name of the registrant.
    - `[RegistrationDateTime <DateTime?>]`: Date and time when the registrant registers for the virtual event. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>]`: The registrant's answer to the registration questions.
      - `[BooleanValue <Boolean?>]`: Boolean answer of the virtual event registration question. Only appears when answerInputType is boolean.
      - `[DisplayName <String>]`: Display name of the registration question.
      - `[MultiChoiceValues <String[]>]`: Collection of text answer of the virtual event registration question. Only appears when answerInputType is multiChoice.
      - `[QuestionId <String>]`: id of the virtual event registration question.
      - `[Value <String>]`: Text answer of the virtual event registration question. Appears when answerInputType is text, multilineText or singleChoice.
    - `[Status <String>]`: virtualEventAttendeeRegistrationStatus
    - `[UserId <String>]`: The registrant's ID in Microsoft Entra ID. Only appears when the registrant is registered in Microsoft Entra ID.

`COORGANIZERS <IMicrosoftGraphCommunicationsUserIdentity[]>`: Identity information of coorganizers of the webinar.
  - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[Id <String>]`: Unique identifier for the identity.
  - `[TenantId <String>]`: The user's tenant ID.

`CREATEDBY <IMicrosoftGraphCommunicationsIdentitySet>`: communicationsIdentitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ApplicationInstance <IMicrosoftGraphIdentity>]`: identity
  - `[AssertedIdentity <IMicrosoftGraphIdentity>]`: identity
  - `[AzureCommunicationServicesUser <IMicrosoftGraphIdentity>]`: identity
  - `[Encrypted <IMicrosoftGraphIdentity>]`: identity
  - `[EndpointType <String>]`: endpointType
  - `[Guest <IMicrosoftGraphIdentity>]`: identity
  - `[OnPremises <IMicrosoftGraphIdentity>]`: identity
  - `[Phone <IMicrosoftGraphIdentity>]`: identity

`DESCRIPTION <IMicrosoftGraphItemBody>`: itemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: The content of the item.
  - `[ContentType <String>]`: bodyType

`ENDDATETIME <IMicrosoftGraphDateTimeZone>`: dateTimeTimeZone
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.

`INPUTOBJECT <IBookingsIdentity>`: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[BookingAppointmentId <String>]`: The unique identifier of bookingAppointment
  - `[BookingBusinessId <String>]`: The unique identifier of bookingBusiness
  - `[BookingCurrencyId <String>]`: The unique identifier of bookingCurrency
  - `[BookingCustomQuestionId <String>]`: The unique identifier of bookingCustomQuestion
  - `[BookingCustomerBaseId <String>]`: The unique identifier of bookingCustomerBase
  - `[BookingServiceId <String>]`: The unique identifier of bookingService
  - `[BookingStaffMemberBaseId <String>]`: The unique identifier of bookingStaffMemberBase
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[Role <String>]`: Usage: role='{role}'
  - `[UserId <String>]`: Usage: userId='{userId}'
  - `[VirtualEventId <String>]`: The unique identifier of virtualEvent
  - `[VirtualEventRegistrationId <String>]`: The unique identifier of virtualEventRegistration
  - `[VirtualEventSessionId <String>]`: The unique identifier of virtualEventSession
  - `[VirtualEventWebinarId <String>]`: The unique identifier of virtualEventWebinar

`REGISTRATIONS <IMicrosoftGraphVirtualEventRegistration[]>`: Registration records of the webinar.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CancelationDateTime <DateTime?>]`: Date and time when the registrant cancels their registration for the virtual event. Only appears when applicable. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Email <String>]`: Email address of the registrant.
  - `[FirstName <String>]`: First name of the registrant.
  - `[LastName <String>]`: Last name of the registrant.
  - `[RegistrationDateTime <DateTime?>]`: Date and time when the registrant registers for the virtual event. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>]`: The registrant's answer to the registration questions.
    - `[BooleanValue <Boolean?>]`: Boolean answer of the virtual event registration question. Only appears when answerInputType is boolean.
    - `[DisplayName <String>]`: Display name of the registration question.
    - `[MultiChoiceValues <String[]>]`: Collection of text answer of the virtual event registration question. Only appears when answerInputType is multiChoice.
    - `[QuestionId <String>]`: id of the virtual event registration question.
    - `[Value <String>]`: Text answer of the virtual event registration question. Appears when answerInputType is text, multilineText or singleChoice.
  - `[Status <String>]`: virtualEventAttendeeRegistrationStatus
  - `[UserId <String>]`: The registrant's ID in Microsoft Entra ID. Only appears when the registrant is registered in Microsoft Entra ID.

`SESSIONS <IMicrosoftGraphVirtualEventSession[]>`: Sessions for the virtual event.
  - `[AllowAttendeeToEnableCamera <Boolean?>]`: Indicates whether attendees can turn on their camera.
  - `[AllowAttendeeToEnableMic <Boolean?>]`: Indicates whether attendees can turn on their microphone.
  - `[AllowMeetingChat <String>]`: meetingChatMode
  - `[AllowParticipantsToChangeName <Boolean?>]`: Specifies if participants are allowed to rename themselves in an instance of the meeting.
  - `[AllowTeamworkReactions <Boolean?>]`: Indicates if Teams reactions are enabled for the meeting.
  - `[AllowedPresenters <String>]`: onlineMeetingPresenters
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
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
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
    - `[MessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
    - `[ReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
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
    - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

`STARTDATETIME <IMicrosoftGraphDateTimeZone>`: dateTimeTimeZone
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.

## RELATED LINKS

