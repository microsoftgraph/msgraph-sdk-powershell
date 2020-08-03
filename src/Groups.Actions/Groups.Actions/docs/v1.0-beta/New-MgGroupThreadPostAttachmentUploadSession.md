---
external help file:
Module Name: Microsoft.Graph.Groups.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.actions/new-mggroupthreadpostattachmentuploadsession
schema: 2.0.0
---

# New-MgGroupThreadPostAttachmentUploadSession

## SYNOPSIS
Invoke action createUploadSession

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgGroupThreadPostAttachmentUploadSession -ConversationThreadId <String> -GroupId <String> -PostId <String>
 [-AttachmentItemAttachmentType <String>] [-AttachmentItemContentType <String>] [-AttachmentItemIsInline]
 [-AttachmentItemName <String>] [-AttachmentItemSize <Int64>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgGroupThreadPostAttachmentUploadSession -ConversationThreadId <String> -GroupId <String> -PostId <String>
 -BodyParameter <IPaths81LtxxGroupsGroupIdThreadsConversationthreadIdPostsPostIdAttachmentsMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgGroupThreadPostAttachmentUploadSession -InputObject <IGroupsActionsIdentity>
 -BodyParameter <IPaths81LtxxGroupsGroupIdThreadsConversationthreadIdPostsPostIdAttachmentsMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgGroupThreadPostAttachmentUploadSession -InputObject <IGroupsActionsIdentity>
 [-AttachmentItemAttachmentType <String>] [-AttachmentItemContentType <String>] [-AttachmentItemIsInline]
 [-AttachmentItemName <String>] [-AttachmentItemSize <Int64>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action createUploadSession

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

### -AttachmentItemAttachmentType
attachmentType

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttachmentItemContentType
The nature of the data in the attachment.
Optional.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttachmentItemIsInline
true if the attachment is an inline attachment; otherwise, false.
Optional.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttachmentItemName
The display name of the attachment.
This can be a descriptive string and does not have to be the actual file name.
Required.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttachmentItemSize
The length of the attachment in bytes.
Required.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPaths81LtxxGroupsGroupIdThreadsConversationthreadIdPostsPostIdAttachmentsMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConversationThreadId
key: conversationThread-id of conversationThread

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
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
Parameter Sets: Create1, CreateExpanded1
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
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PostId
key: post-id of post

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IGroupsActionsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths81LtxxGroupsGroupIdThreadsConversationthreadIdPostsPostIdAttachmentsMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUploadSession

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths81LtxxGroupsGroupIdThreadsConversationthreadIdPostsPostIdAttachmentsMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>: .
  - `[AttachmentItemAttachmentType <String>]`: attachmentType
  - `[AttachmentItemContentType <String>]`: The nature of the data in the attachment. Optional.
  - `[AttachmentItemIsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false. Optional.
  - `[AttachmentItemName <String>]`: The display name of the attachment. This can be a descriptive string and does not have to be the actual file name. Required.
  - `[AttachmentItemSize <Int64?>]`: The length of the attachment in bytes. Required.

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

