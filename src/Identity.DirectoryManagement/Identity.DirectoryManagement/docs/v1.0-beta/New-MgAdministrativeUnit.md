---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgadministrativeunit
schema: 2.0.0
---

# New-MgAdministrativeUnit

## SYNOPSIS
Add new entity to administrativeUnits

## SYNTAX

### CreateExpanded (Default)
```
New-MgAdministrativeUnit [-AdditionalProperties <Hashtable>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>]
 [-Members <IMicrosoftGraphDirectoryObject[]>] [-ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>]
 [-Visibility <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgAdministrativeUnit -BodyParameter <IMicrosoftGraphAdministrativeUnit> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Add new entity to administrativeUnits

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
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAdministrativeUnit
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedDateTime
.

```yaml
Type: System.DateTime
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

### -Extensions
.
To construct, see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension[]
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

### -Members
.
To construct, see NOTES section for MEMBERS properties and create a hash table.

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

### -ScopedRoleMembers
.
To construct, see NOTES section for SCOPEDROLEMEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphScopedRoleMembership[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Visibility
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAdministrativeUnit

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAdministrativeUnit

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAdministrativeUnit>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Extensions <IMicrosoftGraphExtension[]>]`: 
    - `[Id <String>]`: Read-only.
  - `[Members <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AdministrativeUnitId <String>]`: 
    - `[RoleId <String>]`: 
    - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
  - `[Visibility <String>]`: 

EXTENSIONS <IMicrosoftGraphExtension[]>: .
  - `[Id <String>]`: Read-only.

MEMBERS <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

SCOPEDROLEMEMBERS <IMicrosoftGraphScopedRoleMembership[]>: .
  - `[Id <String>]`: Read-only.
  - `[AdministrativeUnitId <String>]`: 
  - `[RoleId <String>]`: 
  - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.

## RELATED LINKS

