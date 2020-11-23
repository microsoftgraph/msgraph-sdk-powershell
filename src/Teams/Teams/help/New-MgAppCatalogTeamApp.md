---
external help file: Microsoft.Graph.Teams-help.xml
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgappcatalogteamapp
schema: 2.0.0
---

# New-MgAppCatalogTeamApp

## SYNOPSIS
Create new navigation property to teamsApps for appCatalogs

## SYNTAX

### CreateExpanded (Default)
```
New-MgAppCatalogTeamApp [-AdditionalProperties <Hashtable>]
 [-AppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>] [-DisplayName <String>] [-DistributionMethod <String>]
 [-ExternalId <String>] [-Id <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgAppCatalogTeamApp -BodyParameter <IMicrosoftGraphTeamsApp> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to teamsApps for appCatalogs

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppDefinitions
The details for each version of the app.
To construct, see NOTES section for APPDEFINITIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamsAppDefinition[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
teamsApp
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamsApp
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DistributionMethod
teamsAppDistributionMethod

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalId
The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.

```yaml
Type: String
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsApp
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsApp
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

APPDEFINITIONS \<IMicrosoftGraphTeamsAppDefinition1\[\]\>: The details for each version of the app.
  \[Id \<String\>\]: Read-only.
  \[DisplayName \<String\>\]: The name of the app provided by the app developer.
  \[TeamsAppId \<String\>\]: The ID from the Teams app manifest.
  \[Version \<String\>\]: The version number of the application.

BODYPARAMETER \<IMicrosoftGraphTeamsApp1\>: teamsApp
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

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgappcatalogteamapp](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgappcatalogteamapp)

