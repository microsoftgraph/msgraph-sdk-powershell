---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/import-mgdevicemanagementimportedwindowautopilotdeviceidentity
schema: 2.0.0
---

# Import-MgDeviceManagementImportedWindowAutopilotDeviceIdentity

## SYNOPSIS
Invoke action import

## SYNTAX

### ImportExpanded1 (Default)
```
Import-MgDeviceManagementImportedWindowAutopilotDeviceIdentity [-AdditionalProperties <Hashtable>]
 [-ImportedWindowsAutopilotDeviceIdentities <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Import1
```
Import-MgDeviceManagementImportedWindowAutopilotDeviceIdentity
 -BodyParameter <IPaths1Jc0WclDevicemanagementImportedwindowsautopilotdeviceidentitiesMicrosoftGraphImportPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action import

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ImportExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Jc0WclDevicemanagementImportedwindowsautopilotdeviceidentitiesMicrosoftGraphImportPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Import1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ImportedWindowsAutopilotDeviceIdentities
.
To construct, please use Get-Help -Online and see NOTES section for IMPORTEDWINDOWSAUTOPILOTDEVICEIDENTITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity[]
Parameter Sets: ImportExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPaths1Jc0WclDevicemanagementImportedwindowsautopilotdeviceidentitiesMicrosoftGraphImportPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Jc0WclDevicemanagementImportedwindowsautopilotdeviceidentitiesMicrosoftGraphImportPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ImportedWindowsAutopilotDeviceIdentities <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AssignedUserPrincipalName <String>]`: UPN of the user the device will be assigned
    - `[GroupTag <String>]`: Group Tag of the Windows autopilot device.
    - `[HardwareIdentifier <Byte[]>]`: Hardware Blob of the Windows autopilot device.
    - `[ImportId <String>]`: The Import Id of the Windows autopilot device.
    - `[ProductKey <String>]`: Product Key of the Windows autopilot device.
    - `[SerialNumber <String>]`: Serial number of the Windows autopilot device.
    - `[State <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentityState>]`: importedWindowsAutopilotDeviceIdentityState
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceErrorCode <Int32?>]`: Device error code reported by Device Directory Service(DDS).
      - `[DeviceErrorName <String>]`: Device error name reported by Device Directory Service(DDS).
      - `[DeviceImportStatus <String>]`: importedWindowsAutopilotDeviceIdentityImportStatus
      - `[DeviceRegistrationId <String>]`: Device Registration ID for successfully added device reported by Device Directory Service(DDS).

IMPORTEDWINDOWSAUTOPILOTDEVICEIDENTITIES <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity[]>: .
  - `[Id <String>]`: Read-only.
  - `[AssignedUserPrincipalName <String>]`: UPN of the user the device will be assigned
  - `[GroupTag <String>]`: Group Tag of the Windows autopilot device.
  - `[HardwareIdentifier <Byte[]>]`: Hardware Blob of the Windows autopilot device.
  - `[ImportId <String>]`: The Import Id of the Windows autopilot device.
  - `[ProductKey <String>]`: Product Key of the Windows autopilot device.
  - `[SerialNumber <String>]`: Serial number of the Windows autopilot device.
  - `[State <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentityState>]`: importedWindowsAutopilotDeviceIdentityState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceErrorCode <Int32?>]`: Device error code reported by Device Directory Service(DDS).
    - `[DeviceErrorName <String>]`: Device error name reported by Device Directory Service(DDS).
    - `[DeviceImportStatus <String>]`: importedWindowsAutopilotDeviceIdentityImportStatus
    - `[DeviceRegistrationId <String>]`: Device Registration ID for successfully added device reported by Device Directory Service(DDS).

## RELATED LINKS

