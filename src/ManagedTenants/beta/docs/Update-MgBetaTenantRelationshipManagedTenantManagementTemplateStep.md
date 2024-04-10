---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.managedtenants/update-mgbetatenantrelationshipmanagedtenantmanagementtemplatestep
schema: 2.0.0
---

# Update-MgBetaTenantRelationshipManagedTenantManagementTemplateStep

## SYNOPSIS
Update the navigation property managementTemplateSteps in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTenantRelationshipManagedTenantManagementTemplateStep -ManagementTemplateStepId <String>
 [-AcceptedVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>]
 [-AdditionalProperties <Hashtable>] [-Category <String>] [-CreatedByUserId <String>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-InformationLinks <IMicrosoftGraphActionUrl[]>] [-LastActionByUserId <String>]
 [-LastActionDateTime <DateTime>] [-ManagementTemplate <IMicrosoftGraphManagedTenantsManagementTemplate>]
 [-PortalLink <IMicrosoftGraphActionUrl>] [-Priority <Int32>] [-ResponseHeadersVariable <String>]
 [-UserImpact <String>] [-Versions <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion[]>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaTenantRelationshipManagedTenantManagementTemplateStep -ManagementTemplateStepId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementTemplateStep> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaTenantRelationshipManagedTenantManagementTemplateStep -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementTemplateStep> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaTenantRelationshipManagedTenantManagementTemplateStep -InputObject <IManagedTenantsIdentity>
 [-AcceptedVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>]
 [-AdditionalProperties <Hashtable>] [-Category <String>] [-CreatedByUserId <String>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-InformationLinks <IMicrosoftGraphActionUrl[]>] [-LastActionByUserId <String>]
 [-LastActionDateTime <DateTime>] [-ManagementTemplate <IMicrosoftGraphManagedTenantsManagementTemplate>]
 [-PortalLink <IMicrosoftGraphActionUrl>] [-Priority <Int32>] [-ResponseHeadersVariable <String>]
 [-UserImpact <String>] [-Versions <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion[]>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property managementTemplateSteps in tenantRelationships

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

### -AcceptedVersion
managementTemplateStepVersion
To construct, see NOTES section for ACCEPTEDVERSION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateStepVersion
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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
managementTemplateStep
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateStep
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

### -CreatedByUserId
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

### -CreatedDateTime
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

### -Description
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

### -DisplayName
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

### -InformationLinks
.
To construct, see NOTES section for INFORMATIONLINKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphActionUrl[]
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

### -LastActionByUserId
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

### -LastActionDateTime
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

### -ManagementTemplate
managementTemplate
To construct, see NOTES section for MANAGEMENTTEMPLATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplate
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementTemplateStepId
The unique identifier of managementTemplateStep

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

### -PortalLink
actionUrl
To construct, see NOTES section for PORTALLINK properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphActionUrl
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
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

### -UserImpact
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

### -Versions
.
To construct, see NOTES section for VERSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateStepVersion[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateStep

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateStep

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACCEPTEDVERSION <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>`: managementTemplateStepVersion
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
    - `[InformationLinks <IMicrosoftGraphActionUrl[]>]`: 
      - `[DisplayName <String>]`: Brief title for the page that the links directs to.
      - `[Url <String>]`: The URL to the documentation or Microsoft Entra admin center page.
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
    - `[UserImpact <String>]`: 
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

`BODYPARAMETER <IMicrosoftGraphManagedTenantsManagementTemplateStep>`: managementTemplateStep
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AcceptedVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>]`: managementTemplateStepVersion
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AcceptedFor <IMicrosoftGraphManagedTenantsManagementTemplateStep>]`: managementTemplateStep
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
  - `[Category <String>]`: managementCategory
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[InformationLinks <IMicrosoftGraphActionUrl[]>]`: 
    - `[DisplayName <String>]`: Brief title for the page that the links directs to.
    - `[Url <String>]`: The URL to the documentation or Microsoft Entra admin center page.
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
  - `[UserImpact <String>]`: 
  - `[Versions <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion[]>]`: 

`INFORMATIONLINKS <IMicrosoftGraphActionUrl[]>`: .
  - `[DisplayName <String>]`: Brief title for the page that the links directs to.
  - `[Url <String>]`: The URL to the documentation or Microsoft Entra admin center page.

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

`MANAGEMENTTEMPLATE <IMicrosoftGraphManagedTenantsManagementTemplate>`: managementTemplate
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Category <String>]`: managementCategory
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: The description for the management template. Optional. Read-only.
  - `[DisplayName <String>]`: The display name for the management template. Required. Read-only.
  - `[InformationLinks <IMicrosoftGraphActionUrl[]>]`: 
    - `[DisplayName <String>]`: Brief title for the page that the links directs to.
    - `[Url <String>]`: The URL to the documentation or Microsoft Entra admin center page.
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
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AcceptedVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>]`: managementTemplateStepVersion
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AcceptedFor <IMicrosoftGraphManagedTenantsManagementTemplateStep>]`: managementTemplateStep
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
    - `[Category <String>]`: managementCategory
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[InformationLinks <IMicrosoftGraphActionUrl[]>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[ManagementTemplate <IMicrosoftGraphManagedTenantsManagementTemplate>]`: managementTemplate
    - `[PortalLink <IMicrosoftGraphActionUrl>]`: actionUrl
    - `[Priority <Int32?>]`: 
    - `[UserImpact <String>]`: 
    - `[Versions <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion[]>]`: 
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

`PORTALLINK <IMicrosoftGraphActionUrl>`: actionUrl
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: Brief title for the page that the links directs to.
  - `[Url <String>]`: The URL to the documentation or Microsoft Entra admin center page.

`VERSIONS <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion[]>`: .
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
    - `[InformationLinks <IMicrosoftGraphActionUrl[]>]`: 
      - `[DisplayName <String>]`: Brief title for the page that the links directs to.
      - `[Url <String>]`: The URL to the documentation or Microsoft Entra admin center page.
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
    - `[UserImpact <String>]`: 
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

