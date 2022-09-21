---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgidentitygovernanceaccessreviewhistorydefinition
schema: 2.0.0
---

# New-MgIdentityGovernanceAccessReviewHistoryDefinition

## SYNOPSIS
Create a new accessReviewHistoryDefinition object.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgIdentityGovernanceAccessReviewHistoryDefinition [-AdditionalProperties <Hashtable>]
 [-CreatedBy <IMicrosoftGraphUserIdentity>] [-CreatedDateTime <DateTime>] [-Decisions <String[]>]
 [-DisplayName <String>] [-Id <String>] [-Instances <IMicrosoftGraphAccessReviewHistoryInstance[]>]
 [-ReviewHistoryPeriodEndDateTime <DateTime>] [-ReviewHistoryPeriodStartDateTime <DateTime>]
 [-ScheduleSettings <IMicrosoftGraphAccessReviewHistoryScheduleSettings>]
 [-Scopes <IMicrosoftGraphAccessReviewScope[]>] [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgIdentityGovernanceAccessReviewHistoryDefinition
 -BodyParameter <IMicrosoftGraphAccessReviewHistoryDefinition> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new accessReviewHistoryDefinition object.

## EXAMPLES

### Example 1: Using the New-MgIdentityGovernanceAccessReviewHistoryDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Last quarter's group reviews April 2021"
	Decisions = @(
		"approve"
		"deny"
		"dontKnow"
		"notReviewed"
		"notNotified"
	)
	ScheduleSettings = @{
		ReportRange = "P1M"
		Recurrence = @{
			Pattern = @{
				Type = "monthly"
				Interval = 1
			}
			Range = @{
				Type = "noEnd"
				StartDate = "2018-08-03T21:02:30.667Z"
				Count = 
			}
		}
	}
	Scopes = @(
		@{
			"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
			QueryType = "MicrosoftGraph"
			Query = "/identityGovernance/accessReviews/definitions?$filter=contains(scope/query, 'accessPackageAssignments')"
			QueryRoot = $null
		}
		@{
			"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
			QueryType = "MicrosoftGraph"
			Query = "/identityGovernance/accessReviews/definitions?$filter=contains(scope/query, '/groups')"
			QueryRoot = $null
		}
	)
}
New-MgIdentityGovernanceAccessReviewHistoryDefinition -BodyParameter $params
```

This example shows how to use the New-MgIdentityGovernanceAccessReviewHistoryDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessReviewHistoryDefinition
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewHistoryDefinition
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
userIdentity
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserIdentity
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Timestamp when the access review definition was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Decisions
Determines which review decisions will be included in the fetched review history data if specified.
Optional on create.
All decisions will be included by default if no decisions are provided on create.
Possible values are: approve, deny, dontKnow, notReviewed, and notNotified.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Name for the access review history data collection.
Required.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Instances
If the accessReviewHistoryDefinition is a recurring definition, instances represent each recurrence.
A definition that does not recur will have exactly one instance.
To construct, please use Get-Help -Online and see NOTES section for INSTANCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewHistoryInstance[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReviewHistoryPeriodEndDateTime
A timestamp.
Reviews ending on or before this date will be included in the fetched history data.
Only required if scheduleSettings is not defined.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReviewHistoryPeriodStartDateTime
A timestamp.
Reviews starting on or before this date will be included in the fetched history data.
Only required if scheduleSettings is not defined.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScheduleSettings
accessReviewHistoryScheduleSettings
To construct, please use Get-Help -Online and see NOTES section for SCHEDULESETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewHistoryScheduleSettings
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scopes
Used to scope what reviews are included in the fetched history data.
Fetches reviews whose scope matches with this provided scope.
Required.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewScope[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
accessReviewHistoryStatus

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewHistoryDefinition

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewHistoryDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAccessReviewHistoryDefinition>: accessReviewHistoryDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[CreatedDateTime <DateTime?>]`: Timestamp when the access review definition was created.
  - `[Decisions <String[]>]`: Determines which review decisions will be included in the fetched review history data if specified. Optional on create. All decisions will be included by default if no decisions are provided on create. Possible values are: approve, deny, dontKnow, notReviewed, and notNotified.
  - `[DisplayName <String>]`: Name for the access review history data collection. Required.
  - `[Instances <IMicrosoftGraphAccessReviewHistoryInstance[]>]`: If the accessReviewHistoryDefinition is a recurring definition, instances represent each recurrence. A definition that does not recur will have exactly one instance.
    - `[Id <String>]`: 
    - `[DownloadUri <String>]`: Uri which can be used to retrieve review history data. This URI will be active for 24 hours after being generated. Required.
    - `[ExpirationDateTime <DateTime?>]`: Timestamp when this instance and associated data expires and the history is deleted. Required.
    - `[FulfilledDateTime <DateTime?>]`: Timestamp when all of the available data for this instance was collected. This will be set after this instance's status is set to done. Required.
    - `[ReviewHistoryPeriodEndDateTime <DateTime?>]`: Timestamp, reviews ending on or before this date will be included in the fetched history data.
    - `[ReviewHistoryPeriodStartDateTime <DateTime?>]`: Timestamp, reviews starting on or after this date will be included in the fetched history data.
    - `[RunDateTime <DateTime?>]`: Timestamp when the instance's history data is scheduled to be generated.
    - `[Status <String>]`: accessReviewHistoryStatus
  - `[ReviewHistoryPeriodEndDateTime <DateTime?>]`: A timestamp. Reviews ending on or before this date will be included in the fetched history data. Only required if scheduleSettings is not defined.
  - `[ReviewHistoryPeriodStartDateTime <DateTime?>]`: A timestamp. Reviews starting on or before this date will be included in the fetched history data. Only required if scheduleSettings is not defined.
  - `[ScheduleSettings <IMicrosoftGraphAccessReviewHistoryScheduleSettings>]`: accessReviewHistoryScheduleSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
    - `[ReportRange <String>]`: A duration string in ISO 8601 duration format specifying the lookback period of the generated review history data. For example, if a history definition is scheduled to run on the 1st of every month, the reportRange is P1M. In this case, on the first of every month, access review history data will be collected containing only the previous month's review data. Note: Only years, months, and days ISO 8601 properties are supported. Required.
  - `[Scopes <IMicrosoftGraphAccessReviewScope[]>]`: Used to scope what reviews are included in the fetched history data. Fetches reviews whose scope matches with this provided scope. Required.
  - `[Status <String>]`: accessReviewHistoryStatus

CREATEDBY <IMicrosoftGraphUserIdentity>: userIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[Id <String>]`: Unique identifier for the identity.
  - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.

INSTANCES <IMicrosoftGraphAccessReviewHistoryInstance[]>: If the accessReviewHistoryDefinition is a recurring definition, instances represent each recurrence. A definition that does not recur will have exactly one instance.
  - `[Id <String>]`: 
  - `[DownloadUri <String>]`: Uri which can be used to retrieve review history data. This URI will be active for 24 hours after being generated. Required.
  - `[ExpirationDateTime <DateTime?>]`: Timestamp when this instance and associated data expires and the history is deleted. Required.
  - `[FulfilledDateTime <DateTime?>]`: Timestamp when all of the available data for this instance was collected. This will be set after this instance's status is set to done. Required.
  - `[ReviewHistoryPeriodEndDateTime <DateTime?>]`: Timestamp, reviews ending on or before this date will be included in the fetched history data.
  - `[ReviewHistoryPeriodStartDateTime <DateTime?>]`: Timestamp, reviews starting on or after this date will be included in the fetched history data.
  - `[RunDateTime <DateTime?>]`: Timestamp when the instance's history data is scheduled to be generated.
  - `[Status <String>]`: accessReviewHistoryStatus

SCHEDULESETTINGS <IMicrosoftGraphAccessReviewHistoryScheduleSettings>: accessReviewHistoryScheduleSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
  - `[ReportRange <String>]`: A duration string in ISO 8601 duration format specifying the lookback period of the generated review history data. For example, if a history definition is scheduled to run on the 1st of every month, the reportRange is P1M. In this case, on the first of every month, access review history data will be collected containing only the previous month's review data. Note: Only years, months, and days ISO 8601 properties are supported. Required.

## RELATED LINKS

