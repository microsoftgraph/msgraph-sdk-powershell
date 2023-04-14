---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/send-mgchatactivitynotification
schema: 2.0.0
---

# Send-MgChatActivityNotification

## SYNOPSIS
Send an activity feed notification in scope of a chat.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

## SYNTAX

### SendExpanded (Default)
```
Send-MgChatActivityNotification -ChatId <String> [-ActivityType <String>] [-AdditionalProperties <Hashtable>]
 [-ChainId <Int64>] [-PreviewText <IMicrosoftGraphItemBody>] [-Recipient <Hashtable>]
 [-TemplateParameters <IMicrosoftGraphKeyValuePair[]>] [-Topic <IMicrosoftGraphTeamworkActivityTopic>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Send
```
Send-MgChatActivityNotification -ChatId <String>
 -BodyParameter <IPaths1BjzoobChatsChatIdMicrosoftGraphSendactivitynotificationPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SendViaIdentity
```
Send-MgChatActivityNotification -InputObject <ITeamsIdentity>
 -BodyParameter <IPaths1BjzoobChatsChatIdMicrosoftGraphSendactivitynotificationPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SendViaIdentityExpanded
```
Send-MgChatActivityNotification -InputObject <ITeamsIdentity> [-ActivityType <String>]
 [-AdditionalProperties <Hashtable>] [-ChainId <Int64>] [-PreviewText <IMicrosoftGraphItemBody>]
 [-Recipient <Hashtable>] [-TemplateParameters <IMicrosoftGraphKeyValuePair[]>]
 [-Topic <IMicrosoftGraphTeamworkActivityTopic>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Send an activity feed notification in scope of a chat.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

## EXAMPLES

### Example 1: Using the Send-MgChatActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/v1.0/chats/{chatId}"
	}
	ActivityType = "taskCreated"
	PreviewText = @{
		Content = "New Task Created"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "taskId"
			Value = "Task 12322"
		}
	)
}
Send-MgChatActivityNotification -ChatId $chatId -BodyParameter $params
```

This example shows how to use the Send-MgChatActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Send-MgChatActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/v1.0/chats/{chatId}/messages/{messageId}"
	}
	ActivityType = "approvalRequired"
	PreviewText = @{
		Content = "Deployment requires your approval"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "approvalTaskId"
			Value = "2020AAGGTAPP"
		}
	)
}
Send-MgChatActivityNotification -ChatId $chatId -BodyParameter $params
```

This example shows how to use the Send-MgChatActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the Send-MgChatActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "text"
		Value = "Deployment Approvals Channel"
		WebUrl = "https://teams.microsoft.com/l/message/19:448cfd2ac2a7490a9084a9ed14cttr78c@thread.skype/1605223780000?tenantId=c8b1bf45-3834-4ecf-971a-b4c755ee677d&groupId=d4c2a937-f097-435a-bc91-5c1683ca7245&parentMessageId=1605223771864&teamName=Approvals&channelName=Azure%20DevOps&createdTime=1605223780000"
	}
	ActivityType = "deploymentApprovalRequired"
	PreviewText = @{
		Content = "New deployment requires your approval"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "deploymentId"
			Value = "6788662"
		}
	)
}
Send-MgChatActivityNotification -ChatId $chatId -BodyParameter $params
```

This example shows how to use the Send-MgChatActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the Send-MgChatActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "text"
		Value = "Deployment Approvals Channel"
		WebUrl = "https://teams.microsoft.com/l/message/19:448cfd2ac2a7490a9084a9ed14cttr78c@thread.skype/1605223780000?tenantId=c8b1bf45-3834-4ecf-971a-b4c755ee677d&groupId=d4c2a937-f097-435a-bc91-5c1683ca7245&parentMessageId=1605223771864&teamName=Approvals&channelName=Azure%20DevOps&createdTime=1605223780000"
	}
	ActivityType = "deploymentApprovalRequired"
	PreviewText = @{
		Content = "New deployment requires your approval"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
	}
	TemplateParameters = @(
		@{
			Name = "deploymentId"
			Value = "6788662"
		}
	)
}
Send-MgChatActivityNotification -ChatId $chatId -BodyParameter $params
```

This example shows how to use the Send-MgChatActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Using the Send-MgChatActivityNotification Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/v1.0/chats/{chatId}/messages/{messageId}"
	}
	ActivityType = "approvalRequired"
	PreviewText = @{
		Content = "Deployment requires your approval"
	}
	Recipient = @{
		"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
		UserId = "jacob@contoso.com"
	}
	TemplateParameters = @(
		@{
			Name = "approvalTaskId"
			Value = "2020AAGGTAPP"
		}
	)
}
Send-MgChatActivityNotification -ChatId $chatId -BodyParameter $params
```

This example shows how to use the Send-MgChatActivityNotification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -ActivityType
.

```yaml
Type: System.String
Parameter Sets: SendExpanded, SendViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: SendExpanded, SendViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1BjzoobChatsChatIdMicrosoftGraphSendactivitynotificationPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Send, SendViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChainId
.

```yaml
Type: System.Int64
Parameter Sets: SendExpanded, SendViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChatId
The unique identifier of chat

```yaml
Type: System.String
Parameter Sets: Send, SendExpanded
Aliases:

Required: True
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
Parameter Sets: SendViaIdentity, SendViaIdentityExpanded
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

### -PreviewText
itemBody
To construct, please use Get-Help -Online and see NOTES section for PREVIEWTEXT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemBody
Parameter Sets: SendExpanded, SendViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Recipient
teamworkNotificationRecipient

```yaml
Type: System.Collections.Hashtable
Parameter Sets: SendExpanded, SendViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateParameters
.
To construct, please use Get-Help -Online and see NOTES section for TEMPLATEPARAMETERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: SendExpanded, SendViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Topic
teamworkActivityTopic
To construct, please use Get-Help -Online and see NOTES section for TOPIC properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkActivityTopic
Parameter Sets: SendExpanded, SendViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1BjzoobChatsChatIdMicrosoftGraphSendactivitynotificationPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1BjzoobChatsChatIdMicrosoftGraphSendactivitynotificationPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ActivityType <String>]`: 
  - `[ChainId <Int64?>]`: 
  - `[PreviewText <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[Recipient <IMicrosoftGraphTeamworkNotificationRecipient>]`: teamworkNotificationRecipient
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[TemplateParameters <IMicrosoftGraphKeyValuePair[]>]`: 
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[Topic <IMicrosoftGraphTeamworkActivityTopic>]`: teamworkActivityTopic
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Source <String>]`: teamworkActivityTopicSource
    - `[Value <String>]`: The topic value. If the value of the source property is entityUrl, this must be a Microsoft Graph URL. If the vaule is text, this must be a plain text value.
    - `[WebUrl <String>]`: The link the user clicks when they select the notification. Optional when source is entityUrl; required when source is text.

INPUTOBJECT <ITeamsIdentity>: Identity Parameter
  - `[AssociatedTeamInfoId <String>]`: The unique identifier of associatedTeamInfo
  - `[ChannelId <String>]`: The unique identifier of channel
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageHostedContentId <String>]`: The unique identifier of chatMessageHostedContent
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[ChatMessageId1 <String>]`: The unique identifier of chatMessage
  - `[ConversationMemberId <String>]`: The unique identifier of conversationMember
  - `[DeletedTeamId <String>]`: The unique identifier of deletedTeam
  - `[GroupId <String>]`: The unique identifier of group
  - `[OfferShiftRequestId <String>]`: The unique identifier of offerShiftRequest
  - `[OpenShiftChangeRequestId <String>]`: The unique identifier of openShiftChangeRequest
  - `[OpenShiftId <String>]`: The unique identifier of openShift
  - `[PinnedChatMessageInfoId <String>]`: The unique identifier of pinnedChatMessageInfo
  - `[ResourceSpecificPermissionGrantId <String>]`: The unique identifier of resourceSpecificPermissionGrant
  - `[SchedulingGroupId <String>]`: The unique identifier of schedulingGroup
  - `[SharedWithChannelTeamInfoId <String>]`: The unique identifier of sharedWithChannelTeamInfo
  - `[ShiftId <String>]`: The unique identifier of shift
  - `[SwapShiftsChangeRequestId <String>]`: The unique identifier of swapShiftsChangeRequest
  - `[TeamId <String>]`: The unique identifier of team
  - `[TeamTemplateDefinitionId <String>]`: The unique identifier of teamTemplateDefinition
  - `[TeamTemplateId <String>]`: The unique identifier of teamTemplate
  - `[TeamsAppDefinitionId <String>]`: The unique identifier of teamsAppDefinition
  - `[TeamsAppId <String>]`: The unique identifier of teamsApp
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TeamsAsyncOperationId <String>]`: The unique identifier of teamsAsyncOperation
  - `[TeamsTabId <String>]`: The unique identifier of teamsTab
  - `[TeamworkDeviceId <String>]`: The unique identifier of teamworkDevice
  - `[TeamworkDeviceOperationId <String>]`: The unique identifier of teamworkDeviceOperation
  - `[TeamworkTagId <String>]`: The unique identifier of teamworkTag
  - `[TeamworkTagMemberId <String>]`: The unique identifier of teamworkTagMember
  - `[TimeCardId <String>]`: The unique identifier of timeCard
  - `[TimeOffId <String>]`: The unique identifier of timeOff
  - `[TimeOffReasonId <String>]`: The unique identifier of timeOffReason
  - `[TimeOffRequestId <String>]`: The unique identifier of timeOffRequest
  - `[UserId <String>]`: The unique identifier of user
  - `[UserScopeTeamsAppInstallationId <String>]`: The unique identifier of userScopeTeamsAppInstallation
  - `[WorkforceIntegrationId <String>]`: The unique identifier of workforceIntegration

PREVIEWTEXT <IMicrosoftGraphItemBody>: itemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: The content of the item.
  - `[ContentType <String>]`: bodyType

TEMPLATEPARAMETERS <IMicrosoftGraphKeyValuePair[]>: .
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

TOPIC <IMicrosoftGraphTeamworkActivityTopic>: teamworkActivityTopic
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Source <String>]`: teamworkActivityTopicSource
  - `[Value <String>]`: The topic value. If the value of the source property is entityUrl, this must be a Microsoft Graph URL. If the vaule is text, this must be a plain text value.
  - `[WebUrl <String>]`: The link the user clicks when they select the notification. Optional when source is entityUrl; required when source is text.

## RELATED LINKS

