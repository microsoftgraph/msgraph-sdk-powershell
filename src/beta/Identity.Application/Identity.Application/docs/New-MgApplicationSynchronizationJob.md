---
external help file:
Module Name: Microsoft.Graph.Identity.Application
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.application/new-mgapplicationsynchronizationjob
schema: 2.0.0
---

# New-MgApplicationSynchronizationJob

## SYNOPSIS
Create new navigation property to jobs for applications

## SYNTAX

### CreateExpanded (Default)
```
New-MgApplicationSynchronizationJob -ApplicationId <String> [-Id <String>] [-ScheduleExpiration <DateTime>]
 [-ScheduleInterval <TimeSpan>] [-ScheduleState <String>]
 [-SchemaDirectories <IMicrosoftGraphDirectoryDefinition[]>] [-SchemaId <String>]
 [-SchemaProvisioningTaskIdentifier <String>]
 [-SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>] [-SchemaVersion <String>]
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
New-MgApplicationSynchronizationJob -InputObject <IIdentityApplicationIdentity>
 -BodyParameter <IMicrosoftGraphSynchronizationJob> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgApplicationSynchronizationJob -InputObject <IIdentityApplicationIdentity> [-Id <String>]
 [-ScheduleExpiration <DateTime>] [-ScheduleInterval <TimeSpan>] [-ScheduleState <String>]
 [-SchemaDirectories <IMicrosoftGraphDirectoryDefinition[]>] [-SchemaId <String>]
 [-SchemaProvisioningTaskIdentifier <String>]
 [-SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>] [-SchemaVersion <String>]
 [-Status <IMicrosoftGraphSynchronizationStatus>]
 [-SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>] [-TemplateId <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to jobs for applications

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -ApplicationId
key: application-id of application

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
synchronizationJob
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationJob
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Id
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
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityApplicationIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ScheduleExpiration
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
Dynamic: False
```

### -ScheduleInterval
.

```yaml
Type: System.TimeSpan
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ScheduleState
synchronizationScheduleState

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SchemaDirectories
.
To construct, see NOTES section for SCHEMADIRECTORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryDefinition[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SchemaId
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
Dynamic: False
```

### -SchemaProvisioningTaskIdentifier
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
Dynamic: False
```

### -SchemaSynchronizationRules
.
To construct, see NOTES section for SCHEMASYNCHRONIZATIONRULES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationRule[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SchemaVersion
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
Dynamic: False
```

### -Status
synchronizationStatus
To construct, see NOTES section for STATUS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationStatus
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SynchronizationJobSettings
.
To construct, see NOTES section for SYNCHRONIZATIONJOBSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TemplateId
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityApplicationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationJob

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationJob

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphSynchronizationJob>: synchronizationJob
  - `[Id <String>]`: Read-only.
  - `[ScheduleExpiration <DateTime?>]`: 
  - `[ScheduleInterval <TimeSpan?>]`: 
  - `[ScheduleState <String>]`: synchronizationScheduleState
  - `[SchemaDirectories <IMicrosoftGraphDirectoryDefinition[]>]`: 
    - `[Id <String>]`: Read-only.
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
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
          - `[Key <String>]`: 
          - `[Value <String>]`: 
        - `[Multivalued <Boolean?>]`: 
        - `[Mutability <String>]`: mutability
        - `[Name <String>]`: 
        - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: 
          - `[ReferencedObjectName <String>]`: 
          - `[ReferencedProperty <String>]`: 
        - `[Required <Boolean?>]`: 
        - `[Type <String>]`: attributeType
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[SupportedApis <String[]>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Version <String>]`: 
  - `[SchemaId <String>]`: Read-only.
  - `[SchemaProvisioningTaskIdentifier <String>]`: 
  - `[SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
    - `[Editable <Boolean?>]`: 
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
        - `[SourceExpression <String>]`: 
        - `[SourceName <String>]`: 
        - `[SourceParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
          - `[Key <String>]`: 
          - `[ValueExpression <String>]`: 
          - `[ValueName <String>]`: 
          - `[ValueParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
          - `[ValueType <String>]`: attributeMappingSourceType
        - `[SourceType <String>]`: attributeMappingSourceType
        - `[TargetAttributeName <String>]`: 
      - `[Enabled <Boolean?>]`: 
      - `[FlowTypes <String>]`: objectFlowTypes
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[ScopeCategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
        - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
          - `[OperatorName <String>]`: 
          - `[SourceOperandName <String>]`: 
          - `[TargetOperandValues <String[]>]`: 
        - `[Name <String>]`: 
      - `[ScopeGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[ScopeInputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[SourceObjectName <String>]`: 
      - `[TargetObjectName <String>]`: 
    - `[Priority <Int32?>]`: 
    - `[SourceDirectoryName <String>]`: 
    - `[TargetDirectoryName <String>]`: 
  - `[SchemaVersion <String>]`: 
  - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
    - `[Code <String>]`: synchronizationStatusCode
    - `[CountSuccessiveCompleteFailures <Int64?>]`: 
    - `[EscrowsPruned <Boolean?>]`: 
    - `[LastExecutionActivityIdentifier <String>]`: 
    - `[LastExecutionCountEntitled <Int64?>]`: 
    - `[LastExecutionCountEntitledForProvisioning <Int64?>]`: 
    - `[LastExecutionCountEscrowed <Int64?>]`: 
    - `[LastExecutionCountEscrowedRaw <Int64?>]`: 
    - `[LastExecutionCountExported <Int64?>]`: 
    - `[LastExecutionCountExports <Int64?>]`: 
    - `[LastExecutionCountImported <Int64?>]`: 
    - `[LastExecutionCountImportedDeltas <Int64?>]`: 
    - `[LastExecutionCountImportedReferenceDeltas <Int64?>]`: 
    - `[LastExecutionErrorCode <String>]`: 
    - `[LastExecutionErrorMessage <String>]`: 
    - `[LastExecutionErrorTenantActionable <Boolean?>]`: 
    - `[LastExecutionState <String>]`: synchronizationTaskExecutionResult
    - `[LastExecutionTimeBegan <DateTime?>]`: 
    - `[LastExecutionTimeEnded <DateTime?>]`: 
    - `[LastSuccessfulExecutionActivityIdentifier <String>]`: 
    - `[LastSuccessfulExecutionCountEntitled <Int64?>]`: 
    - `[LastSuccessfulExecutionCountEntitledForProvisioning <Int64?>]`: 
    - `[LastSuccessfulExecutionCountEscrowed <Int64?>]`: 
    - `[LastSuccessfulExecutionCountEscrowedRaw <Int64?>]`: 
    - `[LastSuccessfulExecutionCountExported <Int64?>]`: 
    - `[LastSuccessfulExecutionCountExports <Int64?>]`: 
    - `[LastSuccessfulExecutionCountImported <Int64?>]`: 
    - `[LastSuccessfulExecutionCountImportedDeltas <Int64?>]`: 
    - `[LastSuccessfulExecutionCountImportedReferenceDeltas <Int64?>]`: 
    - `[LastSuccessfulExecutionErrorCode <String>]`: 
    - `[LastSuccessfulExecutionErrorMessage <String>]`: 
    - `[LastSuccessfulExecutionErrorTenantActionable <Boolean?>]`: 
    - `[LastSuccessfulExecutionState <String>]`: synchronizationTaskExecutionResult
    - `[LastSuccessfulExecutionTimeBegan <DateTime?>]`: 
    - `[LastSuccessfulExecutionTimeEnded <DateTime?>]`: 
    - `[LastSuccessfulExecutionWithExportActivityIdentifier <String>]`: 
    - `[LastSuccessfulExecutionWithExportCountEntitled <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountEntitledForProvisioning <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountEscrowed <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountEscrowedRaw <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountExported <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountExports <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountImported <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountImportedDeltas <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountImportedReferenceDeltas <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportState <String>]`: synchronizationTaskExecutionResult
    - `[LastSuccessfulExecutionWithExportTimeBegan <DateTime?>]`: 
    - `[LastSuccessfulExecutionWithExportTimeEnded <DateTime?>]`: 
    - `[LastSuccessfulExecutionWithExportsErrorCode <String>]`: 
    - `[LastSuccessfulExecutionWithExportsErrorMessage <String>]`: 
    - `[LastSuccessfulExecutionWithExportsErrorTenantActionable <Boolean?>]`: 
    - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: 
      - `[CompletedUnits <Int64?>]`: 
      - `[ProgressObservationDateTime <DateTime?>]`: 
      - `[TotalUnits <Int64?>]`: 
      - `[Units <String>]`: 
    - `[QuarantineCurrentBegan <DateTime?>]`: 
    - `[QuarantineNextAttempt <DateTime?>]`: 
    - `[QuarantineReason <String>]`: quarantineReason
    - `[QuarantineSeriesBegan <DateTime?>]`: 
    - `[QuarantineSeriesCount <Int64?>]`: 
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

#### INPUTOBJECT <IIdentityApplicationIdentity>: Identity Parameter
  - `[ApplicationId <String>]`: key: application-id of application
  - `[ApplicationTemplateId <String>]`: key: applicationTemplate-id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: claimsMappingPolicy-id of claimsMappingPolicy
  - `[DirectoryDefinitionId <String>]`: key: directoryDefinition-id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[ExtensionPropertyId <String>]`: key: extensionProperty-id of extensionProperty
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: homeRealmDiscoveryPolicy-id of homeRealmDiscoveryPolicy
  - `[SynchronizationJobId <String>]`: key: synchronizationJob-id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: synchronizationTemplate-id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: tokenIssuancePolicy-id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: tokenLifetimePolicy-id of tokenLifetimePolicy

#### SCHEMADIRECTORIES <IMicrosoftGraphDirectoryDefinition[]>: .
  - `[Id <String>]`: Read-only.
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
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
        - `[Key <String>]`: 
        - `[Value <String>]`: 
      - `[Multivalued <Boolean?>]`: 
      - `[Mutability <String>]`: mutability
      - `[Name <String>]`: 
      - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: 
        - `[ReferencedObjectName <String>]`: 
        - `[ReferencedProperty <String>]`: 
      - `[Required <Boolean?>]`: 
      - `[Type <String>]`: attributeType
    - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
    - `[Name <String>]`: 
    - `[SupportedApis <String[]>]`: 
  - `[ReadOnly <Boolean?>]`: 
  - `[Version <String>]`: 

#### SCHEMASYNCHRONIZATIONRULES <IMicrosoftGraphSynchronizationRule[]>: .
  - `[Editable <Boolean?>]`: 
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
      - `[SourceExpression <String>]`: 
      - `[SourceName <String>]`: 
      - `[SourceParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
        - `[Key <String>]`: 
        - `[ValueExpression <String>]`: 
        - `[ValueName <String>]`: 
        - `[ValueParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
        - `[ValueType <String>]`: attributeMappingSourceType
      - `[SourceType <String>]`: attributeMappingSourceType
      - `[TargetAttributeName <String>]`: 
    - `[Enabled <Boolean?>]`: 
    - `[FlowTypes <String>]`: objectFlowTypes
    - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Key <String>]`: 
      - `[Value <String>]`: 
    - `[Name <String>]`: 
    - `[ScopeCategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
        - `[OperatorName <String>]`: 
        - `[SourceOperandName <String>]`: 
        - `[TargetOperandValues <String[]>]`: 
      - `[Name <String>]`: 
    - `[ScopeGroups <IMicrosoftGraphFilterGroup[]>]`: 
    - `[ScopeInputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
    - `[SourceObjectName <String>]`: 
    - `[TargetObjectName <String>]`: 
  - `[Priority <Int32?>]`: 
  - `[SourceDirectoryName <String>]`: 
  - `[TargetDirectoryName <String>]`: 

#### STATUS <IMicrosoftGraphSynchronizationStatus>: synchronizationStatus
  - `[Code <String>]`: synchronizationStatusCode
  - `[CountSuccessiveCompleteFailures <Int64?>]`: 
  - `[EscrowsPruned <Boolean?>]`: 
  - `[LastExecutionActivityIdentifier <String>]`: 
  - `[LastExecutionCountEntitled <Int64?>]`: 
  - `[LastExecutionCountEntitledForProvisioning <Int64?>]`: 
  - `[LastExecutionCountEscrowed <Int64?>]`: 
  - `[LastExecutionCountEscrowedRaw <Int64?>]`: 
  - `[LastExecutionCountExported <Int64?>]`: 
  - `[LastExecutionCountExports <Int64?>]`: 
  - `[LastExecutionCountImported <Int64?>]`: 
  - `[LastExecutionCountImportedDeltas <Int64?>]`: 
  - `[LastExecutionCountImportedReferenceDeltas <Int64?>]`: 
  - `[LastExecutionErrorCode <String>]`: 
  - `[LastExecutionErrorMessage <String>]`: 
  - `[LastExecutionErrorTenantActionable <Boolean?>]`: 
  - `[LastExecutionState <String>]`: synchronizationTaskExecutionResult
  - `[LastExecutionTimeBegan <DateTime?>]`: 
  - `[LastExecutionTimeEnded <DateTime?>]`: 
  - `[LastSuccessfulExecutionActivityIdentifier <String>]`: 
  - `[LastSuccessfulExecutionCountEntitled <Int64?>]`: 
  - `[LastSuccessfulExecutionCountEntitledForProvisioning <Int64?>]`: 
  - `[LastSuccessfulExecutionCountEscrowed <Int64?>]`: 
  - `[LastSuccessfulExecutionCountEscrowedRaw <Int64?>]`: 
  - `[LastSuccessfulExecutionCountExported <Int64?>]`: 
  - `[LastSuccessfulExecutionCountExports <Int64?>]`: 
  - `[LastSuccessfulExecutionCountImported <Int64?>]`: 
  - `[LastSuccessfulExecutionCountImportedDeltas <Int64?>]`: 
  - `[LastSuccessfulExecutionCountImportedReferenceDeltas <Int64?>]`: 
  - `[LastSuccessfulExecutionErrorCode <String>]`: 
  - `[LastSuccessfulExecutionErrorMessage <String>]`: 
  - `[LastSuccessfulExecutionErrorTenantActionable <Boolean?>]`: 
  - `[LastSuccessfulExecutionState <String>]`: synchronizationTaskExecutionResult
  - `[LastSuccessfulExecutionTimeBegan <DateTime?>]`: 
  - `[LastSuccessfulExecutionTimeEnded <DateTime?>]`: 
  - `[LastSuccessfulExecutionWithExportActivityIdentifier <String>]`: 
  - `[LastSuccessfulExecutionWithExportCountEntitled <Int64?>]`: 
  - `[LastSuccessfulExecutionWithExportCountEntitledForProvisioning <Int64?>]`: 
  - `[LastSuccessfulExecutionWithExportCountEscrowed <Int64?>]`: 
  - `[LastSuccessfulExecutionWithExportCountEscrowedRaw <Int64?>]`: 
  - `[LastSuccessfulExecutionWithExportCountExported <Int64?>]`: 
  - `[LastSuccessfulExecutionWithExportCountExports <Int64?>]`: 
  - `[LastSuccessfulExecutionWithExportCountImported <Int64?>]`: 
  - `[LastSuccessfulExecutionWithExportCountImportedDeltas <Int64?>]`: 
  - `[LastSuccessfulExecutionWithExportCountImportedReferenceDeltas <Int64?>]`: 
  - `[LastSuccessfulExecutionWithExportState <String>]`: synchronizationTaskExecutionResult
  - `[LastSuccessfulExecutionWithExportTimeBegan <DateTime?>]`: 
  - `[LastSuccessfulExecutionWithExportTimeEnded <DateTime?>]`: 
  - `[LastSuccessfulExecutionWithExportsErrorCode <String>]`: 
  - `[LastSuccessfulExecutionWithExportsErrorMessage <String>]`: 
  - `[LastSuccessfulExecutionWithExportsErrorTenantActionable <Boolean?>]`: 
  - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: 
    - `[CompletedUnits <Int64?>]`: 
    - `[ProgressObservationDateTime <DateTime?>]`: 
    - `[TotalUnits <Int64?>]`: 
    - `[Units <String>]`: 
  - `[QuarantineCurrentBegan <DateTime?>]`: 
  - `[QuarantineNextAttempt <DateTime?>]`: 
  - `[QuarantineReason <String>]`: quarantineReason
  - `[QuarantineSeriesBegan <DateTime?>]`: 
  - `[QuarantineSeriesCount <Int64?>]`: 
  - `[SteadyStateFirstAchievedTime <DateTime?>]`: 
  - `[SteadyStateLastAchievedTime <DateTime?>]`: 
  - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: 
    - `[Key <String>]`: 
    - `[Value <Int64?>]`: 
  - `[TroubleshootingUrl <String>]`: 

#### SYNCHRONIZATIONJOBSETTINGS <IMicrosoftGraphKeyValuePair[]>: .
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

## RELATED LINKS

