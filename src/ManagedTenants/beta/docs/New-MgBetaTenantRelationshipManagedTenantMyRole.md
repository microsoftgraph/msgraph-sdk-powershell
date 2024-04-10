---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.managedtenants/new-mgbetatenantrelationshipmanagedtenantmyrole
schema: 2.0.0
---

# New-MgBetaTenantRelationshipManagedTenantMyRole

## SYNOPSIS
Create new navigation property to myRoles for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaTenantRelationshipManagedTenantMyRole [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphManagedTenantsRoleAssignment[]>] [-ResponseHeadersVariable <String>]
 [-TenantId <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaTenantRelationshipManagedTenantMyRole -BodyParameter <IMicrosoftGraphManagedTenantsMyRole>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to myRoles for tenantRelationships

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

### -Assignments
A collection of role assignments for the managed tenant.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsRoleAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
myRole
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsMyRole
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -TenantId
The Microsoft Entra tenant identifier for the managed tenant.
Optional.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsMyRole

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsMyRole

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSIGNMENTS <IMicrosoftGraphManagedTenantsRoleAssignment[]>`: A collection of role assignments for the managed tenant.
  - `[AssignmentType <String>]`: delegatedPrivilegeStatus
  - `[Roles <IMicrosoftGraphManagedTenantsRoleDefinition[]>]`: The collection of roles assigned.
    - `[Description <String>]`: The description for the role.
    - `[DisplayName <String>]`: The display name for the role assignment.
    - `[TemplateId <String>]`: The unique identifier for the template.

`BODYPARAMETER <IMicrosoftGraphManagedTenantsMyRole>`: myRole
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Assignments <IMicrosoftGraphManagedTenantsRoleAssignment[]>]`: A collection of role assignments for the managed tenant.
    - `[AssignmentType <String>]`: delegatedPrivilegeStatus
    - `[Roles <IMicrosoftGraphManagedTenantsRoleDefinition[]>]`: The collection of roles assigned.
      - `[Description <String>]`: The description for the role.
      - `[DisplayName <String>]`: The display name for the role assignment.
      - `[TemplateId <String>]`: The unique identifier for the template.
  - `[TenantId <String>]`: The Microsoft Entra tenant identifier for the managed tenant. Optional. Read-only.

## RELATED LINKS

