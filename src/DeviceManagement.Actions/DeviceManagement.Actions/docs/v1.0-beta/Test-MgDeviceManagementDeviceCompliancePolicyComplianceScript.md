---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/test-mgdevicemanagementdevicecompliancepolicycompliancescript
schema: 2.0.0
---

# Test-MgDeviceManagementDeviceCompliancePolicyComplianceScript

## SYNOPSIS
Invoke action validateComplianceScript

## SYNTAX

### ValidateExpanded (Default)
```
Test-MgDeviceManagementDeviceCompliancePolicyComplianceScript [-AdditionalProperties <Hashtable>]
 [-DeviceCompliancePolicyScript <IMicrosoftGraphDeviceCompliancePolicyScript>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Validate
```
Test-MgDeviceManagementDeviceCompliancePolicyComplianceScript
 -BodyParameter <IPathsV2Sh76DevicemanagementDevicecompliancepoliciesMicrosoftGraphValidatecompliancescriptPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action validateComplianceScript

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
Type: Microsoft.Graph.PowerShell.Models.IPathsV2Sh76DevicemanagementDevicecompliancepoliciesMicrosoftGraphValidatecompliancescriptPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Validate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceCompliancePolicyScript
deviceCompliancePolicyScript
To construct, please use Get-Help -Online and see NOTES section for DEVICECOMPLIANCEPOLICYSCRIPT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicyScript
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

### Microsoft.Graph.PowerShell.Models.IPathsV2Sh76DevicemanagementDevicecompliancepoliciesMicrosoftGraphValidatecompliancescriptPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceComplianceScriptValidationResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsV2Sh76DevicemanagementDevicecompliancepoliciesMicrosoftGraphValidatecompliancescriptPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceCompliancePolicyScript <IMicrosoftGraphDeviceCompliancePolicyScript>]`: deviceCompliancePolicyScript
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceComplianceScriptId <String>]`: Device compliance script Id.
    - `[RulesContent <Byte[]>]`: Json of the rules.

DEVICECOMPLIANCEPOLICYSCRIPT <IMicrosoftGraphDeviceCompliancePolicyScript>: deviceCompliancePolicyScript
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceComplianceScriptId <String>]`: Device compliance script Id.
  - `[RulesContent <Byte[]>]`: Json of the rules.

## RELATED LINKS

