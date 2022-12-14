---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/test-mginformationprotectionpolicylabelapplication
schema: 2.0.0
---

# Test-MgBetaInformationProtectionPolicyLabelApplication

## SYNOPSIS
Compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set manually or explicitly by a user or service, rather than automatically based on file contents.
Given contentInfo, which includes existing content metadata key/value pairs, and labelingOptions as an input, the API returns an informationProtectionAction object that contains one of more of the following:

## SYNTAX

### EvaluateExpanded (Default)
```
Test-MgBetaInformationProtectionPolicyLabelApplication [-AdditionalProperties <Hashtable>]
 [-ContentInfo <IMicrosoftGraphContentInfo>] [-LabelingOptions <IMicrosoftGraphLabelingOptions>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Evaluate
```
Test-MgBetaInformationProtectionPolicyLabelApplication
 -BodyParameter <IPaths1Aushj1InformationprotectionPolicyLabelsMicrosoftGraphEvaluateapplicationPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set manually or explicitly by a user or service, rather than automatically based on file contents.
Given contentInfo, which includes existing content metadata key/value pairs, and labelingOptions as an input, the API returns an informationProtectionAction object that contains one of more of the following:

## EXAMPLES

### Example 1: Using the Test-MgBetaInformationProtectionPolicyLabelApplication Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	ContentInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.contentInfo"
		"Format@odata.type" = "#Microsoft.Graph.Beta.contentFormat"
		Format = "default"
		Identifier = $null
		"State@odata.type" = "#Microsoft.Graph.Beta.contentState"
		State = "rest"
		"Metadata@odata.type" = "#Collection(Microsoft.Graph.Beta.keyValuePair)"
		Metadata = @(
			@{
				"@odata.type" = "#Microsoft.Graph.Beta.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Enabled"
				Value = "True"
			}
			@{
				"@odata.type" = "#Microsoft.Graph.Beta.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Method"
				Value = "Standard"
			}
			@{
				"@odata.type" = "#Microsoft.Graph.Beta.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_SetDate"
				Value = "1/1/0001 12:00:00 AM"
			}
			@{
				"@odata.type" = "#Microsoft.Graph.Beta.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_SiteId"
				Value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
			}
			@{
				"@odata.type" = "#Microsoft.Graph.Beta.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Name"
				Value = "General"
			}
			@{
				"@odata.type" = "#Microsoft.Graph.Beta.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_ContentBits"
				Value = "0"
			}
			@{
				"@odata.type" = "#Microsoft.Graph.Beta.keyValuePair"
				Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_ActionId"
				Value = "00000000-0000-0000-0000-000000000000"
			}
		)
	}
	LabelingOptions = @{
		"@odata.type" = "#Microsoft.Graph.Beta.labelingOptions"
		"AssignmentMethod@odata.type" = "#Microsoft.Graph.Beta.assignmentMethod"
		AssignmentMethod = "standard"
		"LabelId@odata.type" = "#Guid"
		LabelId = "97309856-9c28-4ac6-9382-5f8bc20c457b"
		DowngradeJustification = $null
		"ExtendedProperties@odata.type" = "#Collection(Microsoft.Graph.Beta.keyValuePair)"
		ExtendedProperties = @(
		)
	}
}
Test-MgBetaInformationProtectionPolicyLabelApplication -BodyParameter $params
```

This example shows how to use the Test-MgBetaInformationProtectionPolicyLabelApplication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1Aushj1InformationprotectionPolicyLabelsMicrosoftGraphEvaluateapplicationPostRequestbodyContentApplicationJsonSchema
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphContentInfo
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLabelingOptions
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1Aushj1InformationprotectionPolicyLabelsMicrosoftGraphEvaluateapplicationPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInformationProtectionAction

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Aushj1InformationprotectionPolicyLabelsMicrosoftGraphEvaluateapplicationPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentInfo <IMicrosoftGraphContentInfo>]`: contentInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Format <String>]`: contentFormat
    - `[Identifier <String>]`: Identifier used for Azure Information Protection Analytics.
    - `[Metadata <IMicrosoftGraphKeyValuePair[]>]`: Existing Microsoft Purview Information Protection metadata is passed as key/value pairs, where the key is the MSIP_Label_GUID_PropName.
      - `[Name <String>]`: Name for this key-value pair
      - `[Value <String>]`: Value for this key-value pair
    - `[State <String>]`: contentState
  - `[LabelingOptions <IMicrosoftGraphLabelingOptions>]`: labelingOptions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AssignmentMethod <String>]`: assignmentMethod
    - `[DowngradeJustification <IMicrosoftGraphDowngradeJustification>]`: downgradeJustification
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsDowngradeJustified <Boolean?>]`: Indicates whether the downgrade is or is not justified.
      - `[JustificationMessage <String>]`: Message that indicates why a downgrade is justified. The message will appear in administrative logs.
    - `[ExtendedProperties <IMicrosoftGraphKeyValuePair[]>]`: Extended properties will be parsed and returned in the standard MIP labeled metadata format as part of the label information.
    - `[LabelId <String>]`: The GUID of the label that should be applied to the information.

CONTENTINFO <IMicrosoftGraphContentInfo>: contentInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Format <String>]`: contentFormat
  - `[Identifier <String>]`: Identifier used for Azure Information Protection Analytics.
  - `[Metadata <IMicrosoftGraphKeyValuePair[]>]`: Existing Microsoft Purview Information Protection metadata is passed as key/value pairs, where the key is the MSIP_Label_GUID_PropName.
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[State <String>]`: contentState

LABELINGOPTIONS <IMicrosoftGraphLabelingOptions>: labelingOptions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AssignmentMethod <String>]`: assignmentMethod
  - `[DowngradeJustification <IMicrosoftGraphDowngradeJustification>]`: downgradeJustification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsDowngradeJustified <Boolean?>]`: Indicates whether the downgrade is or is not justified.
    - `[JustificationMessage <String>]`: Message that indicates why a downgrade is justified. The message will appear in administrative logs.
  - `[ExtendedProperties <IMicrosoftGraphKeyValuePair[]>]`: Extended properties will be parsed and returned in the standard MIP labeled metadata format as part of the label information.
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[LabelId <String>]`: The GUID of the label that should be applied to the information.

## RELATED LINKS

