---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticresourceperformance
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticResourcePerformance

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsResourcePerformance for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticResourcePerformance [-AdditionalProperties <Hashtable>]
 [-AverageSpikeTimeScore <Int32>] [-CpuSpikeTimePercentage <Double>]
 [-CpuSpikeTimePercentageThreshold <Double>] [-CpuSpikeTimeScore <Int32>] [-DeviceCount <Int64>]
 [-DeviceId <String>] [-DeviceName <String>] [-DeviceResourcePerformanceScore <Int32>] [-Id <String>]
 [-Manufacturer <String>] [-Model <String>] [-RamSpikeTimePercentage <Double>]
 [-RamSpikeTimePercentageThreshold <Double>] [-RamSpikeTimeScore <Int32>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticResourcePerformance
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsResourcePerformance> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsResourcePerformance for deviceManagement

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

### -AverageSpikeTimeScore
AverageSpikeTimeScore of a device or a model type.
Valid values 0 to 100

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The user experience analytics resource performance entity.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsResourcePerformance
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CpuSpikeTimePercentage
CPU spike time in percentage.
Valid values 0 to 100

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CpuSpikeTimePercentageThreshold
Threshold of cpuSpikeTimeScore.
Valid values 0 to 100

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CpuSpikeTimeScore
The user experience analytics device CPU spike time score.
Valid values 0 to 100

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceCount
User experience analytics summarized device count.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId
The id of the device.

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

### -DeviceName
The name of the device.

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

### -DeviceResourcePerformanceScore
Resource performance score of a specific device.
Valid values 0 to 100

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manufacturer
The user experience analytics device manufacturer.

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

### -Model
The user experience analytics device model.

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

### -RamSpikeTimePercentage
RAM spike time in percentage.
Valid values 0 to 100

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RamSpikeTimePercentageThreshold
Threshold of ramSpikeTimeScore.
Valid values 0 to 100

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RamSpikeTimeScore
The user experience analytics device RAM spike time score.
Valid values 0 to 100

```yaml
Type: System.Int32
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsResourcePerformance

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsResourcePerformance

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsResourcePerformance>: The user experience analytics resource performance entity.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AverageSpikeTimeScore <Int32?>]`: AverageSpikeTimeScore of a device or a model type. Valid values 0 to 100
  - `[CpuSpikeTimePercentage <Double?>]`: CPU spike time in percentage. Valid values 0 to 100
  - `[CpuSpikeTimePercentageThreshold <Double?>]`: Threshold of cpuSpikeTimeScore. Valid values 0 to 100
  - `[CpuSpikeTimeScore <Int32?>]`: The user experience analytics device CPU spike time score. Valid values 0 to 100
  - `[DeviceCount <Int64?>]`: User experience analytics summarized device count.
  - `[DeviceId <String>]`: The id of the device.
  - `[DeviceName <String>]`: The name of the device.
  - `[DeviceResourcePerformanceScore <Int32?>]`: Resource performance score of a specific device. Valid values 0 to 100
  - `[Manufacturer <String>]`: The user experience analytics device manufacturer.
  - `[Model <String>]`: The user experience analytics device model.
  - `[RamSpikeTimePercentage <Double?>]`: RAM spike time in percentage. Valid values 0 to 100
  - `[RamSpikeTimePercentageThreshold <Double?>]`: Threshold of ramSpikeTimeScore. Valid values 0 to 100
  - `[RamSpikeTimeScore <Int32?>]`: The user experience analytics device RAM spike time score. Valid values 0 to 100

## RELATED LINKS

