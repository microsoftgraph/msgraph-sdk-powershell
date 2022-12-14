---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.managedtenants/new-mgtenantrelationshipmanagedtenantaggregatedpolicycompliance
schema: 2.0.0
---

# New-MgBetaTenantRelationshipManagedTenantAggregatedPolicyCompliance

## SYNOPSIS
Create new navigation property to aggregatedPolicyCompliances for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaTenantRelationshipManagedTenantAggregatedPolicyCompliance [-AdditionalProperties <Hashtable>]
 [-CompliancePolicyId <String>] [-CompliancePolicyName <String>] [-CompliancePolicyPlatform <String>]
 [-CompliancePolicyType <String>] [-Id <String>] [-LastRefreshedDateTime <DateTime>]
 [-NumberOfCompliantDevices <Int64>] [-NumberOfErrorDevices <Int64>] [-NumberOfNonCompliantDevices <Int64>]
 [-PolicyModifiedDateTime <DateTime>] [-TenantDisplayName <String>] [-TenantId <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaTenantRelationshipManagedTenantAggregatedPolicyCompliance
 -BodyParameter <IMicrosoftGraphManagedTenantsAggregatedPolicyCompliance> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to aggregatedPolicyCompliances for tenantRelationships

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
aggregatedPolicyCompliance
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsAggregatedPolicyCompliance
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompliancePolicyId
Identifier for the device compliance policy.
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

### -CompliancePolicyName
Name of the device compliance policy.
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

### -CompliancePolicyPlatform
Platform for the device compliance policy.
Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, androidAOSP, all.
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

### -CompliancePolicyType
The type of compliance policy.
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

### -LastRefreshedDateTime
Date and time the entity was last updated in the multi-tenant management platform.
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

### -NumberOfCompliantDevices
The number of devices that are in a compliant status.
Optional.
Read-only.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumberOfErrorDevices
The number of devices that are in an error status.
Optional.
Read-only.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumberOfNonCompliantDevices
The number of device that are in a non-compliant status.
Optional.
Read-only.

```yaml
Type: System.Int64
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyModifiedDateTime
The date and time the device policy was last modified.
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

### -TenantDisplayName
The display name for the managed tenant.
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

### -TenantId
The Azure Active Directory tenant identifier for the managed tenant.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsAggregatedPolicyCompliance

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsAggregatedPolicyCompliance

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsAggregatedPolicyCompliance>: aggregatedPolicyCompliance
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CompliancePolicyId <String>]`: Identifier for the device compliance policy. Optional. Read-only.
  - `[CompliancePolicyName <String>]`: Name of the device compliance policy. Optional. Read-only.
  - `[CompliancePolicyPlatform <String>]`: Platform for the device compliance policy. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, androidAOSP, all. Optional. Read-only.
  - `[CompliancePolicyType <String>]`: The type of compliance policy. Optional. Read-only.
  - `[LastRefreshedDateTime <DateTime?>]`: Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.
  - `[NumberOfCompliantDevices <Int64?>]`: The number of devices that are in a compliant status. Optional. Read-only.
  - `[NumberOfErrorDevices <Int64?>]`: The number of devices that are in an error status. Optional. Read-only.
  - `[NumberOfNonCompliantDevices <Int64?>]`: The number of device that are in a non-compliant status. Optional. Read-only.
  - `[PolicyModifiedDateTime <DateTime?>]`: The date and time the device policy was last modified. Optional. Read-only.
  - `[TenantDisplayName <String>]`: The display name for the managed tenant. Optional. Read-only.
  - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.

## RELATED LINKS

