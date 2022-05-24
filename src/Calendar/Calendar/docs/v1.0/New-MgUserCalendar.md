---
external help file:
Module Name: Microsoft.Graph.Calendar
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.calendar/new-mgusercalendar
schema: 2.0.0
---

# New-MgUserCalendar

## SYNOPSIS
The user's calendars.
Read-only.
Nullable.

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserCalendar -UserId <String> [-AdditionalProperties <Hashtable>]
 [-AllowedOnlineMeetingProviders <String[]>] [-CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]
 [-CalendarView <IMicrosoftGraphEvent[]>] [-CanEdit] [-CanShare] [-CanViewPrivateItems] [-ChangeKey <String>]
 [-Color <String>] [-DefaultOnlineMeetingProvider <String>] [-Events <IMicrosoftGraphEvent[]>]
 [-HexColor <String>] [-Id <String>] [-IsDefaultCalendar] [-IsRemovable] [-IsTallyingResponses]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-Name <String>]
 [-Owner <IMicrosoftGraphEmailAddress>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgUserCalendar -UserId <String> -BodyParameter <IMicrosoftGraphCalendar> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserCalendar -InputObject <ICalendarIdentity> -BodyParameter <IMicrosoftGraphCalendar> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserCalendar -InputObject <ICalendarIdentity> [-AdditionalProperties <Hashtable>]
 [-AllowedOnlineMeetingProviders <String[]>] [-CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]
 [-CalendarView <IMicrosoftGraphEvent[]>] [-CanEdit] [-CanShare] [-CanViewPrivateItems] [-ChangeKey <String>]
 [-Color <String>] [-DefaultOnlineMeetingProvider <String>] [-Events <IMicrosoftGraphEvent[]>]
 [-HexColor <String>] [-Id <String>] [-IsDefaultCalendar] [-IsRemovable] [-IsTallyingResponses]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-Name <String>]
 [-Owner <IMicrosoftGraphEmailAddress>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
The user's calendars.
Read-only.
Nullable.

## EXAMPLES

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

### -AllowedOnlineMeetingProviders
Represent the online meeting service providers that can be used to create online meetings in this calendar.
Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
calendar
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCalendar
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CalendarPermissions
The permissions of the users with whom the calendar is shared.
To construct, please use Get-Help -Online and see NOTES section for CALENDARPERMISSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCalendarPermission[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarView
The calendar view for the calendar.
Navigation property.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for CALENDARVIEW properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvent[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CanEdit
true if the user can write to the calendar, false otherwise.
This property is true for the user who created the calendar.
This property is also true for a user who has been shared a calendar and granted write access.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CanShare
true if the user has the permission to share the calendar, false otherwise.
Only the user who created the calendar can share it.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CanViewPrivateItems
true if the user can read calendar items that have been marked private, false otherwise.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChangeKey
Identifies the version of the calendar object.
Every time the calendar is changed, changeKey changes as well.
This allows Exchange to apply changes to the correct version of the object.
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

### -Color
calendarColor

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

### -DefaultOnlineMeetingProvider
onlineMeetingProviderType

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

### -Events
The events in the calendar.
Navigation property.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for EVENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvent[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HexColor
The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space.
If the user has never explicitly set a color for the calendar, this property is empty.
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

### -Id
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ICalendarIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsDefaultCalendar
true if this is the default calendar where new events are created by default, false otherwise.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsRemovable
Indicates whether this user calendar can be deleted from the user mailbox.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsTallyingResponses
Indicates whether this user calendar supports tracking of meeting responses.
Only meeting invites sent from users' primary calendars support tracking of meeting responses.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MultiValueExtendedProperties
The collection of multi-value extended properties defined for the calendar.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for MULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The calendar name.

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

### -Owner
emailAddress
To construct, please use Get-Help -Online and see NOTES section for OWNER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmailAddress
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SingleValueExtendedProperties
The collection of single-value extended properties defined for the calendar.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for SINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

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

### Microsoft.Graph.PowerShell.Models.ICalendarIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCalendar

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCalendar

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCalendar>: calendar
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
  - `[CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]`: The permissions of the users with whom the calendar is shared.
    - `[Id <String>]`: Read-only.
    - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
    - `[IsInsideOrganization <Boolean?>]`: True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
    - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.
    - `[Role <String>]`: calendarRoleType
  - `[CalendarView <IMicrosoftGraphEvent[]>]`: The calendar view for the calendar. Navigation property. Read-only.
    - `[Categories <String[]>]`: The categories associated with the item
    - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Id <String>]`: Read-only.
    - `[AllowNewTimeProposals <Boolean?>]`: true if the meeting organizer allows invitees to propose a new time when responding; otherwise, false. Optional. Default is true.
    - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[ContentType <String>]`: The MIME type.
      - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Name <String>]`: The attachment's file name.
      - `[Size <Int32?>]`: The length of the attachment in bytes.
    - `[Attendees <IMicrosoftGraphAttendee[]>]`: The collection of attendees for the event.
      - `[Type <String>]`: attendeeType
      - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[ProposedNewTime <IMicrosoftGraphTimeSlot>]`: timeSlot
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
          - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
        - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[Status <IMicrosoftGraphResponseStatus>]`: responseStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Response <String>]`: responseType
        - `[Time <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Body <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[BodyPreview <String>]`: The preview of the message associated with the event. It is in text format.
    - `[Calendar <IMicrosoftGraphCalendar>]`: calendar
    - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the event. Nullable.
      - `[Id <String>]`: Read-only.
    - `[HasAttachments <Boolean?>]`: Set to true if the event has attachments.
    - `[HideAttendees <Boolean?>]`: When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.
    - `[ICalUId <String>]`: A unique identifier for an event across calendars. This ID is different for each occurrence in a recurring series. Read-only.
    - `[Importance <String>]`: importance
    - `[Instances <IMicrosoftGraphEvent[]>]`: The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.
    - `[IsAllDay <Boolean?>]`: 
    - `[IsCancelled <Boolean?>]`: 
    - `[IsDraft <Boolean?>]`: 
    - `[IsOnlineMeeting <Boolean?>]`: 
    - `[IsOrganizer <Boolean?>]`: 
    - `[IsReminderOn <Boolean?>]`: 
    - `[Location <IMicrosoftGraphLocation>]`: location
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[City <String>]`: The city.
        - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
        - `[PostalCode <String>]`: The postal code.
        - `[State <String>]`: The state.
        - `[Street <String>]`: The street.
      - `[Coordinates <IMicrosoftGraphOutlookGeoCoordinates>]`: outlookGeoCoordinates
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Accuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
        - `[Altitude <Double?>]`: The altitude of the location.
        - `[AltitudeAccuracy <Double?>]`: The accuracy of the altitude.
        - `[Latitude <Double?>]`: The latitude of the location.
        - `[Longitude <Double?>]`: The longitude of the location.
      - `[DisplayName <String>]`: The name associated with the location.
      - `[LocationEmailAddress <String>]`: Optional email address of the location.
      - `[LocationType <String>]`: locationType
      - `[LocationUri <String>]`: Optional URI representing the location.
      - `[UniqueId <String>]`: For internal use only.
      - `[UniqueIdType <String>]`: locationUniqueIdType
    - `[Locations <IMicrosoftGraphLocation[]>]`: 
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the event. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[OnlineMeeting <IMicrosoftGraphOnlineMeetingInfo>]`: onlineMeetingInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConferenceId <String>]`: The ID of the conference.
      - `[JoinUrl <String>]`: The external link that launches the online meeting. This is a URL that clients will launch into a browser and will redirect the user to join the meeting.
      - `[Phones <IMicrosoftGraphPhone[]>]`: All of the phone numbers associated with this conference.
        - `[Language <String>]`: 
        - `[Number <String>]`: The phone number.
        - `[Region <String>]`: 
        - `[Type <String>]`: phoneType
      - `[QuickDial <String>]`: The pre-formatted quickdial for this call.
      - `[TollFreeNumbers <String[]>]`: The toll free numbers that can be used to join the conference.
      - `[TollNumber <String>]`: The toll number that can be used to join the conference.
    - `[OnlineMeetingProvider <String>]`: onlineMeetingProviderType
    - `[OnlineMeetingUrl <String>]`: 
    - `[Organizer <IMicrosoftGraphRecipient>]`: recipient
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[OriginalEndTimeZone <String>]`: 
    - `[OriginalStart <DateTime?>]`: 
    - `[OriginalStartTimeZone <String>]`: 
    - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
        - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
        - `[FirstDayOfWeek <String>]`: dayOfWeek
        - `[Index <String>]`: weekIndex
        - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
        - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
        - `[Type <String>]`: recurrencePatternType
      - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
        - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
        - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
        - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
        - `[Type <String>]`: recurrenceRangeType
    - `[ReminderMinutesBeforeStart <Int32?>]`: 
    - `[ResponseRequested <Boolean?>]`: 
    - `[ResponseStatus <IMicrosoftGraphResponseStatus>]`: responseStatus
    - `[Sensitivity <String>]`: sensitivity
    - `[SeriesMasterId <String>]`: 
    - `[ShowAs <String>]`: freeBusyStatus
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the event. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String>]`: A property value.
    - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Subject <String>]`: 
    - `[TransactionId <String>]`: 
    - `[Type <String>]`: eventType
    - `[WebLink <String>]`: 
  - `[CanEdit <Boolean?>]`: true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
  - `[CanShare <Boolean?>]`: true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
  - `[CanViewPrivateItems <Boolean?>]`: true if the user can read calendar items that have been marked private, false otherwise.
  - `[ChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[Color <String>]`: calendarColor
  - `[DefaultOnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[Events <IMicrosoftGraphEvent[]>]`: The events in the calendar. Navigation property. Read-only.
  - `[HexColor <String>]`: The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is empty. Read-only.
  - `[IsDefaultCalendar <Boolean?>]`: true if this is the default calendar where new events are created by default, false otherwise.
  - `[IsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
  - `[IsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
  - `[Name <String>]`: The calendar name.
  - `[Owner <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.

CALENDARPERMISSIONS <IMicrosoftGraphCalendarPermission[]>: The permissions of the users with whom the calendar is shared.
  - `[Id <String>]`: Read-only.
  - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of the person or entity.
    - `[Name <String>]`: The display name of the person or entity.
  - `[IsInsideOrganization <Boolean?>]`: True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
  - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.
  - `[Role <String>]`: calendarRoleType

CALENDARVIEW <IMicrosoftGraphEvent[]>: The calendar view for the calendar. Navigation property. Read-only.
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: Read-only.
  - `[AllowNewTimeProposals <Boolean?>]`: true if the meeting organizer allows invitees to propose a new time when responding; otherwise, false. Optional. Default is true.
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Name <String>]`: The attachment's file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Attendees <IMicrosoftGraphAttendee[]>]`: The collection of attendees for the event.
    - `[Type <String>]`: attendeeType
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
    - `[ProposedNewTime <IMicrosoftGraphTimeSlot>]`: timeSlot
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
        - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
      - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Status <IMicrosoftGraphResponseStatus>]`: responseStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Response <String>]`: responseType
      - `[Time <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Body <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[BodyPreview <String>]`: The preview of the message associated with the event. It is in text format.
  - `[Calendar <IMicrosoftGraphCalendar>]`: calendar
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
    - `[CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]`: The permissions of the users with whom the calendar is shared.
      - `[Id <String>]`: Read-only.
      - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
      - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[IsInsideOrganization <Boolean?>]`: True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
      - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.
      - `[Role <String>]`: calendarRoleType
    - `[CalendarView <IMicrosoftGraphEvent[]>]`: The calendar view for the calendar. Navigation property. Read-only.
    - `[CanEdit <Boolean?>]`: true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
    - `[CanShare <Boolean?>]`: true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
    - `[CanViewPrivateItems <Boolean?>]`: true if the user can read calendar items that have been marked private, false otherwise.
    - `[ChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[Color <String>]`: calendarColor
    - `[DefaultOnlineMeetingProvider <String>]`: onlineMeetingProviderType
    - `[Events <IMicrosoftGraphEvent[]>]`: The events in the calendar. Navigation property. Read-only.
    - `[HexColor <String>]`: The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is empty. Read-only.
    - `[IsDefaultCalendar <Boolean?>]`: true if this is the default calendar where new events are created by default, false otherwise.
    - `[IsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
    - `[IsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[Name <String>]`: The calendar name.
    - `[Owner <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String>]`: A property value.
  - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the event. Nullable.
    - `[Id <String>]`: Read-only.
  - `[HasAttachments <Boolean?>]`: Set to true if the event has attachments.
  - `[HideAttendees <Boolean?>]`: When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.
  - `[ICalUId <String>]`: A unique identifier for an event across calendars. This ID is different for each occurrence in a recurring series. Read-only.
  - `[Importance <String>]`: importance
  - `[Instances <IMicrosoftGraphEvent[]>]`: The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.
  - `[IsAllDay <Boolean?>]`: 
  - `[IsCancelled <Boolean?>]`: 
  - `[IsDraft <Boolean?>]`: 
  - `[IsOnlineMeeting <Boolean?>]`: 
  - `[IsOrganizer <Boolean?>]`: 
  - `[IsReminderOn <Boolean?>]`: 
  - `[Location <IMicrosoftGraphLocation>]`: location
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
    - `[Coordinates <IMicrosoftGraphOutlookGeoCoordinates>]`: outlookGeoCoordinates
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Accuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
      - `[Altitude <Double?>]`: The altitude of the location.
      - `[AltitudeAccuracy <Double?>]`: The accuracy of the altitude.
      - `[Latitude <Double?>]`: The latitude of the location.
      - `[Longitude <Double?>]`: The longitude of the location.
    - `[DisplayName <String>]`: The name associated with the location.
    - `[LocationEmailAddress <String>]`: Optional email address of the location.
    - `[LocationType <String>]`: locationType
    - `[LocationUri <String>]`: Optional URI representing the location.
    - `[UniqueId <String>]`: For internal use only.
    - `[UniqueIdType <String>]`: locationUniqueIdType
  - `[Locations <IMicrosoftGraphLocation[]>]`: 
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the event. Read-only. Nullable.
  - `[OnlineMeeting <IMicrosoftGraphOnlineMeetingInfo>]`: onlineMeetingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConferenceId <String>]`: The ID of the conference.
    - `[JoinUrl <String>]`: The external link that launches the online meeting. This is a URL that clients will launch into a browser and will redirect the user to join the meeting.
    - `[Phones <IMicrosoftGraphPhone[]>]`: All of the phone numbers associated with this conference.
      - `[Language <String>]`: 
      - `[Number <String>]`: The phone number.
      - `[Region <String>]`: 
      - `[Type <String>]`: phoneType
    - `[QuickDial <String>]`: The pre-formatted quickdial for this call.
    - `[TollFreeNumbers <String[]>]`: The toll free numbers that can be used to join the conference.
    - `[TollNumber <String>]`: The toll number that can be used to join the conference.
  - `[OnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[OnlineMeetingUrl <String>]`: 
  - `[Organizer <IMicrosoftGraphRecipient>]`: recipient
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[OriginalEndTimeZone <String>]`: 
  - `[OriginalStart <DateTime?>]`: 
  - `[OriginalStartTimeZone <String>]`: 
  - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
      - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
      - `[FirstDayOfWeek <String>]`: dayOfWeek
      - `[Index <String>]`: weekIndex
      - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
      - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
      - `[Type <String>]`: recurrencePatternType
    - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
      - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
      - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
      - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
      - `[Type <String>]`: recurrenceRangeType
  - `[ReminderMinutesBeforeStart <Int32?>]`: 
  - `[ResponseRequested <Boolean?>]`: 
  - `[ResponseStatus <IMicrosoftGraphResponseStatus>]`: responseStatus
  - `[Sensitivity <String>]`: sensitivity
  - `[SeriesMasterId <String>]`: 
  - `[ShowAs <String>]`: freeBusyStatus
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the event. Read-only. Nullable.
  - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[Subject <String>]`: 
  - `[TransactionId <String>]`: 
  - `[Type <String>]`: eventType
  - `[WebLink <String>]`: 

EVENTS <IMicrosoftGraphEvent[]>: The events in the calendar. Navigation property. Read-only.
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: Read-only.
  - `[AllowNewTimeProposals <Boolean?>]`: true if the meeting organizer allows invitees to propose a new time when responding; otherwise, false. Optional. Default is true.
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Name <String>]`: The attachment's file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Attendees <IMicrosoftGraphAttendee[]>]`: The collection of attendees for the event.
    - `[Type <String>]`: attendeeType
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
    - `[ProposedNewTime <IMicrosoftGraphTimeSlot>]`: timeSlot
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
        - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
      - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Status <IMicrosoftGraphResponseStatus>]`: responseStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Response <String>]`: responseType
      - `[Time <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Body <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[BodyPreview <String>]`: The preview of the message associated with the event. It is in text format.
  - `[Calendar <IMicrosoftGraphCalendar>]`: calendar
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
    - `[CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]`: The permissions of the users with whom the calendar is shared.
      - `[Id <String>]`: Read-only.
      - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
      - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[IsInsideOrganization <Boolean?>]`: True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
      - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.
      - `[Role <String>]`: calendarRoleType
    - `[CalendarView <IMicrosoftGraphEvent[]>]`: The calendar view for the calendar. Navigation property. Read-only.
    - `[CanEdit <Boolean?>]`: true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
    - `[CanShare <Boolean?>]`: true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
    - `[CanViewPrivateItems <Boolean?>]`: true if the user can read calendar items that have been marked private, false otherwise.
    - `[ChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[Color <String>]`: calendarColor
    - `[DefaultOnlineMeetingProvider <String>]`: onlineMeetingProviderType
    - `[Events <IMicrosoftGraphEvent[]>]`: The events in the calendar. Navigation property. Read-only.
    - `[HexColor <String>]`: The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is empty. Read-only.
    - `[IsDefaultCalendar <Boolean?>]`: true if this is the default calendar where new events are created by default, false otherwise.
    - `[IsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
    - `[IsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[Name <String>]`: The calendar name.
    - `[Owner <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String>]`: A property value.
  - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the event. Nullable.
    - `[Id <String>]`: Read-only.
  - `[HasAttachments <Boolean?>]`: Set to true if the event has attachments.
  - `[HideAttendees <Boolean?>]`: When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.
  - `[ICalUId <String>]`: A unique identifier for an event across calendars. This ID is different for each occurrence in a recurring series. Read-only.
  - `[Importance <String>]`: importance
  - `[Instances <IMicrosoftGraphEvent[]>]`: The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.
  - `[IsAllDay <Boolean?>]`: 
  - `[IsCancelled <Boolean?>]`: 
  - `[IsDraft <Boolean?>]`: 
  - `[IsOnlineMeeting <Boolean?>]`: 
  - `[IsOrganizer <Boolean?>]`: 
  - `[IsReminderOn <Boolean?>]`: 
  - `[Location <IMicrosoftGraphLocation>]`: location
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
    - `[Coordinates <IMicrosoftGraphOutlookGeoCoordinates>]`: outlookGeoCoordinates
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Accuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
      - `[Altitude <Double?>]`: The altitude of the location.
      - `[AltitudeAccuracy <Double?>]`: The accuracy of the altitude.
      - `[Latitude <Double?>]`: The latitude of the location.
      - `[Longitude <Double?>]`: The longitude of the location.
    - `[DisplayName <String>]`: The name associated with the location.
    - `[LocationEmailAddress <String>]`: Optional email address of the location.
    - `[LocationType <String>]`: locationType
    - `[LocationUri <String>]`: Optional URI representing the location.
    - `[UniqueId <String>]`: For internal use only.
    - `[UniqueIdType <String>]`: locationUniqueIdType
  - `[Locations <IMicrosoftGraphLocation[]>]`: 
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the event. Read-only. Nullable.
  - `[OnlineMeeting <IMicrosoftGraphOnlineMeetingInfo>]`: onlineMeetingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConferenceId <String>]`: The ID of the conference.
    - `[JoinUrl <String>]`: The external link that launches the online meeting. This is a URL that clients will launch into a browser and will redirect the user to join the meeting.
    - `[Phones <IMicrosoftGraphPhone[]>]`: All of the phone numbers associated with this conference.
      - `[Language <String>]`: 
      - `[Number <String>]`: The phone number.
      - `[Region <String>]`: 
      - `[Type <String>]`: phoneType
    - `[QuickDial <String>]`: The pre-formatted quickdial for this call.
    - `[TollFreeNumbers <String[]>]`: The toll free numbers that can be used to join the conference.
    - `[TollNumber <String>]`: The toll number that can be used to join the conference.
  - `[OnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[OnlineMeetingUrl <String>]`: 
  - `[Organizer <IMicrosoftGraphRecipient>]`: recipient
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[OriginalEndTimeZone <String>]`: 
  - `[OriginalStart <DateTime?>]`: 
  - `[OriginalStartTimeZone <String>]`: 
  - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
      - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
      - `[FirstDayOfWeek <String>]`: dayOfWeek
      - `[Index <String>]`: weekIndex
      - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
      - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
      - `[Type <String>]`: recurrencePatternType
    - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
      - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
      - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
      - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
      - `[Type <String>]`: recurrenceRangeType
  - `[ReminderMinutesBeforeStart <Int32?>]`: 
  - `[ResponseRequested <Boolean?>]`: 
  - `[ResponseStatus <IMicrosoftGraphResponseStatus>]`: responseStatus
  - `[Sensitivity <String>]`: sensitivity
  - `[SeriesMasterId <String>]`: 
  - `[ShowAs <String>]`: freeBusyStatus
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the event. Read-only. Nullable.
  - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[Subject <String>]`: 
  - `[TransactionId <String>]`: 
  - `[Type <String>]`: eventType
  - `[WebLink <String>]`: 

INPUTOBJECT <ICalendarIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: id of attachment
  - `[CalendarGroupId <String>]`: key: id of calendarGroup
  - `[CalendarId <String>]`: key: id of calendar
  - `[CalendarPermissionId <String>]`: key: id of calendarPermission
  - `[EventId <String>]`: key: id of event
  - `[EventId1 <String>]`: key: id of event
  - `[ExtensionId <String>]`: key: id of extension
  - `[GroupId <String>]`: key: id of group
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[PlaceId <String>]`: key: id of place
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: key: id of user

MULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String[]>]`: A collection of property values.

OWNER <IMicrosoftGraphEmailAddress>: emailAddress
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Address <String>]`: The email address of the person or entity.
  - `[Name <String>]`: The display name of the person or entity.

SINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String>]`: A property value.

## RELATED LINKS

