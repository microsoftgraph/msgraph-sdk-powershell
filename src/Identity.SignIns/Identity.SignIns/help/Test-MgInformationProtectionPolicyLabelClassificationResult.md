---
external help file: Microsoft.Graph.Identity.SignIns-help.xml
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/test-mginformationprotectionpolicylabelclassificationresult
schema: 2.0.0
---

# Test-MgInformationProtectionPolicyLabelClassificationResult

## SYNOPSIS
Invoke action evaluateClassificationResults

## SYNTAX

### EvaluateExpanded (Default)
```
Test-MgInformationProtectionPolicyLabelClassificationResult [-AdditionalProperties <Hashtable>]
 [-ClassificationResults <IMicrosoftGraphClassificationResult[]>] [-ContentInfo <IMicrosoftGraphContentInfo>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Evaluate
```
Test-MgInformationProtectionPolicyLabelClassificationResult
 -BodyParameter <IPathsLeqqhcInformationprotectionPolicyLabelsMicrosoftGraphEvaluateclassificationresultsPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action evaluateClassificationResults

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IPathsLeqqhcInformationprotectionPolicyLabelsMicrosoftGraphEvaluateclassificationresultsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Evaluate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClassificationResults
.
To construct, see NOTES section for CLASSIFICATIONRESULTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphClassificationResult[]
Parameter Sets: EvaluateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentInfo
contentInfo
To construct, see NOTES section for CONTENTINFO properties and create a hash table.

```yaml
Type: IMicrosoftGraphContentInfo
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IPathsLeqqhcInformationprotectionPolicyLabelsMicrosoftGraphEvaluateclassificationresultsPostRequestbodyContentApplicationJsonSchema
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInformationProtectionAction
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IPathsLeqqhcInformationprotectionPolicyLabelsMicrosoftGraphEvaluateclassificationresultsPostRequestbodyContentApplicationJsonSchema\>: .
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[ClassificationResults \<IMicrosoftGraphClassificationResult\[\]\>\]: 
    \[ConfidenceLevel \<Int32?\>\]: 
    \[Count \<Int32?\>\]: 
    \[SensitiveTypeId \<String\>\]: 
  \[ContentInfo \<IMicrosoftGraphContentInfo\>\]: contentInfo
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Format \<String\>\]: contentFormat
    \[Identifier \<String\>\]: 
    \[Metadata \<IMicrosoftGraphKeyValuePair\[\]\>\]: 
      \[Name \<String\>\]: Name for this key-value pair
      \[Value \<String\>\]: Value for this key-value pair
    \[State \<String\>\]: contentState

CLASSIFICATIONRESULTS \<IMicrosoftGraphClassificationResult\[\]\>: .
  \[ConfidenceLevel \<Int32?\>\]: 
  \[Count \<Int32?\>\]: 
  \[SensitiveTypeId \<String\>\]: 

CONTENTINFO \<IMicrosoftGraphContentInfo\>: contentInfo
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Format \<String\>\]: contentFormat
  \[Identifier \<String\>\]: 
  \[Metadata \<IMicrosoftGraphKeyValuePair\[\]\>\]: 
    \[Name \<String\>\]: Name for this key-value pair
    \[Value \<String\>\]: Value for this key-value pair
  \[State \<String\>\]: contentState

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/test-mginformationprotectionpolicylabelclassificationresult](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/test-mginformationprotectionpolicylabelclassificationresult)

