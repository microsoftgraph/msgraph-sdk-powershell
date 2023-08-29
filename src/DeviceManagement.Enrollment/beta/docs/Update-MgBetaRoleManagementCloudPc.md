---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Enrollment
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.enrollment/update-mgbetarolemanagementcloudpc
schema: 2.0.0
---

# Update-MgBetaRoleManagementCloudPc

## SYNOPSIS
Update the navigation property cloudPC in roleManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaRoleManagementCloudPc [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]
 [-RoleAssignments <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>]
 [-RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaRoleManagementCloudPc -BodyParameter <IMicrosoftGraphRbacApplicationMultiple> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property cloudPC in roleManagement

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

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
rbacApplicationMultiple
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRbacApplicationMultiple
Parameter Sets: Update
Aliases:

Required: True
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceNamespaces
.
To construct, see NOTES section for RESOURCENAMESPACES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRbacResourceNamespace[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleAssignments
.
To construct, see NOTES section for ROLEASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleAssignmentMultiple[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleDefinitions
.
To construct, see NOTES section for ROLEDEFINITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleDefinition[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRbacApplicationMultiple

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRbacApplicationMultiple

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphRbacApplicationMultiple>`: rbacApplicationMultiple
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Name <String>]`: Name of the resource namespace. Typically, the same name as the id property, such as microsoft.aad.b2c. Required. Supports $filter (eq, startsWith).
    - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: Operations that an authorized principal are allowed to perform.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ActionVerb <String>]`: HTTP method for the action, such as DELETE, GET, PATCH, POST, PUT, or null. Supports $filter (eq) but not for null values.
      - `[AuthenticationContext <IMicrosoftGraphAuthenticationContextClassReference>]`: authenticationContextClassReference
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Description <String>]`: A short explanation of the policies that are enforced by authenticationContextClassReference. This value should be used to provide secondary text to describe the authentication context class reference when building user facing admin experiences. For example, selection UX.
        - `[DisplayName <String>]`: A friendly name that identifies the authenticationContextClassReference object when building user-facing admin experiences. For example, a selection UX.
        - `[IsAvailable <Boolean?>]`: Indicates whether the authenticationContextClassReference has been published by the security admin and is ready for use by apps. When it is set to false, it should not be shown in selection UX used to tag resources with authentication context class values. It will still be shown in the Conditionall Access policy authoring experience.  Supports $filter (eq).
      - `[AuthenticationContextId <String>]`: 
      - `[Description <String>]`: Description for the action. Supports $filter (eq).
      - `[IsAuthenticationContextSettable <Boolean?>]`: 
      - `[IsPrivileged <Boolean?>]`: 
      - `[Name <String>]`: Name for the action within the resource namespace, such as microsoft.insights/programs/update. Can include slash character (/). Case insensitive. Required. Supports $filter (eq).
      - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[DisplayName <String>]`: 
        - `[Scope <String>]`: 
        - `[Type <String>]`: 
      - `[ResourceScopeId <String>]`: Not implemented.
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AppScopeIds <String[]>]`: Ids of the app specific scopes when the assignment scopes are app specific. The scopes of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[AppScopes <IMicrosoftGraphAppScope[]>]`: Read-only collection with details of the app specific scopes when the assignment scopes are app specific. Containment entity. Read-only.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. This property is read only.
      - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. This property is read only.
    - `[Condition <String>]`: 
    - `[Description <String>]`: Description of the role assignment.
    - `[DirectoryScopeIds <String[]>]`: Ids of the directory objects representing the scopes of the assignment. The scopes of an assignment determine the set of resources for which the principals have been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScopes <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the directory objects that are scope of the assignment. Provided so that callers can get the directory objects using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[DisplayName <String>]`: Name of the role assignment. Required.
    - `[PrincipalIds <String[]>]`: Identifiers of the principals to which the assignment is granted.  Supports $filter (any operator only).
    - `[Principals <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the assigned principals. Provided so that callers can get the principals using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AllowedPrincipalTypes <String>]`: allowedRolePrincipalTypes
      - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
      - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq and startsWith).
      - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles support this attribute.
      - `[IsBuiltIn <Boolean?>]`: Flag indicating if the unifiedRoleDefinition is part of the default set included with the product or custom. Read-only.  Supports $filter (eq).
      - `[IsEnabled <Boolean?>]`: Flag indicating if the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
      - `[IsPrivileged <Boolean?>]`: 
      - `[ResourceScopes <String[]>]`: List of scopes permissions granted by the role definition apply to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This will be deprecated soon. Attach scope to role assignment.
      - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
        - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
        - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective. Not supported for custom roles.
        - `[ExcludedResourceActions <String[]>]`: 
      - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false. This identifier is typically used if one needs an identifier to be the same across different directories. Read-only when isBuiltIn is true.
      - `[Version <String>]`: Indicates the version of the unifiedRoleDefinition object. Read-only when isBuiltIn is true.
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for.
  - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: 

`RESOURCENAMESPACES <IMicrosoftGraphUnifiedRbacResourceNamespace[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Name <String>]`: Name of the resource namespace. Typically, the same name as the id property, such as microsoft.aad.b2c. Required. Supports $filter (eq, startsWith).
  - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: Operations that an authorized principal are allowed to perform.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ActionVerb <String>]`: HTTP method for the action, such as DELETE, GET, PATCH, POST, PUT, or null. Supports $filter (eq) but not for null values.
    - `[AuthenticationContext <IMicrosoftGraphAuthenticationContextClassReference>]`: authenticationContextClassReference
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Description <String>]`: A short explanation of the policies that are enforced by authenticationContextClassReference. This value should be used to provide secondary text to describe the authentication context class reference when building user facing admin experiences. For example, selection UX.
      - `[DisplayName <String>]`: A friendly name that identifies the authenticationContextClassReference object when building user-facing admin experiences. For example, a selection UX.
      - `[IsAvailable <Boolean?>]`: Indicates whether the authenticationContextClassReference has been published by the security admin and is ready for use by apps. When it is set to false, it should not be shown in selection UX used to tag resources with authentication context class values. It will still be shown in the Conditionall Access policy authoring experience.  Supports $filter (eq).
    - `[AuthenticationContextId <String>]`: 
    - `[Description <String>]`: Description for the action. Supports $filter (eq).
    - `[IsAuthenticationContextSettable <Boolean?>]`: 
    - `[IsPrivileged <Boolean?>]`: 
    - `[Name <String>]`: Name for the action within the resource namespace, such as microsoft.insights/programs/update. Can include slash character (/). Case insensitive. Required. Supports $filter (eq).
    - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DisplayName <String>]`: 
      - `[Scope <String>]`: 
      - `[Type <String>]`: 
    - `[ResourceScopeId <String>]`: Not implemented.

`ROLEASSIGNMENTS <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppScopeIds <String[]>]`: Ids of the app specific scopes when the assignment scopes are app specific. The scopes of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
  - `[AppScopes <IMicrosoftGraphAppScope[]>]`: Read-only collection with details of the app specific scopes when the assignment scopes are app specific. Containment entity. Read-only.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. This property is read only.
    - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. This property is read only.
  - `[Condition <String>]`: 
  - `[Description <String>]`: Description of the role assignment.
  - `[DirectoryScopeIds <String[]>]`: Ids of the directory objects representing the scopes of the assignment. The scopes of an assignment determine the set of resources for which the principals have been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
  - `[DirectoryScopes <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the directory objects that are scope of the assignment. Provided so that callers can get the directory objects using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[DisplayName <String>]`: Name of the role assignment. Required.
  - `[PrincipalIds <String[]>]`: Identifiers of the principals to which the assignment is granted.  Supports $filter (any operator only).
  - `[Principals <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the assigned principals. Provided so that callers can get the principals using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
  - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AllowedPrincipalTypes <String>]`: allowedRolePrincipalTypes
    - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
    - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq and startsWith).
    - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles support this attribute.
    - `[IsBuiltIn <Boolean?>]`: Flag indicating if the unifiedRoleDefinition is part of the default set included with the product or custom. Read-only.  Supports $filter (eq).
    - `[IsEnabled <Boolean?>]`: Flag indicating if the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
    - `[IsPrivileged <Boolean?>]`: 
    - `[ResourceScopes <String[]>]`: List of scopes permissions granted by the role definition apply to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This will be deprecated soon. Attach scope to role assignment.
    - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
      - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
      - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective. Not supported for custom roles.
      - `[ExcludedResourceActions <String[]>]`: 
    - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false. This identifier is typically used if one needs an identifier to be the same across different directories. Read-only when isBuiltIn is true.
    - `[Version <String>]`: Indicates the version of the unifiedRoleDefinition object. Read-only when isBuiltIn is true.
  - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for.

`ROLEDEFINITIONS <IMicrosoftGraphUnifiedRoleDefinition[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowedPrincipalTypes <String>]`: allowedRolePrincipalTypes
  - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
  - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq and startsWith).
  - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles support this attribute.
  - `[IsBuiltIn <Boolean?>]`: Flag indicating if the unifiedRoleDefinition is part of the default set included with the product or custom. Read-only.  Supports $filter (eq).
  - `[IsEnabled <Boolean?>]`: Flag indicating if the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
  - `[IsPrivileged <Boolean?>]`: 
  - `[ResourceScopes <String[]>]`: List of scopes permissions granted by the role definition apply to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This will be deprecated soon. Attach scope to role assignment.
  - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
    - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
    - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective. Not supported for custom roles.
    - `[ExcludedResourceActions <String[]>]`: 
  - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false. This identifier is typically used if one needs an identifier to be the same across different directories. Read-only when isBuiltIn is true.
  - `[Version <String>]`: Indicates the version of the unifiedRoleDefinition object. Read-only when isBuiltIn is true.

## RELATED LINKS

