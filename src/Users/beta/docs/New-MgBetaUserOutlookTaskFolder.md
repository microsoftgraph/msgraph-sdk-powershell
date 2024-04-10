---
external help file:
Module Name: Microsoft.Graph.Beta.Users
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.users/new-mgbetauseroutlooktaskfolder
schema: 2.0.0
---

# New-MgBetaUserOutlookTaskFolder

## SYNOPSIS
Create a task folder in the default task group (My Tasks) of the user's mailbox.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaUserOutlookTaskFolder -UserId <String> [-AdditionalProperties <Hashtable>] [-ChangeKey <String>]
 [-Id <String>] [-IsDefaultFolder]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-Name <String>]
 [-ParentGroupKey <String>] [-ResponseHeadersVariable <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-Tasks <IMicrosoftGraphOutlookTask[]>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaUserOutlookTaskFolder -UserId <String> -BodyParameter <IMicrosoftGraphOutlookTaskFolder>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaUserOutlookTaskFolder -InputObject <IUsersIdentity>
 -BodyParameter <IMicrosoftGraphOutlookTaskFolder> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaUserOutlookTaskFolder -InputObject <IUsersIdentity> [-AdditionalProperties <Hashtable>]
 [-ChangeKey <String>] [-Id <String>] [-IsDefaultFolder]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-Name <String>]
 [-ParentGroupKey <String>] [-ResponseHeadersVariable <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-Tasks <IMicrosoftGraphOutlookTask[]>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a task folder in the default task group (My Tasks) of the user's mailbox.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	Name = "Volunteer"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOutlookTaskFolder -UserId $userId -BodyParameter $params
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
outlookTaskFolder
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOutlookTaskFolder
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChangeKey
The version of the task folder.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IUsersIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsDefaultFolder
True if the folder is the default task folder.

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
The collection of multi-value extended properties defined for the task folder.
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
The name of the task folder.

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

### -ParentGroupKey
The unique GUID identifier for the task folder's parent group.

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

### -SingleValueExtendedProperties
The collection of single-value extended properties defined for the task folder.
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

### -Tasks
The tasks in this task folder.
Read-only.
Nullable.
To construct, see NOTES section for TASKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOutlookTask[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOutlookTaskFolder

### Microsoft.Graph.Beta.PowerShell.Models.IUsersIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOutlookTaskFolder

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphOutlookTaskFolder>`: outlookTaskFolder
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ChangeKey <String>]`: The version of the task folder.
  - `[IsDefaultFolder <Boolean?>]`: True if the folder is the default task folder.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the task folder. Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[Name <String>]`: The name of the task folder.
  - `[ParentGroupKey <String>]`: The unique GUID identifier for the task folder's parent group.
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the task folder. Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Value <String>]`: A property value.
  - `[Tasks <IMicrosoftGraphOutlookTask[]>]`: The tasks in this task folder. Read-only. Nullable.
    - `[Categories <String[]>]`: 
    - `[ChangeKey <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AssignedTo <String>]`: The name of the person who has been assigned the task in Outlook. Read-only.
    - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.  Read-only. Nullable.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ContentType <String>]`: The MIME type.
      - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Name <String>]`: The display name of the attachment. This does not need to be the actual file name.
      - `[Size <Int32?>]`: The length of the attachment in bytes.
    - `[Body <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[CompletedDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
      - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
    - `[DueDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[HasAttachments <Boolean?>]`: Set to true if the task has attachments.
    - `[Importance <String>]`: importance
    - `[IsReminderOn <Boolean?>]`: Set to true if an alert is set to remind the user of the task.
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the task. Read-only. Nullable.
    - `[Owner <String>]`: The name of the person who created the task.
    - `[ParentFolderId <String>]`: The unique identifier for the task's parent folder.
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
    - `[ReminderDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Sensitivity <String>]`: sensitivity
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the task. Read-only. Nullable.
    - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Status <String>]`: taskStatus
    - `[Subject <String>]`: A brief description or title of the task.

`INPUTOBJECT <IUsersIdentity>`: Identity Parameter
  - `[AppId <String>]`: Alternate key of servicePrincipal
  - `[AttachmentBaseId <String>]`: The unique identifier of attachmentBase
  - `[AttachmentId <String>]`: The unique identifier of attachment
  - `[AttachmentSessionId <String>]`: The unique identifier of attachmentSession
  - `[ChecklistItemId <String>]`: The unique identifier of checklistItem
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[LicenseDetailsId <String>]`: The unique identifier of licenseDetails
  - `[LinkedResourceId <String>]`: The unique identifier of linkedResource
  - `[NotificationId <String>]`: The unique identifier of notification
  - `[OAuth2PermissionGrantId <String>]`: The unique identifier of oAuth2PermissionGrant
  - `[OutlookCategoryId <String>]`: The unique identifier of outlookCategory
  - `[OutlookTaskFolderId <String>]`: The unique identifier of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: The unique identifier of outlookTaskGroup
  - `[OutlookTaskId <String>]`: The unique identifier of outlookTask
  - `[ProfilePhotoId <String>]`: The unique identifier of profilePhoto
  - `[ServicePrincipalId <String>]`: The unique identifier of servicePrincipal
  - `[ServiceStorageQuotaBreakdownId <String>]`: The unique identifier of serviceStorageQuotaBreakdown
  - `[SharedInsightId <String>]`: The unique identifier of sharedInsight
  - `[TodoTaskId <String>]`: The unique identifier of todoTask
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[TrendingId <String>]`: The unique identifier of trending
  - `[UsedInsightId <String>]`: The unique identifier of usedInsight
  - `[UserId <String>]`: The unique identifier of user
  - `[WindowsSettingId <String>]`: The unique identifier of windowsSetting
  - `[WindowsSettingInstanceId <String>]`: The unique identifier of windowsSettingInstance

`MULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>`: The collection of multi-value extended properties defined for the task folder. Read-only. Nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Value <String[]>]`: A collection of property values.

`SINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>`: The collection of single-value extended properties defined for the task folder. Read-only. Nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Value <String>]`: A property value.

`TASKS <IMicrosoftGraphOutlookTask[]>`: The tasks in this task folder. Read-only. Nullable.
  - `[Categories <String[]>]`: 
  - `[ChangeKey <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AssignedTo <String>]`: The name of the person who has been assigned the task in Outlook. Read-only.
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.  Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Name <String>]`: The display name of the attachment. This does not need to be the actual file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Body <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[CompletedDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
    - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
  - `[DueDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[HasAttachments <Boolean?>]`: Set to true if the task has attachments.
  - `[Importance <String>]`: importance
  - `[IsReminderOn <Boolean?>]`: Set to true if an alert is set to remind the user of the task.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the task. Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[Owner <String>]`: The name of the person who created the task.
  - `[ParentFolderId <String>]`: The unique identifier for the task's parent folder.
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
  - `[ReminderDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[Sensitivity <String>]`: sensitivity
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the task. Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Value <String>]`: A property value.
  - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[Status <String>]`: taskStatus
  - `[Subject <String>]`: A brief description or title of the task.

## RELATED LINKS

