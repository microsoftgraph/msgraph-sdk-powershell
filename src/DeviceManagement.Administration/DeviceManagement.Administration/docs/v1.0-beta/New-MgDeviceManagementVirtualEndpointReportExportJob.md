---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementvirtualendpointreportexportjob
schema: 2.0.0
---

# New-MgDeviceManagementVirtualEndpointReportExportJob

## SYNOPSIS
Create a new cloudPcExportJob object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementVirtualEndpointReportExportJob [-AdditionalProperties <Hashtable>]
 [-ExpirationDateTime <DateTime>] [-ExportJobStatus <String>] [-ExportUrl <String>] [-Filter <String>]
 [-Format <String>] [-Id <String>] [-Property <String[]>] [-ReportName <String>] [-RequestDateTime <DateTime>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementVirtualEndpointReportExportJob -BodyParameter <IMicrosoftGraphCloudPcExportJob>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new cloudPcExportJob object.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
cloudPcExportJob
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcExportJob
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExpirationDateTime
The date time when the export job expires.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExportJobStatus
cloudPcExportJobStatus

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExportUrl
The storage account url of the exported report, it can be used to download the file.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
The filter applied on the report.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Format
The format of the exported report.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
The selected columns of the report.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReportName
cloudPcReportName

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestDateTime
The date time when the export job was requested.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcExportJob

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcExportJob

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCloudPcExportJob>: cloudPcExportJob
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ExpirationDateTime <DateTime?>]`: The date time when the export job expires.
  - `[ExportJobStatus <String>]`: cloudPcExportJobStatus
  - `[ExportUrl <String>]`: The storage account url of the exported report, it can be used to download the file.
  - `[Filter <String>]`: The filter applied on the report.
  - `[Format <String>]`: The format of the exported report.
  - `[ReportName <String>]`: cloudPcReportName
  - `[RequestDateTime <DateTime?>]`: The date time when the export job was requested.
  - `[Select <String[]>]`: The selected columns of the report.

## RELATED LINKS

