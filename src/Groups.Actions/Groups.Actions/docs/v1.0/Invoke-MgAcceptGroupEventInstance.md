---
external help file:
Module Name: Microsoft.Graph.Groups.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.actions/invoke-mgacceptgroupeventinstance
schema: 2.0.0
---

# Invoke-MgAcceptGroupEventInstance

## SYNOPSIS
Invoke action accept

## SYNTAX

### AcceptExpanded (Default)
```
Invoke-MgAcceptGroupEventInstance -EventId <String> -EventId1 <String> -GroupId <String> [-Comment <String>]
 [-SendResponse] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Accept
```
Invoke-MgAcceptGroupEventInstance -EventId <String> -EventId1 <String> -GroupId <String>
 -BodyParameter <IPaths1Mj8GzzGroupsGroupIdEventsEventIdInstancesEventId1MicrosoftGraphAcceptPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AcceptViaIdentity
```
Invoke-MgAcceptGroupEventInstance -InputObject <IGroupsActionsIdentity>
 -BodyParameter <IPaths1Mj8GzzGroupsGroupIdEventsEventIdInstancesEventId1MicrosoftGraphAcceptPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AcceptViaIdentityExpanded
```
Invoke-MgAcceptGroupEventInstance -InputObject <IGroupsActionsIdentity> [-Comment <String>] [-SendResponse]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action accept

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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Mj8GzzGroupsGroupIdEventsEventIdInstancesEventId1MicrosoftGraphAcceptPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Accept, AcceptViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Comment
.

```yaml
Type: System.String
Parameter Sets: AcceptExpanded, AcceptViaIdentityExpanded
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
Parameter Sets: Accept, AcceptExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventId1
key: event-id of event

```yaml
Type: System.String
Parameter Sets: Accept, AcceptExpanded
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
Parameter Sets: Accept, AcceptExpanded
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
Parameter Sets: AcceptViaIdentity, AcceptViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -SendResponse
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: AcceptExpanded, AcceptViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1Mj8GzzGroupsGroupIdEventsEventIdInstancesEventId1MicrosoftGraphAcceptPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Mj8GzzGroupsGroupIdEventsEventIdInstancesEventId1MicrosoftGraphAcceptPostRequestbodyContentApplicationJsonSchema>: .
  - `[Comment <String>]`: 
  - `[SendResponse <Boolean?>]`: 

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

