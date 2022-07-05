---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementuserexperienceanalyticregressionsummary
schema: 2.0.0
---

# Update-MgDeviceManagementUserExperienceAnalyticRegressionSummary

## SYNOPSIS
Update the navigation property userExperienceAnalyticsRegressionSummary in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementUserExperienceAnalyticRegressionSummary [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-ManufacturerRegression <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]
 [-ModelRegression <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]
 [-OperatingSystemRegression <IMicrosoftGraphUserExperienceAnalyticsMetric[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementUserExperienceAnalyticRegressionSummary
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsRegressionSummary> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property userExperienceAnalyticsRegressionSummary in deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The user experience analytics Regression Summary.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsRegressionSummary
Parameter Sets: Update
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManufacturerRegression
The metric values for the user experience analytics Manufacturer regression.
To construct, please use Get-Help -Online and see NOTES section for MANUFACTURERREGRESSION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsMetric[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModelRegression
The metric values for the user experience analytics model regression.
To construct, please use Get-Help -Online and see NOTES section for MODELREGRESSION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsMetric[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OperatingSystemRegression
The metric values for the user experience analytics operating system regression.
To construct, please use Get-Help -Online and see NOTES section for OPERATINGSYSTEMREGRESSION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsMetric[]
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
Type: System.Management.Automation.SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsRegressionSummary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsRegressionSummary>: The user experience analytics Regression Summary.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ManufacturerRegression <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics Manufacturer regression.
    - `[Id <String>]`: 
    - `[Unit <String>]`: The unit of the user experience analytics metric.
    - `[Value <Double?>]`: The value of the user experience analytics metric.
  - `[ModelRegression <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics model regression.
  - `[OperatingSystemRegression <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics operating system regression.

MANUFACTURERREGRESSION <IMicrosoftGraphUserExperienceAnalyticsMetric[]>: The metric values for the user experience analytics Manufacturer regression.
  - `[Id <String>]`: 
  - `[Unit <String>]`: The unit of the user experience analytics metric.
  - `[Value <Double?>]`: The value of the user experience analytics metric.

MODELREGRESSION <IMicrosoftGraphUserExperienceAnalyticsMetric[]>: The metric values for the user experience analytics model regression.
  - `[Id <String>]`: 
  - `[Unit <String>]`: The unit of the user experience analytics metric.
  - `[Value <Double?>]`: The value of the user experience analytics metric.

OPERATINGSYSTEMREGRESSION <IMicrosoftGraphUserExperienceAnalyticsMetric[]>: The metric values for the user experience analytics operating system regression.
  - `[Id <String>]`: 
  - `[Unit <String>]`: The unit of the user experience analytics metric.
  - `[Value <Double?>]`: The value of the user experience analytics metric.

## RELATED LINKS

