---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/new-mgtenantrelationshipmanagedtenantmanagementtemplatestepversiondeployment
schema: 2.0.0
---

# New-MgTenantRelationshipManagedTenantManagementTemplateStepVersionDeployment

## SYNOPSIS
Create new navigation property to deployments for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgTenantRelationshipManagedTenantManagementTemplateStepVersionDeployment
 -ManagementTemplateStepVersionId <String> [-AdditionalProperties <Hashtable>] [-CreatedByUserId <String>]
 [-CreatedDateTime <DateTime>] [-Error <IMicrosoftGraphManagedTenantsGraphApiErrorDetails>] [-Id <String>]
 [-LastActionByUserId <String>] [-LastActionDateTime <DateTime>] [-Status <String>]
 [-TemplateStepVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>] [-TenantId <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgTenantRelationshipManagedTenantManagementTemplateStepVersionDeployment
 -ManagementTemplateStepVersionId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementTemplateStepDeployment> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgTenantRelationshipManagedTenantManagementTemplateStepVersionDeployment
 -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementTemplateStepDeployment> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgTenantRelationshipManagedTenantManagementTemplateStepVersionDeployment
 -InputObject <IManagedTenantsIdentity> [-AdditionalProperties <Hashtable>] [-CreatedByUserId <String>]
 [-CreatedDateTime <DateTime>] [-Error <IMicrosoftGraphManagedTenantsGraphApiErrorDetails>] [-Id <String>]
 [-LastActionByUserId <String>] [-LastActionDateTime <DateTime>] [-Status <String>]
 [-TemplateStepVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>] [-TenantId <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deployments for tenantRelationships

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
managementTemplateStepDeployment
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateStepDeployment
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedByUserId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Error
graphAPIErrorDetails
To construct, please use Get-Help -Online and see NOTES section for ERROR properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsGraphApiErrorDetails
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastActionByUserId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastActionDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementTemplateStepVersionId
key: id of managementTemplateStepVersion

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
managementTemplateDeploymentStatus

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateStepVersion
managementTemplateStepVersion
To construct, please use Get-Help -Online and see NOTES section for TEMPLATESTEPVERSION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateStepVersion
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateStepDeployment

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateStepDeployment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsManagementTemplateStepDeployment>: managementTemplateStepDeployment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Error <IMicrosoftGraphManagedTenantsGraphApiErrorDetails>]`: graphAPIErrorDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <String>]`: 
    - `[Message <String>]`: 
  - `[LastActionByUserId <String>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[Status <String>]`: managementTemplateDeploymentStatus
  - `[TemplateStepVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>]`: managementTemplateStepVersion
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AcceptedFor <IMicrosoftGraphManagedTenantsManagementTemplateStep>]`: managementTemplateStep
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AcceptedVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>]`: managementTemplateStepVersion
      - `[Category <String>]`: managementCategory
      - `[CreatedByUserId <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastActionByUserId <String>]`: 
      - `[LastActionDateTime <DateTime?>]`: 
      - `[ManagementTemplate <IMicrosoftGraphManagedTenantsManagementTemplate>]`: managementTemplate
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Category <String>]`: managementCategory
        - `[CreatedByUserId <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[Description <String>]`: The description for the management template. Optional. Read-only.
        - `[DisplayName <String>]`: The display name for the management template. Required. Read-only.
        - `[InformationLinks <IMicrosoftGraphActionUrl[]>]`: 
          - `[DisplayName <String>]`: 
          - `[Url <String>]`: 
        - `[LastActionByUserId <String>]`: 
        - `[LastActionDateTime <DateTime?>]`: 
        - `[ManagementTemplateCollections <IMicrosoftGraphManagedTenantsManagementTemplateCollection[]>]`: 
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
          - `[CreatedByUserId <String>]`: 
          - `[CreatedDateTime <DateTime?>]`: 
          - `[Description <String>]`: 
          - `[DisplayName <String>]`: 
          - `[LastActionByUserId <String>]`: 
          - `[LastActionDateTime <DateTime?>]`: 
          - `[ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplate[]>]`: 
        - `[ManagementTemplateSteps <IMicrosoftGraphManagedTenantsManagementTemplateStep[]>]`: 
        - `[Parameters <IMicrosoftGraphManagedTenantsTemplateParameter[]>]`: The collection of parameters used by the management template. Optional. Read-only.
          - `[Description <String>]`: The description for the template parameter. Optional. Read-only.
          - `[DisplayName <String>]`: The display name for the template parameter. Required. Read-only.
          - `[JsonAllowedValues <String>]`: The allowed values for the template parameter represented by a serialized string of JSON. Optional. Read-only.
          - `[JsonDefaultValue <String>]`: The default value for the template parameter represented by a serialized string of JSON. Required. Read-only.
          - `[ValueType <String>]`: managementParameterValueType
        - `[Priority <Int32?>]`: 
        - `[Provider <String>]`: managementProvider
        - `[UserImpact <String>]`: 
        - `[Version <Int32?>]`: 
        - `[WorkloadActions <IMicrosoftGraphManagedTenantsWorkloadAction[]>]`: The collection of workload actions associated with the management template. Optional. Read-only.
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
      - `[PortalLink <IMicrosoftGraphActionUrl>]`: actionUrl
      - `[Priority <Int32?>]`: 
      - `[Versions <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion[]>]`: 
    - `[ContentMarkdown <String>]`: 
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Deployments <IMicrosoftGraphManagedTenantsManagementTemplateStepDeployment[]>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[Name <String>]`: 
    - `[TemplateStep <IMicrosoftGraphManagedTenantsManagementTemplateStep>]`: managementTemplateStep
    - `[Version <Int32?>]`: 
    - `[VersionInformation <String>]`: 
  - `[TenantId <String>]`: 

ERROR <IMicrosoftGraphManagedTenantsGraphApiErrorDetails>: graphAPIErrorDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Code <String>]`: 
  - `[Message <String>]`: 

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

TEMPLATESTEPVERSION <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>: managementTemplateStepVersion
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AcceptedFor <IMicrosoftGraphManagedTenantsManagementTemplateStep>]`: managementTemplateStep
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AcceptedVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>]`: managementTemplateStepVersion
    - `[Category <String>]`: managementCategory
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[ManagementTemplate <IMicrosoftGraphManagedTenantsManagementTemplate>]`: managementTemplate
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Category <String>]`: managementCategory
      - `[CreatedByUserId <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: The description for the management template. Optional. Read-only.
      - `[DisplayName <String>]`: The display name for the management template. Required. Read-only.
      - `[InformationLinks <IMicrosoftGraphActionUrl[]>]`: 
        - `[DisplayName <String>]`: 
        - `[Url <String>]`: 
      - `[LastActionByUserId <String>]`: 
      - `[LastActionDateTime <DateTime?>]`: 
      - `[ManagementTemplateCollections <IMicrosoftGraphManagedTenantsManagementTemplateCollection[]>]`: 
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[CreatedByUserId <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[LastActionByUserId <String>]`: 
        - `[LastActionDateTime <DateTime?>]`: 
        - `[ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplate[]>]`: 
      - `[ManagementTemplateSteps <IMicrosoftGraphManagedTenantsManagementTemplateStep[]>]`: 
      - `[Parameters <IMicrosoftGraphManagedTenantsTemplateParameter[]>]`: The collection of parameters used by the management template. Optional. Read-only.
        - `[Description <String>]`: The description for the template parameter. Optional. Read-only.
        - `[DisplayName <String>]`: The display name for the template parameter. Required. Read-only.
        - `[JsonAllowedValues <String>]`: The allowed values for the template parameter represented by a serialized string of JSON. Optional. Read-only.
        - `[JsonDefaultValue <String>]`: The default value for the template parameter represented by a serialized string of JSON. Required. Read-only.
        - `[ValueType <String>]`: managementParameterValueType
      - `[Priority <Int32?>]`: 
      - `[Provider <String>]`: managementProvider
      - `[UserImpact <String>]`: 
      - `[Version <Int32?>]`: 
      - `[WorkloadActions <IMicrosoftGraphManagedTenantsWorkloadAction[]>]`: The collection of workload actions associated with the management template. Optional. Read-only.
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
    - `[PortalLink <IMicrosoftGraphActionUrl>]`: actionUrl
    - `[Priority <Int32?>]`: 
    - `[Versions <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion[]>]`: 
  - `[ContentMarkdown <String>]`: 
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Deployments <IMicrosoftGraphManagedTenantsManagementTemplateStepDeployment[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Error <IMicrosoftGraphManagedTenantsGraphApiErrorDetails>]`: graphAPIErrorDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: 
      - `[Message <String>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[Status <String>]`: managementTemplateDeploymentStatus
    - `[TemplateStepVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>]`: managementTemplateStepVersion
    - `[TenantId <String>]`: 
  - `[LastActionByUserId <String>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[Name <String>]`: 
  - `[TemplateStep <IMicrosoftGraphManagedTenantsManagementTemplateStep>]`: managementTemplateStep
  - `[Version <Int32?>]`: 
  - `[VersionInformation <String>]`: 

## RELATED LINKS

