---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtwindowinformationprotectiondeviceregistration
schema: 2.0.0
---

# New-MgDeviceAppMgtWindowInformationProtectionDeviceRegistration

## SYNOPSIS
Create new navigation property to windowsInformationProtectionDeviceRegistrations for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppMgtWindowInformationProtectionDeviceRegistration [-AdditionalProperties <Hashtable>]
 [-DeviceMacAddress <String>] [-DeviceName <String>] [-DeviceRegistrationId <String>] [-DeviceType <String>]
 [-Id <String>] [-LastCheckInDateTime <DateTime>] [-UserId <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtWindowInformationProtectionDeviceRegistration
 -BodyParameter <IMicrosoftGraphWindowsInformationProtectionDeviceRegistration> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to windowsInformationProtectionDeviceRegistrations for deviceAppManagement

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents device registration records for Bring-Your-Own-Device(BYOD) Windows devices.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphWindowsInformationProtectionDeviceRegistration
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceMacAddress
Device Mac address.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceName
Device name.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceRegistrationId
Device identifier for this device registration record.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceType
Device type, for example, Windows laptop VS Windows phone.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastCheckInDateTime
Last checkin time of the device.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
UserId associated with this device registration record.

```yaml
Type: String
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionDeviceRegistration
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionDeviceRegistration
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphWindowsInformationProtectionDeviceRegistration\>: Represents device registration records for Bring-Your-Own-Device(BYOD) Windows devices.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[DeviceMacAddress \<String\>\]: Device Mac address.
  \[DeviceName \<String\>\]: Device name.
  \[DeviceRegistrationId \<String\>\]: Device identifier for this device registration record.
  \[DeviceType \<String\>\]: Device type, for example, Windows laptop VS Windows phone.
  \[LastCheckInDateTime \<DateTime?\>\]: Last checkin time of the device.
  \[UserId \<String\>\]: UserId associated with this device registration record.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtwindowinformationprotectiondeviceregistration](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtwindowinformationprotectiondeviceregistration)

