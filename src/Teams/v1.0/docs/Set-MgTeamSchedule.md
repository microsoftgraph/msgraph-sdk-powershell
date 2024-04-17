---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.teams/set-mgteamschedule
schema: 2.0.0
---

# Set-MgTeamSchedule

## SYNOPSIS
Update the navigation property schedule in teams

## SYNTAX

### SetExpanded (Default)
```
Set-MgTeamSchedule -TeamId <String> [-AdditionalProperties <Hashtable>] [-Enabled] [-Id <String>]
 [-OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>] [-OfferShiftRequestsEnabled]
 [-OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]
 [-OpenShifts <IMicrosoftGraphOpenShift[]>] [-OpenShiftsEnabled] [-ProvisionStatus <String>]
 [-ResponseHeadersVariable <String>] [-SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]
 [-Shifts <IMicrosoftGraphShift[]>] [-SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]
 [-SwapShiftsRequestsEnabled] [-TimeClockEnabled] [-TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]
 [-TimeOffRequests <IMicrosoftGraphTimeOffRequest[]>] [-TimeOffRequestsEnabled]
 [-TimesOff <IMicrosoftGraphTimeOff[]>] [-TimeZone <String>] [-WorkforceIntegrationIds <String[]>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-MgTeamSchedule -TeamId <String> -BodyParameter <IMicrosoftGraphSchedule>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-MgTeamSchedule -InputObject <ITeamsIdentity> -BodyParameter <IMicrosoftGraphSchedule>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-MgTeamSchedule -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>] [-Enabled] [-Id <String>]
 [-OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>] [-OfferShiftRequestsEnabled]
 [-OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]
 [-OpenShifts <IMicrosoftGraphOpenShift[]>] [-OpenShiftsEnabled] [-ProvisionStatus <String>]
 [-ResponseHeadersVariable <String>] [-SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]
 [-Shifts <IMicrosoftGraphShift[]>] [-SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]
 [-SwapShiftsRequestsEnabled] [-TimeClockEnabled] [-TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]
 [-TimeOffRequests <IMicrosoftGraphTimeOffRequest[]>] [-TimeOffRequestsEnabled]
 [-TimesOff <IMicrosoftGraphTimeOff[]>] [-TimeZone <String>] [-WorkforceIntegrationIds <String[]>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property schedule in teams

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
schedule
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchedule
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Enabled
Indicates whether the schedule is enabled for the team.
Required.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OfferShiftRequests
The offer requests for shifts in the schedule.
To construct, see NOTES section for OFFERSHIFTREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfferShiftRequest[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OfferShiftRequestsEnabled
Indicates whether offer shift requests are enabled for the schedule.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OpenShiftChangeRequests
The open shift requests in the schedule.
To construct, see NOTES section for OPENSHIFTCHANGEREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOpenShiftChangeRequest[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OpenShifts
The set of open shifts in a scheduling group in the schedule.
To construct, see NOTES section for OPENSHIFTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOpenShift[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OpenShiftsEnabled
Indicates whether open shifts are enabled for the schedule.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProvisionStatus
operationStatus

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchedulingGroups
The logical grouping of users in the schedule (usually by role).
To construct, see NOTES section for SCHEDULINGGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchedulingGroup[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Shifts
The shifts in the schedule.
To construct, see NOTES section for SHIFTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShift[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SwapShiftsChangeRequests
The swap requests for shifts in the schedule.
To construct, see NOTES section for SWAPSHIFTSCHANGEREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSwapShiftsChangeRequest[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SwapShiftsRequestsEnabled
Indicates whether swap shifts requests are enabled for the schedule.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: Set, SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeClockEnabled
Indicates whether time clock is enabled for the schedule.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeOffReasons
The set of reasons for a time off in the schedule.
To construct, see NOTES section for TIMEOFFREASONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTimeOffReason[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeOffRequests
The time off requests in the schedule.
To construct, see NOTES section for TIMEOFFREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTimeOffRequest[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeOffRequestsEnabled
Indicates whether time off requests are enabled for the schedule.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimesOff
The instances of times off in the schedule.
To construct, see NOTES section for TIMESOFF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTimeOff[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeZone
Indicates the time zone of the schedule team using tz database format.
Required.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkforceIntegrationIds
.

```yaml
Type: System.String[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchedule

### Microsoft.Graph.PowerShell.Models.ITeamsIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchedule

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSchedule>`: schedule
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Enabled <Boolean?>]`: Indicates whether the schedule is enabled for the team. Required.
  - `[OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>]`: The offer requests for shifts in the schedule.
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionMessage <String>]`: 
    - `[SenderMessage <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
    - `[RecipientUserId <String>]`: User ID of the recipient of the offer shift request.
    - `[SenderShiftId <String>]`: User ID of the sender of the offer shift request.
  - `[OfferShiftRequestsEnabled <Boolean?>]`: Indicates whether offer shift requests are enabled for the schedule.
  - `[OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]`: The open shift requests in the schedule.
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionMessage <String>]`: 
    - `[SenderMessage <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[OpenShiftId <String>]`: ID for the open shift.
  - `[OpenShifts <IMicrosoftGraphOpenShift[]>]`: The set of open shifts in a scheduling group in the schedule.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DraftOpenShift <IMicrosoftGraphOpenShiftItem>]`: openShiftItem
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Activities <IMicrosoftGraphShiftActivity[]>]`: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
        - `[Code <String>]`: Customer defined code for the shiftActivity. Required.
        - `[DisplayName <String>]`: The name of the shiftActivity. Required.
        - `[EndDateTime <DateTime?>]`: The end date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
        - `[IsPaid <Boolean?>]`: Indicates whether the microsoft.graph.user should be paid for the activity during their shift. Required.
        - `[StartDateTime <DateTime?>]`: The start date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
        - `[Theme <String>]`: scheduleEntityTheme
      - `[DisplayName <String>]`: The shift label of the shiftItem.
      - `[Notes <String>]`: The shift notes for the shiftItem.
      - `[EndDateTime <DateTime?>]`: 
      - `[StartDateTime <DateTime?>]`: 
      - `[Theme <String>]`: scheduleEntityTheme
      - `[OpenSlotCount <Int32?>]`: Count of the number of slots for the given open shift.
    - `[SchedulingGroupId <String>]`: ID for the scheduling group that the open shift belongs to.
    - `[SharedOpenShift <IMicrosoftGraphOpenShiftItem>]`: openShiftItem
  - `[OpenShiftsEnabled <Boolean?>]`: Indicates whether open shifts are enabled for the schedule.
  - `[ProvisionStatus <String>]`: operationStatus
  - `[SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]`: The logical grouping of users in the schedule (usually by role).
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: The display name for the schedulingGroup. Required.
    - `[UserIds <String[]>]`: The list of user IDs that are a member of the schedulingGroup. Required.
  - `[Shifts <IMicrosoftGraphShift[]>]`: The shifts in the schedule.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DraftShift <IMicrosoftGraphShiftItem>]`: shiftItem
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EndDateTime <DateTime?>]`: 
      - `[StartDateTime <DateTime?>]`: 
      - `[Theme <String>]`: scheduleEntityTheme
      - `[Activities <IMicrosoftGraphShiftActivity[]>]`: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
      - `[DisplayName <String>]`: The shift label of the shiftItem.
      - `[Notes <String>]`: The shift notes for the shiftItem.
    - `[SchedulingGroupId <String>]`: ID of the scheduling group the shift is part of. Required.
    - `[SharedShift <IMicrosoftGraphShiftItem>]`: shiftItem
    - `[UserId <String>]`: ID of the user assigned to the shift. Required.
  - `[SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]`: The swap requests for shifts in the schedule.
    - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
    - `[RecipientUserId <String>]`: User ID of the recipient of the offer shift request.
    - `[SenderShiftId <String>]`: User ID of the sender of the offer shift request.
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionMessage <String>]`: 
    - `[SenderMessage <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[RecipientShiftId <String>]`: ShiftId for the recipient user with whom the request is to swap.
  - `[SwapShiftsRequestsEnabled <Boolean?>]`: Indicates whether swap shifts requests are enabled for the schedule.
  - `[TimeClockEnabled <Boolean?>]`: Indicates whether time clock is enabled for the schedule.
  - `[TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]`: The set of reasons for a time off in the schedule.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: The name of the timeOffReason. Required.
    - `[IconType <String>]`: timeOffReasonIconType
    - `[IsActive <Boolean?>]`: Indicates whether the timeOffReason can be used when creating new entities or updating existing ones. Required.
  - `[TimeOffRequests <IMicrosoftGraphTimeOffRequest[]>]`: The time off requests in the schedule.
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionMessage <String>]`: 
    - `[SenderMessage <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[EndDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[TimeOffReasonId <String>]`: The reason for the time off.
  - `[TimeOffRequestsEnabled <Boolean?>]`: Indicates whether time off requests are enabled for the schedule.
  - `[TimeZone <String>]`: Indicates the time zone of the schedule team using tz database format. Required.
  - `[TimesOff <IMicrosoftGraphTimeOff[]>]`: The instances of times off in the schedule.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DraftTimeOff <IMicrosoftGraphTimeOffItem>]`: timeOffItem
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EndDateTime <DateTime?>]`: 
      - `[StartDateTime <DateTime?>]`: 
      - `[Theme <String>]`: scheduleEntityTheme
      - `[TimeOffReasonId <String>]`: ID of the timeOffReason for this timeOffItem. Required.
    - `[SharedTimeOff <IMicrosoftGraphTimeOffItem>]`: timeOffItem
    - `[UserId <String>]`: ID of the user assigned to the timeOff. Required.
  - `[WorkforceIntegrationIds <String[]>]`: 

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

`OFFERSHIFTREQUESTS <IMicrosoftGraphOfferShiftRequest[]>`: The offer requests for shifts in the schedule.
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionMessage <String>]`: 
  - `[SenderMessage <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
  - `[RecipientUserId <String>]`: User ID of the recipient of the offer shift request.
  - `[SenderShiftId <String>]`: User ID of the sender of the offer shift request.

`OPENSHIFTCHANGEREQUESTS <IMicrosoftGraphOpenShiftChangeRequest[]>`: The open shift requests in the schedule.
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionMessage <String>]`: 
  - `[SenderMessage <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[OpenShiftId <String>]`: ID for the open shift.

`OPENSHIFTS <IMicrosoftGraphOpenShift[]>`: The set of open shifts in a scheduling group in the schedule.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DraftOpenShift <IMicrosoftGraphOpenShiftItem>]`: openShiftItem
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Activities <IMicrosoftGraphShiftActivity[]>]`: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
      - `[Code <String>]`: Customer defined code for the shiftActivity. Required.
      - `[DisplayName <String>]`: The name of the shiftActivity. Required.
      - `[EndDateTime <DateTime?>]`: The end date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
      - `[IsPaid <Boolean?>]`: Indicates whether the microsoft.graph.user should be paid for the activity during their shift. Required.
      - `[StartDateTime <DateTime?>]`: The start date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
      - `[Theme <String>]`: scheduleEntityTheme
    - `[DisplayName <String>]`: The shift label of the shiftItem.
    - `[Notes <String>]`: The shift notes for the shiftItem.
    - `[EndDateTime <DateTime?>]`: 
    - `[StartDateTime <DateTime?>]`: 
    - `[Theme <String>]`: scheduleEntityTheme
    - `[OpenSlotCount <Int32?>]`: Count of the number of slots for the given open shift.
  - `[SchedulingGroupId <String>]`: ID for the scheduling group that the open shift belongs to.
  - `[SharedOpenShift <IMicrosoftGraphOpenShiftItem>]`: openShiftItem

`SCHEDULINGGROUPS <IMicrosoftGraphSchedulingGroup[]>`: The logical grouping of users in the schedule (usually by role).
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name for the schedulingGroup. Required.
  - `[UserIds <String[]>]`: The list of user IDs that are a member of the schedulingGroup. Required.

`SHIFTS <IMicrosoftGraphShift[]>`: The shifts in the schedule.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DraftShift <IMicrosoftGraphShiftItem>]`: shiftItem
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EndDateTime <DateTime?>]`: 
    - `[StartDateTime <DateTime?>]`: 
    - `[Theme <String>]`: scheduleEntityTheme
    - `[Activities <IMicrosoftGraphShiftActivity[]>]`: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
      - `[Code <String>]`: Customer defined code for the shiftActivity. Required.
      - `[DisplayName <String>]`: The name of the shiftActivity. Required.
      - `[EndDateTime <DateTime?>]`: The end date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
      - `[IsPaid <Boolean?>]`: Indicates whether the microsoft.graph.user should be paid for the activity during their shift. Required.
      - `[StartDateTime <DateTime?>]`: The start date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
      - `[Theme <String>]`: scheduleEntityTheme
    - `[DisplayName <String>]`: The shift label of the shiftItem.
    - `[Notes <String>]`: The shift notes for the shiftItem.
  - `[SchedulingGroupId <String>]`: ID of the scheduling group the shift is part of. Required.
  - `[SharedShift <IMicrosoftGraphShiftItem>]`: shiftItem
  - `[UserId <String>]`: ID of the user assigned to the shift. Required.

`SWAPSHIFTSCHANGEREQUESTS <IMicrosoftGraphSwapShiftsChangeRequest[]>`: The swap requests for shifts in the schedule.
  - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
  - `[RecipientUserId <String>]`: User ID of the recipient of the offer shift request.
  - `[SenderShiftId <String>]`: User ID of the sender of the offer shift request.
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionMessage <String>]`: 
  - `[SenderMessage <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[RecipientShiftId <String>]`: ShiftId for the recipient user with whom the request is to swap.

`TIMEOFFREASONS <IMicrosoftGraphTimeOffReason[]>`: The set of reasons for a time off in the schedule.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The name of the timeOffReason. Required.
  - `[IconType <String>]`: timeOffReasonIconType
  - `[IsActive <Boolean?>]`: Indicates whether the timeOffReason can be used when creating new entities or updating existing ones. Required.

`TIMEOFFREQUESTS <IMicrosoftGraphTimeOffRequest[]>`: The time off requests in the schedule.
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionMessage <String>]`: 
  - `[SenderMessage <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[EndDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[TimeOffReasonId <String>]`: The reason for the time off.

`TIMESOFF <IMicrosoftGraphTimeOff[]>`: The instances of times off in the schedule.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DraftTimeOff <IMicrosoftGraphTimeOffItem>]`: timeOffItem
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EndDateTime <DateTime?>]`: 
    - `[StartDateTime <DateTime?>]`: 
    - `[Theme <String>]`: scheduleEntityTheme
    - `[TimeOffReasonId <String>]`: ID of the timeOffReason for this timeOffItem. Required.
  - `[SharedTimeOff <IMicrosoftGraphTimeOffItem>]`: timeOffItem
  - `[UserId <String>]`: ID of the user assigned to the timeOff. Required.

## RELATED LINKS

