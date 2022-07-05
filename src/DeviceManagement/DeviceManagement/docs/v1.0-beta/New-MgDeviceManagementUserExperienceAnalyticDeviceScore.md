---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticdevicescore
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticDeviceScore

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsDeviceScores for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticDeviceScore [-AdditionalProperties <Hashtable>]
 [-AppReliabilityScore <Double>] [-BatteryHealthScore <Double>] [-DeviceName <String>]
 [-EndpointAnalyticsScore <Double>] [-HealthStatus <String>] [-Id <String>] [-Manufacturer <String>]
 [-Model <String>] [-StartupPerformanceScore <Double>] [-WorkFromAnywhereScore <Double>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticDeviceScore
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsDeviceScores> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsDeviceScores for deviceManagement

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

### -AppReliabilityScore
The user experience analytics device app reliability score.
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

### -BatteryHealthScore
The user experience analytics device battery health score.
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

### -BodyParameter
The user experience analytics device scores entity consolidates the various endpoint analytics scores.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsDeviceScores
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceName
The user experience analytics device name.

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

### -EndpointAnalyticsScore
The user experience analytics device score.
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

### -StartupPerformanceScore
The user experience analytics device startup performance score.
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

### -WorkFromAnywhereScore
The user experience analytics device work From anywhere score.
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsDeviceScores

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsDeviceScores

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsDeviceScores>: The user experience analytics device scores entity consolidates the various endpoint analytics scores.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppReliabilityScore <Double?>]`: The user experience analytics device app reliability score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[BatteryHealthScore <Double?>]`: The user experience analytics device battery health score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[DeviceName <String>]`: The user experience analytics device name.
  - `[EndpointAnalyticsScore <Double?>]`: The user experience analytics device score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[HealthStatus <String>]`: userExperienceAnalyticsHealthState
  - `[Manufacturer <String>]`: The user experience analytics device manufacturer.
  - `[Model <String>]`: The user experience analytics device model.
  - `[StartupPerformanceScore <Double?>]`: The user experience analytics device startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[WorkFromAnywhereScore <Double?>]`: The user experience analytics device work From anywhere score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308

## RELATED LINKS

