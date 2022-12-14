---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devicemanagement.administration/new-mgdevicemanagementrolescopetag
schema: 2.0.0
---

# New-MgBetaDeviceManagementRoleScopeTag

## SYNOPSIS
Create new navigation property to roleScopeTags for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementRoleScopeTag [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphRoleScopeTagAutoAssignment[]>] [-Description <String>] [-DisplayName <String>]
 [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementRoleScopeTag -BodyParameter <IMicrosoftGraphRoleScopeTag> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to roleScopeTags for deviceManagement

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

### -Assignments
The list of assignments for this Role Scope Tag.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRoleScopeTagAutoAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Role Scope Tag
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRoleScopeTag
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Description of the Role Scope Tag.

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
The display or friendly name of the Role Scope Tag.

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
The unique idenfier for an entity.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRoleScopeTag

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRoleScopeTag

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphRoleScopeTagAutoAssignment[]>: The list of assignments for this Role Scope Tag.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

BODYPARAMETER <IMicrosoftGraphRoleScopeTag>: Role Scope Tag
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Assignments <IMicrosoftGraphRoleScopeTagAutoAssignment[]>]`: The list of assignments for this Role Scope Tag.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[Description <String>]`: Description of the Role Scope Tag.
  - `[DisplayName <String>]`: The display or friendly name of the Role Scope Tag.

## RELATED LINKS

