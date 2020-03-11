---
external help file:
Module Name: Microsoft.Graph.Identity.RoleManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.rolemanagement/update-mgrolemanagementdirectoryroleassignment
schema: 2.0.0
---

# Update-MgRoleManagementDirectoryRoleAssignment

## SYNOPSIS
Update the navigation property roleAssignments in roleManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId <String> [-Id <String>]
 [-MicrosoftGraphEntityId <String>] [-Principal <IMicrosoftGraphDirectoryObject>] [-PrincipalId <String>]
 [-ResourceScope <String>] [-RoleDefinitionDescription <String>] [-RoleDefinitionDisplayName <String>]
 [-RoleDefinitionId <String>] [-RoleDefinitionIsBuiltIn] [-RoleDefinitionIsEnabled]
 [-RoleDefinitionResourceScopes <String[]>]
 [-RoleDefinitionRolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]
 [-RoleDefinitionTemplateId <String>] [-RoleDefinitionVersion <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId <String>
 -BodyParameter <IMicrosoftGraphUnifiedRoleAssignment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgRoleManagementDirectoryRoleAssignment -InputObject <IIdentityRoleManagementIdentity>
 -BodyParameter <IMicrosoftGraphUnifiedRoleAssignment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgRoleManagementDirectoryRoleAssignment -InputObject <IIdentityRoleManagementIdentity> [-Id <String>]
 [-MicrosoftGraphEntityId <String>] [-Principal <IMicrosoftGraphDirectoryObject>] [-PrincipalId <String>]
 [-ResourceScope <String>] [-RoleDefinitionDescription <String>] [-RoleDefinitionDisplayName <String>]
 [-RoleDefinitionId <String>] [-RoleDefinitionIsBuiltIn] [-RoleDefinitionIsEnabled]
 [-RoleDefinitionResourceScopes <String[]>]
 [-RoleDefinitionRolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]
 [-RoleDefinitionTemplateId <String>] [-RoleDefinitionVersion <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property roleAssignments in roleManagement

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
unifiedRoleAssignment
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleAssignment
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityRoleManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -MicrosoftGraphEntityId
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Principal
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for PRINCIPAL properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PrincipalId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceScope
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleDefinitionDescription
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleDefinitionDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleDefinitionId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleDefinitionIsBuiltIn
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleDefinitionIsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleDefinitionResourceScopes
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleDefinitionRolePermissions
.
To construct, see NOTES section for ROLEDEFINITIONROLEPERMISSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRolePermission[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleDefinitionTemplateId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleDefinitionVersion
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UnifiedRoleAssignmentId
key: unifiedRoleAssignment-id of unifiedRoleAssignment

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityRoleManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleAssignment

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphUnifiedRoleAssignment>: unifiedRoleAssignment
  - `[Id <String>]`: Read-only.
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[PrincipalId <String>]`: 
  - `[ResourceScope <String>]`: 
  - `[RoleDefinitionDescription <String>]`: 
  - `[RoleDefinitionDisplayName <String>]`: 
  - `[RoleDefinitionId <String>]`: 
  - `[RoleDefinitionIsBuiltIn <Boolean?>]`: 
  - `[RoleDefinitionIsEnabled <Boolean?>]`: 
  - `[RoleDefinitionResourceScopes <String[]>]`: 
  - `[RoleDefinitionRolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: 
    - `[AllowedResourceActions <String[]>]`: 
    - `[Condition <String>]`: 
  - `[RoleDefinitionTemplateId <String>]`: 
  - `[RoleDefinitionVersion <String>]`: 

#### INPUTOBJECT <IIdentityRoleManagementIdentity>: Identity Parameter
  - `[UnifiedRoleAssignmentId <String>]`: key: unifiedRoleAssignment-id of unifiedRoleAssignment
  - `[UnifiedRoleDefinitionId <String>]`: key: unifiedRoleDefinition-id of unifiedRoleDefinition

#### PRINCIPAL <IMicrosoftGraphDirectoryObject>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

#### ROLEDEFINITIONROLEPERMISSIONS <IMicrosoftGraphUnifiedRolePermission[]>: .
  - `[AllowedResourceActions <String[]>]`: 
  - `[Condition <String>]`: 

## RELATED LINKS

