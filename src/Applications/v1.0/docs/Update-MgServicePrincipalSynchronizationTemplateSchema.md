---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.applications/update-mgserviceprincipalsynchronizationtemplateschema
schema: 2.0.0
---

# Update-MgServicePrincipalSynchronizationTemplateSchema

## SYNOPSIS
Update the navigation property schema in servicePrincipals

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgServicePrincipalSynchronizationTemplateSchema -ServicePrincipalId <String>
 -SynchronizationTemplateId <String> [-AdditionalProperties <Hashtable>]
 [-Directories <IMicrosoftGraphDirectoryDefinition[]>] [-Id <String>]
 [-SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>] [-Version <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgServicePrincipalSynchronizationTemplateSchema -ServicePrincipalId <String>
 -SynchronizationTemplateId <String> -BodyParameter <IMicrosoftGraphSynchronizationSchema> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgServicePrincipalSynchronizationTemplateSchema -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphSynchronizationSchema> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgServicePrincipalSynchronizationTemplateSchema -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Directories <IMicrosoftGraphDirectoryDefinition[]>] [-Id <String>]
 [-SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>] [-Version <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property schema in servicePrincipals

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



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
synchronizationSchema
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationSchema
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Directories
.
To construct, see NOTES section for DIRECTORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryDefinition[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
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
Type: Microsoft.Graph.PowerShell.Models.IApplicationsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ServicePrincipalId
The unique identifier of servicePrincipal

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

### -SynchronizationRules
.
To construct, see NOTES section for SYNCHRONIZATIONRULES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationRule[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SynchronizationTemplateId
The unique identifier of synchronizationTemplate

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

### -Version
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

### Microsoft.Graph.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationSchema

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSynchronizationSchema>`: synchronizationSchema
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
    - `[DiscoveryDateTime <DateTime?>]`: 
    - `[Name <String>]`: 
    - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: 
      - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
        - `[Anchor <Boolean?>]`: 
        - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
          - `[Key <String>]`: 
          - `[Value <String>]`: 
        - `[CaseExact <Boolean?>]`: 
        - `[DefaultValue <String>]`: 
        - `[FlowNullValues <Boolean?>]`: 
        - `[Metadata <IMicrosoftGraphAttributeDefinitionMetadataEntry[]>]`: 
          - `[Key <String>]`: attributeDefinitionMetadata
          - `[Value <String>]`: 
        - `[Multivalued <Boolean?>]`: 
        - `[Mutability <String>]`: mutability
        - `[Name <String>]`: 
        - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: 
          - `[ReferencedObjectName <String>]`: 
          - `[ReferencedProperty <String>]`: 
        - `[Required <Boolean?>]`: 
        - `[Type <String>]`: attributeType
      - `[Metadata <IMicrosoftGraphObjectDefinitionMetadataEntry[]>]`: 
        - `[Key <String>]`: objectDefinitionMetadata
        - `[Value <String>]`: 
      - `[Name <String>]`: 
      - `[SupportedApis <String[]>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Version <String>]`: 
  - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
    - `[ContainerFilter <IMicrosoftGraphContainerFilter>]`: containerFilter
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IncludedContainers <String[]>]`: 
    - `[Editable <Boolean?>]`: 
    - `[GroupFilter <IMicrosoftGraphGroupFilter>]`: groupFilter
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IncludedGroups <String[]>]`: 
    - `[Id <String>]`: 
    - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
    - `[Name <String>]`: 
    - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: 
      - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: 
        - `[DefaultValue <String>]`: 
        - `[ExportMissingReferences <Boolean?>]`: 
        - `[FlowBehavior <String>]`: attributeFlowBehavior
        - `[FlowType <String>]`: attributeFlowType
        - `[MatchingPriority <Int32?>]`: 
        - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Expression <String>]`: 
          - `[Name <String>]`: 
          - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
            - `[Key <String>]`: 
            - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
          - `[Type <String>]`: attributeMappingSourceType
        - `[TargetAttributeName <String>]`: 
      - `[Enabled <Boolean?>]`: 
      - `[FlowTypes <String>]`: objectFlowTypes
      - `[Metadata <IMicrosoftGraphObjectMappingMetadataEntry[]>]`: 
        - `[Key <String>]`: objectMappingMetadata
        - `[Value <String>]`: 
      - `[Name <String>]`: 
      - `[Scope <IMicrosoftGraphFilter>]`: filter
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
          - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
            - `[OperatorName <String>]`: 
            - `[SourceOperandName <String>]`: 
            - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Values <String[]>]`: 
          - `[Name <String>]`: 
        - `[Groups <IMicrosoftGraphFilterGroup[]>]`: 
        - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[SourceObjectName <String>]`: 
      - `[TargetObjectName <String>]`: 
    - `[Priority <Int32?>]`: 
    - `[SourceDirectoryName <String>]`: 
    - `[TargetDirectoryName <String>]`: 
  - `[Version <String>]`: 

`DIRECTORIES <IMicrosoftGraphDirectoryDefinition[]>`: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
  - `[DiscoveryDateTime <DateTime?>]`: 
  - `[Name <String>]`: 
  - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: 
    - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
      - `[Anchor <Boolean?>]`: 
      - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
        - `[Key <String>]`: 
        - `[Value <String>]`: 
      - `[CaseExact <Boolean?>]`: 
      - `[DefaultValue <String>]`: 
      - `[FlowNullValues <Boolean?>]`: 
      - `[Metadata <IMicrosoftGraphAttributeDefinitionMetadataEntry[]>]`: 
        - `[Key <String>]`: attributeDefinitionMetadata
        - `[Value <String>]`: 
      - `[Multivalued <Boolean?>]`: 
      - `[Mutability <String>]`: mutability
      - `[Name <String>]`: 
      - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: 
        - `[ReferencedObjectName <String>]`: 
        - `[ReferencedProperty <String>]`: 
      - `[Required <Boolean?>]`: 
      - `[Type <String>]`: attributeType
    - `[Metadata <IMicrosoftGraphObjectDefinitionMetadataEntry[]>]`: 
      - `[Key <String>]`: objectDefinitionMetadata
      - `[Value <String>]`: 
    - `[Name <String>]`: 
    - `[SupportedApis <String[]>]`: 
  - `[ReadOnly <Boolean?>]`: 
  - `[Version <String>]`: 

`INPUTOBJECT <IApplicationsIdentity>`: Identity Parameter
  - `[AppManagementPolicyId <String>]`: The unique identifier of appManagementPolicy
  - `[AppRoleAssignmentId <String>]`: The unique identifier of appRoleAssignment
  - `[ApplicationId <String>]`: The unique identifier of application
  - `[ApplicationTemplateId <String>]`: The unique identifier of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: The unique identifier of claimsMappingPolicy
  - `[DelegatedPermissionClassificationId <String>]`: The unique identifier of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: The unique identifier of directoryDefinition
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EndpointId <String>]`: The unique identifier of endpoint
  - `[ExtensionPropertyId <String>]`: The unique identifier of extensionProperty
  - `[FederatedIdentityCredentialId <String>]`: The unique identifier of federatedIdentityCredential
  - `[GroupId <String>]`: The unique identifier of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: The unique identifier of homeRealmDiscoveryPolicy
  - `[OAuth2PermissionGrantId <String>]`: The unique identifier of oAuth2PermissionGrant
  - `[ServicePrincipalId <String>]`: The unique identifier of servicePrincipal
  - `[SynchronizationJobId <String>]`: The unique identifier of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: The unique identifier of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: The unique identifier of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: The unique identifier of tokenLifetimePolicy
  - `[UserId <String>]`: The unique identifier of user

`SYNCHRONIZATIONRULES <IMicrosoftGraphSynchronizationRule[]>`: .
  - `[ContainerFilter <IMicrosoftGraphContainerFilter>]`: containerFilter
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IncludedContainers <String[]>]`: 
  - `[Editable <Boolean?>]`: 
  - `[GroupFilter <IMicrosoftGraphGroupFilter>]`: groupFilter
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IncludedGroups <String[]>]`: 
  - `[Id <String>]`: 
  - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
    - `[Key <String>]`: 
    - `[Value <String>]`: 
  - `[Name <String>]`: 
  - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: 
    - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: 
      - `[DefaultValue <String>]`: 
      - `[ExportMissingReferences <Boolean?>]`: 
      - `[FlowBehavior <String>]`: attributeFlowBehavior
      - `[FlowType <String>]`: attributeFlowType
      - `[MatchingPriority <Int32?>]`: 
      - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Expression <String>]`: 
        - `[Name <String>]`: 
        - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
          - `[Key <String>]`: 
          - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
        - `[Type <String>]`: attributeMappingSourceType
      - `[TargetAttributeName <String>]`: 
    - `[Enabled <Boolean?>]`: 
    - `[FlowTypes <String>]`: objectFlowTypes
    - `[Metadata <IMicrosoftGraphObjectMappingMetadataEntry[]>]`: 
      - `[Key <String>]`: objectMappingMetadata
      - `[Value <String>]`: 
    - `[Name <String>]`: 
    - `[Scope <IMicrosoftGraphFilter>]`: filter
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
        - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
          - `[OperatorName <String>]`: 
          - `[SourceOperandName <String>]`: 
          - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Values <String[]>]`: 
        - `[Name <String>]`: 
      - `[Groups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
    - `[SourceObjectName <String>]`: 
    - `[TargetObjectName <String>]`: 
  - `[Priority <Int32?>]`: 
  - `[SourceDirectoryName <String>]`: 
  - `[TargetDirectoryName <String>]`: 

## RELATED LINKS

