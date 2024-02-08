---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.actions/enable-mgbetadevicemanagementtenantattachrbac
schema: 2.0.0
---

# Enable-MgBetaDeviceManagementTenantAttachRbac

## SYNOPSIS
Invoke action enable

## SYNTAX

### EnableExpanded (Default)
```
Enable-MgBetaDeviceManagementTenantAttachRbac [-AdditionalProperties <Hashtable>] [-Enable] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Enable
```
Enable-MgBetaDeviceManagementTenantAttachRbac
 -BodyParameter <IPaths118806LDevicemanagementTenantattachrbacMicrosoftGraphEnablePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action enable

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: EnableExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths118806LDevicemanagementTenantattachrbacMicrosoftGraphEnablePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Enable
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Enable
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: EnableExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths118806LDevicemanagementTenantattachrbacMicrosoftGraphEnablePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths118806LDevicemanagementTenantattachrbacMicrosoftGraphEnablePostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Enable <Boolean?>]`: 

## RELATED LINKS

