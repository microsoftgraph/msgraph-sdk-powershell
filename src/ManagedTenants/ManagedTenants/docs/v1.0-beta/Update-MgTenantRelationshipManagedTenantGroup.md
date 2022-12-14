---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/update-mgtenantrelationshipmanagedtenantgroup
schema: 2.0.0
---

# Update-MgTenantRelationshipManagedTenantGroup

## SYNOPSIS
Update the navigation property tenantGroups in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTenantRelationshipManagedTenantGroup -TenantGroupId <String> [-AdditionalProperties <Hashtable>]
 [-AllTenantsIncluded] [-DisplayName <String>] [-Id <String>]
 [-ManagementActions <IMicrosoftGraphManagedTenantsManagementActionInfo[]>]
 [-ManagementIntents <IMicrosoftGraphManagedTenantsManagementIntentInfo[]>] [-TenantIds <String[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTenantRelationshipManagedTenantGroup -TenantGroupId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsTenantGroup> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTenantRelationshipManagedTenantGroup -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsTenantGroup> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTenantRelationshipManagedTenantGroup -InputObject <IManagedTenantsIdentity>
 [-AdditionalProperties <Hashtable>] [-AllTenantsIncluded] [-DisplayName <String>] [-Id <String>]
 [-ManagementActions <IMicrosoftGraphManagedTenantsManagementActionInfo[]>]
 [-ManagementIntents <IMicrosoftGraphManagedTenantsManagementIntentInfo[]>] [-TenantIds <String[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property tenantGroups in tenantRelationships

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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantGroup
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

### -ManagementActions
The collection of management action associated with the tenant group.
Optional.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for MANAGEMENTACTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementActionInfo[]
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
To construct, please use Get-Help -Online and see NOTES section for MANAGEMENTINTENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementIntentInfo[]
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

### -TenantGroupId
key: id of tenantGroup

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

### Microsoft.Graph.PowerShell.Models.IManagedTenantsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantGroup

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsTenantGroup>: tenantGroup
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

MANAGEMENTACTIONS <IMicrosoftGraphManagedTenantsManagementActionInfo[]>: The collection of management action associated with the tenant group. Optional. Read-only.
  - `[ManagementActionId <String>]`: The identifier for the management action. Required. Read-only.
  - `[ManagementTemplateId <String>]`: The identifier for the management template. Required. Read-only.
  - `[ManagementTemplateVersion <Int32?>]`: 

MANAGEMENTINTENTS <IMicrosoftGraphManagedTenantsManagementIntentInfo[]>: The collection of management intents associated with the tenant group. Optional. Read-only.
  - `[ManagementIntentDisplayName <String>]`: The display name for the management intent. Optional. Read-only.
  - `[ManagementIntentId <String>]`: The identifier for the management intent. Required. Read-only.
  - `[ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplateDetailedInfo[]>]`: The collection of management template information associated with the management intent. Optional. Read-only.
    - `[Category <String>]`: managementCategory
    - `[DisplayName <String>]`: The display name for the management template. Required. Read-only.
    - `[ManagementTemplateId <String>]`: The unique identifier for the management template. Required. Read-only.
    - `[Version <Int32?>]`: 

## RELATED LINKS

