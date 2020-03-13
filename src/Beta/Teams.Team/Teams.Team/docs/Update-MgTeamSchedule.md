---
external help file:
Module Name: Microsoft.Graph.Teams.Team
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.team/update-mgteamschedule
schema: 2.0.0
---

# Update-MgTeamSchedule

## SYNOPSIS
Update the navigation property schedule in teams

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTeamSchedule -TeamId <String> [-Enabled] [-Id <String>]
 [-OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>] [-OfferShiftRequestsEnabled]
 [-OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]
 [-OpenShifts <IMicrosoftGraphOpenShift[]>] [-OpenShiftsEnabled] [-ProvisionStatus <String>]
 [-ProvisionStatusCode <String>] [-SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]
 [-Shifts <IMicrosoftGraphShift[]>] [-SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]
 [-SwapShiftsRequestsEnabled] [-TimeClockEnabled] [-TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]
 [-TimeOffRequests <IMicrosoftGraphTimeOffRequest[]>] [-TimeOffRequestsEnabled]
 [-TimesOff <IMicrosoftGraphTimeOff[]>] [-TimeZone <String>] [-WorkforceIntegrationIds <String[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTeamSchedule -TeamId <String> -BodyParameter <IMicrosoftGraphSchedule> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTeamSchedule -InputObject <ITeamsTeamIdentity> -BodyParameter <IMicrosoftGraphSchedule> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTeamSchedule -InputObject <ITeamsTeamIdentity> [-Enabled] [-Id <String>]
 [-OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>] [-OfferShiftRequestsEnabled]
 [-OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]
 [-OpenShifts <IMicrosoftGraphOpenShift[]>] [-OpenShiftsEnabled] [-ProvisionStatus <String>]
 [-ProvisionStatusCode <String>] [-SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]
 [-Shifts <IMicrosoftGraphShift[]>] [-SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]
 [-SwapShiftsRequestsEnabled] [-TimeClockEnabled] [-TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]
 [-TimeOffRequests <IMicrosoftGraphTimeOffRequest[]>] [-TimeOffRequestsEnabled]
 [-TimesOff <IMicrosoftGraphTimeOff[]>] [-TimeZone <String>] [-WorkforceIntegrationIds <String[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property schedule in teams

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

### -BodyParameter
schedule
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchedule
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Enabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
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
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -OfferShiftRequests
.
To construct, see NOTES section for OFFERSHIFTREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfferShiftRequest[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OfferShiftRequestsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OpenShiftChangeRequests
.
To construct, see NOTES section for OPENSHIFTCHANGEREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOpenShiftChangeRequest[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OpenShifts
.
To construct, see NOTES section for OPENSHIFTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOpenShift[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OpenShiftsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -ProvisionStatus
operationStatus

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProvisionStatusCode
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SchedulingGroups
.
To construct, see NOTES section for SCHEDULINGGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchedulingGroup[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Shifts
.
To construct, see NOTES section for SHIFTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShift[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SwapShiftsChangeRequests
.
To construct, see NOTES section for SWAPSHIFTSCHANGEREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSwapShiftsChangeRequest[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SwapShiftsRequestsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TeamId
key: team-id of team

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TimeClockEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TimeOffReasons
.
To construct, see NOTES section for TIMEOFFREASONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTimeOffReason[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TimeOffRequests
.
To construct, see NOTES section for TIMEOFFREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTimeOffRequest[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TimeOffRequestsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TimesOff
.
To construct, see NOTES section for TIMESOFF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTimeOff[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TimeZone
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WorkforceIntegrationIds
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchedule

### Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphSchedule>: schedule
  - `[Id <String>]`: Read-only.
  - `[Enabled <Boolean?>]`: 
  - `[OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>]`: 
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionDateTime <DateTime?>]`: 
    - `[ManagerActionMessage <String>]`: 
    - `[ManagerUserId <String>]`: 
    - `[SenderDateTime <DateTime?>]`: 
    - `[SenderMessage <String>]`: 
    - `[SenderUserId <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[RecipientActionDateTime <DateTime?>]`: 
    - `[RecipientActionMessage <String>]`: 
    - `[RecipientUserId <String>]`: 
    - `[SenderShiftId <String>]`: 
  - `[OfferShiftRequestsEnabled <Boolean?>]`: 
  - `[OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]`: 
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionDateTime <DateTime?>]`: 
    - `[ManagerActionMessage <String>]`: 
    - `[ManagerUserId <String>]`: 
    - `[SenderDateTime <DateTime?>]`: 
    - `[SenderMessage <String>]`: 
    - `[SenderUserId <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[OpenShiftId <String>]`: 
  - `[OpenShifts <IMicrosoftGraphOpenShift[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[DraftOpenShiftActivities <IMicrosoftGraphShiftActivity[]>]`: 
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[EndDateTime <DateTime?>]`: 
      - `[IsPaid <Boolean?>]`: 
      - `[StartDateTime <DateTime?>]`: 
      - `[Theme <String>]`: scheduleEntityTheme
    - `[DraftOpenShiftDisplayName <String>]`: 
    - `[DraftOpenShiftEndDateTime <DateTime?>]`: 
    - `[DraftOpenShiftNotes <String>]`: 
    - `[DraftOpenShiftOpenSlotCount <Int32?>]`: 
    - `[DraftOpenShiftStartDateTime <DateTime?>]`: 
    - `[DraftOpenShiftTheme <String>]`: scheduleEntityTheme
    - `[SchedulingGroupId <String>]`: 
    - `[SharedOpenShiftActivities <IMicrosoftGraphShiftActivity[]>]`: 
    - `[SharedOpenShiftDisplayName <String>]`: 
    - `[SharedOpenShiftEndDateTime <DateTime?>]`: 
    - `[SharedOpenShiftNotes <String>]`: 
    - `[SharedOpenShiftOpenSlotCount <Int32?>]`: 
    - `[SharedOpenShiftStartDateTime <DateTime?>]`: 
    - `[SharedOpenShiftTheme <String>]`: scheduleEntityTheme
  - `[OpenShiftsEnabled <Boolean?>]`: 
  - `[ProvisionStatus <String>]`: operationStatus
  - `[ProvisionStatusCode <String>]`: 
  - `[SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[IsActive <Boolean?>]`: 
    - `[UserIds <String[]>]`: 
  - `[Shifts <IMicrosoftGraphShift[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[DraftShiftActivities <IMicrosoftGraphShiftActivity[]>]`: 
    - `[DraftShiftDisplayName <String>]`: 
    - `[DraftShiftEndDateTime <DateTime?>]`: 
    - `[DraftShiftNotes <String>]`: 
    - `[DraftShiftStartDateTime <DateTime?>]`: 
    - `[DraftShiftTheme <String>]`: scheduleEntityTheme
    - `[SchedulingGroupId <String>]`: 
    - `[SharedShiftActivities <IMicrosoftGraphShiftActivity[]>]`: 
    - `[SharedShiftDisplayName <String>]`: 
    - `[SharedShiftEndDateTime <DateTime?>]`: 
    - `[SharedShiftNotes <String>]`: 
    - `[SharedShiftStartDateTime <DateTime?>]`: 
    - `[SharedShiftTheme <String>]`: scheduleEntityTheme
    - `[UserId <String>]`: 
  - `[SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]`: 
    - `[RecipientActionDateTime <DateTime?>]`: 
    - `[RecipientActionMessage <String>]`: 
    - `[RecipientUserId <String>]`: 
    - `[SenderShiftId <String>]`: 
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionDateTime <DateTime?>]`: 
    - `[ManagerActionMessage <String>]`: 
    - `[ManagerUserId <String>]`: 
    - `[SenderDateTime <DateTime?>]`: 
    - `[SenderMessage <String>]`: 
    - `[SenderUserId <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[RecipientShiftId <String>]`: 
  - `[SwapShiftsRequestsEnabled <Boolean?>]`: 
  - `[TimeClockEnabled <Boolean?>]`: 
  - `[TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[IconType <String>]`: timeOffReasonIconType
    - `[IsActive <Boolean?>]`: 
  - `[TimeOffRequests <IMicrosoftGraphTimeOffRequest[]>]`: 
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionDateTime <DateTime?>]`: 
    - `[ManagerActionMessage <String>]`: 
    - `[ManagerUserId <String>]`: 
    - `[SenderDateTime <DateTime?>]`: 
    - `[SenderMessage <String>]`: 
    - `[SenderUserId <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[EndDateTime <DateTime?>]`: 
    - `[StartDateTime <DateTime?>]`: 
    - `[TimeOffReasonId <String>]`: 
  - `[TimeOffRequestsEnabled <Boolean?>]`: 
  - `[TimeZone <String>]`: 
  - `[TimesOff <IMicrosoftGraphTimeOff[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[DraftTimeOffEndDateTime <DateTime?>]`: 
    - `[DraftTimeOffReasonId <String>]`: 
    - `[DraftTimeOffStartDateTime <DateTime?>]`: 
    - `[DraftTimeOffTheme <String>]`: scheduleEntityTheme
    - `[SharedTimeOffEndDateTime <DateTime?>]`: 
    - `[SharedTimeOffReasonId <String>]`: 
    - `[SharedTimeOffStartDateTime <DateTime?>]`: 
    - `[SharedTimeOffTheme <String>]`: scheduleEntityTheme
    - `[UserId <String>]`: 
  - `[WorkforceIntegrationIds <String[]>]`: 

#### INPUTOBJECT <ITeamsTeamIdentity>: Identity Parameter
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
  - `[TeamsCatalogAppId <String>]`: key: teamsCatalogApp-id of teamsCatalogApp
  - `[TeamsTabId <String>]`: key: teamsTab-id of teamsTab
  - `[TeamsTemplateId <String>]`: key: teamsTemplate-id of teamsTemplate
  - `[TimeOffId <String>]`: key: timeOff-id of timeOff
  - `[TimeOffReasonId <String>]`: key: timeOffReason-id of timeOffReason
  - `[TimeOffRequestId <String>]`: key: timeOffRequest-id of timeOffRequest
  - `[UserId <String>]`: key: user-id of user
  - `[WorkforceIntegrationId <String>]`: key: workforceIntegration-id of workforceIntegration

#### OFFERSHIFTREQUESTS <IMicrosoftGraphOfferShiftRequest[]>: .
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionDateTime <DateTime?>]`: 
  - `[ManagerActionMessage <String>]`: 
  - `[ManagerUserId <String>]`: 
  - `[SenderDateTime <DateTime?>]`: 
  - `[SenderMessage <String>]`: 
  - `[SenderUserId <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[RecipientActionDateTime <DateTime?>]`: 
  - `[RecipientActionMessage <String>]`: 
  - `[RecipientUserId <String>]`: 
  - `[SenderShiftId <String>]`: 

#### OPENSHIFTCHANGEREQUESTS <IMicrosoftGraphOpenShiftChangeRequest[]>: .
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionDateTime <DateTime?>]`: 
  - `[ManagerActionMessage <String>]`: 
  - `[ManagerUserId <String>]`: 
  - `[SenderDateTime <DateTime?>]`: 
  - `[SenderMessage <String>]`: 
  - `[SenderUserId <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[OpenShiftId <String>]`: 

#### OPENSHIFTS <IMicrosoftGraphOpenShift[]>: .
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[DraftOpenShiftActivities <IMicrosoftGraphShiftActivity[]>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[EndDateTime <DateTime?>]`: 
    - `[IsPaid <Boolean?>]`: 
    - `[StartDateTime <DateTime?>]`: 
    - `[Theme <String>]`: scheduleEntityTheme
  - `[DraftOpenShiftDisplayName <String>]`: 
  - `[DraftOpenShiftEndDateTime <DateTime?>]`: 
  - `[DraftOpenShiftNotes <String>]`: 
  - `[DraftOpenShiftOpenSlotCount <Int32?>]`: 
  - `[DraftOpenShiftStartDateTime <DateTime?>]`: 
  - `[DraftOpenShiftTheme <String>]`: scheduleEntityTheme
  - `[SchedulingGroupId <String>]`: 
  - `[SharedOpenShiftActivities <IMicrosoftGraphShiftActivity[]>]`: 
  - `[SharedOpenShiftDisplayName <String>]`: 
  - `[SharedOpenShiftEndDateTime <DateTime?>]`: 
  - `[SharedOpenShiftNotes <String>]`: 
  - `[SharedOpenShiftOpenSlotCount <Int32?>]`: 
  - `[SharedOpenShiftStartDateTime <DateTime?>]`: 
  - `[SharedOpenShiftTheme <String>]`: scheduleEntityTheme

#### SCHEDULINGGROUPS <IMicrosoftGraphSchedulingGroup[]>: .
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[IsActive <Boolean?>]`: 
  - `[UserIds <String[]>]`: 

#### SHIFTS <IMicrosoftGraphShift[]>: .
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[DraftShiftActivities <IMicrosoftGraphShiftActivity[]>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[EndDateTime <DateTime?>]`: 
    - `[IsPaid <Boolean?>]`: 
    - `[StartDateTime <DateTime?>]`: 
    - `[Theme <String>]`: scheduleEntityTheme
  - `[DraftShiftDisplayName <String>]`: 
  - `[DraftShiftEndDateTime <DateTime?>]`: 
  - `[DraftShiftNotes <String>]`: 
  - `[DraftShiftStartDateTime <DateTime?>]`: 
  - `[DraftShiftTheme <String>]`: scheduleEntityTheme
  - `[SchedulingGroupId <String>]`: 
  - `[SharedShiftActivities <IMicrosoftGraphShiftActivity[]>]`: 
  - `[SharedShiftDisplayName <String>]`: 
  - `[SharedShiftEndDateTime <DateTime?>]`: 
  - `[SharedShiftNotes <String>]`: 
  - `[SharedShiftStartDateTime <DateTime?>]`: 
  - `[SharedShiftTheme <String>]`: scheduleEntityTheme
  - `[UserId <String>]`: 

#### SWAPSHIFTSCHANGEREQUESTS <IMicrosoftGraphSwapShiftsChangeRequest[]>: .
  - `[RecipientActionDateTime <DateTime?>]`: 
  - `[RecipientActionMessage <String>]`: 
  - `[RecipientUserId <String>]`: 
  - `[SenderShiftId <String>]`: 
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionDateTime <DateTime?>]`: 
  - `[ManagerActionMessage <String>]`: 
  - `[ManagerUserId <String>]`: 
  - `[SenderDateTime <DateTime?>]`: 
  - `[SenderMessage <String>]`: 
  - `[SenderUserId <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[RecipientShiftId <String>]`: 

#### TIMEOFFREASONS <IMicrosoftGraphTimeOffReason[]>: .
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[IconType <String>]`: timeOffReasonIconType
  - `[IsActive <Boolean?>]`: 

#### TIMEOFFREQUESTS <IMicrosoftGraphTimeOffRequest[]>: .
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionDateTime <DateTime?>]`: 
  - `[ManagerActionMessage <String>]`: 
  - `[ManagerUserId <String>]`: 
  - `[SenderDateTime <DateTime?>]`: 
  - `[SenderMessage <String>]`: 
  - `[SenderUserId <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[EndDateTime <DateTime?>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[TimeOffReasonId <String>]`: 

#### TIMESOFF <IMicrosoftGraphTimeOff[]>: .
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[DraftTimeOffEndDateTime <DateTime?>]`: 
  - `[DraftTimeOffReasonId <String>]`: 
  - `[DraftTimeOffStartDateTime <DateTime?>]`: 
  - `[DraftTimeOffTheme <String>]`: scheduleEntityTheme
  - `[SharedTimeOffEndDateTime <DateTime?>]`: 
  - `[SharedTimeOffReasonId <String>]`: 
  - `[SharedTimeOffStartDateTime <DateTime?>]`: 
  - `[SharedTimeOffTheme <String>]`: scheduleEntityTheme
  - `[UserId <String>]`: 

## RELATED LINKS

