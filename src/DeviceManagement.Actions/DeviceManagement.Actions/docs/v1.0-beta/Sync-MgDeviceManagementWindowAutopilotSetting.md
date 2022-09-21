---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/sync-mgdevicemanagementwindowautopilotsetting
schema: 2.0.0
---

# Sync-MgDeviceManagementWindowAutopilotSetting

## SYNOPSIS
Initiates a sync of all AutoPilot registered devices from Store for Business and other portals.
If the sync successful, this action returns a 204 No Content response code.
If a sync is already in progress, the action returns a 409 Conflict response code.
If this sync action is called within 10 minutes of the previous sync, the action returns a 429 Too Many Requests response code.

## SYNTAX

```
Sync-MgDeviceManagementWindowAutopilotSetting [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Initiates a sync of all AutoPilot registered devices from Store for Business and other portals.
If the sync successful, this action returns a 204 No Content response code.
If a sync is already in progress, the action returns a 409 Conflict response code.
If this sync action is called within 10 minutes of the previous sync, the action returns a 429 Too Many Requests response code.

## EXAMPLES

## PARAMETERS

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

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

## RELATED LINKS

