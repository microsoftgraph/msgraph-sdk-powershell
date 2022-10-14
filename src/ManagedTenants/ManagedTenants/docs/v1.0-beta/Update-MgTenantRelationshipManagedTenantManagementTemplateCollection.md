---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/update-mgtenantrelationshipmanagedtenantmanagementtemplatecollection
schema: 2.0.0
---

# Update-MgTenantRelationshipManagedTenantManagementTemplateCollection

## SYNOPSIS
Update the navigation property managementTemplateCollections in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTenantRelationshipManagedTenantManagementTemplateCollection -ManagementTemplateCollectionId <String>
 [-AdditionalProperties <Hashtable>] [-CreatedByUserId <String>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-LastActionByUserId <String>]
 [-LastActionDateTime <DateTime>] [-ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplate[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTenantRelationshipManagedTenantManagementTemplateCollection -ManagementTemplateCollectionId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementTemplateCollection> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTenantRelationshipManagedTenantManagementTemplateCollection -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementTemplateCollection> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTenantRelationshipManagedTenantManagementTemplateCollection -InputObject <IManagedTenantsIdentity>
 [-AdditionalProperties <Hashtable>] [-CreatedByUserId <String>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-LastActionByUserId <String>]
 [-LastActionDateTime <DateTime>] [-ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplate[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property managementTemplateCollections in tenantRelationships

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
managementTemplateCollection
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateCollection
Parameter Sets: Update, UpdateViaIdentity
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

### -ManagementTemplateCollectionId
key: id of managementTemplateCollection

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

### -ManagementTemplates
.
To construct, please use Get-Help -Online and see NOTES section for MANAGEMENTTEMPLATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplate[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateCollection

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsManagementTemplateCollection>: managementTemplateCollection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastActionByUserId <String>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplate[]>]`: 
    - `[Id <String>]`: 
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
    - `[ManagementTemplateSteps <IMicrosoftGraphManagedTenantsManagementTemplateStep[]>]`: 
      - `[Id <String>]`: 
      - `[AcceptedVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>]`: managementTemplateStepVersion
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[AcceptedFor <IMicrosoftGraphManagedTenantsManagementTemplateStep>]`: managementTemplateStep
        - `[ContentMarkdown <String>]`: 
        - `[CreatedByUserId <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[Deployments <IMicrosoftGraphManagedTenantsManagementTemplateStepDeployment[]>]`: 
          - `[Id <String>]`: 
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
      - `[LastActionByUserId <String>]`: 
      - `[LastActionDateTime <DateTime?>]`: 
      - `[ManagementTemplate <IMicrosoftGraphManagedTenantsManagementTemplate>]`: managementTemplate
      - `[PortalLink <IMicrosoftGraphActionUrl>]`: actionUrl
      - `[Priority <Int32?>]`: 
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

MANAGEMENTTEMPLATES <IMicrosoftGraphManagedTenantsManagementTemplate[]>: .
  - `[Id <String>]`: 
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
    - `[Id <String>]`: 
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplate[]>]`: 
  - `[ManagementTemplateSteps <IMicrosoftGraphManagedTenantsManagementTemplateStep[]>]`: 
    - `[Id <String>]`: 
    - `[AcceptedVersion <IMicrosoftGraphManagedTenantsManagementTemplateStepVersion>]`: managementTemplateStepVersion
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[AcceptedFor <IMicrosoftGraphManagedTenantsManagementTemplateStep>]`: managementTemplateStep
      - `[ContentMarkdown <String>]`: 
      - `[CreatedByUserId <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Deployments <IMicrosoftGraphManagedTenantsManagementTemplateStepDeployment[]>]`: 
        - `[Id <String>]`: 
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
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[ManagementTemplate <IMicrosoftGraphManagedTenantsManagementTemplate>]`: managementTemplate
    - `[PortalLink <IMicrosoftGraphActionUrl>]`: actionUrl
    - `[Priority <Int32?>]`: 
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

## RELATED LINKS

