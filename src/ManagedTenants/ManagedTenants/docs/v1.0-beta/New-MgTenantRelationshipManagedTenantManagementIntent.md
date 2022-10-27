---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/new-mgtenantrelationshipmanagedtenantmanagementintent
schema: 2.0.0
---

# New-MgTenantRelationshipManagedTenantManagementIntent

## SYNOPSIS
Create new navigation property to managementIntents for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgTenantRelationshipManagedTenantManagementIntent [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-Id <String>] [-IsGlobal]
 [-ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplateDetailedInfo[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgTenantRelationshipManagedTenantManagementIntent
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementIntent> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to managementIntents for tenantRelationships

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
managementIntent
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementIntent
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name for the management intent.
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

### -Id
The unique identifier for an entity.
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

### -IsGlobal
A flag indicating whether the management intent is global.
Required.
Read-only.

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

### -ManagementTemplates
The collection of management templates associated with the management intent.
Optional.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for MANAGEMENTTEMPLATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateDetailedInfo[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementIntent

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementIntent

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsManagementIntent>: managementIntent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name for the management intent. Optional. Read-only.
  - `[IsGlobal <Boolean?>]`: A flag indicating whether the management intent is global. Required. Read-only.
  - `[ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplateDetailedInfo[]>]`: The collection of management templates associated with the management intent. Optional. Read-only.
    - `[Category <String>]`: managementCategory
    - `[DisplayName <String>]`: The display name for the management template. Required. Read-only.
    - `[ManagementTemplateId <String>]`: The unique identifier for the management template. Required. Read-only.
    - `[Version <Int32?>]`: 

MANAGEMENTTEMPLATES <IMicrosoftGraphManagedTenantsManagementTemplateDetailedInfo[]>: The collection of management templates associated with the management intent. Optional. Read-only.
  - `[Category <String>]`: managementCategory
  - `[DisplayName <String>]`: The display name for the management template. Required. Read-only.
  - `[ManagementTemplateId <String>]`: The unique identifier for the management template. Required. Read-only.
  - `[Version <Int32?>]`: 

## RELATED LINKS

