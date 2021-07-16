---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticworkfromanywheremetric
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric

## SYNOPSIS
User experience analytics work from anywhere metrics.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-MetricDevices <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
User experience analytics work from anywhere metrics.

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
The user experience analytics metric for work from anywhere report
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MetricDevices
The work from anywhere metric devices.
To construct, see NOTES section for METRICDEVICES properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric>: The user experience analytics metric for work from anywhere report
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[MetricDevices <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]>]`: The work from anywhere metric devices.
    - `[Id <String>]`: Read-only.
    - `[AutoPilotProfileAssigned <Boolean?>]`: The user experience analytics work from anywhere intune device's autopilotProfileAssigned.
    - `[AutoPilotRegistered <Boolean?>]`: The user experience work from anywhere intune device's autopilotRegistered.
    - `[AzureAdDeviceId <String>]`: The user experience work from anywhere azure Ad device Id.
    - `[AzureAdJoinType <String>]`: The user experience work from anywhere device's azure Ad joinType.
    - `[AzureAdRegistered <Boolean?>]`: The user experience work from anywhere device's azureAdRegistered.
    - `[DeviceName <String>]`: The work from anywhere device's name.
    - `[ManagedBy <String>]`: The user experience work from anywhere management agent of the device.
    - `[Manufacturer <String>]`: The user experience work from anywhere device's manufacturer.
    - `[Model <String>]`: The user experience work from anywhere device's model.
    - `[OSDescription <String>]`: The user experience work from anywhere device's OS Description.
    - `[OSVersion <String>]`: The user experience work from anywhere device's OS Version.
    - `[Ownership <String>]`: The user experience work from anywhere device's ownership.
    - `[SerialNumber <String>]`: The user experience work from anywhere device's serial number.

METRICDEVICES <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]>: The work from anywhere metric devices.
  - `[Id <String>]`: Read-only.
  - `[AutoPilotProfileAssigned <Boolean?>]`: The user experience analytics work from anywhere intune device's autopilotProfileAssigned.
  - `[AutoPilotRegistered <Boolean?>]`: The user experience work from anywhere intune device's autopilotRegistered.
  - `[AzureAdDeviceId <String>]`: The user experience work from anywhere azure Ad device Id.
  - `[AzureAdJoinType <String>]`: The user experience work from anywhere device's azure Ad joinType.
  - `[AzureAdRegistered <Boolean?>]`: The user experience work from anywhere device's azureAdRegistered.
  - `[DeviceName <String>]`: The work from anywhere device's name.
  - `[ManagedBy <String>]`: The user experience work from anywhere management agent of the device.
  - `[Manufacturer <String>]`: The user experience work from anywhere device's manufacturer.
  - `[Model <String>]`: The user experience work from anywhere device's model.
  - `[OSDescription <String>]`: The user experience work from anywhere device's OS Description.
  - `[OSVersion <String>]`: The user experience work from anywhere device's OS Version.
  - `[Ownership <String>]`: The user experience work from anywhere device's ownership.
  - `[SerialNumber <String>]`: The user experience work from anywhere device's serial number.

## RELATED LINKS
