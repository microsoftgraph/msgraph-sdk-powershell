---
external help file:
Module Name: Microsoft.Graph.Teams.Team
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.team/new-mgteamchanneltab
schema: 2.0.0
---

# New-MgTeamChannelTab

## SYNOPSIS
Create new navigation property to tabs for teams

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgTeamChannelTab -ChannelId <String> -TeamId <String> [-ConfigurationContentUrl <String>]
 [-ConfigurationEntityId <String>] [-ConfigurationRemoveUrl <String>] [-ConfigurationWebsiteUrl <String>]
 [-DisplayName <String>] [-Id <String>] [-MessageId <String>] [-SortOrderIndex <String>]
 [-TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition1[]>] [-TeamAppDisplayName <String>]
 [-TeamAppDistributionMethod <String>] [-TeamAppExternalId <String>] [-TeamAppId <String>]
 [-TeamsAppId <String>] [-WebUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgTeamChannelTab -ChannelId <String> -TeamId <String> -BodyParameter <IMicrosoftGraphTeamsTab1> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgTeamChannelTab -InputObject <ITeamsTeamIdentity> -BodyParameter <IMicrosoftGraphTeamsTab1> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgTeamChannelTab -InputObject <ITeamsTeamIdentity> [-ConfigurationContentUrl <String>]
 [-ConfigurationEntityId <String>] [-ConfigurationRemoveUrl <String>] [-ConfigurationWebsiteUrl <String>]
 [-DisplayName <String>] [-Id <String>] [-MessageId <String>] [-SortOrderIndex <String>]
 [-TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition1[]>] [-TeamAppDisplayName <String>]
 [-TeamAppDistributionMethod <String>] [-TeamAppExternalId <String>] [-TeamAppId <String>]
 [-TeamsAppId <String>] [-WebUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to tabs for teams

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
teamsTab
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsTab1
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChannelId
key: channel-id of channel

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

### -ConfigurationContentUrl
Url used for rendering tab contents in Teams.
Required.

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

### -ConfigurationEntityId
Identifier for the entity hosted by the tab provider.

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

### -ConfigurationRemoveUrl
Url called by Teams client when a Tab is removed using the Teams Client.

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

### -ConfigurationWebsiteUrl
Url for showing tab contents outside of Teams.

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

### -DisplayName
Name of the tab.

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

### -MessageId
.

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

### -SortOrderIndex
.

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

### -TeamAppDefinitions
The details for each version of the app.
To construct, see NOTES section for TEAMAPPDEFINITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppDefinition1[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamAppDisplayName
The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.

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

### -TeamAppDistributionMethod
teamsAppDistributionMethod

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

### -TeamAppExternalId
The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.

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

### -TeamAppId
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

### -TeamsAppId
.

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

### -WebUrl
Deep link url of the tab instance.
Read only.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsTab1

### Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsTab1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTeamsTab1>: teamsTab
  - `[Id <String>]`: Read-only.
  - `[ConfigurationContentUrl <String>]`: Url used for rendering tab contents in Teams. Required.
  - `[ConfigurationEntityId <String>]`: Identifier for the entity hosted by the tab provider.
  - `[ConfigurationRemoveUrl <String>]`: Url called by Teams client when a Tab is removed using the Teams Client.
  - `[ConfigurationWebsiteUrl <String>]`: Url for showing tab contents outside of Teams.
  - `[DisplayName <String>]`: Name of the tab.
  - `[MessageId <String>]`: 
  - `[SortOrderIndex <String>]`: 
  - `[TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition1[]>]`: The details for each version of the app.
    - `[Id <String>]`: Read-only.
    - `[AzureAdAppId <String>]`: 
    - `[DisplayName <String>]`: The name of the app provided by the app developer.
    - `[PublishingState <String>]`: teamsAppPublishingState
    - `[TeamsAppId <String>]`: The id from the Teams App manifest.
    - `[Version <String>]`: The version number of the application.
  - `[TeamAppDisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
  - `[TeamAppDistributionMethod <String>]`: teamsAppDistributionMethod
  - `[TeamAppExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
  - `[TeamAppId <String>]`: Read-only.
  - `[TeamsAppId <String>]`: 
  - `[WebUrl <String>]`: Deep link url of the tab instance. Read only.

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

TEAMAPPDEFINITIONS <IMicrosoftGraphTeamsAppDefinition1[]>: The details for each version of the app.
  - `[Id <String>]`: Read-only.
  - `[AzureAdAppId <String>]`: 
  - `[DisplayName <String>]`: The name of the app provided by the app developer.
  - `[PublishingState <String>]`: teamsAppPublishingState
  - `[TeamsAppId <String>]`: The id from the Teams App manifest.
  - `[Version <String>]`: The version number of the application.

## RELATED LINKS

