---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.administration/update-mgbetadevicemanagementvirtualendpointreport
schema: 2.0.0
---

# Update-MgBetaDeviceManagementVirtualEndpointReport

## SYNOPSIS
Update the navigation property reports in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementVirtualEndpointReport [-AdditionalProperties <Hashtable>]
 [-ExportJobs <IMicrosoftGraphCloudPcExportJob[]>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementVirtualEndpointReport -BodyParameter <IMicrosoftGraphCloudPcReports> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property reports in deviceManagement

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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcReports
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExportJobs
The export jobs created for downloading reports.
To construct, see NOTES section for EXPORTJOBS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcExportJob[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcReports

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcReports

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphCloudPcReports>`: cloudPcReports
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ExportJobs <IMicrosoftGraphCloudPcExportJob[]>]`: The export jobs created for downloading reports.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ExpirationDateTime <DateTime?>]`: The date and time when the export job expires.
    - `[ExportJobStatus <String>]`: cloudPcExportJobStatus
    - `[ExportUrl <String>]`: The storage account URL of the exported report. It can be used to download the file.
    - `[Filter <String>]`: The filter applied on the report.
    - `[Format <String>]`: The format of the exported report.
    - `[ReportName <String>]`: cloudPcReportName
    - `[RequestDateTime <DateTime?>]`: The date and time when the export job was requested.
    - `[Select <String[]>]`: The selected columns of the report.

`EXPORTJOBS <IMicrosoftGraphCloudPcExportJob[]>`: The export jobs created for downloading reports.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ExpirationDateTime <DateTime?>]`: The date and time when the export job expires.
  - `[ExportJobStatus <String>]`: cloudPcExportJobStatus
  - `[ExportUrl <String>]`: The storage account URL of the exported report. It can be used to download the file.
  - `[Filter <String>]`: The filter applied on the report.
  - `[Format <String>]`: The format of the exported report.
  - `[ReportName <String>]`: cloudPcReportName
  - `[RequestDateTime <DateTime?>]`: The date and time when the export job was requested.
  - `[Select <String[]>]`: The selected columns of the report.

## RELATED LINKS

