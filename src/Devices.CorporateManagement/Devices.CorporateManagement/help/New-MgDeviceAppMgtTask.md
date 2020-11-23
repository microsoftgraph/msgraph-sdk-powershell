---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
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
New-MgDeviceAppMgtTask [-AdditionalProperties <Hashtable>] [-AssignedTo <String>] [-Category <String>]
 [-CreatedDateTime <DateTime>] [-Creator <String>] [-CreatorNotes <String>] [-Description <String>]
 [-DisplayName <String>] [-DueDateTime <DateTime>] [-Id <String>] [-Priority <String>] [-Status <String>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtTask -BodyParameter <IMicrosoftGraphDeviceAppManagementTask> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceAppManagementTasks for deviceAppManagement

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

### -AssignedTo
The name or email of the admin this task is assigned to.

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

### -BodyParameter
A device app management task.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceAppManagementTask
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
deviceAppManagementTaskCategory

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

### -CreatedDateTime
The created date.

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

### -Creator
The email address of the creator.

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

### -CreatorNotes
Notes from the creator.

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

### -Description
The description.

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

### -DisplayName
The name.

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

### -DueDateTime
The due date.

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

### -Priority
deviceAppManagementTaskPriority

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

### -Status
deviceAppManagementTaskStatus

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAppManagementTask
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAppManagementTask
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphDeviceAppManagementTask\>: A device app management task.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AssignedTo \<String\>\]: The name or email of the admin this task is assigned to.
  \[Category \<String\>\]: deviceAppManagementTaskCategory
  \[CreatedDateTime \<DateTime?\>\]: The created date.
  \[Creator \<String\>\]: The email address of the creator.
  \[CreatorNotes \<String\>\]: Notes from the creator.
  \[Description \<String\>\]: The description.
  \[DisplayName \<String\>\]: The name.
  \[DueDateTime \<DateTime?\>\]: The due date.
  \[Priority \<String\>\]: deviceAppManagementTaskPriority
  \[Status \<String\>\]: deviceAppManagementTaskStatus

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgttask](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgttask)

