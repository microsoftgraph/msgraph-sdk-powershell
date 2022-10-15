---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/update-mgdevicemanagementvirtualendpointreport
schema: 2.0.0
---

# Update-MgDeviceManagementVirtualEndpointReport

## SYNOPSIS
Update the navigation property reports in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementVirtualEndpointReport [-AdditionalProperties <Hashtable>]
 [-ExportJobs <IMicrosoftGraphCloudPcExportJob[]>] [-Id <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementVirtualEndpointReport -BodyParameter <IMicrosoftGraphCloudPcReports> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property reports in deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
cloudPcReports
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcReports
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExportJobs
.
To construct, please use Get-Help -Online and see NOTES section for EXPORTJOBS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcExportJob[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcReports

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCloudPcReports>: cloudPcReports
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ExportJobs <IMicrosoftGraphCloudPcExportJob[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[ExportJobStatus <String>]`: cloudPcExportJobStatus
    - `[ExportUrl <String>]`: 
    - `[Filter <String>]`: 
    - `[Format <String>]`: 
    - `[ReportName <String>]`: cloudPcReportName
    - `[RequestDateTime <DateTime?>]`: 
    - `[Select <String[]>]`: 

EXPORTJOBS <IMicrosoftGraphCloudPcExportJob[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ExpirationDateTime <DateTime?>]`: 
  - `[ExportJobStatus <String>]`: cloudPcExportJobStatus
  - `[ExportUrl <String>]`: 
  - `[Filter <String>]`: 
  - `[Format <String>]`: 
  - `[ReportName <String>]`: cloudPcReportName
  - `[RequestDateTime <DateTime?>]`: 
  - `[Select <String[]>]`: 

## RELATED LINKS

