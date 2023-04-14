---
external help file:
Module Name: Microsoft.Graph.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/new-mggroupconversation
schema: 2.0.0
---

# New-MgGroupConversation

## SYNOPSIS
Use reply thread or reply post to further post to that conversation.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgGroupConversation -GroupId <String> [-AdditionalProperties <Hashtable>] [-HasAttachments] [-Id <String>]
 [-LastDeliveredDateTime <DateTime>] [-Preview <String>] [-Threads <IMicrosoftGraphConversationThread[]>]
 [-Topic <String>] [-UniqueSenders <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgGroupConversation -GroupId <String> -BodyParameter <IMicrosoftGraphConversation> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgGroupConversation -InputObject <IGroupsIdentity> -BodyParameter <IMicrosoftGraphConversation> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgGroupConversation -InputObject <IGroupsIdentity> [-AdditionalProperties <Hashtable>] [-HasAttachments]
 [-Id <String>] [-LastDeliveredDateTime <DateTime>] [-Preview <String>]
 [-Threads <IMicrosoftGraphConversationThread[]>] [-Topic <String>] [-UniqueSenders <String[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Use reply thread or reply post to further post to that conversation.

## EXAMPLES

### Example 1: Using the New-MgGroupConversation Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	Topic = "Take your wellness days and rest"
	Threads = @(
		@{
			Posts = @(
				@{
					Body = @{
						ContentType = "html"
						Content = "Contoso cares about you: Rest and Recharge"
					}
					NewParticipants = @(
						@{
							EmailAddress = @{
								Name = "Adele Vance"
								Address = "AdeleV@contoso.onmicrosoft.com"
							}
						}
					)
				}
			)
		}
	)
}
New-MgGroupConversation -GroupId $groupId -BodyParameter $params
```

This example shows how to use the New-MgGroupConversation Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
conversation
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

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
The unique identifier of group

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
Supports $filter (eq, ne) and $search.

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
The unique idenfier for an entity.
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IGroupsIdentity
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
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

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
A short summary from the body of the latest post in this conversation.
Supports $filter (eq, ne, le, ge).

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
To construct, please use Get-Help -Online and see NOTES section for THREADS properties and create a hash table.

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

### Microsoft.Graph.PowerShell.Models.IGroupsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConversation

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConversation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphConversation>: conversation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[HasAttachments <Boolean?>]`: Indicates whether any of the posts within this Conversation has at least one attachment. Supports $filter (eq, ne) and $search.
  - `[LastDeliveredDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Preview <String>]`: A short summary from the body of the latest post in this conversation. Supports $filter (eq, ne, le, ge).
  - `[Threads <IMicrosoftGraphConversationThread[]>]`: A collection of all the conversation threads in the conversation. A navigation property. Read-only. Nullable.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CcRecipients <IMicrosoftGraphRecipient[]>]`: The Cc: recipients for the thread. Returned only on $select.
      - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Address <String>]`: The email address of the person or entity.
        - `[Name <String>]`: The display name of the person or entity.
    - `[HasAttachments <Boolean?>]`: Indicates whether any of the posts within this thread has at least one attachment. Returned by default.
    - `[IsLocked <Boolean?>]`: Indicates if the thread is locked. Returned by default.
    - `[LastDeliveredDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.Returned by default.
    - `[Posts <IMicrosoftGraphPost[]>]`: 
      - `[Categories <String[]>]`: The categories associated with the item
      - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Attachments <IMicrosoftGraphAttachment[]>]`: Read-only. Nullable. Supports $expand.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[ContentType <String>]`: The MIME type.
        - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
        - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Name <String>]`: The attachment's file name.
        - `[Size <Int32?>]`: The length of the attachment in bytes.
      - `[Body <IMicrosoftGraphItemBody>]`: itemBody
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Content <String>]`: The content of the item.
        - `[ContentType <String>]`: bodyType
      - `[ConversationId <String>]`: Unique ID of the conversation. Read-only.
      - `[ConversationThreadId <String>]`: Unique ID of the conversation thread. Read-only.
      - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the post. Read-only. Nullable. Supports $expand.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[From <IMicrosoftGraphRecipient>]`: recipient
      - `[HasAttachments <Boolean?>]`: Indicates whether the post has at least one attachment. This is a default property.
      - `[InReplyTo <IMicrosoftGraphPost>]`: post
      - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the post. Read-only. Nullable.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[Value <String[]>]`: A collection of property values.
      - `[NewParticipants <IMicrosoftGraphRecipient[]>]`: Conversation participants that were added to the thread as part of this post.
      - `[ReceivedDateTime <DateTime?>]`: Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Sender <IMicrosoftGraphRecipient>]`: recipient
      - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the post. Read-only. Nullable.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[Value <String>]`: A property value.
    - `[Preview <String>]`: A short summary from the body of the latest post in this conversation. Returned by default.
    - `[ToRecipients <IMicrosoftGraphRecipient[]>]`: The To: recipients for the thread. Returned only on $select.
    - `[Topic <String>]`: The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated. Returned by default.
    - `[UniqueSenders <String[]>]`: All the users that sent a message to this thread. Returned by default.
  - `[Topic <String>]`: The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.
  - `[UniqueSenders <String[]>]`: All the users that sent a message to this Conversation.

INPUTOBJECT <IGroupsIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: The unique identifier of attachment
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ConversationId <String>]`: The unique identifier of conversation
  - `[ConversationThreadId <String>]`: The unique identifier of conversationThread
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[DirectorySettingId <String>]`: The unique identifier of directorySetting
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[DriveItemId <String>]`: The unique identifier of driveItem
  - `[DriveItemVersionId <String>]`: The unique identifier of driveItemVersion
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[EndpointId <String>]`: The unique identifier of endpoint
  - `[EventId <String>]`: The unique identifier of event
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[GroupId <String>]`: The unique identifier of group
  - `[GroupLifecyclePolicyId <String>]`: The unique identifier of groupLifecyclePolicy
  - `[HorizontalSectionColumnId <String>]`: The unique identifier of horizontalSectionColumn
  - `[HorizontalSectionId <String>]`: The unique identifier of horizontalSection
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListId <String>]`: The unique identifier of list
  - `[ListId1 <String>]`: Usage: listId='{listId}'
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[MentionId <String>]`: The unique identifier of mention
  - `[MultiValueLegacyExtendedPropertyId <String>]`: The unique identifier of multiValueLegacyExtendedProperty
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[PlannerBucketId <String>]`: The unique identifier of plannerBucket
  - `[PlannerPlanId <String>]`: The unique identifier of plannerPlan
  - `[PostId <String>]`: The unique identifier of post
  - `[ProfilePhotoId <String>]`: The unique identifier of profilePhoto
  - `[Q <String>]`: Usage: q='{q}'
  - `[ResourceSpecificPermissionGrantId <String>]`: The unique identifier of resourceSpecificPermissionGrant
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SingleValueLegacyExtendedPropertyId <String>]`: The unique identifier of singleValueLegacyExtendedProperty
  - `[SiteId <String>]`: The unique identifier of site
  - `[SitePageId <String>]`: The unique identifier of sitePage
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[Token <String>]`: Usage: token='{token}'
  - `[User <String>]`: Usage: User='{User}'
  - `[UserId <String>]`: The unique identifier of user
  - `[WebPartId <String>]`: The unique identifier of webPart

THREADS <IMicrosoftGraphConversationThread[]>: A collection of all the conversation threads in the conversation. A navigation property. Read-only. Nullable.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CcRecipients <IMicrosoftGraphRecipient[]>]`: The Cc: recipients for the thread. Returned only on $select.
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
  - `[HasAttachments <Boolean?>]`: Indicates whether any of the posts within this thread has at least one attachment. Returned by default.
  - `[IsLocked <Boolean?>]`: Indicates if the thread is locked. Returned by default.
  - `[LastDeliveredDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.Returned by default.
  - `[Posts <IMicrosoftGraphPost[]>]`: 
    - `[Categories <String[]>]`: The categories associated with the item
    - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Attachments <IMicrosoftGraphAttachment[]>]`: Read-only. Nullable. Supports $expand.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[ContentType <String>]`: The MIME type.
      - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Name <String>]`: The attachment's file name.
      - `[Size <Int32?>]`: The length of the attachment in bytes.
    - `[Body <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[ConversationId <String>]`: Unique ID of the conversation. Read-only.
    - `[ConversationThreadId <String>]`: Unique ID of the conversation thread. Read-only.
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the post. Read-only. Nullable. Supports $expand.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[From <IMicrosoftGraphRecipient>]`: recipient
    - `[HasAttachments <Boolean?>]`: Indicates whether the post has at least one attachment. This is a default property.
    - `[InReplyTo <IMicrosoftGraphPost>]`: post
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the post. Read-only. Nullable.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[NewParticipants <IMicrosoftGraphRecipient[]>]`: Conversation participants that were added to the thread as part of this post.
    - `[ReceivedDateTime <DateTime?>]`: Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Sender <IMicrosoftGraphRecipient>]`: recipient
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the post. Read-only. Nullable.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Value <String>]`: A property value.
  - `[Preview <String>]`: A short summary from the body of the latest post in this conversation. Returned by default.
  - `[ToRecipients <IMicrosoftGraphRecipient[]>]`: The To: recipients for the thread. Returned only on $select.
  - `[Topic <String>]`: The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated. Returned by default.
  - `[UniqueSenders <String[]>]`: All the users that sent a message to this thread. Returned by default.

## RELATED LINKS

