---
external help file:
Module Name: Microsoft.Graph.Teams.Team
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.team/update-mgteamprimarychannelmessage
schema: 2.0.0
---

# Update-MgTeamPrimaryChannelMessage

## SYNOPSIS
Update the navigation property messages in teams

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgTeamPrimaryChannelMessage -ChatMessageId <String> -TeamId <String>
 [-Attachments <IMicrosoftGraphChatMessageAttachment[]>] [-BodyContent <String>] [-BodyContentType <String>]
 [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>] [-Etag <String>]
 [-From <IMicrosoftGraphIdentitySet>] [-HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]
 [-Id <String>] [-Importance <String>] [-LastModifiedDateTime <DateTime>] [-Locale <String>]
 [-Mentions <IMicrosoftGraphChatMessageMention[]>] [-MessageType <String>] [-PolicyTipComplianceUrl <String>]
 [-PolicyTipGeneralText <String>] [-PolicyTipMatchedConditionDescriptions <String[]>]
 [-PolicyViolationDlpAction <String>] [-PolicyViolationJustificationText <String>]
 [-PolicyViolationUserAction <String>] [-PolicyViolationVerdictDetails <String>]
 [-Reactions <IMicrosoftGraphChatMessageReaction[]>] [-Replies <IMicrosoftGraphChatMessage1[]>]
 [-ReplyToId <String>] [-Subject <String>] [-Summary <String>] [-WebUrl <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgTeamPrimaryChannelMessage -ChatMessageId <String> -TeamId <String>
 -BodyParameter <IMicrosoftGraphChatMessage1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgTeamPrimaryChannelMessage -InputObject <ITeamsTeamIdentity>
 -BodyParameter <IMicrosoftGraphChatMessage1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgTeamPrimaryChannelMessage -InputObject <ITeamsTeamIdentity>
 [-Attachments <IMicrosoftGraphChatMessageAttachment[]>] [-BodyContent <String>] [-BodyContentType <String>]
 [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>] [-Etag <String>]
 [-From <IMicrosoftGraphIdentitySet>] [-HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]
 [-Id <String>] [-Importance <String>] [-LastModifiedDateTime <DateTime>] [-Locale <String>]
 [-Mentions <IMicrosoftGraphChatMessageMention[]>] [-MessageType <String>] [-PolicyTipComplianceUrl <String>]
 [-PolicyTipGeneralText <String>] [-PolicyTipMatchedConditionDescriptions <String[]>]
 [-PolicyViolationDlpAction <String>] [-PolicyViolationJustificationText <String>]
 [-PolicyViolationUserAction <String>] [-PolicyViolationVerdictDetails <String>]
 [-Reactions <IMicrosoftGraphChatMessageReaction[]>] [-Replies <IMicrosoftGraphChatMessage1[]>]
 [-ReplyToId <String>] [-Subject <String>] [-Summary <String>] [-WebUrl <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property messages in teams

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

### -Attachments
Attached files.
Attachments are currently read-only – sending attachments is not supported.
To construct, see NOTES section for ATTACHMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessageAttachment[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyContent
The content of the item.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyContentType
bodyType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
chatMessage
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessage1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChatMessageId
key: chatMessage-id of chatMessage

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Read only.
Timestamp of when the chat message was created.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedDateTime
Read only.
Timestamp at which the chat message was deleted, or null if not deleted.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Etag
Read-only.
Version number of the chat message.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -From
identitySet
To construct, see NOTES section for FROM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostedContents
.
To construct, see NOTES section for HOSTEDCONTENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessageHostedContent[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Importance
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
Read only.
Timestamp of when the chat message is created or edited, including when a reply is made (if it's a root chat message in a channel) or a reaction is added or removed.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Locale
Locale of the chat message set by the client.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Mentions
List of entities mentioned in the chat message.
Currently supports user, bot, team, channel.
To construct, see NOTES section for MENTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessageMention[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MessageType
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -PolicyTipComplianceUrl
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyTipGeneralText
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyTipMatchedConditionDescriptions
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyViolationDlpAction
chatMessagePolicyViolationDlpActionTypes

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyViolationJustificationText
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyViolationUserAction
chatMessagePolicyViolationUserActionTypes

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyViolationVerdictDetails
chatMessagePolicyViolationVerdictDetailsTypes

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reactions
.
To construct, see NOTES section for REACTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessageReaction[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Replies
.
To construct, see NOTES section for REPLIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessage1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReplyToId
Read-only.
Id of the parent chat message or root chat message of the thread.
(Only applies to chat messages in channels not chats)

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
The subject of the chat message, in plaintext.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Summary
Summary text of the chat message that could be used for push notifications and summary views or fall back views.
Only applies to channel chat messages, not chat messages in a chat.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamId
key: team-id of team

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WebUrl
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessage1

### Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ATTACHMENTS <IMicrosoftGraphChatMessageAttachment[]>: Attached files. Attachments are currently read-only – sending attachments is not supported.
  - `[Content <String>]`: The content of the attachment. If the attachment is a rich card, set the property to the rich card object. This property and contentUrl are mutually exclusive.
  - `[ContentType <String>]`: The media type of the content attachment. It can have the following values: reference: Attachment is a link to another file. Populate the contentURL with the link to the object.file: Raw file attachment. Populate the contenturl field with the base64 encoding of the file in data: format.image/: Image type with the type of the image specified ex: image/png, image/jpeg, image/gif. Populate the contentUrl field with the base64 encoding of the file in data: format.video/: Video type with the format specified. Ex: video/mp4. Populate the contentUrl field with the base64 encoding of the file in data: format.audio/: Audio type with the format specified. Ex: audio/wmw. Populate the contentUrl field with the base64 encoding of the file in data: format.application/card type: Rich card attachment type with the card type specifying the exact card format to use. Set content with the json format of the card. Supported values for card type include:application/vnd.microsoft.card.adaptive: A rich card that can contain any combination of text, speech, images,,buttons, and input fields. Set the content property to,an AdaptiveCard object.application/vnd.microsoft.card.animation: A rich card that plays animation. Set the content property,to an AnimationCardobject.application/vnd.microsoft.card.audio: A rich card that plays audio files. Set the content property,to an AudioCard object.application/vnd.microsoft.card.video: A rich card that plays videos. Set the content property,to a VideoCard object.application/vnd.microsoft.card.hero: A Hero card. Set the content property to a HeroCard object.application/vnd.microsoft.card.thumbnail: A Thumbnail card. Set the content property to a ThumbnailCard object.application/vnd.microsoft.com.card.receipt: A Receipt card. Set the content property to a ReceiptCard object.application/vnd.microsoft.com.card.signin: A user Sign In card. Set the content property to a SignInCard object.
  - `[ContentUrl <String>]`: URL for the content of the attachment. Supported protocols: http, https, file and data.
  - `[Id <String>]`: Read-only. Unique id of the attachment.
  - `[Name <String>]`: Name of the attachment.
  - `[ThumbnailUrl <String>]`: URL to a thumbnail image that the channel can use if it supports using an alternative, smaller form of content or contentUrl. For example, if you set contentType to application/word and set contentUrl to the location of the Word document, you might include a thumbnail image that represents the document. The channel could display the thumbnail image instead of the document. When the user clicks the image, the channel would open the document.

BODYPARAMETER <IMicrosoftGraphChatMessage1>: chatMessage
  - `[Id <String>]`: Read-only.
  - `[Attachments <IMicrosoftGraphChatMessageAttachment[]>]`: Attached files. Attachments are currently read-only – sending attachments is not supported.
    - `[Content <String>]`: The content of the attachment. If the attachment is a rich card, set the property to the rich card object. This property and contentUrl are mutually exclusive.
    - `[ContentType <String>]`: The media type of the content attachment. It can have the following values: reference: Attachment is a link to another file. Populate the contentURL with the link to the object.file: Raw file attachment. Populate the contenturl field with the base64 encoding of the file in data: format.image/: Image type with the type of the image specified ex: image/png, image/jpeg, image/gif. Populate the contentUrl field with the base64 encoding of the file in data: format.video/: Video type with the format specified. Ex: video/mp4. Populate the contentUrl field with the base64 encoding of the file in data: format.audio/: Audio type with the format specified. Ex: audio/wmw. Populate the contentUrl field with the base64 encoding of the file in data: format.application/card type: Rich card attachment type with the card type specifying the exact card format to use. Set content with the json format of the card. Supported values for card type include:application/vnd.microsoft.card.adaptive: A rich card that can contain any combination of text, speech, images,,buttons, and input fields. Set the content property to,an AdaptiveCard object.application/vnd.microsoft.card.animation: A rich card that plays animation. Set the content property,to an AnimationCardobject.application/vnd.microsoft.card.audio: A rich card that plays audio files. Set the content property,to an AudioCard object.application/vnd.microsoft.card.video: A rich card that plays videos. Set the content property,to a VideoCard object.application/vnd.microsoft.card.hero: A Hero card. Set the content property to a HeroCard object.application/vnd.microsoft.card.thumbnail: A Thumbnail card. Set the content property to a ThumbnailCard object.application/vnd.microsoft.com.card.receipt: A Receipt card. Set the content property to a ReceiptCard object.application/vnd.microsoft.com.card.signin: A user Sign In card. Set the content property to a SignInCard object.
    - `[ContentUrl <String>]`: URL for the content of the attachment. Supported protocols: http, https, file and data.
    - `[Id <String>]`: Read-only. Unique id of the attachment.
    - `[Name <String>]`: Name of the attachment.
    - `[ThumbnailUrl <String>]`: URL to a thumbnail image that the channel can use if it supports using an alternative, smaller form of content or contentUrl. For example, if you set contentType to application/word and set contentUrl to the location of the Word document, you might include a thumbnail image that represents the document. The channel could display the thumbnail image instead of the document. When the user clicks the image, the channel would open the document.
  - `[BodyContent <String>]`: The content of the item.
  - `[BodyContentType <String>]`: bodyType
  - `[CreatedDateTime <DateTime?>]`: Read only. Timestamp of when the chat message was created.
  - `[DeletedDateTime <DateTime?>]`: Read only. Timestamp at which the chat message was deleted, or null if not deleted.
  - `[Etag <String>]`: Read-only. Version number of the chat message.
  - `[From <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]`: 
    - `[Id <String>]`: Read-only.
  - `[Importance <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: Read only. Timestamp of when the chat message is created or edited, including when a reply is made (if it's a root chat message in a channel) or a reaction is added or removed.
  - `[Locale <String>]`: Locale of the chat message set by the client.
  - `[Mentions <IMicrosoftGraphChatMessageMention[]>]`: List of entities mentioned in the chat message. Currently supports user, bot, team, channel.
    - `[Id <Int32?>]`: Index of an entity being mentioned in the specified chatMessage. Matches the {index} value in the corresponding <at id='{index}'> tag in the message body.
    - `[MentionText <String>]`: String used to represent the mention. For example, a user's display name, a team name.
    - `[Mentioned <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[MessageType <String>]`: 
  - `[PolicyTipComplianceUrl <String>]`: 
  - `[PolicyTipGeneralText <String>]`: 
  - `[PolicyTipMatchedConditionDescriptions <String[]>]`: 
  - `[PolicyViolationDlpAction <String>]`: chatMessagePolicyViolationDlpActionTypes
  - `[PolicyViolationJustificationText <String>]`: 
  - `[PolicyViolationUserAction <String>]`: chatMessagePolicyViolationUserActionTypes
  - `[PolicyViolationVerdictDetails <String>]`: chatMessagePolicyViolationVerdictDetailsTypes
  - `[Reactions <IMicrosoftGraphChatMessageReaction[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[ReactionType <String>]`: 
    - `[User <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Replies <IMicrosoftGraphChatMessage1[]>]`: 
  - `[ReplyToId <String>]`: Read-only. Id of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels not chats)
  - `[Subject <String>]`: The subject of the chat message, in plaintext.
  - `[Summary <String>]`: Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.
  - `[WebUrl <String>]`: 

FROM <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

HOSTEDCONTENTS <IMicrosoftGraphChatMessageHostedContent[]>: .
  - `[Id <String>]`: Read-only.

INPUTOBJECT <ITeamsTeamIdentity>: Identity Parameter
  - `[ChannelId <String>]`: key: channel-id of channel
  - `[ChatMessageHostedContentId <String>]`: key: chatMessageHostedContent-id of chatMessageHostedContent
  - `[ChatMessageId <String>]`: key: chatMessage-id of chatMessage
  - `[ChatMessageId1 <String>]`: key: chatMessage-id of chatMessage
  - `[ConversationMemberId <String>]`: key: conversationMember-id of conversationMember
  - `[GroupId <String>]`: key: group-id of group
  - `[OfferShiftRequestId <String>]`: key: offerShiftRequest-id of offerShiftRequest
  - `[OpenShiftChangeRequestId <String>]`: key: openShiftChangeRequest-id of openShiftChangeRequest
  - `[OpenShiftId <String>]`: key: openShift-id of openShift
  - `[SchedulingGroupId <String>]`: key: schedulingGroup-id of schedulingGroup
  - `[ShiftId <String>]`: key: shift-id of shift
  - `[SwapShiftsChangeRequestId <String>]`: key: swapShiftsChangeRequest-id of swapShiftsChangeRequest
  - `[TeamId <String>]`: key: team-id of team
  - `[TeamsAppInstallationId <String>]`: key: teamsAppInstallation-id of teamsAppInstallation
  - `[TeamsAsyncOperationId <String>]`: key: teamsAsyncOperation-id of teamsAsyncOperation
  - `[TeamsTabId <String>]`: key: teamsTab-id of teamsTab
  - `[TeamsTemplateId <String>]`: key: teamsTemplate-id of teamsTemplate
  - `[TimeOffId <String>]`: key: timeOff-id of timeOff
  - `[TimeOffReasonId <String>]`: key: timeOffReason-id of timeOffReason
  - `[TimeOffRequestId <String>]`: key: timeOffRequest-id of timeOffRequest
  - `[UserId <String>]`: key: user-id of user
  - `[WorkforceIntegrationId <String>]`: key: workforceIntegration-id of workforceIntegration

MENTIONS <IMicrosoftGraphChatMessageMention[]>: List of entities mentioned in the chat message. Currently supports user, bot, team, channel.
  - `[Id <Int32?>]`: Index of an entity being mentioned in the specified chatMessage. Matches the {index} value in the corresponding <at id='{index}'> tag in the message body.
  - `[MentionText <String>]`: String used to represent the mention. For example, a user's display name, a team name.
  - `[Mentioned <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity

REACTIONS <IMicrosoftGraphChatMessageReaction[]>: .
  - `[CreatedDateTime <DateTime?>]`: 
  - `[ReactionType <String>]`: 
  - `[User <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity

REPLIES <IMicrosoftGraphChatMessage1[]>: .
  - `[Id <String>]`: Read-only.
  - `[Attachments <IMicrosoftGraphChatMessageAttachment[]>]`: Attached files. Attachments are currently read-only – sending attachments is not supported.
    - `[Content <String>]`: The content of the attachment. If the attachment is a rich card, set the property to the rich card object. This property and contentUrl are mutually exclusive.
    - `[ContentType <String>]`: The media type of the content attachment. It can have the following values: reference: Attachment is a link to another file. Populate the contentURL with the link to the object.file: Raw file attachment. Populate the contenturl field with the base64 encoding of the file in data: format.image/: Image type with the type of the image specified ex: image/png, image/jpeg, image/gif. Populate the contentUrl field with the base64 encoding of the file in data: format.video/: Video type with the format specified. Ex: video/mp4. Populate the contentUrl field with the base64 encoding of the file in data: format.audio/: Audio type with the format specified. Ex: audio/wmw. Populate the contentUrl field with the base64 encoding of the file in data: format.application/card type: Rich card attachment type with the card type specifying the exact card format to use. Set content with the json format of the card. Supported values for card type include:application/vnd.microsoft.card.adaptive: A rich card that can contain any combination of text, speech, images,,buttons, and input fields. Set the content property to,an AdaptiveCard object.application/vnd.microsoft.card.animation: A rich card that plays animation. Set the content property,to an AnimationCardobject.application/vnd.microsoft.card.audio: A rich card that plays audio files. Set the content property,to an AudioCard object.application/vnd.microsoft.card.video: A rich card that plays videos. Set the content property,to a VideoCard object.application/vnd.microsoft.card.hero: A Hero card. Set the content property to a HeroCard object.application/vnd.microsoft.card.thumbnail: A Thumbnail card. Set the content property to a ThumbnailCard object.application/vnd.microsoft.com.card.receipt: A Receipt card. Set the content property to a ReceiptCard object.application/vnd.microsoft.com.card.signin: A user Sign In card. Set the content property to a SignInCard object.
    - `[ContentUrl <String>]`: URL for the content of the attachment. Supported protocols: http, https, file and data.
    - `[Id <String>]`: Read-only. Unique id of the attachment.
    - `[Name <String>]`: Name of the attachment.
    - `[ThumbnailUrl <String>]`: URL to a thumbnail image that the channel can use if it supports using an alternative, smaller form of content or contentUrl. For example, if you set contentType to application/word and set contentUrl to the location of the Word document, you might include a thumbnail image that represents the document. The channel could display the thumbnail image instead of the document. When the user clicks the image, the channel would open the document.
  - `[BodyContent <String>]`: The content of the item.
  - `[BodyContentType <String>]`: bodyType
  - `[CreatedDateTime <DateTime?>]`: Read only. Timestamp of when the chat message was created.
  - `[DeletedDateTime <DateTime?>]`: Read only. Timestamp at which the chat message was deleted, or null if not deleted.
  - `[Etag <String>]`: Read-only. Version number of the chat message.
  - `[From <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]`: 
    - `[Id <String>]`: Read-only.
  - `[Importance <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: Read only. Timestamp of when the chat message is created or edited, including when a reply is made (if it's a root chat message in a channel) or a reaction is added or removed.
  - `[Locale <String>]`: Locale of the chat message set by the client.
  - `[Mentions <IMicrosoftGraphChatMessageMention[]>]`: List of entities mentioned in the chat message. Currently supports user, bot, team, channel.
    - `[Id <Int32?>]`: Index of an entity being mentioned in the specified chatMessage. Matches the {index} value in the corresponding <at id='{index}'> tag in the message body.
    - `[MentionText <String>]`: String used to represent the mention. For example, a user's display name, a team name.
    - `[Mentioned <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[MessageType <String>]`: 
  - `[PolicyTipComplianceUrl <String>]`: 
  - `[PolicyTipGeneralText <String>]`: 
  - `[PolicyTipMatchedConditionDescriptions <String[]>]`: 
  - `[PolicyViolationDlpAction <String>]`: chatMessagePolicyViolationDlpActionTypes
  - `[PolicyViolationJustificationText <String>]`: 
  - `[PolicyViolationUserAction <String>]`: chatMessagePolicyViolationUserActionTypes
  - `[PolicyViolationVerdictDetails <String>]`: chatMessagePolicyViolationVerdictDetailsTypes
  - `[Reactions <IMicrosoftGraphChatMessageReaction[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[ReactionType <String>]`: 
    - `[User <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Replies <IMicrosoftGraphChatMessage1[]>]`: 
  - `[ReplyToId <String>]`: Read-only. Id of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels not chats)
  - `[Subject <String>]`: The subject of the chat message, in plaintext.
  - `[Summary <String>]`: Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.
  - `[WebUrl <String>]`: 

## RELATED LINKS

