---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.managedtenants/update-mgbetatenantrelationshipmanagedtenant
schema: 2.0.0
---

# Update-MgBetaTenantRelationshipManagedTenant

## SYNOPSIS
Update the navigation property tenants in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTenantRelationshipManagedTenant -TenantId <String> [-AdditionalProperties <Hashtable>]
 [-Contract <IMicrosoftGraphManagedTenantsTenantContract>] [-CreatedDateTime <DateTime>]
 [-DisplayName <String>] [-Id <String>] [-LastUpdatedDateTime <DateTime>] [-ResponseHeadersVariable <String>]
 [-TenantId1 <String>] [-TenantStatusInformation <IMicrosoftGraphManagedTenantsTenantStatusInformation>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaTenantRelationshipManagedTenant -TenantId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsTenant> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaTenantRelationshipManagedTenant -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsTenant> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaTenantRelationshipManagedTenant -InputObject <IManagedTenantsIdentity> [-TenantId <String>]
 [-AdditionalProperties <Hashtable>] [-Contract <IMicrosoftGraphManagedTenantsTenantContract>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>] [-LastUpdatedDateTime <DateTime>]
 [-ResponseHeadersVariable <String>]
 [-TenantStatusInformation <IMicrosoftGraphManagedTenantsTenantStatusInformation>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property tenants in tenantRelationships

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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsTenant
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
To construct, see NOTES section for CONTRACT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantContract
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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
The unique identifier of tenant

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
The Microsoft Entra tenant identifier for the managed tenant.
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
To construct, see NOTES section for TENANTSTATUSINFORMATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantStatusInformation
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsTenant

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsTenant

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphManagedTenantsTenant>`: tenant
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
  - `[TenantId <String>]`: The Microsoft Entra tenant identifier for the managed tenant. Optional. Read-only.
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

`CONTRACT <IMicrosoftGraphManagedTenantsTenantContract>`: tenantContract
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContractType <Int32?>]`: The type of relationship that exists between the managing entity and tenant. Optional. Read-only.
  - `[DefaultDomainName <String>]`: The default domain name for the tenant. Required. Read-only.
  - `[DisplayName <String>]`: The display name for the tenant. Optional. Read-only.

`INPUTOBJECT <IManagedTenantsIdentity>`: Identity Parameter
  - `[AggregatedPolicyComplianceId <String>]`: The unique identifier of aggregatedPolicyCompliance
  - `[AppPerformanceId <String>]`: The unique identifier of appPerformance
  - `[AuditEventId <String>]`: The unique identifier of auditEvent
  - `[CloudPcConnectionId <String>]`: The unique identifier of cloudPcConnection
  - `[CloudPcDeviceId <String>]`: The unique identifier of cloudPcDevice
  - `[CloudPcOverviewTenantId <String>]`: The unique identifier of cloudPcOverview
  - `[ConditionalAccessPolicyCoverageId <String>]`: The unique identifier of conditionalAccessPolicyCoverage
  - `[CredentialUserRegistrationsSummaryId <String>]`: The unique identifier of credentialUserRegistrationsSummary
  - `[DeviceAppPerformanceId <String>]`: The unique identifier of deviceAppPerformance
  - `[DeviceCompliancePolicySettingStateSummaryId <String>]`: The unique identifier of deviceCompliancePolicySettingStateSummary
  - `[DeviceHealthStatusId <String>]`: The unique identifier of deviceHealthStatus
  - `[ManagedDeviceComplianceId <String>]`: The unique identifier of managedDeviceCompliance
  - `[ManagedDeviceComplianceTrendId <String>]`: The unique identifier of managedDeviceComplianceTrend
  - `[ManagedTenantAlertId <String>]`: The unique identifier of managedTenantAlert
  - `[ManagedTenantAlertLogId <String>]`: The unique identifier of managedTenantAlertLog
  - `[ManagedTenantAlertRuleDefinitionId <String>]`: The unique identifier of managedTenantAlertRuleDefinition
  - `[ManagedTenantAlertRuleId <String>]`: The unique identifier of managedTenantAlertRule
  - `[ManagedTenantApiNotificationId <String>]`: The unique identifier of managedTenantApiNotification
  - `[ManagedTenantEmailNotificationId <String>]`: The unique identifier of managedTenantEmailNotification
  - `[ManagedTenantTicketingEndpointId <String>]`: The unique identifier of managedTenantTicketingEndpoint
  - `[ManagementActionId <String>]`: The unique identifier of managementAction
  - `[ManagementActionTenantDeploymentStatusId <String>]`: The unique identifier of managementActionTenantDeploymentStatus
  - `[ManagementIntentId <String>]`: The unique identifier of managementIntent
  - `[ManagementTemplateCollectionId <String>]`: The unique identifier of managementTemplateCollection
  - `[ManagementTemplateCollectionTenantSummaryId <String>]`: The unique identifier of managementTemplateCollectionTenantSummary
  - `[ManagementTemplateId <String>]`: The unique identifier of managementTemplate
  - `[ManagementTemplateStepDeploymentId <String>]`: The unique identifier of managementTemplateStepDeployment
  - `[ManagementTemplateStepId <String>]`: The unique identifier of managementTemplateStep
  - `[ManagementTemplateStepTenantSummaryId <String>]`: The unique identifier of managementTemplateStepTenantSummary
  - `[ManagementTemplateStepVersionId <String>]`: The unique identifier of managementTemplateStepVersion
  - `[MyRoleTenantId <String>]`: The unique identifier of myRole
  - `[TenantCustomizedInformationId <String>]`: The unique identifier of tenantCustomizedInformation
  - `[TenantDetailedInformationId <String>]`: The unique identifier of tenantDetailedInformation
  - `[TenantGroupId <String>]`: The unique identifier of tenantGroup
  - `[TenantId <String>]`: The unique identifier of tenant
  - `[TenantTagId <String>]`: The unique identifier of tenantTag
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsProtectionStateId <String>]`: The unique identifier of windowsProtectionState

`TENANTSTATUSINFORMATION <IMicrosoftGraphManagedTenantsTenantStatusInformation>`: tenantStatusInformation
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

