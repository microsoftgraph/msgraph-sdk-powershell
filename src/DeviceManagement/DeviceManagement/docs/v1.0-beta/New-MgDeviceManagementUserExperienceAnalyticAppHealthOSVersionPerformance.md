---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticapphealthosversionperformance
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticAppHealthOSVersionPerformance

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsAppHealthOSVersionPerformance for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticAppHealthOSVersionPerformance [-ActiveDeviceCount <Int32>]
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-MeanTimeToFailureInMinutes <Int32>]
 [-OSBuildNumber <String>] [-OSVersion <String>] [-OSVersionAppHealthScore <Double>]
 [-OSVersionAppHealthStatus <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticAppHealthOSVersionPerformance
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsAppHealthOSVersionPerformance> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsAppHealthOSVersionPerformance for deviceManagement

## EXAMPLES

## PARAMETERS

### -ActiveDeviceCount
The number of active devices for the OS version.
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
The user experience analytics device OS version performance entity contains OS version performance details.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthOSVersionPerformance
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
The mean time to failure for the OS version in minutes.
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

### -OSBuildNumber
The OS build number installed on the device.

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

### -OSVersion
The OS version installed on the device.

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

### -OSVersionAppHealthScore
The app health score of the OS version.
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

### -OSVersionAppHealthStatus
The overall app health status of the OS version.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthOSVersionPerformance

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthOSVersionPerformance

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsAppHealthOSVersionPerformance>: The user experience analytics device OS version performance entity contains OS version performance details.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ActiveDeviceCount <Int32?>]`: The number of active devices for the OS version. Valid values -2147483648 to 2147483647
  - `[MeanTimeToFailureInMinutes <Int32?>]`: The mean time to failure for the OS version in minutes. Valid values -2147483648 to 2147483647
  - `[OSBuildNumber <String>]`: The OS build number installed on the device.
  - `[OSVersion <String>]`: The OS version installed on the device.
  - `[OSVersionAppHealthScore <Double?>]`: The app health score of the OS version. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[OSVersionAppHealthStatus <String>]`: The overall app health status of the OS version.

## RELATED LINKS

