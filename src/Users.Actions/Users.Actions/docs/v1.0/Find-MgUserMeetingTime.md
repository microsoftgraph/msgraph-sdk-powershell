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
Find-MgUserMeetingTime -UserId <String> [-AdditionalProperties <Hashtable>]
 [-Attendees <IMicrosoftGraphAttendeeBase[]>] [-IsOrganizerOptional]
 [-LocationConstraint <IMicrosoftGraphLocationConstraint1>] [-MaxCandidates <Int32>]
 [-MeetingDuration <TimeSpan>] [-MinimumAttendeePercentage <Double>] [-ReturnSuggestionReasons]
 [-TimeConstraint <IMicrosoftGraphTimeConstraint>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Find1
```
Find-MgUserMeetingTime -UserId <String>
 -BodyParameter <IPathsSzpbzfUsersUserIdMicrosoftGraphFindmeetingtimesPostRequestbodyContentApplicationJsonSchema1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### FindViaIdentity1
```
Find-MgUserMeetingTime -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPathsSzpbzfUsersUserIdMicrosoftGraphFindmeetingtimesPostRequestbodyContentApplicationJsonSchema1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### FindViaIdentityExpanded1
```
Find-MgUserMeetingTime -InputObject <IUsersActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-Attendees <IMicrosoftGraphAttendeeBase[]>] [-IsOrganizerOptional]
 [-LocationConstraint <IMicrosoftGraphLocationConstraint1>] [-MaxCandidates <Int32>]
 [-MeetingDuration <TimeSpan>] [-MinimumAttendeePercentage <Double>] [-ReturnSuggestionReasons]
 [-TimeConstraint <IMicrosoftGraphTimeConstraint>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action findMeetingTimes

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Attendees
.
To construct, please use Get-Help -Online and see NOTES section for ATTENDEES properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsSzpbzfUsersUserIdMicrosoftGraphFindmeetingtimesPostRequestbodyContentApplicationJsonSchema1
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -LocationConstraint
locationConstraint
To construct, please use Get-Help -Online and see NOTES section for LOCATIONCONSTRAINT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLocationConstraint1
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

### -TimeConstraint
timeConstraint
To construct, please use Get-Help -Online and see NOTES section for TIMECONSTRAINT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTimeConstraint
Parameter Sets: FindExpanded1, FindViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPathsSzpbzfUsersUserIdMicrosoftGraphFindmeetingtimesPostRequestbodyContentApplicationJsonSchema1

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMeetingTimeSuggestionsResult1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ATTENDEES <IMicrosoftGraphAttendeeBase[]>: .
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.
  - `[Type <String>]`: attendeeType

BODYPARAMETER <IPathsSzpbzfUsersUserIdMicrosoftGraphFindmeetingtimesPostRequestbodyContentApplicationJsonSchema1>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Attendees <IMicrosoftGraphAttendeeBase[]>]`: 
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of an entity instance.
      - `[Name <String>]`: The display name of an entity instance.
    - `[Type <String>]`: attendeeType
  - `[IsOrganizerOptional <Boolean?>]`: 
  - `[LocationConstraint <IMicrosoftGraphLocationConstraint1>]`: locationConstraint
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsRequired <Boolean?>]`: The client requests the service to include in the response a meeting location for the meeting. If this is true and all the resources are busy, findMeetingTimes will not return any meeting time suggestions. If this is false and all the resources are busy, findMeetingTimes would still look for meeting times without locations.
    - `[Locations <IMicrosoftGraphLocationConstraintItem1[]>]`: Constraint information for one or more locations that the client requests for the meeting.
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
      - `[ResolveAvailability <Boolean?>]`: If set to true and the specified resource is busy, findMeetingTimes looks for another resource that is free. If set to false and the specified resource is busy, findMeetingTimes returns the resource best ranked in the user's cache without checking if it's free. Default is true.
    - `[SuggestLocation <Boolean?>]`: The client requests the service to suggest one or more meeting locations.
  - `[MaxCandidates <Int32?>]`: 
  - `[MeetingDuration <TimeSpan?>]`: 
  - `[MinimumAttendeePercentage <Double?>]`: 
  - `[ReturnSuggestionReasons <Boolean?>]`: 
  - `[TimeConstraint <IMicrosoftGraphTimeConstraint>]`: timeConstraint
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ActivityDomain <String>]`: activityDomain
    - `[TimeSlots <IMicrosoftGraphTimeSlot[]>]`: 
      - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
        - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
      - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

INPUTOBJECT <IUsersActionsIdentity>: Identity Parameter
  - `[AccessReviewInstanceId <String>]`: key: id of accessReviewInstance
  - `[AccessReviewStageId <String>]`: key: id of accessReviewStage
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
  - `[BaseTaskId <String>]`: key: id of baseTask
  - `[BaseTaskListId <String>]`: key: id of baseTaskList
  - `[CalendarId <String>]`: key: id of calendar
  - `[ChatId <String>]`: key: id of chat
  - `[ChatMessageId <String>]`: key: id of chatMessage
  - `[ChatMessageId1 <String>]`: key: id of chatMessage
  - `[CloudPcId <String>]`: key: id of cloudPC
  - `[ContentTypeId <String>]`: key: id of contentType
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceId <String>]`: key: id of device
  - `[DeviceLogCollectionResponseId <String>]`: key: id of deviceLogCollectionResponse
  - `[DocumentSetVersionId <String>]`: key: id of documentSetVersion
  - `[DriveId <String>]`: key: id of drive
  - `[DriveItemId <String>]`: key: id of driveItem
  - `[DriveItemVersionId <String>]`: key: id of driveItemVersion
  - `[EventId <String>]`: key: id of event
  - `[EventId1 <String>]`: key: id of event
  - `[ListItemId <String>]`: key: id of listItem
  - `[ListItemVersionId <String>]`: key: id of listItemVersion
  - `[MailFolderId <String>]`: key: id of mailFolder
  - `[MailFolderId1 <String>]`: key: id of mailFolder
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[MessageId <String>]`: key: id of message
  - `[MicrosoftAuthenticatorAuthenticationMethodId <String>]`: key: id of microsoftAuthenticatorAuthenticationMethod
  - `[MobileAppTroubleshootingEventId <String>]`: key: id of mobileAppTroubleshootingEvent
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[OutlookTaskFolderId <String>]`: key: id of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: key: id of outlookTaskGroup
  - `[OutlookTaskId <String>]`: key: id of outlookTask
  - `[PasswordlessMicrosoftAuthenticatorAuthenticationMethodId <String>]`: key: id of passwordlessMicrosoftAuthenticatorAuthenticationMethod
  - `[PermissionId <String>]`: key: id of permission
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SensitivityLabelId <String>]`: key: id of sensitivityLabel
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[TeamsAppInstallationId <String>]`: key: id of teamsAppInstallation
  - `[TodoTaskId <String>]`: key: id of todoTask
  - `[TodoTaskListId <String>]`: key: id of todoTaskList
  - `[UserId <String>]`: key: id of user
  - `[WindowsHelloForBusinessAuthenticationMethodId <String>]`: key: id of windowsHelloForBusinessAuthenticationMethod

LOCATIONCONSTRAINT <IMicrosoftGraphLocationConstraint1>: locationConstraint
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsRequired <Boolean?>]`: The client requests the service to include in the response a meeting location for the meeting. If this is true and all the resources are busy, findMeetingTimes will not return any meeting time suggestions. If this is false and all the resources are busy, findMeetingTimes would still look for meeting times without locations.
  - `[Locations <IMicrosoftGraphLocationConstraintItem1[]>]`: Constraint information for one or more locations that the client requests for the meeting.
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
    - `[ResolveAvailability <Boolean?>]`: If set to true and the specified resource is busy, findMeetingTimes looks for another resource that is free. If set to false and the specified resource is busy, findMeetingTimes returns the resource best ranked in the user's cache without checking if it's free. Default is true.
  - `[SuggestLocation <Boolean?>]`: The client requests the service to suggest one or more meeting locations.

TIMECONSTRAINT <IMicrosoftGraphTimeConstraint>: timeConstraint
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ActivityDomain <String>]`: activityDomain
  - `[TimeSlots <IMicrosoftGraphTimeSlot[]>]`: 
    - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
      - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
    - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

## RELATED LINKS

