---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticdevicemetrichistory
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticDeviceMetricHistory

## SYNOPSIS
User experience analytics device metric history

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticDeviceMetricHistory [-AdditionalProperties <Hashtable>]
 [-DeviceId <String>] [-Id <String>] [-MetricDateTime <DateTime>] [-MetricType <String>]
 [-UserExperienceAnalyticsMetric <IMicrosoftGraphUserExperienceAnalyticsMetric>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticDeviceMetricHistory
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsMetricHistory> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
User experience analytics device metric history

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The user experience analytics metric history.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserExperienceAnalyticsMetricHistory
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceId
The user experience analytics device id.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MetricDateTime
The user experience analytics metric date time.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MetricType
The user experience analytics metric type.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserExperienceAnalyticsMetric
The user experience analytics metric contains the score and units of a metric of a user experience anlaytics category.
To construct, see NOTES section for USEREXPERIENCEANALYTICSMETRIC properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserExperienceAnalyticsMetric
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsMetricHistory
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsMetricHistory
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsMetricHistory>: The user experience analytics metric history.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[DeviceId <String>]`: The user experience analytics device id.
  - `[MetricDateTime <DateTime?>]`: The user experience analytics metric date time.
  - `[MetricType <String>]`: The user experience analytics metric type.
  - `[UserExperienceAnalyticsMetric <IMicrosoftGraphUserExperienceAnalyticsMetric>]`: The user experience analytics metric contains the score and units of a metric of a user experience anlaytics category.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Unit <String>]`: The unit of the user experience analytics metric.
    - `[Value <Double?>]`: The value of the user experience analytics metric.

USEREXPERIENCEANALYTICSMETRIC <IMicrosoftGraphUserExperienceAnalyticsMetric>: The user experience analytics metric contains the score and units of a metric of a user experience anlaytics category.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Unit <String>]`: The unit of the user experience analytics metric.
  - `[Value <Double?>]`: The value of the user experience analytics metric.

## RELATED LINKS
