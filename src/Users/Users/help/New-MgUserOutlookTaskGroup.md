---
external help file: Microsoft.Graph.Users-help.xml
Module Name: Microsoft.Graph.Users
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/new-mguseroutlooktaskgroup
schema: 2.0.0
---

# New-MgUserOutlookTaskGroup

## SYNOPSIS
Create new navigation property to taskGroups for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserOutlookTaskGroup -UserId <String> [-AdditionalProperties <Hashtable>] [-ChangeKey <String>]
 [-GroupKey <String>] [-Id <String>] [-IsDefaultGroup] [-Name <String>]
 [-TaskFolders <IMicrosoftGraphOutlookTaskFolder[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgUserOutlookTaskGroup -UserId <String> -BodyParameter <IMicrosoftGraphOutlookTaskGroup> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserOutlookTaskGroup -InputObject <IUsersIdentity> [-AdditionalProperties <Hashtable>]
 [-ChangeKey <String>] [-GroupKey <String>] [-Id <String>] [-IsDefaultGroup] [-Name <String>]
 [-TaskFolders <IMicrosoftGraphOutlookTaskFolder[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserOutlookTaskGroup -InputObject <IUsersIdentity> -BodyParameter <IMicrosoftGraphOutlookTaskGroup>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to taskGroups for users

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
outlookTaskGroup
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphOutlookTaskGroup
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChangeKey
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupKey
.

```yaml
Type: String
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
Type: String
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
Type: IUsersIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsDefaultGroup
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaskFolders
.
To construct, see NOTES section for TASKFOLDERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphOutlookTaskFolder[]
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
Type: String
Parameter Sets: CreateExpanded, Create
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOutlookTaskGroup
### Microsoft.Graph.PowerShell.Models.IUsersIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOutlookTaskGroup
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphOutlookTaskGroup\>: outlookTaskGroup
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ChangeKey \<String\>\]: 
  \[GroupKey \<String\>\]: 
  \[IsDefaultGroup \<Boolean?\>\]: 
  \[Name \<String\>\]: 
  \[TaskFolders \<IMicrosoftGraphOutlookTaskFolder\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[ChangeKey \<String\>\]: 
    \[IsDefaultFolder \<Boolean?\>\]: 
    \[MultiValueExtendedProperties \<IMicrosoftGraphMultiValueLegacyExtendedProperty\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Value \<String\[\]\>\]: A collection of property values.
    \[Name \<String\>\]: 
    \[ParentGroupKey \<String\>\]: 
    \[SingleValueExtendedProperties \<IMicrosoftGraphSingleValueLegacyExtendedProperty\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Value \<String\>\]: A property value.
    \[Tasks \<IMicrosoftGraphOutlookTask\[\]\>\]: 
      \[Categories \<String\[\]\>\]: The categories associated with the item
      \[ChangeKey \<String\>\]: Identifies the version of the item.
Every time the item is changed, changeKey changes as well.
This allows Exchange to apply changes to the correct version of the object.
Read-only.
      \[CreatedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      \[LastModifiedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      \[Id \<String\>\]: Read-only.
      \[AssignedTo \<String\>\]: 
      \[Attachments \<IMicrosoftGraphAttachment\[\]\>\]: 
        \[Id \<String\>\]: Read-only.
        \[ContentType \<String\>\]: The MIME type.
        \[IsInline \<Boolean?\>\]: true if the attachment is an inline attachment; otherwise, false.
        \[LastModifiedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        \[Name \<String\>\]: The attachment's file name.
        \[Size \<Int32?\>\]: The length of the attachment in bytes.
      \[Body \<IMicrosoftGraphItemBody\>\]: itemBody
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Content \<String\>\]: The content of the item.
        \[ContentType \<String\>\]: bodyType
      \[CompletedDateTime \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[DateTime \<String\>\]: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
        \[TimeZone \<String\>\]: Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.
      \[DueDateTime \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
      \[HasAttachments \<Boolean?\>\]: 
      \[Importance \<String\>\]: importance
      \[IsReminderOn \<Boolean?\>\]: 
      \[MultiValueExtendedProperties \<IMicrosoftGraphMultiValueLegacyExtendedProperty\[\]\>\]: 
      \[Owner \<String\>\]: 
      \[ParentFolderId \<String\>\]: 
      \[Recurrence \<IMicrosoftGraphPatternedRecurrence\>\]: patternedRecurrence
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Pattern \<IMicrosoftGraphRecurrencePattern\>\]: recurrencePattern
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[DayOfMonth \<Int32?\>\]: The day of the month on which the event occurs.
Required if type is absoluteMonthly or absoluteYearly.
          \[DaysOfWeek \<String\[\]\>\]: A collection of the days of the week on which the event occurs.
The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.
If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern. 
Required if type is weekly, relativeMonthly, or relativeYearly.
          \[FirstDayOfWeek \<String\>\]: dayOfWeek
          \[Index \<String\>\]: weekIndex
          \[Interval \<Int32?\>\]: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type.
Required.
          \[Month \<Int32?\>\]: The month in which the event occurs. 
This is a number from 1 to 12.
          \[Type \<String\>\]: recurrencePatternType
        \[Range \<IMicrosoftGraphRecurrenceRange\>\]: recurrenceRange
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[EndDate \<DateTime?\>\]: The date to stop applying the recurrence pattern.
Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date.
Required if type is endDate.
          \[NumberOfOccurrences \<Int32?\>\]: The number of times to repeat the event.
Required and must be positive if type is numbered.
          \[RecurrenceTimeZone \<String\>\]: Time zone for the startDate and endDate properties.
Optional.
If not specified, the time zone of the event is used.
          \[StartDate \<DateTime?\>\]: The date to start applying the recurrence pattern.
The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event.
Must be the same value as the start property of the recurring event.
Required.
          \[Type \<String\>\]: recurrenceRangeType
      \[ReminderDateTime \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
      \[Sensitivity \<String\>\]: sensitivity
      \[SingleValueExtendedProperties \<IMicrosoftGraphSingleValueLegacyExtendedProperty\[\]\>\]: 
      \[StartDateTime \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
      \[Status \<String\>\]: taskStatus
      \[Subject \<String\>\]: 

INPUTOBJECT \<IUsersIdentity\>: Identity Parameter
  \[AttachmentId \<String\>\]: key: id of attachment
  \[ExtensionId \<String\>\]: key: id of extension
  \[LicenseDetailsId \<String\>\]: key: id of licenseDetails
  \[LinkedResourceId \<String\>\]: key: id of linkedResource
  \[MultiValueLegacyExtendedPropertyId \<String\>\]: key: id of multiValueLegacyExtendedProperty
  \[NotificationId \<String\>\]: key: id of notification
  \[OutlookCategoryId \<String\>\]: key: id of outlookCategory
  \[OutlookTaskFolderId \<String\>\]: key: id of outlookTaskFolder
  \[OutlookTaskGroupId \<String\>\]: key: id of outlookTaskGroup
  \[OutlookTaskId \<String\>\]: key: id of outlookTask
  \[ProfilePhotoId \<String\>\]: key: id of profilePhoto
  \[SingleValueLegacyExtendedPropertyId \<String\>\]: key: id of singleValueLegacyExtendedProperty
  \[TodoTaskId \<String\>\]: key: id of todoTask
  \[TodoTaskListId \<String\>\]: key: id of todoTaskList
  \[UserId \<String\>\]: key: id of user

TASKFOLDERS \<IMicrosoftGraphOutlookTaskFolder\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[ChangeKey \<String\>\]: 
  \[IsDefaultFolder \<Boolean?\>\]: 
  \[MultiValueExtendedProperties \<IMicrosoftGraphMultiValueLegacyExtendedProperty\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Value \<String\[\]\>\]: A collection of property values.
  \[Name \<String\>\]: 
  \[ParentGroupKey \<String\>\]: 
  \[SingleValueExtendedProperties \<IMicrosoftGraphSingleValueLegacyExtendedProperty\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Value \<String\>\]: A property value.
  \[Tasks \<IMicrosoftGraphOutlookTask\[\]\>\]: 
    \[Categories \<String\[\]\>\]: The categories associated with the item
    \[ChangeKey \<String\>\]: Identifies the version of the item.
Every time the item is changed, changeKey changes as well.
This allows Exchange to apply changes to the correct version of the object.
Read-only.
    \[CreatedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    \[LastModifiedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    \[Id \<String\>\]: Read-only.
    \[AssignedTo \<String\>\]: 
    \[Attachments \<IMicrosoftGraphAttachment\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[ContentType \<String\>\]: The MIME type.
      \[IsInline \<Boolean?\>\]: true if the attachment is an inline attachment; otherwise, false.
      \[LastModifiedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      \[Name \<String\>\]: The attachment's file name.
      \[Size \<Int32?\>\]: The length of the attachment in bytes.
    \[Body \<IMicrosoftGraphItemBody\>\]: itemBody
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Content \<String\>\]: The content of the item.
      \[ContentType \<String\>\]: bodyType
    \[CompletedDateTime \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DateTime \<String\>\]: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
      \[TimeZone \<String\>\]: Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.
    \[DueDateTime \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
    \[HasAttachments \<Boolean?\>\]: 
    \[Importance \<String\>\]: importance
    \[IsReminderOn \<Boolean?\>\]: 
    \[MultiValueExtendedProperties \<IMicrosoftGraphMultiValueLegacyExtendedProperty\[\]\>\]: 
    \[Owner \<String\>\]: 
    \[ParentFolderId \<String\>\]: 
    \[Recurrence \<IMicrosoftGraphPatternedRecurrence\>\]: patternedRecurrence
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Pattern \<IMicrosoftGraphRecurrencePattern\>\]: recurrencePattern
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[DayOfMonth \<Int32?\>\]: The day of the month on which the event occurs.
Required if type is absoluteMonthly or absoluteYearly.
        \[DaysOfWeek \<String\[\]\>\]: A collection of the days of the week on which the event occurs.
The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.
If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern. 
Required if type is weekly, relativeMonthly, or relativeYearly.
        \[FirstDayOfWeek \<String\>\]: dayOfWeek
        \[Index \<String\>\]: weekIndex
        \[Interval \<Int32?\>\]: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type.
Required.
        \[Month \<Int32?\>\]: The month in which the event occurs. 
This is a number from 1 to 12.
        \[Type \<String\>\]: recurrencePatternType
      \[Range \<IMicrosoftGraphRecurrenceRange\>\]: recurrenceRange
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[EndDate \<DateTime?\>\]: The date to stop applying the recurrence pattern.
Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date.
Required if type is endDate.
        \[NumberOfOccurrences \<Int32?\>\]: The number of times to repeat the event.
Required and must be positive if type is numbered.
        \[RecurrenceTimeZone \<String\>\]: Time zone for the startDate and endDate properties.
Optional.
If not specified, the time zone of the event is used.
        \[StartDate \<DateTime?\>\]: The date to start applying the recurrence pattern.
The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event.
Must be the same value as the start property of the recurring event.
Required.
        \[Type \<String\>\]: recurrenceRangeType
    \[ReminderDateTime \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
    \[Sensitivity \<String\>\]: sensitivity
    \[SingleValueExtendedProperties \<IMicrosoftGraphSingleValueLegacyExtendedProperty\[\]\>\]: 
    \[StartDateTime \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
    \[Status \<String\>\]: taskStatus
    \[Subject \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/new-mguseroutlooktaskgroup](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/new-mguseroutlooktaskgroup)

## RELATED LINKS
