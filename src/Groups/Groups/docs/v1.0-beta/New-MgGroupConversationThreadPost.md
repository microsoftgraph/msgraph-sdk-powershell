---
external help file:
Module Name: Microsoft.Graph.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/new-mggroupconversationthreadpost
schema: 2.0.0
---

# New-MgGroupConversationThreadPost

## SYNOPSIS
Create new navigation property to posts for groups

## SYNTAX

### CreateExpanded (Default)
```
New-MgGroupConversationThreadPost -ConversationId <String> -ConversationThreadId <String> -GroupId <String>
 [-AdditionalProperties <Hashtable>] [-Attachments <IMicrosoftGraphAttachment[]>]
 [-Body <IMicrosoftGraphItemBody>] [-Categories <String[]>] [-ChangeKey <String>] [-ConversationId1 <String>]
 [-ConversationThreadId1 <String>] [-CreatedDateTime <DateTime>] [-Extensions <IMicrosoftGraphExtension[]>]
 [-From <IMicrosoftGraphRecipient>] [-HasAttachments] [-Id <String>] [-Importance <String>]
 [-InReplyTo <IMicrosoftGraphPost1>] [-LastModifiedDateTime <DateTime>] [-Mentions <IMicrosoftGraphMention[]>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-NewParticipants <IMicrosoftGraphRecipient[]>] [-ReceivedDateTime <DateTime>]
 [-Sender <IMicrosoftGraphRecipient>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgGroupConversationThreadPost -ConversationId <String> -ConversationThreadId <String> -GroupId <String>
 -BodyParameter <IMicrosoftGraphPost1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgGroupConversationThreadPost -InputObject <IGroupsIdentity> -BodyParameter <IMicrosoftGraphPost1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgGroupConversationThreadPost -InputObject <IGroupsIdentity> [-ConversationId <String>]
 [-ConversationThreadId <String>] [-AdditionalProperties <Hashtable>]
 [-Attachments <IMicrosoftGraphAttachment[]>] [-Body <IMicrosoftGraphItemBody>] [-Categories <String[]>]
 [-ChangeKey <String>] [-CreatedDateTime <DateTime>] [-Extensions <IMicrosoftGraphExtension[]>]
 [-From <IMicrosoftGraphRecipient>] [-HasAttachments] [-Id <String>] [-Importance <String>]
 [-InReplyTo <IMicrosoftGraphPost1>] [-LastModifiedDateTime <DateTime>] [-Mentions <IMicrosoftGraphMention[]>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-NewParticipants <IMicrosoftGraphRecipient[]>] [-ReceivedDateTime <DateTime>]
 [-Sender <IMicrosoftGraphRecipient>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to posts for groups

## EXAMPLES

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

### -Attachments
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for ATTACHMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttachment[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
itemBody
To construct, please use Get-Help -Online and see NOTES section for BODY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemBody
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
post
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPost1
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
The categories associated with the item

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChangeKey
Identifies the version of the item.
Every time the item is changed, changeKey changes as well.
This allows Exchange to apply changes to the correct version of the object.
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

### -ConversationId
key: id of conversation

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConversationId1
Unique ID of the conversation.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConversationThreadId
key: id of conversationThread

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConversationThreadId1
Unique ID of the conversation thread.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Extensions
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -From
recipient
To construct, please use Get-Help -Online and see NOTES section for FROM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecipient
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
key: id of group

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

### -HasAttachments
Indicates whether the post has at least one attachment.
This is a default property.

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

### -Id
.

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

### -Importance
importance

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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IGroupsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InReplyTo
post
To construct, please use Get-Help -Online and see NOTES section for INREPLYTO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPost1
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Mentions
.
To construct, please use Get-Help -Online and see NOTES section for MENTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMention[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MultiValueExtendedProperties
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for MULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NewParticipants
Conversation participants that were added to the thread as part of this post.
To construct, please use Get-Help -Online and see NOTES section for NEWPARTICIPANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecipient[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReceivedDateTime
Specifies when the post was received.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sender
recipient
To construct, please use Get-Help -Online and see NOTES section for SENDER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecipient
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SingleValueExtendedProperties
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for SINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IGroupsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPost1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPost1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ATTACHMENTS <IMicrosoftGraphAttachment[]>: The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post. Read-only. Nullable. Supports $expand.
  - `[Id <String>]`: 
  - `[ContentType <String>]`: The MIME type.
  - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Name <String>]`: The display name of the attachment. This does not need to be the actual file name.
  - `[Size <Int32?>]`: The length of the attachment in bytes.

BODY <IMicrosoftGraphItemBody>: itemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: The content of the item.
  - `[ContentType <String>]`: bodyType

BODYPARAMETER <IMicrosoftGraphPost1>: post
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: 
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post. Read-only. Nullable. Supports $expand.
    - `[Id <String>]`: 
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Name <String>]`: The display name of the attachment. This does not need to be the actual file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Body <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[ConversationId <String>]`: Unique ID of the conversation. Read-only.
  - `[ConversationThreadId <String>]`: Unique ID of the conversation thread. Read-only.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the post. Read-only. Nullable. Supports $expand.
    - `[Id <String>]`: 
  - `[From <IMicrosoftGraphRecipient>]`: recipient
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of an entity instance.
      - `[Name <String>]`: The display name of an entity instance.
  - `[HasAttachments <Boolean?>]`: Indicates whether the post has at least one attachment. This is a default property.
  - `[Importance <String>]`: importance
  - `[InReplyTo <IMicrosoftGraphPost1>]`: post
  - `[Mentions <IMicrosoftGraphMention[]>]`: 
    - `[Id <String>]`: 
    - `[Application <String>]`: The name of the application where the mention is created. Optional. Not used and defaulted as null for message.
    - `[ClientReference <String>]`: A unique identifier that represents a parent of the resource instance. Optional. Not used and defaulted as null for message.
    - `[CreatedBy <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[CreatedDateTime <DateTime?>]`: The date and time that the mention is created on the client.
    - `[DeepLink <String>]`: A deep web link to the context of the mention in the resource instance. Optional. Not used and defaulted as null for message.
    - `[MentionText <String>]`: Optional. Not used and defaulted as null for message. To get the mentions in a message, see the bodyPreview property of the message instead.
    - `[Mentioned <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[ServerCreatedDateTime <DateTime?>]`: The date and time that the mention is created on the server. Optional. Not used and defaulted as null for message.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the post. Read-only. Nullable.
    - `[Id <String>]`: 
    - `[Value <String[]>]`: A collection of property values.
  - `[NewParticipants <IMicrosoftGraphRecipient[]>]`: Conversation participants that were added to the thread as part of this post.
  - `[ReceivedDateTime <DateTime?>]`: Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Sender <IMicrosoftGraphRecipient>]`: recipient
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the post. Read-only. Nullable.
    - `[Id <String>]`: 
    - `[Value <String>]`: A property value.

EXTENSIONS <IMicrosoftGraphExtension[]>: The collection of open extensions defined for the post. Read-only. Nullable. Supports $expand.
  - `[Id <String>]`: 

FROM <IMicrosoftGraphRecipient>: recipient
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

INPUTOBJECT <IGroupsIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: id of attachment
  - `[ContentTypeId <String>]`: key: id of contentType
  - `[ConversationId <String>]`: key: id of conversation
  - `[ConversationThreadId <String>]`: key: id of conversationThread
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[DirectorySettingId <String>]`: key: id of directorySetting
  - `[DocumentSetVersionId <String>]`: key: id of documentSetVersion
  - `[DriveId <String>]`: key: id of drive
  - `[DriveItemId <String>]`: key: id of driveItem
  - `[DriveItemVersionId <String>]`: key: id of driveItemVersion
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[EndpointId <String>]`: key: id of endpoint
  - `[EventId <String>]`: key: id of event
  - `[ExtensionId <String>]`: key: id of extension
  - `[GroupId <String>]`: key: id of group
  - `[GroupLifecyclePolicyId <String>]`: key: id of groupLifecyclePolicy
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListId <String>]`: key: id of list
  - `[ListId1 <String>]`: Usage: listId='{listId}'
  - `[ListItemId <String>]`: key: id of listItem
  - `[ListItemVersionId <String>]`: key: id of listItemVersion
  - `[MentionId <String>]`: key: id of mention
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[PermissionId <String>]`: key: id of permission
  - `[PostId <String>]`: key: id of post
  - `[ProfilePhotoId <String>]`: key: id of profilePhoto
  - `[Q <String>]`: Usage: q='{q}'
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[SiteId <String>]`: key: id of site
  - `[SitePageId <String>]`: key: id of sitePage
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[Token <String>]`: Usage: token='{token}'
  - `[User <String>]`: Usage: User='{User}'
  - `[UserId <String>]`: key: id of user

INREPLYTO <IMicrosoftGraphPost1>: post
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: 
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post. Read-only. Nullable. Supports $expand.
    - `[Id <String>]`: 
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Name <String>]`: The display name of the attachment. This does not need to be the actual file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[Body <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[ConversationId <String>]`: Unique ID of the conversation. Read-only.
  - `[ConversationThreadId <String>]`: Unique ID of the conversation thread. Read-only.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the post. Read-only. Nullable. Supports $expand.
    - `[Id <String>]`: 
  - `[From <IMicrosoftGraphRecipient>]`: recipient
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of an entity instance.
      - `[Name <String>]`: The display name of an entity instance.
  - `[HasAttachments <Boolean?>]`: Indicates whether the post has at least one attachment. This is a default property.
  - `[Importance <String>]`: importance
  - `[InReplyTo <IMicrosoftGraphPost1>]`: post
  - `[Mentions <IMicrosoftGraphMention[]>]`: 
    - `[Id <String>]`: 
    - `[Application <String>]`: The name of the application where the mention is created. Optional. Not used and defaulted as null for message.
    - `[ClientReference <String>]`: A unique identifier that represents a parent of the resource instance. Optional. Not used and defaulted as null for message.
    - `[CreatedBy <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[CreatedDateTime <DateTime?>]`: The date and time that the mention is created on the client.
    - `[DeepLink <String>]`: A deep web link to the context of the mention in the resource instance. Optional. Not used and defaulted as null for message.
    - `[MentionText <String>]`: Optional. Not used and defaulted as null for message. To get the mentions in a message, see the bodyPreview property of the message instead.
    - `[Mentioned <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[ServerCreatedDateTime <DateTime?>]`: The date and time that the mention is created on the server. Optional. Not used and defaulted as null for message.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the post. Read-only. Nullable.
    - `[Id <String>]`: 
    - `[Value <String[]>]`: A collection of property values.
  - `[NewParticipants <IMicrosoftGraphRecipient[]>]`: Conversation participants that were added to the thread as part of this post.
  - `[ReceivedDateTime <DateTime?>]`: Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Sender <IMicrosoftGraphRecipient>]`: recipient
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the post. Read-only. Nullable.
    - `[Id <String>]`: 
    - `[Value <String>]`: A property value.

MENTIONS <IMicrosoftGraphMention[]>: .
  - `[Id <String>]`: 
  - `[Application <String>]`: The name of the application where the mention is created. Optional. Not used and defaulted as null for message.
  - `[ClientReference <String>]`: A unique identifier that represents a parent of the resource instance. Optional. Not used and defaulted as null for message.
  - `[CreatedBy <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.
  - `[CreatedDateTime <DateTime?>]`: The date and time that the mention is created on the client.
  - `[DeepLink <String>]`: A deep web link to the context of the mention in the resource instance. Optional. Not used and defaulted as null for message.
  - `[MentionText <String>]`: Optional. Not used and defaulted as null for message. To get the mentions in a message, see the bodyPreview property of the message instead.
  - `[Mentioned <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[ServerCreatedDateTime <DateTime?>]`: The date and time that the mention is created on the server. Optional. Not used and defaulted as null for message.

MULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>: The collection of multi-value extended properties defined for the post. Read-only. Nullable.
  - `[Id <String>]`: 
  - `[Value <String[]>]`: A collection of property values.

NEWPARTICIPANTS <IMicrosoftGraphRecipient[]>: Conversation participants that were added to the thread as part of this post.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

SENDER <IMicrosoftGraphRecipient>: recipient
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

SINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>: The collection of single-value extended properties defined for the post. Read-only. Nullable.
  - `[Id <String>]`: 
  - `[Value <String>]`: A property value.

## RELATED LINKS

