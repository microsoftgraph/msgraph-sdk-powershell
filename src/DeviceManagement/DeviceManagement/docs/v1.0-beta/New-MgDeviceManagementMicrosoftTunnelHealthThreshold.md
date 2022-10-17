---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementmicrosofttunnelhealththreshold
schema: 2.0.0
---

# New-MgDeviceManagementMicrosoftTunnelHealthThreshold

## SYNOPSIS
Create new navigation property to microsoftTunnelHealthThresholds for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementMicrosoftTunnelHealthThreshold [-AdditionalProperties <Hashtable>]
 [-DefaultHealthyThreshold <Int64>] [-DefaultUnhealthyThreshold <Int64>] [-HealthyThreshold <Int64>]
 [-Id <String>] [-UnhealthyThreshold <Int64>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementMicrosoftTunnelHealthThreshold
 -BodyParameter <IMicrosoftGraphMicrosoftTunnelHealthThreshold> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to microsoftTunnelHealthThresholds for deviceManagement

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

### -BodyParameter
Entity that represents the health thresholds of a health metric
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelHealthThreshold
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultHealthyThreshold
The threshold for being healthy based on default health status metrics: CPU usage healthy \< 50%, Memory usage healthy \< 50%, Disk space healthy \> 5GB, Latency healthy \< 10ms, health metrics can be customized.
Read-only.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultUnhealthyThreshold
The threshold for being unhealthy based on default health status metrics: CPU usage unhealthy \> 75%, Memory usage unhealthy \> 75%, Disk space \< 3GB, Latency unhealthy \> 20ms, health metrics can be customized.
Read-only.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HealthyThreshold
The threshold for being healthy based on default health status metrics: CPU usage healthy \< 50%, Memory usage healthy \< 50%, Disk space healthy \> 5GB, Latency healthy \< 10ms, health metrics can be customized.

```yaml
Type: System.Int64
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

### -UnhealthyThreshold
The threshold for being unhealthy based on default health status metrics: CPU usage unhealthy \> 75%, Memory usage unhealthy \> 75%, Disk space \< 3GB, Latency Unhealthy \> 20ms, health metrics can be customized.

```yaml
Type: System.Int64
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelHealthThreshold

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelHealthThreshold

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphMicrosoftTunnelHealthThreshold>: Entity that represents the health thresholds of a health metric
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DefaultHealthyThreshold <Int64?>]`: The threshold for being healthy based on default health status metrics: CPU usage healthy < 50%, Memory usage healthy < 50%, Disk space healthy > 5GB, Latency healthy < 10ms, health metrics can be customized. Read-only.
  - `[DefaultUnhealthyThreshold <Int64?>]`: The threshold for being unhealthy based on default health status metrics: CPU usage unhealthy > 75%, Memory usage unhealthy > 75%, Disk space < 3GB, Latency unhealthy > 20ms, health metrics can be customized. Read-only.
  - `[HealthyThreshold <Int64?>]`: The threshold for being healthy based on default health status metrics: CPU usage healthy < 50%, Memory usage healthy < 50%, Disk space healthy > 5GB, Latency healthy < 10ms, health metrics can be customized.
  - `[UnhealthyThreshold <Int64?>]`: The threshold for being unhealthy based on default health status metrics: CPU usage unhealthy > 75%, Memory usage unhealthy > 75%, Disk space < 3GB, Latency Unhealthy > 20ms, health metrics can be customized.

## RELATED LINKS

