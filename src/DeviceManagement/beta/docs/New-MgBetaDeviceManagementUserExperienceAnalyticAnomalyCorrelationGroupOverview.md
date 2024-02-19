---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement/new-mgbetadevicemanagementuserexperienceanalyticanomalycorrelationgroupoverview
schema: 2.0.0
---

# New-MgBetaDeviceManagementUserExperienceAnalyticAnomalyCorrelationGroupOverview

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsAnomalyCorrelationGroupOverview for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementUserExperienceAnalyticAnomalyCorrelationGroupOverview
 [-AdditionalProperties <Hashtable>] [-AnomalyCorrelationGroupCount <Int32>] [-AnomalyId <String>]
 [-CorrelationGroupAnomalousDeviceCount <Int32>] [-CorrelationGroupAtRiskDeviceCount <Int32>]
 [-CorrelationGroupDeviceCount <Int32>]
 [-CorrelationGroupFeatures <IMicrosoftGraphUserExperienceAnalyticsAnomalyCorrelationGroupFeature[]>]
 [-CorrelationGroupId <String>]
 [-CorrelationGroupPrevalence <UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence>]
 [-CorrelationGroupPrevalencePercentage <Double>] [-Id <String>] [-TotalDeviceCount <Int32>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementUserExperienceAnalyticAnomalyCorrelationGroupOverview
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsAnomalyCorrelationGroupOverview> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsAnomalyCorrelationGroupOverview for deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



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

### -AnomalyCorrelationGroupCount
Indicates the number of correlation groups in the anomaly.
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

### -AnomalyId
The unique identifier of the anomaly.
Anomaly details such as name and type can be found in the UserExperienceAnalyticsAnomalySeverityOverview entity.

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

### -BodyParameter
The user experience analytics anomaly correlation group overview entity contains the information for each correlation group of an anomaly.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAnomalyCorrelationGroupOverview
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CorrelationGroupAnomalousDeviceCount
Indicates the total number of devices affected by the anomaly in the correlation group.
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

### -CorrelationGroupAtRiskDeviceCount
Indicates the total number of devices at risk in the correlation group.
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

### -CorrelationGroupDeviceCount
Indicates the total number of devices in a correlation group.
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

### -CorrelationGroupFeatures
Describes the features of a device that are shared between all devices in a correlation group.
To construct, see NOTES section for CORRELATIONGROUPFEATURES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAnomalyCorrelationGroupFeature[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CorrelationGroupId
The unique identifier for the correlation group which will uniquely identify one of the correlation group within an anomaly.
The correlation Id can be mapped to the correlation group name by concatinating the correlation group features.
Example of correlation group name which is the indicative of concatenated features names are for names, Contoso manufacture 4.4.1 and Windows 11.22621.1485.

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

### -CorrelationGroupPrevalence
Indicates the level of prevalence of the correlation group features in the anomaly.
Possible values are: high, medium or low

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CorrelationGroupPrevalencePercentage
The percentage of the devices in the correlation group that are anomalous.
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

### -TotalDeviceCount
Indicates the total number of devices in the tenant.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAnomalyCorrelationGroupOverview

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAnomalyCorrelationGroupOverview

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsAnomalyCorrelationGroupOverview>`: The user experience analytics anomaly correlation group overview entity contains the information for each correlation group of an anomaly.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AnomalyCorrelationGroupCount <Int32?>]`: Indicates the number of correlation groups in the anomaly. Valid values -2147483648 to 2147483647
  - `[AnomalyId <String>]`: The unique identifier of the anomaly. Anomaly details such as name and type can be found in the UserExperienceAnalyticsAnomalySeverityOverview entity.
  - `[CorrelationGroupAnomalousDeviceCount <Int32?>]`: Indicates the total number of devices affected by the anomaly in the correlation group. Valid values -2147483648 to 2147483647
  - `[CorrelationGroupAtRiskDeviceCount <Int32?>]`: Indicates the total number of devices at risk in the correlation group. Valid values -2147483648 to 2147483647
  - `[CorrelationGroupDeviceCount <Int32?>]`: Indicates the total number of devices in a correlation group. Valid values -2147483648 to 2147483647
  - `[CorrelationGroupFeatures <IMicrosoftGraphUserExperienceAnalyticsAnomalyCorrelationGroupFeature[]>]`: Describes the features of a device that are shared between all devices in a correlation group.
    - `[DeviceFeatureType <UserExperienceAnalyticsAnomalyDeviceFeatureType?>]`: Indicates the device's feature type. Possible values are: manufacturer, model, osVersion, application or driver.
    - `[Values <String[]>]`: Specific metric values that describe the features of the given device feature type.
  - `[CorrelationGroupId <String>]`: The unique identifier for the correlation group which will uniquely identify one of the correlation group within an anomaly. The correlation Id can be mapped to the correlation group name by concatinating the correlation group features. Example of correlation group name which is the indicative of concatenated features names are  for names, Contoso manufacture 4.4.1 and Windows 11.22621.1485.
  - `[CorrelationGroupPrevalence <UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence?>]`: Indicates the level of prevalence of the correlation group features in the anomaly. Possible values are: high, medium or low
  - `[CorrelationGroupPrevalencePercentage <Double?>]`: The percentage of the devices in the correlation group that are anomalous. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[TotalDeviceCount <Int32?>]`: Indicates the total number of devices in the tenant. Valid values -2147483648 to 2147483647

`CORRELATIONGROUPFEATURES <IMicrosoftGraphUserExperienceAnalyticsAnomalyCorrelationGroupFeature[]>`: Describes the features of a device that are shared between all devices in a correlation group.
  - `[DeviceFeatureType <UserExperienceAnalyticsAnomalyDeviceFeatureType?>]`: Indicates the device's feature type. Possible values are: manufacturer, model, osVersion, application or driver.
  - `[Values <String[]>]`: Specific metric values that describe the features of the given device feature type.

## RELATED LINKS

