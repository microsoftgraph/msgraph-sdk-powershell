---
external help file:
Module Name: Microsoft.Graph.Teams.AppCatalogs
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.appcatalogs/update-mgappcatalogteamappdefinition
schema: 2.0.0
---

# Update-MgAppCatalogTeamAppDefinition

## SYNOPSIS
Update the navigation property appDefinitions in appCatalogs

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgAppCatalogTeamAppDefinition -TeamsAppDefinitionId <String> -TeamsAppId <String>
 [-DisplayName <String>] [-Id <String>] [-TeamsAppId1 <String>] [-Version <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgAppCatalogTeamAppDefinition -TeamsAppDefinitionId <String> -TeamsAppId <String>
 -BodyParameter <IMicrosoftGraphTeamsAppDefinition> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgAppCatalogTeamAppDefinition -InputObject <ITeamsAppCatalogsIdentity>
 -BodyParameter <IMicrosoftGraphTeamsAppDefinition> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgAppCatalogTeamAppDefinition -InputObject <ITeamsAppCatalogsIdentity> [-TeamsAppId <String>]
 [-DisplayName <String>] [-Id <String>] [-Version <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property appDefinitions in appCatalogs

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
teamsAppDefinition
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppDefinition
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The name of the app provided by the app developer.

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
Type: Microsoft.Graph.PowerShell.Models.ITeamsAppCatalogsIdentity
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

### -TeamsAppDefinitionId
key: teamsAppDefinition-id of teamsAppDefinition

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

### -TeamsAppId
key: teamsApp-id of teamsApp

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsAppId1
The id from the Teams App manifest.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
The version number of the application.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppDefinition

### Microsoft.Graph.PowerShell.Models.ITeamsAppCatalogsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTeamsAppDefinition>: teamsAppDefinition
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: The name of the app provided by the app developer.
  - `[TeamsAppId <String>]`: The id from the Teams App manifest.
  - `[Version <String>]`: The version number of the application.

INPUTOBJECT <ITeamsAppCatalogsIdentity>: Identity Parameter
  - `[TeamsAppDefinitionId <String>]`: key: teamsAppDefinition-id of teamsAppDefinition
  - `[TeamsAppId <String>]`: key: teamsApp-id of teamsApp

## RELATED LINKS

