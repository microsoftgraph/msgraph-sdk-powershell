---
external help file:
Module Name: Microsoft.Graph.Teams.Team
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.team/new-mgteamscheduleopenshift
schema: 2.0.0
---

# New-MgTeamScheduleOpenShift

## SYNOPSIS
Create new navigation property to openShifts for teams

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgTeamScheduleOpenShift -TeamId <String> [-CreatedDateTime <DateTime>]
 [-DraftOpenShiftActivities <IMicrosoftGraphShiftActivity[]>] [-DraftOpenShiftDisplayName <String>]
 [-DraftOpenShiftEndDateTime <DateTime>] [-DraftOpenShiftNotes <String>]
 [-DraftOpenShiftOpenSlotCount <Int32>] [-DraftOpenShiftStartDateTime <DateTime>]
 [-DraftOpenShiftTheme <String>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-SchedulingGroupId <String>]
 [-SharedOpenShiftActivities <IMicrosoftGraphShiftActivity[]>] [-SharedOpenShiftDisplayName <String>]
 [-SharedOpenShiftEndDateTime <DateTime>] [-SharedOpenShiftNotes <String>]
 [-SharedOpenShiftOpenSlotCount <Int32>] [-SharedOpenShiftStartDateTime <DateTime>]
 [-SharedOpenShiftTheme <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgTeamScheduleOpenShift -TeamId <String> -BodyParameter <IMicrosoftGraphOpenShift> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgTeamScheduleOpenShift -InputObject <ITeamsTeamIdentity> -BodyParameter <IMicrosoftGraphOpenShift>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgTeamScheduleOpenShift -InputObject <ITeamsTeamIdentity> [-CreatedDateTime <DateTime>]
 [-DraftOpenShiftActivities <IMicrosoftGraphShiftActivity[]>] [-DraftOpenShiftDisplayName <String>]
 [-DraftOpenShiftEndDateTime <DateTime>] [-DraftOpenShiftNotes <String>]
 [-DraftOpenShiftOpenSlotCount <Int32>] [-DraftOpenShiftStartDateTime <DateTime>]
 [-DraftOpenShiftTheme <String>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-SchedulingGroupId <String>]
 [-SharedOpenShiftActivities <IMicrosoftGraphShiftActivity[]>] [-SharedOpenShiftDisplayName <String>]
 [-SharedOpenShiftEndDateTime <DateTime>] [-SharedOpenShiftNotes <String>]
 [-SharedOpenShiftOpenSlotCount <Int32>] [-SharedOpenShiftStartDateTime <DateTime>]
 [-SharedOpenShiftTheme <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to openShifts for teams

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
openShift
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOpenShift
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DraftOpenShiftActivities
An incremental part of a shift which can cover details of when and where an employee is during their shift.
For example, an assignment or a scheduled break or lunch.
Required.
To construct, see NOTES section for DRAFTOPENSHIFTACTIVITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShiftActivity[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DraftOpenShiftDisplayName
The shift label of the shiftItem.

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

### -DraftOpenShiftEndDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DraftOpenShiftNotes
The shift notes for the shiftItem.

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

### -DraftOpenShiftOpenSlotCount
Count of the number of slots for the given open shift.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DraftOpenShiftStartDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DraftOpenShiftTheme
scheduleEntityTheme

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

### -Id
Read-only.

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchedulingGroupId
ID for the scheduling group that the open shift belongs to.

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

### -SharedOpenShiftActivities
An incremental part of a shift which can cover details of when and where an employee is during their shift.
For example, an assignment or a scheduled break or lunch.
Required.
To construct, see NOTES section for SHAREDOPENSHIFTACTIVITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShiftActivity[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedOpenShiftDisplayName
The shift label of the shiftItem.

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

### -SharedOpenShiftEndDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedOpenShiftNotes
The shift notes for the shiftItem.

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

### -SharedOpenShiftOpenSlotCount
Count of the number of slots for the given open shift.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedOpenShiftStartDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedOpenShiftTheme
scheduleEntityTheme

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

### -TeamId
key: team-id of team

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOpenShift

### Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOpenShift

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOpenShift>: openShift
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Id <String>]`: Read-only.
  - `[DraftOpenShiftActivities <IMicrosoftGraphShiftActivity[]>]`: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
    - `[Code <String>]`: Customer defined code for the shiftActivity. Required.
    - `[DisplayName <String>]`: The name of the shiftActivity. Required.
    - `[EndDateTime <DateTime?>]`: The end date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Required.
    - `[IsPaid <Boolean?>]`: Indicates whether the microsoft.graph.user should be paid for the activity during their shift. Required.
    - `[StartDateTime <DateTime?>]`: The start date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Required.
    - `[Theme <String>]`: scheduleEntityTheme
  - `[DraftOpenShiftDisplayName <String>]`: The shift label of the shiftItem.
  - `[DraftOpenShiftEndDateTime <DateTime?>]`: 
  - `[DraftOpenShiftNotes <String>]`: The shift notes for the shiftItem.
  - `[DraftOpenShiftOpenSlotCount <Int32?>]`: Count of the number of slots for the given open shift.
  - `[DraftOpenShiftStartDateTime <DateTime?>]`: 
  - `[DraftOpenShiftTheme <String>]`: scheduleEntityTheme
  - `[SchedulingGroupId <String>]`: ID for the scheduling group that the open shift belongs to.
  - `[SharedOpenShiftActivities <IMicrosoftGraphShiftActivity[]>]`: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
  - `[SharedOpenShiftDisplayName <String>]`: The shift label of the shiftItem.
  - `[SharedOpenShiftEndDateTime <DateTime?>]`: 
  - `[SharedOpenShiftNotes <String>]`: The shift notes for the shiftItem.
  - `[SharedOpenShiftOpenSlotCount <Int32?>]`: Count of the number of slots for the given open shift.
  - `[SharedOpenShiftStartDateTime <DateTime?>]`: 
  - `[SharedOpenShiftTheme <String>]`: scheduleEntityTheme

DRAFTOPENSHIFTACTIVITIES <IMicrosoftGraphShiftActivity[]>: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
  - `[Code <String>]`: Customer defined code for the shiftActivity. Required.
  - `[DisplayName <String>]`: The name of the shiftActivity. Required.
  - `[EndDateTime <DateTime?>]`: The end date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Required.
  - `[IsPaid <Boolean?>]`: Indicates whether the microsoft.graph.user should be paid for the activity during their shift. Required.
  - `[StartDateTime <DateTime?>]`: The start date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Required.
  - `[Theme <String>]`: scheduleEntityTheme

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
  - `[TeamsCatalogAppId <String>]`: key: teamsCatalogApp-id of teamsCatalogApp
  - `[TeamsTabId <String>]`: key: teamsTab-id of teamsTab
  - `[TeamsTemplateId <String>]`: key: teamsTemplate-id of teamsTemplate
  - `[TimeOffId <String>]`: key: timeOff-id of timeOff
  - `[TimeOffReasonId <String>]`: key: timeOffReason-id of timeOffReason
  - `[TimeOffRequestId <String>]`: key: timeOffRequest-id of timeOffRequest
  - `[UserId <String>]`: key: user-id of user
  - `[WorkforceIntegrationId <String>]`: key: workforceIntegration-id of workforceIntegration

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

SHAREDOPENSHIFTACTIVITIES <IMicrosoftGraphShiftActivity[]>: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
  - `[Code <String>]`: Customer defined code for the shiftActivity. Required.
  - `[DisplayName <String>]`: The name of the shiftActivity. Required.
  - `[EndDateTime <DateTime?>]`: The end date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Required.
  - `[IsPaid <Boolean?>]`: Indicates whether the microsoft.graph.user should be paid for the activity during their shift. Required.
  - `[StartDateTime <DateTime?>]`: The start date and time for the shiftActivity. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Required.
  - `[Theme <String>]`: scheduleEntityTheme

## RELATED LINKS

