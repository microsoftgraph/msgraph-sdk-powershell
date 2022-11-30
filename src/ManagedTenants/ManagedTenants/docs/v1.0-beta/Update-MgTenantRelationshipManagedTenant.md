---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/update-mgtenantrelationshipmanagedtenant
schema: 2.0.0
---

# Update-MgTenantRelationshipManagedTenant

## SYNOPSIS
Update the navigation property tenants in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTenantRelationshipManagedTenant -TenantId <String> [-AdditionalProperties <Hashtable>]
 [-Contract <IMicrosoftGraphManagedTenantsTenantContract>] [-CreatedDateTime <DateTime>]
 [-DisplayName <String>] [-Id <String>] [-LastUpdatedDateTime <DateTime>] [-TenantId1 <String>]
 [-TenantStatusInformation <IMicrosoftGraphManagedTenantsTenantStatusInformation>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTenantRelationshipManagedTenant -TenantId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsTenant> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTenantRelationshipManagedTenant -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsTenant> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTenantRelationshipManagedTenant -InputObject <IManagedTenantsIdentity> [-TenantId <String>]
 [-AdditionalProperties <Hashtable>] [-Contract <IMicrosoftGraphManagedTenantsTenantContract>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>] [-LastUpdatedDateTime <DateTime>]
 [-TenantStatusInformation <IMicrosoftGraphManagedTenantsTenantStatusInformation>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property tenants in tenantRelationships

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
tenant
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenant
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Contract
tenantContract
To construct, please use Get-Help -Online and see NOTES section for CONTRACT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantContract
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the tenant was created in the multi-tenant management platform.
Optional.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name for the tenant.
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
Type: Microsoft.Graph.PowerShell.Models.IManagedTenantsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastUpdatedDateTime
The date and time the tenant was last updated within the multi-tenant management platform.
Optional.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### -TenantId
key: id of tenant

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantId1
The Azure Active Directory tenant identifier for the managed tenant.
Optional.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantStatusInformation
tenantStatusInformation
To construct, please use Get-Help -Online and see NOTES section for TENANTSTATUSINFORMATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantStatusInformation
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenant

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsTenant>: tenant
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Contract <IMicrosoftGraphManagedTenantsTenantContract>]`: tenantContract
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContractType <Int32?>]`: The type of relationship that exists between the managing entity and tenant. Optional. Read-only.
    - `[DefaultDomainName <String>]`: The default domain name for the tenant. Required. Read-only.
    - `[DisplayName <String>]`: The display name for the tenant. Optional. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time the tenant was created in the multi-tenant management platform. Optional. Read-only.
  - `[DisplayName <String>]`: The display name for the tenant. Required. Read-only.
  - `[LastUpdatedDateTime <DateTime?>]`: The date and time the tenant was last updated within the multi-tenant management platform. Optional. Read-only.
  - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.
  - `[TenantStatusInformation <IMicrosoftGraphManagedTenantsTenantStatusInformation>]`: tenantStatusInformation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DelegatedPrivilegeStatus <String>]`: delegatedPrivilegeStatus
    - `[LastDelegatedPrivilegeRefreshDateTime <DateTime?>]`: The date and time the delegated admin privileges status was updated. Optional. Read-only.
    - `[OffboardedByUserId <String>]`: The identifier for the account that offboarded the managed tenant. Optional. Read-only.
    - `[OffboardedDateTime <DateTime?>]`: The date and time when the managed tenant was offboarded. Optional. Read-only.
    - `[OnboardedByUserId <String>]`: The identifier for the account that onboarded the managed tenant. Optional. Read-only.
    - `[OnboardedDateTime <DateTime?>]`: The date and time when the managed tenant was onboarded. Optional. Read-only.
    - `[OnboardingStatus <String>]`: tenantOnboardingStatus
    - `[TenantOnboardingEligibilityReason <String>]`: tenantOnboardingEligibilityReason
    - `[WorkloadStatuses <IMicrosoftGraphManagedTenantsWorkloadStatus[]>]`: The collection of workload statues for the managed tenant. Optional. Read-only.
      - `[DisplayName <String>]`: The display name for the workload. Required. Read-only.
      - `[OffboardedDateTime <DateTime?>]`: The date and time the workload was offboarded. Optional. Read-only.
      - `[OnboardedDateTime <DateTime?>]`: The date and time the workload was onboarded. Optional. Read-only.
      - `[OnboardingStatus <String>]`: workloadOnboardingStatus

CONTRACT <IMicrosoftGraphManagedTenantsTenantContract>: tenantContract
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContractType <Int32?>]`: The type of relationship that exists between the managing entity and tenant. Optional. Read-only.
  - `[DefaultDomainName <String>]`: The default domain name for the tenant. Required. Read-only.
  - `[DisplayName <String>]`: The display name for the tenant. Optional. Read-only.

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

TENANTSTATUSINFORMATION <IMicrosoftGraphManagedTenantsTenantStatusInformation>: tenantStatusInformation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DelegatedPrivilegeStatus <String>]`: delegatedPrivilegeStatus
  - `[LastDelegatedPrivilegeRefreshDateTime <DateTime?>]`: The date and time the delegated admin privileges status was updated. Optional. Read-only.
  - `[OffboardedByUserId <String>]`: The identifier for the account that offboarded the managed tenant. Optional. Read-only.
  - `[OffboardedDateTime <DateTime?>]`: The date and time when the managed tenant was offboarded. Optional. Read-only.
  - `[OnboardedByUserId <String>]`: The identifier for the account that onboarded the managed tenant. Optional. Read-only.
  - `[OnboardedDateTime <DateTime?>]`: The date and time when the managed tenant was onboarded. Optional. Read-only.
  - `[OnboardingStatus <String>]`: tenantOnboardingStatus
  - `[TenantOnboardingEligibilityReason <String>]`: tenantOnboardingEligibilityReason
  - `[WorkloadStatuses <IMicrosoftGraphManagedTenantsWorkloadStatus[]>]`: The collection of workload statues for the managed tenant. Optional. Read-only.
    - `[DisplayName <String>]`: The display name for the workload. Required. Read-only.
    - `[OffboardedDateTime <DateTime?>]`: The date and time the workload was offboarded. Optional. Read-only.
    - `[OnboardedDateTime <DateTime?>]`: The date and time the workload was onboarded. Optional. Read-only.
    - `[OnboardingStatus <String>]`: workloadOnboardingStatus

## RELATED LINKS

