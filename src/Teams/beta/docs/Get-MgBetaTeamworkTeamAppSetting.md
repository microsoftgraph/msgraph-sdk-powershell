---
external help file:
Module Name: Microsoft.Graph.Beta.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.teams/get-mgbetateamworkteamappsetting
schema: 2.0.0
---

# Get-MgBetaTeamworkTeamAppSetting

## SYNOPSIS
Read the properties and relationships of a teamsAppSettings object.

## SYNTAX

```
Get-MgBetaTeamworkTeamAppSetting [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Read the properties and relationships of a teamsAppSettings object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeamworkTeamAppSetting
```



## PARAMETERS

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppSettings

## NOTES

ALIASES

## RELATED LINKS

