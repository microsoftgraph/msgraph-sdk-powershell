---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/update-mgbetasecurityinformationprotectionlabelpolicysetting
schema: 2.0.0
---

# Update-MgBetaSecurityInformationProtectionLabelPolicySetting

## SYNOPSIS
Update the navigation property labelPolicySettings in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaSecurityInformationProtectionLabelPolicySetting [-AdditionalProperties <Hashtable>]
 [-DefaultLabelId <String>] [-Id <String>] [-IsDowngradeJustificationRequired] [-IsMandatory]
 [-MoreInfoUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaSecurityInformationProtectionLabelPolicySetting
 -BodyParameter <IMicrosoftGraphSecurityInformationProtectionPolicySetting> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property labelPolicySettings in security

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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
informationProtectionPolicySetting
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityInformationProtectionPolicySetting
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultLabelId
.

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

### -IsDowngradeJustificationRequired
Exposes whether justification input is required on label downgrade.

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

### -IsMandatory
Exposes whether mandatory labeling is enabled.

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

### -MoreInfoUrl
Exposes the more information URL that can be configured by the administrator.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityInformationProtectionPolicySetting

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityInformationProtectionPolicySetting

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSecurityInformationProtectionPolicySetting>`: informationProtectionPolicySetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DefaultLabelId <String>]`: 
  - `[IsDowngradeJustificationRequired <Boolean?>]`: Exposes whether justification input is required on label downgrade.
  - `[IsMandatory <Boolean?>]`: Exposes whether mandatory labeling is enabled.
  - `[MoreInfoUrl <String>]`: Exposes the more information URL that can be configured by the administrator.

## RELATED LINKS

