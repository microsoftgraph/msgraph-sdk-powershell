---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticapphealthdevicemodelperformance
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticAppHealthDeviceModelPerformance

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsAppHealthDeviceModelPerformance for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticAppHealthDeviceModelPerformance [-ActiveDeviceCount <Int32>]
 [-AdditionalProperties <Hashtable>] [-DeviceManufacturer <String>] [-DeviceModel <String>]
 [-HealthStatus <String>] [-Id <String>] [-MeanTimeToFailureInMinutes <Int32>] [-ModelAppHealthScore <Double>]
 [-ModelAppHealthStatus <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticAppHealthDeviceModelPerformance
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsAppHealthDeviceModelPerformance> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsAppHealthDeviceModelPerformance for deviceManagement

## EXAMPLES

## PARAMETERS

### -ActiveDeviceCount
The number of active devices for the model.
Valid values -2147483648 to 2147483647

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
The user experience analytics device model performance entity contains device model performance details.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthDeviceModelPerformance
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceManufacturer
The manufacturer name of the device.

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

### -DeviceModel
The model name of the device.

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

### -HealthStatus
userExperienceAnalyticsHealthState

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

### -MeanTimeToFailureInMinutes
The mean time to failure for the model device in minutes.
Valid values -2147483648 to 2147483647

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

### -ModelAppHealthScore
The app health score of the device model.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

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

### -ModelAppHealthStatus
The overall app health status of the device model.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthDeviceModelPerformance

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthDeviceModelPerformance

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsAppHealthDeviceModelPerformance>: The user experience analytics device model performance entity contains device model performance details.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ActiveDeviceCount <Int32?>]`: The number of active devices for the model. Valid values -2147483648 to 2147483647
  - `[DeviceManufacturer <String>]`: The manufacturer name of the device.
  - `[DeviceModel <String>]`: The model name of the device.
  - `[HealthStatus <String>]`: userExperienceAnalyticsHealthState
  - `[MeanTimeToFailureInMinutes <Int32?>]`: The mean time to failure for the model device in minutes. Valid values -2147483648 to 2147483647
  - `[ModelAppHealthScore <Double?>]`: The app health score of the device model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[ModelAppHealthStatus <String>]`: The overall app health status of the device model.

## RELATED LINKS

