---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticbaseline
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticBaseline

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsBaselines for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticBaseline [-AdditionalProperties <Hashtable>]
 [-AppHealthMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-BatteryHealthMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-BestPracticesMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>] [-CreatedDateTime <DateTime>]
 [-DeviceBootPerformanceMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>] [-DisplayName <String>]
 [-Id <String>] [-IsBuiltIn] [-RebootAnalyticsMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-ResourcePerformanceMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-WorkFromAnywhereMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticBaseline
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsBaseline> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsBaselines for deviceManagement

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

### -AppHealthMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, please use Get-Help -Online and see NOTES section for APPHEALTHMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BatteryHealthMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, please use Get-Help -Online and see NOTES section for BATTERYHEALTHMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BestPracticesMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, please use Get-Help -Online and see NOTES section for BESTPRACTICESMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The user experience analytics baseline entity contains baseline values against which to compare the user experience analytics scores.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBaseline
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date the custom baseline was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceBootPerformanceMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, please use Get-Help -Online and see NOTES section for DEVICEBOOTPERFORMANCEMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name of the user experience analytics baseline.

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

### -IsBuiltIn
Signifies if the current baseline is the commercial median baseline or a custom baseline.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RebootAnalyticsMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, please use Get-Help -Online and see NOTES section for REBOOTANALYTICSMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourcePerformanceMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, please use Get-Help -Online and see NOTES section for RESOURCEPERFORMANCEMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkFromAnywhereMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, please use Get-Help -Online and see NOTES section for WORKFROMANYWHEREMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBaseline

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBaseline

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPHEALTHMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]`: The insights for the user experience analytics category.
    - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Severity <String>]`: userExperienceAnalyticsInsightSeverity
    - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.
  - `[MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics category.
    - `[Id <String>]`: 
    - `[Unit <String>]`: The unit of the user experience analytics metric.
    - `[Value <Double?>]`: The value of the user experience analytics metric.

BATTERYHEALTHMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]`: The insights for the user experience analytics category.
    - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Severity <String>]`: userExperienceAnalyticsInsightSeverity
    - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.
  - `[MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics category.
    - `[Id <String>]`: 
    - `[Unit <String>]`: The unit of the user experience analytics metric.
    - `[Value <Double?>]`: The value of the user experience analytics metric.

BESTPRACTICESMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]`: The insights for the user experience analytics category.
    - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Severity <String>]`: userExperienceAnalyticsInsightSeverity
    - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.
  - `[MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics category.
    - `[Id <String>]`: 
    - `[Unit <String>]`: The unit of the user experience analytics metric.
    - `[Value <Double?>]`: The value of the user experience analytics metric.

BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsBaseline>: The user experience analytics baseline entity contains baseline values against which to compare the user experience analytics scores.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppHealthMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]`: The insights for the user experience analytics category.
      - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
      - `[Severity <String>]`: userExperienceAnalyticsInsightSeverity
      - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics insight.
      - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.
    - `[MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics category.
      - `[Id <String>]`: 
      - `[Unit <String>]`: The unit of the user experience analytics metric.
      - `[Value <Double?>]`: The value of the user experience analytics metric.
  - `[BatteryHealthMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[BestPracticesMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[CreatedDateTime <DateTime?>]`: The date the custom baseline was created.
  - `[DeviceBootPerformanceMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[DisplayName <String>]`: The name of the user experience analytics baseline.
  - `[IsBuiltIn <Boolean?>]`: Signifies if the current baseline is the commercial median baseline or a custom baseline.
  - `[RebootAnalyticsMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[ResourcePerformanceMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[WorkFromAnywhereMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.

DEVICEBOOTPERFORMANCEMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]`: The insights for the user experience analytics category.
    - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Severity <String>]`: userExperienceAnalyticsInsightSeverity
    - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.
  - `[MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics category.
    - `[Id <String>]`: 
    - `[Unit <String>]`: The unit of the user experience analytics metric.
    - `[Value <Double?>]`: The value of the user experience analytics metric.

REBOOTANALYTICSMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]`: The insights for the user experience analytics category.
    - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Severity <String>]`: userExperienceAnalyticsInsightSeverity
    - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.
  - `[MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics category.
    - `[Id <String>]`: 
    - `[Unit <String>]`: The unit of the user experience analytics metric.
    - `[Value <Double?>]`: The value of the user experience analytics metric.

RESOURCEPERFORMANCEMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]`: The insights for the user experience analytics category.
    - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Severity <String>]`: userExperienceAnalyticsInsightSeverity
    - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.
  - `[MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics category.
    - `[Id <String>]`: 
    - `[Unit <String>]`: The unit of the user experience analytics metric.
    - `[Value <Double?>]`: The value of the user experience analytics metric.

WORKFROMANYWHEREMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]`: The insights for the user experience analytics category.
    - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Severity <String>]`: userExperienceAnalyticsInsightSeverity
    - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.
  - `[MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics category.
    - `[Id <String>]`: 
    - `[Unit <String>]`: The unit of the user experience analytics metric.
    - `[Value <Double?>]`: The value of the user experience analytics metric.

## RELATED LINKS

