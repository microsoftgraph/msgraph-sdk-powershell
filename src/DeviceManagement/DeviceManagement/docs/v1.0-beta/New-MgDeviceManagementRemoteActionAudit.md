---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementremoteactionaudit
schema: 2.0.0
---

# New-MgDeviceManagementRemoteActionAudit

## SYNOPSIS
Create new navigation property to remoteActionAudits for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementRemoteActionAudit [-Action <RemoteAction>] [-ActionState <String>]
 [-AdditionalProperties <Hashtable>] [-DeviceDisplayName <String>] [-DeviceImei <String>]
 [-DeviceOwnerUserPrincipalName <String>] [-Id <String>] [-InitiatedByUserPrincipalName <String>]
 [-ManagedDeviceId <String>] [-RequestDateTime <DateTime>] [-UserName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementRemoteActionAudit -BodyParameter <IMicrosoftGraphRemoteActionAudit> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to remoteActionAudits for deviceManagement

## EXAMPLES

## PARAMETERS

### -Action
Remote actions Intune supports.

```yaml
Type: Microsoft.Graph.PowerShell.Support.RemoteAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActionState
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
Report of remote actions initiated on the devices belonging to a certain tenant.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRemoteActionAudit
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceDisplayName
Intune device name.

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

### -DeviceImei
IMEI of the device.

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

### -DeviceOwnerUserPrincipalName
Upn of the device owner.

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

### -InitiatedByUserPrincipalName
User who initiated the device action, format is UPN.

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

### -ManagedDeviceId
Action target.

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

### -RequestDateTime
Time when the action was issued, given in UTC.

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

### -UserName
[deprecated] Please use InitiatedByUserPrincipalName instead.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRemoteActionAudit

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRemoteActionAudit

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphRemoteActionAudit>: Report of remote actions initiated on the devices belonging to a certain tenant.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Action <RemoteAction?>]`: Remote actions Intune supports.
  - `[ActionState <String>]`: actionState
  - `[DeviceDisplayName <String>]`: Intune device name.
  - `[DeviceImei <String>]`: IMEI of the device.
  - `[DeviceOwnerUserPrincipalName <String>]`: Upn of the device owner.
  - `[InitiatedByUserPrincipalName <String>]`: User who initiated the device action, format is UPN.
  - `[ManagedDeviceId <String>]`: Action target.
  - `[RequestDateTime <DateTime?>]`: Time when the action was issued, given in UTC.
  - `[UserName <String>]`: [deprecated] Please use InitiatedByUserPrincipalName instead.

## RELATED LINKS

