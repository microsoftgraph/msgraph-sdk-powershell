---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/new-mgtenantrelationshipmanagedtenanttag
schema: 2.0.0
---

# New-MgTenantRelationshipManagedTenantTag

## SYNOPSIS
Create a new tenantTag object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgTenantRelationshipManagedTenantTag [-AdditionalProperties <Hashtable>] [-CreatedByUserId <String>]
 [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-Id <String>] [-LastActionByUserId <String>] [-LastActionDateTime <DateTime>]
 [-Tenants <IMicrosoftGraphManagedTenantsTenantInfo[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgTenantRelationshipManagedTenantTag -BodyParameter <IMicrosoftGraphManagedTenantsTenantTag> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new tenantTag object.

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
tenantTag
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantTag
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedByUserId
The identifier for the account that created the tenant tag.
Required.
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

### -CreatedDateTime
The date and time when the tenant tag was created.
Required.
Read-only.

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

### -DeletedDateTime
The date and time when the tenant tag was deleted.
Required.
Read-only.

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
The description for the tenant tag.
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

### -DisplayName
The display name for the tenant tag.
Required.
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

### -LastActionByUserId
The identifier for the account that lasted on the tenant tag.
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

### -LastActionDateTime
The date and time the last action was performed against the tenant tag.
Optional.
Read-only.

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

### -Tenants
The collection of managed tenants associated with the tenant tag.
Optional.
To construct, please use Get-Help -Online and see NOTES section for TENANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantInfo[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantTag

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantTag

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsTenantTag>: tenantTag
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CreatedByUserId <String>]`: The identifier for the account that created the tenant tag. Required. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the tenant tag was created. Required. Read-only.
  - `[DeletedDateTime <DateTime?>]`: The date and time when the tenant tag was deleted. Required. Read-only.
  - `[Description <String>]`: The description for the tenant tag. Optional. Read-only.
  - `[DisplayName <String>]`: The display name for the tenant tag. Required. Read-only.
  - `[LastActionByUserId <String>]`: The identifier for the account that lasted on the tenant tag. Optional. Read-only.
  - `[LastActionDateTime <DateTime?>]`: The date and time the last action was performed against the tenant tag. Optional. Read-only.
  - `[Tenants <IMicrosoftGraphManagedTenantsTenantInfo[]>]`: The collection of managed tenants associated with the tenant tag. Optional.
    - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Optional.

TENANTS <IMicrosoftGraphManagedTenantsTenantInfo[]>: The collection of managed tenants associated with the tenant tag. Optional.
  - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Optional.

## RELATED LINKS

