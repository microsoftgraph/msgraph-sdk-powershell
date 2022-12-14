---
external help file:
Module Name: Microsoft.Graph.Beta.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.teams/add-mgteamchannelmember
schema: 2.0.0
---

# Add-MgBetaTeamChannelMember

## SYNOPSIS
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

## SYNTAX

### AddExpanded1 (Default)
```
Add-MgBetaTeamChannelMember -ChannelId <String> -TeamId <String> [-AdditionalProperties <Hashtable>]
 [-Values <IMicrosoftGraphConversationMember[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Add1
```
Add-MgBetaTeamChannelMember -ChannelId <String> -TeamId <String>
 -BodyParameter <IPaths1Rl53M1TeamsTeamIdChannelsChannelIdMembersMicrosoftGraphAddPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentity1
```
Add-MgBetaTeamChannelMember -InputObject <ITeamsIdentity>
 -BodyParameter <IPaths1Rl53M1TeamsTeamIdChannelsChannelIdMembersMicrosoftGraphAddPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentityExpanded1
```
Add-MgBetaTeamChannelMember -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-Values <IMicrosoftGraphConversationMember[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

## EXAMPLES

### Example 1: Add members in bulk to a team
```powershell
Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	Values = @(
		@{
			"@odata.type" = "Microsoft.Graph.Beta.aadUserConversationMember"
			Roles = @(
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('18a80140-b0fb-4489-b360-2f6efaf225a0')"
		}
		@{
			"@odata.type" = "Microsoft.Graph.Beta.aadUserConversationMember"
			Roles = @(
				"owner"
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('86503198-b81b-43fe-81ee-ad45b8848ac9')"
		}
	)
}

Add-MgBetaTeamMember -TeamId $teamId -BodyParameter $params
```

This example shows how to use the Add-MgBetaTeamChannelMember Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Add members in bulk and encounter partial failure
```powershell
Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	Values = @(
		@{
			"@odata.type" = "Microsoft.Graph.Beta.aadUserConversationMember"
			Roles = @(
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('18a80140-b0fb-4489-b360-2f6efaf225a0')"
		}
		@{
			"@odata.type" = "Microsoft.Graph.Beta.aadUserConversationMember"
			Roles = @(
				"owner"
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('86503198-b81b-43fe-81ee-ad45b8848ac9')"
		}
	)
}

Add-MgBetaTeamMember -TeamId $teamId -BodyParameter $params
```

This example shows how to use the Add-MgBetaTeamChannelMember Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Add members in bulk to a team using user principal name
```powershell
Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	Values = @(
		@{
			"@odata.type" = "Microsoft.Graph.Beta.aadUserConversationMember"
			Roles = @(
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('jacob@contoso.com')"
		}
		@{
			"@odata.type" = "Microsoft.Graph.Beta.aadUserConversationMember"
			Roles = @(
				"owner"
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('alex@contoso.com')"
		}
	)
}

Add-MgBetaTeamMember -TeamId $teamId -BodyParameter $params
```

This example shows how to use the Add-MgBetaTeamChannelMember Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: AddExpanded1, AddViaIdentityExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1Rl53M1TeamsTeamIdChannelsChannelIdMembersMicrosoftGraphAddPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Add1, AddViaIdentity1
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
Parameter Sets: Add1, AddExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity
Parameter Sets: AddViaIdentity1, AddViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -TeamId
key: id of team

```yaml
Type: System.String
Parameter Sets: Add1, AddExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Values
.
To construct, please use Get-Help -Online and see NOTES section for VALUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConversationMember[]
Parameter Sets: AddExpanded1, AddViaIdentityExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1Rl53M1TeamsTeamIdChannelsChannelIdMembersMicrosoftGraphAddPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphActionResultPart

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Rl53M1TeamsTeamIdChannelsChannelIdMembersMicrosoftGraphAddPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Values <IMicrosoftGraphConversationMember[]>]`: 
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

VALUES <IMicrosoftGraphConversationMember[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name of the user.
  - `[Roles <String[]>]`: The roles for that user. This property only contains additional qualifiers when relevant - for example, if the member has owner privileges, the roles property contains owner as one of the values. Similarly, if the member is a guest, the roles property contains guest as one of the values. A basic member should not have any values specified in the roles property.
  - `[VisibleHistoryStartDateTime <DateTime?>]`: The timestamp denoting how far back a conversation's history is shared with the conversation member. This property is settable only for members of a chat.

## RELATED LINKS

