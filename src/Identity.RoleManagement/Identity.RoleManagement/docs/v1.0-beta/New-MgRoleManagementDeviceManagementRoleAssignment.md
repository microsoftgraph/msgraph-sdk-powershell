---
external help file:
Module Name: Microsoft.Graph.Identity.RoleManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.rolemanagement/new-mgrolemanagementdevicemanagementroleassignment
schema: 2.0.0
---

# New-MgRoleManagementDeviceManagementRoleAssignment

## SYNOPSIS
Create new navigation property to roleAssignments for roleManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgRoleManagementDeviceManagementRoleAssignment [-AppScopeIds <String[]>]
 [-AppScopes <IMicrosoftGraphAppScope[]>] [-Condition <String>] [-Description <String>]
 [-DirectoryScopeIds <String[]>] [-DirectoryScopes <IMicrosoftGraphDirectoryObject[]>] [-DisplayName <String>]
 [-Id <String>] [-MicrosoftGraphEntityId <String>] [-PrincipalIds <String[]>]
 [-Principals <IMicrosoftGraphDirectoryObject[]>] [-RoleDefinitionDescription <String>]
 [-RoleDefinitionDisplayName <String>] [-RoleDefinitionId <String>] [-RoleDefinitionIsBuiltIn]
 [-RoleDefinitionIsEnabled] [-RoleDefinitionResourceScopes <String[]>]
 [-RoleDefinitionRolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]
 [-RoleDefinitionTemplateId <String>] [-RoleDefinitionVersion <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgRoleManagementDeviceManagementRoleAssignment
 -BodyParameter <IMicrosoftGraphUnifiedRoleAssignmentMultiple> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to roleAssignments for roleManagement

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

### -AppScopeIds
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

### -AppScopes
.
To construct, see NOTES section for APPSCOPES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppScope[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
unifiedRoleAssignmentMultiple
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleAssignmentMultiple
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Condition
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

### -Description
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

### -DirectoryScopeIds
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

### -DirectoryScopes
.
To construct, see NOTES section for DIRECTORYSCOPES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
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

### -Id
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

### -MicrosoftGraphEntityId
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

### -PrincipalIds
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

### -Principals
.
To construct, see NOTES section for PRINCIPALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleDefinitionDescription
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

### -RoleDefinitionDisplayName
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

### -RoleDefinitionId
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

### -RoleDefinitionIsBuiltIn
.

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

### -RoleDefinitionIsEnabled
.

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

### -RoleDefinitionResourceScopes
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

### -RoleDefinitionRolePermissions
.
To construct, see NOTES section for ROLEDEFINITIONROLEPERMISSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRolePermission[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleDefinitionTemplateId
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

### -RoleDefinitionVersion
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleAssignmentMultiple

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleAssignmentMultiple

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPSCOPES <IMicrosoftGraphAppScope[]>: .
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[Type <String>]`: 

BODYPARAMETER <IMicrosoftGraphUnifiedRoleAssignmentMultiple>: unifiedRoleAssignmentMultiple
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

DIRECTORYSCOPES <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

PRINCIPALS <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

ROLEDEFINITIONROLEPERMISSIONS <IMicrosoftGraphUnifiedRolePermission[]>: .
  - `[AllowedResourceActions <String[]>]`: 
  - `[Condition <String>]`: 
  - `[ExcludedResourceActions <String[]>]`: 

## RELATED LINKS

