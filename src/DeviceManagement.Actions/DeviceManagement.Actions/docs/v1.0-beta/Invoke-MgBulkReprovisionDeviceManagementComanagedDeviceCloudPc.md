---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/invoke-mgbulkreprovisiondevicemanagementcomanageddevicecloudpc
schema: 2.0.0
---

# Invoke-MgBulkReprovisionDeviceManagementComanagedDeviceCloudPc

## SYNOPSIS
Invoke action bulkReprovisionCloudPc

## SYNTAX

### BulkExpanded (Default)
```
Invoke-MgBulkReprovisionDeviceManagementComanagedDeviceCloudPc [-AdditionalProperties <Hashtable>]
 [-ManagedDeviceIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Bulk
```
Invoke-MgBulkReprovisionDeviceManagementComanagedDeviceCloudPc
 -BodyParameter <IPaths1WrkhgvDevicemanagementComanageddevicesMicrosoftGraphBulkreprovisioncloudpcPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action bulkReprovisionCloudPc

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: BulkExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1WrkhgvDevicemanagementComanageddevicesMicrosoftGraphBulkreprovisioncloudpcPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Bulk
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagedDeviceIds
.

```yaml
Type: System.String[]
Parameter Sets: BulkExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1WrkhgvDevicemanagementComanageddevicesMicrosoftGraphBulkreprovisioncloudpcPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcBulkRemoteActionResult

## NOTES

ALIASES

### Invoke-MgBulkDeviceManagementComanagedDeviceReprovisionCloudPc

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1WrkhgvDevicemanagementComanageddevicesMicrosoftGraphBulkreprovisioncloudpcPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ManagedDeviceIds <String[]>]`: 

## RELATED LINKS

