---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/test-mgdeviceappmgtmobileappxml
schema: 2.0.0
---

# Test-MgDeviceAppMgtMobileAppXml

## SYNOPSIS
Invoke action validateXml

## SYNTAX

### ValidateExpanded (Default)
```
Test-MgDeviceAppMgtMobileAppXml [-AdditionalProperties <Hashtable>]
 [-OfficeConfigurationXmlInputFile <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Validate
```
Test-MgDeviceAppMgtMobileAppXml
 -BodyParameter <IPaths17Ccqu0DeviceappmanagementMobileappsMicrosoftGraphValidatexmlPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action validateXml

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ValidateExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths17Ccqu0DeviceappmanagementMobileappsMicrosoftGraphValidatexmlPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Validate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OfficeConfigurationXmlInputFile
Input File for OfficeConfigurationXml (.)

```yaml
Type: System.String
Parameter Sets: ValidateExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths17Ccqu0DeviceappmanagementMobileappsMicrosoftGraphValidatexmlPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

### Test-MgDeviceAppManagementMobileAppXml

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths17Ccqu0DeviceappmanagementMobileappsMicrosoftGraphValidatexmlPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[OfficeConfigurationXml <Byte[]>]`: 

## RELATED LINKS

