---
external help file:
Module Name: Microsoft.Graph.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/update-mgdevicemanagementreport
schema: 2.0.0
---

# Update-MgDeviceManagementReport

## SYNOPSIS
Update the navigation property reports in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementReport [-AdditionalProperties <Hashtable>]
 [-CachedReportConfigurations <IMicrosoftGraphDeviceManagementCachedReportConfiguration[]>]
 [-ExportJobs <IMicrosoftGraphDeviceManagementExportJob[]>] [-Id <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementReport -BodyParameter <IMicrosoftGraphDeviceManagementReports1> [-PassThru]
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
Singleton entity that acts as a container for all reports functionality.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementReports1
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CachedReportConfigurations
Entity representing the configuration of a cached report
To construct, please use Get-Help -Online and see NOTES section for CACHEDREPORTCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementCachedReportConfiguration[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExportJobs
Entity representing a job to export a report
To construct, please use Get-Help -Online and see NOTES section for EXPORTJOBS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementExportJob[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementReports1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementReports1>: Singleton entity that acts as a container for all reports functionality.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CachedReportConfigurations <IMicrosoftGraphDeviceManagementCachedReportConfiguration[]>]`: Entity representing the configuration of a cached report
    - `[Id <String>]`: 
    - `[ExpirationDateTime <DateTime?>]`: Time that the cached report expires
    - `[Filter <String>]`: Filters applied on report creation.
    - `[LastRefreshDateTime <DateTime?>]`: Time that the cached report was last refreshed
    - `[Metadata <String>]`: Caller-managed metadata associated with the report
    - `[OrderBy <String[]>]`: Ordering of columns in the report
    - `[ReportName <String>]`: Name of the report
    - `[Select <String[]>]`: Columns selected from the report
    - `[Status <DeviceManagementReportStatus?>]`: Possible statuses associated with a generated report
  - `[ExportJobs <IMicrosoftGraphDeviceManagementExportJob[]>]`: Entity representing a job to export a report
    - `[Id <String>]`: 
    - `[ExpirationDateTime <DateTime?>]`: Time that the exported report expires
    - `[Filter <String>]`: Filters applied on the report
    - `[Format <DeviceManagementReportFileFormat?>]`: Possible values for the file format of a report
    - `[LocalizationType <DeviceManagementExportJobLocalizationType?>]`: Configures how the requested export job is localized
    - `[ReportName <String>]`: Name of the report
    - `[RequestDateTime <DateTime?>]`: Time that the exported report was requested
    - `[Select <String[]>]`: Columns selected from the report
    - `[SnapshotId <String>]`: A snapshot is an identifiable subset of the dataset represented by the ReportName. A sessionId or CachedReportConfiguration id can be used here. If a sessionId is specified, Filter, Select, and OrderBy are applied to the data represented by the sessionId. Filter, Select, and OrderBy cannot be specified together with a CachedReportConfiguration id.
    - `[Status <DeviceManagementReportStatus?>]`: Possible statuses associated with a generated report
    - `[Url <String>]`: Temporary location of the exported report

CACHEDREPORTCONFIGURATIONS <IMicrosoftGraphDeviceManagementCachedReportConfiguration[]>: Entity representing the configuration of a cached report
  - `[Id <String>]`: 
  - `[ExpirationDateTime <DateTime?>]`: Time that the cached report expires
  - `[Filter <String>]`: Filters applied on report creation.
  - `[LastRefreshDateTime <DateTime?>]`: Time that the cached report was last refreshed
  - `[Metadata <String>]`: Caller-managed metadata associated with the report
  - `[OrderBy <String[]>]`: Ordering of columns in the report
  - `[ReportName <String>]`: Name of the report
  - `[Select <String[]>]`: Columns selected from the report
  - `[Status <DeviceManagementReportStatus?>]`: Possible statuses associated with a generated report

EXPORTJOBS <IMicrosoftGraphDeviceManagementExportJob[]>: Entity representing a job to export a report
  - `[Id <String>]`: 
  - `[ExpirationDateTime <DateTime?>]`: Time that the exported report expires
  - `[Filter <String>]`: Filters applied on the report
  - `[Format <DeviceManagementReportFileFormat?>]`: Possible values for the file format of a report
  - `[LocalizationType <DeviceManagementExportJobLocalizationType?>]`: Configures how the requested export job is localized
  - `[ReportName <String>]`: Name of the report
  - `[RequestDateTime <DateTime?>]`: Time that the exported report was requested
  - `[Select <String[]>]`: Columns selected from the report
  - `[SnapshotId <String>]`: A snapshot is an identifiable subset of the dataset represented by the ReportName. A sessionId or CachedReportConfiguration id can be used here. If a sessionId is specified, Filter, Select, and OrderBy are applied to the data represented by the sessionId. Filter, Select, and OrderBy cannot be specified together with a CachedReportConfiguration id.
  - `[Status <DeviceManagementReportStatus?>]`: Possible statuses associated with a generated report
  - `[Url <String>]`: Temporary location of the exported report

## RELATED LINKS

