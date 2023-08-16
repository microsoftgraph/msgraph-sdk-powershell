---
external help file:
Module Name: Microsoft.Graph.Beta.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.teams/update-mgbetateamscheduletimecard
schema: 2.0.0
---

# Update-MgBetaTeamScheduleTimeCard

## SYNOPSIS
Replace an existing timeCard with updated values.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTeamScheduleTimeCard -TeamId <String> -TimeCardId <String> [-AdditionalProperties <Hashtable>]
 [-Breaks <IMicrosoftGraphTimeCardBreak[]>] [-ClockInEvent <IMicrosoftGraphTimeCardEvent>]
 [-ClockOutEvent <IMicrosoftGraphTimeCardEvent>] [-ConfirmedBy <String>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-Notes <IMicrosoftGraphItemBody>] [-OriginalEntry <IMicrosoftGraphTimeCardEntry>] [-State <String>]
 [-UserId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaTeamScheduleTimeCard -TeamId <String> -TimeCardId <String>
 -BodyParameter <IMicrosoftGraphTimeCard> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaTeamScheduleTimeCard -InputObject <ITeamsIdentity> -BodyParameter <IMicrosoftGraphTimeCard>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaTeamScheduleTimeCard -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-Breaks <IMicrosoftGraphTimeCardBreak[]>] [-ClockInEvent <IMicrosoftGraphTimeCardEvent>]
 [-ClockOutEvent <IMicrosoftGraphTimeCardEvent>] [-ConfirmedBy <String>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-Notes <IMicrosoftGraphItemBody>] [-OriginalEntry <IMicrosoftGraphTimeCardEntry>] [-State <String>]
 [-UserId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Replace an existing timeCard with updated values.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
timeCard
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeCard
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Breaks
The list of breaks associated with the timeCard.
To construct, see NOTES section for BREAKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeCardBreak[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClockInEvent
timeCardEvent
To construct, see NOTES section for CLOCKINEVENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeCardEvent
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClockOutEvent
timeCardEvent
To construct, see NOTES section for CLOCKOUTEVENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeCardEvent
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConfirmedBy
confirmedBy

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Notes
itemBody
To construct, see NOTES section for NOTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphItemBody
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OriginalEntry
timeCardEntry
To construct, see NOTES section for ORIGINALENTRY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeCardEntry
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
timeCardState

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamId
The unique identifier of team

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeCardId
The unique identifier of timeCard

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
User ID to which the timeCard belongs.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeCard

### Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeCard

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphTimeCard>`: timeCard
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Breaks <IMicrosoftGraphTimeCardBreak[]>]`: The list of breaks associated with the timeCard.
    - `[BreakId <String>]`: ID of the timeCardBreak.
    - `[End <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AtApprovedLocation <Boolean?>]`: Indicates whether the entry was recorded at the approved location.
      - `[DateTime <DateTime?>]`: The time the entry is recorded.
      - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Content <String>]`: The content of the item.
        - `[ContentType <String>]`: bodyType
    - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
    - `[Start <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
  - `[ClockInEvent <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
  - `[ClockOutEvent <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
  - `[ConfirmedBy <String>]`: confirmedBy
  - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
  - `[OriginalEntry <IMicrosoftGraphTimeCardEntry>]`: timeCardEntry
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Breaks <IMicrosoftGraphTimeCardBreak[]>]`: The list of breaks associated with the timeCard.
    - `[ClockInEvent <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
    - `[ClockOutEvent <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
  - `[State <String>]`: timeCardState
  - `[UserId <String>]`: User ID to which  the timeCard belongs.

`BREAKS <IMicrosoftGraphTimeCardBreak[]>`: The list of breaks associated with the timeCard.
  - `[BreakId <String>]`: ID of the timeCardBreak.
  - `[End <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AtApprovedLocation <Boolean?>]`: Indicates whether the entry was recorded at the approved location.
    - `[DateTime <DateTime?>]`: The time the entry is recorded.
    - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
  - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
  - `[Start <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent

`CLOCKINEVENT <IMicrosoftGraphTimeCardEvent>`: timeCardEvent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AtApprovedLocation <Boolean?>]`: Indicates whether the entry was recorded at the approved location.
  - `[DateTime <DateTime?>]`: The time the entry is recorded.
  - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType

`CLOCKOUTEVENT <IMicrosoftGraphTimeCardEvent>`: timeCardEvent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AtApprovedLocation <Boolean?>]`: Indicates whether the entry was recorded at the approved location.
  - `[DateTime <DateTime?>]`: The time the entry is recorded.
  - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType

`CREATEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`INPUTOBJECT <ITeamsIdentity>`: Identity Parameter
  - `[AssociatedTeamInfoId <String>]`: The unique identifier of associatedTeamInfo
  - `[ChannelId <String>]`: The unique identifier of channel
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageHostedContentId <String>]`: The unique identifier of chatMessageHostedContent
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[ChatMessageId1 <String>]`: The unique identifier of chatMessage
  - `[ConversationMemberId <String>]`: The unique identifier of conversationMember
  - `[DeletedChatId <String>]`: The unique identifier of deletedChat
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

`LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`NOTES <IMicrosoftGraphItemBody>`: itemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: The content of the item.
  - `[ContentType <String>]`: bodyType

`ORIGINALENTRY <IMicrosoftGraphTimeCardEntry>`: timeCardEntry
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Breaks <IMicrosoftGraphTimeCardBreak[]>]`: The list of breaks associated with the timeCard.
    - `[BreakId <String>]`: ID of the timeCardBreak.
    - `[End <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AtApprovedLocation <Boolean?>]`: Indicates whether the entry was recorded at the approved location.
      - `[DateTime <DateTime?>]`: The time the entry is recorded.
      - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Content <String>]`: The content of the item.
        - `[ContentType <String>]`: bodyType
    - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
    - `[Start <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
  - `[ClockInEvent <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
  - `[ClockOutEvent <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent

## RELATED LINKS

