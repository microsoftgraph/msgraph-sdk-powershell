---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/invoke-mgbetaextractsecurityinformationprotectionsensitivitylabelcontentlabel
schema: 2.0.0
---

# Invoke-MgBetaExtractSecurityInformationProtectionSensitivityLabelContentLabel

## SYNOPSIS
Use the metadata that exists on an already-labeled piece of information to resolve the metadata to a specific sensitivity label.
The contentInfo input is resolved to informationProtectionContentLabel.

## SYNTAX

### ExtractExpanded (Default)
```
Invoke-MgBetaExtractSecurityInformationProtectionSensitivityLabelContentLabel
 [-AdditionalProperties <Hashtable>] [-ContentInfo <IMicrosoftGraphSecurityContentInfo>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Extract
```
Invoke-MgBetaExtractSecurityInformationProtectionSensitivityLabelContentLabel
 -BodyParameter <IPathsQlapx7SecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityExtractcontentlabelPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Use the metadata that exists on an already-labeled piece of information to resolve the metadata to a specific sensitivity label.
The contentInfo input is resolved to informationProtectionContentLabel.

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
Parameter Sets: ExtractExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsQlapx7SecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityExtractcontentlabelPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Extract
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentInfo
contentInfo
To construct, see NOTES section for CONTENTINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityContentInfo
Parameter Sets: ExtractExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsQlapx7SecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityExtractcontentlabelPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityContentLabel

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsQlapx7SecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityExtractcontentlabelPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentInfo <IMicrosoftGraphSecurityContentInfo>]`: contentInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentFormat <String>]`: The format of the content to be labeled. Possible values are: file, email.
    - `[Identifier <String>]`: Identifier used for Azure Information Protection Analytics.
    - `[Metadata <IMicrosoftGraphSecurityKeyValuePair[]>]`: Existing Microsoft Purview Information Protection metadata is passed as key-value pairs, where the key is the MSIPLabelGUID_PropName.
      - `[Name <String>]`: Name for this key-value pair.
      - `[Value <String>]`: Value for this key-value pair.
    - `[State <String>]`: contentState

`CONTENTINFO <IMicrosoftGraphSecurityContentInfo>`: contentInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentFormat <String>]`: The format of the content to be labeled. Possible values are: file, email.
  - `[Identifier <String>]`: Identifier used for Azure Information Protection Analytics.
  - `[Metadata <IMicrosoftGraphSecurityKeyValuePair[]>]`: Existing Microsoft Purview Information Protection metadata is passed as key-value pairs, where the key is the MSIPLabelGUID_PropName.
    - `[Name <String>]`: Name for this key-value pair.
    - `[Value <String>]`: Value for this key-value pair.
  - `[State <String>]`: contentState

## RELATED LINKS

