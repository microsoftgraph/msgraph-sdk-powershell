---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/update-mgtenantrelationshipmanagedtenantmanagementactiontenantdeploymentstatuses
schema: 2.0.0
---

# Update-MgTenantRelationshipManagedTenantManagementActionTenantDeploymentStatuses

## SYNOPSIS
Update the navigation property managementActionTenantDeploymentStatuses in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTenantRelationshipManagedTenantManagementActionTenantDeploymentStatuses
 -ManagementActionTenantDeploymentStatusId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Statuses <IMicrosoftGraphManagedTenantsManagementActionDeploymentStatus[]>] [-TenantGroupId <String>]
 [-TenantId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTenantRelationshipManagedTenantManagementActionTenantDeploymentStatuses
 -ManagementActionTenantDeploymentStatusId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementActionTenantDeploymentStatus> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTenantRelationshipManagedTenantManagementActionTenantDeploymentStatuses
 -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementActionTenantDeploymentStatus> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTenantRelationshipManagedTenantManagementActionTenantDeploymentStatuses
 -InputObject <IManagedTenantsIdentity> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Statuses <IMicrosoftGraphManagedTenantsManagementActionDeploymentStatus[]>] [-TenantGroupId <String>]
 [-TenantId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property managementActionTenantDeploymentStatuses in tenantRelationships

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementActionTenantDeploymentStatus
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IManagedTenantsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagementActionTenantDeploymentStatusId
key: id of managementActionTenantDeploymentStatus

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementActionDeploymentStatus[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IManagedTenantsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementActionTenantDeploymentStatus

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsManagementActionTenantDeploymentStatus>: managementActionTenantDeploymentStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
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

INPUTOBJECT <IManagedTenantsIdentity>: Identity Parameter
  - `[AggregatedPolicyComplianceId <String>]`: key: id of aggregatedPolicyCompliance
  - `[AuditEventId <String>]`: key: id of auditEvent
  - `[CloudPcConnectionId <String>]`: key: id of cloudPcConnection
  - `[CloudPcDeviceId <String>]`: key: id of cloudPcDevice
  - `[CloudPcOverviewTenantId <String>]`: key: tenantId of cloudPcOverview
  - `[ConditionalAccessPolicyCoverageId <String>]`: key: id of conditionalAccessPolicyCoverage
  - `[CredentialUserRegistrationsSummaryId <String>]`: key: id of credentialUserRegistrationsSummary
  - `[DeviceCompliancePolicySettingStateSummaryId <String>]`: key: id of deviceCompliancePolicySettingStateSummary
  - `[ManagedDeviceComplianceId <String>]`: key: id of managedDeviceCompliance
  - `[ManagedDeviceComplianceTrendId <String>]`: key: id of managedDeviceComplianceTrend
  - `[ManagementActionId <String>]`: key: id of managementAction
  - `[ManagementActionTenantDeploymentStatusId <String>]`: key: id of managementActionTenantDeploymentStatus
  - `[ManagementIntentId <String>]`: key: id of managementIntent
  - `[ManagementTemplateCollectionId <String>]`: key: id of managementTemplateCollection
  - `[ManagementTemplateId <String>]`: key: id of managementTemplate
  - `[ManagementTemplateStepDeploymentId <String>]`: key: id of managementTemplateStepDeployment
  - `[ManagementTemplateStepId <String>]`: key: id of managementTemplateStep
  - `[ManagementTemplateStepVersionId <String>]`: key: id of managementTemplateStepVersion
  - `[MyRoleTenantId <String>]`: key: tenantId of myRole
  - `[TenantCustomizedInformationId <String>]`: key: id of tenantCustomizedInformation
  - `[TenantDetailedInformationId <String>]`: key: id of tenantDetailedInformation
  - `[TenantGroupId <String>]`: key: id of tenantGroup
  - `[TenantId <String>]`: key: id of tenant
  - `[TenantTagId <String>]`: key: id of tenantTag
  - `[WindowsDeviceMalwareStateId <String>]`: key: id of windowsDeviceMalwareState
  - `[WindowsProtectionStateId <String>]`: key: id of windowsProtectionState

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

