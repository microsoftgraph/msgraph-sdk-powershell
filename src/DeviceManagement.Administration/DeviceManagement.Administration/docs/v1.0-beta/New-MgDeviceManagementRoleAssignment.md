---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementroleassignment
schema: 2.0.0
---

# New-MgDeviceManagementRoleAssignment

## SYNOPSIS
Create new navigation property to roleAssignments for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementRoleAssignment [-AdditionalProperties <Hashtable>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-Members <String[]>] [-ResourceScopes <String[]>]
 [-RoleDefinition <IMicrosoftGraphRoleDefinition1>] [-RoleScopeTags <IMicrosoftGraphRoleScopeTag[]>]
 [-ScopeMembers <String[]>] [-ScopeType <RoleAssignmentScopeType>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementRoleAssignment -BodyParameter <IMicrosoftGraphDeviceAndAppManagementRoleAssignment>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to roleAssignments for deviceManagement

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
The Role Assignment resource.
Role assignments tie together a role definition with members and scopes.
There can be one or more role assignments per role.
This applies to custom and built-in roles.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAndAppManagementRoleAssignment
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Description of the Role Assignment.

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
The display or friendly name of the role Assignment.

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

### -Members
The list of ids of role member security groups.
These are IDs from Azure Active Directory.

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

### -ResourceScopes
List of ids of role scope member security groups.
These are IDs from Azure Active Directory.

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

### -RoleDefinition
The Role Definition resource.
The role definition is the foundation of role based access in Intune.
The role combines an Intune resource such as a Mobile App and associated role permissions such as Create or Read for the resource.
There are two types of roles, built-in and custom.
Built-in roles cannot be modified.
Both built-in roles and custom roles must have assignments to be enforced.
Create custom roles if you want to define a role that allows any of the available resources and role permissions to be combined into a single role.
To construct, please use Get-Help -Online and see NOTES section for ROLEDEFINITION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRoleDefinition1
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTags
The set of Role Scope Tags defined on the Role Assignment.
To construct, please use Get-Help -Online and see NOTES section for ROLESCOPETAGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRoleScopeTag[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScopeMembers
List of ids of role scope member security groups.
These are IDs from Azure Active Directory.

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

### -ScopeType
Specifies the type of scope for a Role Assignment.

```yaml
Type: Microsoft.Graph.PowerShell.Support.RoleAssignmentScopeType
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAndAppManagementRoleAssignment

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceAndAppManagementRoleAssignment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceAndAppManagementRoleAssignment>: The Role Assignment resource. Role assignments tie together a role definition with members and scopes. There can be one or more role assignments per role. This applies to custom and built-in roles.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description of the Role Assignment.
  - `[DisplayName <String>]`: The display or friendly name of the role Assignment.
  - `[ResourceScopes <String[]>]`: List of ids of role scope member security groups.  These are IDs from Azure Active Directory.
  - `[RoleDefinition <IMicrosoftGraphRoleDefinition1>]`: The Role Definition resource. The role definition is the foundation of role based access in Intune. The role combines an Intune resource such as a Mobile App and associated role permissions such as Create or Read for the resource. There are two types of roles, built-in and custom. Built-in roles cannot be modified. Both built-in roles and custom roles must have assignments to be enforced. Create custom roles if you want to define a role that allows any of the available resources and role permissions to be combined into a single role.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Description <String>]`: Description of the Role definition.
    - `[DisplayName <String>]`: Display Name of the Role definition.
    - `[IsBuiltIn <Boolean?>]`: Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.
    - `[IsBuiltInRoleDefinition <Boolean?>]`: Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.
    - `[Permissions <IMicrosoftGraphRolePermission1[]>]`: List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.
      - `[Actions <String[]>]`: Allowed Actions - Deprecated
      - `[ResourceActions <IMicrosoftGraphResourceAction[]>]`: Resource Actions each containing a set of allowed and not allowed permissions.
        - `[AllowedResourceActions <String[]>]`: Allowed Actions
        - `[NotAllowedResourceActions <String[]>]`: Not Allowed Actions.
    - `[RoleAssignments <IMicrosoftGraphRoleAssignment[]>]`: List of Role assignments for this role definition.
      - `[Id <String>]`: 
      - `[Description <String>]`: Description of the Role Assignment.
      - `[DisplayName <String>]`: The display or friendly name of the role Assignment.
      - `[ResourceScopes <String[]>]`: List of ids of role scope member security groups.  These are IDs from Azure Active Directory.
      - `[RoleDefinition <IMicrosoftGraphRoleDefinition1>]`: The Role Definition resource. The role definition is the foundation of role based access in Intune. The role combines an Intune resource such as a Mobile App and associated role permissions such as Create or Read for the resource. There are two types of roles, built-in and custom. Built-in roles cannot be modified. Both built-in roles and custom roles must have assignments to be enforced. Create custom roles if you want to define a role that allows any of the available resources and role permissions to be combined into a single role.
      - `[ScopeMembers <String[]>]`: List of ids of role scope member security groups.  These are IDs from Azure Active Directory.
      - `[ScopeType <RoleAssignmentScopeType?>]`: Specifies the type of scope for a Role Assignment.
    - `[RolePermissions <IMicrosoftGraphRolePermission1[]>]`: List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[ScopeMembers <String[]>]`: List of ids of role scope member security groups.  These are IDs from Azure Active Directory.
  - `[ScopeType <RoleAssignmentScopeType?>]`: Specifies the type of scope for a Role Assignment.
  - `[Id <String>]`: 
  - `[Members <String[]>]`: The list of ids of role member security groups. These are IDs from Azure Active Directory.
  - `[RoleScopeTags <IMicrosoftGraphRoleScopeTag[]>]`: The set of Role Scope Tags defined on the Role Assignment.
    - `[Id <String>]`: 
    - `[Assignments <IMicrosoftGraphRoleScopeTagAutoAssignment[]>]`: The list of assignments for this Role Scope Tag.
      - `[Id <String>]`: 
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
    - `[Description <String>]`: Description of the Role Scope Tag.
    - `[DisplayName <String>]`: The display or friendly name of the Role Scope Tag.
    - `[IsBuiltIn <Boolean?>]`: Description of the Role Scope Tag. This property is read-only.

ROLEDEFINITION <IMicrosoftGraphRoleDefinition1>: The Role Definition resource. The role definition is the foundation of role based access in Intune. The role combines an Intune resource such as a Mobile App and associated role permissions such as Create or Read for the resource. There are two types of roles, built-in and custom. Built-in roles cannot be modified. Both built-in roles and custom roles must have assignments to be enforced. Create custom roles if you want to define a role that allows any of the available resources and role permissions to be combined into a single role.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Description <String>]`: Description of the Role definition.
  - `[DisplayName <String>]`: Display Name of the Role definition.
  - `[IsBuiltIn <Boolean?>]`: Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.
  - `[IsBuiltInRoleDefinition <Boolean?>]`: Type of Role. Set to True if it is built-in, or set to False if it is a custom role definition.
  - `[Permissions <IMicrosoftGraphRolePermission1[]>]`: List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.
    - `[Actions <String[]>]`: Allowed Actions - Deprecated
    - `[ResourceActions <IMicrosoftGraphResourceAction[]>]`: Resource Actions each containing a set of allowed and not allowed permissions.
      - `[AllowedResourceActions <String[]>]`: Allowed Actions
      - `[NotAllowedResourceActions <String[]>]`: Not Allowed Actions.
  - `[RoleAssignments <IMicrosoftGraphRoleAssignment[]>]`: List of Role assignments for this role definition.
    - `[Id <String>]`: 
    - `[Description <String>]`: Description of the Role Assignment.
    - `[DisplayName <String>]`: The display or friendly name of the role Assignment.
    - `[ResourceScopes <String[]>]`: List of ids of role scope member security groups.  These are IDs from Azure Active Directory.
    - `[RoleDefinition <IMicrosoftGraphRoleDefinition1>]`: The Role Definition resource. The role definition is the foundation of role based access in Intune. The role combines an Intune resource such as a Mobile App and associated role permissions such as Create or Read for the resource. There are two types of roles, built-in and custom. Built-in roles cannot be modified. Both built-in roles and custom roles must have assignments to be enforced. Create custom roles if you want to define a role that allows any of the available resources and role permissions to be combined into a single role.
    - `[ScopeMembers <String[]>]`: List of ids of role scope member security groups.  These are IDs from Azure Active Directory.
    - `[ScopeType <RoleAssignmentScopeType?>]`: Specifies the type of scope for a Role Assignment.
  - `[RolePermissions <IMicrosoftGraphRolePermission1[]>]`: List of Role Permissions this role is allowed to perform. These must match the actionName that is defined as part of the rolePermission.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.

ROLESCOPETAGS <IMicrosoftGraphRoleScopeTag[]>: The set of Role Scope Tags defined on the Role Assignment.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphRoleScopeTagAutoAssignment[]>]`: The list of assignments for this Role Scope Tag.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[Description <String>]`: Description of the Role Scope Tag.
  - `[DisplayName <String>]`: The display or friendly name of the Role Scope Tag.
  - `[IsBuiltIn <Boolean?>]`: Description of the Role Scope Tag. This property is read-only.

## RELATED LINKS

