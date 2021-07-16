---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementuserexperienceanalyticapphealthoverview
schema: 2.0.0
---

# Update-MgDeviceManagementUserExperienceAnalyticAppHealthOverview

## SYNOPSIS
User experience analytics appHealth overview

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementUserExperienceAnalyticAppHealthOverview [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]
 [-MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementUserExperienceAnalyticAppHealthOverview
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsCategory> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
User experience analytics appHealth overview

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Insights
The insights for the user experience analytics category.
To construct, see NOTES section for INSIGHTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserExperienceAnalyticsInsight[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MetricValues
The metric values for the user experience analytics category.
To construct, see NOTES section for METRICVALUES properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserExperienceAnalyticsMetric[]
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsCategory>: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]`: The insights for the user experience analytics category.
    - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Severity <String>]`: userExperienceAnalyticsInsightSeverity
    - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.
  - `[MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics category.
    - `[Id <String>]`: Read-only.
    - `[Unit <String>]`: The unit of the user experience analytics metric.
    - `[Value <Double?>]`: The value of the user experience analytics metric.

INSIGHTS <IMicrosoftGraphUserExperienceAnalyticsInsight[]>: The insights for the user experience analytics category.
  - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
  - `[Severity <String>]`: userExperienceAnalyticsInsightSeverity
  - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics insight.
  - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.

METRICVALUES <IMicrosoftGraphUserExperienceAnalyticsMetric[]>: The metric values for the user experience analytics category.
  - `[Id <String>]`: Read-only.
  - `[Unit <String>]`: The unit of the user experience analytics metric.
  - `[Value <Double?>]`: The value of the user experience analytics metric.

## RELATED LINKS
