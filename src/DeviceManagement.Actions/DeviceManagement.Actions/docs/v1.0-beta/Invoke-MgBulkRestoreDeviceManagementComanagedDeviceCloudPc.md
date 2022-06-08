---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/invoke-mgbulkrestoredevicemanagementcomanageddevicecloudpc
schema: 2.0.0
---

# Invoke-MgBulkRestoreDeviceManagementComanagedDeviceCloudPc

## SYNOPSIS
Invoke action bulkRestoreCloudPc

## SYNTAX

### BulkExpanded (Default)
```
Invoke-MgBulkRestoreDeviceManagementComanagedDeviceCloudPc [-AdditionalProperties <Hashtable>]
 [-ManagedDeviceIds <String[]>] [-RestorePointDateTime <DateTime>] [-TimeRange <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Bulk
```
Invoke-MgBulkRestoreDeviceManagementComanagedDeviceCloudPc
 -BodyParameter <IPaths1Rxaz9ODevicemanagementComanageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action bulkRestoreCloudPc

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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Rxaz9ODevicemanagementComanageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema
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

### -RestorePointDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: BulkExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeRange
restoreTimeRange

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IPaths1Rxaz9ODevicemanagementComanageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcBulkRemoteActionResult

## NOTES

ALIASES

### Invoke-MgBulkDeviceManagementComanagedDeviceRestoreCloudPc

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Rxaz9ODevicemanagementComanageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ManagedDeviceIds <String[]>]`: 
  - `[RestorePointDateTime <DateTime?>]`: 
  - `[TimeRange <String>]`: restoreTimeRange

## RELATED LINKS

