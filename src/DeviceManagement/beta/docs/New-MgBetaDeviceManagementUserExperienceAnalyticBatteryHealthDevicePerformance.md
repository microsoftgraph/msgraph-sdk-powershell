---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement/new-mgbetadevicemanagementuserexperienceanalyticbatteryhealthdeviceperformance
schema: 2.0.0
---

# New-MgBetaDeviceManagementUserExperienceAnalyticBatteryHealthDevicePerformance

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsBatteryHealthDevicePerformance for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementUserExperienceAnalyticBatteryHealthDevicePerformance
 [-AdditionalProperties <Hashtable>] [-BatteryAgeInDays <Int32>]
 [-DeviceBatteriesDetails <IMicrosoftGraphUserExperienceAnalyticsDeviceBatteryDetail[]>]
 [-DeviceBatteryCount <Int32>] [-DeviceBatteryHealthScore <Int32>] [-DeviceBatteryTags <String[]>]
 [-DeviceId <String>] [-DeviceName <String>] [-EstimatedRuntimeInMinutes <Int32>]
 [-FullBatteryDrainCount <Int32>] [-HealthStatus <UserExperienceAnalyticsHealthState>] [-Id <String>]
 [-Manufacturer <String>] [-MaxCapacityPercentage <Int32>] [-Model <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementUserExperienceAnalyticBatteryHealthDevicePerformance
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsBatteryHealthDevicePerformance>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsBatteryHealthDevicePerformance for deviceManagement

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BatteryAgeInDays
Estimated battery age.
Unit in days.
Valid values 0 to 2147483647

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
The user experience analytics battery health device performance entity contains device level battery information.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBatteryHealthDevicePerformance
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceBatteriesDetails
Properties (maxCapacity and cycleCount) related to all batteries of the device.
To construct, see NOTES section for DEVICEBATTERIESDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsDeviceBatteryDetail[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceBatteryCount
Number of batteries in a user device.
Valid values 0 to 2147483647

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

### -DeviceBatteryHealthScore
A weighted average of a device’s maximum capacity score and runtime estimate score.
Values range from 0-100.
Valid values 0 to 2147483647

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

### -DeviceBatteryTags
Tags for computed information on how battery on the device is behaving.
E.g.
newbattery, batterycapacityred, designcapacityzero, etc.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId
The unique identifier of the device, Intune DeviceID.

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
Device friendly name.

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

### -EstimatedRuntimeInMinutes
The estimated runtime of the device when the battery is fully charged.
Unit in minutes.
Valid values 0 to 2147483647

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

### -FullBatteryDrainCount
Number of times the battery has been discharged an amount that equals 100% of its capacity, but not necessarily by discharging it from 100% to 0%.
Valid values 0 to 2147483647

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

### -HealthStatus
userExperienceAnalyticsHealthState

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.UserExperienceAnalyticsHealthState
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manufacturer
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

### -MaxCapacityPercentage
Ratio of current capacity and design capacity of the battery with the lowest capacity.
Unit in percentage and values range from 0-100.
Valid values 0 to 2147483647

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

### -Model
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBatteryHealthDevicePerformance

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBatteryHealthDevicePerformance

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsBatteryHealthDevicePerformance>`: The user experience analytics battery health device performance entity contains device level battery information.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[BatteryAgeInDays <Int32?>]`: Estimated battery age. Unit in days. Valid values 0 to 2147483647
  - `[DeviceBatteriesDetails <IMicrosoftGraphUserExperienceAnalyticsDeviceBatteryDetail[]>]`: Properties (maxCapacity and cycleCount) related to all batteries of the device.
    - `[BatteryId <String>]`: Uniquely identifies the batteries in a single device.
    - `[FullBatteryDrainCount <Int32?>]`: Number of times the battery has been discharged an amount that equals 100% of its capacity, but not necessarily by discharging it from 100% to 0%. Valid values 0 to 2147483647
    - `[MaxCapacityPercentage <Int32?>]`: Ratio of current capacity and design capacity of the battery. Unit in percentage and values range from 0-100. Valid values 0 to 2147483647
  - `[DeviceBatteryCount <Int32?>]`: Number of batteries in a user device. Valid values 0 to 2147483647
  - `[DeviceBatteryHealthScore <Int32?>]`: A weighted average of a device’s maximum capacity score and runtime estimate score. Values range from 0-100. Valid values 0 to 2147483647
  - `[DeviceBatteryTags <String[]>]`: Tags for computed information on how battery on the device is behaving. E.g. newbattery, batterycapacityred, designcapacityzero, etc.
  - `[DeviceId <String>]`: The unique identifier of the device, Intune DeviceID.
  - `[DeviceName <String>]`: Device friendly name.
  - `[EstimatedRuntimeInMinutes <Int32?>]`: The estimated runtime of the device when the battery is fully charged. Unit in minutes. Valid values 0 to 2147483647
  - `[FullBatteryDrainCount <Int32?>]`: Number of times the battery has been discharged an amount that equals 100% of its capacity, but not necessarily by discharging it from 100% to 0%. Valid values 0 to 2147483647
  - `[HealthStatus <UserExperienceAnalyticsHealthState?>]`: userExperienceAnalyticsHealthState
  - `[Manufacturer <String>]`: The manufacturer name of the device.
  - `[MaxCapacityPercentage <Int32?>]`: Ratio of current capacity and design capacity of the battery with the lowest capacity. Unit in percentage and values range from 0-100. Valid values 0 to 2147483647
  - `[Model <String>]`: The model name of the device.

`DEVICEBATTERIESDETAILS <IMicrosoftGraphUserExperienceAnalyticsDeviceBatteryDetail[]>`: Properties (maxCapacity and cycleCount) related to all batteries of the device.
  - `[BatteryId <String>]`: Uniquely identifies the batteries in a single device.
  - `[FullBatteryDrainCount <Int32?>]`: Number of times the battery has been discharged an amount that equals 100% of its capacity, but not necessarily by discharging it from 100% to 0%. Valid values 0 to 2147483647
  - `[MaxCapacityPercentage <Int32?>]`: Ratio of current capacity and design capacity of the battery. Unit in percentage and values range from 0-100. Valid values 0 to 2147483647

## RELATED LINKS

