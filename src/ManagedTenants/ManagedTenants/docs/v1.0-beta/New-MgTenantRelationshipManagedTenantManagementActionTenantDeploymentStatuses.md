---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.managedtenants/new-mgtenantrelationshipmanagedtenantmanagementactiontenantdeploymentstatuses
schema: 2.0.0
---

# New-MgBetaTenantRelationshipManagedTenantManagementActionTenantDeploymentStatuses

## SYNOPSIS
Create new navigation property to managementActionTenantDeploymentStatuses for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaTenantRelationshipManagedTenantManagementActionTenantDeploymentStatuses
 [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Statuses <IMicrosoftGraphManagedTenantsManagementActionDeploymentStatus[]>] [-TenantGroupId <String>]
 [-TenantId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaTenantRelationshipManagedTenantManagementActionTenantDeploymentStatuses
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementActionTenantDeploymentStatus> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to managementActionTenantDeploymentStatuses for tenantRelationships

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
managementActionTenantDeploymentStatus
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementActionTenantDeploymentStatus
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Statuses
The collection of deployment status for each instance of a management action.
Optional.
To construct, please use Get-Help -Online and see NOTES section for STATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementActionDeploymentStatus[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantGroupId
The identifier for the tenant group that is associated with the management action.
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

### -TenantId
The Azure Active Directory tenant identifier for the managed tenant.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementActionTenantDeploymentStatus

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementActionTenantDeploymentStatus

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsManagementActionTenantDeploymentStatus>: managementActionTenantDeploymentStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Statuses <IMicrosoftGraphManagedTenantsManagementActionDeploymentStatus[]>]`: The collection of deployment status for each instance of a management action. Optional.
    - `[ManagementActionId <String>]`: The identifier for the management action. Required. Read-only.
    - `[ManagementTemplateId <String>]`: The management template identifier that was used to generate the management action. Required. Read-only.
    - `[ManagementTemplateVersion <Int32?>]`: 
    - `[Status <String>]`: managementActionStatus
    - `[WorkloadActionDeploymentStatuses <IMicrosoftGraphManagedTenantsWorkloadActionDeploymentStatus[]>]`: The collection of workload action deployment statues for the given management action. Optional.
      - `[ActionId <String>]`: The unique identifier for the workload action. Required. Read-only.
      - `[DeployedPolicyId <String>]`: The identifier of any policy that was created by applying the workload action. Optional. Read-only.
      - `[Error <IMicrosoftGraphGenericError>]`: genericError
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: The error code.
        - `[Message <String>]`: The error message.
      - `[ExcludeGroups <String[]>]`: 
      - `[IncludeAllUsers <Boolean?>]`: 
      - `[IncludeGroups <String[]>]`: 
      - `[LastDeploymentDateTime <DateTime?>]`: The date and time the workload action was last deployed. Optional.
      - `[Status <String>]`: workloadActionStatus
  - `[TenantGroupId <String>]`: The identifier for the tenant group that is associated with the management action. Required. Read-only.
  - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.

STATUSES <IMicrosoftGraphManagedTenantsManagementActionDeploymentStatus[]>: The collection of deployment status for each instance of a management action. Optional.
  - `[ManagementActionId <String>]`: The identifier for the management action. Required. Read-only.
  - `[ManagementTemplateId <String>]`: The management template identifier that was used to generate the management action. Required. Read-only.
  - `[ManagementTemplateVersion <Int32?>]`: 
  - `[Status <String>]`: managementActionStatus
  - `[WorkloadActionDeploymentStatuses <IMicrosoftGraphManagedTenantsWorkloadActionDeploymentStatus[]>]`: The collection of workload action deployment statues for the given management action. Optional.
    - `[ActionId <String>]`: The unique identifier for the workload action. Required. Read-only.
    - `[DeployedPolicyId <String>]`: The identifier of any policy that was created by applying the workload action. Optional. Read-only.
    - `[Error <IMicrosoftGraphGenericError>]`: genericError
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: The error code.
      - `[Message <String>]`: The error message.
    - `[ExcludeGroups <String[]>]`: 
    - `[IncludeAllUsers <Boolean?>]`: 
    - `[IncludeGroups <String[]>]`: 
    - `[LastDeploymentDateTime <DateTime?>]`: The date and time the workload action was last deployed. Optional.
    - `[Status <String>]`: workloadActionStatus

## RELATED LINKS

