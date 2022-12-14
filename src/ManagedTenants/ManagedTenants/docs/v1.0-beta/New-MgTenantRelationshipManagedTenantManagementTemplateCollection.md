---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.managedtenants/new-mgtenantrelationshipmanagedtenantmanagementtemplatecollection
schema: 2.0.0
---

# New-MgBetaTenantRelationshipManagedTenantManagementTemplateCollection

## SYNOPSIS
Create new navigation property to managementTemplateCollections for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaTenantRelationshipManagedTenantManagementTemplateCollection [-AdditionalProperties <Hashtable>]
 [-CreatedByUserId <String>] [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-Id <String>] [-LastActionByUserId <String>] [-LastActionDateTime <DateTime>]
 [-ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplate[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaTenantRelationshipManagedTenantManagementTemplateCollection
 -BodyParameter <IMicrosoftGraphManagedTenantsManagementTemplateCollection> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to managementTemplateCollections for tenantRelationships

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateCollection
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastActionByUserId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementTemplates
.
To construct, please use Get-Help -Online and see NOTES section for MANAGEMENTTEMPLATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplate[]
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateCollection

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementTemplateCollection

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedTenantsManagementTemplateCollection>: managementTemplateCollection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastActionByUserId <String>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[ManagementTemplates <IMicrosoftGraphManagedTenantsManagementTemplate[]>]`: 
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

MANAGEMENTTEMPLATES <IMicrosoftGraphManagedTenantsManagementTemplate[]>: .
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

