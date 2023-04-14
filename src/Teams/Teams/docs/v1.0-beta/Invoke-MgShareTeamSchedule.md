---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/invoke-mgshareteamschedule
schema: 2.0.0
---

# Invoke-MgShareTeamSchedule

## SYNOPSIS
Share a schedule time range with schedule members.\nMake the collections of shift, openshift and timeOff items in the specified time range of the schedule viewable by the specified team members, including employees and managers.\nEach shift, openshift and timeOff instance in a schedule supports a draft version and a shared version of the item.
The draft version is viewable by only managers, and the shared version is viewable by employees and managers.
For each shift, openshift and timeOff instance in the specified time range, the share action updates the shared version from the draft version, so that in addition to managers, employees can also view the most current information about the item.
The **notifyTeam** parameter further specifies which employees can view the item.

## SYNTAX

### ShareExpanded1 (Default)
```
Invoke-MgShareTeamSchedule -TeamId <String> [-AdditionalProperties <Hashtable>] [-EndDateTime <DateTime>]
 [-NotifyTeam] [-StartDateTime <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Share1
```
Invoke-MgShareTeamSchedule -TeamId <String>
 -BodyParameter <IPathsCo6ShtTeamsTeamIdScheduleMicrosoftGraphSharePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ShareViaIdentity1
```
Invoke-MgShareTeamSchedule -InputObject <ITeamsIdentity>
 -BodyParameter <IPathsCo6ShtTeamsTeamIdScheduleMicrosoftGraphSharePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ShareViaIdentityExpanded1
```
Invoke-MgShareTeamSchedule -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-EndDateTime <DateTime>] [-NotifyTeam] [-StartDateTime <DateTime>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Share a schedule time range with schedule members.\nMake the collections of shift, openshift and timeOff items in the specified time range of the schedule viewable by the specified team members, including employees and managers.\nEach shift, openshift and timeOff instance in a schedule supports a draft version and a shared version of the item.
The draft version is viewable by only managers, and the shared version is viewable by employees and managers.
For each shift, openshift and timeOff instance in the specified time range, the share action updates the shared version from the draft version, so that in addition to managers, employees can also view the most current information about the item.
The **notifyTeam** parameter further specifies which employees can view the item.

## EXAMPLES

### Example 1: Using the Invoke-MgShareTeamSchedule Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	NotifyTeam = $true
	StartDateTime = [System.DateTime]::Parse("2018-10-08T00:00:00.000Z")
	EndDateTime = [System.DateTime]::Parse("2018-10-15T00:00:00.000Z")
}
Invoke-MgShareTeamSchedule -TeamId $teamId -BodyParameter $params
```

This example shows how to use the Invoke-MgShareTeamSchedule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ShareExpanded1, ShareViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPathsCo6ShtTeamsTeamIdScheduleMicrosoftGraphSharePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Share1, ShareViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EndDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: ShareExpanded1, ShareViaIdentityExpanded1
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
Parameter Sets: ShareViaIdentity1, ShareViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NotifyTeam
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ShareExpanded1, ShareViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -StartDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: ShareExpanded1, ShareViaIdentityExpanded1
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
Parameter Sets: Share1, ShareExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPathsCo6ShtTeamsTeamIdScheduleMicrosoftGraphSharePostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsCo6ShtTeamsTeamIdScheduleMicrosoftGraphSharePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EndDateTime <DateTime?>]`: 
  - `[NotifyTeam <Boolean?>]`: 
  - `[StartDateTime <DateTime?>]`: 

INPUTOBJECT <ITeamsIdentity>: Identity Parameter
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

## RELATED LINKS

