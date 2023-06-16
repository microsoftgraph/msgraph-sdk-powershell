---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.teams/update-mgteamoperation
schema: 2.0.0
---

# Update-MgTeamOperation

## SYNOPSIS
Update the navigation property operations in teams

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTeamOperation -TeamId <String> -TeamsAsyncOperationId <String> [-AdditionalProperties <Hashtable>]
 [-AttemptsCount <Int32>] [-CreatedDateTime <DateTime>] [-Error <IMicrosoftGraphOperationError>]
 [-Id <String>] [-LastActionDateTime <DateTime>] [-OperationType <String>] [-Status <String>]
 [-TargetResourceId <String>] [-TargetResourceLocation <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTeamOperation -TeamId <String> -TeamsAsyncOperationId <String>
 -BodyParameter <IMicrosoftGraphTeamsAsyncOperation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTeamOperation -InputObject <ITeamsIdentity> -BodyParameter <IMicrosoftGraphTeamsAsyncOperation>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTeamOperation -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-AttemptsCount <Int32>] [-CreatedDateTime <DateTime>] [-Error <IMicrosoftGraphOperationError>]
 [-Id <String>] [-LastActionDateTime <DateTime>] [-OperationType <String>] [-Status <String>]
 [-TargetResourceId <String>] [-TargetResourceLocation <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property operations in teams

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

### -AttemptsCount
Number of times the operation was attempted before being marked successful or failed.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
teamsAsyncOperation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAsyncOperation
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Time when the operation was created.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Error
operationError
To construct, see NOTES section for ERROR properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOperationError
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.ITeamsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastActionDateTime
Time when the async operation was last updated.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OperationType
teamsAsyncOperationType

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

### -Status
teamsAsyncOperationStatus

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

### -TargetResourceId
The ID of the object that's created or modified as result of this async operation, typically a team.

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

### -TargetResourceLocation
The location of the object that's created or modified as result of this async operation.
This URL should be treated as an opaque value and not parsed into its component paths.

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

### -TeamsAsyncOperationId
The unique identifier of teamsAsyncOperation

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAsyncOperation

### Microsoft.Graph.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAsyncOperation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphTeamsAsyncOperation>`: teamsAsyncOperation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AttemptsCount <Int32?>]`: Number of times the operation was attempted before being marked successful or failed.
  - `[CreatedDateTime <DateTime?>]`: Time when the operation was created.
  - `[Error <IMicrosoftGraphOperationError>]`: operationError
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <String>]`: Operation error code.
    - `[Message <String>]`: Operation error message.
  - `[LastActionDateTime <DateTime?>]`: Time when the async operation was last updated.
  - `[OperationType <String>]`: teamsAsyncOperationType
  - `[Status <String>]`: teamsAsyncOperationStatus
  - `[TargetResourceId <String>]`: The ID of the object that's created or modified as result of this async operation, typically a team.
  - `[TargetResourceLocation <String>]`: The location of the object that's created or modified as result of this async operation. This URL should be treated as an opaque value and not parsed into its component paths.

`ERROR <IMicrosoftGraphOperationError>`: operationError
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Code <String>]`: Operation error code.
  - `[Message <String>]`: Operation error message.

`INPUTOBJECT <ITeamsIdentity>`: Identity Parameter
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
  - `[SchedulingGroupId <String>]`: The unique identifier of schedulingGroup
  - `[SharedWithChannelTeamInfoId <String>]`: The unique identifier of sharedWithChannelTeamInfo
  - `[ShiftId <String>]`: The unique identifier of shift
  - `[SwapShiftsChangeRequestId <String>]`: The unique identifier of swapShiftsChangeRequest
  - `[TeamId <String>]`: The unique identifier of team
  - `[TeamsAppDefinitionId <String>]`: The unique identifier of teamsAppDefinition
  - `[TeamsAppId <String>]`: The unique identifier of teamsApp
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TeamsAsyncOperationId <String>]`: The unique identifier of teamsAsyncOperation
  - `[TeamsTabId <String>]`: The unique identifier of teamsTab
  - `[TeamworkTagId <String>]`: The unique identifier of teamworkTag
  - `[TeamworkTagMemberId <String>]`: The unique identifier of teamworkTagMember
  - `[TimeOffId <String>]`: The unique identifier of timeOff
  - `[TimeOffReasonId <String>]`: The unique identifier of timeOffReason
  - `[TimeOffRequestId <String>]`: The unique identifier of timeOffRequest
  - `[UserId <String>]`: The unique identifier of user
  - `[UserScopeTeamsAppInstallationId <String>]`: The unique identifier of userScopeTeamsAppInstallation
  - `[WorkforceIntegrationId <String>]`: The unique identifier of workforceIntegration

## RELATED LINKS

