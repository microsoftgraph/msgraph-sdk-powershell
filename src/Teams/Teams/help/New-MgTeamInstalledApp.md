---
external help file: Microsoft.Graph.Teams-help.xml
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgteaminstalledapp
schema: 2.0.0
---

# New-MgTeamInstalledApp

## SYNOPSIS
Create new navigation property to installedApps for teams

## SYNTAX

### CreateExpanded (Default)
```
New-MgTeamInstalledApp -TeamId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-TeamsApp <IMicrosoftGraphTeamsApp>] [-TeamsAppDefinition <IMicrosoftGraphTeamsAppDefinition>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgTeamInstalledApp -TeamId <String> -BodyParameter <IMicrosoftGraphTeamsAppInstallation> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgTeamInstalledApp -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-TeamsApp <IMicrosoftGraphTeamsApp>] [-TeamsAppDefinition <IMicrosoftGraphTeamsAppDefinition>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgTeamInstalledApp -InputObject <ITeamsIdentity> -BodyParameter <IMicrosoftGraphTeamsAppInstallation>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to installedApps for teams

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
teamsAppInstallation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamsAppInstallation
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
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
Type: ITeamsIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -TeamId
key: id of team

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsApp
teamsApp
To construct, see NOTES section for TEAMSAPP properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamsApp
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsAppDefinition
teamsAppDefinition
To construct, see NOTES section for TEAMSAPPDEFINITION properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamsAppDefinition
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppInstallation
### Microsoft.Graph.PowerShell.Models.ITeamsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppInstallation
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphTeamsAppInstallation1\>: teamsAppInstallation
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[TeamsApp \<IMicrosoftGraphTeamsApp1\>\]: teamsApp
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AppDefinitions \<IMicrosoftGraphTeamsAppDefinition1\[\]\>\]: The details for each version of the app.
      \[Id \<String\>\]: Read-only.
      \[DisplayName \<String\>\]: The name of the app provided by the app developer.
      \[TeamsAppId \<String\>\]: The ID from the Teams app manifest.
      \[Version \<String\>\]: The version number of the application.
    \[DisplayName \<String\>\]: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
    \[DistributionMethod \<String\>\]: teamsAppDistributionMethod
    \[ExternalId \<String\>\]: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
  \[TeamsAppDefinition \<IMicrosoftGraphTeamsAppDefinition1\>\]: teamsAppDefinition

INPUTOBJECT \<ITeamsIdentity\>: Identity Parameter
  \[ChannelId \<String\>\]: key: id of channel
  \[ChatId \<String\>\]: key: id of chat
  \[ChatMessageHostedContentId \<String\>\]: key: id of chatMessageHostedContent
  \[ChatMessageId \<String\>\]: key: id of chatMessage
  \[ChatMessageId1 \<String\>\]: key: id of chatMessage
  \[ConversationMemberId \<String\>\]: key: id of conversationMember
  \[GroupId \<String\>\]: key: id of group
  \[OfferShiftRequestId \<String\>\]: key: id of offerShiftRequest
  \[OpenShiftChangeRequestId \<String\>\]: key: id of openShiftChangeRequest
  \[OpenShiftId \<String\>\]: key: id of openShift
  \[SchedulingGroupId \<String\>\]: key: id of schedulingGroup
  \[ShiftId \<String\>\]: key: id of shift
  \[SwapShiftsChangeRequestId \<String\>\]: key: id of swapShiftsChangeRequest
  \[TeamId \<String\>\]: key: id of team
  \[TeamsAppDefinitionId \<String\>\]: key: id of teamsAppDefinition
  \[TeamsAppId \<String\>\]: key: id of teamsApp
  \[TeamsAppInstallationId \<String\>\]: key: id of teamsAppInstallation
  \[TeamsAsyncOperationId \<String\>\]: key: id of teamsAsyncOperation
  \[TeamsTabId \<String\>\]: key: id of teamsTab
  \[TimeCardId \<String\>\]: key: id of timeCard
  \[TimeOffId \<String\>\]: key: id of timeOff
  \[TimeOffReasonId \<String\>\]: key: id of timeOffReason
  \[TimeOffRequestId \<String\>\]: key: id of timeOffRequest
  \[UserId \<String\>\]: key: id of user
  \[UserScopeTeamsAppInstallationId \<String\>\]: key: id of userScopeTeamsAppInstallation
  \[WorkforceIntegrationId \<String\>\]: key: id of workforceIntegration

TEAMSAPP \<IMicrosoftGraphTeamsApp1\>: teamsApp
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AppDefinitions \<IMicrosoftGraphTeamsAppDefinition1\[\]\>\]: The details for each version of the app.
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: The name of the app provided by the app developer.
    \[TeamsAppId \<String\>\]: The ID from the Teams app manifest.
    \[Version \<String\>\]: The version number of the application.
  \[DisplayName \<String\>\]: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
  \[DistributionMethod \<String\>\]: teamsAppDistributionMethod
  \[ExternalId \<String\>\]: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.

TEAMSAPPDEFINITION \<IMicrosoftGraphTeamsAppDefinition1\>: teamsAppDefinition
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[DisplayName \<String\>\]: The name of the app provided by the app developer.
  \[TeamsAppId \<String\>\]: The ID from the Teams app manifest.
  \[Version \<String\>\]: The version number of the application.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgteaminstalledapp](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgteaminstalledapp)

