---
external help file:
Module Name: Microsoft.Graph.Beta.Calendar
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.calendar/new-mgbetausercalendargroupcalendar
schema: 2.0.0
---

# New-MgBetaUserCalendarGroupCalendar

## SYNOPSIS
Use this API to create a new calendar in a calendar group for a user.
This API is available in the following national cloud deployments.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaUserCalendarGroupCalendar -CalendarGroupId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-AllowedOnlineMeetingProviders <String[]>] [-CalendarGroupId1 <String>]
 [-CalendarPermissions <IMicrosoftGraphCalendarPermission[]>] [-CalendarView <IMicrosoftGraphEvent[]>]
 [-CanEdit] [-CanShare] [-CanViewPrivateItems] [-ChangeKey <String>] [-Color <String>]
 [-DefaultOnlineMeetingProvider <String>] [-Events <IMicrosoftGraphEvent[]>] [-HexColor <String>]
 [-Id <String>] [-IsDefaultCalendar] [-IsRemovable] [-IsShared] [-IsSharedWithMe] [-IsTallyingResponses]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-Name <String>]
 [-Owner <IMicrosoftGraphEmailAddress>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaUserCalendarGroupCalendar -CalendarGroupId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphCalendar> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaUserCalendarGroupCalendar -InputObject <ICalendarIdentity> -BodyParameter <IMicrosoftGraphCalendar>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaUserCalendarGroupCalendar -InputObject <ICalendarIdentity> [-CalendarGroupId <String>]
 [-AdditionalProperties <Hashtable>] [-AllowedOnlineMeetingProviders <String[]>]
 [-CalendarPermissions <IMicrosoftGraphCalendarPermission[]>] [-CalendarView <IMicrosoftGraphEvent[]>]
 [-CanEdit] [-CanShare] [-CanViewPrivateItems] [-ChangeKey <String>] [-Color <String>]
 [-DefaultOnlineMeetingProvider <String>] [-Events <IMicrosoftGraphEvent[]>] [-HexColor <String>]
 [-Id <String>] [-IsDefaultCalendar] [-IsRemovable] [-IsShared] [-IsSharedWithMe] [-IsTallyingResponses]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-Name <String>]
 [-Owner <IMicrosoftGraphEmailAddress>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Use this API to create a new calendar in a calendar group for a user.
This API is available in the following national cloud deployments.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
```

$params = @{
	name = "Marketing calendar"
}

# A UPN can also be used as -UserId.
New-MgBetaUserCalendarGroupCalendar -UserId $userId -CalendarGroupId $calendarGroupId -BodyParameter $params

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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCalendar
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CalendarGroupId
The unique identifier of calendarGroup

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarGroupId1
The calendarGroup in which to create the calendar.
If the user has never explicitly set a group for the calendar, this property is null.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarPermissions
The permissions of the users with whom the calendar is shared.
To construct, see NOTES section for CALENDARPERMISSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCalendarPermission[]
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
To construct, see NOTES section for CALENDARVIEW properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEvent[]
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
This property is also true for a user who has been shared a calendar and granted write access, through an Outlook client or the corresponding calendarPermission resource.
Read-only.

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
Read-only.

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
This property is set through an Outlook client or the corresponding calendarPermission resource.
Read-only.

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
To construct, see NOTES section for EVENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEvent[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.ICalendarIdentity
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

### -IsShared
true if the user has shared the calendar with other users, false otherwise.
Since only the user who created the calendar can share it, isShared and isSharedWithMe cannot be true for the same user.
This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource.
Read-only.

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

### -IsSharedWithMe
true if the user has been shared this calendar, false otherwise.
This property is always false for a calendar owner.
This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource.
Read-only.

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
To construct, see NOTES section for MULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]
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
To construct, see NOTES section for OWNER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEmailAddress
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
To construct, see NOTES section for SINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

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

### Microsoft.Graph.Beta.PowerShell.Models.ICalendarIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCalendar

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCalendar

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphCalendar>`: calendar
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
  - `[CalendarGroupId <String>]`: The calendarGroup in which to create the calendar. If the user has never explicitly set a group for the calendar, this property is  null.
  - `[CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]`: The permissions of the users with whom the calendar is shared.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of an entity instance.
      - `[Name <String>]`: The display name of an entity instance.
    - `[IsInsideOrganization <Boolean?>]`: True if the user in context (share recipient or delegate) is inside the same organization as the calendar owner.
    - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of recipients or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You can't remove 'My organization' as a recipient to a calendar.
    - `[Role <String>]`: calendarRoleType
  - `[CalendarView <IMicrosoftGraphEvent[]>]`: The calendar view for the calendar. Navigation property. Read-only.
    - `[Categories <String[]>]`: 
    - `[ChangeKey <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AllowNewTimeProposals <Boolean?>]`: true if the meeting organizer allows invitees to propose a new time when responding; otherwise false. Optional. Default is true.
    - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ContentType <String>]`: The MIME type.
      - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Name <String>]`: The display name of the attachment. This does not need to be the actual file name.
      - `[Size <Int32?>]`: The length of the attachment in bytes.
    - `[Attendees <IMicrosoftGraphAttendee[]>]`: The collection of attendees for the event.
      - `[Type <String>]`: attendeeType
      - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[ProposedNewTime <IMicrosoftGraphTimeSlot>]`: timeSlot
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
          - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
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
    - `[CancelledOccurrences <String[]>]`: Contains occurrenceId property values of cancelled instances in a recurring series, if the event is the series master. Instances in a recurring series that are cancelled are called cancelledOccurences.Returned only on $select in a Get operation which specifies the id of a series master event (that is, the seriesMasterId property value).
    - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[ExceptionOccurrences <IMicrosoftGraphEvent[]>]`: 
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the event. Nullable.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[HasAttachments <Boolean?>]`: Set to true if the event has attachments.
    - `[HideAttendees <Boolean?>]`: When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.
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
        - `[PostOfficeBox <String>]`: The post office box number.
        - `[PostalCode <String>]`: The postal code.
        - `[State <String>]`: The state.
        - `[Street <String>]`: The street.
        - `[Type <String>]`: physicalAddressType
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
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[OccurrenceId <String>]`: 
    - `[OnlineMeeting <IMicrosoftGraphOnlineMeetingInfo>]`: onlineMeetingInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConferenceId <String>]`: The ID of the conference.
      - `[JoinUrl <String>]`: The external link that launches the online meeting. This is a URL that clients launch into a browser and will redirect the user to join the meeting.
      - `[Phones <IMicrosoftGraphPhone[]>]`: All of the phone numbers associated with this conference.
        - `[Number <String>]`: The phone number.
        - `[Type <String>]`: phoneType
      - `[QuickDial <String>]`: The preformatted quick dial for this call.
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
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Value <String>]`: A property value.
    - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Subject <String>]`: 
    - `[TransactionId <String>]`: 
    - `[Type <String>]`: eventType
    - `[Uid <String>]`: 
    - `[WebLink <String>]`: 
  - `[CanEdit <Boolean?>]`: true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access, through an Outlook client or the corresponding calendarPermission resource. Read-only.
  - `[CanShare <Boolean?>]`: true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it. Read-only.
  - `[CanViewPrivateItems <Boolean?>]`: true if the user can read calendar items that have been marked private, false otherwise. This property is set through an Outlook client or the corresponding calendarPermission resource. Read-only.
  - `[ChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[Color <String>]`: calendarColor
  - `[DefaultOnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[Events <IMicrosoftGraphEvent[]>]`: The events in the calendar. Navigation property. Read-only.
  - `[HexColor <String>]`: The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is  empty.
  - `[IsDefaultCalendar <Boolean?>]`: true if this is the default calendar where new events are created by default, false otherwise.
  - `[IsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
  - `[IsShared <Boolean?>]`: true if the user has shared the calendar with other users, false otherwise. Since only the user who created the calendar can share it, isShared and isSharedWithMe cannot be true for the same user. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.
  - `[IsSharedWithMe <Boolean?>]`: true if the user has been shared this calendar, false otherwise. This property is always false for a calendar owner. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.
  - `[IsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
  - `[Name <String>]`: The calendar name.
  - `[Owner <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.

`CALENDARPERMISSIONS <IMicrosoftGraphCalendarPermission[]>`: The permissions of the users with whom the calendar is shared.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.
  - `[IsInsideOrganization <Boolean?>]`: True if the user in context (share recipient or delegate) is inside the same organization as the calendar owner.
  - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of recipients or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You can't remove 'My organization' as a recipient to a calendar.
  - `[Role <String>]`: calendarRoleType

`CALENDARVIEW <IMicrosoftGraphEvent[]>`: The calendar view for the calendar. Navigation property. Read-only.
  - `[Categories <String[]>]`: 
  - `[ChangeKey <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowNewTimeProposals <Boolean?>]`: true if the meeting organizer allows invitees to propose a new time when responding; otherwise false. Optional. Default is true.
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Name <String>]`: The display name of the attachment. This does not need to be the actual file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Attendees <IMicrosoftGraphAttendee[]>]`: The collection of attendees for the event.
    - `[Type <String>]`: attendeeType
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of an entity instance.
      - `[Name <String>]`: The display name of an entity instance.
    - `[ProposedNewTime <IMicrosoftGraphTimeSlot>]`: timeSlot
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
        - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
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
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
    - `[CalendarGroupId <String>]`: The calendarGroup in which to create the calendar. If the user has never explicitly set a group for the calendar, this property is  null.
    - `[CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]`: The permissions of the users with whom the calendar is shared.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
      - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[IsInsideOrganization <Boolean?>]`: True if the user in context (share recipient or delegate) is inside the same organization as the calendar owner.
      - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of recipients or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You can't remove 'My organization' as a recipient to a calendar.
      - `[Role <String>]`: calendarRoleType
    - `[CalendarView <IMicrosoftGraphEvent[]>]`: The calendar view for the calendar. Navigation property. Read-only.
    - `[CanEdit <Boolean?>]`: true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access, through an Outlook client or the corresponding calendarPermission resource. Read-only.
    - `[CanShare <Boolean?>]`: true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it. Read-only.
    - `[CanViewPrivateItems <Boolean?>]`: true if the user can read calendar items that have been marked private, false otherwise. This property is set through an Outlook client or the corresponding calendarPermission resource. Read-only.
    - `[ChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[Color <String>]`: calendarColor
    - `[DefaultOnlineMeetingProvider <String>]`: onlineMeetingProviderType
    - `[Events <IMicrosoftGraphEvent[]>]`: The events in the calendar. Navigation property. Read-only.
    - `[HexColor <String>]`: The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is  empty.
    - `[IsDefaultCalendar <Boolean?>]`: true if this is the default calendar where new events are created by default, false otherwise.
    - `[IsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
    - `[IsShared <Boolean?>]`: true if the user has shared the calendar with other users, false otherwise. Since only the user who created the calendar can share it, isShared and isSharedWithMe cannot be true for the same user. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.
    - `[IsSharedWithMe <Boolean?>]`: true if the user has been shared this calendar, false otherwise. This property is always false for a calendar owner. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.
    - `[IsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[Name <String>]`: The calendar name.
    - `[Owner <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Value <String>]`: A property value.
  - `[CancelledOccurrences <String[]>]`: Contains occurrenceId property values of cancelled instances in a recurring series, if the event is the series master. Instances in a recurring series that are cancelled are called cancelledOccurences.Returned only on $select in a Get operation which specifies the id of a series master event (that is, the seriesMasterId property value).
  - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[ExceptionOccurrences <IMicrosoftGraphEvent[]>]`: 
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the event. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[HasAttachments <Boolean?>]`: Set to true if the event has attachments.
  - `[HideAttendees <Boolean?>]`: When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.
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
      - `[PostOfficeBox <String>]`: The post office box number.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
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
  - `[OccurrenceId <String>]`: 
  - `[OnlineMeeting <IMicrosoftGraphOnlineMeetingInfo>]`: onlineMeetingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConferenceId <String>]`: The ID of the conference.
    - `[JoinUrl <String>]`: The external link that launches the online meeting. This is a URL that clients launch into a browser and will redirect the user to join the meeting.
    - `[Phones <IMicrosoftGraphPhone[]>]`: All of the phone numbers associated with this conference.
      - `[Number <String>]`: The phone number.
      - `[Type <String>]`: phoneType
    - `[QuickDial <String>]`: The preformatted quick dial for this call.
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
  - `[Uid <String>]`: 
  - `[WebLink <String>]`: 

`EVENTS <IMicrosoftGraphEvent[]>`: The events in the calendar. Navigation property. Read-only.
  - `[Categories <String[]>]`: 
  - `[ChangeKey <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowNewTimeProposals <Boolean?>]`: true if the meeting organizer allows invitees to propose a new time when responding; otherwise false. Optional. Default is true.
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Name <String>]`: The display name of the attachment. This does not need to be the actual file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Attendees <IMicrosoftGraphAttendee[]>]`: The collection of attendees for the event.
    - `[Type <String>]`: attendeeType
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of an entity instance.
      - `[Name <String>]`: The display name of an entity instance.
    - `[ProposedNewTime <IMicrosoftGraphTimeSlot>]`: timeSlot
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
        - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
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
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
    - `[CalendarGroupId <String>]`: The calendarGroup in which to create the calendar. If the user has never explicitly set a group for the calendar, this property is  null.
    - `[CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]`: The permissions of the users with whom the calendar is shared.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
      - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[IsInsideOrganization <Boolean?>]`: True if the user in context (share recipient or delegate) is inside the same organization as the calendar owner.
      - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of recipients or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You can't remove 'My organization' as a recipient to a calendar.
      - `[Role <String>]`: calendarRoleType
    - `[CalendarView <IMicrosoftGraphEvent[]>]`: The calendar view for the calendar. Navigation property. Read-only.
    - `[CanEdit <Boolean?>]`: true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access, through an Outlook client or the corresponding calendarPermission resource. Read-only.
    - `[CanShare <Boolean?>]`: true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it. Read-only.
    - `[CanViewPrivateItems <Boolean?>]`: true if the user can read calendar items that have been marked private, false otherwise. This property is set through an Outlook client or the corresponding calendarPermission resource. Read-only.
    - `[ChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[Color <String>]`: calendarColor
    - `[DefaultOnlineMeetingProvider <String>]`: onlineMeetingProviderType
    - `[Events <IMicrosoftGraphEvent[]>]`: The events in the calendar. Navigation property. Read-only.
    - `[HexColor <String>]`: The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is  empty.
    - `[IsDefaultCalendar <Boolean?>]`: true if this is the default calendar where new events are created by default, false otherwise.
    - `[IsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
    - `[IsShared <Boolean?>]`: true if the user has shared the calendar with other users, false otherwise. Since only the user who created the calendar can share it, isShared and isSharedWithMe cannot be true for the same user. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.
    - `[IsSharedWithMe <Boolean?>]`: true if the user has been shared this calendar, false otherwise. This property is always false for a calendar owner. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.
    - `[IsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[Name <String>]`: The calendar name.
    - `[Owner <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Value <String>]`: A property value.
  - `[CancelledOccurrences <String[]>]`: Contains occurrenceId property values of cancelled instances in a recurring series, if the event is the series master. Instances in a recurring series that are cancelled are called cancelledOccurences.Returned only on $select in a Get operation which specifies the id of a series master event (that is, the seriesMasterId property value).
  - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[ExceptionOccurrences <IMicrosoftGraphEvent[]>]`: 
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the event. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[HasAttachments <Boolean?>]`: Set to true if the event has attachments.
  - `[HideAttendees <Boolean?>]`: When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.
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
      - `[PostOfficeBox <String>]`: The post office box number.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
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
  - `[OccurrenceId <String>]`: 
  - `[OnlineMeeting <IMicrosoftGraphOnlineMeetingInfo>]`: onlineMeetingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConferenceId <String>]`: The ID of the conference.
    - `[JoinUrl <String>]`: The external link that launches the online meeting. This is a URL that clients launch into a browser and will redirect the user to join the meeting.
    - `[Phones <IMicrosoftGraphPhone[]>]`: All of the phone numbers associated with this conference.
      - `[Number <String>]`: The phone number.
      - `[Type <String>]`: phoneType
    - `[QuickDial <String>]`: The preformatted quick dial for this call.
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
  - `[Uid <String>]`: 
  - `[WebLink <String>]`: 

`INPUTOBJECT <ICalendarIdentity>`: Identity Parameter
  - `[AttachmentId <String>]`: The unique identifier of attachment
  - `[CalendarGroupId <String>]`: The unique identifier of calendarGroup
  - `[CalendarId <String>]`: The unique identifier of calendar
  - `[CalendarPermissionId <String>]`: The unique identifier of calendarPermission
  - `[EventId <String>]`: The unique identifier of event
  - `[EventId1 <String>]`: The unique identifier of event
  - `[EventId2 <String>]`: The unique identifier of event
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[GroupId <String>]`: The unique identifier of group
  - `[PlaceId <String>]`: The unique identifier of place
  - `[UserId <String>]`: The unique identifier of user

`MULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Value <String[]>]`: A collection of property values.

`OWNER <IMicrosoftGraphEmailAddress>`: emailAddress
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Address <String>]`: The email address of an entity instance.
  - `[Name <String>]`: The display name of an entity instance.

`SINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Value <String>]`: A property value.

## RELATED LINKS

