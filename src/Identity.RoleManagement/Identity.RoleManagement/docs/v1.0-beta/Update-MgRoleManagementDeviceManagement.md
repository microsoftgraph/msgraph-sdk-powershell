---
external help file:
Module Name: Microsoft.Graph.Identity.RoleManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.rolemanagement/update-mgrolemanagementdevicemanagement
schema: 2.0.0
---

# Update-MgRoleManagementDeviceManagement

## SYNOPSIS
Update the navigation property deviceManagement in roleManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgRoleManagementDeviceManagement [-Id <String>]
 [-RoleAssignments <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>]
 [-RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgRoleManagementDeviceManagement -BodyParameter <IMicrosoftGraphRbacApplicationMultiple> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property deviceManagement in roleManagement

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
rbacApplicationMultiple
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRbacApplicationMultiple
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleAssignmentMultiple[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRbacApplicationMultiple

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphRbacApplicationMultiple>: rbacApplicationMultiple
  - `[Id <String>]`: Read-only.
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppScopeIds <String[]>]`: 
    - `[AppScopes <IMicrosoftGraphAppScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: 
      - `[Type <String>]`: 
    - `[Condition <String>]`: 
    - `[Description <String>]`: 
    - `[DirectoryScopeIds <String[]>]`: 
    - `[DirectoryScopes <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[MicrosoftGraphEntityId <String>]`: Read-only.
    - `[PrincipalIds <String[]>]`: 
    - `[Principals <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[RoleDefinitionDescription <String>]`: 
    - `[RoleDefinitionDisplayName <String>]`: 
    - `[RoleDefinitionId <String>]`: 
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

ROLEASSIGNMENTS <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>: .
  - `[Id <String>]`: Read-only.
  - `[AppScopeIds <String[]>]`: 
  - `[AppScopes <IMicrosoftGraphAppScope[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[Type <String>]`: 
  - `[Condition <String>]`: 
  - `[Description <String>]`: 
  - `[DirectoryScopeIds <String[]>]`: 
  - `[DirectoryScopes <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[PrincipalIds <String[]>]`: 
  - `[Principals <IMicrosoftGraphDirectoryObject[]>]`: 
  - `[RoleDefinitionDescription <String>]`: 
  - `[RoleDefinitionDisplayName <String>]`: 
  - `[RoleDefinitionId <String>]`: 
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

