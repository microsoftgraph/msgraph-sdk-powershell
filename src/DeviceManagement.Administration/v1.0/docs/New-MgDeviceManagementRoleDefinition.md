---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementroledefinition
schema: 2.0.0
---

# New-MgDeviceManagementRoleDefinition

## SYNOPSIS
Create a new deviceAndAppManagementRoleDefinition object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementRoleDefinition [-AdditionalProperties <Hashtable>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IsBuiltIn] [-ResponseHeadersVariable <String>]
 [-RoleAssignments <IMicrosoftGraphRoleAssignment[]>] [-RolePermissions <IMicrosoftGraphRolePermission[]>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementRoleDefinition -BodyParameter <IMicrosoftGraphRoleDefinition>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new deviceAndAppManagementRoleDefinition object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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
The Role Definition resource.
The role definition is the foundation of role based access in Intune.
The role combines an Intune resource such as a Mobile App and associated role permissions such as Create or Read for the resource.
There are two types of roles, built-in and custom.
Built-in roles cannot be modified.
Both built-in roles and custom roles must have assignments to be enforced.
Create custom roles if you want to define a role that allows any of the available resources and role permissions to be combined into a single role.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRoleDefinition
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Description of the Role definition.

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
Display Name of the Role definition.

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

### -IsBuiltIn
Type of Role.
Set to True if it is built-in, or set to False if it is a custom role definition.

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

### -RoleAssignments
List of Role assignments for this role definition.
To construct, see NOTES section for ROLEASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRoleAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RolePermissions
List of Role Permissions this role is allowed to perform.
These must match the actionName that is defined as part of the rolePermission.
To construct, see NOTES section for ROLEPERMISSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRolePermission[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRoleDefinition

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRoleDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphRoleDefinition>`: The Role Definition resource. The role definition is the foundation of role based access in Intune. The role combines an Intune resource such as a Mobile App and associated role permissions such as Create or Read for the resource. There are two types of roles, built-in and custom. Built-in roles cannot be modified. Both built-in roles and custom roles must have assignments to be enforced. Create custom roles if you want to define a role that allows any of the available resources and role permissions to be combined into a single role.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: Description of the Role definition.
  - `[DisplayName <String>]`: Display Name of the Role definition.
  - `[IsBuiltIn <Boolean?>]`: Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.
  - `[RoleAssignments <IMicrosoftGraphRoleAssignment[]>]`: List of Role assignments for this role definition.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: Description of the Role Assignment.
    - `[DisplayName <String>]`: The display or friendly name of the role Assignment.
    - `[ResourceScopes <String[]>]`: List of ids of role scope member security groups.  These are IDs from Azure Active Directory.
    - `[RoleDefinition <IMicrosoftGraphRoleDefinition>]`: The Role Definition resource. The role definition is the foundation of role based access in Intune. The role combines an Intune resource such as a Mobile App and associated role permissions such as Create or Read for the resource. There are two types of roles, built-in and custom. Built-in roles cannot be modified. Both built-in roles and custom roles must have assignments to be enforced. Create custom roles if you want to define a role that allows any of the available resources and role permissions to be combined into a single role.
  - `[RolePermissions <IMicrosoftGraphRolePermission[]>]`: List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.
    - `[ResourceActions <IMicrosoftGraphResourceAction[]>]`: Resource Actions each containing a set of allowed and not allowed permissions.
      - `[AllowedResourceActions <String[]>]`: Allowed Actions
      - `[NotAllowedResourceActions <String[]>]`: Not Allowed Actions.

`ROLEASSIGNMENTS <IMicrosoftGraphRoleAssignment[]>`: List of Role assignments for this role definition.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: Description of the Role Assignment.
  - `[DisplayName <String>]`: The display or friendly name of the role Assignment.
  - `[ResourceScopes <String[]>]`: List of ids of role scope member security groups.  These are IDs from Azure Active Directory.
  - `[RoleDefinition <IMicrosoftGraphRoleDefinition>]`: The Role Definition resource. The role definition is the foundation of role based access in Intune. The role combines an Intune resource such as a Mobile App and associated role permissions such as Create or Read for the resource. There are two types of roles, built-in and custom. Built-in roles cannot be modified. Both built-in roles and custom roles must have assignments to be enforced. Create custom roles if you want to define a role that allows any of the available resources and role permissions to be combined into a single role.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: Description of the Role definition.
    - `[DisplayName <String>]`: Display Name of the Role definition.
    - `[IsBuiltIn <Boolean?>]`: Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.
    - `[RoleAssignments <IMicrosoftGraphRoleAssignment[]>]`: List of Role assignments for this role definition.
    - `[RolePermissions <IMicrosoftGraphRolePermission[]>]`: List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.
      - `[ResourceActions <IMicrosoftGraphResourceAction[]>]`: Resource Actions each containing a set of allowed and not allowed permissions.
        - `[AllowedResourceActions <String[]>]`: Allowed Actions
        - `[NotAllowedResourceActions <String[]>]`: Not Allowed Actions.

`ROLEPERMISSIONS <IMicrosoftGraphRolePermission[]>`: List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.
  - `[ResourceActions <IMicrosoftGraphResourceAction[]>]`: Resource Actions each containing a set of allowed and not allowed permissions.
    - `[AllowedResourceActions <String[]>]`: Allowed Actions
    - `[NotAllowedResourceActions <String[]>]`: Not Allowed Actions.

## RELATED LINKS

