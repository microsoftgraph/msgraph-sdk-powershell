---
external help file:
Module Name: Microsoft.Graph.Beta.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.teams/new-mgbetateamscheduleshift
schema: 2.0.0
---

# New-MgBetaTeamScheduleShift

## SYNOPSIS
Create a new shift instance in a schedule.
The duration of a shift cannot be less than 1 minute or longer than 24 hours.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaTeamScheduleShift -TeamId <String> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-DraftShift <IMicrosoftGraphShiftItem>] [-Id <String>]
 [-IsStagedForDeletion] [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-SchedulingGroupId <String>]
 [-SharedShift <IMicrosoftGraphShiftItem>] [-UserId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaTeamScheduleShift -TeamId <String> -BodyParameter <IMicrosoftGraphShift> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaTeamScheduleShift -InputObject <ITeamsIdentity> -BodyParameter <IMicrosoftGraphShift> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaTeamScheduleShift -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-DraftShift <IMicrosoftGraphShiftItem>] [-Id <String>]
 [-IsStagedForDeletion] [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-SchedulingGroupId <String>]
 [-SharedShift <IMicrosoftGraphShiftItem>] [-UserId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new shift instance in a schedule.
The duration of a shift cannot be less than 1 minute or longer than 24 hours.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Teams
```

$params = @{
	id = "SHFT_577b75d2-a927-48c0-a5d1-dc984894e7b8"
	userId = "c5d0c76b-80c4-481c-be50-923cd8d680a1"
	schedulingGroupId = "TAG_228940ed-ff84-4e25-b129-1b395cf78be0"
	sharedShift = @{
		displayName = "Day shift"
		notes = "Please do inventory as part of your shift."
		startDateTime = [System.DateTime]::Parse("2019-03-11T15:00:00Z")
		endDateTime = [System.DateTime]::Parse("2019-03-12T00:00:00Z")
		theme = "blue"
		activities = @(
			@{
				isPaid = $true
				startDateTime = [System.DateTime]::Parse("2019-03-11T15:00:00Z")
				endDateTime = [System.DateTime]::Parse("2019-03-11T15:15:00Z")
				code = ""
				displayName = "Lunch"
			}
		)
	}
	draftShift = @{
		displayName = "Day shift"
		notes = "Please do inventory as part of your shift."
		startDateTime = [System.DateTime]::Parse("2019-03-11T15:00:00Z")
		endDateTime = [System.DateTime]::Parse("2019-03-12T00:00:00Z")
		theme = "blue"
		activities = @(
			@{
				isPaid = $true
				startDateTime = [System.DateTime]::Parse("2019-03-11T15:00:00Z")
				endDateTime = [System.DateTime]::Parse("2019-03-11T15:30:00Z")
				code = ""
				displayName = "Lunch"
			}
		)
	}
}

New-MgBetaTeamScheduleShift -TeamId $teamId -BodyParameter $params

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
shift
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphShift
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DraftShift
shiftItem
To construct, see NOTES section for DRAFTSHIFT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphShiftItem
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsStagedForDeletion
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchedulingGroupId
.

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

### -SharedShift
shiftItem
To construct, see NOTES section for SHAREDSHIFT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphShiftItem
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphShift

### Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphShift

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphShift>`: shift
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
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
  - `[IsStagedForDeletion <Boolean?>]`: 
  - `[SchedulingGroupId <String>]`: 
  - `[SharedShift <IMicrosoftGraphShiftItem>]`: shiftItem
  - `[UserId <String>]`: 

`CREATEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`DRAFTSHIFT <IMicrosoftGraphShiftItem>`: shiftItem
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
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`SHAREDSHIFT <IMicrosoftGraphShiftItem>`: shiftItem
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

## RELATED LINKS

