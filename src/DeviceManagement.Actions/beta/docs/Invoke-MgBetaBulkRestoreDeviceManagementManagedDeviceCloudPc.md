---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.actions/invoke-mgbetabulkrestoredevicemanagementmanageddevicecloudpc
schema: 2.0.0
---

# Invoke-MgBetaBulkRestoreDeviceManagementManagedDeviceCloudPc

## SYNOPSIS
Restore multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices and a restore point date and time.

## SYNTAX

### BulkExpanded (Default)
```
Invoke-MgBetaBulkRestoreDeviceManagementManagedDeviceCloudPc [-AdditionalProperties <Hashtable>]
 [-ManagedDeviceIds <String[]>] [-RestorePointDateTime <DateTime>] [-TimeRange <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Bulk
```
Invoke-MgBetaBulkRestoreDeviceManagementManagedDeviceCloudPc
 -BodyParameter <IPaths2F9570DevicemanagementManageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Restore multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices and a restore point date and time.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions
$params = @{
	ManagedDeviceIds = @(
		"30d0e128-de93-41dc-89ec-33d84bb662a0"
		"7c82a3e3-9459-44e4-94d9-b92f93bf78dd"
	)
	RestorePointDateTime = [System.DateTime]::Parse("2021-09-23T04:00:00.0000000")
	TimeRange = "before"
}
Invoke-MgBetaBulkRestoreDeviceManagementManagedDeviceCloudPc -BodyParameter $params
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: BulkExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths2F9570DevicemanagementManageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Bulk
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagedDeviceIds
.

```yaml
Type: System.String[]
Parameter Sets: BulkExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestorePointDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: BulkExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeRange
restoreTimeRange

```yaml
Type: System.String
Parameter Sets: BulkExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths2F9570DevicemanagementManageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcBulkRemoteActionResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths2F9570DevicemanagementManageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ManagedDeviceIds <String[]>]`: 
  - `[RestorePointDateTime <DateTime?>]`: 
  - `[TimeRange <String>]`: restoreTimeRange

## RELATED LINKS

