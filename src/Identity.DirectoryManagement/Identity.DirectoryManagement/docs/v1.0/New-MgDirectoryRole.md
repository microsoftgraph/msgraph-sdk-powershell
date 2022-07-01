---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectoryrole
schema: 2.0.0
---

# New-MgDirectoryRole

## SYNOPSIS
Activate directoryRole

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDirectoryRole [-AdditionalProperties <Hashtable>] [-DeletedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-Members <IMicrosoftGraphDirectoryObject[]>]
 [-RoleTemplateId <String>] [-ScopedMembers <IMicrosoftGraphScopedRoleMembership[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create1
```
New-MgDirectoryRole -BodyParameter <IMicrosoftGraphDirectoryRole> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Activate directoryRole

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
directoryRole
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryRole
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description for the directory role.
Read-only.
Supports $filter (eq), $search, $select.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name for the directory role.
Read-only.
Supports $filter (eq), $search, $select.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Members
Users that are members of this directory role.
HTTP Methods: GET, POST, DELETE.
Read-only.
Nullable.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for MEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleTemplateId
The id of the directoryRoleTemplate that this role is based on.
The property must be specified when activating a directory role in a tenant with a POST operation.
After the directory role has been activated, the property is read only.
Supports $filter (eq), $select.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScopedMembers
Members of this directory role that are scoped to administrative units.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for SCOPEDMEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphScopedRoleMembership[]
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryRole

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryRole

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDirectoryRole>: directoryRole
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 
  - `[Description <String>]`: The description for the directory role. Read-only. Supports $filter (eq), $search, $select.
  - `[DisplayName <String>]`: The display name for the directory role. Read-only. Supports $filter (eq), $search, $select.
  - `[Members <IMicrosoftGraphDirectoryObject[]>]`: Users that are members of this directory role. HTTP Methods: GET, POST, DELETE. Read-only. Nullable. Supports $expand.
    - `[Id <String>]`: 
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[RoleTemplateId <String>]`: The id of the directoryRoleTemplate that this role is based on. The property must be specified when activating a directory role in a tenant with a POST operation. After the directory role has been activated, the property is read only. Supports $filter (eq), $select.
  - `[ScopedMembers <IMicrosoftGraphScopedRoleMembership[]>]`: Members of this directory role that are scoped to administrative units. Read-only. Nullable.
    - `[Id <String>]`: 
    - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
    - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
    - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.

MEMBERS <IMicrosoftGraphDirectoryObject[]>: Users that are members of this directory role. HTTP Methods: GET, POST, DELETE. Read-only. Nullable. Supports $expand.
  - `[Id <String>]`: 
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

SCOPEDMEMBERS <IMicrosoftGraphScopedRoleMembership[]>: Members of this directory role that are scoped to administrative units. Read-only. Nullable.
  - `[Id <String>]`: 
  - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
  - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
  - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.

## RELATED LINKS

