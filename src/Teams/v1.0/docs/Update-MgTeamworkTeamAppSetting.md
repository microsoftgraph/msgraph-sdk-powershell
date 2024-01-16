---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.teams/update-mgteamworkteamappsetting
schema: 2.0.0
---

# Update-MgTeamworkTeamAppSetting

## SYNOPSIS
Update the tenant-wide teamsAppSettings for all Teams apps in the tenant.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTeamworkTeamAppSetting [-AdditionalProperties <Hashtable>] [-AllowUserRequestsForAppAccess]
 [-Id <String>] [-IsUserPersonalScopeResourceSpecificConsentEnabled] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTeamworkTeamAppSetting -BodyParameter <IMicrosoftGraphTeamsAppSettings> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the tenant-wide teamsAppSettings for all Teams apps in the tenant.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Teams
```

$params = @{
	"@odata.type" = "#microsoft.graph.teamsAppSettings"
	allowUserRequestsForAppAccess = "true"
}

Update-MgTeamworkTeamAppSetting -BodyParameter $params

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowUserRequestsForAppAccess
Indicates whether users are allowed to request access to the unavailable Teams apps.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
teamsAppSettings
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppSettings
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

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

### -IsUserPersonalScopeResourceSpecificConsentEnabled
Indicates whether resource-specific consent for personal scope in Teams apps is enabled for the tenant.
True indicates that Teams apps that are allowed in the tenant and require resource-specific permissions can be installed in the personal scope.
False blocks the installation of any Teams app that requires resource-specific permissions in the personal scope.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppSettings

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppSettings

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphTeamsAppSettings>`: teamsAppSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowUserRequestsForAppAccess <Boolean?>]`: Indicates whether users are allowed to request access to the unavailable Teams apps.
  - `[IsUserPersonalScopeResourceSpecificConsentEnabled <Boolean?>]`: Indicates whether resource-specific consent for personal scope in Teams apps is enabled for the tenant. True indicates that Teams apps that are allowed in the tenant and require resource-specific permissions can be installed in the personal scope. False blocks the installation of any Teams app that requires resource-specific permissions in the personal scope.

## RELATED LINKS

