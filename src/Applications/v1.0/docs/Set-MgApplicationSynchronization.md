---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.applications/set-mgapplicationsynchronization
schema: 2.0.0
---

# Set-MgApplicationSynchronization

## SYNOPSIS
Update the navigation property synchronization in applications

## SYNTAX

### SetExpanded (Default)
```
Set-MgApplicationSynchronization -ApplicationId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Jobs <IMicrosoftGraphSynchronizationJob[]>]
 [-Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]
 [-Templates <IMicrosoftGraphSynchronizationTemplate[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-MgApplicationSynchronization -ApplicationId <String> -BodyParameter <IMicrosoftGraphSynchronization>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-MgApplicationSynchronization -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphSynchronization> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-MgApplicationSynchronization -InputObject <IApplicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-Jobs <IMicrosoftGraphSynchronizationJob[]>]
 [-Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]
 [-Templates <IMicrosoftGraphSynchronizationTemplate[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property synchronization in applications

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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationId
The unique identifier of application

```yaml
Type: System.String
Parameter Sets: Set, SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
synchronization
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronization
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Jobs
.
To construct, see NOTES section for JOBS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationJob[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Secrets
.
To construct, see NOTES section for SECRETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Templates
.
To construct, see NOTES section for TEMPLATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationTemplate[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronization

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronization

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSynchronization>`: synchronization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Expiration <DateTime?>]`: 
      - `[Interval <TimeSpan?>]`: 
      - `[State <String>]`: synchronizationScheduleState
    - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
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
    - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: synchronizationStatusCode
      - `[CountSuccessiveCompleteFailures <Int64?>]`: 
      - `[EscrowsPruned <Boolean?>]`: 
      - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ActivityIdentifier <String>]`: 
        - `[CountEntitled <Int64?>]`: 
        - `[CountEntitledForProvisioning <Int64?>]`: 
        - `[CountEscrowed <Int64?>]`: 
        - `[CountEscrowedRaw <Int64?>]`: 
        - `[CountExported <Int64?>]`: 
        - `[CountExports <Int64?>]`: 
        - `[CountImported <Int64?>]`: 
        - `[CountImportedDeltas <Int64?>]`: 
        - `[CountImportedReferenceDeltas <Int64?>]`: 
        - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Code <String>]`: 
          - `[Message <String>]`: 
          - `[TenantActionable <Boolean?>]`: 
        - `[State <String>]`: synchronizationTaskExecutionResult
        - `[TimeBegan <DateTime?>]`: 
        - `[TimeEnded <DateTime?>]`: 
      - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
      - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
      - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: 
        - `[CompletedUnits <Int64?>]`: 
        - `[ProgressObservationDateTime <DateTime?>]`: 
        - `[TotalUnits <Int64?>]`: 
        - `[Units <String>]`: 
      - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CurrentBegan <DateTime?>]`: 
        - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
        - `[NextAttempt <DateTime?>]`: 
        - `[Reason <String>]`: quarantineReason
        - `[SeriesBegan <DateTime?>]`: 
        - `[SeriesCount <Int64?>]`: 
      - `[SteadyStateFirstAchievedTime <DateTime?>]`: 
      - `[SteadyStateLastAchievedTime <DateTime?>]`: 
      - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: 
        - `[Key <String>]`: 
        - `[Value <Int64?>]`: 
      - `[TroubleshootingUrl <String>]`: 
    - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: 
      - `[Name <String>]`: Name for this key-value pair
      - `[Value <String>]`: Value for this key-value pair
    - `[TemplateId <String>]`: 
  - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: 
    - `[Key <String>]`: synchronizationSecret
    - `[Value <String>]`: 
  - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ApplicationId <String>]`: 
    - `[Default <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[Discoverable <Boolean?>]`: 
    - `[FactoryTag <String>]`: 
    - `[Metadata <IMicrosoftGraphSynchronizationMetadataEntry[]>]`: 
      - `[Key <String>]`: synchronizationMetadata
      - `[Value <String>]`: 
    - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema

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

`JOBS <IMicrosoftGraphSynchronizationJob[]>`: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Expiration <DateTime?>]`: 
    - `[Interval <TimeSpan?>]`: 
    - `[State <String>]`: synchronizationScheduleState
  - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
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
  - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <String>]`: synchronizationStatusCode
    - `[CountSuccessiveCompleteFailures <Int64?>]`: 
    - `[EscrowsPruned <Boolean?>]`: 
    - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ActivityIdentifier <String>]`: 
      - `[CountEntitled <Int64?>]`: 
      - `[CountEntitledForProvisioning <Int64?>]`: 
      - `[CountEscrowed <Int64?>]`: 
      - `[CountEscrowedRaw <Int64?>]`: 
      - `[CountExported <Int64?>]`: 
      - `[CountExports <Int64?>]`: 
      - `[CountImported <Int64?>]`: 
      - `[CountImportedDeltas <Int64?>]`: 
      - `[CountImportedReferenceDeltas <Int64?>]`: 
      - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: 
        - `[Message <String>]`: 
        - `[TenantActionable <Boolean?>]`: 
      - `[State <String>]`: synchronizationTaskExecutionResult
      - `[TimeBegan <DateTime?>]`: 
      - `[TimeEnded <DateTime?>]`: 
    - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
    - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
    - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: 
      - `[CompletedUnits <Int64?>]`: 
      - `[ProgressObservationDateTime <DateTime?>]`: 
      - `[TotalUnits <Int64?>]`: 
      - `[Units <String>]`: 
    - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CurrentBegan <DateTime?>]`: 
      - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
      - `[NextAttempt <DateTime?>]`: 
      - `[Reason <String>]`: quarantineReason
      - `[SeriesBegan <DateTime?>]`: 
      - `[SeriesCount <Int64?>]`: 
    - `[SteadyStateFirstAchievedTime <DateTime?>]`: 
    - `[SteadyStateLastAchievedTime <DateTime?>]`: 
    - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: 
      - `[Key <String>]`: 
      - `[Value <Int64?>]`: 
    - `[TroubleshootingUrl <String>]`: 
  - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: 
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[TemplateId <String>]`: 

`SECRETS <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>`: .
  - `[Key <String>]`: synchronizationSecret
  - `[Value <String>]`: 

`TEMPLATES <IMicrosoftGraphSynchronizationTemplate[]>`: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ApplicationId <String>]`: 
  - `[Default <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[Discoverable <Boolean?>]`: 
  - `[FactoryTag <String>]`: 
  - `[Metadata <IMicrosoftGraphSynchronizationMetadataEntry[]>]`: 
    - `[Key <String>]`: synchronizationMetadata
    - `[Value <String>]`: 
  - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
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

## RELATED LINKS

