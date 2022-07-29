---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgttask
schema: 2.0.0
---

# New-MgDeviceAppMgtTask

## SYNOPSIS
Create new navigation property to deviceAppManagementTasks for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppMgtTask [-AdditionalProperties <Hashtable>] [-AssignedTo <String>]
 [-Category <DeviceAppManagementTaskCategory>] [-CreatedDateTime <DateTime>] [-Creator <String>]
 [-CreatorNotes <String>] [-Description <String>] [-DisplayName <String>] [-DueDateTime <DateTime>]
 [-Id <String>] [-Priority <DeviceAppManagementTaskPriority>] [-Status <DeviceAppManagementTaskStatus>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtTask -BodyParameter <IMicrosoftGraphDeviceAppManagementTask> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceAppManagementTasks for deviceAppManagement

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

### -AssignedTo
The name or email of the admin this task is assigned to.

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
A device app management task.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAppManagementTask
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
Device app management task category.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceAppManagementTaskCategory
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The created date.

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

### -Creator
The email address of the creator.

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

### -CreatorNotes
Notes from the creator.

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

### -Description
The description.

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

### -DisplayName
The name.

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

### -DueDateTime
The due date.

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

### -Priority
Device app management task priority.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceAppManagementTaskPriority
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
Device app management task status.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceAppManagementTaskStatus
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAppManagementTask

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAppManagementTask

## NOTES

ALIASES

### New-MgDeviceAppManagementTask

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceAppManagementTask>: A device app management task.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AssignedTo <String>]`: The name or email of the admin this task is assigned to.
  - `[Category <DeviceAppManagementTaskCategory?>]`: Device app management task category.
  - `[CreatedDateTime <DateTime?>]`: The created date.
  - `[Creator <String>]`: The email address of the creator.
  - `[CreatorNotes <String>]`: Notes from the creator.
  - `[Description <String>]`: The description.
  - `[DisplayName <String>]`: The name.
  - `[DueDateTime <DateTime?>]`: The due date.
  - `[Priority <DeviceAppManagementTaskPriority?>]`: Device app management task priority.
  - `[Status <DeviceAppManagementTaskStatus?>]`: Device app management task status.

## RELATED LINKS

