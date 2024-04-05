---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement/update-mgbetadevicemanagementuserexperienceanalyticbatteryhealthruntimedetail
schema: 2.0.0
---

# Update-MgBetaDeviceManagementUserExperienceAnalyticBatteryHealthRuntimeDetail

## SYNOPSIS
Update the navigation property userExperienceAnalyticsBatteryHealthRuntimeDetails in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementUserExperienceAnalyticBatteryHealthRuntimeDetail [-ActiveDevices <Int32>]
 [-AdditionalProperties <Hashtable>] [-BatteryRuntimeFair <Int32>] [-BatteryRuntimeGood <Int32>]
 [-BatteryRuntimePoor <Int32>] [-Id <String>] [-LastRefreshedDateTime <DateTime>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementUserExperienceAnalyticBatteryHealthRuntimeDetail
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsBatteryHealthRuntimeDetails>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property userExperienceAnalyticsBatteryHealthRuntimeDetails in deviceManagement

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

### -ActiveDevices
Number of active devices within the tenant.
Valid values 0 to 2147483647

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BatteryRuntimeFair
Number of devices whose active runtime is greater than 3 hours but lesser than 5 hours.
Valid values 0 to 2147483647

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BatteryRuntimeGood
Number of devices whose active runtime is greater than 5 hours.
Valid values 0 to 2147483647

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BatteryRuntimePoor
Number of devices whose active runtime is lesser than 3 hours.
Valid values 0 to 2147483647

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The user experience analytics battery health runtime entity contains count of devices broken down into 3 categories - devices with runtime \> 5 hours, devices with runtime 3-5 hours and devices with runtime \< 3 hours.This API provides the count of devices in these 3 categories.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBatteryHealthRuntimeDetails
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

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

### -LastRefreshedDateTime
Recorded date time of this runtime details instance.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBatteryHealthRuntimeDetails

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBatteryHealthRuntimeDetails

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsBatteryHealthRuntimeDetails>`: The user experience analytics battery health runtime entity contains count of devices broken down into 3 categories - devices with runtime > 5 hours, devices with runtime 3-5 hours and devices with runtime < 3 hours.This API provides the count of devices in these 3 categories.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActiveDevices <Int32?>]`: Number of active devices within the tenant. Valid values 0 to 2147483647
  - `[BatteryRuntimeFair <Int32?>]`: Number of devices whose active runtime is greater than 3 hours but lesser than 5 hours. Valid values 0 to 2147483647
  - `[BatteryRuntimeGood <Int32?>]`: Number of devices  whose active runtime is greater than 5 hours. Valid values 0 to 2147483647
  - `[BatteryRuntimePoor <Int32?>]`: Number of devices whose active runtime is lesser than 3 hours. Valid values 0 to 2147483647
  - `[LastRefreshedDateTime <DateTime?>]`: Recorded date time of this runtime details instance.

## RELATED LINKS

