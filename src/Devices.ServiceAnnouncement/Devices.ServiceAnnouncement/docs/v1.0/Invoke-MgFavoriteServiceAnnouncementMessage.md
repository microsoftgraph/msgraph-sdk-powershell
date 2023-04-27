---
external help file:
Module Name: Microsoft.Graph.Devices.ServiceAnnouncement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.serviceannouncement/invoke-mgfavoriteserviceannouncementmessage
schema: 2.0.0
---

# Invoke-MgFavoriteServiceAnnouncementMessage

## SYNOPSIS
Invoke action favorite

## SYNTAX

### FavoriteExpanded1 (Default)
```
Invoke-MgFavoriteServiceAnnouncementMessage [-AdditionalProperties <Hashtable>] [-MessageIds <String[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Favorite1
```
Invoke-MgFavoriteServiceAnnouncementMessage
 -BodyParameter <IPaths1Hqlbr0AdminServiceannouncementMessagesMicrosoftGraphFavoritePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action favorite

## EXAMPLES

### Example 1: Using the Invoke-MgFavoriteServiceAnnouncementMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
$params = @{
	MessageIds = @(
		"MC172851"
		"MC167983"
	)
}
Invoke-MgFavoriteServiceAnnouncementMessage -BodyParameter $params
```

This example shows how to use the Invoke-MgFavoriteServiceAnnouncementMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: FavoriteExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1Hqlbr0AdminServiceannouncementMessagesMicrosoftGraphFavoritePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Favorite1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MessageIds
.

```yaml
Type: System.String[]
Parameter Sets: FavoriteExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPaths1Hqlbr0AdminServiceannouncementMessagesMicrosoftGraphFavoritePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Hqlbr0AdminServiceannouncementMessagesMicrosoftGraphFavoritePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MessageIds <String[]>]`: 

## RELATED LINKS

