---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/get-mgdevicemanagementdeviceconfigurationtargeteduseranddevice
schema: 2.0.0
---

# Get-MgDeviceManagementDeviceConfigurationTargetedUserAndDevice

## SYNOPSIS
Invoke action getTargetedUsersAndDevices

## SYNTAX

### GetExpanded (Default)
```
Get-MgDeviceManagementDeviceConfigurationTargetedUserAndDevice [-AdditionalProperties <Hashtable>]
 [-DeviceConfigurationIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-MgDeviceManagementDeviceConfigurationTargetedUserAndDevice
 -BodyParameter <IPaths1G57514DevicemanagementDeviceconfigurationsMicrosoftGraphGettargetedusersanddevicesPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action getTargetedUsersAndDevices

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1G57514DevicemanagementDeviceconfigurationsMicrosoftGraphGettargetedusersanddevicesPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceConfigurationIds
.

```yaml
Type: System.String[]
Parameter Sets: GetExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1G57514DevicemanagementDeviceconfigurationsMicrosoftGraphGettargetedusersanddevicesPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationTargetedUserAndDevice

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1G57514DevicemanagementDeviceconfigurationsMicrosoftGraphGettargetedusersanddevicesPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceConfigurationIds <String[]>]`: 

## RELATED LINKS

