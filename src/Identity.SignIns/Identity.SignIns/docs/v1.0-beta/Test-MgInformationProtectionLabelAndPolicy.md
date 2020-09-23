---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/test-mginformationprotectionlabelandpolicy
schema: 2.0.0
---

# Test-MgInformationProtectionLabelAndPolicy

## SYNOPSIS
Invoke action evaluateLabelsAndPolicies

## SYNTAX

### EvaluateExpanded (Default)
```
Test-MgInformationProtectionLabelAndPolicy [-AdditionalProperties <Hashtable>]
 [-ClassifyText <IMicrosoftGraphTextClassificationRequest>]
 [-EvaluateDataLossPreventionPolicies <IMicrosoftGraphDlpEvaluatePoliciesRequest>]
 [-EvaluateSensitivityLabels <IMicrosoftGraphEvaluateSensitivityLabelsRequest>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Evaluate
```
Test-MgInformationProtectionLabelAndPolicy
 -BodyParameter <IPathsU4Eih0InformationprotectionMicrosoftGraphEvaluatelabelsandpoliciesPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action evaluateLabelsAndPolicies

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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsU4Eih0InformationprotectionMicrosoftGraphEvaluatelabelsandpoliciesPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Evaluate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClassifyText
textClassificationRequest
To construct, see NOTES section for CLASSIFYTEXT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTextClassificationRequest
Parameter Sets: EvaluateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EvaluateDataLossPreventionPolicies
dlpEvaluatePoliciesRequest
To construct, see NOTES section for EVALUATEDATALOSSPREVENTIONPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDlpEvaluatePoliciesRequest
Parameter Sets: EvaluateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EvaluateSensitivityLabels
evaluateSensitivityLabelsRequest
To construct, see NOTES section for EVALUATESENSITIVITYLABELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvaluateSensitivityLabelsRequest
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

### Microsoft.Graph.PowerShell.Models.IPathsU4Eih0InformationprotectionMicrosoftGraphEvaluatelabelsandpoliciesPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvaluateLabelsAndPoliciesJobResponse

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsU4Eih0InformationprotectionMicrosoftGraphEvaluatelabelsandpoliciesPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ClassifyText <IMicrosoftGraphTextClassificationRequest>]`: textClassificationRequest
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[FileExtension <String>]`: 
    - `[ScopesToRun <String>]`: sensitiveTypeScope
    - `[SensitiveTypeIds <String[]>]`: 
    - `[Text <String>]`: 
  - `[EvaluateDataLossPreventionPolicies <IMicrosoftGraphDlpEvaluatePoliciesRequest>]`: dlpEvaluatePoliciesRequest
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EvaluationInput <IMicrosoftGraphDlpEvaluationInput>]`: dlpEvaluationInput
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccessScope <String>]`: accessScope
      - `[CurrentLabel <IMicrosoftGraphCurrentLabel>]`: currentLabel
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ApplicationMode <String>]`: applicationMode
        - `[Id <String>]`: 
      - `[DiscoveredSensitiveTypes <IMicrosoftGraphDiscoveredSensitiveType[]>]`: 
        - `[Confidence <Int32?>]`: 
        - `[Count <Int32?>]`: 
        - `[Id <String>]`: 
    - `[NotificationInfo <IMicrosoftGraphDlpNotification>]`: dlpNotification
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Author <String>]`: 
    - `[Target <String>]`: 
  - `[EvaluateSensitivityLabels <IMicrosoftGraphEvaluateSensitivityLabelsRequest>]`: evaluateSensitivityLabelsRequest
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CurrentLabel <IMicrosoftGraphCurrentLabel>]`: currentLabel
    - `[DiscoveredSensitiveTypes <IMicrosoftGraphDiscoveredSensitiveType[]>]`: 

CLASSIFYTEXT <IMicrosoftGraphTextClassificationRequest>: textClassificationRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[FileExtension <String>]`: 
  - `[ScopesToRun <String>]`: sensitiveTypeScope
  - `[SensitiveTypeIds <String[]>]`: 
  - `[Text <String>]`: 

EVALUATEDATALOSSPREVENTIONPOLICIES <IMicrosoftGraphDlpEvaluatePoliciesRequest>: dlpEvaluatePoliciesRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EvaluationInput <IMicrosoftGraphDlpEvaluationInput>]`: dlpEvaluationInput
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessScope <String>]`: accessScope
    - `[CurrentLabel <IMicrosoftGraphCurrentLabel>]`: currentLabel
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApplicationMode <String>]`: applicationMode
      - `[Id <String>]`: 
    - `[DiscoveredSensitiveTypes <IMicrosoftGraphDiscoveredSensitiveType[]>]`: 
      - `[Confidence <Int32?>]`: 
      - `[Count <Int32?>]`: 
      - `[Id <String>]`: 
  - `[NotificationInfo <IMicrosoftGraphDlpNotification>]`: dlpNotification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Author <String>]`: 
  - `[Target <String>]`: 

EVALUATESENSITIVITYLABELS <IMicrosoftGraphEvaluateSensitivityLabelsRequest>: evaluateSensitivityLabelsRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CurrentLabel <IMicrosoftGraphCurrentLabel>]`: currentLabel
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplicationMode <String>]`: applicationMode
    - `[Id <String>]`: 
  - `[DiscoveredSensitiveTypes <IMicrosoftGraphDiscoveredSensitiveType[]>]`: 
    - `[Confidence <Int32?>]`: 
    - `[Count <Int32?>]`: 
    - `[Id <String>]`: 

## RELATED LINKS

