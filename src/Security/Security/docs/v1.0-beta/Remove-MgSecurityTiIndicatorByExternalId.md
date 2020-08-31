---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/remove-mgsecuritytiindicatorbyexternalid
schema: 2.0.0
---

# Remove-MgSecurityTiIndicatorByExternalId

## SYNOPSIS
Invoke action deleteTiIndicatorsByExternalId

## SYNTAX

### DeleteExpanded1 (Default)
```
Remove-MgSecurityTiIndicatorByExternalId [-Value <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Delete1
```
Remove-MgSecurityTiIndicatorByExternalId
 -BodyParameter <IPaths1Gb7He6SecurityTiindicatorsMicrosoftGraphDeletetiindicatorsbyexternalidPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action deleteTiIndicatorsByExternalId

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1Gb7He6SecurityTiindicatorsMicrosoftGraphDeletetiindicatorsbyexternalidPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Delete1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Value
.

```yaml
Type: System.String[]
Parameter Sets: DeleteExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPaths1Gb7He6SecurityTiindicatorsMicrosoftGraphDeletetiindicatorsbyexternalidPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphResultInfo

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Gb7He6SecurityTiindicatorsMicrosoftGraphDeletetiindicatorsbyexternalidPostRequestbodyContentApplicationJsonSchema>: .
  - `[Value <String[]>]`: 

## RELATED LINKS

