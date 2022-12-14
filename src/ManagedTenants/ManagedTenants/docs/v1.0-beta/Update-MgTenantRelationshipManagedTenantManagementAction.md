---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.managedtenants/update-mgtenantrelationshipmanagedtenantmanagementaction
schema: 2.0.0
---

# Update-MgBetaTenantRelationshipManagedTenantManagementAction

## SYNOPSIS
Update the navigation property managementActions in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTenantRelationshipManagedTenantManagementAction -ManagementActionId <String>
 [-AdditionalProperties <Hashtable>] [-Category <String>] [-Description <String>] [-DisplayName <String>]
 [-Id <String>] [-ReferenceTemplateId <String>] [-ReferenceTemplateVersion <Int32>]
 [-WorkloadActions <IMicrosoftGraphManagedTenantsWorkloadAction[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaTenantRelationshipManagedTenantManagementAction -ManagementActionId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementAction> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaTenantRelationshipManagedTenantManagementAction -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementAction> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaTenantRelationshipManagedTenantManagementAction -InputObject <IManagedTenantsIdentity>
 [-AdditionalProperties <Hashtable>] [-Category <String>] [-Description <String>] [-DisplayName <String>]
 [-Id <String>] [-ReferenceTemplateId <String>] [-ReferenceTemplateVersion <Int32>]
 [-WorkloadActions <IMicrosoftGraphManagedTenantsWorkloadAction[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property managementActions in tenantRelationships

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
managementAction
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementAction
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
managementCategory

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

### -Description
The description for the management action.
Optional.
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

### -DisplayName
The display name for the management action.
Optional.
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

### -Id
The unique identifier for an entity.
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IManagedTenantsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagementActionId
key: id of managementAction

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

### -ReferenceTemplateId
The reference for the management template used to generate the management action.
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

### -ReferenceTemplateVersion
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkloadActions
The collection of workload actions associated with the management action.
Required.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for WORKLOADACTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsWorkloadAction[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IManagedTenantsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementAction

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsManagementAction>: managementAction
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Category <String>]`: managementCategory
  - `[Description <String>]`: The description for the management action. Optional. Read-only.
  - `[DisplayName <String>]`: The display name for the management action. Optional. Read-only.
  - `[ReferenceTemplateId <String>]`: The reference for the management template used to generate the management action. Required. Read-only.
  - `[ReferenceTemplateVersion <Int32?>]`: 
  - `[WorkloadActions <IMicrosoftGraphManagedTenantsWorkloadAction[]>]`: The collection of workload actions associated with the management action. Required. Read-only.
    - `[ActionId <String>]`: The unique identifier for the workload action. Required. Read-only.
    - `[Category <String>]`: workloadActionCategory
    - `[Description <String>]`: The description for the workload action. Optional. Read-only.
    - `[DisplayName <String>]`: The display name for the workload action. Optional. Read-only.
    - `[Licenses <String[]>]`: 
    - `[Service <String>]`: The service associated with workload action. Optional. Read-only.
    - `[Settings <IMicrosoftGraphManagedTenantsSetting[]>]`: The collection of settings associated with the workload action. Optional. Read-only.
      - `[DisplayName <String>]`: The display name for the setting. Required. Read-only.
      - `[JsonValue <String>]`: The value for the setting serialized as string of JSON. Required. Read-only.
      - `[OverwriteAllowed <Boolean?>]`: A flag indicating whether the setting can be override existing configurations when applied. Required. Read-only.
      - `[SettingId <String>]`: 
      - `[ValueType <String>]`: managementParameterValueType

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
  - `[ManagedTenantAlertId <String>]`: key: id of managedTenantAlert
  - `[ManagedTenantAlertLogId <String>]`: key: id of managedTenantAlertLog
  - `[ManagedTenantAlertRuleDefinitionId <String>]`: key: id of managedTenantAlertRuleDefinition
  - `[ManagedTenantAlertRuleId <String>]`: key: id of managedTenantAlertRule
  - `[ManagedTenantApiNotificationId <String>]`: key: id of managedTenantApiNotification
  - `[ManagedTenantEmailNotificationId <String>]`: key: id of managedTenantEmailNotification
  - `[ManagedTenantTicketingEndpointId <String>]`: key: id of managedTenantTicketingEndpoint
  - `[ManagementActionId <String>]`: key: id of managementAction
  - `[ManagementActionTenantDeploymentStatusId <String>]`: key: id of managementActionTenantDeploymentStatus
  - `[ManagementIntentId <String>]`: key: id of managementIntent
  - `[ManagementTemplateCollectionId <String>]`: key: id of managementTemplateCollection
  - `[ManagementTemplateCollectionTenantSummaryId <String>]`: key: id of managementTemplateCollectionTenantSummary
  - `[ManagementTemplateId <String>]`: key: id of managementTemplate
  - `[ManagementTemplateStepDeploymentId <String>]`: key: id of managementTemplateStepDeployment
  - `[ManagementTemplateStepId <String>]`: key: id of managementTemplateStep
  - `[ManagementTemplateStepTenantSummaryId <String>]`: key: id of managementTemplateStepTenantSummary
  - `[ManagementTemplateStepVersionId <String>]`: key: id of managementTemplateStepVersion
  - `[MyRoleTenantId <String>]`: key: tenantId of myRole
  - `[TenantCustomizedInformationId <String>]`: key: id of tenantCustomizedInformation
  - `[TenantDetailedInformationId <String>]`: key: id of tenantDetailedInformation
  - `[TenantGroupId <String>]`: key: id of tenantGroup
  - `[TenantId <String>]`: key: id of tenant
  - `[TenantTagId <String>]`: key: id of tenantTag
  - `[WindowsDeviceMalwareStateId <String>]`: key: id of windowsDeviceMalwareState
  - `[WindowsProtectionStateId <String>]`: key: id of windowsProtectionState

WORKLOADACTIONS <IMicrosoftGraphManagedTenantsWorkloadAction[]>: The collection of workload actions associated with the management action. Required. Read-only.
  - `[ActionId <String>]`: The unique identifier for the workload action. Required. Read-only.
  - `[Category <String>]`: workloadActionCategory
  - `[Description <String>]`: The description for the workload action. Optional. Read-only.
  - `[DisplayName <String>]`: The display name for the workload action. Optional. Read-only.
  - `[Licenses <String[]>]`: 
  - `[Service <String>]`: The service associated with workload action. Optional. Read-only.
  - `[Settings <IMicrosoftGraphManagedTenantsSetting[]>]`: The collection of settings associated with the workload action. Optional. Read-only.
    - `[DisplayName <String>]`: The display name for the setting. Required. Read-only.
    - `[JsonValue <String>]`: The value for the setting serialized as string of JSON. Required. Read-only.
    - `[OverwriteAllowed <Boolean?>]`: A flag indicating whether the setting can be override existing configurations when applied. Required. Read-only.
    - `[SettingId <String>]`: 
    - `[ValueType <String>]`: managementParameterValueType

## RELATED LINKS

