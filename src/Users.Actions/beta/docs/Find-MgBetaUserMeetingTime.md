---
external help file:
Module Name: Microsoft.Graph.Beta.Users.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.users.actions/find-mgbetausermeetingtime
schema: 2.0.0
---

# Find-MgBetaUserMeetingTime

## SYNOPSIS
Suggest meeting times and locations based on organizer and attendee availability, and time or location constraints specified as parameters.
If findMeetingTimes cannot return any meeting suggestions, the response would indicate a reason in the emptySuggestionsReason property.
\nBased on this value, you can better adjust the parameters and call findMeetingTimes again.
The algorithm used to suggest meeting times and locations undergoes fine-tuning from time to time.
In scenarios like test environments where the input parameters and calendar data remain static, expect that the suggested results may differ over time.

## SYNTAX

### FindExpanded (Default)
```
Find-MgBetaUserMeetingTime -UserId <String> [-AdditionalProperties <Hashtable>]
 [-Attendees <IMicrosoftGraphAttendeeBase[]>] [-IsOrganizerOptional]
 [-LocationConstraint <IMicrosoftGraphLocationConstraint>] [-MaxCandidates <Int32>]
 [-MeetingDuration <TimeSpan>] [-MinimumAttendeePercentage <Double>] [-ReturnSuggestionReasons]
 [-TimeConstraint <IMicrosoftGraphTimeConstraint>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Find
```
Find-MgBetaUserMeetingTime -UserId <String>
 -BodyParameter <IComponents1H459T5RequestbodiesFindmeetingtimesrequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### FindViaIdentity
```
Find-MgBetaUserMeetingTime -InputObject <IUsersActionsIdentity>
 -BodyParameter <IComponents1H459T5RequestbodiesFindmeetingtimesrequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### FindViaIdentityExpanded
```
Find-MgBetaUserMeetingTime -InputObject <IUsersActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-Attendees <IMicrosoftGraphAttendeeBase[]>] [-IsOrganizerOptional]
 [-LocationConstraint <IMicrosoftGraphLocationConstraint>] [-MaxCandidates <Int32>]
 [-MeetingDuration <TimeSpan>] [-MinimumAttendeePercentage <Double>] [-ReturnSuggestionReasons]
 [-TimeConstraint <IMicrosoftGraphTimeConstraint>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Suggest meeting times and locations based on organizer and attendee availability, and time or location constraints specified as parameters.
If findMeetingTimes cannot return any meeting suggestions, the response would indicate a reason in the emptySuggestionsReason property.
\nBased on this value, you can better adjust the parameters and call findMeetingTimes again.
The algorithm used to suggest meeting times and locations undergoes fine-tuning from time to time.
In scenarios like test environments where the input parameters and calendar data remain static, expect that the suggested results may differ over time.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	Attendees = @(
		@{
			Type = "required"
			EmailAddress = @{
				Name = "Alex Wilbur"
				Address = "alexw@contoso.onmicrosoft.com"
			}
		}
	)
	LocationConstraint = @{
		IsRequired = "false"
		SuggestLocation = "false"
		Locations = @(
			@{
				ResolveAvailability = "false"
				DisplayName = "Conf room Hood"
			}
		)
	}
	TimeConstraint = @{
		ActivityDomain = "work"
		TimeSlots = @(
			@{
				Start = @{
					DateTime = "2019-04-16T09:00:00"
					TimeZone = "Pacific Standard Time"
				}
				End = @{
					DateTime = "2019-04-18T17:00:00"
					TimeZone = "Pacific Standard Time"
				}
			}
		)
	}
	IsOrganizerOptional = "false"
	MeetingDuration = "PT1H"
	ReturnSuggestionReasons = "true"
	MinimumAttendeePercentage = "100"
}
# A UPN can also be used as -UserId.
Find-MgBetaUserMeetingTime -UserId $userId -BodyParameter $params
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: FindExpanded, FindViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Attendees
.
To construct, see NOTES section for ATTENDEES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAttendeeBase[]
Parameter Sets: FindExpanded, FindViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IComponents1H459T5RequestbodiesFindmeetingtimesrequestbodyContentApplicationJsonSchema
Parameter Sets: Find, FindViaIdentity
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IUsersActionsIdentity
Parameter Sets: FindViaIdentity, FindViaIdentityExpanded
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
Parameter Sets: FindExpanded, FindViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationConstraint
locationConstraint
To construct, see NOTES section for LOCATIONCONSTRAINT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLocationConstraint
Parameter Sets: FindExpanded, FindViaIdentityExpanded
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
Parameter Sets: FindExpanded, FindViaIdentityExpanded
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
Parameter Sets: FindExpanded, FindViaIdentityExpanded
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
Parameter Sets: FindExpanded, FindViaIdentityExpanded
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
Parameter Sets: FindExpanded, FindViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeConstraint
timeConstraint
To construct, see NOTES section for TIMECONSTRAINT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeConstraint
Parameter Sets: FindExpanded, FindViaIdentityExpanded
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
Parameter Sets: Find, FindExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IComponents1H459T5RequestbodiesFindmeetingtimesrequestbodyContentApplicationJsonSchema

### Microsoft.Graph.Beta.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingTimeSuggestionsResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ATTENDEES <IMicrosoftGraphAttendeeBase[]>`: .
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.
  - `[Type <String>]`: attendeeType

`BODYPARAMETER <IComponents1H459T5RequestbodiesFindmeetingtimesrequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Attendees <IMicrosoftGraphAttendeeBase[]>]`: 
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of an entity instance.
      - `[Name <String>]`: The display name of an entity instance.
    - `[Type <String>]`: attendeeType
  - `[IsOrganizerOptional <Boolean?>]`: 
  - `[LocationConstraint <IMicrosoftGraphLocationConstraint>]`: locationConstraint
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsRequired <Boolean?>]`: The client requests the service to include in the response a meeting location for the meeting. If this is true and all the resources are busy, findMeetingTimes won't return any meeting time suggestions. If this is false and all the resources are busy, findMeetingTimes would still look for meeting times without locations.
    - `[Locations <IMicrosoftGraphLocationConstraintItem[]>]`: Constraint information for one or more locations that the client requests for the meeting.
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

`INPUTOBJECT <IUsersActionsIdentity>`: Identity Parameter
  - `[AccessReviewInstanceId <String>]`: The unique identifier of accessReviewInstance
  - `[AccessReviewStageId <String>]`: The unique identifier of accessReviewStage
  - `[AppLogCollectionRequestId <String>]`: The unique identifier of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: The unique identifier of authenticationMethod
  - `[CalendarId <String>]`: The unique identifier of calendar
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[ChatMessageId1 <String>]`: The unique identifier of chatMessage
  - `[CloudPcId <String>]`: The unique identifier of cloudPC
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[DeviceEnrollmentConfigurationId <String>]`: The unique identifier of deviceEnrollmentConfiguration
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[DriveItemId <String>]`: The unique identifier of driveItem
  - `[DriveItemVersionId <String>]`: The unique identifier of driveItemVersion
  - `[EventId <String>]`: The unique identifier of event
  - `[EventId1 <String>]`: The unique identifier of event
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[MailFolderId <String>]`: The unique identifier of mailFolder
  - `[MailFolderId1 <String>]`: The unique identifier of mailFolder
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[MessageId <String>]`: The unique identifier of message
  - `[MobileAppTroubleshootingEventId <String>]`: The unique identifier of mobileAppTroubleshootingEvent
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[OnlineMeetingId <String>]`: The unique identifier of onlineMeeting
  - `[OutlookTaskFolderId <String>]`: The unique identifier of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: The unique identifier of outlookTaskGroup
  - `[OutlookTaskId <String>]`: The unique identifier of outlookTask
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[PlannerPlanId <String>]`: The unique identifier of plannerPlan
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TodoTaskId <String>]`: The unique identifier of todoTask
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[UserId <String>]`: The unique identifier of user

`LOCATIONCONSTRAINT <IMicrosoftGraphLocationConstraint>`: locationConstraint
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsRequired <Boolean?>]`: The client requests the service to include in the response a meeting location for the meeting. If this is true and all the resources are busy, findMeetingTimes won't return any meeting time suggestions. If this is false and all the resources are busy, findMeetingTimes would still look for meeting times without locations.
  - `[Locations <IMicrosoftGraphLocationConstraintItem[]>]`: Constraint information for one or more locations that the client requests for the meeting.
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
    - `[ResolveAvailability <Boolean?>]`: If set to true and the specified resource is busy, findMeetingTimes looks for another resource that is free. If set to false and the specified resource is busy, findMeetingTimes returns the resource best ranked in the user's cache without checking if it's free. Default is true.
  - `[SuggestLocation <Boolean?>]`: The client requests the service to suggest one or more meeting locations.

`TIMECONSTRAINT <IMicrosoftGraphTimeConstraint>`: timeConstraint
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ActivityDomain <String>]`: activityDomain
  - `[TimeSlots <IMicrosoftGraphTimeSlot[]>]`: 
    - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
      - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
    - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

## RELATED LINKS

