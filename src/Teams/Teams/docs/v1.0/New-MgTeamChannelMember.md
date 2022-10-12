---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgteamchannelmember
schema: 2.0.0
---

# New-MgTeamChannelMember

## SYNOPSIS
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

## SYNTAX

### CreateExpanded (Default)
```
New-MgTeamChannelMember -ChannelId <String> -TeamId <String> [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-Id <String>] [-Roles <String[]>] [-VisibleHistoryStartDateTime <DateTime>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgTeamChannelMember -ChannelId <String> -TeamId <String>
 -BodyParameter <IMicrosoftGraphConversationMember> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgTeamChannelMember -InputObject <ITeamsIdentity> -BodyParameter <IMicrosoftGraphConversationMember>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgTeamChannelMember -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-Id <String>] [-Roles <String[]>] [-VisibleHistoryStartDateTime <DateTime>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

## EXAMPLES

### Example 1: Using the New-MgTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('8b081ef6-4792-4def-b2c9-c363a1bf41d5')"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```

This example shows how to use the New-MgTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the New-MgTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId
```

This example shows how to use the New-MgTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the New-MgTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('jacob@contoso.com')"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```

This example shows how to use the New-MgTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the New-MgTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/beta/users('jacob@contoso.com')"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```

This example shows how to use the New-MgTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Using the New-MgTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users/8b081ef6-4792-4def-b2c9-c363a1bf41d5"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```

This example shows how to use the New-MgTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 6: Using the New-MgTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users/24b3819b-4e1d-4f3e-86bd-e42b54d0b2b4"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```

This example shows how to use the New-MgTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 7: Using the New-MgTeamChannelMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
	)
	"User@odata.bind" = "https://graph.microsoft.com/v1.0/users/bc3598dd-cce4-4742-ae15-173429951408"
	TenantId = "a18103d1-a6ef-4f66-ac64-e4ef42ea8681"
}
New-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```

This example shows how to use the New-MgTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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

### -BodyParameter
conversationMember
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConversationMember
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChannelId
key: id of channel

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

### -DisplayName
The display name of the user.

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

### -Id
The unique idenfier for an entity.
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ITeamsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Roles
The roles for that user.
This property only contains additional qualifiers when relevant - for example, if the member has owner privileges, the roles property contains owner as one of the values.
Similarly, if the member is a guest, the roles property contains guest as one of the values.
A basic member should not have any values specified in the roles property.

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

### -TeamId
key: id of team

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

### -VisibleHistoryStartDateTime
The timestamp denoting how far back a conversation's history is shared with the conversation member.
This property is settable only for members of a chat.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConversationMember

### Microsoft.Graph.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConversationMember

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphConversationMember>: conversationMember
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name of the user.
  - `[Roles <String[]>]`: The roles for that user. This property only contains additional qualifiers when relevant - for example, if the member has owner privileges, the roles property contains owner as one of the values. Similarly, if the member is a guest, the roles property contains guest as one of the values. A basic member should not have any values specified in the roles property.
  - `[VisibleHistoryStartDateTime <DateTime?>]`: The timestamp denoting how far back a conversation's history is shared with the conversation member. This property is settable only for members of a chat.

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
  - `[TeamTemplateDefinitionId <String>]`: key: id of teamTemplateDefinition
  - `[TeamTemplateId <String>]`: key: id of teamTemplate
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

## RELATED LINKS

