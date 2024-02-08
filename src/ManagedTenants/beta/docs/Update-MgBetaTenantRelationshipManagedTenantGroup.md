---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.managedtenants/update-mgbetatenantrelationshipmanagedtenantgroup
schema: 2.0.0
---

# Update-MgBetaTenantRelationshipManagedTenantGroup

## SYNOPSIS
Update the navigation property tenantGroups in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTenantRelationshipManagedTenantGroup -TenantGroupId <String> [-AdditionalProperties <Hashtable>]
 [-AllTenantsIncluded] [-DisplayName <String>] [-Id <String>]
 [-ManagementActions <IMicrosoftGraphManagedTenantsManagementActionInfo[]>]
 [-ManagementIntents <IMicrosoftGraphManagedTenantsManagementIntentInfo[]>] [-TenantIds <String[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaTenantRelationshipManagedTenantGroup -TenantGroupId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsTenantGroup> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaTenantRelationshipManagedTenantGroup -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsTenantGroup> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaTenantRelationshipManagedTenantGroup -InputObject <IManagedTenantsIdentity>
 [-AdditionalProperties <Hashtable>] [-AllTenantsIncluded] [-DisplayName <String>] [-Id <String>]
 [-ManagementActions <IMicrosoftGraphManagedTenantsManagementActionInfo[]>]
 [-ManagementIntents <IMicrosoftGraphManagedTenantsManagementIntentInfo[]>] [-TenantIds <String[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property tenantGroups in tenantRelationships

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

### -AllTenantsIncluded
A flag indicating whether all managed tenant are included in the tenant group.
Required.
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

### -BodyParameter
tenantGroup
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantGroup
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name for the tenant group.
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

### -ManagementActions
The collection of management action associated with the tenant group.
Optional.
Read-only.
To construct, see NOTES section for MANAGEMENTACTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementActionInfo[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementIntents
The collection of management intents associated with the tenant group.
Optional.
Read-only.
To construct, see NOTES section for MANAGEMENTINTENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementIntentInfo[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantGroupId
The unique identifier of tenantGroup

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

### -TenantIds
The collection of managed tenant identifiers include in the tenant group.
Optional.
Read-only.

```yaml
Type: System.String[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantGroup

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphManagedTenantsTenantGroup>`: tenantGroup
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllTenantsIncluded <Boolean?>]`: A flag indicating whether all managed tenant are included in the tenant group. Required. Read-only.
  - `[DisplayName <String>]`: The display name for the tenant group. Optional. Read-only.
  - `[ManagementActions <IMicrosoftGraphManagedTenantsManagementActionInfo[]>]`: The collection of management action associated with the tenant group. Optional. Read-only.
    - `[ManagementActionId <String>]`: The identifier for the management action. Required. Read-only.
    - `[ManagementTemplateId <String>]`: The identifier for the management template. Required. Read-only.
    - `[ManagementTemplateVersion <Int32?>]`: 
  - `[ManagementIntents <IMicrosoftGraphManagedTenantsManagementIntentInfo[]>]`: The collection of management intents associated with the tenant group. Optional. Read-only.
    - `[ManagementIntentDisplayName <String>]`: The display name for the management intent. Optional. Read-only.
    - `[ManagementIntentId <String>]`: The identifier for the management intent. Required. Read-only.
    - `[ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplateDetailedInfo[]>]`: The collection of management template information associated with the management intent. Optional. Read-only.
      - `[Category <String>]`: managementCategory
      - `[DisplayName <String>]`: The display name for the management template. Required. Read-only.
      - `[ManagementTemplateId <String>]`: The unique identifier for the management template. Required. Read-only.
      - `[Version <Int32?>]`: 
  - `[TenantIds <String[]>]`: The collection of managed tenant identifiers include in the tenant group. Optional. Read-only.

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

`MANAGEMENTACTIONS <IMicrosoftGraphManagedTenantsManagementActionInfo[]>`: The collection of management action associated with the tenant group. Optional. Read-only.
  - `[ManagementActionId <String>]`: The identifier for the management action. Required. Read-only.
  - `[ManagementTemplateId <String>]`: The identifier for the management template. Required. Read-only.
  - `[ManagementTemplateVersion <Int32?>]`: 

`MANAGEMENTINTENTS <IMicrosoftGraphManagedTenantsManagementIntentInfo[]>`: The collection of management intents associated with the tenant group. Optional. Read-only.
  - `[ManagementIntentDisplayName <String>]`: The display name for the management intent. Optional. Read-only.
  - `[ManagementIntentId <String>]`: The identifier for the management intent. Required. Read-only.
  - `[ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplateDetailedInfo[]>]`: The collection of management template information associated with the management intent. Optional. Read-only.
    - `[Category <String>]`: managementCategory
    - `[DisplayName <String>]`: The display name for the management template. Required. Read-only.
    - `[ManagementTemplateId <String>]`: The unique identifier for the management template. Required. Read-only.
    - `[Version <Int32?>]`: 

## RELATED LINKS

