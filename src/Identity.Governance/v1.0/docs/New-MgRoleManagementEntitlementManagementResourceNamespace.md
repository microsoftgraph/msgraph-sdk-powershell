---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.governance/new-mgrolemanagemententitlementmanagementresourcenamespace
schema: 2.0.0
---

# New-MgRoleManagementEntitlementManagementResourceNamespace

## SYNOPSIS
Create new navigation property to resourceNamespaces for roleManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgRoleManagementEntitlementManagementResourceNamespace [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Name <String>] [-ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgRoleManagementEntitlementManagementResourceNamespace
 -BodyParameter <IMicrosoftGraphUnifiedRbacResourceNamespace> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to resourceNamespaces for roleManagement

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
unifiedRbacResourceNamespace
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRbacResourceNamespace
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Name
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

### -ResourceActions
.
To construct, see NOTES section for RESOURCEACTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRbacResourceAction[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRbacResourceNamespace

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRbacResourceNamespace

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphUnifiedRbacResourceNamespace>`: unifiedRbacResourceNamespace
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Name <String>]`: 
  - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ActionVerb <String>]`: 
    - `[AuthenticationContextId <String>]`: 
    - `[Description <String>]`: 
    - `[IsAuthenticationContextSettable <Boolean?>]`: 
    - `[Name <String>]`: 
    - `[ResourceScopeId <String>]`: 

`RESOURCEACTIONS <IMicrosoftGraphUnifiedRbacResourceAction[]>`: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ActionVerb <String>]`: 
  - `[AuthenticationContextId <String>]`: 
  - `[Description <String>]`: 
  - `[IsAuthenticationContextSettable <Boolean?>]`: 
  - `[Name <String>]`: 
  - `[ResourceScopeId <String>]`: 

## RELATED LINKS

