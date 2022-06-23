---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/test-mgsecurityinformationprotectionsensitivitylabelapplication
schema: 2.0.0
---

# Test-MgSecurityInformationProtectionSensitivityLabelApplication

## SYNOPSIS
Invoke action evaluateApplication

## SYNTAX

### EvaluateExpanded (Default)
```
Test-MgSecurityInformationProtectionSensitivityLabelApplication [-AdditionalProperties <Hashtable>]
 [-ContentInfo <IMicrosoftGraphSecurityContentInfo>]
 [-LabelingOptions <IMicrosoftGraphSecurityLabelingOptions>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Evaluate
```
Test-MgSecurityInformationProtectionSensitivityLabelApplication
 -BodyParameter <IPaths1CurldqSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityEvaluateapplicationPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action evaluateApplication

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: EvaluateExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1CurldqSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityEvaluateapplicationPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Evaluate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentInfo
contentInfo
To construct, please use Get-Help -Online and see NOTES section for CONTENTINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityContentInfo
Parameter Sets: EvaluateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LabelingOptions
labelingOptions
To construct, please use Get-Help -Online and see NOTES section for LABELINGOPTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityLabelingOptions
Parameter Sets: EvaluateExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1CurldqSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityEvaluateapplicationPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityInformationProtectionAction

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1CurldqSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityEvaluateapplicationPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentInfo <IMicrosoftGraphSecurityContentInfo>]`: contentInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentFormat <String>]`: 
    - `[Identifier <String>]`: 
    - `[Metadata <IMicrosoftGraphSecurityKeyValuePair[]>]`: 
      - `[Name <String>]`: 
      - `[Value <String>]`: 
    - `[State <String>]`: contentState
  - `[LabelingOptions <IMicrosoftGraphSecurityLabelingOptions>]`: labelingOptions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AssignmentMethod <String>]`: assignmentMethod
    - `[DowngradeJustification <IMicrosoftGraphSecurityDowngradeJustification>]`: downgradeJustification
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsDowngradeJustified <Boolean?>]`: 
      - `[JustificationMessage <String>]`: 
    - `[ExtendedProperties <IMicrosoftGraphSecurityKeyValuePair[]>]`: 
    - `[LabelId <String>]`: 

CONTENTINFO <IMicrosoftGraphSecurityContentInfo>: contentInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentFormat <String>]`: 
  - `[Identifier <String>]`: 
  - `[Metadata <IMicrosoftGraphSecurityKeyValuePair[]>]`: 
    - `[Name <String>]`: 
    - `[Value <String>]`: 
  - `[State <String>]`: contentState

LABELINGOPTIONS <IMicrosoftGraphSecurityLabelingOptions>: labelingOptions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AssignmentMethod <String>]`: assignmentMethod
  - `[DowngradeJustification <IMicrosoftGraphSecurityDowngradeJustification>]`: downgradeJustification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsDowngradeJustified <Boolean?>]`: 
    - `[JustificationMessage <String>]`: 
  - `[ExtendedProperties <IMicrosoftGraphSecurityKeyValuePair[]>]`: 
    - `[Name <String>]`: 
    - `[Value <String>]`: 
  - `[LabelId <String>]`: 

## RELATED LINKS

