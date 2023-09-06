---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/invoke-mgbetatenantrelationshipmanagedtenantgroupsearch
schema: 2.0.0
---

# Invoke-MgBetaTenantRelationshipManagedTenantGroupSearch

## SYNOPSIS
Invoke action tenantSearch

## SYNTAX

### TenantExpanded (Default)
```
Invoke-MgBetaTenantRelationshipManagedTenantGroupSearch [-AdditionalProperties <Hashtable>]
 [-TenantId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Tenant
```
Invoke-MgBetaTenantRelationshipManagedTenantGroupSearch
 -Body <IPathsF1Wwh1TenantrelationshipsManagedtenantsTenantgroupsMicrosoftGraphManagedtenantsTenantsearchPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action tenantSearch

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
Parameter Sets: TenantExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsF1Wwh1TenantrelationshipsManagedtenantsTenantgroupsMicrosoftGraphManagedtenantsTenantsearchPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Tenant
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -TenantId
.

```yaml
Type: System.String
Parameter Sets: TenantExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsF1Wwh1TenantrelationshipsManagedtenantsTenantgroupsMicrosoftGraphManagedtenantsTenantsearchPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IPathsF1Wwh1TenantrelationshipsManagedtenantsTenantgroupsMicrosoftGraphManagedtenantsTenantsearchPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[TenantId <String>]`: 

## RELATED LINKS

