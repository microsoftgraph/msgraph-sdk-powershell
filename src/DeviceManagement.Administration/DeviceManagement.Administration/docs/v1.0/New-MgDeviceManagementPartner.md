---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementpartner
schema: 2.0.0
---

# New-MgDeviceManagementPartner

## SYNOPSIS
Create new navigation property to deviceManagementPartners for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementPartner [-AdditionalProperties <Hashtable>] [-DisplayName <String>] [-Id <String>]
 [-IsConfigured] [-LastHeartbeatDateTime <DateTime>] [-PartnerAppType <DeviceManagementPartnerAppType>]
 [-PartnerState <DeviceManagementPartnerTenantState>] [-SingleTenantAppId <String>]
 [-WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime <DateTime>]
 [-WhenPartnerDevicesWillBeRemovedDateTime <DateTime>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementPartner -BodyParameter <IMicrosoftGraphDeviceManagementPartner1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceManagementPartners for deviceManagement

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
Entity which represents a connection to device management partner.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementPartner1
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
Partner display name

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

### -IsConfigured
Whether device management partner is configured or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastHeartbeatDateTime
Timestamp of last heartbeat after admin enabled option Connect to Device management Partner

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

### -PartnerAppType
Partner App Type.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementPartnerAppType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PartnerState
Partner state of this tenant.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementPartnerTenantState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SingleTenantAppId
Partner Single tenant App id

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

### -WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime
DateTime in UTC when PartnerDevices will be marked as NonCompliant

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

### -WhenPartnerDevicesWillBeRemovedDateTime
DateTime in UTC when PartnerDevices will be removed

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementPartner1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementPartner1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementPartner1>: Entity which represents a connection to device management partner.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: Partner display name
  - `[IsConfigured <Boolean?>]`: Whether device management partner is configured or not
  - `[LastHeartbeatDateTime <DateTime?>]`: Timestamp of last heartbeat after admin enabled option Connect to Device management Partner
  - `[PartnerAppType <DeviceManagementPartnerAppType?>]`: Partner App Type.
  - `[PartnerState <DeviceManagementPartnerTenantState?>]`: Partner state of this tenant.
  - `[SingleTenantAppId <String>]`: Partner Single tenant App id
  - `[WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime <DateTime?>]`: DateTime in UTC when PartnerDevices will be marked as NonCompliant
  - `[WhenPartnerDevicesWillBeRemovedDateTime <DateTime?>]`: DateTime in UTC when PartnerDevices will be removed

## RELATED LINKS

