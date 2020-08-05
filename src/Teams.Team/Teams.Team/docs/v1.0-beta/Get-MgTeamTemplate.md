---
external help file:
Module Name: Microsoft.Graph.Teams.Team
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.team/get-mgteamtemplate
schema: 2.0.0
---

# Get-MgTeamTemplate

## SYNOPSIS
Get template from teams

## SYNTAX

### List (Default)
```
Get-MgTeamTemplate [-Count] [-ExpandProperty <String[]>] [-Filter <String>] [-PageSize <Int32>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-All] [<CommonParameters>]
```

### Get
```
Get-MgTeamTemplate -TeamId <String> [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get1
```
Get-MgTeamTemplate -TeamsTemplateId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgTeamTemplate -InputObject <ITeamsTeamIdentity> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgTeamTemplate -InputObject <ITeamsTeamIdentity> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Get template from teams

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

### -All
List all pages

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Count
Include count of items

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List
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
Parameter Sets: GetViaIdentity, GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases: Top, Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List
Aliases: OrderBy

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
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsTemplateId
key: teamsTemplate-id of teamsTemplate

```yaml
Type: System.String
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsTemplate

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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
  - `[TeamsTabId <String>]`: key: teamsTab-id of teamsTab
  - `[TeamsTemplateId <String>]`: key: teamsTemplate-id of teamsTemplate
  - `[TimeOffId <String>]`: key: timeOff-id of timeOff
  - `[TimeOffReasonId <String>]`: key: timeOffReason-id of timeOffReason
  - `[TimeOffRequestId <String>]`: key: timeOffRequest-id of timeOffRequest
  - `[UserId <String>]`: key: user-id of user
  - `[WorkforceIntegrationId <String>]`: key: workforceIntegration-id of workforceIntegration

## RELATED LINKS

