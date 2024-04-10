---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Enrollment
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.enrollment/update-mgbetadevicemanagementwindowsautopilotsetting
schema: 2.0.0
---

# Update-MgBetaDeviceManagementWindowsAutopilotSetting

## SYNOPSIS
Update the navigation property windowsAutopilotSettings in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementWindowsAutopilotSetting [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-LastManualSyncTriggerDateTime <DateTime>] [-LastSyncDateTime <DateTime>]
 [-ResponseHeadersVariable <String>] [-SyncStatus <WindowsAutopilotSyncStatus>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementWindowsAutopilotSetting -BodyParameter <IMicrosoftGraphWindowsAutopilotSettings>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property windowsAutopilotSettings in deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

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

### -BodyParameter
The windowsAutopilotSettings resource represents a Windows Autopilot Account to sync data with Windows device data sync service.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsAutopilotSettings
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

### -LastManualSyncTriggerDateTime
Last data sync date time with DDS service.

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

### -LastSyncDateTime
Last data sync date time with DDS service.

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

### -SyncStatus
windowsAutopilotSyncStatus

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.WindowsAutopilotSyncStatus
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsAutopilotSettings

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsAutopilotSettings

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphWindowsAutopilotSettings>`: The windowsAutopilotSettings resource represents a Windows Autopilot Account to sync data with Windows device data sync service.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[LastManualSyncTriggerDateTime <DateTime?>]`: Last data sync date time with DDS service.
  - `[LastSyncDateTime <DateTime?>]`: Last data sync date time with DDS service.
  - `[SyncStatus <WindowsAutopilotSyncStatus?>]`: windowsAutopilotSyncStatus

## RELATED LINKS

