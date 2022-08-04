---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementuserexperienceanalyticbatteryhealthcapacitydetail
schema: 2.0.0
---

# Update-MgDeviceManagementUserExperienceAnalyticBatteryHealthCapacityDetail

## SYNOPSIS
Update the navigation property userExperienceAnalyticsBatteryHealthCapacityDetails in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementUserExperienceAnalyticBatteryHealthCapacityDetail [-ActiveDevices <Int32>]
 [-AdditionalProperties <Hashtable>] [-BatteryCapacityFair <Int32>] [-BatteryCapacityGood <Int32>]
 [-BatteryCapacityPoor <Int32>] [-Id <String>] [-LastRefreshedDateTime <DateTime>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementUserExperienceAnalyticBatteryHealthCapacityDetail
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsBatteryHealthCapacityDetails> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property userExperienceAnalyticsBatteryHealthCapacityDetails in deviceManagement

## EXAMPLES

## PARAMETERS

### -ActiveDevices
Number of active devices within the tenant.
Valid values -2147483648 to 2147483647

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

### -BatteryCapacityFair
Number of devices whose battery maximum capacity is greater than 50% but lesser than 80%.
Valid values -2147483648 to 2147483647

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

### -BatteryCapacityGood
Number of devices whose battery maximum capacity is greater than 80%.
Valid values -2147483648 to 2147483647

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

### -BatteryCapacityPoor
Number of devices whose battery maximum capacity is lesser than 50%.
Valid values -2147483648 to 2147483647

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
The user experience analytics battery health capacity entity contains count of devices broken down into 3 categories - devices with capacity \> 80%, devices with capacity 50-80% and devices with capacity \< 50 %.This API provides the count of devices in these 3 categories..
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBatteryHealthCapacityDetails
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

### -LastRefreshedDateTime
Recorded date time of this capacity details instance.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBatteryHealthCapacityDetails

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsBatteryHealthCapacityDetails>: The user experience analytics battery health capacity entity contains count of devices broken down into 3 categories - devices with capacity > 80%, devices with capacity 50-80% and devices with capacity < 50 %.This API provides the count of devices in these 3 categories..
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ActiveDevices <Int32?>]`: Number of active devices within the tenant. Valid values -2147483648 to 2147483647
  - `[BatteryCapacityFair <Int32?>]`: Number of devices whose battery maximum capacity is greater than 50% but lesser than 80%. Valid values -2147483648 to 2147483647
  - `[BatteryCapacityGood <Int32?>]`: Number of devices whose battery maximum capacity is greater than 80%. Valid values -2147483648 to 2147483647
  - `[BatteryCapacityPoor <Int32?>]`: Number of devices whose battery maximum capacity is lesser than 50%. Valid values -2147483648 to 2147483647
  - `[LastRefreshedDateTime <DateTime?>]`: Recorded date time of this capacity details instance.

## RELATED LINKS

