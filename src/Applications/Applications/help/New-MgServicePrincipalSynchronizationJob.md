---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgserviceprincipalsynchronizationjob
schema: 2.0.0
---

# New-MgServicePrincipalSynchronizationJob

## SYNOPSIS
Create new navigation property to jobs for servicePrincipals

## SYNTAX

### CreateExpanded (Default)
```
New-MgServicePrincipalSynchronizationJob -ServicePrincipalId <String> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-Schedule <IMicrosoftGraphSynchronizationSchedule>]
 [-Schema <IMicrosoftGraphSynchronizationSchema>] [-Status <IMicrosoftGraphSynchronizationStatus>]
 [-SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>] [-TemplateId <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgServicePrincipalSynchronizationJob -ServicePrincipalId <String>
 -BodyParameter <IMicrosoftGraphSynchronizationJob> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgServicePrincipalSynchronizationJob -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-Schedule <IMicrosoftGraphSynchronizationSchedule>]
 [-Schema <IMicrosoftGraphSynchronizationSchema>] [-Status <IMicrosoftGraphSynchronizationStatus>]
 [-SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>] [-TemplateId <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgServicePrincipalSynchronizationJob -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphSynchronizationJob> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to jobs for servicePrincipals

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
synchronizationJob
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphSynchronizationJob
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IApplicationsIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Schedule
synchronizationSchedule
To construct, see NOTES section for SCHEDULE properties and create a hash table.

```yaml
Type: IMicrosoftGraphSynchronizationSchedule
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
To construct, see NOTES section for SCHEMA properties and create a hash table.

```yaml
Type: IMicrosoftGraphSynchronizationSchema
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServicePrincipalId
key: id of servicePrincipal

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
synchronizationStatus
To construct, see NOTES section for STATUS properties and create a hash table.

```yaml
Type: IMicrosoftGraphSynchronizationStatus
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SynchronizationJobSettings
.
To construct, see NOTES section for SYNCHRONIZATIONJOBSETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateId
.

```yaml
Type: String
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
Type: SwitchParameter
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
Type: SwitchParameter
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
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphSynchronizationJob\>: synchronizationJob
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Schedule \<IMicrosoftGraphSynchronizationSchedule\>\]: synchronizationSchedule
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Expiration \<DateTime?\>\]: 
    \[Interval \<TimeSpan?\>\]: 
    \[State \<String\>\]: synchronizationScheduleState
  \[Schema \<IMicrosoftGraphSynchronizationSchema\>\]: synchronizationSchema
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[Directories \<IMicrosoftGraphDirectoryDefinition\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Discoverabilities \<String\>\]: directoryDefinitionDiscoverabilities
      \[DiscoveryDateTime \<DateTime?\>\]: 
      \[Name \<String\>\]: 
      \[Objects \<IMicrosoftGraphObjectDefinition\[\]\>\]: 
        \[Attributes \<IMicrosoftGraphAttributeDefinition\[\]\>\]: 
          \[Anchor \<Boolean?\>\]: 
          \[ApiExpressions \<IMicrosoftGraphStringKeyStringValuePair\[\]\>\]: 
            \[Key \<String\>\]: 
            \[Value \<String\>\]: 
          \[CaseExact \<Boolean?\>\]: 
          \[DefaultValue \<String\>\]: 
          \[FlowNullValues \<Boolean?\>\]: 
          \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
            \[Key \<String\>\]: 
            \[Value \<String\>\]: 
          \[Multivalued \<Boolean?\>\]: 
          \[Mutability \<String\>\]: mutability
          \[Name \<String\>\]: 
          \[ReferencedObjects \<IMicrosoftGraphReferencedObject\[\]\>\]: 
            \[ReferencedObjectName \<String\>\]: 
            \[ReferencedProperty \<String\>\]: 
          \[Required \<Boolean?\>\]: 
          \[Type \<String\>\]: attributeType
        \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
        \[Name \<String\>\]: 
        \[SupportedApis \<String\[\]\>\]: 
      \[ReadOnly \<Boolean?\>\]: 
      \[Version \<String\>\]: 
    \[SynchronizationRules \<IMicrosoftGraphSynchronizationRule\[\]\>\]: 
      \[Editable \<Boolean?\>\]: 
      \[Id \<String\>\]: 
      \[Metadata \<IMicrosoftGraphStringKeyStringValuePair\[\]\>\]: 
      \[Name \<String\>\]: 
      \[ObjectMappings \<IMicrosoftGraphObjectMapping\[\]\>\]: 
        \[AttributeMappings \<IMicrosoftGraphAttributeMapping\[\]\>\]: 
          \[DefaultValue \<String\>\]: 
          \[ExportMissingReferences \<Boolean?\>\]: 
          \[FlowBehavior \<String\>\]: attributeFlowBehavior
          \[FlowType \<String\>\]: attributeFlowType
          \[MatchingPriority \<Int32?\>\]: 
          \[Source \<IMicrosoftGraphAttributeMappingSource\>\]: attributeMappingSource
            \[(Any) \<Object\>\]: This indicates any property can be added to this object.
            \[Expression \<String\>\]: 
            \[Name \<String\>\]: 
            \[Parameters \<IMicrosoftGraphStringKeyAttributeMappingSourceValuePair\[\]\>\]: 
              \[Key \<String\>\]: 
              \[Value \<IMicrosoftGraphAttributeMappingSource\>\]: attributeMappingSource
            \[Type \<String\>\]: attributeMappingSourceType
          \[TargetAttributeName \<String\>\]: 
        \[Enabled \<Boolean?\>\]: 
        \[FlowTypes \<String\>\]: objectFlowTypes
        \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
        \[Name \<String\>\]: 
        \[Scope \<IMicrosoftGraphFilter\>\]: filter
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[CategoryFilterGroups \<IMicrosoftGraphFilterGroup\[\]\>\]: 
            \[Clauses \<IMicrosoftGraphFilterClause\[\]\>\]: 
              \[OperatorName \<String\>\]: 
              \[SourceOperandName \<String\>\]: 
              \[TargetOperand \<IMicrosoftGraphFilterOperand\>\]: filterOperand
                \[(Any) \<Object\>\]: This indicates any property can be added to this object.
                \[Values \<String\[\]\>\]: 
            \[Name \<String\>\]: 
          \[Groups \<IMicrosoftGraphFilterGroup\[\]\>\]: 
          \[InputFilterGroups \<IMicrosoftGraphFilterGroup\[\]\>\]: 
        \[SourceObjectName \<String\>\]: 
        \[TargetObjectName \<String\>\]: 
      \[Priority \<Int32?\>\]: 
      \[SourceDirectoryName \<String\>\]: 
      \[TargetDirectoryName \<String\>\]: 
    \[Version \<String\>\]: 
  \[Status \<IMicrosoftGraphSynchronizationStatus\>\]: synchronizationStatus
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Code \<String\>\]: synchronizationStatusCode
    \[CountSuccessiveCompleteFailures \<Int64?\>\]: 
    \[EscrowsPruned \<Boolean?\>\]: 
    \[LastExecution \<IMicrosoftGraphSynchronizationTaskExecution\>\]: synchronizationTaskExecution
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[ActivityIdentifier \<String\>\]: 
      \[CountEntitled \<Int64?\>\]: 
      \[CountEntitledForProvisioning \<Int64?\>\]: 
      \[CountEscrowed \<Int64?\>\]: 
      \[CountEscrowedRaw \<Int64?\>\]: 
      \[CountExported \<Int64?\>\]: 
      \[CountExports \<Int64?\>\]: 
      \[CountImported \<Int64?\>\]: 
      \[CountImportedDeltas \<Int64?\>\]: 
      \[CountImportedReferenceDeltas \<Int64?\>\]: 
      \[Error \<IMicrosoftGraphSynchronizationError\>\]: synchronizationError
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Code \<String\>\]: 
        \[Message \<String\>\]: 
        \[TenantActionable \<Boolean?\>\]: 
      \[State \<String\>\]: synchronizationTaskExecutionResult
      \[TimeBegan \<DateTime?\>\]: 
      \[TimeEnded \<DateTime?\>\]: 
    \[LastSuccessfulExecution \<IMicrosoftGraphSynchronizationTaskExecution\>\]: synchronizationTaskExecution
    \[LastSuccessfulExecutionWithExports \<IMicrosoftGraphSynchronizationTaskExecution\>\]: synchronizationTaskExecution
    \[Progress \<IMicrosoftGraphSynchronizationProgress\[\]\>\]: 
      \[CompletedUnits \<Int64?\>\]: 
      \[ProgressObservationDateTime \<DateTime?\>\]: 
      \[TotalUnits \<Int64?\>\]: 
      \[Units \<String\>\]: 
    \[Quarantine \<IMicrosoftGraphSynchronizationQuarantine\>\]: synchronizationQuarantine
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[CurrentBegan \<DateTime?\>\]: 
      \[Error \<IMicrosoftGraphSynchronizationError\>\]: synchronizationError
      \[NextAttempt \<DateTime?\>\]: 
      \[Reason \<String\>\]: quarantineReason
      \[SeriesBegan \<DateTime?\>\]: 
      \[SeriesCount \<Int64?\>\]: 
    \[SteadyStateFirstAchievedTime \<DateTime?\>\]: 
    \[SteadyStateLastAchievedTime \<DateTime?\>\]: 
    \[SynchronizedEntryCountByType \<IMicrosoftGraphStringKeyLongValuePair\[\]\>\]: 
      \[Key \<String\>\]: 
      \[Value \<Int64?\>\]: 
    \[TroubleshootingUrl \<String\>\]: 
  \[SynchronizationJobSettings \<IMicrosoftGraphKeyValuePair\[\]\>\]: 
    \[Name \<String\>\]: Name for this key-value pair
    \[Value \<String\>\]: Value for this key-value pair
  \[TemplateId \<String\>\]: 

INPUTOBJECT \<IApplicationsIdentity\>: Identity Parameter
  \[AppRoleAssignmentId \<String\>\]: key: id of appRoleAssignment
  \[ApplicationId \<String\>\]: key: id of application
  \[ApplicationTemplateId \<String\>\]: key: id of applicationTemplate
  \[ConnectorGroupId \<String\>\]: key: id of connectorGroup
  \[ConnectorId \<String\>\]: key: id of connector
  \[DelegatedPermissionClassificationId \<String\>\]: key: id of delegatedPermissionClassification
  \[DirectoryDefinitionId \<String\>\]: key: id of directoryDefinition
  \[EndpointId \<String\>\]: key: id of endpoint
  \[ExtensionPropertyId \<String\>\]: key: id of extensionProperty
  \[GroupId \<String\>\]: key: id of group
  \[LicenseDetailsId \<String\>\]: key: id of licenseDetails
  \[OnPremisesAgentGroupId \<String\>\]: key: id of onPremisesAgentGroup
  \[OnPremisesAgentGroupId1 \<String\>\]: key: id of onPremisesAgentGroup
  \[OnPremisesAgentId \<String\>\]: key: id of onPremisesAgent
  \[OnPremisesAgentId1 \<String\>\]: key: id of onPremisesAgent
  \[OnPremisesPublishingProfileId \<String\>\]: key: id of onPremisesPublishingProfile
  \[PublishedResourceId \<String\>\]: key: id of publishedResource
  \[PublishedResourceId1 \<String\>\]: key: id of publishedResource
  \[ServicePrincipalId \<String\>\]: key: id of servicePrincipal
  \[SynchronizationJobId \<String\>\]: key: id of synchronizationJob
  \[SynchronizationTemplateId \<String\>\]: key: id of synchronizationTemplate
  \[UserId \<String\>\]: key: id of user

SCHEDULE \<IMicrosoftGraphSynchronizationSchedule\>: synchronizationSchedule
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Expiration \<DateTime?\>\]: 
  \[Interval \<TimeSpan?\>\]: 
  \[State \<String\>\]: synchronizationScheduleState

SCHEMA \<IMicrosoftGraphSynchronizationSchema\>: synchronizationSchema
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Directories \<IMicrosoftGraphDirectoryDefinition\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Discoverabilities \<String\>\]: directoryDefinitionDiscoverabilities
    \[DiscoveryDateTime \<DateTime?\>\]: 
    \[Name \<String\>\]: 
    \[Objects \<IMicrosoftGraphObjectDefinition\[\]\>\]: 
      \[Attributes \<IMicrosoftGraphAttributeDefinition\[\]\>\]: 
        \[Anchor \<Boolean?\>\]: 
        \[ApiExpressions \<IMicrosoftGraphStringKeyStringValuePair\[\]\>\]: 
          \[Key \<String\>\]: 
          \[Value \<String\>\]: 
        \[CaseExact \<Boolean?\>\]: 
        \[DefaultValue \<String\>\]: 
        \[FlowNullValues \<Boolean?\>\]: 
        \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
          \[Key \<String\>\]: 
          \[Value \<String\>\]: 
        \[Multivalued \<Boolean?\>\]: 
        \[Mutability \<String\>\]: mutability
        \[Name \<String\>\]: 
        \[ReferencedObjects \<IMicrosoftGraphReferencedObject\[\]\>\]: 
          \[ReferencedObjectName \<String\>\]: 
          \[ReferencedProperty \<String\>\]: 
        \[Required \<Boolean?\>\]: 
        \[Type \<String\>\]: attributeType
      \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
      \[Name \<String\>\]: 
      \[SupportedApis \<String\[\]\>\]: 
    \[ReadOnly \<Boolean?\>\]: 
    \[Version \<String\>\]: 
  \[SynchronizationRules \<IMicrosoftGraphSynchronizationRule\[\]\>\]: 
    \[Editable \<Boolean?\>\]: 
    \[Id \<String\>\]: 
    \[Metadata \<IMicrosoftGraphStringKeyStringValuePair\[\]\>\]: 
    \[Name \<String\>\]: 
    \[ObjectMappings \<IMicrosoftGraphObjectMapping\[\]\>\]: 
      \[AttributeMappings \<IMicrosoftGraphAttributeMapping\[\]\>\]: 
        \[DefaultValue \<String\>\]: 
        \[ExportMissingReferences \<Boolean?\>\]: 
        \[FlowBehavior \<String\>\]: attributeFlowBehavior
        \[FlowType \<String\>\]: attributeFlowType
        \[MatchingPriority \<Int32?\>\]: 
        \[Source \<IMicrosoftGraphAttributeMappingSource\>\]: attributeMappingSource
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[Expression \<String\>\]: 
          \[Name \<String\>\]: 
          \[Parameters \<IMicrosoftGraphStringKeyAttributeMappingSourceValuePair\[\]\>\]: 
            \[Key \<String\>\]: 
            \[Value \<IMicrosoftGraphAttributeMappingSource\>\]: attributeMappingSource
          \[Type \<String\>\]: attributeMappingSourceType
        \[TargetAttributeName \<String\>\]: 
      \[Enabled \<Boolean?\>\]: 
      \[FlowTypes \<String\>\]: objectFlowTypes
      \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
      \[Name \<String\>\]: 
      \[Scope \<IMicrosoftGraphFilter\>\]: filter
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[CategoryFilterGroups \<IMicrosoftGraphFilterGroup\[\]\>\]: 
          \[Clauses \<IMicrosoftGraphFilterClause\[\]\>\]: 
            \[OperatorName \<String\>\]: 
            \[SourceOperandName \<String\>\]: 
            \[TargetOperand \<IMicrosoftGraphFilterOperand\>\]: filterOperand
              \[(Any) \<Object\>\]: This indicates any property can be added to this object.
              \[Values \<String\[\]\>\]: 
          \[Name \<String\>\]: 
        \[Groups \<IMicrosoftGraphFilterGroup\[\]\>\]: 
        \[InputFilterGroups \<IMicrosoftGraphFilterGroup\[\]\>\]: 
      \[SourceObjectName \<String\>\]: 
      \[TargetObjectName \<String\>\]: 
    \[Priority \<Int32?\>\]: 
    \[SourceDirectoryName \<String\>\]: 
    \[TargetDirectoryName \<String\>\]: 
  \[Version \<String\>\]: 

STATUS \<IMicrosoftGraphSynchronizationStatus\>: synchronizationStatus
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Code \<String\>\]: synchronizationStatusCode
  \[CountSuccessiveCompleteFailures \<Int64?\>\]: 
  \[EscrowsPruned \<Boolean?\>\]: 
  \[LastExecution \<IMicrosoftGraphSynchronizationTaskExecution\>\]: synchronizationTaskExecution
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[ActivityIdentifier \<String\>\]: 
    \[CountEntitled \<Int64?\>\]: 
    \[CountEntitledForProvisioning \<Int64?\>\]: 
    \[CountEscrowed \<Int64?\>\]: 
    \[CountEscrowedRaw \<Int64?\>\]: 
    \[CountExported \<Int64?\>\]: 
    \[CountExports \<Int64?\>\]: 
    \[CountImported \<Int64?\>\]: 
    \[CountImportedDeltas \<Int64?\>\]: 
    \[CountImportedReferenceDeltas \<Int64?\>\]: 
    \[Error \<IMicrosoftGraphSynchronizationError\>\]: synchronizationError
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Code \<String\>\]: 
      \[Message \<String\>\]: 
      \[TenantActionable \<Boolean?\>\]: 
    \[State \<String\>\]: synchronizationTaskExecutionResult
    \[TimeBegan \<DateTime?\>\]: 
    \[TimeEnded \<DateTime?\>\]: 
  \[LastSuccessfulExecution \<IMicrosoftGraphSynchronizationTaskExecution\>\]: synchronizationTaskExecution
  \[LastSuccessfulExecutionWithExports \<IMicrosoftGraphSynchronizationTaskExecution\>\]: synchronizationTaskExecution
  \[Progress \<IMicrosoftGraphSynchronizationProgress\[\]\>\]: 
    \[CompletedUnits \<Int64?\>\]: 
    \[ProgressObservationDateTime \<DateTime?\>\]: 
    \[TotalUnits \<Int64?\>\]: 
    \[Units \<String\>\]: 
  \[Quarantine \<IMicrosoftGraphSynchronizationQuarantine\>\]: synchronizationQuarantine
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[CurrentBegan \<DateTime?\>\]: 
    \[Error \<IMicrosoftGraphSynchronizationError\>\]: synchronizationError
    \[NextAttempt \<DateTime?\>\]: 
    \[Reason \<String\>\]: quarantineReason
    \[SeriesBegan \<DateTime?\>\]: 
    \[SeriesCount \<Int64?\>\]: 
  \[SteadyStateFirstAchievedTime \<DateTime?\>\]: 
  \[SteadyStateLastAchievedTime \<DateTime?\>\]: 
  \[SynchronizedEntryCountByType \<IMicrosoftGraphStringKeyLongValuePair\[\]\>\]: 
    \[Key \<String\>\]: 
    \[Value \<Int64?\>\]: 
  \[TroubleshootingUrl \<String\>\]: 

SYNCHRONIZATIONJOBSETTINGS \<IMicrosoftGraphKeyValuePair\[\]\>: .
  \[Name \<String\>\]: Name for this key-value pair
  \[Value \<String\>\]: Value for this key-value pair

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgserviceprincipalsynchronizationjob](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgserviceprincipalsynchronizationjob)

