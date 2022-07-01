---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtwindowinformationprotectionwipeaction
schema: 2.0.0
---

# New-MgDeviceAppMgtWindowInformationProtectionWipeAction

## SYNOPSIS
Create new navigation property to windowsInformationProtectionWipeActions for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppMgtWindowInformationProtectionWipeAction [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-LastCheckInDateTime <DateTime>] [-Status <String>] [-TargetedDeviceMacAddress <String>]
 [-TargetedDeviceName <String>] [-TargetedDeviceRegistrationId <String>] [-TargetedUserId <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtWindowInformationProtectionWipeAction
 -BodyParameter <IMicrosoftGraphWindowsInformationProtectionWipeAction> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to windowsInformationProtectionWipeActions for deviceAppManagement

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
Represents wipe requests issued by tenant admin for Bring-Your-Own-Device(BYOD) Windows devices.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionWipeAction
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -LastCheckInDateTime
Last checkin time of the device that was targeted by this wipe action.

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

### -Status
actionState

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

### -TargetedDeviceMacAddress
Targeted device Mac address.

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

### -TargetedDeviceName
Targeted device name.

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

### -TargetedDeviceRegistrationId
The DeviceRegistrationId being targeted by this wipe action.

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

### -TargetedUserId
The UserId being targeted by this wipe action.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionWipeAction

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionWipeAction

## NOTES

ALIASES

### New-MgDeviceAppManagementWindowInformationProtectionWipeAction

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphWindowsInformationProtectionWipeAction>: Represents wipe requests issued by tenant admin for Bring-Your-Own-Device(BYOD) Windows devices.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[LastCheckInDateTime <DateTime?>]`: Last checkin time of the device that was targeted by this wipe action.
  - `[Status <String>]`: actionState
  - `[TargetedDeviceMacAddress <String>]`: Targeted device Mac address.
  - `[TargetedDeviceName <String>]`: Targeted device name.
  - `[TargetedDeviceRegistrationId <String>]`: The DeviceRegistrationId being targeted by this wipe action.
  - `[TargetedUserId <String>]`: The UserId being targeted by this wipe action.

## RELATED LINKS

