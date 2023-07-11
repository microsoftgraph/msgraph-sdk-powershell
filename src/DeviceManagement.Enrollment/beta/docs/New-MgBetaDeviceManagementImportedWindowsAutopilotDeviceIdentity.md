---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Enrollment
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.enrollment/new-mgbetadevicemanagementimportedwindowsautopilotdeviceidentity
schema: 2.0.0
---

# New-MgBetaDeviceManagementImportedWindowsAutopilotDeviceIdentity

## SYNOPSIS
Create new navigation property to importedWindowsAutopilotDeviceIdentities for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementImportedWindowsAutopilotDeviceIdentity [-AdditionalProperties <Hashtable>]
 [-AssignedUserPrincipalName <String>] [-GroupTag <String>] [-HardwareIdentifierInputFile <String>]
 [-Id <String>] [-ImportId <String>] [-ProductKey <String>] [-SerialNumber <String>]
 [-State <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentityState>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementImportedWindowsAutopilotDeviceIdentity
 -BodyParameter <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to importedWindowsAutopilotDeviceIdentities for deviceManagement

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedUserPrincipalName
UPN of the user the device will be assigned

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
Imported windows autopilot devices.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -GroupTag
Group Tag of the Windows autopilot device.

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

### -HardwareIdentifierInputFile
Input File for HardwareIdentifier (Hardware Blob of the Windows autopilot device.)

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
The unique identifier for an entity.
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

### -ImportId
The Import Id of the Windows autopilot device.

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

### -ProductKey
Product Key of the Windows autopilot device.

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

### -SerialNumber
Serial number of the Windows autopilot device.

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

### -State
importedWindowsAutopilotDeviceIdentityState
To construct, see NOTES section for STATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphImportedWindowsAutopilotDeviceIdentityState
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity>`: Imported windows autopilot devices.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
    - `[DeviceImportStatus <ImportedWindowsAutopilotDeviceIdentityImportStatus?>]`: importedWindowsAutopilotDeviceIdentityImportStatus
    - `[DeviceRegistrationId <String>]`: Device Registration ID for successfully added device reported by Device Directory Service(DDS).

`STATE <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentityState>`: importedWindowsAutopilotDeviceIdentityState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceErrorCode <Int32?>]`: Device error code reported by Device Directory Service(DDS).
  - `[DeviceErrorName <String>]`: Device error name reported by Device Directory Service(DDS).
  - `[DeviceImportStatus <ImportedWindowsAutopilotDeviceIdentityImportStatus?>]`: importedWindowsAutopilotDeviceIdentityImportStatus
  - `[DeviceRegistrationId <String>]`: Device Registration ID for successfully added device reported by Device Directory Service(DDS).

## RELATED LINKS

