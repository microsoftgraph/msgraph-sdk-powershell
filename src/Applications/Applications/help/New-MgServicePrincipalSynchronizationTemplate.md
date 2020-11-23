---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgserviceprincipalsynchronizationtemplate
schema: 2.0.0
---

# New-MgServicePrincipalSynchronizationTemplate

## SYNOPSIS
Create new navigation property to templates for servicePrincipals

## SYNTAX

### CreateExpanded (Default)
```
New-MgServicePrincipalSynchronizationTemplate -ServicePrincipalId <String> [-AdditionalProperties <Hashtable>]
 [-ApplicationId <String>] [-Default] [-Description <String>] [-Discoverable] [-FactoryTag <String>]
 [-Id <String>] [-Metadata <IMicrosoftGraphMetadataEntry[]>] [-Schema <IMicrosoftGraphSynchronizationSchema>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgServicePrincipalSynchronizationTemplate -ServicePrincipalId <String>
 -BodyParameter <IMicrosoftGraphSynchronizationTemplate> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgServicePrincipalSynchronizationTemplate -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-ApplicationId <String>] [-Default] [-Description <String>]
 [-Discoverable] [-FactoryTag <String>] [-Id <String>] [-Metadata <IMicrosoftGraphMetadataEntry[]>]
 [-Schema <IMicrosoftGraphSynchronizationSchema>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgServicePrincipalSynchronizationTemplate -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphSynchronizationTemplate> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to templates for servicePrincipals

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

### -ApplicationId
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

### -BodyParameter
synchronizationTemplate
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphSynchronizationTemplate
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Default
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
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

### -Discoverable
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -FactoryTag
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

### -Metadata
.
To construct, see NOTES section for METADATA properties and create a hash table.

```yaml
Type: IMicrosoftGraphMetadataEntry[]
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationTemplate
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationTemplate
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphSynchronizationTemplate\>: synchronizationTemplate
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ApplicationId \<String\>\]: 
  \[Default \<Boolean?\>\]: 
  \[Description \<String\>\]: 
  \[Discoverable \<Boolean?\>\]: 
  \[FactoryTag \<String\>\]: 
  \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
    \[Key \<String\>\]: 
    \[Value \<String\>\]: 
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

METADATA \<IMicrosoftGraphMetadataEntry\[\]\>: .
  \[Key \<String\>\]: 
  \[Value \<String\>\]: 

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

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgserviceprincipalsynchronizationtemplate](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgserviceprincipalsynchronizationtemplate)

