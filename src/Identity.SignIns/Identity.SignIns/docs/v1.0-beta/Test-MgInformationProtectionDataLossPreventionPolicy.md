---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/test-mginformationprotectiondatalosspreventionpolicy
schema: 2.0.0
---

# Test-MgInformationProtectionDataLossPreventionPolicy

## SYNOPSIS
Invoke action evaluate

## SYNTAX

### EvaluateExpanded (Default)
```
Test-MgInformationProtectionDataLossPreventionPolicy [-AdditionalProperties <Hashtable>]
 [-EvaluationInput <IMicrosoftGraphDlpEvaluationInput>] [-NotificationInfo <IMicrosoftGraphDlpNotification>]
 [-Target <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Evaluate
```
Test-MgInformationProtectionDataLossPreventionPolicy
 -BodyParameter <IPaths1JhdydfInformationprotectionDatalosspreventionpoliciesMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action evaluate

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
Type: Microsoft.Graph.PowerShell.Models.IPaths1JhdydfInformationprotectionDatalosspreventionpoliciesMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Evaluate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EvaluationInput
dlpEvaluationInput
To construct, please use Get-Help -Online and see NOTES section for EVALUATIONINPUT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDlpEvaluationInput
Parameter Sets: EvaluateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationInfo
dlpNotification
To construct, please use Get-Help -Online and see NOTES section for NOTIFICATIONINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDlpNotification
Parameter Sets: EvaluateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Target
.

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IPaths1JhdydfInformationprotectionDatalosspreventionpoliciesMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDlpEvaluatePoliciesJobResponse

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1JhdydfInformationprotectionDatalosspreventionpoliciesMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EvaluationInput <IMicrosoftGraphDlpEvaluationInput>]`: dlpEvaluationInput
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessScope <String>]`: accessScope
    - `[CurrentLabel <IMicrosoftGraphCurrentLabel>]`: currentLabel
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApplicationMode <String>]`: applicationMode
      - `[Id <String>]`: 
    - `[DiscoveredSensitiveTypes <IMicrosoftGraphDiscoveredSensitiveType[]>]`: 
      - `[ClassificationAttributes <IMicrosoftGraphClassificationAttribute[]>]`: 
        - `[Confidence <Int32?>]`: 
        - `[Count <Int32?>]`: 
      - `[Confidence <Int32?>]`: 
      - `[Count <Int32?>]`: 
      - `[Id <String>]`: 
  - `[NotificationInfo <IMicrosoftGraphDlpNotification>]`: dlpNotification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Author <String>]`: 
  - `[Target <String>]`: 

EVALUATIONINPUT <IMicrosoftGraphDlpEvaluationInput>: dlpEvaluationInput
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AccessScope <String>]`: accessScope
  - `[CurrentLabel <IMicrosoftGraphCurrentLabel>]`: currentLabel
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplicationMode <String>]`: applicationMode
    - `[Id <String>]`: 
  - `[DiscoveredSensitiveTypes <IMicrosoftGraphDiscoveredSensitiveType[]>]`: 
    - `[ClassificationAttributes <IMicrosoftGraphClassificationAttribute[]>]`: 
      - `[Confidence <Int32?>]`: 
      - `[Count <Int32?>]`: 
    - `[Confidence <Int32?>]`: 
    - `[Count <Int32?>]`: 
    - `[Id <String>]`: 

NOTIFICATIONINFO <IMicrosoftGraphDlpNotification>: dlpNotification
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Author <String>]`: 

## RELATED LINKS

