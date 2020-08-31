---
external help file:
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/get-mgprintreportprintusagesummary
schema: 2.0.0
---

# Get-MgPrintReportPrintUsageSummary

## SYNOPSIS
Invoke function getPrintUsageSummariesByGroup

## SYNTAX

### Get (Default)
```
Get-MgPrintReportPrintUsageSummary -PeriodEnd <DateTime> -PeriodStart <DateTime> [<CommonParameters>]
```

### Get1
```
Get-MgPrintReportPrintUsageSummary -PeriodEnd <DateTime> -PeriodStart <DateTime> [<CommonParameters>]
```

### Get2
```
Get-MgPrintReportPrintUsageSummary -PeriodEnd <DateTime> -PeriodStart <DateTime> -TimeSpanInMinutes <Int32>
 [<CommonParameters>]
```

### Get3
```
Get-MgPrintReportPrintUsageSummary -PeriodEnd <DateTime> -PeriodStart <DateTime> [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgPrintReportPrintUsageSummary -InputObject <IDevicesCloudPrintIdentity> [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgPrintReportPrintUsageSummary -InputObject <IDevicesCloudPrintIdentity> [<CommonParameters>]
```

### GetViaIdentity2
```
Get-MgPrintReportPrintUsageSummary -InputObject <IDevicesCloudPrintIdentity> [<CommonParameters>]
```

### GetViaIdentity3
```
Get-MgPrintReportPrintUsageSummary -InputObject <IDevicesCloudPrintIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getPrintUsageSummariesByGroup

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesCloudPrintIdentity
Parameter Sets: GetViaIdentity, GetViaIdentity1, GetViaIdentity2, GetViaIdentity3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PeriodEnd
.

```yaml
Type: System.DateTime
Parameter Sets: Get, Get1, Get2, Get3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PeriodStart
.

```yaml
Type: System.DateTime
Parameter Sets: Get, Get1, Get2, Get3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeSpanInMinutes
.

```yaml
Type: System.Int32
Parameter Sets: Get2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDevicesCloudPrintIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPrintUsageSummary

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterUsageSummary

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUsageSummary

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserPrintUsageSummary

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDevicesCloudPrintIdentity>: Identity Parameter
  - `[GroupId <String>]`: 
  - `[PeriodEnd <DateTime?>]`: 
  - `[PeriodStart <DateTime?>]`: 
  - `[PrintConnectorId <String>]`: key: id of printConnector
  - `[PrintIdentityId <String>]`: key: id of printIdentity
  - `[PrintOperationId <String>]`: key: id of printOperation
  - `[PrintServiceEndpointId <String>]`: key: id of printServiceEndpoint
  - `[PrintServiceId <String>]`: key: id of printService
  - `[PrintTaskDefinitionId <String>]`: key: id of printTaskDefinition
  - `[PrintTaskId <String>]`: key: id of printTask
  - `[PrintTaskTriggerId <String>]`: key: id of printTaskTrigger
  - `[PrintUserIdentityId <String>]`: key: id of printUserIdentity
  - `[PrinterId <String>]`: key: id of printer
  - `[PrinterId1 <String>]`: 
  - `[PrinterShareId <String>]`: key: id of printerShare
  - `[ReportRootId <String>]`: key: id of reportRoot
  - `[TimeSpanInMinutes <Int32?>]`: 
  - `[TopListsSize <Int32?>]`: 
  - `[UserId <String>]`: 

## RELATED LINKS

