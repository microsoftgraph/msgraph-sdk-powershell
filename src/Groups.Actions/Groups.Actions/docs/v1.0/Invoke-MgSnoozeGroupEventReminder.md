---
external help file:
Module Name: Microsoft.Graph.Groups.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.actions/invoke-mgsnoozegroupeventreminder
schema: 2.0.0
---

# Invoke-MgSnoozeGroupEventReminder

## SYNOPSIS
Invoke action snoozeReminder

## SYNTAX

### SnoozeExpanded (Default)
```
Invoke-MgSnoozeGroupEventReminder -EventId <String> -GroupId <String> [-NewReminderTimeDateTime <String>]
 [-NewReminderTimeZone <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Snooze
```
Invoke-MgSnoozeGroupEventReminder -EventId <String> -GroupId <String>
 -BodyParameter <IPaths608Nu3GroupsGroupIdEventsEventIdMicrosoftGraphSnoozereminderPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SnoozeViaIdentity
```
Invoke-MgSnoozeGroupEventReminder -InputObject <IGroupsActionsIdentity>
 -BodyParameter <IPaths608Nu3GroupsGroupIdEventsEventIdMicrosoftGraphSnoozereminderPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SnoozeViaIdentityExpanded
```
Invoke-MgSnoozeGroupEventReminder -InputObject <IGroupsActionsIdentity> [-NewReminderTimeDateTime <String>]
 [-NewReminderTimeZone <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action snoozeReminder

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

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths608Nu3GroupsGroupIdEventsEventIdMicrosoftGraphSnoozereminderPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Snooze, SnoozeViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EventId
key: event-id of event

```yaml
Type: System.String
Parameter Sets: Snooze, SnoozeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
key: group-id of group

```yaml
Type: System.String
Parameter Sets: Snooze, SnoozeExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IGroupsActionsIdentity
Parameter Sets: SnoozeViaIdentity, SnoozeViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NewReminderTimeDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: SnoozeExpanded, SnoozeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewReminderTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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

### Microsoft.Graph.PowerShell.Models.IGroupsActionsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths608Nu3GroupsGroupIdEventsEventIdMicrosoftGraphSnoozereminderPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths608Nu3GroupsGroupIdEventsEventIdMicrosoftGraphSnoozereminderPostRequestbodyContentApplicationJsonSchema>: .
  - `[NewReminderTimeDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[NewReminderTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.

INPUTOBJECT <IGroupsActionsIdentity>: Identity Parameter
  - `[ConversationId <String>]`: key: conversation-id of conversation
  - `[ConversationThreadId <String>]`: key: conversationThread-id of conversationThread
  - `[EventId <String>]`: key: event-id of event
  - `[EventId1 <String>]`: key: event-id of event
  - `[GroupId <String>]`: key: group-id of group
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[PostId <String>]`: key: post-id of post
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup

## RELATED LINKS

