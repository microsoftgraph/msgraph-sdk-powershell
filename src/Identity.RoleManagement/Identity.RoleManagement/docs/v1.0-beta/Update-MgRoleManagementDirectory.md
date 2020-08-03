---
external help file:
Module Name: Microsoft.Graph.Identity.RoleManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.rolemanagement/update-mgrolemanagementdirectory
schema: 2.0.0
---

# Update-MgRoleManagementDirectory

## SYNOPSIS
Update the navigation property directory in roleManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgRoleManagementDirectory [-Id <String>] [-RoleAssignments <IMicrosoftGraphUnifiedRoleAssignment[]>]
 [-RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgRoleManagementDirectory -BodyParameter <IMicrosoftGraphRbacApplication> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property directory in roleManagement

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
rbacApplication
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRbacApplication
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
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

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleAssignment[]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleDefinition[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRbacApplication

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphRbacApplication>: rbacApplication
  - `[Id <String>]`: Read-only.
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppScopeDisplayName <String>]`: 
    - `[AppScopeId <String>]`: 
    - `[AppScopeType <String>]`: 
    - `[Condition <String>]`: 
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[DirectoryScopeId <String>]`: 
    - `[MicrosoftGraphEntityId <String>]`: Read-only.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[PrincipalId <String>]`: 
    - `[ResourceScope <String>]`: 
    - `[RoleDefinitionDescription <String>]`: 
    - `[RoleDefinitionDisplayName <String>]`: 
    - `[RoleDefinitionId <String>]`: 
    - `[RoleDefinitionId1 <String>]`: Read-only.
    - `[RoleDefinitionIsBuiltIn <Boolean?>]`: 
    - `[RoleDefinitionIsEnabled <Boolean?>]`: 
    - `[RoleDefinitionResourceScopes <String[]>]`: 
    - `[RoleDefinitionRolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: 
      - `[AllowedResourceActions <String[]>]`: 
      - `[Condition <String>]`: 
      - `[ExcludedResourceActions <String[]>]`: 
    - `[RoleDefinitionTemplateId <String>]`: 
    - `[RoleDefinitionVersion <String>]`: 
  - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsBuiltIn <Boolean?>]`: 
    - `[IsEnabled <Boolean?>]`: 
    - `[ResourceScopes <String[]>]`: 
    - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: 
    - `[TemplateId <String>]`: 
    - `[Version <String>]`: 

ROLEASSIGNMENTS <IMicrosoftGraphUnifiedRoleAssignment[]>: .
  - `[Id <String>]`: Read-only.
  - `[AppScopeDisplayName <String>]`: 
  - `[AppScopeId <String>]`: 
  - `[AppScopeType <String>]`: 
  - `[Condition <String>]`: 
  - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[DirectoryScopeId <String>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[PrincipalId <String>]`: 
  - `[ResourceScope <String>]`: 
  - `[RoleDefinitionDescription <String>]`: 
  - `[RoleDefinitionDisplayName <String>]`: 
  - `[RoleDefinitionId <String>]`: 
  - `[RoleDefinitionId1 <String>]`: Read-only.
  - `[RoleDefinitionIsBuiltIn <Boolean?>]`: 
  - `[RoleDefinitionIsEnabled <Boolean?>]`: 
  - `[RoleDefinitionResourceScopes <String[]>]`: 
  - `[RoleDefinitionRolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: 
    - `[AllowedResourceActions <String[]>]`: 
    - `[Condition <String>]`: 
    - `[ExcludedResourceActions <String[]>]`: 
  - `[RoleDefinitionTemplateId <String>]`: 
  - `[RoleDefinitionVersion <String>]`: 

ROLEDEFINITIONS <IMicrosoftGraphUnifiedRoleDefinition[]>: .
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsBuiltIn <Boolean?>]`: 
  - `[IsEnabled <Boolean?>]`: 
  - `[ResourceScopes <String[]>]`: 
  - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: 
    - `[AllowedResourceActions <String[]>]`: 
    - `[Condition <String>]`: 
    - `[ExcludedResourceActions <String[]>]`: 
  - `[TemplateId <String>]`: 
  - `[Version <String>]`: 

## RELATED LINKS

