---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgapplicationsynchronizationjob
schema: 2.0.0
---

# New-MgApplicationSynchronizationJob

## SYNOPSIS
Create new navigation property to jobs for applications

## SYNTAX

### CreateExpanded (Default)
```
New-MgApplicationSynchronizationJob -ApplicationId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Schedule <IMicrosoftGraphSynchronizationSchedule>] [-Schema <IMicrosoftGraphSynchronizationSchema>]
 [-Status <IMicrosoftGraphSynchronizationStatus>]
 [-SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>] [-TemplateId <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgApplicationSynchronizationJob -ApplicationId <String> -BodyParameter <IMicrosoftGraphSynchronizationJob>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgApplicationSynchronizationJob -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphSynchronizationJob> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgApplicationSynchronizationJob -InputObject <IApplicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-Schedule <IMicrosoftGraphSynchronizationSchedule>]
 [-Schema <IMicrosoftGraphSynchronizationSchema>] [-Status <IMicrosoftGraphSynchronizationStatus>]
 [-SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>] [-TemplateId <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to jobs for applications

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

### -ApplicationId
key: id of application

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

### -BodyParameter
synchronizationJob
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationJob
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IApplicationsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Schedule
synchronizationSchedule
To construct, please use Get-Help -Online and see NOTES section for SCHEDULE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationSchedule
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Schema
synchronizationSchema
To construct, please use Get-Help -Online and see NOTES section for SCHEMA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationSchema
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
synchronizationStatus
To construct, please use Get-Help -Online and see NOTES section for STATUS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationStatus
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SynchronizationJobSettings
Settings associated with the job.
Some settings are inherited from the template.
To construct, please use Get-Help -Online and see NOTES section for SYNCHRONIZATIONJOBSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateId
Identifier of the synchronization template this job is based on.

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

### Microsoft.Graph.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationJob

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationJob

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSynchronizationJob>: synchronizationJob
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Expiration <DateTime?>]`: Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Interval <TimeSpan?>]`: The interval between synchronization iterations.
    - `[State <String>]`: synchronizationScheduleState
  - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: Contains the collection of directories and all of their objects.
      - `[Id <String>]`: 
      - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
      - `[DiscoveryDateTime <DateTime?>]`: Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: Name of the directory. Must be unique within the synchronization schema. Not nullable.
      - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: Collection of objects supported by the directory.
        - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
          - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
          - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
            - `[Key <String>]`: Key.
            - `[Value <String>]`: Value.
          - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
          - `[DefaultValue <String>]`: 
          - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
          - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
            - `[Key <String>]`: Name of the metadata property.
            - `[Value <String>]`: Value of the metadata property.
          - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
          - `[Mutability <String>]`: mutability
          - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
          - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
            - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
            - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
          - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
          - `[Type <String>]`: attributeType
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
        - `[Name <String>]`: 
        - `[SupportedApis <String[]>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Version <String>]`: Read only value that indicates version discovered. null if discovery has not yet occurred.
    - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
      - `[Editable <Boolean?>]`: true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.
      - `[Id <String>]`: Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.
      - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.
      - `[Name <String>]`: Human-readable name of the synchronization rule. Not nullable.
      - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: Collection of object mappings supported by the rule. Tells the synchronization engine which objects should be synchronized.
        - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: Attribute mappings define which attributes to map from the source object into the target object and how they should flow. A number of functions are available to support the transformation of the original source values.
          - `[DefaultValue <String>]`: Default value to be used in case the source property was evaluated to null. Optional.
          - `[ExportMissingReferences <Boolean?>]`: For internal use only.
          - `[FlowBehavior <String>]`: attributeFlowBehavior
          - `[FlowType <String>]`: attributeFlowType
          - `[MatchingPriority <Int32?>]`: If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.
          - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Expression <String>]`: 
            - `[Name <String>]`: 
            - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
              - `[Key <String>]`: The name of the parameter.
              - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
            - `[Type <String>]`: attributeMappingSourceType
          - `[TargetAttributeName <String>]`: Name of the attribute on the target object.
        - `[Enabled <Boolean?>]`: When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.
        - `[FlowTypes <String>]`: objectFlowTypes
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
        - `[Name <String>]`: Human-friendly name of the object mapping.
        - `[Scope <IMicrosoftGraphFilter>]`: filter
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to decide whether given object belongs and should be processed as part of this object mapping. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
            - `[Clauses <IMicrosoftGraphFilterClause[]>]`: Filter clauses (conditions) of this group. All clauses in a group must be satisfied in order for the filter group to evaluate to true.
              - `[OperatorName <String>]`: Name of the operator to be applied to the source and target operands. Must be one of the supported operators. Supported operators can be discovered.
              - `[SourceOperandName <String>]`: Name of source operand (the operand being tested). The source operand name must match one of the attribute names on the source object.
              - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
                - `[(Any) <Object>]`: This indicates any property can be added to this object.
                - `[Values <String[]>]`: Collection of values.
            - `[Name <String>]`: Human-readable name of the filter group.
          - `[Groups <IMicrosoftGraphFilterGroup[]>]`: Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is not satisfied any longer, such object will get de-provisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
          - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get de-provisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
        - `[SourceObjectName <String>]`: Name of the object in the source directory. Must match the object name from the source directory definition.
        - `[TargetObjectName <String>]`: Name of the object in target directory. Must match the object name from the target directory definition.
      - `[Priority <Int32?>]`: Priority relative to other rules in the synchronizationSchema. Rules with the lowest priority number will be processed first.
      - `[SourceDirectoryName <String>]`: Name of the source directory. Must match one of the directory definitions in synchronizationSchema.
      - `[TargetDirectoryName <String>]`: Name of the target directory. Must match one of the directory definitions in synchronizationSchema.
    - `[Version <String>]`: The version of the schema, updated automatically with every schema change.
  - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <String>]`: synchronizationStatusCode
    - `[CountSuccessiveCompleteFailures <Int64?>]`: Number of consecutive times this job failed.
    - `[EscrowsPruned <Boolean?>]`: true if the job's escrows (object-level errors) were pruned during initial synchronization. Escrows can be pruned if during the initial synchronization, you reach the threshold of errors that would normally put the job in quarantine. Instead of going into quarantine, the synchronization process clears the job's errors and continues until the initial synchronization is completed. When the initial synchronization is completed, the job will pause and wait for the customer to clean up the errors.
    - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ActivityIdentifier <String>]`: Identifier of the job run.
      - `[CountEntitled <Int64?>]`: Count of processed entries that were assigned for this application.
      - `[CountEntitledForProvisioning <Int64?>]`: Count of processed entries that were assigned for provisioning.
      - `[CountEscrowed <Int64?>]`: Count of entries that were escrowed (errors).
      - `[CountEscrowedRaw <Int64?>]`: Count of entries that were escrowed, including system-generated escrows.
      - `[CountExported <Int64?>]`: Count of exported entries.
      - `[CountExports <Int64?>]`: Count of entries that were expected to be exported.
      - `[CountImported <Int64?>]`: Count of imported entries.
      - `[CountImportedDeltas <Int64?>]`: Count of imported delta-changes.
      - `[CountImportedReferenceDeltas <Int64?>]`: Count of imported delta-changes pertaining to reference changes.
      - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: 
        - `[Message <String>]`: 
        - `[TenantActionable <Boolean?>]`: 
      - `[State <String>]`: synchronizationTaskExecutionResult
      - `[TimeBegan <DateTime?>]`: Time when this job run began. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[TimeEnded <DateTime?>]`: Time when this job run ended. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
    - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
    - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: Details of the progress of a job toward completion.
      - `[CompletedUnits <Int64?>]`: The numerator of a progress ratio; the number of units of changes already processed.
      - `[ProgressObservationDateTime <DateTime?>]`: The time of a progress observation as an offset in minutes from UTC.
      - `[TotalUnits <Int64?>]`: The denominator of a progress ratio; a number of units of changes to be processed to accomplish synchronization.
      - `[Units <String>]`: An optional description of the units.
    - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CurrentBegan <DateTime?>]`: Date and time when the quarantine was last evaluated and imposed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
      - `[NextAttempt <DateTime?>]`: Date and time when the next attempt to re-evaluate the quarantine will be made. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Reason <String>]`: quarantineReason
      - `[SeriesBegan <DateTime?>]`: Date and time when the quarantine was first imposed in this series (a series starts when a quarantine is first imposed, and is reset as soon as the quarantine is lifted). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[SeriesCount <Int64?>]`: Number of times in this series the quarantine was re-evaluated and left in effect (a series starts when quarantine is first imposed, and is reset as soon as quarantine is lifted).
    - `[SteadyStateFirstAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was first achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[SteadyStateLastAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was last achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: Count of synchronized objects, listed by object type.
      - `[Key <String>]`: Key.
      - `[Value <Int64?>]`: Value.
    - `[TroubleshootingUrl <String>]`: In the event of an error, the URL with the troubleshooting steps for the issue.
  - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: Settings associated with the job. Some settings are inherited from the template.
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[TemplateId <String>]`: Identifier of the synchronization template this job is based on.

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppManagementPolicyId <String>]`: key: id of appManagementPolicy
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DelegatedPermissionClassificationId <String>]`: key: id of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[FederatedIdentityCredentialId <String>]`: key: id of federatedIdentityCredential
  - `[GroupId <String>]`: key: id of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OnPremisesAgentGroupId <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: id of publishedResource
  - `[ServicePrincipalId <String>]`: key: id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[UserId <String>]`: key: id of user

SCHEDULE <IMicrosoftGraphSynchronizationSchedule>: synchronizationSchedule
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Expiration <DateTime?>]`: Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Interval <TimeSpan?>]`: The interval between synchronization iterations.
  - `[State <String>]`: synchronizationScheduleState

SCHEMA <IMicrosoftGraphSynchronizationSchema>: synchronizationSchema
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: Contains the collection of directories and all of their objects.
    - `[Id <String>]`: 
    - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
    - `[DiscoveryDateTime <DateTime?>]`: Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Name <String>]`: Name of the directory. Must be unique within the synchronization schema. Not nullable.
    - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: Collection of objects supported by the directory.
      - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
        - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
        - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
          - `[Key <String>]`: Key.
          - `[Value <String>]`: Value.
        - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
        - `[DefaultValue <String>]`: 
        - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
          - `[Key <String>]`: Name of the metadata property.
          - `[Value <String>]`: Value of the metadata property.
        - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
        - `[Mutability <String>]`: mutability
        - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
        - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
          - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
          - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
        - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
        - `[Type <String>]`: attributeType
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[SupportedApis <String[]>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Version <String>]`: Read only value that indicates version discovered. null if discovery has not yet occurred.
  - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
    - `[Editable <Boolean?>]`: true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.
    - `[Id <String>]`: Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.
    - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.
    - `[Name <String>]`: Human-readable name of the synchronization rule. Not nullable.
    - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: Collection of object mappings supported by the rule. Tells the synchronization engine which objects should be synchronized.
      - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: Attribute mappings define which attributes to map from the source object into the target object and how they should flow. A number of functions are available to support the transformation of the original source values.
        - `[DefaultValue <String>]`: Default value to be used in case the source property was evaluated to null. Optional.
        - `[ExportMissingReferences <Boolean?>]`: For internal use only.
        - `[FlowBehavior <String>]`: attributeFlowBehavior
        - `[FlowType <String>]`: attributeFlowType
        - `[MatchingPriority <Int32?>]`: If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.
        - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Expression <String>]`: 
          - `[Name <String>]`: 
          - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
            - `[Key <String>]`: The name of the parameter.
            - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
          - `[Type <String>]`: attributeMappingSourceType
        - `[TargetAttributeName <String>]`: Name of the attribute on the target object.
      - `[Enabled <Boolean?>]`: When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.
      - `[FlowTypes <String>]`: objectFlowTypes
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
      - `[Name <String>]`: Human-friendly name of the object mapping.
      - `[Scope <IMicrosoftGraphFilter>]`: filter
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to decide whether given object belongs and should be processed as part of this object mapping. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
          - `[Clauses <IMicrosoftGraphFilterClause[]>]`: Filter clauses (conditions) of this group. All clauses in a group must be satisfied in order for the filter group to evaluate to true.
            - `[OperatorName <String>]`: Name of the operator to be applied to the source and target operands. Must be one of the supported operators. Supported operators can be discovered.
            - `[SourceOperandName <String>]`: Name of source operand (the operand being tested). The source operand name must match one of the attribute names on the source object.
            - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Values <String[]>]`: Collection of values.
          - `[Name <String>]`: Human-readable name of the filter group.
        - `[Groups <IMicrosoftGraphFilterGroup[]>]`: Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is not satisfied any longer, such object will get de-provisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
        - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get de-provisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
      - `[SourceObjectName <String>]`: Name of the object in the source directory. Must match the object name from the source directory definition.
      - `[TargetObjectName <String>]`: Name of the object in target directory. Must match the object name from the target directory definition.
    - `[Priority <Int32?>]`: Priority relative to other rules in the synchronizationSchema. Rules with the lowest priority number will be processed first.
    - `[SourceDirectoryName <String>]`: Name of the source directory. Must match one of the directory definitions in synchronizationSchema.
    - `[TargetDirectoryName <String>]`: Name of the target directory. Must match one of the directory definitions in synchronizationSchema.
  - `[Version <String>]`: The version of the schema, updated automatically with every schema change.

STATUS <IMicrosoftGraphSynchronizationStatus>: synchronizationStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Code <String>]`: synchronizationStatusCode
  - `[CountSuccessiveCompleteFailures <Int64?>]`: Number of consecutive times this job failed.
  - `[EscrowsPruned <Boolean?>]`: true if the job's escrows (object-level errors) were pruned during initial synchronization. Escrows can be pruned if during the initial synchronization, you reach the threshold of errors that would normally put the job in quarantine. Instead of going into quarantine, the synchronization process clears the job's errors and continues until the initial synchronization is completed. When the initial synchronization is completed, the job will pause and wait for the customer to clean up the errors.
  - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ActivityIdentifier <String>]`: Identifier of the job run.
    - `[CountEntitled <Int64?>]`: Count of processed entries that were assigned for this application.
    - `[CountEntitledForProvisioning <Int64?>]`: Count of processed entries that were assigned for provisioning.
    - `[CountEscrowed <Int64?>]`: Count of entries that were escrowed (errors).
    - `[CountEscrowedRaw <Int64?>]`: Count of entries that were escrowed, including system-generated escrows.
    - `[CountExported <Int64?>]`: Count of exported entries.
    - `[CountExports <Int64?>]`: Count of entries that were expected to be exported.
    - `[CountImported <Int64?>]`: Count of imported entries.
    - `[CountImportedDeltas <Int64?>]`: Count of imported delta-changes.
    - `[CountImportedReferenceDeltas <Int64?>]`: Count of imported delta-changes pertaining to reference changes.
    - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: 
      - `[Message <String>]`: 
      - `[TenantActionable <Boolean?>]`: 
    - `[State <String>]`: synchronizationTaskExecutionResult
    - `[TimeBegan <DateTime?>]`: Time when this job run began. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[TimeEnded <DateTime?>]`: Time when this job run ended. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
  - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
  - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: Details of the progress of a job toward completion.
    - `[CompletedUnits <Int64?>]`: The numerator of a progress ratio; the number of units of changes already processed.
    - `[ProgressObservationDateTime <DateTime?>]`: The time of a progress observation as an offset in minutes from UTC.
    - `[TotalUnits <Int64?>]`: The denominator of a progress ratio; a number of units of changes to be processed to accomplish synchronization.
    - `[Units <String>]`: An optional description of the units.
  - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CurrentBegan <DateTime?>]`: Date and time when the quarantine was last evaluated and imposed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
    - `[NextAttempt <DateTime?>]`: Date and time when the next attempt to re-evaluate the quarantine will be made. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Reason <String>]`: quarantineReason
    - `[SeriesBegan <DateTime?>]`: Date and time when the quarantine was first imposed in this series (a series starts when a quarantine is first imposed, and is reset as soon as the quarantine is lifted). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[SeriesCount <Int64?>]`: Number of times in this series the quarantine was re-evaluated and left in effect (a series starts when quarantine is first imposed, and is reset as soon as quarantine is lifted).
  - `[SteadyStateFirstAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was first achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[SteadyStateLastAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was last achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: Count of synchronized objects, listed by object type.
    - `[Key <String>]`: Key.
    - `[Value <Int64?>]`: Value.
  - `[TroubleshootingUrl <String>]`: In the event of an error, the URL with the troubleshooting steps for the issue.

SYNCHRONIZATIONJOBSETTINGS <IMicrosoftGraphKeyValuePair[]>: Settings associated with the job. Some settings are inherited from the template.
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

## RELATED LINKS

