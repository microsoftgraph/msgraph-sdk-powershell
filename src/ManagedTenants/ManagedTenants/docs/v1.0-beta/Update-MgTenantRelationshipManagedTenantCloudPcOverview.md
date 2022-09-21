---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/update-mgtenantrelationshipmanagedtenantcloudpcoverview
schema: 2.0.0
---

# Update-MgTenantRelationshipManagedTenantCloudPcOverview

## SYNOPSIS
Update the navigation property cloudPcsOverview in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTenantRelationshipManagedTenantCloudPcOverview -CloudPcOverviewTenantId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-LastRefreshedDateTime <DateTime>]
 [-NumberOfCloudPcConnectionStatusFailed <Int32>] [-NumberOfCloudPcConnectionStatusPassed <Int32>]
 [-NumberOfCloudPcConnectionStatusPending <Int32>] [-NumberOfCloudPcConnectionStatusRunning <Int32>]
 [-NumberOfCloudPcConnectionStatusUnkownFutureValue <Int32>] [-NumberOfCloudPcStatusDeprovisioning <Int32>]
 [-NumberOfCloudPcStatusFailed <Int32>] [-NumberOfCloudPcStatusInGracePeriod <Int32>]
 [-NumberOfCloudPcStatusNotProvisioned <Int32>] [-NumberOfCloudPcStatusProvisioned <Int32>]
 [-NumberOfCloudPcStatusProvisioning <Int32>] [-NumberOfCloudPcStatusUnknown <Int32>]
 [-NumberOfCloudPcStatusUpgrading <Int32>] [-TenantDisplayName <String>] [-TenantId <String>]
 [-TotalBusinessLicenses <Int32>] [-TotalCloudPcConnectionStatus <Int32>] [-TotalCloudPcStatus <Int32>]
 [-TotalEnterpriseLicenses <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTenantRelationshipManagedTenantCloudPcOverview -CloudPcOverviewTenantId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsCloudPcOverview> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTenantRelationshipManagedTenantCloudPcOverview -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsCloudPcOverview> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTenantRelationshipManagedTenantCloudPcOverview -InputObject <IManagedTenantsIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-LastRefreshedDateTime <DateTime>]
 [-NumberOfCloudPcConnectionStatusFailed <Int32>] [-NumberOfCloudPcConnectionStatusPassed <Int32>]
 [-NumberOfCloudPcConnectionStatusPending <Int32>] [-NumberOfCloudPcConnectionStatusRunning <Int32>]
 [-NumberOfCloudPcConnectionStatusUnkownFutureValue <Int32>] [-NumberOfCloudPcStatusDeprovisioning <Int32>]
 [-NumberOfCloudPcStatusFailed <Int32>] [-NumberOfCloudPcStatusInGracePeriod <Int32>]
 [-NumberOfCloudPcStatusNotProvisioned <Int32>] [-NumberOfCloudPcStatusProvisioned <Int32>]
 [-NumberOfCloudPcStatusProvisioning <Int32>] [-NumberOfCloudPcStatusUnknown <Int32>]
 [-NumberOfCloudPcStatusUpgrading <Int32>] [-TenantDisplayName <String>] [-TenantId <String>]
 [-TotalBusinessLicenses <Int32>] [-TotalCloudPcConnectionStatus <Int32>] [-TotalCloudPcStatus <Int32>]
 [-TotalEnterpriseLicenses <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property cloudPcsOverview in tenantRelationships

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
cloudPcOverview
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsCloudPcOverview
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CloudPcOverviewTenantId
key: tenantId of cloudPcOverview

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsCloudPcOverview

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsCloudPcOverview>: cloudPcOverview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
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
  - `[TotalBusinessLicenses <Int32?>]`: 
  - `[TotalCloudPcConnectionStatus <Int32?>]`: The total number of cloud PC connection statuses for the given managed tenant. Optional. Read-only.
  - `[TotalCloudPcStatus <Int32?>]`: The total number of cloud PC statues for the given managed tenant. Optional. Read-only.
  - `[TotalEnterpriseLicenses <Int32?>]`: 

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

## RELATED LINKS

