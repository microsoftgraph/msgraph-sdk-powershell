---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementvirtualendpointsnapshot
schema: 2.0.0
---

# New-MgDeviceManagementVirtualEndpointSnapshot

## SYNOPSIS
Create new navigation property to snapshots for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementVirtualEndpointSnapshot [-AdditionalProperties <Hashtable>] [-CloudPcId <String>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastRestoredDateTime <DateTime>] [-Status <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementVirtualEndpointSnapshot -BodyParameter <IMicrosoftGraphCloudPcSnapshot> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to snapshots for deviceManagement

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
cloudPcSnapshot
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcSnapshot
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CloudPcId
The unique identifier for the Cloud PC.

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

### -CreatedDateTime
The date and time at which the snapshot was taken.
The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC).
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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

### -LastRestoredDateTime
The date and time at which the snapshot was last used to restore the Cloud PC device.
The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC).
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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
cloudPcSnapshotStatus

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcSnapshot

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcSnapshot

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCloudPcSnapshot>: cloudPcSnapshot
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CloudPcId <String>]`: The unique identifier for the Cloud PC.
  - `[CreatedDateTime <DateTime?>]`: The date and time at which the snapshot was taken. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[LastRestoredDateTime <DateTime?>]`: The date and time at which the snapshot was last used to restore the Cloud PC device. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Status <String>]`: cloudPcSnapshotStatus

## RELATED LINKS

