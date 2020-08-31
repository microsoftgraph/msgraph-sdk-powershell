---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/update-mgapplicationsynchronization
schema: 2.0.0
---

# Update-MgApplicationSynchronization

## SYNOPSIS
Update the navigation property synchronization in applications

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgApplicationSynchronization -ApplicationId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Jobs <IMicrosoftGraphSynchronizationJob[]>]
 [-Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]
 [-Templates <IMicrosoftGraphSynchronizationTemplate[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgApplicationSynchronization -ApplicationId <String> -BodyParameter <IMicrosoftGraphSynchronization>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgApplicationSynchronization -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphSynchronization> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgApplicationSynchronization -InputObject <IApplicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-Jobs <IMicrosoftGraphSynchronizationJob[]>]
 [-Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]
 [-Templates <IMicrosoftGraphSynchronizationTemplate[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property synchronization in applications

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

### -ApplicationId
key: id of application

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

### -BodyParameter
synchronization
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronization
Parameter Sets: Update, UpdateViaIdentity
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

### -Jobs
.
To construct, see NOTES section for JOBS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationJob[]
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

### -Secrets
.
To construct, see NOTES section for SECRETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronization

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSynchronization>: synchronization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Expiration <DateTime?>]`: 
      - `[Interval <TimeSpan?>]`: 
      - `[State <String>]`: synchronizationScheduleState
    - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: 
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
            - `[FlowNullValues <Boolean?>]`: 
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
      - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
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
          - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
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
    - `[Id <String>]`: Read-only.
    - `[ApplicationId <String>]`: 
    - `[Default <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[Discoverable <Boolean?>]`: 
    - `[FactoryTag <String>]`: 
    - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
    - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[GroupId <String>]`: key: id of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OnPremisesAgentGroupId <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: id of onPremisesAgent
  - `[OnPremisesAgentId1 <String>]`: key: id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: id of publishedResource
  - `[PublishedResourceId1 <String>]`: key: id of publishedResource
  - `[ServicePrincipalId <String>]`: key: id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[UserId <String>]`: key: id of user

JOBS <IMicrosoftGraphSynchronizationJob[]>: .
  - `[Id <String>]`: Read-only.
  - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Expiration <DateTime?>]`: 
    - `[Interval <TimeSpan?>]`: 
    - `[State <String>]`: synchronizationScheduleState
  - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: 
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
          - `[FlowNullValues <Boolean?>]`: 
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
    - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
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
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
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

SECRETS <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>: .
  - `[Key <String>]`: synchronizationSecret
  - `[Value <String>]`: 

TEMPLATES <IMicrosoftGraphSynchronizationTemplate[]>: .
  - `[Id <String>]`: Read-only.
  - `[ApplicationId <String>]`: 
  - `[Default <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[Discoverable <Boolean?>]`: 
  - `[FactoryTag <String>]`: 
  - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
    - `[Key <String>]`: 
    - `[Value <String>]`: 
  - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: 
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
          - `[FlowNullValues <Boolean?>]`: 
          - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
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
    - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
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
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
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

