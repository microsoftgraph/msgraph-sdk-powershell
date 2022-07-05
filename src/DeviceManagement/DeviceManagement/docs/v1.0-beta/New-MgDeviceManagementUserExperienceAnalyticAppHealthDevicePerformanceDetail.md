---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticapphealthdeviceperformancedetail
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticAppHealthDevicePerformanceDetail

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsAppHealthDevicePerformanceDetails for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticAppHealthDevicePerformanceDetail
 [-AdditionalProperties <Hashtable>] [-AppDisplayName <String>] [-AppPublisher <String>]
 [-AppVersion <String>] [-DeviceDisplayName <String>] [-DeviceId <String>] [-EventDateTime <DateTime>]
 [-EventType <String>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticAppHealthDevicePerformanceDetail
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsAppHealthDevicePerformanceDetails> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsAppHealthDevicePerformanceDetails for deviceManagement

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

### -AppDisplayName
The friendly name of the application for which the event occurred.

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

### -AppPublisher
The publisher of the application.

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

### -AppVersion
The version of the application.

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
The user experience analytics device performance entity contains device performance details.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthDevicePerformanceDetails
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceDisplayName
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

### -DeviceId
The id of the device.

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

### -EventDateTime
The time the event occurred.

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

### -EventType
The type of the event.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthDevicePerformanceDetails

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthDevicePerformanceDetails

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsAppHealthDevicePerformanceDetails>: The user experience analytics device performance entity contains device performance details.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppDisplayName <String>]`: The friendly name of the application for which the event occurred.
  - `[AppPublisher <String>]`: The publisher of the application.
  - `[AppVersion <String>]`: The version of the application.
  - `[DeviceDisplayName <String>]`: The name of the device.
  - `[DeviceId <String>]`: The id of the device.
  - `[EventDateTime <DateTime?>]`: The time the event occurred.
  - `[EventType <String>]`: The type of the event.

## RELATED LINKS

