---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mguserteamworkinstalledapp
schema: 2.0.0
---

# New-MgUserTeamworkInstalledApp

## SYNOPSIS
Create new navigation property to installedApps for users

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgUserTeamworkInstalledApp -UserId <String> [-AdditionalProperties <Hashtable>]
 [-Chat <IMicrosoftGraphChat>] [-Id <String>] [-TeamsApp <IMicrosoftGraphTeamsApp>]
 [-TeamsAppDefinition <IMicrosoftGraphTeamsAppDefinition1>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgUserTeamworkInstalledApp -UserId <String> -BodyParameter <IMicrosoftGraphUserScopeTeamsAppInstallation1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgUserTeamworkInstalledApp -InputObject <ITeamsIdentity>
 -BodyParameter <IMicrosoftGraphUserScopeTeamsAppInstallation1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgUserTeamworkInstalledApp -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-Chat <IMicrosoftGraphChat>] [-Id <String>] [-TeamsApp <IMicrosoftGraphTeamsApp>]
 [-TeamsAppDefinition <IMicrosoftGraphTeamsAppDefinition1>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to installedApps for users

## EXAMPLES

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
userScopeTeamsAppInstallation
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserScopeTeamsAppInstallation1
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Chat
chat
To construct, please use Get-Help -Online and see NOTES section for CHAT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChat
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.ITeamsIdentity
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -TeamsApp
teamsApp
To construct, please use Get-Help -Online and see NOTES section for TEAMSAPP properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsApp
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsAppDefinition
teamsAppDefinition
To construct, please use Get-Help -Online and see NOTES section for TEAMSAPPDEFINITION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppDefinition1
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserScopeTeamsAppInstallation1

### Microsoft.Graph.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserScopeTeamsAppInstallation1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserScopeTeamsAppInstallation1>: userScopeTeamsAppInstallation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[TeamsApp <IMicrosoftGraphTeamsApp>]`: teamsApp
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[AppDefinitions <IMicrosoftGraphTeamsAppDefinition1[]>]`: The details for each version of the app.
      - `[Id <String>]`: 
      - `[AllowedInstallationScopes <String>]`: teamsAppInstallationScopes
      - `[AzureAdAppId <String>]`: The WebApplicationInfo.Id from the Teams app manifest.
      - `[Bot <IMicrosoftGraphTeamworkBot>]`: teamworkBot
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
      - `[ColorIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[HostedContent <IMicrosoftGraphTeamworkHostedContent>]`: teamworkHostedContent
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
          - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
          - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
        - `[WebUrl <String>]`: The web URL that can be used for downloading the image.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[Description <String>]`: Verbose description of the application.
      - `[DisplayName <String>]`: The name of the app provided by the app developer.
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[OutlineIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
      - `[PublishingState <String>]`: teamsAppPublishingState
      - `[Shortdescription <String>]`: 
      - `[TeamsAppId <String>]`: The ID from the Teams app manifest.
      - `[Version <String>]`: The version number of the application.
    - `[DisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
    - `[DistributionMethod <String>]`: teamsAppDistributionMethod
    - `[ExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
  - `[TeamsAppDefinition <IMicrosoftGraphTeamsAppDefinition1>]`: teamsAppDefinition
  - `[Id <String>]`: 
  - `[Chat <IMicrosoftGraphChat>]`: chat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ChatType <String>]`: chatType
    - `[CreatedDateTime <DateTime?>]`: Date and time at which the chat was created. Read-only.
    - `[InstalledApps <IMicrosoftGraphTeamsAppInstallation1[]>]`: A collection of all the apps in the chat. Nullable.
      - `[Id <String>]`: 
      - `[TeamsApp <IMicrosoftGraphTeamsApp>]`: teamsApp
      - `[TeamsAppDefinition <IMicrosoftGraphTeamsAppDefinition1>]`: teamsAppDefinition
    - `[LastMessagePreview <IMicrosoftGraphChatMessageInfo>]`: chatMessageInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Body <IMicrosoftGraphItemBody>]`: itemBody
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Content <String>]`: The content of the item.
        - `[ContentType <String>]`: bodyType
      - `[CreatedDateTime <DateTime?>]`: Date time object representing the time at which message was created.
      - `[EventDetail <IMicrosoftGraphEventMessageDetail>]`: eventMessageDetail
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[From <IMicrosoftGraphChatMessageFromIdentitySet>]`: chatMessageFromIdentitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[IsDeleted <Boolean?>]`: If set to true, the original message has been deleted.
      - `[MessageType <String>]`: chatMessageType
    - `[LastUpdatedDateTime <DateTime?>]`: Date and time at which the chat was renamed or list of members were last changed. Read-only.
    - `[Members <IMicrosoftGraphConversationMember[]>]`: A collection of all the members in the chat. Nullable.
      - `[Id <String>]`: 
      - `[DisplayName <String>]`: The display name of the user.
      - `[Roles <String[]>]`: The roles for that user. This property only contains additional qualifiers when relevant - for example, if the member has owner privileges, the roles property contains owner as one of the values. Similarly, if the member is a guest, the roles property contains guest as one of the values. A basic member should not have any values specified in the roles property.
      - `[VisibleHistoryStartDateTime <DateTime?>]`: The timestamp denoting how far back a conversation's history is shared with the conversation member. This property is settable only for members of a chat.
    - `[Messages <IMicrosoftGraphChatMessage[]>]`: A collection of all the messages in the chat. Nullable.
      - `[Id <String>]`: 
      - `[Attachments <IMicrosoftGraphChatMessageAttachment1[]>]`: References to attached objects like files, tabs, meetings etc.
        - `[Content <String>]`: The content of the attachment. If the attachment is a rich card, set the property to the rich card object. This property and contentUrl are mutually exclusive.
        - `[ContentType <String>]`: The media type of the content attachment. It can have the following values: reference: Attachment is a link to another file. Populate the contentURL with the link to the object.Any contentTypes supported by the Bot Framework's Attachment objectapplication/vnd.microsoft.card.codesnippet: A code snippet. application/vnd.microsoft.card.announcement: An announcement header.
        - `[ContentUrl <String>]`: URL for the content of the attachment. Supported protocols: http, https, file and data.
        - `[Id <String>]`: Read-only. Unique id of the attachment.
        - `[Name <String>]`: Name of the attachment.
        - `[TeamsAppId <String>]`: The ID of the Teams app that is associated with the attachment. The property is specifically used to attribute a Teams message card to the specified app.
        - `[ThumbnailUrl <String>]`: URL to a thumbnail image that the channel can use if it supports using an alternative, smaller form of content or contentUrl. For example, if you set contentType to application/word and set contentUrl to the location of the Word document, you might include a thumbnail image that represents the document. The channel could display the thumbnail image instead of the document. When the user clicks the image, the channel would open the document.
      - `[Body <IMicrosoftGraphItemBody>]`: itemBody
      - `[ChannelIdentity <IMicrosoftGraphChannelIdentity>]`: channelIdentity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ChannelId <String>]`: The identity of the channel in which the message was posted.
        - `[TeamId <String>]`: The identity of the team in which the message was posted.
      - `[ChatId <String>]`: If the message was sent in a chat, represents the identity of the chat.
      - `[CreatedDateTime <DateTime?>]`: Timestamp of when the chat message was created.
      - `[DeletedDateTime <DateTime?>]`: Read only. Timestamp at which the chat message was deleted, or null if not deleted.
      - `[Etag <String>]`: Read-only. Version number of the chat message.
      - `[EventDetail <IMicrosoftGraphEventMessageDetail>]`: eventMessageDetail
      - `[From <IMicrosoftGraphChatMessageFromIdentitySet>]`: chatMessageFromIdentitySet
      - `[HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]`: Content in a message hosted by Microsoft Teams - for example, images or code snippets.
        - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
        - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
        - `[Id <String>]`: 
      - `[Importance <String>]`: 
      - `[LastEditedDateTime <DateTime?>]`: Read only. Timestamp when edits to the chat message were made. Triggers an 'Edited' flag in the Teams UI. If no edits are made the value is null.
      - `[LastModifiedDateTime <DateTime?>]`: Read only. Timestamp when the chat message is created (initial setting) or modified, including when a reaction is added or removed.
      - `[Locale <String>]`: Locale of the chat message set by the client. Always set to en-us.
      - `[Mentions <IMicrosoftGraphChatMessageMention1[]>]`: List of entities mentioned in the chat message. Supported entities are: user, bot, team, channel, and tag.
        - `[Id <Int32?>]`: Index of an entity being mentioned in the specified chatMessage. Matches the {index} value in the corresponding <at id='{index}'> tag in the message body.
        - `[MentionText <String>]`: String used to represent the mention. For example, a user's display name, a team name.
        - `[Mentioned <IMicrosoftGraphChatMessageMentionedIdentitySet1>]`: chatMessageMentionedIdentitySet
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[Device <IMicrosoftGraphIdentity>]`: identity
          - `[User <IMicrosoftGraphIdentity>]`: identity
          - `[Conversation <IMicrosoftGraphTeamworkConversationIdentity>]`: teamworkConversationIdentity
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
            - `[Id <String>]`: Unique identifier for the identity.
            - `[ConversationIdentityType <String>]`: teamworkConversationIdentityType
          - `[Tag <IMicrosoftGraphTeamworkTagIdentity>]`: teamworkTagIdentity
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
            - `[Id <String>]`: Unique identifier for the identity.
      - `[MessageType <String>]`: chatMessageType
      - `[OnBehalfOf <IMicrosoftGraphChatMessageFromIdentitySet>]`: chatMessageFromIdentitySet
      - `[PolicyViolation <IMicrosoftGraphChatMessagePolicyViolation>]`: chatMessagePolicyViolation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DlpAction <String>]`: chatMessagePolicyViolationDlpActionTypes
        - `[JustificationText <String>]`: Justification text provided by the sender of the message when overriding a policy violation.
        - `[PolicyTip <IMicrosoftGraphChatMessagePolicyViolationPolicyTip>]`: chatMessagePolicyViolationPolicyTip
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ComplianceUrl <String>]`: The URL a user can visit to read about the data loss prevention policies for the organization. (ie, policies about what users shouldn't say in chats)
          - `[GeneralText <String>]`: Explanatory text shown to the sender of the message.
          - `[MatchedConditionDescriptions <String[]>]`: The list of improper data in the message that was detected by the data loss prevention app. Each DLP app defines its own conditions, examples include 'Credit Card Number' and 'Social Security Number'.
        - `[UserAction <String>]`: chatMessagePolicyViolationUserActionTypes
        - `[VerdictDetails <String>]`: chatMessagePolicyViolationVerdictDetailsTypes
      - `[Reactions <IMicrosoftGraphChatMessageReaction[]>]`: Reactions for this chat message (for example, Like).
        - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[ReactionType <String>]`: Supported values are like, angry, sad, laugh, heart, surprised.
        - `[User <IMicrosoftGraphChatMessageReactionIdentitySet>]`: chatMessageReactionIdentitySet
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[Device <IMicrosoftGraphIdentity>]`: identity
          - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[Replies <IMicrosoftGraphChatMessage[]>]`: Replies for a specified message. Supports $expand for channel messages.
      - `[ReplyToId <String>]`: Read-only. ID of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels, not chats.)
      - `[Subject <String>]`: The subject of the chat message, in plaintext.
      - `[Summary <String>]`: Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.
      - `[WebUrl <String>]`: Read-only. Link to the message in Microsoft Teams.
    - `[OnlineMeetingInfo <IMicrosoftGraphTeamworkOnlineMeetingInfo>]`: teamworkOnlineMeetingInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CalendarEventId <String>]`: The identifier of the calendar event associated with the meeting.
      - `[JoinWebUrl <String>]`: The URL which can be clicked on to join or uniquely identify the meeting.
      - `[Organizer <IMicrosoftGraphTeamworkUserIdentity>]`: teamworkUserIdentity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
        - `[UserIdentityType <String>]`: teamworkUserIdentityType
    - `[Operations <IMicrosoftGraphTeamsAsyncOperation1[]>]`: A collection of all the Teams async operations that ran or are running on the chat. Nullable.
      - `[Id <String>]`: 
      - `[AttemptsCount <Int32?>]`: Number of times the operation was attempted before being marked successful or failed.
      - `[CreatedDateTime <DateTime?>]`: Time when the operation was created.
      - `[Error <IMicrosoftGraphOperationError>]`: operationError
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: Operation error code.
        - `[Message <String>]`: Operation error message.
      - `[LastActionDateTime <DateTime?>]`: Time when the async operation was last updated.
      - `[OperationType <String>]`: 
      - `[Status <String>]`: teamsAsyncOperationStatus
      - `[TargetResourceId <String>]`: The ID of the object that's created or modified as result of this async operation, typically a team.
      - `[TargetResourceLocation <String>]`: The location of the object that's created or modified as result of this async operation. This URL should be treated as an opaque value and not parsed into its component paths.
    - `[PermissionGrants <IMicrosoftGraphResourceSpecificPermissionGrant[]>]`: A collection of permissions granted to apps for the chat.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[Id <String>]`: 
      - `[ClientAppId <String>]`: ID of the service principal of the Azure AD app that has been granted access. Read-only.
      - `[ClientId <String>]`: ID of the Azure AD app that has been granted access. Read-only.
      - `[Permission <String>]`: The name of the resource-specific permission. Read-only.
      - `[PermissionType <String>]`: The type of permission. Possible values are: Application, Delegated. Read-only.
      - `[ResourceAppId <String>]`: ID of the Azure AD app that is hosting the resource. Read-only.
    - `[PinnedMessages <IMicrosoftGraphPinnedChatMessageInfo[]>]`: A collection of all the pinned messages in the chat. Nullable.
      - `[Id <String>]`: 
      - `[Message <IMicrosoftGraphChatMessage>]`: chatMessage
    - `[Tabs <IMicrosoftGraphTeamsTab1[]>]`: A collection of all the tabs in the chat. Nullable.
      - `[Id <String>]`: 
      - `[Configuration <IMicrosoftGraphTeamsTabConfiguration>]`: teamsTabConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ContentUrl <String>]`: Url used for rendering tab contents in Teams. Required.
        - `[EntityId <String>]`: Identifier for the entity hosted by the tab provider.
        - `[RemoveUrl <String>]`: Url called by Teams client when a Tab is removed using the Teams Client.
        - `[WebsiteUrl <String>]`: Url for showing tab contents outside of Teams.
      - `[DisplayName <String>]`: Name of the tab.
      - `[MessageId <String>]`: 
      - `[SortOrderIndex <String>]`: Index of the order used for sorting tabs.
      - `[TeamsApp <IMicrosoftGraphTeamsApp>]`: teamsApp
      - `[TeamsAppId <String>]`: 
      - `[WebUrl <String>]`: Deep link URL of the tab instance. Read only.
    - `[TenantId <String>]`: The identifier of the tenant in which the chat was created. Read-only.
    - `[Topic <String>]`: (Optional) Subject or topic for the chat. Only available for group chats.
    - `[Viewpoint <IMicrosoftGraphChatViewpoint>]`: chatViewpoint
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsHidden <Boolean?>]`: Indicates whether the chat is hidden for the current user.
      - `[LastMessageReadDateTime <DateTime?>]`: Represents the dateTime up until which the current user has read chatMessages in a specific chat.
    - `[WebUrl <String>]`: The URL for the chat in Microsoft Teams. The URL should be treated as an opaque blob, and not parsed. Read-only.

CHAT <IMicrosoftGraphChat>: chat
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ChatType <String>]`: chatType
  - `[CreatedDateTime <DateTime?>]`: Date and time at which the chat was created. Read-only.
  - `[InstalledApps <IMicrosoftGraphTeamsAppInstallation1[]>]`: A collection of all the apps in the chat. Nullable.
    - `[Id <String>]`: 
    - `[TeamsApp <IMicrosoftGraphTeamsApp>]`: teamsApp
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[AppDefinitions <IMicrosoftGraphTeamsAppDefinition1[]>]`: The details for each version of the app.
        - `[Id <String>]`: 
        - `[AllowedInstallationScopes <String>]`: teamsAppInstallationScopes
        - `[AzureAdAppId <String>]`: The WebApplicationInfo.Id from the Teams app manifest.
        - `[Bot <IMicrosoftGraphTeamworkBot>]`: teamworkBot
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
        - `[ColorIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
          - `[HostedContent <IMicrosoftGraphTeamworkHostedContent>]`: teamworkHostedContent
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: 
            - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
            - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
          - `[WebUrl <String>]`: The web URL that can be used for downloading the image.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Application <IMicrosoftGraphIdentity>]`: identity
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
            - `[Id <String>]`: Unique identifier for the identity.
          - `[Device <IMicrosoftGraphIdentity>]`: identity
          - `[User <IMicrosoftGraphIdentity>]`: identity
        - `[Description <String>]`: Verbose description of the application.
        - `[DisplayName <String>]`: The name of the app provided by the app developer.
        - `[LastModifiedDateTime <DateTime?>]`: 
        - `[OutlineIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
        - `[PublishingState <String>]`: teamsAppPublishingState
        - `[Shortdescription <String>]`: 
        - `[TeamsAppId <String>]`: The ID from the Teams app manifest.
        - `[Version <String>]`: The version number of the application.
      - `[DisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
      - `[DistributionMethod <String>]`: teamsAppDistributionMethod
      - `[ExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
    - `[TeamsAppDefinition <IMicrosoftGraphTeamsAppDefinition1>]`: teamsAppDefinition
  - `[LastMessagePreview <IMicrosoftGraphChatMessageInfo>]`: chatMessageInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Body <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[CreatedDateTime <DateTime?>]`: Date time object representing the time at which message was created.
    - `[EventDetail <IMicrosoftGraphEventMessageDetail>]`: eventMessageDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[From <IMicrosoftGraphChatMessageFromIdentitySet>]`: chatMessageFromIdentitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[IsDeleted <Boolean?>]`: If set to true, the original message has been deleted.
    - `[MessageType <String>]`: chatMessageType
  - `[LastUpdatedDateTime <DateTime?>]`: Date and time at which the chat was renamed or list of members were last changed. Read-only.
  - `[Members <IMicrosoftGraphConversationMember[]>]`: A collection of all the members in the chat. Nullable.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The display name of the user.
    - `[Roles <String[]>]`: The roles for that user. This property only contains additional qualifiers when relevant - for example, if the member has owner privileges, the roles property contains owner as one of the values. Similarly, if the member is a guest, the roles property contains guest as one of the values. A basic member should not have any values specified in the roles property.
    - `[VisibleHistoryStartDateTime <DateTime?>]`: The timestamp denoting how far back a conversation's history is shared with the conversation member. This property is settable only for members of a chat.
  - `[Messages <IMicrosoftGraphChatMessage[]>]`: A collection of all the messages in the chat. Nullable.
    - `[Id <String>]`: 
    - `[Attachments <IMicrosoftGraphChatMessageAttachment1[]>]`: References to attached objects like files, tabs, meetings etc.
      - `[Content <String>]`: The content of the attachment. If the attachment is a rich card, set the property to the rich card object. This property and contentUrl are mutually exclusive.
      - `[ContentType <String>]`: The media type of the content attachment. It can have the following values: reference: Attachment is a link to another file. Populate the contentURL with the link to the object.Any contentTypes supported by the Bot Framework's Attachment objectapplication/vnd.microsoft.card.codesnippet: A code snippet. application/vnd.microsoft.card.announcement: An announcement header.
      - `[ContentUrl <String>]`: URL for the content of the attachment. Supported protocols: http, https, file and data.
      - `[Id <String>]`: Read-only. Unique id of the attachment.
      - `[Name <String>]`: Name of the attachment.
      - `[TeamsAppId <String>]`: The ID of the Teams app that is associated with the attachment. The property is specifically used to attribute a Teams message card to the specified app.
      - `[ThumbnailUrl <String>]`: URL to a thumbnail image that the channel can use if it supports using an alternative, smaller form of content or contentUrl. For example, if you set contentType to application/word and set contentUrl to the location of the Word document, you might include a thumbnail image that represents the document. The channel could display the thumbnail image instead of the document. When the user clicks the image, the channel would open the document.
    - `[Body <IMicrosoftGraphItemBody>]`: itemBody
    - `[ChannelIdentity <IMicrosoftGraphChannelIdentity>]`: channelIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ChannelId <String>]`: The identity of the channel in which the message was posted.
      - `[TeamId <String>]`: The identity of the team in which the message was posted.
    - `[ChatId <String>]`: If the message was sent in a chat, represents the identity of the chat.
    - `[CreatedDateTime <DateTime?>]`: Timestamp of when the chat message was created.
    - `[DeletedDateTime <DateTime?>]`: Read only. Timestamp at which the chat message was deleted, or null if not deleted.
    - `[Etag <String>]`: Read-only. Version number of the chat message.
    - `[EventDetail <IMicrosoftGraphEventMessageDetail>]`: eventMessageDetail
    - `[From <IMicrosoftGraphChatMessageFromIdentitySet>]`: chatMessageFromIdentitySet
    - `[HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]`: Content in a message hosted by Microsoft Teams - for example, images or code snippets.
      - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
      - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
      - `[Id <String>]`: 
    - `[Importance <String>]`: 
    - `[LastEditedDateTime <DateTime?>]`: Read only. Timestamp when edits to the chat message were made. Triggers an 'Edited' flag in the Teams UI. If no edits are made the value is null.
    - `[LastModifiedDateTime <DateTime?>]`: Read only. Timestamp when the chat message is created (initial setting) or modified, including when a reaction is added or removed.
    - `[Locale <String>]`: Locale of the chat message set by the client. Always set to en-us.
    - `[Mentions <IMicrosoftGraphChatMessageMention1[]>]`: List of entities mentioned in the chat message. Supported entities are: user, bot, team, channel, and tag.
      - `[Id <Int32?>]`: Index of an entity being mentioned in the specified chatMessage. Matches the {index} value in the corresponding <at id='{index}'> tag in the message body.
      - `[MentionText <String>]`: String used to represent the mention. For example, a user's display name, a team name.
      - `[Mentioned <IMicrosoftGraphChatMessageMentionedIdentitySet1>]`: chatMessageMentionedIdentitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
        - `[Conversation <IMicrosoftGraphTeamworkConversationIdentity>]`: teamworkConversationIdentity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
          - `[ConversationIdentityType <String>]`: teamworkConversationIdentityType
        - `[Tag <IMicrosoftGraphTeamworkTagIdentity>]`: teamworkTagIdentity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
    - `[MessageType <String>]`: chatMessageType
    - `[OnBehalfOf <IMicrosoftGraphChatMessageFromIdentitySet>]`: chatMessageFromIdentitySet
    - `[PolicyViolation <IMicrosoftGraphChatMessagePolicyViolation>]`: chatMessagePolicyViolation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DlpAction <String>]`: chatMessagePolicyViolationDlpActionTypes
      - `[JustificationText <String>]`: Justification text provided by the sender of the message when overriding a policy violation.
      - `[PolicyTip <IMicrosoftGraphChatMessagePolicyViolationPolicyTip>]`: chatMessagePolicyViolationPolicyTip
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ComplianceUrl <String>]`: The URL a user can visit to read about the data loss prevention policies for the organization. (ie, policies about what users shouldn't say in chats)
        - `[GeneralText <String>]`: Explanatory text shown to the sender of the message.
        - `[MatchedConditionDescriptions <String[]>]`: The list of improper data in the message that was detected by the data loss prevention app. Each DLP app defines its own conditions, examples include 'Credit Card Number' and 'Social Security Number'.
      - `[UserAction <String>]`: chatMessagePolicyViolationUserActionTypes
      - `[VerdictDetails <String>]`: chatMessagePolicyViolationVerdictDetailsTypes
    - `[Reactions <IMicrosoftGraphChatMessageReaction[]>]`: Reactions for this chat message (for example, Like).
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[ReactionType <String>]`: Supported values are like, angry, sad, laugh, heart, surprised.
      - `[User <IMicrosoftGraphChatMessageReactionIdentitySet>]`: chatMessageReactionIdentitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Replies <IMicrosoftGraphChatMessage[]>]`: Replies for a specified message. Supports $expand for channel messages.
    - `[ReplyToId <String>]`: Read-only. ID of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels, not chats.)
    - `[Subject <String>]`: The subject of the chat message, in plaintext.
    - `[Summary <String>]`: Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.
    - `[WebUrl <String>]`: Read-only. Link to the message in Microsoft Teams.
  - `[OnlineMeetingInfo <IMicrosoftGraphTeamworkOnlineMeetingInfo>]`: teamworkOnlineMeetingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CalendarEventId <String>]`: The identifier of the calendar event associated with the meeting.
    - `[JoinWebUrl <String>]`: The URL which can be clicked on to join or uniquely identify the meeting.
    - `[Organizer <IMicrosoftGraphTeamworkUserIdentity>]`: teamworkUserIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
      - `[UserIdentityType <String>]`: teamworkUserIdentityType
  - `[Operations <IMicrosoftGraphTeamsAsyncOperation1[]>]`: A collection of all the Teams async operations that ran or are running on the chat. Nullable.
    - `[Id <String>]`: 
    - `[AttemptsCount <Int32?>]`: Number of times the operation was attempted before being marked successful or failed.
    - `[CreatedDateTime <DateTime?>]`: Time when the operation was created.
    - `[Error <IMicrosoftGraphOperationError>]`: operationError
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: Operation error code.
      - `[Message <String>]`: Operation error message.
    - `[LastActionDateTime <DateTime?>]`: Time when the async operation was last updated.
    - `[OperationType <String>]`: 
    - `[Status <String>]`: teamsAsyncOperationStatus
    - `[TargetResourceId <String>]`: The ID of the object that's created or modified as result of this async operation, typically a team.
    - `[TargetResourceLocation <String>]`: The location of the object that's created or modified as result of this async operation. This URL should be treated as an opaque value and not parsed into its component paths.
  - `[PermissionGrants <IMicrosoftGraphResourceSpecificPermissionGrant[]>]`: A collection of permissions granted to apps for the chat.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
    - `[ClientAppId <String>]`: ID of the service principal of the Azure AD app that has been granted access. Read-only.
    - `[ClientId <String>]`: ID of the Azure AD app that has been granted access. Read-only.
    - `[Permission <String>]`: The name of the resource-specific permission. Read-only.
    - `[PermissionType <String>]`: The type of permission. Possible values are: Application, Delegated. Read-only.
    - `[ResourceAppId <String>]`: ID of the Azure AD app that is hosting the resource. Read-only.
  - `[PinnedMessages <IMicrosoftGraphPinnedChatMessageInfo[]>]`: A collection of all the pinned messages in the chat. Nullable.
    - `[Id <String>]`: 
    - `[Message <IMicrosoftGraphChatMessage>]`: chatMessage
  - `[Tabs <IMicrosoftGraphTeamsTab1[]>]`: A collection of all the tabs in the chat. Nullable.
    - `[Id <String>]`: 
    - `[Configuration <IMicrosoftGraphTeamsTabConfiguration>]`: teamsTabConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ContentUrl <String>]`: Url used for rendering tab contents in Teams. Required.
      - `[EntityId <String>]`: Identifier for the entity hosted by the tab provider.
      - `[RemoveUrl <String>]`: Url called by Teams client when a Tab is removed using the Teams Client.
      - `[WebsiteUrl <String>]`: Url for showing tab contents outside of Teams.
    - `[DisplayName <String>]`: Name of the tab.
    - `[MessageId <String>]`: 
    - `[SortOrderIndex <String>]`: Index of the order used for sorting tabs.
    - `[TeamsApp <IMicrosoftGraphTeamsApp>]`: teamsApp
    - `[TeamsAppId <String>]`: 
    - `[WebUrl <String>]`: Deep link URL of the tab instance. Read only.
  - `[TenantId <String>]`: The identifier of the tenant in which the chat was created. Read-only.
  - `[Topic <String>]`: (Optional) Subject or topic for the chat. Only available for group chats.
  - `[Viewpoint <IMicrosoftGraphChatViewpoint>]`: chatViewpoint
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsHidden <Boolean?>]`: Indicates whether the chat is hidden for the current user.
    - `[LastMessageReadDateTime <DateTime?>]`: Represents the dateTime up until which the current user has read chatMessages in a specific chat.
  - `[WebUrl <String>]`: The URL for the chat in Microsoft Teams. The URL should be treated as an opaque blob, and not parsed. Read-only.

INPUTOBJECT <ITeamsIdentity>: Identity Parameter
  - `[AssociatedTeamInfoId <String>]`: key: id of associatedTeamInfo
  - `[ChannelId <String>]`: key: id of channel
  - `[ChatId <String>]`: key: id of chat
  - `[ChatMessageHostedContentId <String>]`: key: id of chatMessageHostedContent
  - `[ChatMessageId <String>]`: key: id of chatMessage
  - `[ChatMessageId1 <String>]`: key: id of chatMessage
  - `[ConversationMemberId <String>]`: key: id of conversationMember
  - `[DeletedTeamId <String>]`: key: id of deletedTeam
  - `[GroupId <String>]`: key: id of group
  - `[OfferShiftRequestId <String>]`: key: id of offerShiftRequest
  - `[OpenShiftChangeRequestId <String>]`: key: id of openShiftChangeRequest
  - `[OpenShiftId <String>]`: key: id of openShift
  - `[PinnedChatMessageInfoId <String>]`: key: id of pinnedChatMessageInfo
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SchedulingGroupId <String>]`: key: id of schedulingGroup
  - `[SharedWithChannelTeamInfoId <String>]`: key: id of sharedWithChannelTeamInfo
  - `[ShiftId <String>]`: key: id of shift
  - `[SwapShiftsChangeRequestId <String>]`: key: id of swapShiftsChangeRequest
  - `[TeamId <String>]`: key: id of team
  - `[TeamsAppDefinitionId <String>]`: key: id of teamsAppDefinition
  - `[TeamsAppId <String>]`: key: id of teamsApp
  - `[TeamsAppInstallationId <String>]`: key: id of teamsAppInstallation
  - `[TeamsAsyncOperationId <String>]`: key: id of teamsAsyncOperation
  - `[TeamsTabId <String>]`: key: id of teamsTab
  - `[TeamworkDeviceId <String>]`: key: id of teamworkDevice
  - `[TeamworkDeviceOperationId <String>]`: key: id of teamworkDeviceOperation
  - `[TeamworkTagId <String>]`: key: id of teamworkTag
  - `[TeamworkTagMemberId <String>]`: key: id of teamworkTagMember
  - `[TimeCardId <String>]`: key: id of timeCard
  - `[TimeOffId <String>]`: key: id of timeOff
  - `[TimeOffReasonId <String>]`: key: id of timeOffReason
  - `[TimeOffRequestId <String>]`: key: id of timeOffRequest
  - `[UserId <String>]`: key: id of user
  - `[UserScopeTeamsAppInstallationId <String>]`: key: id of userScopeTeamsAppInstallation
  - `[WorkforceIntegrationId <String>]`: key: id of workforceIntegration

TEAMSAPP <IMicrosoftGraphTeamsApp>: teamsApp
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppDefinitions <IMicrosoftGraphTeamsAppDefinition1[]>]`: The details for each version of the app.
    - `[Id <String>]`: 
    - `[AllowedInstallationScopes <String>]`: teamsAppInstallationScopes
    - `[AzureAdAppId <String>]`: The WebApplicationInfo.Id from the Teams app manifest.
    - `[Bot <IMicrosoftGraphTeamworkBot>]`: teamworkBot
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
    - `[ColorIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[HostedContent <IMicrosoftGraphTeamworkHostedContent>]`: teamworkHostedContent
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
        - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
      - `[WebUrl <String>]`: The web URL that can be used for downloading the image.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Description <String>]`: Verbose description of the application.
    - `[DisplayName <String>]`: The name of the app provided by the app developer.
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[OutlineIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
    - `[PublishingState <String>]`: teamsAppPublishingState
    - `[Shortdescription <String>]`: 
    - `[TeamsAppId <String>]`: The ID from the Teams app manifest.
    - `[Version <String>]`: The version number of the application.
  - `[DisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
  - `[DistributionMethod <String>]`: teamsAppDistributionMethod
  - `[ExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.

TEAMSAPPDEFINITION <IMicrosoftGraphTeamsAppDefinition1>: teamsAppDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AllowedInstallationScopes <String>]`: teamsAppInstallationScopes
  - `[AzureAdAppId <String>]`: The WebApplicationInfo.Id from the Teams app manifest.
  - `[Bot <IMicrosoftGraphTeamworkBot>]`: teamworkBot
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
  - `[ColorIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[HostedContent <IMicrosoftGraphTeamworkHostedContent>]`: teamworkHostedContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
      - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
    - `[WebUrl <String>]`: The web URL that can be used for downloading the image.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Description <String>]`: Verbose description of the application.
  - `[DisplayName <String>]`: The name of the app provided by the app developer.
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[OutlineIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
  - `[PublishingState <String>]`: teamsAppPublishingState
  - `[Shortdescription <String>]`: 
  - `[TeamsAppId <String>]`: The ID from the Teams app manifest.
  - `[Version <String>]`: The version number of the application.

## RELATED LINKS

