---
external help file:
Module Name: Microsoft.Graph.Teams.AppCatalogs
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.appcatalogs/update-mgappcatalog
schema: 2.0.0
---

# Update-MgAppCatalog

## SYNOPSIS
Update appCatalogs

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgAppCatalog [-Id <String>] [-TeamsApps <IMicrosoftGraphTeamsApp1[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgAppCatalog -BodyParameter <IMicrosoftGraphAppCatalogs> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update appCatalogs

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
appCatalogs
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppCatalogs
Parameter Sets: Update1
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
Type: System.String
Parameter Sets: UpdateExpanded1
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

### -TeamsApps
.
To construct, see NOTES section for TEAMSAPPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsApp1[]
Parameter Sets: UpdateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppCatalogs

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAppCatalogs>: appCatalogs
  - `[Id <String>]`: Read-only.
  - `[TeamsApps <IMicrosoftGraphTeamsApp1[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The name of the app provided by the app developer.
      - `[TeamsAppId <String>]`: The id from the Teams App manifest.
      - `[Version <String>]`: The version number of the application.
    - `[DisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
    - `[DistributionMethod <String>]`: teamsAppDistributionMethod
    - `[ExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.

TEAMSAPPS <IMicrosoftGraphTeamsApp1[]>: .
  - `[Id <String>]`: Read-only.
  - `[AppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the app provided by the app developer.
    - `[TeamsAppId <String>]`: The id from the Teams App manifest.
    - `[Version <String>]`: The version number of the application.
  - `[DisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
  - `[DistributionMethod <String>]`: teamsAppDistributionMethod
  - `[ExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.

## RELATED LINKS

