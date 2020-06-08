---
external help file:
Module Name: Microsoft.Graph.Teams.Team
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.team/update-mgteamprimarychannel
schema: 2.0.0
---

# Update-MgTeamPrimaryChannel

## SYNOPSIS
Update the navigation property primaryChannel in teams

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTeamPrimaryChannel -TeamId <String> [-Description <String>] [-DisplayName <String>] [-Email <String>]
 [-Id <String>] [-Tabs <IMicrosoftGraphTeamsTab[]>] [-WebUrl <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgTeamPrimaryChannel -TeamId <String> -BodyParameter <IMicrosoftGraphChannel> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTeamPrimaryChannel -InputObject <ITeamsTeamIdentity> -BodyParameter <IMicrosoftGraphChannel>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTeamPrimaryChannel -InputObject <ITeamsTeamIdentity> [-Description <String>] [-DisplayName <String>]
 [-Email <String>] [-Id <String>] [-Tabs <IMicrosoftGraphTeamsTab[]>] [-WebUrl <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property primaryChannel in teams

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
channel
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChannel
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Optional textual description for the channel.

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

### -DisplayName
Channel name as it will appear to the user in Microsoft Teams.

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

### -Email
The email address for sending messages to the channel.
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

### -Tabs
A collection of all the tabs in the channel.
A navigation property.
To construct, see NOTES section for TABS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsTab[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WebUrl
A hyperlink that will navigate to the channel in Microsoft Teams.
This is the URL that you get when you right-click a channel in Microsoft Teams and select Get link to channel.
This URL should be treated as an opaque blob, and not parsed.
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChannel

### Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphChannel>: channel
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

TABS <IMicrosoftGraphTeamsTab[]>: A collection of all the tabs in the channel. A navigation property.
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

## RELATED LINKS

