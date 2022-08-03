---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecurityinformationprotection
schema: 2.0.0
---

# Update-MgSecurityInformationProtection

## SYNOPSIS
Update the navigation property informationProtection in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityInformationProtection [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-LabelPolicySettings <IMicrosoftGraphSecurityInformationProtectionPolicySetting>]
 [-SensitivityLabels <IMicrosoftGraphSecuritySensitivityLabel[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgSecurityInformationProtection -BodyParameter <IMicrosoftGraphSecurityInformationProtection>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property informationProtection in security

## EXAMPLES

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
informationProtection
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityInformationProtection
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
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

### -LabelPolicySettings
informationProtectionPolicySetting
To construct, please use Get-Help -Online and see NOTES section for LABELPOLICYSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityInformationProtectionPolicySetting
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

### -SensitivityLabels
.
To construct, please use Get-Help -Online and see NOTES section for SENSITIVITYLABELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecuritySensitivityLabel[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityInformationProtection

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSecurityInformationProtection>: informationProtection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[LabelPolicySettings <IMicrosoftGraphSecurityInformationProtectionPolicySetting>]`: informationProtectionPolicySetting
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DefaultLabelId <String>]`: 
    - `[IsDowngradeJustificationRequired <Boolean?>]`: 
    - `[IsMandatory <Boolean?>]`: 
    - `[MoreInfoUrl <String>]`: 
  - `[SensitivityLabels <IMicrosoftGraphSecuritySensitivityLabel[]>]`: 
    - `[Id <String>]`: 
    - `[Color <String>]`: 
    - `[ContentFormats <String[]>]`: 
    - `[Description <String>]`: 
    - `[HasProtection <Boolean?>]`: 
    - `[IsActive <Boolean?>]`: 
    - `[IsAppliable <Boolean?>]`: 
    - `[Name <String>]`: 
    - `[Parent <IMicrosoftGraphSecuritySensitivityLabel>]`: sensitivityLabel
    - `[Sensitivity <Int32?>]`: 
    - `[Tooltip <String>]`: 

LABELPOLICYSETTINGS <IMicrosoftGraphSecurityInformationProtectionPolicySetting>: informationProtectionPolicySetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DefaultLabelId <String>]`: 
  - `[IsDowngradeJustificationRequired <Boolean?>]`: 
  - `[IsMandatory <Boolean?>]`: 
  - `[MoreInfoUrl <String>]`: 

SENSITIVITYLABELS <IMicrosoftGraphSecuritySensitivityLabel[]>: .
  - `[Id <String>]`: 
  - `[Color <String>]`: 
  - `[ContentFormats <String[]>]`: 
  - `[Description <String>]`: 
  - `[HasProtection <Boolean?>]`: 
  - `[IsActive <Boolean?>]`: 
  - `[IsAppliable <Boolean?>]`: 
  - `[Name <String>]`: 
  - `[Parent <IMicrosoftGraphSecuritySensitivityLabel>]`: sensitivityLabel
  - `[Sensitivity <Int32?>]`: 
  - `[Tooltip <String>]`: 

## RELATED LINKS

