---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.managedtenants/update-mgbetatenantrelationshipmanagedtenantcredentialuserregistrationsummary
schema: 2.0.0
---

# Update-MgBetaTenantRelationshipManagedTenantCredentialUserRegistrationSummary

## SYNOPSIS
Update the navigation property credentialUserRegistrationsSummaries in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTenantRelationshipManagedTenantCredentialUserRegistrationSummary
 -CredentialUserRegistrationsSummaryId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-LastRefreshedDateTime <DateTime>] [-MfaAndSsprCapableUserCount <Int32>]
 [-MfaConditionalAccessPolicyState <String>] [-MfaExcludedUserCount <Int32>] [-MfaRegisteredUserCount <Int32>]
 [-ResponseHeadersVariable <String>] [-SecurityDefaultsEnabled] [-SsprEnabledUserCount <Int32>]
 [-SsprRegisteredUserCount <Int32>] [-TenantDisplayName <String>] [-TenantId <String>]
 [-TenantLicenseType <String>] [-TotalUserCount <Int32>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaTenantRelationshipManagedTenantCredentialUserRegistrationSummary
 -CredentialUserRegistrationsSummaryId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaTenantRelationshipManagedTenantCredentialUserRegistrationSummary
 -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaTenantRelationshipManagedTenantCredentialUserRegistrationSummary
 -InputObject <IManagedTenantsIdentity> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-LastRefreshedDateTime <DateTime>] [-MfaAndSsprCapableUserCount <Int32>]
 [-MfaConditionalAccessPolicyState <String>] [-MfaExcludedUserCount <Int32>] [-MfaRegisteredUserCount <Int32>]
 [-ResponseHeadersVariable <String>] [-SecurityDefaultsEnabled] [-SsprEnabledUserCount <Int32>]
 [-SsprRegisteredUserCount <Int32>] [-TenantDisplayName <String>] [-TenantId <String>]
 [-TenantLicenseType <String>] [-TotalUserCount <Int32>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property credentialUserRegistrationsSummaries in tenantRelationships

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
credentialUserRegistrationsSummary
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CredentialUserRegistrationsSummaryId
The unique identifier of credentialUserRegistrationsSummary

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

### -LastRefreshedDateTime
Date and time the entity was last updated in the multi-tenant management platform.
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

### -MfaAndSsprCapableUserCount
The number of users that are capable of performing multi-factor authentication or self service password reset.
Optional.
Read-only.

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

### -MfaConditionalAccessPolicyState
The state of a conditional access policy that enforces multi-factor authentication.
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

### -MfaExcludedUserCount
The number of users in the multi-factor authentication exclusion security group (Microsoft 365 Lighthouse - MFA exclusions).
Optional.
Read-only.

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

### -MfaRegisteredUserCount
The number of users registered for multi-factor authentication.
Optional.
Read-only.

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

### -SecurityDefaultsEnabled
A flag indicating whether Identity Security Defaults is enabled.
Optional.
Read-only.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SsprEnabledUserCount
The number of users enabled for self service password reset.
Optional.
Read-only.

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

### -SsprRegisteredUserCount
The number of users registered for self service password reset.
Optional.
Read-only.

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

### -TenantDisplayName
The display name for the managed tenant.
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
The Microsoft Entra tenant identifier for the managed tenant.
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

### -TenantLicenseType
The license type associated with the tenant; for example, AADFree, AADPremium1, AADPremium2.

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

### -TotalUserCount
The total number of users in the given managed tenant.
Optional.
Read-only.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphManagedTenantsCredentialUserRegistrationsSummary>`: credentialUserRegistrationsSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[LastRefreshedDateTime <DateTime?>]`: Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.
  - `[MfaAndSsprCapableUserCount <Int32?>]`: The number of users that are capable of performing multi-factor authentication or self service password reset. Optional. Read-only.
  - `[MfaConditionalAccessPolicyState <String>]`: The state of a conditional access policy that enforces multi-factor authentication. Optional. Read-only.
  - `[MfaExcludedUserCount <Int32?>]`: The number of users in the multi-factor authentication exclusion security group (Microsoft 365 Lighthouse - MFA exclusions). Optional. Read-only.
  - `[MfaRegisteredUserCount <Int32?>]`: The number of users registered for multi-factor authentication. Optional. Read-only.
  - `[SecurityDefaultsEnabled <Boolean?>]`: A flag indicating whether Identity Security Defaults is enabled. Optional. Read-only.
  - `[SsprEnabledUserCount <Int32?>]`: The number of users enabled for self service password reset. Optional. Read-only.
  - `[SsprRegisteredUserCount <Int32?>]`: The number of users registered for self service password reset. Optional. Read-only.
  - `[TenantDisplayName <String>]`: The display name for the managed tenant. Required. Read-only.
  - `[TenantId <String>]`: The Microsoft Entra tenant identifier for the managed tenant. Required. Read-only.
  - `[TenantLicenseType <String>]`: The license type associated with the tenant; for example, AADFree, AADPremium1, AADPremium2.
  - `[TotalUserCount <Int32?>]`: The total number of users in the given managed tenant. Optional. Read-only.

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

## RELATED LINKS

