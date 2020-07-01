---
external help file:
Module Name: Microsoft.Graph.Users.Calendar
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.calendar/new-mgusercalendarviewinstance
schema: 2.0.0
---

# New-MgUserCalendarViewInstance

## SYNOPSIS
Create new navigation property to instances for users

## SYNTAX

### CreateExpanded3 (Default)
```
New-MgUserCalendarViewInstance -EventId <String> -UserId <String> [-CalendarId <String>]
 [-AddressCity <String>] [-AddressCountryOrRegion <String>] [-AddressPostalCode <String>]
 [-AddressState <String>] [-AddressStreet <String>] [-AllowNewTimeProposals]
 [-Attachments <IMicrosoftGraphAttachment[]>] [-Attendees <IMicrosoftGraphAttendee[]>] [-BodyContent <String>]
 [-BodyContentType <String>] [-BodyPreview <String>] [-CalendarAllowedOnlineMeetingProviders <String[]>]
 [-CalendarCanEdit] [-CalendarCanShare] [-CalendarCanViewPrivateItems] [-CalendarChangeKey <String>]
 [-CalendarColor <String>] [-CalendarDefaultOnlineMeetingProvider <String>]
 [-CalendarEvents <IMicrosoftGraphEvent1[]>] [-CalendarIsRemovable] [-CalendarIsTallyingResponses]
 [-CalendarMultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-CalendarName <String>] [-CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]
 [-CalendarSingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-CalendarView <IMicrosoftGraphEvent1[]>] [-Categories <String[]>] [-ChangeKey <String>]
 [-CoordinateAccuracy <Double>] [-CoordinateAltitude <Double>] [-CoordinateAltitudeAccuracy <Double>]
 [-CoordinateLatitude <Double>] [-CoordinateLongitude <Double>] [-CreatedDateTime <DateTime>]
 [-EndDateTime <String>] [-EndTimeZone <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-HasAttachments]
 [-ICalUId <String>] [-Id <String>] [-Importance <String>] [-Instances <IMicrosoftGraphEvent1[]>] [-IsAllDay]
 [-IsCancelled] [-IsOnlineMeeting] [-IsOrganizer] [-IsReminderOn] [-LastModifiedDateTime <DateTime>]
 [-LocationDisplayName <String>] [-LocationEmailAddress <String>] [-Locations <IMicrosoftGraphLocation1[]>]
 [-LocationType <String>] [-LocationUniqueId <String>] [-LocationUniqueIdType <String>]
 [-LocationUri <String>] [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-OnlineMeetingConferenceId <String>] [-OnlineMeetingJoinUrl <String>]
 [-OnlineMeetingPhones <IMicrosoftGraphPhone1[]>] [-OnlineMeetingProvider <String>]
 [-OnlineMeetingQuickDial <String>] [-OnlineMeetingTollFreeNumbers <String[]>]
 [-OnlineMeetingTollNumber <String>] [-OnlineMeetingUrl <String>] [-Organizer <IMicrosoftGraphRecipient>]
 [-OriginalEndTimeZone <String>] [-OriginalStart <DateTime>] [-OriginalStartTimeZone <String>]
 [-OwnerAddress <String>] [-OwnerName <String>] [-PatternDayOfMonth <Int32>] [-PatternDaysOfWeek <String[]>]
 [-PatternFirstDayOfWeek <String>] [-PatternIndex <String>] [-PatternInterval <Int32>] [-PatternMonth <Int32>]
 [-PatternType <String>] [-RangeEndDate <DateTime>] [-RangeNumberOfOccurrences <Int32>]
 [-RangeRecurrenceTimeZone <String>] [-RangeStartDate <DateTime>] [-RangeType <String>]
 [-ReminderMinutesBeforeStart <Int32>] [-ResponseRequested] [-ResponseStatusResponse <String>]
 [-ResponseStatusTime <DateTime>] [-Sensitivity <String>] [-SeriesMasterId <String>] [-ShowAs <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-StartDateTime <String>] [-StartTimeZone <String>] [-Subject <String>] [-Type <String>] [-WebLink <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create3
```
New-MgUserCalendarViewInstance -EventId <String> -UserId <String> -BodyParameter <IMicrosoftGraphEvent1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create4
```
New-MgUserCalendarViewInstance -CalendarId <String> -EventId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphEvent1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create5
```
New-MgUserCalendarViewInstance -EventId <String> -UserId <String> -BodyParameter <IMicrosoftGraphEvent1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded4
```
New-MgUserCalendarViewInstance -CalendarId <String> -EventId <String> -UserId <String> [-AddressCity <String>]
 [-AddressCountryOrRegion <String>] [-AddressPostalCode <String>] [-AddressState <String>]
 [-AddressStreet <String>] [-AllowNewTimeProposals] [-Attachments <IMicrosoftGraphAttachment[]>]
 [-Attendees <IMicrosoftGraphAttendee[]>] [-BodyContent <String>] [-BodyContentType <String>]
 [-BodyPreview <String>] [-CalendarAllowedOnlineMeetingProviders <String[]>] [-CalendarCanEdit]
 [-CalendarCanShare] [-CalendarCanViewPrivateItems] [-CalendarChangeKey <String>] [-CalendarColor <String>]
 [-CalendarDefaultOnlineMeetingProvider <String>] [-CalendarEvents <IMicrosoftGraphEvent1[]>]
 [-CalendarIsRemovable] [-CalendarIsTallyingResponses]
 [-CalendarMultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-CalendarName <String>] [-CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]
 [-CalendarSingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-CalendarView <IMicrosoftGraphEvent1[]>] [-Categories <String[]>] [-ChangeKey <String>]
 [-CoordinateAccuracy <Double>] [-CoordinateAltitude <Double>] [-CoordinateAltitudeAccuracy <Double>]
 [-CoordinateLatitude <Double>] [-CoordinateLongitude <Double>] [-CreatedDateTime <DateTime>]
 [-EndDateTime <String>] [-EndTimeZone <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-HasAttachments]
 [-ICalUId <String>] [-Id <String>] [-Importance <String>] [-Instances <IMicrosoftGraphEvent1[]>] [-IsAllDay]
 [-IsCancelled] [-IsOnlineMeeting] [-IsOrganizer] [-IsReminderOn] [-LastModifiedDateTime <DateTime>]
 [-LocationDisplayName <String>] [-LocationEmailAddress <String>] [-Locations <IMicrosoftGraphLocation1[]>]
 [-LocationType <String>] [-LocationUniqueId <String>] [-LocationUniqueIdType <String>]
 [-LocationUri <String>] [-MicrosoftGraphEntityId <String>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-OnlineMeetingConferenceId <String>] [-OnlineMeetingJoinUrl <String>]
 [-OnlineMeetingPhones <IMicrosoftGraphPhone1[]>] [-OnlineMeetingProvider <String>]
 [-OnlineMeetingQuickDial <String>] [-OnlineMeetingTollFreeNumbers <String[]>]
 [-OnlineMeetingTollNumber <String>] [-OnlineMeetingUrl <String>] [-Organizer <IMicrosoftGraphRecipient>]
 [-OriginalEndTimeZone <String>] [-OriginalStart <DateTime>] [-OriginalStartTimeZone <String>]
 [-OwnerAddress <String>] [-OwnerName <String>] [-PatternDayOfMonth <Int32>] [-PatternDaysOfWeek <String[]>]
 [-PatternFirstDayOfWeek <String>] [-PatternIndex <String>] [-PatternInterval <Int32>] [-PatternMonth <Int32>]
 [-PatternType <String>] [-RangeEndDate <DateTime>] [-RangeNumberOfOccurrences <Int32>]
 [-RangeRecurrenceTimeZone <String>] [-RangeStartDate <DateTime>] [-RangeType <String>]
 [-ReminderMinutesBeforeStart <Int32>] [-ResponseRequested] [-ResponseStatusResponse <String>]
 [-ResponseStatusTime <DateTime>] [-Sensitivity <String>] [-SeriesMasterId <String>] [-ShowAs <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-StartDateTime <String>] [-StartTimeZone <String>] [-Subject <String>] [-Type <String>] [-WebLink <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded5
```
New-MgUserCalendarViewInstance -EventId <String> -UserId <String> [-CalendarId <String>]
 [-AddressCity <String>] [-AddressCountryOrRegion <String>] [-AddressPostalCode <String>]
 [-AddressState <String>] [-AddressStreet <String>] [-AllowNewTimeProposals]
 [-Attachments <IMicrosoftGraphAttachment[]>] [-Attendees <IMicrosoftGraphAttendee[]>] [-BodyContent <String>]
 [-BodyContentType <String>] [-BodyPreview <String>] [-CalendarAllowedOnlineMeetingProviders <String[]>]
 [-CalendarCanEdit] [-CalendarCanShare] [-CalendarCanViewPrivateItems] [-CalendarChangeKey <String>]
 [-CalendarColor <String>] [-CalendarDefaultOnlineMeetingProvider <String>]
 [-CalendarEvents <IMicrosoftGraphEvent1[]>] [-CalendarIsRemovable] [-CalendarIsTallyingResponses]
 [-CalendarMultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-CalendarName <String>] [-CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]
 [-CalendarSingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-CalendarView <IMicrosoftGraphEvent1[]>] [-Categories <String[]>] [-ChangeKey <String>]
 [-CoordinateAccuracy <Double>] [-CoordinateAltitude <Double>] [-CoordinateAltitudeAccuracy <Double>]
 [-CoordinateLatitude <Double>] [-CoordinateLongitude <Double>] [-CreatedDateTime <DateTime>]
 [-EndDateTime <String>] [-EndTimeZone <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-HasAttachments]
 [-ICalUId <String>] [-Id <String>] [-Importance <String>] [-Instances <IMicrosoftGraphEvent1[]>] [-IsAllDay]
 [-IsCancelled] [-IsOnlineMeeting] [-IsOrganizer] [-IsReminderOn] [-LastModifiedDateTime <DateTime>]
 [-LocationDisplayName <String>] [-LocationEmailAddress <String>] [-Locations <IMicrosoftGraphLocation1[]>]
 [-LocationType <String>] [-LocationUniqueId <String>] [-LocationUniqueIdType <String>]
 [-LocationUri <String>] [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-OnlineMeetingConferenceId <String>] [-OnlineMeetingJoinUrl <String>]
 [-OnlineMeetingPhones <IMicrosoftGraphPhone1[]>] [-OnlineMeetingProvider <String>]
 [-OnlineMeetingQuickDial <String>] [-OnlineMeetingTollFreeNumbers <String[]>]
 [-OnlineMeetingTollNumber <String>] [-OnlineMeetingUrl <String>] [-Organizer <IMicrosoftGraphRecipient>]
 [-OriginalEndTimeZone <String>] [-OriginalStart <DateTime>] [-OriginalStartTimeZone <String>]
 [-OwnerAddress <String>] [-OwnerName <String>] [-PatternDayOfMonth <Int32>] [-PatternDaysOfWeek <String[]>]
 [-PatternFirstDayOfWeek <String>] [-PatternIndex <String>] [-PatternInterval <Int32>] [-PatternMonth <Int32>]
 [-PatternType <String>] [-RangeEndDate <DateTime>] [-RangeNumberOfOccurrences <Int32>]
 [-RangeRecurrenceTimeZone <String>] [-RangeStartDate <DateTime>] [-RangeType <String>]
 [-ReminderMinutesBeforeStart <Int32>] [-ResponseRequested] [-ResponseStatusResponse <String>]
 [-ResponseStatusTime <DateTime>] [-Sensitivity <String>] [-SeriesMasterId <String>] [-ShowAs <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-StartDateTime <String>] [-StartTimeZone <String>] [-Subject <String>] [-Type <String>] [-WebLink <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity3
```
New-MgUserCalendarViewInstance -InputObject <IUsersCalendarIdentity> -BodyParameter <IMicrosoftGraphEvent1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity4
```
New-MgUserCalendarViewInstance -InputObject <IUsersCalendarIdentity> -BodyParameter <IMicrosoftGraphEvent1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity5
```
New-MgUserCalendarViewInstance -InputObject <IUsersCalendarIdentity> -BodyParameter <IMicrosoftGraphEvent1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded3
```
New-MgUserCalendarViewInstance -InputObject <IUsersCalendarIdentity> [-CalendarId <String>]
 [-AddressCity <String>] [-AddressCountryOrRegion <String>] [-AddressPostalCode <String>]
 [-AddressState <String>] [-AddressStreet <String>] [-AllowNewTimeProposals]
 [-Attachments <IMicrosoftGraphAttachment[]>] [-Attendees <IMicrosoftGraphAttendee[]>] [-BodyContent <String>]
 [-BodyContentType <String>] [-BodyPreview <String>] [-CalendarAllowedOnlineMeetingProviders <String[]>]
 [-CalendarCanEdit] [-CalendarCanShare] [-CalendarCanViewPrivateItems] [-CalendarChangeKey <String>]
 [-CalendarColor <String>] [-CalendarDefaultOnlineMeetingProvider <String>]
 [-CalendarEvents <IMicrosoftGraphEvent1[]>] [-CalendarIsRemovable] [-CalendarIsTallyingResponses]
 [-CalendarMultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-CalendarName <String>] [-CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]
 [-CalendarSingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-CalendarView <IMicrosoftGraphEvent1[]>] [-Categories <String[]>] [-ChangeKey <String>]
 [-CoordinateAccuracy <Double>] [-CoordinateAltitude <Double>] [-CoordinateAltitudeAccuracy <Double>]
 [-CoordinateLatitude <Double>] [-CoordinateLongitude <Double>] [-CreatedDateTime <DateTime>]
 [-EndDateTime <String>] [-EndTimeZone <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-HasAttachments]
 [-ICalUId <String>] [-Id <String>] [-Importance <String>] [-Instances <IMicrosoftGraphEvent1[]>] [-IsAllDay]
 [-IsCancelled] [-IsOnlineMeeting] [-IsOrganizer] [-IsReminderOn] [-LastModifiedDateTime <DateTime>]
 [-LocationDisplayName <String>] [-LocationEmailAddress <String>] [-Locations <IMicrosoftGraphLocation1[]>]
 [-LocationType <String>] [-LocationUniqueId <String>] [-LocationUniqueIdType <String>]
 [-LocationUri <String>] [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-OnlineMeetingConferenceId <String>] [-OnlineMeetingJoinUrl <String>]
 [-OnlineMeetingPhones <IMicrosoftGraphPhone1[]>] [-OnlineMeetingProvider <String>]
 [-OnlineMeetingQuickDial <String>] [-OnlineMeetingTollFreeNumbers <String[]>]
 [-OnlineMeetingTollNumber <String>] [-OnlineMeetingUrl <String>] [-Organizer <IMicrosoftGraphRecipient>]
 [-OriginalEndTimeZone <String>] [-OriginalStart <DateTime>] [-OriginalStartTimeZone <String>]
 [-OwnerAddress <String>] [-OwnerName <String>] [-PatternDayOfMonth <Int32>] [-PatternDaysOfWeek <String[]>]
 [-PatternFirstDayOfWeek <String>] [-PatternIndex <String>] [-PatternInterval <Int32>] [-PatternMonth <Int32>]
 [-PatternType <String>] [-RangeEndDate <DateTime>] [-RangeNumberOfOccurrences <Int32>]
 [-RangeRecurrenceTimeZone <String>] [-RangeStartDate <DateTime>] [-RangeType <String>]
 [-ReminderMinutesBeforeStart <Int32>] [-ResponseRequested] [-ResponseStatusResponse <String>]
 [-ResponseStatusTime <DateTime>] [-Sensitivity <String>] [-SeriesMasterId <String>] [-ShowAs <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-StartDateTime <String>] [-StartTimeZone <String>] [-Subject <String>] [-Type <String>] [-WebLink <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded4
```
New-MgUserCalendarViewInstance -InputObject <IUsersCalendarIdentity> [-CalendarId <String>]
 [-AddressCity <String>] [-AddressCountryOrRegion <String>] [-AddressPostalCode <String>]
 [-AddressState <String>] [-AddressStreet <String>] [-AllowNewTimeProposals]
 [-Attachments <IMicrosoftGraphAttachment[]>] [-Attendees <IMicrosoftGraphAttendee[]>] [-BodyContent <String>]
 [-BodyContentType <String>] [-BodyPreview <String>] [-CalendarAllowedOnlineMeetingProviders <String[]>]
 [-CalendarCanEdit] [-CalendarCanShare] [-CalendarCanViewPrivateItems] [-CalendarChangeKey <String>]
 [-CalendarColor <String>] [-CalendarDefaultOnlineMeetingProvider <String>]
 [-CalendarEvents <IMicrosoftGraphEvent1[]>] [-CalendarIsRemovable] [-CalendarIsTallyingResponses]
 [-CalendarMultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-CalendarName <String>] [-CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]
 [-CalendarSingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-CalendarView <IMicrosoftGraphEvent1[]>] [-Categories <String[]>] [-ChangeKey <String>]
 [-CoordinateAccuracy <Double>] [-CoordinateAltitude <Double>] [-CoordinateAltitudeAccuracy <Double>]
 [-CoordinateLatitude <Double>] [-CoordinateLongitude <Double>] [-CreatedDateTime <DateTime>]
 [-EndDateTime <String>] [-EndTimeZone <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-HasAttachments]
 [-ICalUId <String>] [-Id <String>] [-Importance <String>] [-Instances <IMicrosoftGraphEvent1[]>] [-IsAllDay]
 [-IsCancelled] [-IsOnlineMeeting] [-IsOrganizer] [-IsReminderOn] [-LastModifiedDateTime <DateTime>]
 [-LocationDisplayName <String>] [-LocationEmailAddress <String>] [-Locations <IMicrosoftGraphLocation1[]>]
 [-LocationType <String>] [-LocationUniqueId <String>] [-LocationUniqueIdType <String>]
 [-LocationUri <String>] [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-OnlineMeetingConferenceId <String>] [-OnlineMeetingJoinUrl <String>]
 [-OnlineMeetingPhones <IMicrosoftGraphPhone1[]>] [-OnlineMeetingProvider <String>]
 [-OnlineMeetingQuickDial <String>] [-OnlineMeetingTollFreeNumbers <String[]>]
 [-OnlineMeetingTollNumber <String>] [-OnlineMeetingUrl <String>] [-Organizer <IMicrosoftGraphRecipient>]
 [-OriginalEndTimeZone <String>] [-OriginalStart <DateTime>] [-OriginalStartTimeZone <String>]
 [-OwnerAddress <String>] [-OwnerName <String>] [-PatternDayOfMonth <Int32>] [-PatternDaysOfWeek <String[]>]
 [-PatternFirstDayOfWeek <String>] [-PatternIndex <String>] [-PatternInterval <Int32>] [-PatternMonth <Int32>]
 [-PatternType <String>] [-RangeEndDate <DateTime>] [-RangeNumberOfOccurrences <Int32>]
 [-RangeRecurrenceTimeZone <String>] [-RangeStartDate <DateTime>] [-RangeType <String>]
 [-ReminderMinutesBeforeStart <Int32>] [-ResponseRequested] [-ResponseStatusResponse <String>]
 [-ResponseStatusTime <DateTime>] [-Sensitivity <String>] [-SeriesMasterId <String>] [-ShowAs <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-StartDateTime <String>] [-StartTimeZone <String>] [-Subject <String>] [-Type <String>] [-WebLink <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded5
```
New-MgUserCalendarViewInstance -InputObject <IUsersCalendarIdentity> [-CalendarId <String>]
 [-AddressCity <String>] [-AddressCountryOrRegion <String>] [-AddressPostalCode <String>]
 [-AddressState <String>] [-AddressStreet <String>] [-AllowNewTimeProposals]
 [-Attachments <IMicrosoftGraphAttachment[]>] [-Attendees <IMicrosoftGraphAttendee[]>] [-BodyContent <String>]
 [-BodyContentType <String>] [-BodyPreview <String>] [-CalendarAllowedOnlineMeetingProviders <String[]>]
 [-CalendarCanEdit] [-CalendarCanShare] [-CalendarCanViewPrivateItems] [-CalendarChangeKey <String>]
 [-CalendarColor <String>] [-CalendarDefaultOnlineMeetingProvider <String>]
 [-CalendarEvents <IMicrosoftGraphEvent1[]>] [-CalendarIsRemovable] [-CalendarIsTallyingResponses]
 [-CalendarMultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-CalendarName <String>] [-CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]
 [-CalendarSingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-CalendarView <IMicrosoftGraphEvent1[]>] [-Categories <String[]>] [-ChangeKey <String>]
 [-CoordinateAccuracy <Double>] [-CoordinateAltitude <Double>] [-CoordinateAltitudeAccuracy <Double>]
 [-CoordinateLatitude <Double>] [-CoordinateLongitude <Double>] [-CreatedDateTime <DateTime>]
 [-EndDateTime <String>] [-EndTimeZone <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-HasAttachments]
 [-ICalUId <String>] [-Id <String>] [-Importance <String>] [-Instances <IMicrosoftGraphEvent1[]>] [-IsAllDay]
 [-IsCancelled] [-IsOnlineMeeting] [-IsOrganizer] [-IsReminderOn] [-LastModifiedDateTime <DateTime>]
 [-LocationDisplayName <String>] [-LocationEmailAddress <String>] [-Locations <IMicrosoftGraphLocation1[]>]
 [-LocationType <String>] [-LocationUniqueId <String>] [-LocationUniqueIdType <String>]
 [-LocationUri <String>] [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-OnlineMeetingConferenceId <String>] [-OnlineMeetingJoinUrl <String>]
 [-OnlineMeetingPhones <IMicrosoftGraphPhone1[]>] [-OnlineMeetingProvider <String>]
 [-OnlineMeetingQuickDial <String>] [-OnlineMeetingTollFreeNumbers <String[]>]
 [-OnlineMeetingTollNumber <String>] [-OnlineMeetingUrl <String>] [-Organizer <IMicrosoftGraphRecipient>]
 [-OriginalEndTimeZone <String>] [-OriginalStart <DateTime>] [-OriginalStartTimeZone <String>]
 [-OwnerAddress <String>] [-OwnerName <String>] [-PatternDayOfMonth <Int32>] [-PatternDaysOfWeek <String[]>]
 [-PatternFirstDayOfWeek <String>] [-PatternIndex <String>] [-PatternInterval <Int32>] [-PatternMonth <Int32>]
 [-PatternType <String>] [-RangeEndDate <DateTime>] [-RangeNumberOfOccurrences <Int32>]
 [-RangeRecurrenceTimeZone <String>] [-RangeStartDate <DateTime>] [-RangeType <String>]
 [-ReminderMinutesBeforeStart <Int32>] [-ResponseRequested] [-ResponseStatusResponse <String>]
 [-ResponseStatusTime <DateTime>] [-Sensitivity <String>] [-SeriesMasterId <String>] [-ShowAs <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-StartDateTime <String>] [-StartTimeZone <String>] [-Subject <String>] [-Type <String>] [-WebLink <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to instances for users

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

### -AddressCity
The city.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddressCountryOrRegion
The country or region.
It's a free-format string value, for example, 'United States'.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddressPostalCode
The postal code.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddressState
The state.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddressStreet
The street.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowNewTimeProposals
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Attachments
The collection of fileAttachment and itemAttachment attachments for the event.
Navigation property.
Read-only.
Nullable.
To construct, see NOTES section for ATTACHMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttachment[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Attendees
The collection of attendees for the event.
To construct, see NOTES section for ATTENDEES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttendee[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyContent
The content of the item.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyContentType
bodyType

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
event
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvent1
Parameter Sets: Create3, Create4, Create5, CreateViaIdentity3, CreateViaIdentity4, CreateViaIdentity5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BodyPreview
The preview of the message associated with the event.
It is in text format.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarAllowedOnlineMeetingProviders
Represent the online meeting service providers that can be used to create online meetings in this calendar.
Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarCanEdit
True if the user can write to the calendar, false otherwise.
This property is true for the user who created the calendar.
This property is also true for a user who has been shared a calendar and granted write access.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarCanShare
True if the user has the permission to share the calendar, false otherwise.
Only the user who created the calendar can share it.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarCanViewPrivateItems
True if the user can read calendar items that have been marked private, false otherwise.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarChangeKey
Identifies the version of the calendar object.
Every time the calendar is changed, changeKey changes as well.
This allows Exchange to apply changes to the correct version of the object.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarColor
calendarColor

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarDefaultOnlineMeetingProvider
onlineMeetingProviderType

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarEvents
The events in the calendar.
Navigation property.
Read-only.
To construct, see NOTES section for CALENDAREVENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvent1[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarId
key: calendar-id of calendar

```yaml
Type: System.String
Parameter Sets: Create4, CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarIsRemovable
Indicates whether this user calendar can be deleted from the user mailbox.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarIsTallyingResponses
Indicates whether this user calendar supports tracking of meeting responses.
Only meeting invites sent from users' primary calendars support tracking of meeting responses.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarMultiValueExtendedProperties
The collection of multi-value extended properties defined for the calendar.
Read-only.
Nullable.
To construct, see NOTES section for CALENDARMULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarName
The calendar name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCalendarPermission[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarSingleValueExtendedProperties
The collection of single-value extended properties defined for the calendar.
Read-only.
Nullable.
To construct, see NOTES section for CALENDARSINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvent1[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Categories
The categories associated with the item

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChangeKey
Identifies the version of the item.
Every time the item is changed, changeKey changes as well.
This allows Exchange to apply changes to the correct version of the object.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoordinateAccuracy
The accuracy of the latitude and longitude.
As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoordinateAltitude
The altitude of the location.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoordinateAltitudeAccuracy
The accuracy of the altitude.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoordinateLatitude
The latitude of the location.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoordinateLongitude
The longitude of the location.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventId
key: event-id of event

```yaml
Type: System.String
Parameter Sets: Create3, Create4, Create5, CreateExpanded3, CreateExpanded4, CreateExpanded5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Extensions
The collection of open extensions defined for the event.
Read-only.
Nullable.
To construct, see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HasAttachments
Set to true if the event has attachments.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ICalUId
A unique identifier that is shared by all instances of an event across different calendars.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
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
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Importance
importance

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
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
Type: Microsoft.Graph.PowerShell.Models.IUsersCalendarIdentity
Parameter Sets: CreateViaIdentity3, CreateViaIdentity4, CreateViaIdentity5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Instances
The instances of the event.
Navigation property.
Read-only.
Nullable.
To construct, see NOTES section for INSTANCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvent1[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAllDay
Set to true if the event lasts all day.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsCancelled
Set to true if the event has been canceled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsOnlineMeeting
True if this event has online meeting information, false otherwise.
Default is false.
Optional.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsOrganizer
Set to true if the calendar owner (specified by the owner property of the calendar) is the organizer of the event (specified by the organizer property of the event).
This also applies if a delegate organized the event on behalf of the owner.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsReminderOn
Set to true if an alert is set to remind the user of the event.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationDisplayName
The name associated with the location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationEmailAddress
Optional email address of the location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Locations
The locations where the event is held or attended from.
The location and locations properties always correspond with each other.
If you update the location property, any prior locations in the locations collection would be removed and replaced by the new location value.
To construct, see NOTES section for LOCATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLocation1[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationType
locationType

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationUniqueId
For internal use only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationUniqueIdType
locationUniqueIdType

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationUri
Optional URI representing the location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MicrosoftGraphEntityId
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded4
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MultiValueExtendedProperties
The collection of multi-value extended properties defined for the event.
Read-only.
Nullable.
To construct, see NOTES section for MULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineMeetingConferenceId
The ID of the conference.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineMeetingJoinUrl
The external link that launches the online meeting.
This is a URL that clients will launch into a browser and will redirect the user to join the meeting.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineMeetingPhones
All of the phone numbers associated with this conference.
To construct, see NOTES section for ONLINEMEETINGPHONES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhone1[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineMeetingProvider
onlineMeetingProviderType

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineMeetingQuickDial
The pre-formatted quickdial for this call.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineMeetingTollFreeNumbers
The toll free numbers that can be used to join the conference.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineMeetingTollNumber
The toll number that can be used to join the conference.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineMeetingUrl
A URL for an online meeting.
The property is set only when an organizer specifies an event as an online meeting such as a Skype meeting.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Organizer
recipient
To construct, see NOTES section for ORGANIZER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecipient
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OriginalEndTimeZone
The end time zone that was set when the event was created.
A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OriginalStart
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OriginalStartTimeZone
The start time zone that was set when the event was created.
A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerAddress
The email address of the person or entity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerName
The display name of the person or entity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PatternDayOfMonth
The day of the month on which the event occurs.
Required if type is absoluteMonthly or absoluteYearly.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PatternDaysOfWeek
A collection of the days of the week on which the event occurs.
The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.
If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.
Required if type is weekly, relativeMonthly, or relativeYearly.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PatternFirstDayOfWeek
dayOfWeek

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PatternIndex
weekIndex

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PatternInterval
The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type.
Required.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PatternMonth
The month in which the event occurs.
This is a number from 1 to 12.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PatternType
recurrencePatternType

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangeEndDate
The date to stop applying the recurrence pattern.
Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date.
Required if type is endDate.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangeNumberOfOccurrences
The number of times to repeat the event.
Required and must be positive if type is numbered.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangeRecurrenceTimeZone
Time zone for the startDate and endDate properties.
Optional.
If not specified, the time zone of the event is used.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangeStartDate
The date to start applying the recurrence pattern.
The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event.
Must be the same value as the start property of the recurring event.
Required.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangeType
recurrenceRangeType

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReminderMinutesBeforeStart
The number of minutes before the event start time that the reminder alert occurs.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseRequested
Set to true if the sender would like a response when the event is accepted or declined.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseStatusResponse
responseType

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseStatusTime
The date and time that the response was returned.
It uses ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sensitivity
sensitivity

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SeriesMasterId
The ID for the recurring series master item, if this event is part of a recurring series.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowAs
freeBusyStatus

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SingleValueExtendedProperties
The collection of single-value extended properties defined for the event.
Read-only.
Nullable.
To construct, see NOTES section for SINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
The text of the event's subject line.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
eventType

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Create3, Create4, Create5, CreateExpanded3, CreateExpanded4, CreateExpanded5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WebLink
The URL to open the event in Outlook on the web.Outlook on the web opens the event in the browser if you are signed in to your mailbox.
Otherwise, Outlook on the web prompts you to sign in.This URL can be accessed from within an iFrame.

```yaml
Type: System.String
Parameter Sets: CreateExpanded3, CreateExpanded4, CreateExpanded5, CreateViaIdentityExpanded3, CreateViaIdentityExpanded4, CreateViaIdentityExpanded5
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvent1

### Microsoft.Graph.PowerShell.Models.IUsersCalendarIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvent1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ATTACHMENTS <IMicrosoftGraphAttachment[]>: The collection of fileAttachment and itemAttachment attachments for the event. Navigation property. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[ContentType <String>]`: The MIME type.
  - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Name <String>]`: The attachment's file name.
  - `[Size <Int32?>]`: The length of the attachment in bytes.

ATTENDEES <IMicrosoftGraphAttendee[]>: The collection of attendees for the event.
  - `[Type <String>]`: attendeeType
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[Address <String>]`: The email address of the person or entity.
    - `[Name <String>]`: The display name of the person or entity.
  - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[StatusResponse <String>]`: responseType
  - `[StatusTime <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

BODYPARAMETER <IMicrosoftGraphEvent1>: event
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Id <String>]`: Read-only.
  - `[AddressCity <String>]`: The city.
  - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[AddressPostalCode <String>]`: The postal code.
  - `[AddressState <String>]`: The state.
  - `[AddressStreet <String>]`: The street.
  - `[AllowNewTimeProposals <Boolean?>]`: 
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of fileAttachment and itemAttachment attachments for the event. Navigation property. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Name <String>]`: The attachment's file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Attendees <IMicrosoftGraphAttendee[]>]`: The collection of attendees for the event.
    - `[Type <String>]`: attendeeType
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
    - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[StatusResponse <String>]`: responseType
    - `[StatusTime <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[BodyContent <String>]`: The content of the item.
  - `[BodyContentType <String>]`: bodyType
  - `[BodyPreview <String>]`: The preview of the message associated with the event. It is in text format.
  - `[CalendarAllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
  - `[CalendarCanEdit <Boolean?>]`: True if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
  - `[CalendarCanShare <Boolean?>]`: True if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
  - `[CalendarCanViewPrivateItems <Boolean?>]`: True if the user can read calendar items that have been marked private, false otherwise.
  - `[CalendarChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CalendarColor <String>]`: calendarColor
  - `[CalendarDefaultOnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[CalendarEvents <IMicrosoftGraphEvent1[]>]`: The events in the calendar. Navigation property. Read-only.
  - `[CalendarId <String>]`: Read-only.
  - `[CalendarIsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
  - `[CalendarIsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
  - `[CalendarMultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[CalendarName <String>]`: The calendar name.
  - `[CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]`: The permissions of the users with whom the calendar is shared.
    - `[Id <String>]`: Read-only.
    - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
    - `[EmailAddressAddress <String>]`: The email address of the person or entity.
    - `[EmailAddressName <String>]`: The display name of the person or entity.
    - `[IsInsideOrganization <Boolean?>]`: True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
    - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.
    - `[Role <String>]`: calendarRoleType
  - `[CalendarSingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String>]`: A property value.
  - `[CalendarView <IMicrosoftGraphEvent1[]>]`: The calendar view for the calendar. Navigation property. Read-only.
  - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[CoordinateAltitude <Double?>]`: The altitude of the location.
  - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[CoordinateLatitude <Double?>]`: The latitude of the location.
  - `[CoordinateLongitude <Double?>]`: The longitude of the location.
  - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the event. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[HasAttachments <Boolean?>]`: Set to true if the event has attachments.
  - `[ICalUId <String>]`: A unique identifier that is shared by all instances of an event across different calendars. Read-only.
  - `[Importance <String>]`: importance
  - `[Instances <IMicrosoftGraphEvent1[]>]`: The instances of the event. Navigation property. Read-only. Nullable.
  - `[IsAllDay <Boolean?>]`: Set to true if the event lasts all day.
  - `[IsCancelled <Boolean?>]`: Set to true if the event has been canceled.
  - `[IsOnlineMeeting <Boolean?>]`: True if this event has online meeting information, false otherwise. Default is false. Optional.
  - `[IsOrganizer <Boolean?>]`: Set to true if the calendar owner (specified by the owner property of the calendar) is the organizer of the event (specified by the organizer property of the event). This also applies if a delegate organized the event on behalf of the owner.
  - `[IsReminderOn <Boolean?>]`: Set to true if an alert is set to remind the user of the event.
  - `[LocationDisplayName <String>]`: The name associated with the location.
  - `[LocationEmailAddress <String>]`: Optional email address of the location.
  - `[LocationType <String>]`: locationType
  - `[LocationUniqueId <String>]`: For internal use only.
  - `[LocationUniqueIdType <String>]`: locationUniqueIdType
  - `[LocationUri <String>]`: Optional URI representing the location.
  - `[Locations <IMicrosoftGraphLocation1[]>]`: The locations where the event is held or attended from. The location and locations properties always correspond with each other. If you update the location property, any prior locations in the locations collection would be removed and replaced by the new location value.
    - `[AddressCity <String>]`: The city.
    - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[AddressPostalCode <String>]`: The postal code.
    - `[AddressState <String>]`: The state.
    - `[AddressStreet <String>]`: The street.
    - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[CoordinateAltitude <Double?>]`: The altitude of the location.
    - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[CoordinateLatitude <Double?>]`: The latitude of the location.
    - `[CoordinateLongitude <Double?>]`: The longitude of the location.
    - `[DisplayName <String>]`: The name associated with the location.
    - `[LocationEmailAddress <String>]`: Optional email address of the location.
    - `[LocationType <String>]`: locationType
    - `[LocationUri <String>]`: Optional URI representing the location.
    - `[UniqueId <String>]`: For internal use only.
    - `[UniqueIdType <String>]`: locationUniqueIdType
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the event. Read-only. Nullable.
  - `[OnlineMeetingConferenceId <String>]`: The ID of the conference.
  - `[OnlineMeetingJoinUrl <String>]`: The external link that launches the online meeting. This is a URL that clients will launch into a browser and will redirect the user to join the meeting.
  - `[OnlineMeetingPhones <IMicrosoftGraphPhone1[]>]`: All of the phone numbers associated with this conference.
    - `[Language <String>]`: 
    - `[Number <String>]`: The phone number.
    - `[Region <String>]`: 
    - `[Type <String>]`: phoneType
  - `[OnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[OnlineMeetingQuickDial <String>]`: The pre-formatted quickdial for this call.
  - `[OnlineMeetingTollFreeNumbers <String[]>]`: The toll free numbers that can be used to join the conference.
  - `[OnlineMeetingTollNumber <String>]`: The toll number that can be used to join the conference.
  - `[OnlineMeetingUrl <String>]`: A URL for an online meeting. The property is set only when an organizer specifies an event as an online meeting such as a Skype meeting. Read-only.
  - `[Organizer <IMicrosoftGraphRecipient>]`: recipient
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[OriginalEndTimeZone <String>]`: The end time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
  - `[OriginalStart <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[OriginalStartTimeZone <String>]`: The start time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
  - `[OwnerAddress <String>]`: The email address of the person or entity.
  - `[OwnerName <String>]`: The display name of the person or entity.
  - `[PatternDayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
  - `[PatternDaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
  - `[PatternFirstDayOfWeek <String>]`: dayOfWeek
  - `[PatternIndex <String>]`: weekIndex
  - `[PatternInterval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
  - `[PatternMonth <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
  - `[PatternType <String>]`: recurrencePatternType
  - `[RangeEndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
  - `[RangeNumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
  - `[RangeRecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
  - `[RangeStartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
  - `[RangeType <String>]`: recurrenceRangeType
  - `[ReminderMinutesBeforeStart <Int32?>]`: The number of minutes before the event start time that the reminder alert occurs.
  - `[ResponseRequested <Boolean?>]`: Set to true if the sender would like a response when the event is accepted or declined.
  - `[ResponseStatusResponse <String>]`: responseType
  - `[ResponseStatusTime <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Sensitivity <String>]`: sensitivity
  - `[SeriesMasterId <String>]`: The ID for the recurring series master item, if this event is part of a recurring series.
  - `[ShowAs <String>]`: freeBusyStatus
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the event. Read-only. Nullable.
  - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Subject <String>]`: The text of the event's subject line.
  - `[Type <String>]`: eventType
  - `[WebLink <String>]`: The URL to open the event in Outlook on the web.Outlook on the web opens the event in the browser if you are signed in to your mailbox. Otherwise, Outlook on the web prompts you to sign in.This URL can be accessed from within an iFrame.

CALENDAREVENTS <IMicrosoftGraphEvent1[]>: The events in the calendar. Navigation property. Read-only.
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Id <String>]`: Read-only.
  - `[AddressCity <String>]`: The city.
  - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[AddressPostalCode <String>]`: The postal code.
  - `[AddressState <String>]`: The state.
  - `[AddressStreet <String>]`: The street.
  - `[AllowNewTimeProposals <Boolean?>]`: 
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of fileAttachment and itemAttachment attachments for the event. Navigation property. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Name <String>]`: The attachment's file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Attendees <IMicrosoftGraphAttendee[]>]`: The collection of attendees for the event.
    - `[Type <String>]`: attendeeType
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
    - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[StatusResponse <String>]`: responseType
    - `[StatusTime <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[BodyContent <String>]`: The content of the item.
  - `[BodyContentType <String>]`: bodyType
  - `[BodyPreview <String>]`: The preview of the message associated with the event. It is in text format.
  - `[CalendarAllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
  - `[CalendarCanEdit <Boolean?>]`: True if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
  - `[CalendarCanShare <Boolean?>]`: True if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
  - `[CalendarCanViewPrivateItems <Boolean?>]`: True if the user can read calendar items that have been marked private, false otherwise.
  - `[CalendarChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CalendarColor <String>]`: calendarColor
  - `[CalendarDefaultOnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[CalendarEvents <IMicrosoftGraphEvent1[]>]`: The events in the calendar. Navigation property. Read-only.
  - `[CalendarId <String>]`: Read-only.
  - `[CalendarIsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
  - `[CalendarIsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
  - `[CalendarMultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[CalendarName <String>]`: The calendar name.
  - `[CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]`: The permissions of the users with whom the calendar is shared.
    - `[Id <String>]`: Read-only.
    - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
    - `[EmailAddressAddress <String>]`: The email address of the person or entity.
    - `[EmailAddressName <String>]`: The display name of the person or entity.
    - `[IsInsideOrganization <Boolean?>]`: True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
    - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.
    - `[Role <String>]`: calendarRoleType
  - `[CalendarSingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String>]`: A property value.
  - `[CalendarView <IMicrosoftGraphEvent1[]>]`: The calendar view for the calendar. Navigation property. Read-only.
  - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[CoordinateAltitude <Double?>]`: The altitude of the location.
  - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[CoordinateLatitude <Double?>]`: The latitude of the location.
  - `[CoordinateLongitude <Double?>]`: The longitude of the location.
  - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the event. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[HasAttachments <Boolean?>]`: Set to true if the event has attachments.
  - `[ICalUId <String>]`: A unique identifier that is shared by all instances of an event across different calendars. Read-only.
  - `[Importance <String>]`: importance
  - `[Instances <IMicrosoftGraphEvent1[]>]`: The instances of the event. Navigation property. Read-only. Nullable.
  - `[IsAllDay <Boolean?>]`: Set to true if the event lasts all day.
  - `[IsCancelled <Boolean?>]`: Set to true if the event has been canceled.
  - `[IsOnlineMeeting <Boolean?>]`: True if this event has online meeting information, false otherwise. Default is false. Optional.
  - `[IsOrganizer <Boolean?>]`: Set to true if the calendar owner (specified by the owner property of the calendar) is the organizer of the event (specified by the organizer property of the event). This also applies if a delegate organized the event on behalf of the owner.
  - `[IsReminderOn <Boolean?>]`: Set to true if an alert is set to remind the user of the event.
  - `[LocationDisplayName <String>]`: The name associated with the location.
  - `[LocationEmailAddress <String>]`: Optional email address of the location.
  - `[LocationType <String>]`: locationType
  - `[LocationUniqueId <String>]`: For internal use only.
  - `[LocationUniqueIdType <String>]`: locationUniqueIdType
  - `[LocationUri <String>]`: Optional URI representing the location.
  - `[Locations <IMicrosoftGraphLocation1[]>]`: The locations where the event is held or attended from. The location and locations properties always correspond with each other. If you update the location property, any prior locations in the locations collection would be removed and replaced by the new location value.
    - `[AddressCity <String>]`: The city.
    - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[AddressPostalCode <String>]`: The postal code.
    - `[AddressState <String>]`: The state.
    - `[AddressStreet <String>]`: The street.
    - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[CoordinateAltitude <Double?>]`: The altitude of the location.
    - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[CoordinateLatitude <Double?>]`: The latitude of the location.
    - `[CoordinateLongitude <Double?>]`: The longitude of the location.
    - `[DisplayName <String>]`: The name associated with the location.
    - `[LocationEmailAddress <String>]`: Optional email address of the location.
    - `[LocationType <String>]`: locationType
    - `[LocationUri <String>]`: Optional URI representing the location.
    - `[UniqueId <String>]`: For internal use only.
    - `[UniqueIdType <String>]`: locationUniqueIdType
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the event. Read-only. Nullable.
  - `[OnlineMeetingConferenceId <String>]`: The ID of the conference.
  - `[OnlineMeetingJoinUrl <String>]`: The external link that launches the online meeting. This is a URL that clients will launch into a browser and will redirect the user to join the meeting.
  - `[OnlineMeetingPhones <IMicrosoftGraphPhone1[]>]`: All of the phone numbers associated with this conference.
    - `[Language <String>]`: 
    - `[Number <String>]`: The phone number.
    - `[Region <String>]`: 
    - `[Type <String>]`: phoneType
  - `[OnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[OnlineMeetingQuickDial <String>]`: The pre-formatted quickdial for this call.
  - `[OnlineMeetingTollFreeNumbers <String[]>]`: The toll free numbers that can be used to join the conference.
  - `[OnlineMeetingTollNumber <String>]`: The toll number that can be used to join the conference.
  - `[OnlineMeetingUrl <String>]`: A URL for an online meeting. The property is set only when an organizer specifies an event as an online meeting such as a Skype meeting. Read-only.
  - `[Organizer <IMicrosoftGraphRecipient>]`: recipient
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[OriginalEndTimeZone <String>]`: The end time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
  - `[OriginalStart <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[OriginalStartTimeZone <String>]`: The start time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
  - `[OwnerAddress <String>]`: The email address of the person or entity.
  - `[OwnerName <String>]`: The display name of the person or entity.
  - `[PatternDayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
  - `[PatternDaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
  - `[PatternFirstDayOfWeek <String>]`: dayOfWeek
  - `[PatternIndex <String>]`: weekIndex
  - `[PatternInterval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
  - `[PatternMonth <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
  - `[PatternType <String>]`: recurrencePatternType
  - `[RangeEndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
  - `[RangeNumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
  - `[RangeRecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
  - `[RangeStartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
  - `[RangeType <String>]`: recurrenceRangeType
  - `[ReminderMinutesBeforeStart <Int32?>]`: The number of minutes before the event start time that the reminder alert occurs.
  - `[ResponseRequested <Boolean?>]`: Set to true if the sender would like a response when the event is accepted or declined.
  - `[ResponseStatusResponse <String>]`: responseType
  - `[ResponseStatusTime <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Sensitivity <String>]`: sensitivity
  - `[SeriesMasterId <String>]`: The ID for the recurring series master item, if this event is part of a recurring series.
  - `[ShowAs <String>]`: freeBusyStatus
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the event. Read-only. Nullable.
  - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Subject <String>]`: The text of the event's subject line.
  - `[Type <String>]`: eventType
  - `[WebLink <String>]`: The URL to open the event in Outlook on the web.Outlook on the web opens the event in the browser if you are signed in to your mailbox. Otherwise, Outlook on the web prompts you to sign in.This URL can be accessed from within an iFrame.

CALENDARMULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String[]>]`: A collection of property values.

CALENDARPERMISSIONS <IMicrosoftGraphCalendarPermission[]>: The permissions of the users with whom the calendar is shared.
  - `[Id <String>]`: Read-only.
  - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
  - `[EmailAddressAddress <String>]`: The email address of the person or entity.
  - `[EmailAddressName <String>]`: The display name of the person or entity.
  - `[IsInsideOrganization <Boolean?>]`: True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
  - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.
  - `[Role <String>]`: calendarRoleType

CALENDARSINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String>]`: A property value.

CALENDARVIEW <IMicrosoftGraphEvent1[]>: The calendar view for the calendar. Navigation property. Read-only.
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Id <String>]`: Read-only.
  - `[AddressCity <String>]`: The city.
  - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[AddressPostalCode <String>]`: The postal code.
  - `[AddressState <String>]`: The state.
  - `[AddressStreet <String>]`: The street.
  - `[AllowNewTimeProposals <Boolean?>]`: 
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of fileAttachment and itemAttachment attachments for the event. Navigation property. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Name <String>]`: The attachment's file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Attendees <IMicrosoftGraphAttendee[]>]`: The collection of attendees for the event.
    - `[Type <String>]`: attendeeType
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
    - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[StatusResponse <String>]`: responseType
    - `[StatusTime <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[BodyContent <String>]`: The content of the item.
  - `[BodyContentType <String>]`: bodyType
  - `[BodyPreview <String>]`: The preview of the message associated with the event. It is in text format.
  - `[CalendarAllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
  - `[CalendarCanEdit <Boolean?>]`: True if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
  - `[CalendarCanShare <Boolean?>]`: True if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
  - `[CalendarCanViewPrivateItems <Boolean?>]`: True if the user can read calendar items that have been marked private, false otherwise.
  - `[CalendarChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CalendarColor <String>]`: calendarColor
  - `[CalendarDefaultOnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[CalendarEvents <IMicrosoftGraphEvent1[]>]`: The events in the calendar. Navigation property. Read-only.
  - `[CalendarId <String>]`: Read-only.
  - `[CalendarIsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
  - `[CalendarIsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
  - `[CalendarMultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[CalendarName <String>]`: The calendar name.
  - `[CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]`: The permissions of the users with whom the calendar is shared.
    - `[Id <String>]`: Read-only.
    - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
    - `[EmailAddressAddress <String>]`: The email address of the person or entity.
    - `[EmailAddressName <String>]`: The display name of the person or entity.
    - `[IsInsideOrganization <Boolean?>]`: True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
    - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.
    - `[Role <String>]`: calendarRoleType
  - `[CalendarSingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String>]`: A property value.
  - `[CalendarView <IMicrosoftGraphEvent1[]>]`: The calendar view for the calendar. Navigation property. Read-only.
  - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[CoordinateAltitude <Double?>]`: The altitude of the location.
  - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[CoordinateLatitude <Double?>]`: The latitude of the location.
  - `[CoordinateLongitude <Double?>]`: The longitude of the location.
  - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the event. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[HasAttachments <Boolean?>]`: Set to true if the event has attachments.
  - `[ICalUId <String>]`: A unique identifier that is shared by all instances of an event across different calendars. Read-only.
  - `[Importance <String>]`: importance
  - `[Instances <IMicrosoftGraphEvent1[]>]`: The instances of the event. Navigation property. Read-only. Nullable.
  - `[IsAllDay <Boolean?>]`: Set to true if the event lasts all day.
  - `[IsCancelled <Boolean?>]`: Set to true if the event has been canceled.
  - `[IsOnlineMeeting <Boolean?>]`: True if this event has online meeting information, false otherwise. Default is false. Optional.
  - `[IsOrganizer <Boolean?>]`: Set to true if the calendar owner (specified by the owner property of the calendar) is the organizer of the event (specified by the organizer property of the event). This also applies if a delegate organized the event on behalf of the owner.
  - `[IsReminderOn <Boolean?>]`: Set to true if an alert is set to remind the user of the event.
  - `[LocationDisplayName <String>]`: The name associated with the location.
  - `[LocationEmailAddress <String>]`: Optional email address of the location.
  - `[LocationType <String>]`: locationType
  - `[LocationUniqueId <String>]`: For internal use only.
  - `[LocationUniqueIdType <String>]`: locationUniqueIdType
  - `[LocationUri <String>]`: Optional URI representing the location.
  - `[Locations <IMicrosoftGraphLocation1[]>]`: The locations where the event is held or attended from. The location and locations properties always correspond with each other. If you update the location property, any prior locations in the locations collection would be removed and replaced by the new location value.
    - `[AddressCity <String>]`: The city.
    - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[AddressPostalCode <String>]`: The postal code.
    - `[AddressState <String>]`: The state.
    - `[AddressStreet <String>]`: The street.
    - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[CoordinateAltitude <Double?>]`: The altitude of the location.
    - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[CoordinateLatitude <Double?>]`: The latitude of the location.
    - `[CoordinateLongitude <Double?>]`: The longitude of the location.
    - `[DisplayName <String>]`: The name associated with the location.
    - `[LocationEmailAddress <String>]`: Optional email address of the location.
    - `[LocationType <String>]`: locationType
    - `[LocationUri <String>]`: Optional URI representing the location.
    - `[UniqueId <String>]`: For internal use only.
    - `[UniqueIdType <String>]`: locationUniqueIdType
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the event. Read-only. Nullable.
  - `[OnlineMeetingConferenceId <String>]`: The ID of the conference.
  - `[OnlineMeetingJoinUrl <String>]`: The external link that launches the online meeting. This is a URL that clients will launch into a browser and will redirect the user to join the meeting.
  - `[OnlineMeetingPhones <IMicrosoftGraphPhone1[]>]`: All of the phone numbers associated with this conference.
    - `[Language <String>]`: 
    - `[Number <String>]`: The phone number.
    - `[Region <String>]`: 
    - `[Type <String>]`: phoneType
  - `[OnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[OnlineMeetingQuickDial <String>]`: The pre-formatted quickdial for this call.
  - `[OnlineMeetingTollFreeNumbers <String[]>]`: The toll free numbers that can be used to join the conference.
  - `[OnlineMeetingTollNumber <String>]`: The toll number that can be used to join the conference.
  - `[OnlineMeetingUrl <String>]`: A URL for an online meeting. The property is set only when an organizer specifies an event as an online meeting such as a Skype meeting. Read-only.
  - `[Organizer <IMicrosoftGraphRecipient>]`: recipient
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[OriginalEndTimeZone <String>]`: The end time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
  - `[OriginalStart <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[OriginalStartTimeZone <String>]`: The start time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
  - `[OwnerAddress <String>]`: The email address of the person or entity.
  - `[OwnerName <String>]`: The display name of the person or entity.
  - `[PatternDayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
  - `[PatternDaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
  - `[PatternFirstDayOfWeek <String>]`: dayOfWeek
  - `[PatternIndex <String>]`: weekIndex
  - `[PatternInterval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
  - `[PatternMonth <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
  - `[PatternType <String>]`: recurrencePatternType
  - `[RangeEndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
  - `[RangeNumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
  - `[RangeRecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
  - `[RangeStartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
  - `[RangeType <String>]`: recurrenceRangeType
  - `[ReminderMinutesBeforeStart <Int32?>]`: The number of minutes before the event start time that the reminder alert occurs.
  - `[ResponseRequested <Boolean?>]`: Set to true if the sender would like a response when the event is accepted or declined.
  - `[ResponseStatusResponse <String>]`: responseType
  - `[ResponseStatusTime <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Sensitivity <String>]`: sensitivity
  - `[SeriesMasterId <String>]`: The ID for the recurring series master item, if this event is part of a recurring series.
  - `[ShowAs <String>]`: freeBusyStatus
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the event. Read-only. Nullable.
  - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Subject <String>]`: The text of the event's subject line.
  - `[Type <String>]`: eventType
  - `[WebLink <String>]`: The URL to open the event in Outlook on the web.Outlook on the web opens the event in the browser if you are signed in to your mailbox. Otherwise, Outlook on the web prompts you to sign in.This URL can be accessed from within an iFrame.

EXTENSIONS <IMicrosoftGraphExtension[]>: The collection of open extensions defined for the event. Read-only. Nullable.
  - `[Id <String>]`: Read-only.

INPUTOBJECT <IUsersCalendarIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: attachment-id of attachment
  - `[CalendarGroupId <String>]`: key: calendarGroup-id of calendarGroup
  - `[CalendarId <String>]`: key: calendar-id of calendar
  - `[CalendarPermissionId <String>]`: key: calendarPermission-id of calendarPermission
  - `[EventId <String>]`: key: event-id of event
  - `[EventId1 <String>]`: key: event-id of event
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: multiValueLegacyExtendedProperty-id of multiValueLegacyExtendedProperty
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: singleValueLegacyExtendedProperty-id of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: key: user-id of user

INSTANCES <IMicrosoftGraphEvent1[]>: The instances of the event. Navigation property. Read-only. Nullable.
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Id <String>]`: Read-only.
  - `[AddressCity <String>]`: The city.
  - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[AddressPostalCode <String>]`: The postal code.
  - `[AddressState <String>]`: The state.
  - `[AddressStreet <String>]`: The street.
  - `[AllowNewTimeProposals <Boolean?>]`: 
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of fileAttachment and itemAttachment attachments for the event. Navigation property. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Name <String>]`: The attachment's file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Attendees <IMicrosoftGraphAttendee[]>]`: The collection of attendees for the event.
    - `[Type <String>]`: attendeeType
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
    - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[StatusResponse <String>]`: responseType
    - `[StatusTime <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[BodyContent <String>]`: The content of the item.
  - `[BodyContentType <String>]`: bodyType
  - `[BodyPreview <String>]`: The preview of the message associated with the event. It is in text format.
  - `[CalendarAllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
  - `[CalendarCanEdit <Boolean?>]`: True if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
  - `[CalendarCanShare <Boolean?>]`: True if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
  - `[CalendarCanViewPrivateItems <Boolean?>]`: True if the user can read calendar items that have been marked private, false otherwise.
  - `[CalendarChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CalendarColor <String>]`: calendarColor
  - `[CalendarDefaultOnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[CalendarEvents <IMicrosoftGraphEvent1[]>]`: The events in the calendar. Navigation property. Read-only.
  - `[CalendarId <String>]`: Read-only.
  - `[CalendarIsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
  - `[CalendarIsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
  - `[CalendarMultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[CalendarName <String>]`: The calendar name.
  - `[CalendarPermissions <IMicrosoftGraphCalendarPermission[]>]`: The permissions of the users with whom the calendar is shared.
    - `[Id <String>]`: Read-only.
    - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
    - `[EmailAddressAddress <String>]`: The email address of the person or entity.
    - `[EmailAddressName <String>]`: The display name of the person or entity.
    - `[IsInsideOrganization <Boolean?>]`: True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
    - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.
    - `[Role <String>]`: calendarRoleType
  - `[CalendarSingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String>]`: A property value.
  - `[CalendarView <IMicrosoftGraphEvent1[]>]`: The calendar view for the calendar. Navigation property. Read-only.
  - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[CoordinateAltitude <Double?>]`: The altitude of the location.
  - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[CoordinateLatitude <Double?>]`: The latitude of the location.
  - `[CoordinateLongitude <Double?>]`: The longitude of the location.
  - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the event. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[HasAttachments <Boolean?>]`: Set to true if the event has attachments.
  - `[ICalUId <String>]`: A unique identifier that is shared by all instances of an event across different calendars. Read-only.
  - `[Importance <String>]`: importance
  - `[Instances <IMicrosoftGraphEvent1[]>]`: The instances of the event. Navigation property. Read-only. Nullable.
  - `[IsAllDay <Boolean?>]`: Set to true if the event lasts all day.
  - `[IsCancelled <Boolean?>]`: Set to true if the event has been canceled.
  - `[IsOnlineMeeting <Boolean?>]`: True if this event has online meeting information, false otherwise. Default is false. Optional.
  - `[IsOrganizer <Boolean?>]`: Set to true if the calendar owner (specified by the owner property of the calendar) is the organizer of the event (specified by the organizer property of the event). This also applies if a delegate organized the event on behalf of the owner.
  - `[IsReminderOn <Boolean?>]`: Set to true if an alert is set to remind the user of the event.
  - `[LocationDisplayName <String>]`: The name associated with the location.
  - `[LocationEmailAddress <String>]`: Optional email address of the location.
  - `[LocationType <String>]`: locationType
  - `[LocationUniqueId <String>]`: For internal use only.
  - `[LocationUniqueIdType <String>]`: locationUniqueIdType
  - `[LocationUri <String>]`: Optional URI representing the location.
  - `[Locations <IMicrosoftGraphLocation1[]>]`: The locations where the event is held or attended from. The location and locations properties always correspond with each other. If you update the location property, any prior locations in the locations collection would be removed and replaced by the new location value.
    - `[AddressCity <String>]`: The city.
    - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[AddressPostalCode <String>]`: The postal code.
    - `[AddressState <String>]`: The state.
    - `[AddressStreet <String>]`: The street.
    - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[CoordinateAltitude <Double?>]`: The altitude of the location.
    - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[CoordinateLatitude <Double?>]`: The latitude of the location.
    - `[CoordinateLongitude <Double?>]`: The longitude of the location.
    - `[DisplayName <String>]`: The name associated with the location.
    - `[LocationEmailAddress <String>]`: Optional email address of the location.
    - `[LocationType <String>]`: locationType
    - `[LocationUri <String>]`: Optional URI representing the location.
    - `[UniqueId <String>]`: For internal use only.
    - `[UniqueIdType <String>]`: locationUniqueIdType
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the event. Read-only. Nullable.
  - `[OnlineMeetingConferenceId <String>]`: The ID of the conference.
  - `[OnlineMeetingJoinUrl <String>]`: The external link that launches the online meeting. This is a URL that clients will launch into a browser and will redirect the user to join the meeting.
  - `[OnlineMeetingPhones <IMicrosoftGraphPhone1[]>]`: All of the phone numbers associated with this conference.
    - `[Language <String>]`: 
    - `[Number <String>]`: The phone number.
    - `[Region <String>]`: 
    - `[Type <String>]`: phoneType
  - `[OnlineMeetingProvider <String>]`: onlineMeetingProviderType
  - `[OnlineMeetingQuickDial <String>]`: The pre-formatted quickdial for this call.
  - `[OnlineMeetingTollFreeNumbers <String[]>]`: The toll free numbers that can be used to join the conference.
  - `[OnlineMeetingTollNumber <String>]`: The toll number that can be used to join the conference.
  - `[OnlineMeetingUrl <String>]`: A URL for an online meeting. The property is set only when an organizer specifies an event as an online meeting such as a Skype meeting. Read-only.
  - `[Organizer <IMicrosoftGraphRecipient>]`: recipient
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[OriginalEndTimeZone <String>]`: The end time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
  - `[OriginalStart <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[OriginalStartTimeZone <String>]`: The start time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
  - `[OwnerAddress <String>]`: The email address of the person or entity.
  - `[OwnerName <String>]`: The display name of the person or entity.
  - `[PatternDayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
  - `[PatternDaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
  - `[PatternFirstDayOfWeek <String>]`: dayOfWeek
  - `[PatternIndex <String>]`: weekIndex
  - `[PatternInterval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
  - `[PatternMonth <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
  - `[PatternType <String>]`: recurrencePatternType
  - `[RangeEndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
  - `[RangeNumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
  - `[RangeRecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
  - `[RangeStartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
  - `[RangeType <String>]`: recurrenceRangeType
  - `[ReminderMinutesBeforeStart <Int32?>]`: The number of minutes before the event start time that the reminder alert occurs.
  - `[ResponseRequested <Boolean?>]`: Set to true if the sender would like a response when the event is accepted or declined.
  - `[ResponseStatusResponse <String>]`: responseType
  - `[ResponseStatusTime <DateTime?>]`: The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Sensitivity <String>]`: sensitivity
  - `[SeriesMasterId <String>]`: The ID for the recurring series master item, if this event is part of a recurring series.
  - `[ShowAs <String>]`: freeBusyStatus
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the event. Read-only. Nullable.
  - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Subject <String>]`: The text of the event's subject line.
  - `[Type <String>]`: eventType
  - `[WebLink <String>]`: The URL to open the event in Outlook on the web.Outlook on the web opens the event in the browser if you are signed in to your mailbox. Otherwise, Outlook on the web prompts you to sign in.This URL can be accessed from within an iFrame.

LOCATIONS <IMicrosoftGraphLocation1[]>: The locations where the event is held or attended from. The location and locations properties always correspond with each other. If you update the location property, any prior locations in the locations collection would be removed and replaced by the new location value.
  - `[AddressCity <String>]`: The city.
  - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[AddressPostalCode <String>]`: The postal code.
  - `[AddressState <String>]`: The state.
  - `[AddressStreet <String>]`: The street.
  - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[CoordinateAltitude <Double?>]`: The altitude of the location.
  - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[CoordinateLatitude <Double?>]`: The latitude of the location.
  - `[CoordinateLongitude <Double?>]`: The longitude of the location.
  - `[DisplayName <String>]`: The name associated with the location.
  - `[LocationEmailAddress <String>]`: Optional email address of the location.
  - `[LocationType <String>]`: locationType
  - `[LocationUri <String>]`: Optional URI representing the location.
  - `[UniqueId <String>]`: For internal use only.
  - `[UniqueIdType <String>]`: locationUniqueIdType

MULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>: The collection of multi-value extended properties defined for the event. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String[]>]`: A collection of property values.

ONLINEMEETINGPHONES <IMicrosoftGraphPhone1[]>: All of the phone numbers associated with this conference.
  - `[Language <String>]`: 
  - `[Number <String>]`: The phone number.
  - `[Region <String>]`: 
  - `[Type <String>]`: phoneType

ORGANIZER <IMicrosoftGraphRecipient>: recipient
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[Address <String>]`: The email address of the person or entity.
    - `[Name <String>]`: The display name of the person or entity.

SINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>: The collection of single-value extended properties defined for the event. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String>]`: A property value.

## RELATED LINKS

