---
external help file:
Module Name: Microsoft.Graph.Beta.Reports
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.reports/update-mgbetadevicemanagementreport
schema: 2.0.0
---

# Update-MgBetaDeviceManagementReport

## SYNOPSIS
Update the navigation property reports in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementReport [-AdditionalProperties <Hashtable>]
 [-CachedReportConfigurations <IMicrosoftGraphDeviceManagementCachedReportConfiguration[]>]
 [-ExportJobs <IMicrosoftGraphDeviceManagementExportJob[]>] [-Id <String>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementReport -BodyParameter <IMicrosoftGraphDeviceManagementReports>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
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
Singleton entity that acts as a container for all reports functionality.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementReports
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CachedReportConfigurations
Entity representing the configuration of a cached report.
To construct, see NOTES section for CACHEDREPORTCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementCachedReportConfiguration[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExportJobs
Entity representing a job to export a report.
To construct, see NOTES section for EXPORTJOBS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementExportJob[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementReports

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementReports

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphDeviceManagementReports>`: Singleton entity that acts as a container for all reports functionality.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CachedReportConfigurations <IMicrosoftGraphDeviceManagementCachedReportConfiguration[]>]`: Entity representing the configuration of a cached report.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ExpirationDateTime <DateTime?>]`: Time that the cached report expires.
    - `[Filter <String>]`: Filters applied on report creation.
    - `[LastRefreshDateTime <DateTime?>]`: Time that the cached report was last refreshed.
    - `[Metadata <String>]`: Caller-managed metadata associated with the report.
    - `[OrderBy <String[]>]`: Ordering of columns in the report.
    - `[ReportName <String>]`: Name of the report.
    - `[Select <String[]>]`: Columns selected from the report.
    - `[Status <DeviceManagementReportStatus?>]`: Possible statuses associated with a generated report.
  - `[ExportJobs <IMicrosoftGraphDeviceManagementExportJob[]>]`: Entity representing a job to export a report.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ExpirationDateTime <DateTime?>]`: Time that the exported report expires.
    - `[Filter <String>]`: Filters applied on the report. The maximum length allowed for this property is 2000 characters.
    - `[Format <DeviceManagementReportFileFormat?>]`: Possible values for the file format of a report.
    - `[LocalizationType <DeviceManagementExportJobLocalizationType?>]`: Configures how the requested export job is localized.
    - `[ReportName <String>]`: Name of the report. The maximum length allowed for this property is 2000 characters.
    - `[RequestDateTime <DateTime?>]`: Time that the exported report was requested.
    - `[Search <String>]`: Configures a search term to filter the data. The maximum length allowed for this property is 100 characters.
    - `[Select <String[]>]`: Columns selected from the report. The maximum number of allowed columns names is 256. The maximum length allowed for each column name in this property is 1000 characters.
    - `[SnapshotId <String>]`: A snapshot is an identifiable subset of the dataset represented by the ReportName. A sessionId or CachedReportConfiguration id can be used here. If a sessionId is specified, Filter, Select, and OrderBy are applied to the data represented by the sessionId. Filter, Select, and OrderBy cannot be specified together with a CachedReportConfiguration id. The maximum length allowed for this property is 128 characters.
    - `[Status <DeviceManagementReportStatus?>]`: Possible statuses associated with a generated report.
    - `[Url <String>]`: Temporary location of the exported report.

`CACHEDREPORTCONFIGURATIONS <IMicrosoftGraphDeviceManagementCachedReportConfiguration[]>`: Entity representing the configuration of a cached report.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ExpirationDateTime <DateTime?>]`: Time that the cached report expires.
  - `[Filter <String>]`: Filters applied on report creation.
  - `[LastRefreshDateTime <DateTime?>]`: Time that the cached report was last refreshed.
  - `[Metadata <String>]`: Caller-managed metadata associated with the report.
  - `[OrderBy <String[]>]`: Ordering of columns in the report.
  - `[ReportName <String>]`: Name of the report.
  - `[Select <String[]>]`: Columns selected from the report.
  - `[Status <DeviceManagementReportStatus?>]`: Possible statuses associated with a generated report.

`EXPORTJOBS <IMicrosoftGraphDeviceManagementExportJob[]>`: Entity representing a job to export a report.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ExpirationDateTime <DateTime?>]`: Time that the exported report expires.
  - `[Filter <String>]`: Filters applied on the report. The maximum length allowed for this property is 2000 characters.
  - `[Format <DeviceManagementReportFileFormat?>]`: Possible values for the file format of a report.
  - `[LocalizationType <DeviceManagementExportJobLocalizationType?>]`: Configures how the requested export job is localized.
  - `[ReportName <String>]`: Name of the report. The maximum length allowed for this property is 2000 characters.
  - `[RequestDateTime <DateTime?>]`: Time that the exported report was requested.
  - `[Search <String>]`: Configures a search term to filter the data. The maximum length allowed for this property is 100 characters.
  - `[Select <String[]>]`: Columns selected from the report. The maximum number of allowed columns names is 256. The maximum length allowed for each column name in this property is 1000 characters.
  - `[SnapshotId <String>]`: A snapshot is an identifiable subset of the dataset represented by the ReportName. A sessionId or CachedReportConfiguration id can be used here. If a sessionId is specified, Filter, Select, and OrderBy are applied to the data represented by the sessionId. Filter, Select, and OrderBy cannot be specified together with a CachedReportConfiguration id. The maximum length allowed for this property is 128 characters.
  - `[Status <DeviceManagementReportStatus?>]`: Possible statuses associated with a generated report.
  - `[Url <String>]`: Temporary location of the exported report.

## RELATED LINKS

