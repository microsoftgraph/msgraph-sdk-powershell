---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mginformationprotectionpolicylabel
schema: 2.0.0
---

# New-MgInformationProtectionPolicyLabel

## SYNOPSIS
Create new navigation property to labels for informationProtection

## SYNTAX

### CreateExpanded (Default)
```
New-MgInformationProtectionPolicyLabel [-AdditionalProperties <Hashtable>] [-Color <String>]
 [-Description <String>] [-Id <String>] [-IsActive] [-Name <String>]
 [-Parent <IMicrosoftGraphParentLabelDetails>] [-Sensitivity <Int32>] [-Tooltip <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgInformationProtectionPolicyLabel -BodyParameter <IMicrosoftGraphInformationProtectionLabel> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to labels for informationProtection

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
informationProtectionLabel
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInformationProtectionLabel
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Color
The color that the UI should display for the label, if configured.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The admin-defined description for the label.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsActive
Indicates whether the label is active or not.
Active labels should be hidden or disabled in UI.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The plaintext name of the label.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Parent
parentLabelDetails
To construct, please use Get-Help -Online and see NOTES section for PARENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParentLabelDetails
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sensitivity
The sensitivity value of the label, where lower is less sensitive.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tooltip
The tooltip that should be displayed for the label in a UI.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInformationProtectionLabel

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInformationProtectionLabel

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphInformationProtectionLabel>: informationProtectionLabel
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Color <String>]`: The color that the UI should display for the label, if configured.
  - `[Description <String>]`: The admin-defined description for the label.
  - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in UI.
  - `[Name <String>]`: The plaintext name of the label.
  - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Color <String>]`: The color that the user interface should display for the label, if configured.
    - `[Description <String>]`: The admin-defined description for the label.
    - `[Id <String>]`: The label ID is a globally unique identifier (GUID).
    - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in user interfaces.
    - `[Name <String>]`: The plaintext name of the label.
    - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
    - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
    - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a user interface.
  - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
  - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a UI.

PARENT <IMicrosoftGraphParentLabelDetails>: parentLabelDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Color <String>]`: The color that the user interface should display for the label, if configured.
  - `[Description <String>]`: The admin-defined description for the label.
  - `[Id <String>]`: The label ID is a globally unique identifier (GUID).
  - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in user interfaces.
  - `[Name <String>]`: The plaintext name of the label.
  - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
  - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
  - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a user interface.

## RELATED LINKS

