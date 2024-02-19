---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.managedtenants/update-mgbetatenantrelationshipmanagedtenantcloudpcoverview
schema: 2.0.0
---

# Update-MgBetaTenantRelationshipManagedTenantCloudPcOverview

## SYNOPSIS
Update the navigation property cloudPcsOverview in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTenantRelationshipManagedTenantCloudPcOverview -CloudPcOverviewTenantId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-LastRefreshedDateTime <DateTime>]
 [-NumberOfCloudPcConnectionStatusFailed <Int32>] [-NumberOfCloudPcConnectionStatusPassed <Int32>]
 [-NumberOfCloudPcConnectionStatusPending <Int32>] [-NumberOfCloudPcConnectionStatusRunning <Int32>]
 [-NumberOfCloudPcConnectionStatusUnkownFutureValue <Int32>] [-NumberOfCloudPcStatusDeprovisioning <Int32>]
 [-NumberOfCloudPcStatusFailed <Int32>] [-NumberOfCloudPcStatusInGracePeriod <Int32>]
 [-NumberOfCloudPcStatusNotProvisioned <Int32>] [-NumberOfCloudPcStatusProvisioned <Int32>]
 [-NumberOfCloudPcStatusProvisioning <Int32>] [-NumberOfCloudPcStatusUnknown <Int32>]
 [-NumberOfCloudPcStatusUpgrading <Int32>] [-TenantDisplayName <String>] [-TenantId <String>]
 [-TotalBusinessLicenses <Int32>] [-TotalCloudPcConnectionStatus <Int32>] [-TotalCloudPcStatus <Int32>]
 [-TotalEnterpriseLicenses <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaTenantRelationshipManagedTenantCloudPcOverview -CloudPcOverviewTenantId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsCloudPcOverview> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaTenantRelationshipManagedTenantCloudPcOverview -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsCloudPcOverview> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaTenantRelationshipManagedTenantCloudPcOverview -InputObject <IManagedTenantsIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-LastRefreshedDateTime <DateTime>]
 [-NumberOfCloudPcConnectionStatusFailed <Int32>] [-NumberOfCloudPcConnectionStatusPassed <Int32>]
 [-NumberOfCloudPcConnectionStatusPending <Int32>] [-NumberOfCloudPcConnectionStatusRunning <Int32>]
 [-NumberOfCloudPcConnectionStatusUnkownFutureValue <Int32>] [-NumberOfCloudPcStatusDeprovisioning <Int32>]
 [-NumberOfCloudPcStatusFailed <Int32>] [-NumberOfCloudPcStatusInGracePeriod <Int32>]
 [-NumberOfCloudPcStatusNotProvisioned <Int32>] [-NumberOfCloudPcStatusProvisioned <Int32>]
 [-NumberOfCloudPcStatusProvisioning <Int32>] [-NumberOfCloudPcStatusUnknown <Int32>]
 [-NumberOfCloudPcStatusUpgrading <Int32>] [-TenantDisplayName <String>] [-TenantId <String>]
 [-TotalBusinessLicenses <Int32>] [-TotalCloudPcConnectionStatus <Int32>] [-TotalCloudPcStatus <Int32>]
 [-TotalEnterpriseLicenses <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property cloudPcsOverview in tenantRelationships

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
cloudPcOverview
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsCloudPcOverview
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CloudPcOverviewTenantId
The unique identifier of cloudPcOverview

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

### -NumberOfCloudPcConnectionStatusFailed
The number of cloud PC connections that have a status of failed.
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

### -NumberOfCloudPcConnectionStatusPassed
The number of cloud PC connections that have a status of passed.
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

### -NumberOfCloudPcConnectionStatusPending
The number of cloud PC connections that have a status of pending.
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

### -NumberOfCloudPcConnectionStatusRunning
The number of cloud PC connections that have a status of running.
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

### -NumberOfCloudPcConnectionStatusUnkownFutureValue
The number of cloud PC connections that have a status of unknownFutureValue.
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

### -NumberOfCloudPcStatusDeprovisioning
The number of cloud PCs that have a status of deprovisioning.
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

### -NumberOfCloudPcStatusFailed
The number of cloud PCs that have a status of failed.
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

### -NumberOfCloudPcStatusInGracePeriod
The number of cloud PCs that have a status of inGracePeriod.
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

### -NumberOfCloudPcStatusNotProvisioned
The number of cloud PCs that have a status of notProvisioned.
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

### -NumberOfCloudPcStatusProvisioned
The number of cloud PCs that have a status of provisioned.
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

### -NumberOfCloudPcStatusProvisioning
The number of cloud PCs that have a status of provisioning.
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

### -NumberOfCloudPcStatusUnknown
The number of cloud PCs that have a status of unknown.
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

### -NumberOfCloudPcStatusUpgrading
The number of cloud PCs that have a status of upgrading.
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

### -TenantId
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

### -TotalBusinessLicenses
The total number of cloud PC devices that have the Business SKU.
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

### -TotalCloudPcConnectionStatus
The total number of cloud PC connection statuses for the given managed tenant.
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

### -TotalCloudPcStatus
The total number of cloud PC statues for the given managed tenant.
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

### -TotalEnterpriseLicenses
The total number of cloud PC devices that have the Enterprise SKU.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsCloudPcOverview

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsCloudPcOverview

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphManagedTenantsCloudPcOverview>`: cloudPcOverview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[LastRefreshedDateTime <DateTime?>]`: Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.
  - `[NumberOfCloudPcConnectionStatusFailed <Int32?>]`: The number of cloud PC connections that have a status of failed. Optional. Read-only.
  - `[NumberOfCloudPcConnectionStatusPassed <Int32?>]`: The number of cloud PC connections that have a status of passed. Optional. Read-only.
  - `[NumberOfCloudPcConnectionStatusPending <Int32?>]`: The number of cloud PC connections that have a status of pending. Optional. Read-only.
  - `[NumberOfCloudPcConnectionStatusRunning <Int32?>]`: The number of cloud PC connections that have a status of running. Optional. Read-only.
  - `[NumberOfCloudPcConnectionStatusUnkownFutureValue <Int32?>]`: The number of cloud PC connections that have a status of unknownFutureValue. Optional. Read-only.
  - `[NumberOfCloudPcStatusDeprovisioning <Int32?>]`: The number of cloud PCs that have a status of deprovisioning. Optional. Read-only.
  - `[NumberOfCloudPcStatusFailed <Int32?>]`: The number of cloud PCs that have a status of failed. Optional. Read-only.
  - `[NumberOfCloudPcStatusInGracePeriod <Int32?>]`: The number of cloud PCs that have a status of inGracePeriod. Optional. Read-only.
  - `[NumberOfCloudPcStatusNotProvisioned <Int32?>]`: The number of cloud PCs that have a status of notProvisioned. Optional. Read-only.
  - `[NumberOfCloudPcStatusProvisioned <Int32?>]`: The number of cloud PCs that have a status of provisioned. Optional. Read-only.
  - `[NumberOfCloudPcStatusProvisioning <Int32?>]`: The number of cloud PCs that have a status of provisioning. Optional. Read-only.
  - `[NumberOfCloudPcStatusUnknown <Int32?>]`: The number of cloud PCs that have a status of unknown. Optional. Read-only.
  - `[NumberOfCloudPcStatusUpgrading <Int32?>]`: The number of cloud PCs that have a status of upgrading. Optional. Read-only.
  - `[TenantDisplayName <String>]`: The display name for the managed tenant. Optional. Read-only.
  - `[TenantId <String>]`: 
  - `[TotalBusinessLicenses <Int32?>]`: The total number of cloud PC devices that have the Business SKU. Optional. Read-only.
  - `[TotalCloudPcConnectionStatus <Int32?>]`: The total number of cloud PC connection statuses for the given managed tenant. Optional. Read-only.
  - `[TotalCloudPcStatus <Int32?>]`: The total number of cloud PC statues for the given managed tenant. Optional. Read-only.
  - `[TotalEnterpriseLicenses <Int32?>]`: The total number of cloud PC devices that have the Enterprise SKU. Optional. Read-only.

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

