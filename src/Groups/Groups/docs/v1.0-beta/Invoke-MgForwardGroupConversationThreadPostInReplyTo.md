---
external help file: Microsoft.Graph.Groups-help.xml
Module Name: Microsoft.Graph.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/invoke-mgforwardgroupconversationthreadpostinreplyto
schema: 2.0.0
---

# Invoke-MgForwardGroupConversationThreadPostInReplyTo

## SYNOPSIS
Invoke action forward

## SYNTAX

### ForwardExpanded1 (Default)
```
Invoke-MgForwardGroupConversationThreadPostInReplyTo -ConversationId <String> -ConversationThreadId <String>
 -GroupId <String> -PostId <String> [-AdditionalProperties <Hashtable>] [-Comment <String>]
 [-ToRecipients <IMicrosoftGraphRecipient[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Forward1
```
Invoke-MgForwardGroupConversationThreadPostInReplyTo -ConversationId <String> -ConversationThreadId <String>
 -GroupId <String> -PostId <String>
 -BodyParameter <IPaths1TkyrqsGroupsGroupIdConversationsConversationIdThreadsConversationthreadIdPostsPostIdInreplytoMicrosoftGraphForwardPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ForwardViaIdentityExpanded1
```
Invoke-MgForwardGroupConversationThreadPostInReplyTo -InputObject <IGroupsIdentity>
 [-AdditionalProperties <Hashtable>] [-Comment <String>] [-ToRecipients <IMicrosoftGraphRecipient[]>]
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ForwardViaIdentity1
```
Invoke-MgForwardGroupConversationThreadPostInReplyTo -InputObject <IGroupsIdentity>
 -BodyParameter <IPaths1TkyrqsGroupsGroupIdConversationsConversationIdThreadsConversationthreadIdPostsPostIdInreplytoMicrosoftGraphForwardPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action forward

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: ForwardExpanded1, ForwardViaIdentityExpanded1
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
Type: IPaths1TkyrqsGroupsGroupIdConversationsConversationIdThreadsConversationthreadIdPostsPostIdInreplytoMicrosoftGraphForwardPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Forward1, ForwardViaIdentity1
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
Type: String
Parameter Sets: ForwardExpanded1, ForwardViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConversationId
key: id of conversation

```yaml
Type: String
Parameter Sets: ForwardExpanded1, Forward1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConversationThreadId
key: id of conversationThread

```yaml
Type: String
Parameter Sets: ForwardExpanded1, Forward1
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
Parameter Sets: ForwardExpanded1, Forward1
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
Parameter Sets: ForwardViaIdentityExpanded1, ForwardViaIdentity1
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PostId
key: id of post

```yaml
Type: String
Parameter Sets: ForwardExpanded1, Forward1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToRecipients
.
To construct, see NOTES section for TORECIPIENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphRecipient[]
Parameter Sets: ForwardExpanded1, ForwardViaIdentityExpanded1
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
### Microsoft.Graph.PowerShell.Models.IPaths1TkyrqsGroupsGroupIdConversationsConversationIdThreadsConversationthreadIdPostsPostIdInreplytoMicrosoftGraphForwardPostRequestbodyContentApplicationJsonSchema
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1TkyrqsGroupsGroupIdConversationsConversationIdThreadsConversationthreadIdPostsPostIdInreplytoMicrosoftGraphForwardPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Comment <String>]`: 
  - `[ToRecipients <IMicrosoftGraphRecipient[]>]`: 
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of an entity instance.
      - `[Name <String>]`: The display name of an entity instance.

INPUTOBJECT <IGroupsIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: id of attachment
  - `[ConversationId <String>]`: key: id of conversation
  - `[ConversationThreadId <String>]`: key: id of conversationThread
  - `[DirectorySettingId <String>]`: key: id of directorySetting
  - `[EndpointId <String>]`: key: id of endpoint
  - `[EventId <String>]`: key: id of event
  - `[ExtensionId <String>]`: key: id of extension
  - `[GroupId <String>]`: key: id of group
  - `[GroupLifecyclePolicyId <String>]`: key: id of groupLifecyclePolicy
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[MentionId <String>]`: key: id of mention
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[PostId <String>]`: key: id of post
  - `[ProfilePhotoId <String>]`: key: id of profilePhoto
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[User <String>]`: Usage: User={User}
  - `[UserId <String>]`: key: id of user

TORECIPIENTS <IMicrosoftGraphRecipient[]>: .
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

## RELATED LINKS
