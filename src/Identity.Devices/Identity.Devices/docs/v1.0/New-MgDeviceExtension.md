---
external help file:
Module Name: Microsoft.Graph.Identity.Devices
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.devices/new-mgdeviceextension
schema: 2.0.0
---

# New-MgDeviceExtension

## SYNOPSIS
Create new navigation property to extensions for devices

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceExtension -DeviceId <String> [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgDeviceExtension -DeviceId <String> -BodyParameter <IMicrosoftGraphExtension> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgDeviceExtension -InputObject <IIdentityDevicesIdentity> -BodyParameter <IMicrosoftGraphExtension>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgDeviceExtension -InputObject <IIdentityDevicesIdentity> [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to extensions for devices

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
extension
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceId
key: device-id of device

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityDevicesIdentity
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.IIdentityDevicesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphExtension>: extension
  - `[Id <String>]`: Read-only.

INPUTOBJECT <IIdentityDevicesIdentity>: Identity Parameter
  - `[CommandId <String>]`: key: command-id of command
  - `[DeviceId <String>]`: key: device-id of device
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[ExtensionId <String>]`: key: extension-id of extension

## RELATED LINKS

