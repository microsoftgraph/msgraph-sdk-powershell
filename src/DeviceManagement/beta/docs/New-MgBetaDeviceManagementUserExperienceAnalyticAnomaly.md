---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement/new-mgbetadevicemanagementuserexperienceanalyticanomaly
schema: 2.0.0
---

# New-MgBetaDeviceManagementUserExperienceAnalyticAnomaly

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsAnomaly for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementUserExperienceAnalyticAnomaly [-AdditionalProperties <Hashtable>]
 [-AnomalyFirstOccurrenceDateTime <DateTime>] [-AnomalyId <String>]
 [-AnomalyLatestOccurrenceDateTime <DateTime>] [-AnomalyName <String>]
 [-AnomalyType <UserExperienceAnalyticsAnomalyType>] [-AssetName <String>] [-AssetPublisher <String>]
 [-AssetVersion <String>] [-DetectionModelId <String>] [-DeviceImpactedCount <Int32>] [-Id <String>]
 [-IssueId <String>] [-Severity <UserExperienceAnalyticsAnomalySeverity>]
 [-State <UserExperienceAnalyticsAnomalyState>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementUserExperienceAnalyticAnomaly
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsAnomaly> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsAnomaly for deviceManagement

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

### -AnomalyFirstOccurrenceDateTime
Indicates the first occurrence date and time for the anomaly.

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

### -AnomalyId
The unique identifier of the anomaly.

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

### -AnomalyLatestOccurrenceDateTime
Indicates the latest occurrence date and time for the anomaly.

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

### -AnomalyName
The name of the anomaly.

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

### -AnomalyType
Indicates the category of the anomaly.
Eg: anomaly type can be device, application, stop error, driver or other.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.UserExperienceAnalyticsAnomalyType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssetName
The name of the application or module that caused the anomaly.

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

### -AssetPublisher
The publisher of the application or module that caused the anomaly.

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

### -AssetVersion
The version of the application or module that caused the anomaly.

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
The user experience analytics anomaly entity contains anomaly details.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAnomaly
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DetectionModelId
The unique identifier of the anomaly detection model.

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

### -DeviceImpactedCount
The number of devices impacted by the anomaly.
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

### -IssueId
The unique identifier of the anomaly detection model.

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

### -Severity
Indicates the severity of the anomaly.
Eg: anomaly severity can be high, medium, low, informational or other.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.UserExperienceAnalyticsAnomalySeverity
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
Indicates the state of the anomaly.
Eg: anomaly severity can be new, active, disabled, removed or other.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.UserExperienceAnalyticsAnomalyState
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAnomaly

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAnomaly

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsAnomaly>`: The user experience analytics anomaly entity contains anomaly details.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AnomalyFirstOccurrenceDateTime <DateTime?>]`: Indicates the first occurrence date and time for the anomaly.
  - `[AnomalyId <String>]`: The unique identifier of the anomaly.
  - `[AnomalyLatestOccurrenceDateTime <DateTime?>]`: Indicates the latest occurrence date and time for the anomaly.
  - `[AnomalyName <String>]`: The name of the anomaly.
  - `[AnomalyType <UserExperienceAnalyticsAnomalyType?>]`: Indicates the category of the anomaly. Eg: anomaly type can be device, application, stop error, driver or other.
  - `[AssetName <String>]`: The name of the application or module that caused the anomaly.
  - `[AssetPublisher <String>]`: The publisher of the application or module that caused the anomaly.
  - `[AssetVersion <String>]`: The version of the application or module that caused the anomaly.
  - `[DetectionModelId <String>]`: The unique identifier of the anomaly detection model.
  - `[DeviceImpactedCount <Int32?>]`: The number of devices impacted by the anomaly. Valid values -2147483648 to 2147483647
  - `[IssueId <String>]`: The unique identifier of the anomaly detection model.
  - `[Severity <UserExperienceAnalyticsAnomalySeverity?>]`: Indicates the severity of the anomaly. Eg: anomaly severity can be high, medium, low, informational or other.
  - `[State <UserExperienceAnalyticsAnomalyState?>]`: Indicates the state of the anomaly. Eg: anomaly severity can be new, active, disabled, removed or other.

## RELATED LINKS

