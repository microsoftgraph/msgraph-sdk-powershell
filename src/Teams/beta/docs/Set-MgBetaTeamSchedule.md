---
external help file:
Module Name: Microsoft.Graph.Beta.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.teams/set-mgbetateamschedule
schema: 2.0.0
---

# Set-MgBetaTeamSchedule

## SYNOPSIS
Update the navigation property schedule in teams

## SYNTAX

### SetExpanded (Default)
```
Set-MgBetaTeamSchedule -TeamId <String> [-ActivitiesIncludedWhenCopyingShiftsEnabled]
 [-AdditionalProperties <Hashtable>] [-DayNotes <IMicrosoftGraphDayNote[]>] [-Enabled] [-Id <String>]
 [-IsCrossLocationShiftRequestApprovalRequired] [-IsCrossLocationShiftsEnabled]
 [-OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>] [-OfferShiftRequestsEnabled]
 [-OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]
 [-OpenShifts <IMicrosoftGraphOpenShift[]>] [-OpenShiftsEnabled] [-ProvisionStatus <String>]
 [-ResponseHeadersVariable <String>] [-SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]
 [-Shifts <IMicrosoftGraphShift[]>] [-ShiftsRoleDefinitions <IMicrosoftGraphShiftsRoleDefinition[]>]
 [-StartDayOfWeek <String>] [-SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]
 [-SwapShiftsRequestsEnabled] [-TimeCards <IMicrosoftGraphTimeCard[]>] [-TimeClockEnabled]
 [-TimeClockSettings <IMicrosoftGraphTimeClockSettings>] [-TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]
 [-TimeOffRequests <IMicrosoftGraphTimeOffRequest[]>] [-TimeOffRequestsEnabled]
 [-TimesOff <IMicrosoftGraphTimeOff[]>] [-TimeZone <String>] [-WorkforceIntegrationIds <String[]>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-MgBetaTeamSchedule -TeamId <String> -BodyParameter <IMicrosoftGraphSchedule>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-MgBetaTeamSchedule -InputObject <ITeamsIdentity> -BodyParameter <IMicrosoftGraphSchedule>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-MgBetaTeamSchedule -InputObject <ITeamsIdentity> [-ActivitiesIncludedWhenCopyingShiftsEnabled]
 [-AdditionalProperties <Hashtable>] [-DayNotes <IMicrosoftGraphDayNote[]>] [-Enabled] [-Id <String>]
 [-IsCrossLocationShiftRequestApprovalRequired] [-IsCrossLocationShiftsEnabled]
 [-OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>] [-OfferShiftRequestsEnabled]
 [-OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]
 [-OpenShifts <IMicrosoftGraphOpenShift[]>] [-OpenShiftsEnabled] [-ProvisionStatus <String>]
 [-ResponseHeadersVariable <String>] [-SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]
 [-Shifts <IMicrosoftGraphShift[]>] [-ShiftsRoleDefinitions <IMicrosoftGraphShiftsRoleDefinition[]>]
 [-StartDayOfWeek <String>] [-SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]
 [-SwapShiftsRequestsEnabled] [-TimeCards <IMicrosoftGraphTimeCard[]>] [-TimeClockEnabled]
 [-TimeClockSettings <IMicrosoftGraphTimeClockSettings>] [-TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]
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

### -ActivitiesIncludedWhenCopyingShiftsEnabled
Indicates whether copied shifts should include the activities.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSchedule
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DayNotes
The day notes in the schedule.
To construct, see NOTES section for DAYNOTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDayNote[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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
Type: Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsCrossLocationShiftRequestApprovalRequired
Indicates whether approval is required by a manager of this schedule for cross location shift requests.

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

### -IsCrossLocationShiftsEnabled
Indicates whether the cross-location marketplace feature is enabled for this schedule.

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

### -OfferShiftRequests
The offer requests for shifts in the schedule.
To construct, see NOTES section for OFFERSHIFTREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOfferShiftRequest[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOpenShiftChangeRequest[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOpenShift[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSchedulingGroup[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphShift[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShiftsRoleDefinitions
The definitions of the roles in the schedule.
To construct, see NOTES section for SHIFTSROLEDEFINITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphShiftsRoleDefinition[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDayOfWeek
dayOfWeek

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

### -SwapShiftsChangeRequests
The swap requests for shifts in the schedule.
To construct, see NOTES section for SWAPSHIFTSCHANGEREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSwapShiftsChangeRequest[]
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

### -TimeCards
The time cards in the schedule.
To construct, see NOTES section for TIMECARDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeCard[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
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

### -TimeClockSettings
timeClockSettings
To construct, see NOTES section for TIMECLOCKSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeClockSettings
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeOffReason[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeOffRequest[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTimeOff[]
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
The IDs for the workforce integrations associated with this schedule.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSchedule

### Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSchedule

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSchedule>`: schedule
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActivitiesIncludedWhenCopyingShiftsEnabled <Boolean?>]`: Indicates whether copied shifts should include the activities.
  - `[DayNotes <IMicrosoftGraphDayNote[]>]`: The day notes in the schedule.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DayNoteDate <DateTime?>]`: The date of the day note.
    - `[DraftDayNote <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[SharedDayNote <IMicrosoftGraphItemBody>]`: itemBody
  - `[Enabled <Boolean?>]`: Indicates whether the schedule is enabled for the team. Required.
  - `[IsCrossLocationShiftRequestApprovalRequired <Boolean?>]`: Indicates whether approval is required by a manager of this schedule for cross location shift requests.
  - `[IsCrossLocationShiftsEnabled <Boolean?>]`: Indicates whether the cross-location marketplace feature is enabled for this schedule.
  - `[OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>]`: The offer requests for shifts in the schedule.
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionMessage <String>]`: 
    - `[SenderMessage <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
    - `[RecipientUserId <String>]`: User id of the recipient of the offer shift request.
    - `[SenderShiftId <String>]`: User id of the sender of the offer shift request.
  - `[OfferShiftRequestsEnabled <Boolean?>]`: Indicates whether offer shift requests are enabled for the schedule.
  - `[OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]`: The open shift requests in the schedule.
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionMessage <String>]`: 
    - `[SenderMessage <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[OpenShiftId <String>]`: ID for the open shift.
  - `[OpenShifts <IMicrosoftGraphOpenShift[]>]`: The set of open shifts in a scheduling group in the schedule.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
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
    - `[IsStagedForDeletion <Boolean?>]`: The openShift is marked for deletion, a process that is finalized when the schedule is shared.
    - `[SchedulingGroupId <String>]`: The ID of the schedulingGroup that contains the openShift.
    - `[SchedulingGroupInfo <IMicrosoftGraphSchedulingGroupInfo>]`: schedulingGroupInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: The code for the schedulingGroup.
      - `[DisplayName <String>]`: The display name for the schedulingGroup. Required.
      - `[SchedulingGroupId <String>]`: ID of the schedulingGroup.
    - `[SharedOpenShift <IMicrosoftGraphOpenShiftItem>]`: openShiftItem
    - `[TeamInfo <IMicrosoftGraphShiftsTeamInfo>]`: shiftsTeamInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name for the team. Required.
      - `[TeamId <String>]`: ID of the team.
  - `[OpenShiftsEnabled <Boolean?>]`: Indicates whether open shifts are enabled for the schedule.
  - `[ProvisionStatus <String>]`: operationStatus
  - `[SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]`: The logical grouping of users in the schedule (usually by role).
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Code <String>]`: The code for the schedulingGroup to represent an external identifier. This field must be unique within the team in Microsoft Teams and uses an alphanumeric format, with a maximum of 100 characters.
    - `[DisplayName <String>]`: The display name for the schedulingGroup. Required.
    - `[UserIds <String[]>]`: The list of user IDs that are a member of the schedulingGroup. Required.
  - `[Shifts <IMicrosoftGraphShift[]>]`: The shifts in the schedule.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
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
    - `[IsStagedForDeletion <Boolean?>]`: The shift is marked for deletion, a process that is finalized when the schedule is shared.
    - `[SchedulingGroupId <String>]`: ID of the scheduling group the shift is part of. Required.
    - `[SchedulingGroupInfo <IMicrosoftGraphSchedulingGroupInfo>]`: schedulingGroupInfo
    - `[SharedShift <IMicrosoftGraphShiftItem>]`: shiftItem
    - `[TeamInfo <IMicrosoftGraphShiftsTeamInfo>]`: shiftsTeamInfo
    - `[UserId <String>]`: ID of the user assigned to the shift. Required.
    - `[UserInfo <IMicrosoftGraphShiftsUserInfo>]`: shiftsUserInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name for the user. Required.
      - `[UserId <String>]`: ID of the user.
  - `[ShiftsRoleDefinitions <IMicrosoftGraphShiftsRoleDefinition[]>]`: The definitions of the roles in the schedule.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: The description of the role.
    - `[DisplayName <String>]`: The display name of the role.
    - `[ShiftsRolePermissions <IMicrosoftGraphShiftsRolePermission[]>]`: The collection of role permissions within the role.
      - `[AllowedResourceActions <String[]>]`: The permissions that are allowed for a role. Permissions that aren't in this collection are disabled.
  - `[StartDayOfWeek <String>]`: dayOfWeek
  - `[SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]`: The swap requests for shifts in the schedule.
    - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
    - `[RecipientUserId <String>]`: User id of the recipient of the offer shift request.
    - `[SenderShiftId <String>]`: User id of the sender of the offer shift request.
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionMessage <String>]`: 
    - `[SenderMessage <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[RecipientShiftId <String>]`: Shift ID for the recipient user with whom the request is to swap.
  - `[SwapShiftsRequestsEnabled <Boolean?>]`: Indicates whether swap shifts requests are enabled for the schedule.
  - `[TimeCards <IMicrosoftGraphTimeCard[]>]`: The time cards in the schedule.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Breaks <IMicrosoftGraphTimeCardBreak[]>]`: The list of breaks associated with the timeCard.
      - `[BreakId <String>]`: ID of the timeCardBreak.
      - `[End <IMicrosoftGraphTimeCardEvent>]`: timeCardEvent
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AtApprovedLocation <Boolean?>]`: Indicates whether the entry was recorded at the approved location.
        - `[DateTime <DateTime?>]`: The time the entry is recorded.
        - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
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
  - `[TimeClockEnabled <Boolean?>]`: Indicates whether time clock is enabled for the schedule.
  - `[TimeClockSettings <IMicrosoftGraphTimeClockSettings>]`: timeClockSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApprovedLocation <IMicrosoftGraphGeoCoordinates>]`: geoCoordinates
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Altitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
      - `[Latitude <Double?>]`: Optional. The latitude, in decimal, for the item. Writable on OneDrive Personal.
      - `[Longitude <Double?>]`: Optional. The longitude, in decimal, for the item. Writable on OneDrive Personal.
  - `[TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]`: The set of reasons for a time off in the schedule.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Code <String>]`: The code of the timeOffReason to represent an external identifier. This field must be unique within the team in Microsoft Teams and uses an alphanumeric format, with a maximum of 100 characters.
    - `[DisplayName <String>]`: The name of the timeOffReason. Required.
    - `[IconType <String>]`: timeOffReasonIconType
    - `[IsActive <Boolean?>]`: Indicates whether the timeOffReason can be used when creating new entities or updating existing ones. Required.
  - `[TimeOffRequests <IMicrosoftGraphTimeOffRequest[]>]`: The time off requests in the schedule.
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionMessage <String>]`: 
    - `[SenderMessage <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[EndDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[TimeOffReasonId <String>]`: The reason for the time off.
  - `[TimeOffRequestsEnabled <Boolean?>]`: Indicates whether time off requests are enabled for the schedule.
  - `[TimeZone <String>]`: Indicates the time zone of the schedule team using tz database format. Required.
  - `[TimesOff <IMicrosoftGraphTimeOff[]>]`: The instances of times off in the schedule.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DraftTimeOff <IMicrosoftGraphTimeOffItem>]`: timeOffItem
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EndDateTime <DateTime?>]`: 
      - `[StartDateTime <DateTime?>]`: 
      - `[Theme <String>]`: scheduleEntityTheme
      - `[TimeOffReasonId <String>]`: ID of the timeOffReason for this timeOffItem. Required.
    - `[IsStagedForDeletion <Boolean?>]`: The timeOff is marked for deletion, a process that is finalized when the schedule is shared.
    - `[SharedTimeOff <IMicrosoftGraphTimeOffItem>]`: timeOffItem
    - `[TeamInfo <IMicrosoftGraphShiftsTeamInfo>]`: shiftsTeamInfo
    - `[UserId <String>]`: ID of the user assigned to the timeOff. Required.
    - `[UserInfo <IMicrosoftGraphShiftsUserInfo>]`: shiftsUserInfo
  - `[WorkforceIntegrationIds <String[]>]`: The IDs for the workforce integrations associated with this schedule.

`DAYNOTES <IMicrosoftGraphDayNote[]>`: The day notes in the schedule.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DayNoteDate <DateTime?>]`: The date of the day note.
  - `[DraftDayNote <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[SharedDayNote <IMicrosoftGraphItemBody>]`: itemBody

`INPUTOBJECT <ITeamsIdentity>`: Identity Parameter
  - `[AssociatedTeamInfoId <String>]`: The unique identifier of associatedTeamInfo
  - `[ChannelId <String>]`: The unique identifier of channel
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageHostedContentId <String>]`: The unique identifier of chatMessageHostedContent
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[ChatMessageId1 <String>]`: The unique identifier of chatMessage
  - `[ConversationMemberId <String>]`: The unique identifier of conversationMember
  - `[DayNoteId <String>]`: The unique identifier of dayNote
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
  - `[ShiftsRoleDefinitionId <String>]`: The unique identifier of shiftsRoleDefinition
  - `[SwapShiftsChangeRequestId <String>]`: The unique identifier of swapShiftsChangeRequest
  - `[TeamId <String>]`: The unique identifier of team
  - `[TeamTemplateDefinitionId <String>]`: The unique identifier of teamTemplateDefinition
  - `[TeamTemplateId <String>]`: The unique identifier of teamTemplate
  - `[TeamsAppDashboardCardDefinitionId <String>]`: The unique identifier of teamsAppDashboardCardDefinition
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

`OFFERSHIFTREQUESTS <IMicrosoftGraphOfferShiftRequest[]>`: The offer requests for shifts in the schedule.
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionMessage <String>]`: 
  - `[SenderMessage <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
  - `[RecipientUserId <String>]`: User id of the recipient of the offer shift request.
  - `[SenderShiftId <String>]`: User id of the sender of the offer shift request.

`OPENSHIFTCHANGEREQUESTS <IMicrosoftGraphOpenShiftChangeRequest[]>`: The open shift requests in the schedule.
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionMessage <String>]`: 
  - `[SenderMessage <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[OpenShiftId <String>]`: ID for the open shift.

`OPENSHIFTS <IMicrosoftGraphOpenShift[]>`: The set of open shifts in a scheduling group in the schedule.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
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
  - `[IsStagedForDeletion <Boolean?>]`: The openShift is marked for deletion, a process that is finalized when the schedule is shared.
  - `[SchedulingGroupId <String>]`: The ID of the schedulingGroup that contains the openShift.
  - `[SchedulingGroupInfo <IMicrosoftGraphSchedulingGroupInfo>]`: schedulingGroupInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <String>]`: The code for the schedulingGroup.
    - `[DisplayName <String>]`: The display name for the schedulingGroup. Required.
    - `[SchedulingGroupId <String>]`: ID of the schedulingGroup.
  - `[SharedOpenShift <IMicrosoftGraphOpenShiftItem>]`: openShiftItem
  - `[TeamInfo <IMicrosoftGraphShiftsTeamInfo>]`: shiftsTeamInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name for the team. Required.
    - `[TeamId <String>]`: ID of the team.

`SCHEDULINGGROUPS <IMicrosoftGraphSchedulingGroup[]>`: The logical grouping of users in the schedule (usually by role).
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Code <String>]`: The code for the schedulingGroup to represent an external identifier. This field must be unique within the team in Microsoft Teams and uses an alphanumeric format, with a maximum of 100 characters.
  - `[DisplayName <String>]`: The display name for the schedulingGroup. Required.
  - `[UserIds <String[]>]`: The list of user IDs that are a member of the schedulingGroup. Required.

`SHIFTS <IMicrosoftGraphShift[]>`: The shifts in the schedule.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
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
  - `[IsStagedForDeletion <Boolean?>]`: The shift is marked for deletion, a process that is finalized when the schedule is shared.
  - `[SchedulingGroupId <String>]`: ID of the scheduling group the shift is part of. Required.
  - `[SchedulingGroupInfo <IMicrosoftGraphSchedulingGroupInfo>]`: schedulingGroupInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <String>]`: The code for the schedulingGroup.
    - `[DisplayName <String>]`: The display name for the schedulingGroup. Required.
    - `[SchedulingGroupId <String>]`: ID of the schedulingGroup.
  - `[SharedShift <IMicrosoftGraphShiftItem>]`: shiftItem
  - `[TeamInfo <IMicrosoftGraphShiftsTeamInfo>]`: shiftsTeamInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name for the team. Required.
    - `[TeamId <String>]`: ID of the team.
  - `[UserId <String>]`: ID of the user assigned to the shift. Required.
  - `[UserInfo <IMicrosoftGraphShiftsUserInfo>]`: shiftsUserInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name for the user. Required.
    - `[UserId <String>]`: ID of the user.

`SHIFTSROLEDEFINITIONS <IMicrosoftGraphShiftsRoleDefinition[]>`: The definitions of the roles in the schedule.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: The description of the role.
  - `[DisplayName <String>]`: The display name of the role.
  - `[ShiftsRolePermissions <IMicrosoftGraphShiftsRolePermission[]>]`: The collection of role permissions within the role.
    - `[AllowedResourceActions <String[]>]`: The permissions that are allowed for a role. Permissions that aren't in this collection are disabled.

`SWAPSHIFTSCHANGEREQUESTS <IMicrosoftGraphSwapShiftsChangeRequest[]>`: The swap requests for shifts in the schedule.
  - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
  - `[RecipientUserId <String>]`: User id of the recipient of the offer shift request.
  - `[SenderShiftId <String>]`: User id of the sender of the offer shift request.
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionMessage <String>]`: 
  - `[SenderMessage <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[RecipientShiftId <String>]`: Shift ID for the recipient user with whom the request is to swap.

`TIMECARDS <IMicrosoftGraphTimeCard[]>`: The time cards in the schedule.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
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

`TIMECLOCKSETTINGS <IMicrosoftGraphTimeClockSettings>`: timeClockSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ApprovedLocation <IMicrosoftGraphGeoCoordinates>]`: geoCoordinates
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Altitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
    - `[Latitude <Double?>]`: Optional. The latitude, in decimal, for the item. Writable on OneDrive Personal.
    - `[Longitude <Double?>]`: Optional. The longitude, in decimal, for the item. Writable on OneDrive Personal.

`TIMEOFFREASONS <IMicrosoftGraphTimeOffReason[]>`: The set of reasons for a time off in the schedule.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Code <String>]`: The code of the timeOffReason to represent an external identifier. This field must be unique within the team in Microsoft Teams and uses an alphanumeric format, with a maximum of 100 characters.
  - `[DisplayName <String>]`: The name of the timeOffReason. Required.
  - `[IconType <String>]`: timeOffReasonIconType
  - `[IsActive <Boolean?>]`: Indicates whether the timeOffReason can be used when creating new entities or updating existing ones. Required.

`TIMEOFFREQUESTS <IMicrosoftGraphTimeOffRequest[]>`: The time off requests in the schedule.
  - `[AssignedTo <String>]`: scheduleChangeRequestActor
  - `[ManagerActionMessage <String>]`: 
  - `[SenderMessage <String>]`: 
  - `[State <String>]`: scheduleChangeState
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[EndDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[TimeOffReasonId <String>]`: The reason for the time off.

`TIMESOFF <IMicrosoftGraphTimeOff[]>`: The instances of times off in the schedule.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DraftTimeOff <IMicrosoftGraphTimeOffItem>]`: timeOffItem
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EndDateTime <DateTime?>]`: 
    - `[StartDateTime <DateTime?>]`: 
    - `[Theme <String>]`: scheduleEntityTheme
    - `[TimeOffReasonId <String>]`: ID of the timeOffReason for this timeOffItem. Required.
  - `[IsStagedForDeletion <Boolean?>]`: The timeOff is marked for deletion, a process that is finalized when the schedule is shared.
  - `[SharedTimeOff <IMicrosoftGraphTimeOffItem>]`: timeOffItem
  - `[TeamInfo <IMicrosoftGraphShiftsTeamInfo>]`: shiftsTeamInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name for the team. Required.
    - `[TeamId <String>]`: ID of the team.
  - `[UserId <String>]`: ID of the user assigned to the timeOff. Required.
  - `[UserInfo <IMicrosoftGraphShiftsUserInfo>]`: shiftsUserInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name for the user. Required.
    - `[UserId <String>]`: ID of the user.

## RELATED LINKS

