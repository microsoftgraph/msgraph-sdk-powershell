---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/update-mgtenantrelationshipmanagedtenantappperformance
schema: 2.0.0
---

# Update-MgTenantRelationshipManagedTenantAppPerformance

## SYNOPSIS
Update the navigation property appPerformances in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTenantRelationshipManagedTenantAppPerformance -AppPerformanceId <String>
 [-AdditionalProperties <Hashtable>] [-AppFriendlyName <String>] [-AppName <String>] [-AppPublisher <String>]
 [-Id <String>] [-LastUpdatedDateTime <DateTime>] [-MeanTimeToFailureInMinutes <Int32>]
 [-TenantDisplayName <String>] [-TenantId <String>] [-TotalActiveDeviceCount <Int32>]
 [-TotalAppCrashCount <Int32>] [-TotalAppFreezeCount <Int32>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgTenantRelationshipManagedTenantAppPerformance -AppPerformanceId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsAppPerformance> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTenantRelationshipManagedTenantAppPerformance -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsAppPerformance> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTenantRelationshipManagedTenantAppPerformance -InputObject <IManagedTenantsIdentity>
 [-AdditionalProperties <Hashtable>] [-AppFriendlyName <String>] [-AppName <String>] [-AppPublisher <String>]
 [-Id <String>] [-LastUpdatedDateTime <DateTime>] [-MeanTimeToFailureInMinutes <Int32>]
 [-TenantDisplayName <String>] [-TenantId <String>] [-TotalActiveDeviceCount <Int32>]
 [-TotalAppCrashCount <Int32>] [-TotalAppFreezeCount <Int32>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property appPerformances in tenantRelationships

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

### -AppFriendlyName
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

### -AppName
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

### -AppPerformanceId
The unique identifier of appPerformance

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

### -AppPublisher
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

### -BodyParameter
appPerformance
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsAppPerformance
Parameter Sets: Update, UpdateViaIdentity
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
.

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

### -MeanTimeToFailureInMinutes
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

### -TotalActiveDeviceCount
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

### -TotalAppCrashCount
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

### -TotalAppFreezeCount
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsAppPerformance

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsAppPerformance>: appPerformance
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppFriendlyName <String>]`: 
  - `[AppName <String>]`: 
  - `[AppPublisher <String>]`: 
  - `[LastUpdatedDateTime <DateTime?>]`: 
  - `[MeanTimeToFailureInMinutes <Int32?>]`: 
  - `[TenantDisplayName <String>]`: 
  - `[TenantId <String>]`: 
  - `[TotalActiveDeviceCount <Int32?>]`: 
  - `[TotalAppCrashCount <Int32?>]`: 
  - `[TotalAppFreezeCount <Int32?>]`: 

INPUTOBJECT <IManagedTenantsIdentity>: Identity Parameter
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

