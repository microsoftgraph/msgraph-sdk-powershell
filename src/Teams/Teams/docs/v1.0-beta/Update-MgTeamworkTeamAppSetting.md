---
external help file:
Module Name: Microsoft.Graph.Beta.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.teams/update-mgteamworkteamappsetting
schema: 2.0.0
---

# Update-MgBetaTeamworkTeamAppSetting

## SYNOPSIS
Update the properties of a teamsAppSettings object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTeamworkTeamAppSetting [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-IsChatResourceSpecificConsentEnabled] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaTeamworkTeamAppSetting -BodyParameter <IMicrosoftGraphTeamsAppSettings> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a teamsAppSettings object.

## EXAMPLES

### Example 1: Using the Update-MgBetaTeamworkTeamAppSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.teamsAppSettings"
	IsChatResourceSpecificConsentEnabled = "true"
}
Update-MgBetaTeamworkTeamAppSetting -BodyParameter $params
```

This example shows how to use the Update-MgBetaTeamworkTeamAppSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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

### -BodyParameter
teamsAppSettings
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppSettings
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
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

### -IsChatResourceSpecificConsentEnabled
Indicates whether resource-specific consent for chats/meetings has been enabled for the tenant.
If true, Teams apps that are allowed in the tenant and require resource-specific permissions can be installed inside chats and meetings.
If false, the installation of any Teams app that requires resource-specific permissions in a chat or a meeting will be blocked.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppSettings

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTeamsAppSettings>: teamsAppSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[IsChatResourceSpecificConsentEnabled <Boolean?>]`: Indicates whether resource-specific consent for chats/meetings has been enabled for the tenant. If true, Teams apps that are allowed in the tenant and require resource-specific permissions can be installed inside chats and meetings. If false, the installation of any Teams app that requires resource-specific permissions in a chat or a meeting will be blocked.

## RELATED LINKS

