---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/new-mgtenantrelationshipmanagedtenantconditionalaccesspolicycoverage
schema: 2.0.0
---

# New-MgTenantRelationshipManagedTenantConditionalAccessPolicyCoverage

## SYNOPSIS
Create new navigation property to conditionalAccessPolicyCoverages for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgTenantRelationshipManagedTenantConditionalAccessPolicyCoverage [-AdditionalProperties <Hashtable>]
 [-ConditionalAccessPolicyState <String>] [-Id <String>] [-LatestPolicyModifiedDateTime <DateTime>]
 [-RequiresDeviceCompliance] [-TenantDisplayName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgTenantRelationshipManagedTenantConditionalAccessPolicyCoverage
 -BodyParameter <IMicrosoftGraphManagedTenantsConditionalAccessPolicyCoverage> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to conditionalAccessPolicyCoverages for tenantRelationships

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
conditionalAccessPolicyCoverage
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsConditionalAccessPolicyCoverage
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConditionalAccessPolicyState
The state for the conditional access policy.
Possible values are: enabled, disabled, enabledForReportingButNotEnforced.
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

### -LatestPolicyModifiedDateTime
The date and time the conditional access policy was last modified.
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

### -RequiresDeviceCompliance
A flag indicating whether the conditional access policy requires device compliance.
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

### -TenantDisplayName
The display name for the managed tenant.
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsConditionalAccessPolicyCoverage

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsConditionalAccessPolicyCoverage

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsConditionalAccessPolicyCoverage>: conditionalAccessPolicyCoverage
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConditionalAccessPolicyState <String>]`: The state for the conditional access policy. Possible values are: enabled, disabled, enabledForReportingButNotEnforced. Required. Read-only.
  - `[LatestPolicyModifiedDateTime <DateTime?>]`: The date and time the conditional access policy was last modified. Required. Read-only.
  - `[RequiresDeviceCompliance <Boolean?>]`: A flag indicating whether the conditional access policy requires device compliance. Required. Read-only.
  - `[TenantDisplayName <String>]`: The display name for the managed tenant. Required. Read-only.

## RELATED LINKS

