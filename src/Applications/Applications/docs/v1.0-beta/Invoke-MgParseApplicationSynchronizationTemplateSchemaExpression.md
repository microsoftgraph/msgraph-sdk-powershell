---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/invoke-mgparseapplicationsynchronizationtemplateschemaexpression
schema: 2.0.0
---

# Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression

## SYNOPSIS
Invoke action parseExpression

## SYNTAX

### ParseExpanded (Default)
```
Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression -ApplicationId <String>
 -SynchronizationTemplateId <String> [-AdditionalProperties <Hashtable>] [-Expression <String>]
 [-TargetAttributeDefinition <IMicrosoftGraphAttributeDefinition>]
 [-TestInputObject <IMicrosoftGraphExpressionInputObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Parse
```
Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression -ApplicationId <String>
 -SynchronizationTemplateId <String>
 -BodyParameter <IPaths1Ukm6NrApplicationsApplicationIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ParseViaIdentityExpanded
```
Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Expression <String>]
 [-TargetAttributeDefinition <IMicrosoftGraphAttributeDefinition>]
 [-TestInputObject <IMicrosoftGraphExpressionInputObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ParseViaIdentity
```
Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression -InputObject <IApplicationsIdentity>
 -BodyParameter <IPaths1Ukm6NrApplicationsApplicationIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action parseExpression

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
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
Type: String
Parameter Sets: ParseExpanded, Parse
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IPaths1Ukm6NrApplicationsApplicationIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Parse, ParseViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Expression
.

```yaml
Type: String
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
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
Parameter Sets: ParseViaIdentityExpanded, ParseViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SynchronizationTemplateId
key: id of synchronizationTemplate

```yaml
Type: String
Parameter Sets: ParseExpanded, Parse
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetAttributeDefinition
attributeDefinition
To construct, see NOTES section for TARGETATTRIBUTEDEFINITION properties and create a hash table.

```yaml
Type: IMicrosoftGraphAttributeDefinition
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TestInputObject
expressionInputObject
To construct, see NOTES section for TESTINPUTOBJECT properties and create a hash table.

```yaml
Type: IMicrosoftGraphExpressionInputObject
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1Ukm6NrApplicationsApplicationIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParseExpressionResponse

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Ukm6NrApplicationsApplicationIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Expression <String>]`: 
  - `[TargetAttributeDefinition <IMicrosoftGraphAttributeDefinition>]`: attributeDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
  - `[TestInputObject <IMicrosoftGraphExpressionInputObject>]`: expressionInputObject
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Definition <IMicrosoftGraphObjectDefinition>]`: objectDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[SupportedApis <String[]>]`: 
    - `[Properties <IMicrosoftGraphStringKeyObjectValuePair[]>]`: Property values of the test object.
      - `[Key <String>]`: Key.

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DelegatedPermissionClassificationId <String>]`: key: id of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[GroupId <String>]`: key: id of group
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
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
  - `[UserId <String>]`: key: id of user

TARGETATTRIBUTEDEFINITION <IMicrosoftGraphAttributeDefinition>: attributeDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

TESTINPUTOBJECT <IMicrosoftGraphExpressionInputObject>: expressionInputObject
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Definition <IMicrosoftGraphObjectDefinition>]`: objectDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
  - `[Properties <IMicrosoftGraphStringKeyObjectValuePair[]>]`: Property values of the test object.
    - `[Key <String>]`: Key.

## RELATED LINKS

## RELATED LINKS
