---
external help file:
Module Name: Microsoft.Graph.Teams.Teamwork
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.teamwork/new-mguserteamworkinstalledapp
schema: 2.0.0
---

# New-MgUserTeamworkInstalledApp

## SYNOPSIS
Create new navigation property to installedApps for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserTeamworkInstalledApp -UserId <String> [-Id <String>] [-TeamAppDefinitionDisplayName <String>]
 [-TeamAppDefinitionId <String>] [-TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]
 [-TeamAppDefinitionTeamsAppId <String>] [-TeamAppDefinitionVersion <String>] [-TeamAppDisplayName <String>]
 [-TeamAppDistributionMethod <String>] [-TeamAppExternalId <String>] [-TeamAppId <String>]
 [-TeamAppName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserTeamworkInstalledApp -UserId <String> -BodyParameter <IMicrosoftGraphTeamsAppInstallation>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserTeamworkInstalledApp -InputObject <ITeamsTeamworkIdentity>
 -BodyParameter <IMicrosoftGraphTeamsAppInstallation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserTeamworkInstalledApp -InputObject <ITeamsTeamworkIdentity> [-Id <String>]
 [-TeamAppDefinitionDisplayName <String>] [-TeamAppDefinitionId <String>]
 [-TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>] [-TeamAppDefinitionTeamsAppId <String>]
 [-TeamAppDefinitionVersion <String>] [-TeamAppDisplayName <String>] [-TeamAppDistributionMethod <String>]
 [-TeamAppExternalId <String>] [-TeamAppId <String>] [-TeamAppName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to installedApps for users

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
teamsAppInstallation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppInstallation
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
Type: Microsoft.Graph.PowerShell.Models.ITeamsTeamworkIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -TeamAppDefinitionDisplayName
The name of the app provided by the app developer.

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

### -TeamAppDefinitionId
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

### -TeamAppDefinitions
The details for each version of the app.
To construct, see NOTES section for TEAMAPPDEFINITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppDefinition[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamAppDefinitionTeamsAppId
The id from the Teams App manifest.

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

### -TeamAppDefinitionVersion
The version number of the application.

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

### -TeamAppDisplayName
The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.

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

### -TeamAppDistributionMethod
teamsAppDistributionMethod

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

### -TeamAppExternalId
The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.

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

### -TeamAppId
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

### -TeamAppName
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

### -UserId
key: user-id of user

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppInstallation

### Microsoft.Graph.PowerShell.Models.ITeamsTeamworkIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppInstallation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTeamsAppInstallation>: teamsAppInstallation
  - `[Id <String>]`: Read-only.
  - `[TeamAppDefinitionDisplayName <String>]`: The name of the app provided by the app developer.
  - `[TeamAppDefinitionId <String>]`: Read-only.
  - `[TeamAppDefinitionTeamsAppId <String>]`: The id from the Teams App manifest.
  - `[TeamAppDefinitionVersion <String>]`: The version number of the application.
  - `[TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the app provided by the app developer.
    - `[TeamsAppId <String>]`: The id from the Teams App manifest.
    - `[Version <String>]`: The version number of the application.
  - `[TeamAppDisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
  - `[TeamAppDistributionMethod <String>]`: teamsAppDistributionMethod
  - `[TeamAppExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
  - `[TeamAppId <String>]`: Read-only.
  - `[TeamAppName <String>]`: 

INPUTOBJECT <ITeamsTeamworkIdentity>: Identity Parameter
  - `[TeamsAppInstallationId <String>]`: key: teamsAppInstallation-id of teamsAppInstallation
  - `[UserId <String>]`: key: user-id of user

TEAMAPPDEFINITIONS <IMicrosoftGraphTeamsAppDefinition[]>: The details for each version of the app.
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: The name of the app provided by the app developer.
  - `[TeamsAppId <String>]`: The id from the Teams App manifest.
  - `[Version <String>]`: The version number of the application.

## RELATED LINKS

