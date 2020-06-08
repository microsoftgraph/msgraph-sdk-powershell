---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/find-mgusermeetingtime
schema: 2.0.0
---

# Find-MgUserMeetingTime

## SYNOPSIS
Invoke action findMeetingTimes

## SYNTAX

### FindExpanded1 (Default)
```
Find-MgUserMeetingTime -UserId <String> [-Attendees <IMicrosoftGraphAttendeeBase[]>] [-IsOrganizerOptional]
 [-LocationConstraintIsRequired] [-LocationConstraintLocations <IMicrosoftGraphLocationConstraintItem[]>]
 [-LocationConstraintSuggestLocation] [-MaxCandidates <Int32>] [-MeetingDuration <TimeSpan>]
 [-MinimumAttendeePercentage <Double>] [-ReturnSuggestionReasons] [-TimeConstraintActivityDomain <String>]
 [-TimeConstraintTimeSlots <IMicrosoftGraphTimeSlot[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Find1
```
Find-MgUserMeetingTime -UserId <String>
 -BodyParameter <IPathsSzpbzfUsersUserIdMicrosoftGraphFindmeetingtimesPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### FindViaIdentity1
```
Find-MgUserMeetingTime -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPathsSzpbzfUsersUserIdMicrosoftGraphFindmeetingtimesPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### FindViaIdentityExpanded1
```
Find-MgUserMeetingTime -InputObject <IUsersActionsIdentity> [-Attendees <IMicrosoftGraphAttendeeBase[]>]
 [-IsOrganizerOptional] [-LocationConstraintIsRequired]
 [-LocationConstraintLocations <IMicrosoftGraphLocationConstraintItem[]>] [-LocationConstraintSuggestLocation]
 [-MaxCandidates <Int32>] [-MeetingDuration <TimeSpan>] [-MinimumAttendeePercentage <Double>]
 [-ReturnSuggestionReasons] [-TimeConstraintActivityDomain <String>]
 [-TimeConstraintTimeSlots <IMicrosoftGraphTimeSlot[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action findMeetingTimes

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

### -Attendees
.
To construct, see NOTES section for ATTENDEES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttendeeBase[]
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsSzpbzfUsersUserIdMicrosoftGraphFindmeetingtimesPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Find1, FindViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
Parameter Sets: FindViaIdentity1, FindViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsOrganizerOptional
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationConstraintIsRequired
The client requests the service to include in the response a meeting location for the meeting.
If this is true and all the resources are busy, findMeetingTimes will not return any meeting time suggestions.
If this is false and all the resources are busy, findMeetingTimes would still look for meeting times without locations.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationConstraintLocations
Constraint information for one or more locations that the client requests for the meeting.
To construct, see NOTES section for LOCATIONCONSTRAINTLOCATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLocationConstraintItem[]
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationConstraintSuggestLocation
The client requests the service to suggest one or more meeting locations.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaxCandidates
.

```yaml
Type: System.Int32
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MeetingDuration
.

```yaml
Type: System.TimeSpan
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumAttendeePercentage
.

```yaml
Type: System.Double
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReturnSuggestionReasons
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeConstraintActivityDomain
activityDomain

```yaml
Type: System.String
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeConstraintTimeSlots
.
To construct, see NOTES section for TIMECONSTRAINTTIMESLOTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTimeSlot[]
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
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
Parameter Sets: Find1, FindExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPathsSzpbzfUsersUserIdMicrosoftGraphFindmeetingtimesPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMeetingTimeSuggestionsResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ATTENDEES <IMicrosoftGraphAttendeeBase[]>: .
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[Address <String>]`: The email address of the person or entity.
    - `[Name <String>]`: The display name of the person or entity.
  - `[Type <String>]`: attendeeType

BODYPARAMETER <IPathsSzpbzfUsersUserIdMicrosoftGraphFindmeetingtimesPostRequestbodyContentApplicationJsonSchema>: .
  - `[Attendees <IMicrosoftGraphAttendeeBase[]>]`: 
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
    - `[Type <String>]`: attendeeType
  - `[IsOrganizerOptional <Boolean?>]`: 
  - `[LocationConstraintIsRequired <Boolean?>]`: The client requests the service to include in the response a meeting location for the meeting. If this is true and all the resources are busy, findMeetingTimes will not return any meeting time suggestions. If this is false and all the resources are busy, findMeetingTimes would still look for meeting times without locations.
  - `[LocationConstraintLocations <IMicrosoftGraphLocationConstraintItem[]>]`: Constraint information for one or more locations that the client requests for the meeting.
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
    - `[ResolveAvailability <Boolean?>]`: If set to true and the specified resource is busy, findMeetingTimes looks for another resource that is free. If set to false and the specified resource is busy, findMeetingTimes returns the resource best ranked in the user's cache without checking if it's free. Default is true.
  - `[LocationConstraintSuggestLocation <Boolean?>]`: The client requests the service to suggest one or more meeting locations.
  - `[MaxCandidates <Int32?>]`: 
  - `[MeetingDuration <TimeSpan?>]`: 
  - `[MinimumAttendeePercentage <Double?>]`: 
  - `[ReturnSuggestionReasons <Boolean?>]`: 
  - `[TimeConstraintActivityDomain <String>]`: activityDomain
  - `[TimeConstraintTimeSlots <IMicrosoftGraphTimeSlot[]>]`: 
    - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.

INPUTOBJECT <IUsersActionsIdentity>: Identity Parameter
  - `[AppLogCollectionRequestId <String>]`: key: appLogCollectionRequest-id of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: key: authenticationMethod-id of authenticationMethod
  - `[CalendarGroupId <String>]`: key: calendarGroup-id of calendarGroup
  - `[CalendarId <String>]`: key: calendar-id of calendar
  - `[DeviceEnrollmentConfigurationId <String>]`: key: deviceEnrollmentConfiguration-id of deviceEnrollmentConfiguration
  - `[EventId <String>]`: key: event-id of event
  - `[EventId1 <String>]`: key: event-id of event
  - `[MailFolderId <String>]`: key: mailFolder-id of mailFolder
  - `[MailFolderId1 <String>]`: key: mailFolder-id of mailFolder
  - `[ManagedDeviceId <String>]`: key: managedDevice-id of managedDevice
  - `[MessageId <String>]`: key: message-id of message
  - `[MobileAppTroubleshootingEventId <String>]`: key: mobileAppTroubleshootingEvent-id of mobileAppTroubleshootingEvent
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[OutlookTaskFolderId <String>]`: key: outlookTaskFolder-id of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: key: outlookTaskGroup-id of outlookTaskGroup
  - `[OutlookTaskId <String>]`: key: outlookTask-id of outlookTask
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[TeamsAppInstallationId <String>]`: key: teamsAppInstallation-id of teamsAppInstallation
  - `[UserId <String>]`: key: user-id of user
  - `[WindowsInformationProtectionDeviceRegistrationId <String>]`: key: windowsInformationProtectionDeviceRegistration-id of windowsInformationProtectionDeviceRegistration

LOCATIONCONSTRAINTLOCATIONS <IMicrosoftGraphLocationConstraintItem[]>: Constraint information for one or more locations that the client requests for the meeting.
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
  - `[ResolveAvailability <Boolean?>]`: If set to true and the specified resource is busy, findMeetingTimes looks for another resource that is free. If set to false and the specified resource is busy, findMeetingTimes returns the resource best ranked in the user's cache without checking if it's free. Default is true.

TIMECONSTRAINTTIMESLOTS <IMicrosoftGraphTimeSlot[]>: .
  - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.

## RELATED LINKS

