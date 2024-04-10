---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.actions/test-mgbetadevicemanagementvirtualendpointcloudpcbulkresize
schema: 2.0.0
---

# Test-MgBetaDeviceManagementVirtualEndpointCloudPcBulkResize

## SYNOPSIS
Validate that a set of cloudPC devices meet the requirements to be bulk resized.

## SYNTAX

### ValidateExpanded (Default)
```
Test-MgBetaDeviceManagementVirtualEndpointCloudPcBulkResize [-AdditionalProperties <Hashtable>]
 [-CloudPcIds <String[]>] [-ResponseHeadersVariable <String>] [-TargetServicePlanId <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Validate
```
Test-MgBetaDeviceManagementVirtualEndpointCloudPcBulkResize
 -BodyParameter <IPathsLvwgawDevicemanagementVirtualendpointCloudpcsMicrosoftGraphValidatebulkresizePostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Validate that a set of cloudPC devices meet the requirements to be bulk resized.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsLvwgawDevicemanagementVirtualendpointCloudpcsMicrosoftGraphValidatebulkresizePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Validate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CloudPcIds
.

```yaml
Type: System.String[]
Parameter Sets: ValidateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetServicePlanId
.

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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsLvwgawDevicemanagementVirtualendpointCloudpcsMicrosoftGraphValidatebulkresizePostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcResizeValidationResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsLvwgawDevicemanagementVirtualendpointCloudpcsMicrosoftGraphValidatebulkresizePostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CloudPcIds <String[]>]`: 
  - `[TargetServicePlanId <String>]`: 

## RELATED LINKS

