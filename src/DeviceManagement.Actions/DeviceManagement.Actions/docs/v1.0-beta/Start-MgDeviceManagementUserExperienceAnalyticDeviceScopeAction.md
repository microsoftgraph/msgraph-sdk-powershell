---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devicemanagement.actions/start-mgdevicemanagementuserexperienceanalyticdevicescopeaction
schema: 2.0.0
---

# Start-MgBetaDeviceManagementUserExperienceAnalyticDeviceScopeAction

## SYNOPSIS
Invoke action triggerDeviceScopeAction

## SYNTAX

### TriggerExpanded (Default)
```
Start-MgBetaDeviceManagementUserExperienceAnalyticDeviceScopeAction [-ActionName <String>]
 [-AdditionalProperties <Hashtable>] [-DeviceScopeId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Trigger
```
Start-MgBetaDeviceManagementUserExperienceAnalyticDeviceScopeAction
 -BodyParameter <IPathsNcwx4CDevicemanagementUserexperienceanalyticsdevicescopeMicrosoftGraphTriggerdevicescopeactionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action triggerDeviceScopeAction

## EXAMPLES

## PARAMETERS

### -ActionName
Trigger on the service to either START or STOP computing metrics data based on a device scope configuration.

```yaml
Type: System.String
Parameter Sets: TriggerExpanded
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
Parameter Sets: TriggerExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsNcwx4CDevicemanagementUserexperienceanalyticsdevicescopeMicrosoftGraphTriggerdevicescopeactionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Trigger
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceScopeId
.

```yaml
Type: System.String
Parameter Sets: TriggerExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsNcwx4CDevicemanagementUserexperienceanalyticsdevicescopeMicrosoftGraphTriggerdevicescopeactionPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceScopeActionResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsNcwx4CDevicemanagementUserexperienceanalyticsdevicescopeMicrosoftGraphTriggerdevicescopeactionPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ActionName <String>]`: Trigger on the service to either START or STOP computing metrics data based on a device scope configuration.
  - `[DeviceScopeId <String>]`: 

## RELATED LINKS

