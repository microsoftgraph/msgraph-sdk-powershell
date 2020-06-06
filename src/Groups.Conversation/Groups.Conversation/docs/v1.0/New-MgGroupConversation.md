---
external help file:
Module Name: Microsoft.Graph.Groups.Conversation
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.conversation/new-mggroupconversation
schema: 2.0.0
---

# New-MgGroupConversation

## SYNOPSIS
Create new navigation property to conversations for groups

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgGroupConversation -GroupId <String> [-HasAttachments] [-Id <String>] [-LastDeliveredDateTime <DateTime>]
 [-Preview <String>] [-Threads <IMicrosoftGraphConversationThread[]>] [-Topic <String>]
 [-UniqueSenders <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgGroupConversation -GroupId <String> -BodyParameter <IMicrosoftGraphConversation> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgGroupConversation -InputObject <IGroupsConversationIdentity>
 -BodyParameter <IMicrosoftGraphConversation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgGroupConversation -InputObject <IGroupsConversationIdentity> [-HasAttachments] [-Id <String>]
 [-LastDeliveredDateTime <DateTime>] [-Preview <String>] [-Threads <IMicrosoftGraphConversationThread[]>]
 [-Topic <String>] [-UniqueSenders <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to conversations for groups

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
conversation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConversation
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -HasAttachments
Indicates whether any of the posts within this Conversation has at least one attachment.

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

### -Id
Read-only.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IGroupsConversationIdentity
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastDeliveredDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Preview
A short summary from the body of the latest post in this converstaion.

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

### -Threads
A collection of all the conversation threads in the conversation.
A navigation property.
Read-only.
Nullable.
To construct, see NOTES section for THREADS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConversationThread[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Topic
The topic of the conversation.
This property can be set when the conversation is created, but it cannot be updated.

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

### -UniqueSenders
All the users that sent a message to this Conversation.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IGroupsConversationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConversation

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConversation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphConversation>: conversation
  - `[Id <String>]`: Read-only.
  - `[HasAttachments <Boolean?>]`: Indicates whether any of the posts within this Conversation has at least one attachment.
  - `[LastDeliveredDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Preview <String>]`: A short summary from the body of the latest post in this converstaion.
  - `[Threads <IMicrosoftGraphConversationThread[]>]`: A collection of all the conversation threads in the conversation. A navigation property. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[CcRecipients <IMicrosoftGraphRecipient[]>]`: The Cc: recipients for the thread.
      - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
        - `[Address <String>]`: The email address of the person or entity.
        - `[Name <String>]`: The display name of the person or entity.
    - `[HasAttachments <Boolean?>]`: Indicates whether any of the posts within this thread has at least one attachment.
    - `[IsLocked <Boolean?>]`: Indicates if the thread is locked.
    - `[LastDeliveredDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Posts <IMicrosoftGraphPost[]>]`: Read-only. Nullable.
      - `[Categories <String[]>]`: The categories associated with the item
      - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Id <String>]`: Read-only.
      - `[Attachments <IMicrosoftGraphAttachment[]>]`: Read-only. Nullable.
        - `[Id <String>]`: Read-only.
        - `[ContentType <String>]`: The MIME type.
        - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
        - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        - `[Name <String>]`: The attachment's file name.
        - `[Size <Int32?>]`: The length of the attachment in bytes.
      - `[Body <IMicrosoftGraphItemBody>]`: itemBody
        - `[Content <String>]`: The content of the item.
        - `[ContentType <String>]`: bodyType
      - `[ConversationId <String>]`: Unique ID of the conversation. Read-only.
      - `[ConversationThreadId <String>]`: Unique ID of the conversation thread. Read-only.
      - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the post. Read-only. Nullable.
        - `[Id <String>]`: Read-only.
      - `[From <IMicrosoftGraphRecipient>]`: recipient
      - `[HasAttachments <Boolean?>]`: Indicates whether the post has at least one attachment. This is a default property.
      - `[InReplyTo <IMicrosoftGraphPost>]`: post
      - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the post. Read-only. Nullable.
        - `[Id <String>]`: Read-only.
        - `[Value <String[]>]`: A collection of property values.
      - `[NewParticipants <IMicrosoftGraphRecipient[]>]`: Conversation participants that were added to the thread as part of this post.
      - `[ReceivedDateTime <DateTime?>]`: Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Sender <IMicrosoftGraphRecipient>]`: recipient
      - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the post. Read-only. Nullable.
        - `[Id <String>]`: Read-only.
        - `[Value <String>]`: A property value.
    - `[Preview <String>]`: A short summary from the body of the latest post in this converstaion.
    - `[ToRecipients <IMicrosoftGraphRecipient[]>]`: The To: recipients for the thread.
    - `[Topic <String>]`: The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.
    - `[UniqueSenders <String[]>]`: All the users that sent a message to this thread.
  - `[Topic <String>]`: The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.
  - `[UniqueSenders <String[]>]`: All the users that sent a message to this Conversation.

INPUTOBJECT <IGroupsConversationIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: attachment-id of attachment
  - `[ConversationId <String>]`: key: conversation-id of conversation
  - `[ConversationThreadId <String>]`: key: conversationThread-id of conversationThread
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[GroupId <String>]`: key: group-id of group
  - `[MentionId <String>]`: key: mention-id of mention
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: multiValueLegacyExtendedProperty-id of multiValueLegacyExtendedProperty
  - `[PostId <String>]`: key: post-id of post
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: singleValueLegacyExtendedProperty-id of singleValueLegacyExtendedProperty

THREADS <IMicrosoftGraphConversationThread[]>: A collection of all the conversation threads in the conversation. A navigation property. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[CcRecipients <IMicrosoftGraphRecipient[]>]`: The Cc: recipients for the thread.
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
  - `[HasAttachments <Boolean?>]`: Indicates whether any of the posts within this thread has at least one attachment.
  - `[IsLocked <Boolean?>]`: Indicates if the thread is locked.
  - `[LastDeliveredDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Posts <IMicrosoftGraphPost[]>]`: Read-only. Nullable.
    - `[Categories <String[]>]`: The categories associated with the item
    - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[Attachments <IMicrosoftGraphAttachment[]>]`: Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[ContentType <String>]`: The MIME type.
      - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Name <String>]`: The attachment's file name.
      - `[Size <Int32?>]`: The length of the attachment in bytes.
    - `[Body <IMicrosoftGraphItemBody>]`: itemBody
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[ConversationId <String>]`: Unique ID of the conversation. Read-only.
    - `[ConversationThreadId <String>]`: Unique ID of the conversation thread. Read-only.
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the post. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
    - `[From <IMicrosoftGraphRecipient>]`: recipient
    - `[HasAttachments <Boolean?>]`: Indicates whether the post has at least one attachment. This is a default property.
    - `[InReplyTo <IMicrosoftGraphPost>]`: post
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the post. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[NewParticipants <IMicrosoftGraphRecipient[]>]`: Conversation participants that were added to the thread as part of this post.
    - `[ReceivedDateTime <DateTime?>]`: Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Sender <IMicrosoftGraphRecipient>]`: recipient
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the post. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String>]`: A property value.
  - `[Preview <String>]`: A short summary from the body of the latest post in this converstaion.
  - `[ToRecipients <IMicrosoftGraphRecipient[]>]`: The To: recipients for the thread.
  - `[Topic <String>]`: The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.
  - `[UniqueSenders <String[]>]`: All the users that sent a message to this thread.

## RELATED LINKS

