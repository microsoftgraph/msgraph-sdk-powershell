---
external help file:
Module Name: Microsoft.Graph.Users.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.groups/new-mguserjoinedteam
schema: 2.0.0
---

# New-MgUserJoinedTeam

## SYNOPSIS
Create new navigation property to joinedTeams for users

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgUserJoinedTeam -UserId <String> [-Channels <IMicrosoftGraphChannel[]>]
 [-FunSettings <IMicrosoftGraphTeamFunSettings>] [-GuestSettings <IMicrosoftGraphTeamGuestSettings>]
 [-Id <String>] [-InstalledApps <IMicrosoftGraphTeamsAppInstallation[]>] [-IsArchived]
 [-MemberSettings <IMicrosoftGraphTeamMemberSettings>]
 [-MessagingSettings <IMicrosoftGraphTeamMessagingSettings>]
 [-Operations <IMicrosoftGraphTeamsAsyncOperation[]>] [-PrimaryChannel <IMicrosoftGraphChannel>]
 [-Schedule <IMicrosoftGraphSchedule>] [-WebUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgUserJoinedTeam -UserId <String> -BodyParameter <IMicrosoftGraphTeam> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgUserJoinedTeam -InputObject <IUsersGroupsIdentity> -BodyParameter <IMicrosoftGraphTeam> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgUserJoinedTeam -InputObject <IUsersGroupsIdentity> [-Channels <IMicrosoftGraphChannel[]>]
 [-FunSettings <IMicrosoftGraphTeamFunSettings>] [-GuestSettings <IMicrosoftGraphTeamGuestSettings>]
 [-Id <String>] [-InstalledApps <IMicrosoftGraphTeamsAppInstallation[]>] [-IsArchived]
 [-MemberSettings <IMicrosoftGraphTeamMemberSettings>]
 [-MessagingSettings <IMicrosoftGraphTeamMessagingSettings>]
 [-Operations <IMicrosoftGraphTeamsAsyncOperation[]>] [-PrimaryChannel <IMicrosoftGraphChannel>]
 [-Schedule <IMicrosoftGraphSchedule>] [-WebUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to joinedTeams for users

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
team
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeam
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Channels
The collection of channels & messages associated with the team.
To construct, see NOTES section for CHANNELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChannel[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FunSettings
teamFunSettings
To construct, see NOTES section for FUNSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamFunSettings
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GuestSettings
teamGuestSettings
To construct, see NOTES section for GUESTSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamGuestSettings
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
Type: Microsoft.Graph.PowerShell.Models.IUsersGroupsIdentity
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InstalledApps
The apps installed in this team.
To construct, see NOTES section for INSTALLEDAPPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppInstallation[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsArchived
Whether this team is in read-only mode.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberSettings
teamMemberSettings
To construct, see NOTES section for MEMBERSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamMemberSettings
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MessagingSettings
teamMessagingSettings
To construct, see NOTES section for MESSAGINGSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamMessagingSettings
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Operations
.
To construct, see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAsyncOperation[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrimaryChannel
channel
To construct, see NOTES section for PRIMARYCHANNEL properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChannel
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Schedule
schedule
To construct, see NOTES section for SCHEDULE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchedule
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: user-id of user

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

### -WebUrl
A hyperlink that will go to the team in the Microsoft Teams client.
This is the URL that you get when you right-click a team in the Microsoft Teams client and select Get link to team.
This URL should be treated as an opaque blob, and not parsed.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeam

### Microsoft.Graph.PowerShell.Models.IUsersGroupsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeam

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTeam>: team
  - `[Id <String>]`: Read-only.
  - `[Channels <IMicrosoftGraphChannel[]>]`: The collection of channels & messages associated with the team.
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: Optional textual description for the channel.
    - `[DisplayName <String>]`: Channel name as it will appear to the user in Microsoft Teams.
    - `[Email <String>]`: The email address for sending messages to the channel. Read-only.
    - `[Tabs <IMicrosoftGraphTeamsTab[]>]`: A collection of all the tabs in the channel. A navigation property.
      - `[Id <String>]`: Read-only.
      - `[ConfigurationContentUrl <String>]`: Url used for rendering tab contents in Teams. Required.
      - `[ConfigurationEntityId <String>]`: Identifier for the entity hosted by the tab provider.
      - `[ConfigurationRemoveUrl <String>]`: Url called by Teams client when a Tab is removed using the Teams Client.
      - `[ConfigurationWebsiteUrl <String>]`: Url for showing tab contents outside of Teams.
      - `[DisplayName <String>]`: Name of the tab.
      - `[TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: The name of the app provided by the app developer.
        - `[TeamsAppId <String>]`: The id from the Teams App manifest.
        - `[Version <String>]`: The version number of the application.
      - `[TeamAppDisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
      - `[TeamAppDistributionMethod <String>]`: teamsAppDistributionMethod
      - `[TeamAppExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
      - `[TeamAppId <String>]`: Read-only.
      - `[WebUrl <String>]`: Deep link url of the tab instance. Read only.
    - `[WebUrl <String>]`: A hyperlink that will navigate to the channel in Microsoft Teams. This is the URL that you get when you right-click a channel in Microsoft Teams and select Get link to channel. This URL should be treated as an opaque blob, and not parsed. Read-only.
  - `[FunSettings <IMicrosoftGraphTeamFunSettings>]`: teamFunSettings
    - `[AllowCustomMemes <Boolean?>]`: If set to true, enables users to include custom memes.
    - `[AllowGiphy <Boolean?>]`: If set to true, enables Giphy use.
    - `[AllowStickersAndMemes <Boolean?>]`: If set to true, enables users to include stickers and memes.
    - `[GiphyContentRating <String>]`: giphyRatingType
  - `[GuestSettings <IMicrosoftGraphTeamGuestSettings>]`: teamGuestSettings
    - `[AllowCreateUpdateChannels <Boolean?>]`: If set to true, guests can add and update channels.
    - `[AllowDeleteChannels <Boolean?>]`: If set to true, guests can delete channels.
  - `[InstalledApps <IMicrosoftGraphTeamsAppInstallation[]>]`: The apps installed in this team.
    - `[Id <String>]`: Read-only.
    - `[TeamAppDefinitionDisplayName <String>]`: The name of the app provided by the app developer.
    - `[TeamAppDefinitionId <String>]`: Read-only.
    - `[TeamAppDefinitionTeamsAppId <String>]`: The id from the Teams App manifest.
    - `[TeamAppDefinitionVersion <String>]`: The version number of the application.
    - `[TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
    - `[TeamAppDisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
    - `[TeamAppDistributionMethod <String>]`: teamsAppDistributionMethod
    - `[TeamAppExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
    - `[TeamAppId <String>]`: Read-only.
  - `[IsArchived <Boolean?>]`: Whether this team is in read-only mode.
  - `[MemberSettings <IMicrosoftGraphTeamMemberSettings>]`: teamMemberSettings
    - `[AllowAddRemoveApps <Boolean?>]`: If set to true, members can add and remove apps.
    - `[AllowCreateUpdateChannels <Boolean?>]`: If set to true, members can add and update channels.
    - `[AllowCreateUpdateRemoveConnectors <Boolean?>]`: If set to true, members can add, update, and remove connectors.
    - `[AllowCreateUpdateRemoveTabs <Boolean?>]`: If set to true, members can add, update, and remove tabs.
    - `[AllowDeleteChannels <Boolean?>]`: If set to true, members can delete channels.
  - `[MessagingSettings <IMicrosoftGraphTeamMessagingSettings>]`: teamMessagingSettings
    - `[AllowChannelMentions <Boolean?>]`: If set to true, @channel mentions are allowed.
    - `[AllowOwnerDeleteMessages <Boolean?>]`: If set to true, owners can delete any message.
    - `[AllowTeamMentions <Boolean?>]`: If set to true, @team mentions are allowed.
    - `[AllowUserDeleteMessages <Boolean?>]`: If set to true, users can delete their messages.
    - `[AllowUserEditMessages <Boolean?>]`: If set to true, users can edit their messages.
  - `[Operations <IMicrosoftGraphTeamsAsyncOperation[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AttemptsCount <Int32?>]`: 
    - `[Code <String>]`: Operation error code.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[Message <String>]`: Operation error message.
    - `[OperationType <String>]`: teamsAsyncOperationType
    - `[Status <String>]`: teamsAsyncOperationStatus
    - `[TargetResourceId <String>]`: 
    - `[TargetResourceLocation <String>]`: 
  - `[PrimaryChannel <IMicrosoftGraphChannel>]`: channel
  - `[Schedule <IMicrosoftGraphSchedule>]`: schedule
    - `[Id <String>]`: Read-only.
    - `[Enabled <Boolean?>]`: Indicates whether the schedule is enabled for the team. Required.
    - `[OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>]`: 
      - `[AssignedTo <String>]`: scheduleChangeRequestActor
      - `[ManagerActionDateTime <DateTime?>]`: 
      - `[ManagerActionMessage <String>]`: 
      - `[ManagerUserId <String>]`: 
      - `[SenderDateTime <DateTime?>]`: 
      - `[SenderMessage <String>]`: 
      - `[SenderUserId <String>]`: 
      - `[State <String>]`: scheduleChangeState
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Id <String>]`: Read-only.
      - `[RecipientActionDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
      - `[RecipientUserId <String>]`: User ID of the recipient of the offer shift request.
      - `[SenderShiftId <String>]`: User ID of the sender of the offer shift request.
    - `[OfferShiftRequestsEnabled <Boolean?>]`: Indicates whether offer shift requests are enabled for the schedule.
    - `[OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]`: 
      - `[AssignedTo <String>]`: scheduleChangeRequestActor
      - `[ManagerActionDateTime <DateTime?>]`: 
      - `[ManagerActionMessage <String>]`: 
      - `[ManagerUserId <String>]`: 
      - `[SenderDateTime <DateTime?>]`: 
      - `[SenderMessage <String>]`: 
      - `[SenderUserId <String>]`: 
      - `[State <String>]`: scheduleChangeState
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Id <String>]`: Read-only.
      - `[OpenShiftId <String>]`: ID for the open shift.
    - `[OpenShifts <IMicrosoftGraphOpenShift[]>]`: 
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
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
    - `[OpenShiftsEnabled <Boolean?>]`: Indicates whether open shifts are enabled for the schedule.
    - `[ProvisionStatus <String>]`: operationStatus
    - `[ProvisionStatusCode <String>]`: Additional information about why schedule provisioning failed.
    - `[SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]`: The logical grouping of users in the schedule (usually by role).
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The display name for the schedulingGroup. Required.
      - `[IsActive <Boolean?>]`: Indicates whether the schedulingGroup can be used when creating new entities or updating existing ones. Required.
      - `[UserIds <String[]>]`: The list of user IDs that are a member of the schedulingGroup. Required.
    - `[Shifts <IMicrosoftGraphShift[]>]`: The shifts in the schedule.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Id <String>]`: Read-only.
      - `[DraftShiftActivities <IMicrosoftGraphShiftActivity[]>]`: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
      - `[DraftShiftDisplayName <String>]`: The shift label of the shiftItem.
      - `[DraftShiftEndDateTime <DateTime?>]`: 
      - `[DraftShiftNotes <String>]`: The shift notes for the shiftItem.
      - `[DraftShiftStartDateTime <DateTime?>]`: 
      - `[DraftShiftTheme <String>]`: scheduleEntityTheme
      - `[SchedulingGroupId <String>]`: ID of the scheduling group the shift is part of. Required.
      - `[SharedShiftActivities <IMicrosoftGraphShiftActivity[]>]`: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
      - `[SharedShiftDisplayName <String>]`: The shift label of the shiftItem.
      - `[SharedShiftEndDateTime <DateTime?>]`: 
      - `[SharedShiftNotes <String>]`: The shift notes for the shiftItem.
      - `[SharedShiftStartDateTime <DateTime?>]`: 
      - `[SharedShiftTheme <String>]`: scheduleEntityTheme
      - `[UserId <String>]`: ID of the user assigned to the shift. Required.
    - `[SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]`: 
      - `[RecipientActionDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
      - `[RecipientUserId <String>]`: User ID of the recipient of the offer shift request.
      - `[SenderShiftId <String>]`: User ID of the sender of the offer shift request.
      - `[AssignedTo <String>]`: scheduleChangeRequestActor
      - `[ManagerActionDateTime <DateTime?>]`: 
      - `[ManagerActionMessage <String>]`: 
      - `[ManagerUserId <String>]`: 
      - `[SenderDateTime <DateTime?>]`: 
      - `[SenderMessage <String>]`: 
      - `[SenderUserId <String>]`: 
      - `[State <String>]`: scheduleChangeState
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Id <String>]`: Read-only.
      - `[RecipientShiftId <String>]`: ShiftId for the recipient user with whom the request is to swap.
    - `[SwapShiftsRequestsEnabled <Boolean?>]`: Indicates whether swap shifts requests are enabled for the schedule.
    - `[TimeClockEnabled <Boolean?>]`: Indicates whether time clock is enabled for the schedule.
    - `[TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]`: The set of reasons for a time off in the schedule.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The name of the timeOffReason. Required.
      - `[IconType <String>]`: timeOffReasonIconType
      - `[IsActive <Boolean?>]`: Indicates whether the timeOffReason can be used when creating new entities or updating existing ones. Required.
    - `[TimeOffRequests <IMicrosoftGraphTimeOffRequest[]>]`: 
      - `[AssignedTo <String>]`: scheduleChangeRequestActor
      - `[ManagerActionDateTime <DateTime?>]`: 
      - `[ManagerActionMessage <String>]`: 
      - `[ManagerUserId <String>]`: 
      - `[SenderDateTime <DateTime?>]`: 
      - `[SenderMessage <String>]`: 
      - `[SenderUserId <String>]`: 
      - `[State <String>]`: scheduleChangeState
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Id <String>]`: Read-only.
      - `[EndDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[TimeOffReasonId <String>]`: The reason for the time off.
    - `[TimeOffRequestsEnabled <Boolean?>]`: Indicates whether time off requests are enabled for the schedule.
    - `[TimeZone <String>]`: Indicates the time zone of the schedule team using tz database format. Required.
    - `[TimesOff <IMicrosoftGraphTimeOff[]>]`: The instances of times off in the schedule.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Id <String>]`: Read-only.
      - `[DraftTimeOffEndDateTime <DateTime?>]`: 
      - `[DraftTimeOffReasonId <String>]`: ID of the timeOffReason for this timeOffItem. Required.
      - `[DraftTimeOffStartDateTime <DateTime?>]`: 
      - `[DraftTimeOffTheme <String>]`: scheduleEntityTheme
      - `[SharedTimeOffEndDateTime <DateTime?>]`: 
      - `[SharedTimeOffReasonId <String>]`: ID of the timeOffReason for this timeOffItem. Required.
      - `[SharedTimeOffStartDateTime <DateTime?>]`: 
      - `[SharedTimeOffTheme <String>]`: scheduleEntityTheme
      - `[UserId <String>]`: ID of the user assigned to the timeOff. Required.
    - `[WorkforceIntegrationIds <String[]>]`: 
  - `[WebUrl <String>]`: A hyperlink that will go to the team in the Microsoft Teams client. This is the URL that you get when you right-click a team in the Microsoft Teams client and select Get link to team. This URL should be treated as an opaque blob, and not parsed.

CHANNELS <IMicrosoftGraphChannel[]>: The collection of channels & messages associated with the team.
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: Optional textual description for the channel.
  - `[DisplayName <String>]`: Channel name as it will appear to the user in Microsoft Teams.
  - `[Email <String>]`: The email address for sending messages to the channel. Read-only.
  - `[Tabs <IMicrosoftGraphTeamsTab[]>]`: A collection of all the tabs in the channel. A navigation property.
    - `[Id <String>]`: Read-only.
    - `[ConfigurationContentUrl <String>]`: Url used for rendering tab contents in Teams. Required.
    - `[ConfigurationEntityId <String>]`: Identifier for the entity hosted by the tab provider.
    - `[ConfigurationRemoveUrl <String>]`: Url called by Teams client when a Tab is removed using the Teams Client.
    - `[ConfigurationWebsiteUrl <String>]`: Url for showing tab contents outside of Teams.
    - `[DisplayName <String>]`: Name of the tab.
    - `[TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The name of the app provided by the app developer.
      - `[TeamsAppId <String>]`: The id from the Teams App manifest.
      - `[Version <String>]`: The version number of the application.
    - `[TeamAppDisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
    - `[TeamAppDistributionMethod <String>]`: teamsAppDistributionMethod
    - `[TeamAppExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
    - `[TeamAppId <String>]`: Read-only.
    - `[WebUrl <String>]`: Deep link url of the tab instance. Read only.
  - `[WebUrl <String>]`: A hyperlink that will navigate to the channel in Microsoft Teams. This is the URL that you get when you right-click a channel in Microsoft Teams and select Get link to channel. This URL should be treated as an opaque blob, and not parsed. Read-only.

FUNSETTINGS <IMicrosoftGraphTeamFunSettings>: teamFunSettings
  - `[AllowCustomMemes <Boolean?>]`: If set to true, enables users to include custom memes.
  - `[AllowGiphy <Boolean?>]`: If set to true, enables Giphy use.
  - `[AllowStickersAndMemes <Boolean?>]`: If set to true, enables users to include stickers and memes.
  - `[GiphyContentRating <String>]`: giphyRatingType

GUESTSETTINGS <IMicrosoftGraphTeamGuestSettings>: teamGuestSettings
  - `[AllowCreateUpdateChannels <Boolean?>]`: If set to true, guests can add and update channels.
  - `[AllowDeleteChannels <Boolean?>]`: If set to true, guests can delete channels.

INPUTOBJECT <IUsersGroupsIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: group-id of group
  - `[TeamId <String>]`: key: team-id of team
  - `[UserId <String>]`: key: user-id of user

INSTALLEDAPPS <IMicrosoftGraphTeamsAppInstallation[]>: The apps installed in this team.
  - `[Id <String>]`: Read-only.
  - `[TeamAppDefinitionDisplayName <String>]`: The name of the app provided by the app developer.
  - `[TeamAppDefinitionId <String>]`: Read-only.
  - `[TeamAppDefinitionTeamsAppId <String>]`: The id from the Teams App manifest.
  - `[TeamAppDefinitionVersion <String>]`: The version number of the application.
  - `[TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the app provided by the app developer.
    - `[TeamsAppId <String>]`: The id from the Teams App manifest.
    - `[Version <String>]`: The version number of the application.
  - `[TeamAppDisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
  - `[TeamAppDistributionMethod <String>]`: teamsAppDistributionMethod
  - `[TeamAppExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
  - `[TeamAppId <String>]`: Read-only.

MEMBERSETTINGS <IMicrosoftGraphTeamMemberSettings>: teamMemberSettings
  - `[AllowAddRemoveApps <Boolean?>]`: If set to true, members can add and remove apps.
  - `[AllowCreateUpdateChannels <Boolean?>]`: If set to true, members can add and update channels.
  - `[AllowCreateUpdateRemoveConnectors <Boolean?>]`: If set to true, members can add, update, and remove connectors.
  - `[AllowCreateUpdateRemoveTabs <Boolean?>]`: If set to true, members can add, update, and remove tabs.
  - `[AllowDeleteChannels <Boolean?>]`: If set to true, members can delete channels.

MESSAGINGSETTINGS <IMicrosoftGraphTeamMessagingSettings>: teamMessagingSettings
  - `[AllowChannelMentions <Boolean?>]`: If set to true, @channel mentions are allowed.
  - `[AllowOwnerDeleteMessages <Boolean?>]`: If set to true, owners can delete any message.
  - `[AllowTeamMentions <Boolean?>]`: If set to true, @team mentions are allowed.
  - `[AllowUserDeleteMessages <Boolean?>]`: If set to true, users can delete their messages.
  - `[AllowUserEditMessages <Boolean?>]`: If set to true, users can edit their messages.

OPERATIONS <IMicrosoftGraphTeamsAsyncOperation[]>: .
  - `[Id <String>]`: Read-only.
  - `[AttemptsCount <Int32?>]`: 
  - `[Code <String>]`: Operation error code.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[Message <String>]`: Operation error message.
  - `[OperationType <String>]`: teamsAsyncOperationType
  - `[Status <String>]`: teamsAsyncOperationStatus
  - `[TargetResourceId <String>]`: 
  - `[TargetResourceLocation <String>]`: 

PRIMARYCHANNEL <IMicrosoftGraphChannel>: channel
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: Optional textual description for the channel.
  - `[DisplayName <String>]`: Channel name as it will appear to the user in Microsoft Teams.
  - `[Email <String>]`: The email address for sending messages to the channel. Read-only.
  - `[Tabs <IMicrosoftGraphTeamsTab[]>]`: A collection of all the tabs in the channel. A navigation property.
    - `[Id <String>]`: Read-only.
    - `[ConfigurationContentUrl <String>]`: Url used for rendering tab contents in Teams. Required.
    - `[ConfigurationEntityId <String>]`: Identifier for the entity hosted by the tab provider.
    - `[ConfigurationRemoveUrl <String>]`: Url called by Teams client when a Tab is removed using the Teams Client.
    - `[ConfigurationWebsiteUrl <String>]`: Url for showing tab contents outside of Teams.
    - `[DisplayName <String>]`: Name of the tab.
    - `[TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The name of the app provided by the app developer.
      - `[TeamsAppId <String>]`: The id from the Teams App manifest.
      - `[Version <String>]`: The version number of the application.
    - `[TeamAppDisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
    - `[TeamAppDistributionMethod <String>]`: teamsAppDistributionMethod
    - `[TeamAppExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
    - `[TeamAppId <String>]`: Read-only.
    - `[WebUrl <String>]`: Deep link url of the tab instance. Read only.
  - `[WebUrl <String>]`: A hyperlink that will navigate to the channel in Microsoft Teams. This is the URL that you get when you right-click a channel in Microsoft Teams and select Get link to channel. This URL should be treated as an opaque blob, and not parsed. Read-only.

SCHEDULE <IMicrosoftGraphSchedule>: schedule
  - `[Id <String>]`: Read-only.
  - `[Enabled <Boolean?>]`: Indicates whether the schedule is enabled for the team. Required.
  - `[OfferShiftRequests <IMicrosoftGraphOfferShiftRequest[]>]`: 
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionDateTime <DateTime?>]`: 
    - `[ManagerActionMessage <String>]`: 
    - `[ManagerUserId <String>]`: 
    - `[SenderDateTime <DateTime?>]`: 
    - `[SenderMessage <String>]`: 
    - `[SenderUserId <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[RecipientActionDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
    - `[RecipientUserId <String>]`: User ID of the recipient of the offer shift request.
    - `[SenderShiftId <String>]`: User ID of the sender of the offer shift request.
  - `[OfferShiftRequestsEnabled <Boolean?>]`: Indicates whether offer shift requests are enabled for the schedule.
  - `[OpenShiftChangeRequests <IMicrosoftGraphOpenShiftChangeRequest[]>]`: 
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionDateTime <DateTime?>]`: 
    - `[ManagerActionMessage <String>]`: 
    - `[ManagerUserId <String>]`: 
    - `[SenderDateTime <DateTime?>]`: 
    - `[SenderMessage <String>]`: 
    - `[SenderUserId <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[OpenShiftId <String>]`: ID for the open shift.
  - `[OpenShifts <IMicrosoftGraphOpenShift[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
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
  - `[OpenShiftsEnabled <Boolean?>]`: Indicates whether open shifts are enabled for the schedule.
  - `[ProvisionStatus <String>]`: operationStatus
  - `[ProvisionStatusCode <String>]`: Additional information about why schedule provisioning failed.
  - `[SchedulingGroups <IMicrosoftGraphSchedulingGroup[]>]`: The logical grouping of users in the schedule (usually by role).
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The display name for the schedulingGroup. Required.
    - `[IsActive <Boolean?>]`: Indicates whether the schedulingGroup can be used when creating new entities or updating existing ones. Required.
    - `[UserIds <String[]>]`: The list of user IDs that are a member of the schedulingGroup. Required.
  - `[Shifts <IMicrosoftGraphShift[]>]`: The shifts in the schedule.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[DraftShiftActivities <IMicrosoftGraphShiftActivity[]>]`: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
    - `[DraftShiftDisplayName <String>]`: The shift label of the shiftItem.
    - `[DraftShiftEndDateTime <DateTime?>]`: 
    - `[DraftShiftNotes <String>]`: The shift notes for the shiftItem.
    - `[DraftShiftStartDateTime <DateTime?>]`: 
    - `[DraftShiftTheme <String>]`: scheduleEntityTheme
    - `[SchedulingGroupId <String>]`: ID of the scheduling group the shift is part of. Required.
    - `[SharedShiftActivities <IMicrosoftGraphShiftActivity[]>]`: An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
    - `[SharedShiftDisplayName <String>]`: The shift label of the shiftItem.
    - `[SharedShiftEndDateTime <DateTime?>]`: 
    - `[SharedShiftNotes <String>]`: The shift notes for the shiftItem.
    - `[SharedShiftStartDateTime <DateTime?>]`: 
    - `[SharedShiftTheme <String>]`: scheduleEntityTheme
    - `[UserId <String>]`: ID of the user assigned to the shift. Required.
  - `[SwapShiftsChangeRequests <IMicrosoftGraphSwapShiftsChangeRequest[]>]`: 
    - `[RecipientActionDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[RecipientActionMessage <String>]`: Custom message sent by recipient of the offer shift request.
    - `[RecipientUserId <String>]`: User ID of the recipient of the offer shift request.
    - `[SenderShiftId <String>]`: User ID of the sender of the offer shift request.
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionDateTime <DateTime?>]`: 
    - `[ManagerActionMessage <String>]`: 
    - `[ManagerUserId <String>]`: 
    - `[SenderDateTime <DateTime?>]`: 
    - `[SenderMessage <String>]`: 
    - `[SenderUserId <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[RecipientShiftId <String>]`: ShiftId for the recipient user with whom the request is to swap.
  - `[SwapShiftsRequestsEnabled <Boolean?>]`: Indicates whether swap shifts requests are enabled for the schedule.
  - `[TimeClockEnabled <Boolean?>]`: Indicates whether time clock is enabled for the schedule.
  - `[TimeOffReasons <IMicrosoftGraphTimeOffReason[]>]`: The set of reasons for a time off in the schedule.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the timeOffReason. Required.
    - `[IconType <String>]`: timeOffReasonIconType
    - `[IsActive <Boolean?>]`: Indicates whether the timeOffReason can be used when creating new entities or updating existing ones. Required.
  - `[TimeOffRequests <IMicrosoftGraphTimeOffRequest[]>]`: 
    - `[AssignedTo <String>]`: scheduleChangeRequestActor
    - `[ManagerActionDateTime <DateTime?>]`: 
    - `[ManagerActionMessage <String>]`: 
    - `[ManagerUserId <String>]`: 
    - `[SenderDateTime <DateTime?>]`: 
    - `[SenderMessage <String>]`: 
    - `[SenderUserId <String>]`: 
    - `[State <String>]`: scheduleChangeState
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[EndDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[TimeOffReasonId <String>]`: The reason for the time off.
  - `[TimeOffRequestsEnabled <Boolean?>]`: Indicates whether time off requests are enabled for the schedule.
  - `[TimeZone <String>]`: Indicates the time zone of the schedule team using tz database format. Required.
  - `[TimesOff <IMicrosoftGraphTimeOff[]>]`: The instances of times off in the schedule.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[DraftTimeOffEndDateTime <DateTime?>]`: 
    - `[DraftTimeOffReasonId <String>]`: ID of the timeOffReason for this timeOffItem. Required.
    - `[DraftTimeOffStartDateTime <DateTime?>]`: 
    - `[DraftTimeOffTheme <String>]`: scheduleEntityTheme
    - `[SharedTimeOffEndDateTime <DateTime?>]`: 
    - `[SharedTimeOffReasonId <String>]`: ID of the timeOffReason for this timeOffItem. Required.
    - `[SharedTimeOffStartDateTime <DateTime?>]`: 
    - `[SharedTimeOffTheme <String>]`: scheduleEntityTheme
    - `[UserId <String>]`: ID of the user assigned to the timeOff. Required.
  - `[WorkforceIntegrationIds <String[]>]`: 

## RELATED LINKS

