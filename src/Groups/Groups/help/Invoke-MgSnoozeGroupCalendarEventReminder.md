---
external help file: Microsoft.Graph.Groups-help.xml
Module Name: Microsoft.Graph.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/invoke-mgsnoozegroupcalendareventreminder
schema: 2.0.0
---

# Invoke-MgSnoozeGroupCalendarEventReminder

## SYNOPSIS
Invoke action snoozeReminder

## SYNTAX

### SnoozeExpanded (Default)
```
Invoke-MgSnoozeGroupCalendarEventReminder -EventId <String> -GroupId <String>
 [-AdditionalProperties <Hashtable>] [-NewReminderTime <IMicrosoftGraphDateTimeZone>] [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Snooze
```
Invoke-MgSnoozeGroupCalendarEventReminder -EventId <String> -GroupId <String>
 -BodyParameter <IPathsLo9YtuGroupsGroupIdCalendarEventsEventIdMicrosoftGraphSnoozereminderPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SnoozeViaIdentityExpanded
```
Invoke-MgSnoozeGroupCalendarEventReminder -InputObject <IGroupsIdentity> [-AdditionalProperties <Hashtable>]
 [-NewReminderTime <IMicrosoftGraphDateTimeZone>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SnoozeViaIdentity
```
Invoke-MgSnoozeGroupCalendarEventReminder -InputObject <IGroupsIdentity>
 -BodyParameter <IPathsLo9YtuGroupsGroupIdCalendarEventsEventIdMicrosoftGraphSnoozereminderPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action snoozeReminder

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
Parameter Sets: SnoozeExpanded, SnoozeViaIdentityExpanded
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
Type: IPathsLo9YtuGroupsGroupIdCalendarEventsEventIdMicrosoftGraphSnoozereminderPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Snooze, SnoozeViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EventId
key: id of event

```yaml
Type: String
Parameter Sets: SnoozeExpanded, Snooze
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
key: id of group

```yaml
Type: String
Parameter Sets: SnoozeExpanded, Snooze
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IGroupsIdentity
Parameter Sets: SnoozeViaIdentityExpanded, SnoozeViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NewReminderTime
dateTimeTimeZone
To construct, see NOTES section for NEWREMINDERTIME properties and create a hash table.

```yaml
Type: IMicrosoftGraphDateTimeZone
Parameter Sets: SnoozeExpanded, SnoozeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
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

### Microsoft.Graph.PowerShell.Models.IGroupsIdentity
### Microsoft.Graph.PowerShell.Models.IPathsLo9YtuGroupsGroupIdCalendarEventsEventIdMicrosoftGraphSnoozereminderPostRequestbodyContentApplicationJsonSchema
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IPathsLo9YtuGroupsGroupIdCalendarEventsEventIdMicrosoftGraphSnoozereminderPostRequestbodyContentApplicationJsonSchema\>: .
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[NewReminderTime \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DateTime \<String\>\]: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    \[TimeZone \<String\>\]: Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

INPUTOBJECT \<IGroupsIdentity\>: Identity Parameter
  \[AttachmentId \<String\>\]: key: id of attachment
  \[ConversationId \<String\>\]: key: id of conversation
  \[ConversationThreadId \<String\>\]: key: id of conversationThread
  \[DirectoryObjectId \<String\>\]: key: id of directoryObject
  \[DirectorySettingId \<String\>\]: key: id of directorySetting
  \[EndpointId \<String\>\]: key: id of endpoint
  \[EventId \<String\>\]: key: id of event
  \[ExtensionId \<String\>\]: key: id of extension
  \[GroupId \<String\>\]: key: id of group
  \[GroupLifecyclePolicyId \<String\>\]: key: id of groupLifecyclePolicy
  \[IncludePersonalNotebooks \<Boolean?\>\]: 
  \[MentionId \<String\>\]: key: id of mention
  \[MultiValueLegacyExtendedPropertyId \<String\>\]: key: id of multiValueLegacyExtendedProperty
  \[NotebookId \<String\>\]: key: id of notebook
  \[OnenotePageId \<String\>\]: key: id of onenotePage
  \[OnenoteSectionId \<String\>\]: key: id of onenoteSection
  \[PostId \<String\>\]: key: id of post
  \[ProfilePhotoId \<String\>\]: key: id of profilePhoto
  \[ResourceSpecificPermissionGrantId \<String\>\]: key: id of resourceSpecificPermissionGrant
  \[SingleValueLegacyExtendedPropertyId \<String\>\]: key: id of singleValueLegacyExtendedProperty
  \[User \<String\>\]: 
  \[UserId \<String\>\]: key: id of user

NEWREMINDERTIME \<IMicrosoftGraphDateTimeZone\>: dateTimeTimeZone
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DateTime \<String\>\]: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  \[TimeZone \<String\>\]: Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/invoke-mgsnoozegroupcalendareventreminder](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/invoke-mgsnoozegroupcalendareventreminder)

