---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticanomalydevice
schema: 2.0.0
---

# New-MgBetaDeviceManagementUserExperienceAnalyticAnomalyDevice

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsAnomalyDevice for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementUserExperienceAnalyticAnomalyDevice [-AdditionalProperties <Hashtable>]
 [-AnomalyId <String>] [-AnomalyOnDeviceFirstOccurrenceDateTime <DateTime>]
 [-AnomalyOnDeviceLatestOccurrenceDateTime <DateTime>] [-DeviceId <String>] [-DeviceManufacturer <String>]
 [-DeviceModel <String>] [-DeviceName <String>] [-Id <String>] [-OSName <String>] [-OSVersion <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementUserExperienceAnalyticAnomalyDevice
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsAnomalyDevice> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsAnomalyDevice for deviceManagement

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

### -AnomalyOnDeviceFirstOccurrenceDateTime
Indicates the first occurance date and time for the anomaly on the device.

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

### -AnomalyOnDeviceLatestOccurrenceDateTime
Indicates the latest occurance date and time for the anomaly on the device.

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

### -BodyParameter
The user experience analytics anomaly entity contains device details.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAnomalyDevice
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceId
The unique identifier of the device.

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

### -DeviceName
The name of the device.

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
The unique idenfier for an entity.
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

### -OSName
The name of the OS installed on the device.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAnomalyDevice

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAnomalyDevice

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsAnomalyDevice>: The user experience analytics anomaly entity contains device details.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AnomalyId <String>]`: The unique identifier of the anomaly.
  - `[AnomalyOnDeviceFirstOccurrenceDateTime <DateTime?>]`: Indicates the first occurance date and time for the anomaly on the device.
  - `[AnomalyOnDeviceLatestOccurrenceDateTime <DateTime?>]`: Indicates the latest occurance date and time for the anomaly on the device.
  - `[DeviceId <String>]`: The unique identifier of the device.
  - `[DeviceManufacturer <String>]`: The manufacturer name of the device.
  - `[DeviceModel <String>]`: The model name of the device.
  - `[DeviceName <String>]`: The name of the device.
  - `[OSName <String>]`: The name of the OS installed on the device.
  - `[OSVersion <String>]`: The OS version installed on the device.

## RELATED LINKS

