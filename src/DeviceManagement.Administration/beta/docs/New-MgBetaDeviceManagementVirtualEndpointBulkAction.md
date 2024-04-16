---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.administration/new-mgbetadevicemanagementvirtualendpointbulkaction
schema: 2.0.0
---

# New-MgBetaDeviceManagementVirtualEndpointBulkAction

## SYNOPSIS
Create a new cloudPcBulkAction object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementVirtualEndpointBulkAction [-ActionSummary <IMicrosoftGraphCloudPcBulkActionSummary>]
 [-AdditionalProperties <Hashtable>] [-CloudPcIds <String[]>] [-CreatedDateTime <DateTime>]
 [-DisplayName <String>] [-Id <String>] [-ResponseHeadersVariable <String>]
 [-ScheduledDuringMaintenanceWindow] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementVirtualEndpointBulkAction -BodyParameter <IMicrosoftGraphCloudPcBulkAction>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new cloudPcBulkAction object.

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

### -ActionSummary
cloudPcBulkActionSummary
To construct, see NOTES section for ACTIONSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcBulkActionSummary
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
cloudPcBulkAction
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcBulkAction
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CloudPcIds
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time when the bulk action was created.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
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

### -DisplayName
Name of the bulk action.

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
Parameter Sets: CreateExpanded
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

### -ScheduledDuringMaintenanceWindow
Indicates whether the bulk actions can be initiated during maintenance window.
When true, bulk action will use maintenance window to schedule action, When false means bulk action will not use the maintenance window.
Default value is false.

```yaml
Type: System.Management.Automation.SwitchParameter
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcBulkAction

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcBulkAction

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACTIONSUMMARY <IMicrosoftGraphCloudPcBulkActionSummary>`: cloudPcBulkActionSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FailedCount <Int32?>]`: The number of Cloud PCs where the action failed.
  - `[InProgressCount <Int32?>]`: The number of Cloud PCs where the action is in progress.
  - `[NotSupportedCount <Int32?>]`: The number of Cloud PCs where the action isn't supported.
  - `[PendingCount <Int32?>]`: The number of Cloud PCs where the action is pending.
  - `[SuccessfulCount <Int32?>]`: The number of Cloud PCs where the action is successful.

`BODYPARAMETER <IMicrosoftGraphCloudPcBulkAction>`: cloudPcBulkAction
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActionSummary <IMicrosoftGraphCloudPcBulkActionSummary>]`: cloudPcBulkActionSummary
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[FailedCount <Int32?>]`: The number of Cloud PCs where the action failed.
    - `[InProgressCount <Int32?>]`: The number of Cloud PCs where the action is in progress.
    - `[NotSupportedCount <Int32?>]`: The number of Cloud PCs where the action isn't supported.
    - `[PendingCount <Int32?>]`: The number of Cloud PCs where the action is pending.
    - `[SuccessfulCount <Int32?>]`: The number of Cloud PCs where the action is successful.
  - `[CloudPcIds <String[]>]`: 
  - `[CreatedDateTime <DateTime?>]`: The date and time when the bulk action was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[DisplayName <String>]`: Name of the bulk action.
  - `[ScheduledDuringMaintenanceWindow <Boolean?>]`: Indicates whether the bulk actions can be initiated during maintenance window. When true, bulk action will use maintenance window to schedule action, When false means bulk action will not use the maintenance window. Default value is false.

## RELATED LINKS

